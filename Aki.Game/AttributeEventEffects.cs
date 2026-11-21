using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;
using UnrealEngine;

// Token: 0x0200244C RID: 9292
[NullableContext(1)]
[Nullable(0)]
public class AttributeEventEffects : BuffEffect
{
	// Token: 0x06017407 RID: 95239 RVA: 0x006D5D24 File Offset: 0x006D3F24
	public AttributeEventEffects(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017408 RID: 95240 RVA: 0x006D5D54 File Offset: 0x006D3F54
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		float[] extraEffectGrowParameters2 = parameters.ExtraEffectGrowParameters2;
		int level = this.Level;
		EAttributeType listenId = (EAttributeType)int.Parse(extraEffectParameters_[0]);
		bool isPerTenThousandth = int.Parse(extraEffectParameters_[1]) == 1;
		float lowerBound = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, level, -1f);
		float upperBound = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, level, -1f);
		this.IntervalTrigger = new AttributeIntervalCheck(listenId, lowerBound, upperBound, isPerTenThousandth);
		this.GoalType = (EPassiveEffectGoalType)int.Parse(extraEffectParameters_[2]);
		this.Ids = extraEffectParameters_[3].Split('#', StringSplitOptions.None);
		int num = 0;
		if (extraEffectParameters_.Length > 4)
		{
			int.TryParse(extraEffectParameters_[4], out num);
		}
		this.RemoveBuffAndTagIfOutOfBound = (num == 1);
		int num2 = 0;
		if (extraEffectParameters_.Length > 5)
		{
			int.TryParse(extraEffectParameters_[5], out num2);
		}
		EAttributeEventTargetType eattributeEventTargetType = (EAttributeEventTargetType)num2;
		if (eattributeEventTargetType != EAttributeEventTargetType.Owner && eattributeEventTargetType == EAttributeEventTargetType.Instigator)
		{
			this.ListenTargetType = EPassiveEffectTargetType.ForBuffInstigator;
		}
		else
		{
			this.ListenTargetType = EPassiveEffectTargetType.ForSelf;
		}
		int num3 = 0;
		if (extraEffectParameters_.Length > 6)
		{
			int.TryParse(extraEffectParameters_[6], out num3);
		}
		EAttributeEventTargetType eattributeEventTargetType2 = (EAttributeEventTargetType)num3;
		if (eattributeEventTargetType2 != EAttributeEventTargetType.Owner && eattributeEventTargetType2 == EAttributeEventTargetType.Instigator)
		{
			this.TargetType = EPassiveEffectTargetType.ForBuffInstigator;
			return;
		}
		this.TargetType = EPassiveEffectTargetType.ForSelf;
	}

	// Token: 0x06017409 RID: 95241 RVA: 0x006D5E60 File Offset: 0x006D4060
	public unsafe override void OnCreated()
	{
		Entity listenTarget = this.GetListenTarget();
		if (listenTarget == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "Invalid listen target when add extra effect attribute event";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.ActiveHandleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instigator id", this.InstigatorEntityId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "instigator name";
			CharacterBuffComponent instigatorBuffComponent = base.InstigatorBuffComponent;
			object item2;
			if (instigatorBuffComponent == null)
			{
				item2 = null;
			}
			else
			{
				BaseActorComponent actorComponent = instigatorBuffComponent.GetActorComponent();
				item2 = ((actorComponent != null) ? actorComponent.Owner : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item3 = "owner id";
			Entity ownerEntity = base.OwnerEntity;
			ptr2 = new ValueTuple<string, object>(item3, (ownerEntity != null) ? new int?(ownerEntity.Id) : null);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
			string item4 = "owner name";
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			object item5;
			if (ownerBuffComponent == null)
			{
				item5 = null;
			}
			else
			{
				BaseActorComponent actorComponent2 = ownerBuffComponent.GetActorComponent();
				item5 = ((actorComponent2 != null) ? actorComponent2.Owner : null);
			}
			ptr3 = new ValueTuple<string, object>(item4, item5);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("listen type", this.ListenTargetType);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return;
		}
		this.ListenAttributeComponent = listenTarget.GetComponent<BaseAttributeComponent>();
		if (this.ListenAttributeComponent == null)
		{
			return;
		}
		if (this.IntervalTrigger.IsPerTenThousand && this.IntervalTrigger.MaxAttributeId == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "Buff额外效果6 监听属性变化到特定区间，基于相对最大值的万分比，但是监听的属性没有对应的最大值属性，该效果无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("buff Id", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("属性Id", this.IntervalTrigger.ListenAttributeId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		EAttributeType listenAttributeId = this.IntervalTrigger.ListenAttributeId;
		float currentValue = this.ListenAttributeComponent.GetCurrentValue(listenAttributeId);
		this.OnAttributeChanged(listenAttributeId, currentValue, currentValue);
		this.ListenAttributeComponent.AddListener(listenAttributeId, new Action<EAttributeType, float, float>(this.OnAttributeChanged), "ExtraEffectAttributeEvent");
	}

	// Token: 0x0601740A RID: 95242 RVA: 0x006D6094 File Offset: 0x006D4294
	public override void OnRemoved(bool bPremature)
	{
		if (this.ListenAttributeComponent != null)
		{
			this.ListenAttributeComponent.RemoveListener(this.IntervalTrigger.ListenAttributeId, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
		}
		if (this.GoalType == EPassiveEffectGoalType.AddTag && this.AddedTagCounts.Count > 0)
		{
			Entity ownerEntity = base.OwnerEntity;
			BaseTagComponent baseTagComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseTagComponent>() : null;
			foreach (KeyValuePair<int, int> keyValuePair in this.AddedTagCounts)
			{
				if (baseTagComponent != null)
				{
					baseTagComponent.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, keyValuePair.Key, -keyValuePair.Value);
				}
			}
			this.AddedTagCounts.Clear();
		}
	}

	// Token: 0x0601740B RID: 95243 RVA: 0x006D6160 File Offset: 0x006D4360
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x0601740C RID: 95244 RVA: 0x006D6174 File Offset: 0x006D4374
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		if (!this.IsActivated)
		{
			return null;
		}
		switch (this.GoalType)
		{
		case EPassiveEffectGoalType.Buff:
			this.ExecuteAddBuffs();
			break;
		case EPassiveEffectGoalType.Bullet:
			this.ExecuteAddBullet();
			break;
		case EPassiveEffectGoalType.AddTag:
			this.ExecuteAddOrRemoveTags(true);
			break;
		}
		return null;
	}

	// Token: 0x0601740D RID: 95245 RVA: 0x006D61C4 File Offset: 0x006D43C4
	[NullableContext(2)]
	private Entity GetListenTarget()
	{
		EPassiveEffectTargetType listenTargetType = this.ListenTargetType;
		if (listenTargetType == EPassiveEffectTargetType.ForSelf || listenTargetType != EPassiveEffectTargetType.ForBuffInstigator)
		{
			return base.OwnerEntity;
		}
		EntityHandle instigatorEntity = base.InstigatorEntity;
		if (instigatorEntity == null)
		{
			return null;
		}
		return instigatorEntity.Entity;
	}

	// Token: 0x0601740E RID: 95246 RVA: 0x006D61F8 File Offset: 0x006D43F8
	[NullableContext(2)]
	protected IBuffComponent GetEffectTarget()
	{
		EPassiveEffectTargetType targetType = this.TargetType;
		if (targetType != EPassiveEffectTargetType.ForSelf && targetType == EPassiveEffectTargetType.ForBuffInstigator)
		{
			return base.InstigatorBuffComponent;
		}
		return this.OwnerBuffComponent;
	}

	// Token: 0x0601740F RID: 95247 RVA: 0x006D6220 File Offset: 0x006D4420
	private void ExecuteInactive()
	{
		switch (this.GoalType)
		{
		case EPassiveEffectGoalType.Buff:
			if (this.RemoveBuffAndTagIfOutOfBound)
			{
				foreach (int num in this.TriggeredActiveHandles)
				{
					IBuffComponent effectTarget = this.GetEffectTarget();
					if (effectTarget != null)
					{
						int handle = num;
						int removeStackCount = -1;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
						defaultInterpolatedStringHandler.AppendLiteral("因为其它buff属性监听额外效果而移除（前置buff Id=");
						defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
						defaultInterpolatedStringHandler.AppendLiteral(", handle=");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
						defaultInterpolatedStringHandler.AppendLiteral("）");
						effectTarget.RemoveBuffByHandle(handle, removeStackCount, defaultInterpolatedStringHandler.ToStringAndClear(), null, null, null);
					}
				}
			}
			this.TriggeredActiveHandles.Clear();
			return;
		case EPassiveEffectGoalType.Bullet:
		case EPassiveEffectGoalType.RemoveBuff:
			break;
		case EPassiveEffectGoalType.AddTag:
			if (this.RemoveBuffAndTagIfOutOfBound)
			{
				this.ExecuteAddOrRemoveTags(false);
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06017410 RID: 95248 RVA: 0x006D6338 File Offset: 0x006D4538
	protected void ExecuteAddBuffs()
	{
		IBuffComponent effectTarget = this.GetEffectTarget();
		if (!this.CheckExecutable() || effectTarget == null)
		{
			return;
		}
		for (int i = 0; i < this.Ids.Length; i++)
		{
			long num = long.Parse(this.Ids[i]);
			int value = (int)AbilityUtils.GetArrayValue(this.Times, i, 0.0);
			IBuffComponent buffComponent = effectTarget;
			long buffId = num;
			AddBuffParam addBuffParam = new AddBuffParam();
			addBuffParam.InstigatorId = base.InstigatorBuffComponent.CreatureDataId;
			addBuffParam.Level = new int?(this.Level);
			addBuffParam.OuterStackCount = new int?(value);
			addBuffParam.PreMessageId = base.Buff.MessageId;
			addBuffParam.ServerId = new int?(this.ServerId);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
			defaultInterpolatedStringHandler.AppendLiteral("因为其它buff额外效果而添加（前置buff Id=");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
			defaultInterpolatedStringHandler.AppendLiteral(", handle=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
			defaultInterpolatedStringHandler.AppendLiteral("）");
			addBuffParam.Reason = defaultInterpolatedStringHandler.ToStringAndClear();
			int num2 = buffComponent.AddBuffLocal(buffId, addBuffParam);
			if (this.RemoveBuffAndTagIfOutOfBound && num2 > 0)
			{
				this.TriggeredActiveHandles.Add(num2);
			}
		}
	}

	// Token: 0x06017411 RID: 95249 RVA: 0x006D6464 File Offset: 0x006D4664
	protected void ExecuteAddBullet()
	{
		IBuffComponent effectTarget = this.GetEffectTarget();
		BaseActorComponent baseActorComponent = (effectTarget != null) ? effectTarget.GetActorComponent() : null;
		FTransformDouble? initialTransform = (baseActorComponent != null) ? new FTransformDouble?(baseActorComponent.ActorTransform) : null;
		EntityHandle instigatorEntity = base.InstigatorEntity;
		Entity entity = (baseActorComponent != null) ? baseActorComponent.Entity : null;
		if (initialTransform == null || instigatorEntity == null || entity == null)
		{
			return;
		}
		for (int i = 0; i < this.Ids.Length; i++)
		{
			string bulletRowName = this.Ids[i];
			int num = (int)AbilityUtils.GetArrayValue(this.Times, i, 1.0);
			long? messageId = base.Buff.MessageId;
			for (int j = 0; j < num; j++)
			{
				BulletController.Instance.CreateBulletCustomTarget(entity, bulletRowName, initialTransform, new BulletController.BulletCreateParams
				{
					SyncType = EBulletSyncType.SyncCreate,
					CreateOnAuthority = false
				}, messageId, global::EBulletCreateSource.Others);
			}
		}
	}

	// Token: 0x06017412 RID: 95250 RVA: 0x006D6540 File Offset: 0x006D4740
	protected void ExecuteAddOrRemoveTags(bool isAdd)
	{
		IBuffComponent effectTarget = this.GetEffectTarget();
		if (!this.CheckExecutable() || effectTarget == null)
		{
			return;
		}
		int num = isAdd ? 1 : -1;
		for (int i = 0; i < this.Ids.Length; i++)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(this.Ids[i]);
			Entity ownerEntity = base.OwnerEntity;
			BaseTagComponent baseTagComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				baseTagComponent.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, tagIdByName, num);
			}
			int num3;
			int num2 = (this.AddedTagCounts.TryGetValue(tagIdByName, out num3) ? num3 : 0) + num;
			if (num2 <= 0)
			{
				this.AddedTagCounts.Remove(tagIdByName);
			}
			else
			{
				this.AddedTagCounts[tagIdByName] = num2;
			}
		}
	}

	// Token: 0x06017413 RID: 95251 RVA: 0x006D65EC File Offset: 0x006D47EC
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		bool isActivated = this.IsActivated;
		this.IsActivated = this.IntervalTrigger.CheckListenActiveness(newValue, this.ListenAttributeComponent);
		if (isActivated != this.IsActivated)
		{
			if (this.IsActivated)
			{
				base.TryExecute(new Partial_RequirementPayload(), this.OwnerBuffComponent, Array.Empty<object>());
				return;
			}
			this.ExecuteInactive();
		}
	}

	// Token: 0x06017414 RID: 95252 RVA: 0x006D6645 File Offset: 0x006D4845
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C45A RID: 50266
	public EPassiveEffectTargetType TargetType;

	// Token: 0x0400C45B RID: 50267
	public EPassiveEffectGoalType GoalType;

	// Token: 0x0400C45C RID: 50268
	public string[] Ids = Array.Empty<string>();

	// Token: 0x0400C45D RID: 50269
	[Nullable(2)]
	public double[] Times;

	// Token: 0x0400C45E RID: 50270
	[Nullable(2)]
	private AttributeIntervalCheck IntervalTrigger;

	// Token: 0x0400C45F RID: 50271
	[Nullable(2)]
	private BaseAttributeComponent ListenAttributeComponent;

	// Token: 0x0400C460 RID: 50272
	private bool RemoveBuffAndTagIfOutOfBound;

	// Token: 0x0400C461 RID: 50273
	private bool IsActivated;

	// Token: 0x0400C462 RID: 50274
	private readonly Dictionary<int, int> AddedTagCounts = new Dictionary<int, int>();

	// Token: 0x0400C463 RID: 50275
	private readonly List<int> TriggeredActiveHandles = new List<int>();

	// Token: 0x0400C464 RID: 50276
	private EPassiveEffectTargetType ListenTargetType;
}
