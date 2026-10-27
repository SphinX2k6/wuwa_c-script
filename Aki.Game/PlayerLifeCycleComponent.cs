using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003293 RID: 12947
public class PlayerLifeCycleComponent : EntityComponent
{
	// Token: 0x0601C08C RID: 114828 RVA: 0x007CB4F4 File Offset: 0x007C96F4
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

	// Token: 0x0601C08D RID: 114829 RVA: 0x007CB697 File Offset: 0x007C9897
	protected override bool OnStart()
	{
		EventSystem.Instance.Emit<int, Entity>(EEventName.PlayerEntityStarted, this.PlayerId, base.Entity);
		return true;
	}

	// Token: 0x0601C08E RID: 114830 RVA: 0x007CB6B6 File Offset: 0x007C98B6
	protected override bool OnEnd()
	{
		EventSystem.Instance.Emit<int, Entity>(EEventName.PlayerEntityEnded, this.PlayerId, base.Entity);
		return true;
	}

	// Token: 0x0601C08F RID: 114831 RVA: 0x007CB6D5 File Offset: 0x007C98D5
	protected override bool OnClear()
	{
		FormationDataController.Instance.UnRegisterPlayerEntity(this.PlayerId);
		return true;
	}

	// Token: 0x0601C090 RID: 114832 RVA: 0x007CB6E8 File Offset: 0x007C98E8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PlayerLifeCycleComponent playerLifeCycleComponent = (PlayerLifeCycleComponent)componentTemplate;
		if (base.CanResetComponentProperty("PlayerId"))
		{
			this.PlayerId = playerLifeCycleComponent.PlayerId;
		}
		return true;
	}

	// Token: 0x0400DD94 RID: 56724
	protected int PlayerId;
}
