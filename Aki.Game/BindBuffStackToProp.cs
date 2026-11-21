using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020024D4 RID: 9428
[NullableContext(1)]
[Nullable(0)]
public class BindBuffStackToProp : BuffEffect
{
	// Token: 0x06017668 RID: 95848 RVA: 0x006E4527 File Offset: 0x006E2727
	public BindBuffStackToProp(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017669 RID: 95849 RVA: 0x006E4550 File Offset: 0x006E2750
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 3)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.GHY;
			string message = "BindBuffStackToProp 参数不足（至少需要 param0/param1/param2）";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.PropSystem = (EPropSystemType)BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 0, 0);
		this.AttributeId = BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 1, 0);
		string[] array = ((extraEffectParameters_.Length > 2) ? (extraEffectParameters_[2] ?? "") : "").Split('#', StringSplitOptions.None);
		this.BuffIds = new List<long>();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != "")
			{
				this.BuffIds.Add(long.Parse(array[i]));
			}
		}
		this.CleanBuffsOnRemoved = (BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 3, 0) == 0);
		this.RefreshOnRevive = (BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 4, 0) == 0);
	}

	// Token: 0x0601766A RID: 95850 RVA: 0x006E463A File Offset: 0x006E283A
	private static int ParseIntOr(string[] baseParams, int index, int defaultValue)
	{
		if (index < baseParams.Length && !string.IsNullOrEmpty(baseParams[index]))
		{
			return int.Parse(baseParams[index]);
		}
		return defaultValue;
	}

	// Token: 0x0601766B RID: 95851 RVA: 0x006E4658 File Offset: 0x006E2858
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || !ownerBuffComponent.HasBuffAuthority() || this.BuffIds.Count == 0)
		{
			return;
		}
		if (this.PropSystem == EPropSystemType.Squad)
		{
			SquadPropComponent byEntity = SquadPropComponent.GetByEntity(base.OwnerEntity);
			if (byEntity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				string message = "[BindBuffStackToProp] 小队属性组件缺失，未注册监听";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			byEntity.AddListener((ESquadAttributeType)this.AttributeId, new SquadAttrChangeListener(this.OnSquadAttributeChanged));
			this.AlignBuffs(byEntity.GetCurrentValue((ESquadAttributeType)this.AttributeId));
		}
		else
		{
			Entity ownerEntity = base.OwnerEntity;
			BaseAttributeComponent baseAttributeComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.GHY;
				string message2 = "[BindBuffStackToProp] 角色属性组件缺失，未注册监听";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("buffId", this.BuffId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			baseAttributeComponent.AddListener((EAttributeType)this.AttributeId, new Action<EAttributeType, float, float>(this.OnCharacterAttributeChanged), "BindBuffStackToProp");
			this.AlignBuffs(baseAttributeComponent.GetCurrentValue((EAttributeType)this.AttributeId));
		}
		if (this.RefreshOnRevive && base.OwnerEntity != null)
		{
			BaseBuffComponent baseBuffComponent = this.OwnerBuffComponent as BaseBuffComponent;
			if (baseBuffComponent != null && baseBuffComponent.IsRoleBuffComponent())
			{
				EventSystem.Instance.AddWithTarget(base.OwnerEntity, EEventName.CharOnRevive, new Action(this.OnRevive));
				this.ReviveListened = true;
			}
		}
	}

	// Token: 0x0601766C RID: 95852 RVA: 0x006E47C5 File Offset: 0x006E29C5
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601766D RID: 95853 RVA: 0x006E47C8 File Offset: 0x006E29C8
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || !ownerBuffComponent.HasBuffAuthority() || this.BuffIds.Count == 0)
		{
			return;
		}
		if (this.PropSystem == EPropSystemType.Squad)
		{
			SquadPropComponent byEntity = SquadPropComponent.GetByEntity(base.OwnerEntity);
			if (byEntity != null)
			{
				byEntity.RemoveListener((ESquadAttributeType)this.AttributeId, new SquadAttrChangeListener(this.OnSquadAttributeChanged));
			}
		}
		else
		{
			Entity ownerEntity = base.OwnerEntity;
			BaseAttributeComponent baseAttributeComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent != null)
			{
				baseAttributeComponent.RemoveListener((EAttributeType)this.AttributeId, new Action<EAttributeType, float, float>(this.OnCharacterAttributeChanged));
			}
		}
		if (this.ReviveListened && base.OwnerEntity != null)
		{
			EventSystem.Instance.RemoveWithTarget(base.OwnerEntity, EEventName.CharOnRevive, new Action(this.OnRevive));
			this.ReviveListened = false;
		}
		if (this.CleanBuffsOnRemoved)
		{
			this.AlignBuffs(0f);
		}
	}

	// Token: 0x0601766E RID: 95854 RVA: 0x006E48A6 File Offset: 0x006E2AA6
	private void OnSquadAttributeChanged(ESquadAttributeType attrId, float newValue, float oldValue)
	{
		this.AlignBuffs(newValue);
	}

	// Token: 0x0601766F RID: 95855 RVA: 0x006E48AF File Offset: 0x006E2AAF
	private void OnCharacterAttributeChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		this.AlignBuffs(newValue);
	}

	// Token: 0x06017670 RID: 95856 RVA: 0x006E48B8 File Offset: 0x006E2AB8
	private void OnRevive()
	{
		float? currentPropValue = this.GetCurrentPropValue();
		if (currentPropValue != null)
		{
			this.AlignBuffs(currentPropValue.Value);
		}
	}

	// Token: 0x06017671 RID: 95857 RVA: 0x006E48E4 File Offset: 0x006E2AE4
	protected float? GetCurrentPropValue()
	{
		EPropSystemType propSystem = this.PropSystem;
		if (propSystem != EPropSystemType.Character)
		{
			if (propSystem != EPropSystemType.Squad)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.GHY;
				string message = "[BindBuffStackToProp] 未处理的属性系统类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("propSystem", this.PropSystem);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			SquadPropComponent byEntity = SquadPropComponent.GetByEntity(base.OwnerEntity);
			if (byEntity == null)
			{
				return null;
			}
			return new float?(byEntity.GetCurrentValue((ESquadAttributeType)this.AttributeId));
		}
		else
		{
			Entity ownerEntity = base.OwnerEntity;
			if (ownerEntity == null)
			{
				return null;
			}
			BaseAttributeComponent baseAttributeComponent = ownerEntity.CheckGetComponent<BaseAttributeComponent>();
			if (baseAttributeComponent == null)
			{
				return null;
			}
			return new float?(baseAttributeComponent.GetCurrentValue((EAttributeType)this.AttributeId));
		}
	}

	// Token: 0x06017672 RID: 95858 RVA: 0x006E499C File Offset: 0x006E2B9C
	protected void AlignBuffs(float propValue)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || !ownerBuffComponent.HasBuffAuthority())
		{
			return;
		}
		int num = Math.Max(0, (int)Math.Floor((double)propValue));
		foreach (long buffId in this.BuffIds)
		{
			int? buffMaxStack = this.GetBuffMaxStack(buffId);
			int num2 = (buffMaxStack == null) ? num : Math.Min(num, buffMaxStack.Value);
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
			PlayerBuffComponent playerBuffComponent;
			if (buffDefinition == null || buffDefinition.FormationPolicy != EBuffFormationPolicy.FormationBuff)
			{
				playerBuffComponent = null;
			}
			else
			{
				RoleBuffComponent roleBuffComponent = ownerBuffComponent as RoleBuffComponent;
				playerBuffComponent = ((roleBuffComponent != null) ? roleBuffComponent.GetFormationBuffComp() : null);
			}
			PlayerBuffComponent playerBuffComponent2 = playerBuffComponent;
			int num3 = (playerBuffComponent2 != null) ? playerBuffComponent2.GetFormationBuffTotalStackById(buffId, false) : ownerBuffComponent.GetBuffTotalStackById(buffId, false);
			if (num3 != num2)
			{
				if (num3 < num2)
				{
					this.AddStack(buffId, num2 - num3);
				}
				else
				{
					ownerBuffComponent.RemoveBuff(buffId, num3 - num2, "BindBuffStackToProp 对齐属性值减层", null, null, null);
				}
			}
		}
	}

	// Token: 0x06017673 RID: 95859 RVA: 0x006E4ACC File Offset: 0x006E2CCC
	protected void AddStack(long buffId, int addCount)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null || addCount <= 0)
		{
			return;
		}
		IBuffComponent buffComponent = ownerBuffComponent;
		IActiveBuff buff = base.Buff;
		int? stackCount = new int?(addCount);
		bool isIterable = true;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 1);
		defaultInterpolatedStringHandler.AppendLiteral("BindBuffStackToProp 对齐属性值补层（前置buffId=");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral("）");
		buffComponent.AddIterativeBuff(buffId, buff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
	}

	// Token: 0x06017674 RID: 95860 RVA: 0x006E4B3C File Offset: 0x006E2D3C
	protected int? GetBuffMaxStack(long buffId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		if (buffDefinition == null || buffDefinition.StackLimitCount <= 0)
		{
			return null;
		}
		return new int?(buffDefinition.StackLimitCount);
	}

	// Token: 0x06017675 RID: 95861 RVA: 0x006E4B78 File Offset: 0x006E2D78
	public override string GetDebugEffectString()
	{
		string value = (this.PropSystem == EPropSystemType.Squad) ? "小队共享属性" : "角色属性";
		string value2 = string.Join<long>(",", this.BuffIds);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 5);
		defaultInterpolatedStringHandler.AppendLiteral("绑定buff层数到");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("] buffIds[");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("] 移除时清理buff[");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.CleanBuffsOnRemoved);
		defaultInterpolatedStringHandler.AppendLiteral("] 复活刷新[");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.RefreshOnRevive);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C6C2 RID: 50882
	protected EPropSystemType PropSystem;

	// Token: 0x0400C6C3 RID: 50883
	protected int AttributeId;

	// Token: 0x0400C6C4 RID: 50884
	protected List<long> BuffIds = new List<long>();

	// Token: 0x0400C6C5 RID: 50885
	protected bool CleanBuffsOnRemoved = true;

	// Token: 0x0400C6C6 RID: 50886
	protected bool RefreshOnRevive = true;

	// Token: 0x0400C6C7 RID: 50887
	private bool ReviveListened;
}
