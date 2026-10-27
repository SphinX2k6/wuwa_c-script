using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F80 RID: 12160
[NullableContext(1)]
[Nullable(0)]
public class BindBuffStackToProp : BuffEffect
{
	// Token: 0x06019D56 RID: 105814 RVA: 0x006BDC17 File Offset: 0x006BBE17
	public BindBuffStackToProp(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019D57 RID: 105815 RVA: 0x006BDC40 File Offset: 0x006BBE40
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
		this.BuffIds = (from seg in ((extraEffectParameters_.Length > 2) ? (extraEffectParameters_[2] ?? "") : "").Split('#', StringSplitOptions.None)
		where seg != ""
		select long.Parse(seg)).ToList<long>();
		this.CleanBuffsOnRemoved = (BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 3, 0) == 0);
		this.RefreshOnRevive = (BindBuffStackToProp.ParseIntOr(extraEffectParameters_, 4, 0) == 0);
	}

	// Token: 0x06019D58 RID: 105816 RVA: 0x006BDD41 File Offset: 0x006BBF41
	private static int ParseIntOr(string[] baseParams, int index, int defaultValue)
	{
		if (index < baseParams.Length && !string.IsNullOrEmpty(baseParams[index]))
		{
			return int.Parse(baseParams[index]);
		}
		return defaultValue;
	}

	// Token: 0x06019D59 RID: 105817 RVA: 0x006BDD60 File Offset: 0x006BBF60
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

	// Token: 0x06019D5A RID: 105818 RVA: 0x006BDECD File Offset: 0x006BC0CD
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019D5B RID: 105819 RVA: 0x006BDED0 File Offset: 0x006BC0D0
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

	// Token: 0x06019D5C RID: 105820 RVA: 0x006BDFAE File Offset: 0x006BC1AE
	private void OnSquadAttributeChanged(ESquadAttributeType attrId, float newValue, float oldValue)
	{
		this.AlignBuffs(newValue);
	}

	// Token: 0x06019D5D RID: 105821 RVA: 0x006BDFB7 File Offset: 0x006BC1B7
	private void OnCharacterAttributeChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		this.AlignBuffs(newValue);
	}

	// Token: 0x06019D5E RID: 105822 RVA: 0x006BDFC0 File Offset: 0x006BC1C0
	private void OnRevive()
	{
		float? currentPropValue = this.GetCurrentPropValue();
		if (currentPropValue != null)
		{
			this.AlignBuffs(currentPropValue.Value);
		}
	}

	// Token: 0x06019D5F RID: 105823 RVA: 0x006BDFEC File Offset: 0x006BC1EC
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

	// Token: 0x06019D60 RID: 105824 RVA: 0x006BE0A4 File Offset: 0x006BC2A4
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

	// Token: 0x06019D61 RID: 105825 RVA: 0x006BE1D4 File Offset: 0x006BC3D4
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

	// Token: 0x06019D62 RID: 105826 RVA: 0x006BE244 File Offset: 0x006BC444
	protected int? GetBuffMaxStack(long buffId)
	{
		BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
		if (buffDefinition == null || buffDefinition.StackLimitCount <= 0)
		{
			return null;
		}
		return new int?(buffDefinition.StackLimitCount);
	}

	// Token: 0x06019D63 RID: 105827 RVA: 0x006BE280 File Offset: 0x006BC480
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

	// Token: 0x0400C319 RID: 49945
	protected EPropSystemType PropSystem;

	// Token: 0x0400C31A RID: 49946
	protected int AttributeId;

	// Token: 0x0400C31B RID: 49947
	protected List<long> BuffIds = new List<long>();

	// Token: 0x0400C31C RID: 49948
	protected bool CleanBuffsOnRemoved = true;

	// Token: 0x0400C31D RID: 49949
	protected bool RefreshOnRevive = true;

	// Token: 0x0400C31E RID: 49950
	private bool ReviveListened;
}
