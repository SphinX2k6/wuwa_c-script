using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.Vision;

// Token: 0x02003004 RID: 12292
[NullableContext(1)]
[Nullable(0)]
public class VisionBuffComponent : CharacterBuffComponent
{
	// Token: 0x0601A094 RID: 106644 RVA: 0x006D14AC File Offset: 0x006CF6AC
	private bool NeedTransfer()
	{
		if (this.NeedNeedTransferFlag != null)
		{
			return this.NeedNeedTransferFlag.Value;
		}
		CharacterFollowComponent component = base.Entity.GetComponent<CharacterFollowComponent>();
		Entity entity = (component != null) ? component.GetAttributeHolder() : null;
		if (entity == null)
		{
			return false;
		}
		if (entity == base.Entity)
		{
			return false;
		}
		VisionComponent visionComponent = this.CreatureDataComponent.GetVisionComponent();
		if (visionComponent != null)
		{
			SVisionData visionData = PhantomUtil.GetVisionData(visionComponent.VisionId);
			this.NeedNeedTransferFlag = new bool?(visionData != null && visionData.buff是否转移);
		}
		return this.NeedNeedTransferFlag.GetValueOrDefault();
	}

	// Token: 0x0601A095 RID: 106645 RVA: 0x006D1538 File Offset: 0x006CF738
	public unsafe override void AddBuff(long buffId, AddBuffParam buffParams)
	{
		if (base.CreatureDataId == buffParams.InstigatorId || !this.NeedTransfer())
		{
			base.AddBuff(buffId, buffParams);
			return;
		}
		CharacterFollowComponent component = base.Entity.GetComponent<CharacterFollowComponent>();
		Entity entity = (component != null) ? component.GetAttributeHolder() : null;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent != null && characterBuffComponent != this)
		{
			characterBuffComponent.AddBuff(buffId, buffParams);
			return;
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
		Entity entity2 = base.Entity;
		string message = "添加幻象buff时无法获取到合法的召唤者";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", (buffParams != null) ? buffParams.Reason : null);
		instance.Error(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0601A096 RID: 106646 RVA: 0x006D1608 File Offset: 0x006CF808
	public unsafe override void RemoveBuff(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null)
	{
		if (this.NeedTransfer())
		{
			CharacterFollowComponent component = base.Entity.GetComponent<CharacterFollowComponent>();
			Entity entity = (component != null) ? component.GetAttributeHolder() : null;
			CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			if (characterBuffComponent != null && characterBuffComponent != this)
			{
				characterBuffComponent.RemoveBuff(buffId, stackCount, reason, preMessageId, isServerRequest, instigatorId);
			}
			else
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity entity2 = base.Entity;
				string message = "移除幻象buff时无法获取到合法的召唤者";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
				instance.Error(flag, entity2, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		base.RemoveBuff(buffId, stackCount, reason, preMessageId, isServerRequest, instigatorId);
	}

	// Token: 0x0601A097 RID: 106647 RVA: 0x006D16C8 File Offset: 0x006CF8C8
	[NullableContext(2)]
	public override BaseBuffComponent GetBuffApplyTarget(long buffId, long instigatorId)
	{
		if (base.CreatureDataId == instigatorId || !this.NeedTransfer())
		{
			return this;
		}
		CharacterFollowComponent component = base.Entity.GetComponent<CharacterFollowComponent>();
		Entity entity = (component != null) ? component.GetAttributeHolder() : null;
		CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
		if (characterBuffComponent != null && characterBuffComponent != this)
		{
			return characterBuffComponent.GetBuffApplyTarget(buffId, instigatorId);
		}
		return null;
	}

	// Token: 0x0601A098 RID: 106648 RVA: 0x006D1720 File Offset: 0x006CF920
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VisionBuffComponent visionBuffComponent = (VisionBuffComponent)componentTemplate;
		if (base.CanResetComponentProperty("NeedNeedTransferFlag"))
		{
			this.NeedNeedTransferFlag = visionBuffComponent.NeedNeedTransferFlag;
		}
		return true;
	}

	// Token: 0x0400C51D RID: 50461
	private bool? NeedNeedTransferFlag;
}
