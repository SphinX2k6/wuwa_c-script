using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002804 RID: 10244
public class PlayerLifeCycleComponent : EntityComponent
{
	// Token: 0x06019CB2 RID: 105650 RVA: 0x007F27B4 File Offset: 0x007F09B4
	[NullableContext(2)]
	protected unsafe override bool OnInitData(IEntityArgs args = null)
	{
		CreatureDataComponent creatureDataComponent = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.PlayerId = ((creatureDataComponent != null) ? creatureDataComponent.GetPlayerId() : 0);
		if (this.PlayerId == 0)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Actor;
			Entity entity = base.Entity;
			string message = "初始化PlayerEntity时找不到合法的PlayerId";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureDataId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PlayerId", this.PlayerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("entityId", base.Entity.Id);
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(this.PlayerId);
		if (playerEntity != null)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Actor;
			Entity entity2 = base.Entity;
			string message2 = "PlayerId已经存在";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PlayerId", this.PlayerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("entityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("oldEntityId", playerEntity.Id);
			instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		FormationDataController.Instance.RegisterPlayerEntity(this.PlayerId, base.Entity as WorldEntity);
		return true;
	}

	// Token: 0x06019CB3 RID: 105651 RVA: 0x007F2957 File Offset: 0x007F0B57
	protected override bool OnStart()
	{
		EventSystem.Instance.Emit<int, Entity>(EEventName.PlayerEntityStarted, this.PlayerId, base.Entity);
		return true;
	}

	// Token: 0x06019CB4 RID: 105652 RVA: 0x007F2976 File Offset: 0x007F0B76
	protected override bool OnEnd()
	{
		EventSystem.Instance.Emit<int, Entity>(EEventName.PlayerEntityEnded, this.PlayerId, base.Entity);
		return true;
	}

	// Token: 0x06019CB5 RID: 105653 RVA: 0x007F2995 File Offset: 0x007F0B95
	protected override bool OnClear()
	{
		FormationDataController.Instance.UnRegisterPlayerEntity(this.PlayerId);
		return true;
	}

	// Token: 0x06019CB6 RID: 105654 RVA: 0x007F29A8 File Offset: 0x007F0BA8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerLifeCycleComponent playerLifeCycleComponent = (PlayerLifeCycleComponent)componentTemplate;
		this.PlayerId = playerLifeCycleComponent.PlayerId;
		return true;
	}

	// Token: 0x1700298E RID: 10638
	// (get) Token: 0x06019CB7 RID: 105655 RVA: 0x007F29D4 File Offset: 0x007F0BD4
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700298F RID: 10639
	// (get) Token: 0x06019CB8 RID: 105656 RVA: 0x007F29D7 File Offset: 0x007F0BD7
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002990 RID: 10640
	// (get) Token: 0x06019CB9 RID: 105657 RVA: 0x007F29DA File Offset: 0x007F0BDA
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E23B RID: 57915
	protected int PlayerId;
}
