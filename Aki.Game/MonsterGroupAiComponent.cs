using System;
using System.Runtime.CompilerServices;

// Token: 0x020031C1 RID: 12737
public class MonsterGroupAiComponent : BaseGroupAiComponent
{
	// Token: 0x0601B73C RID: 112444 RVA: 0x00783310 File Offset: 0x00781510
	public override void OnGroupPatrolRegistered()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.关卡.群组巡逻"]));
	}

	// Token: 0x0601B73D RID: 112445 RVA: 0x0078333B File Offset: 0x0078153B
	public override bool ShouldForceResetPatrolOnLargeDelta()
	{
		return false;
	}

	// Token: 0x0601B73E RID: 112446 RVA: 0x0078333E File Offset: 0x0078153E
	public override void PushPatrolMoveInfo(EGroupPatrolMemberRole role)
	{
		if (role == EGroupPatrolMemberRole.Captain)
		{
			return;
		}
		base.PushPatrolMoveInfo(role);
	}

	// Token: 0x0601B73F RID: 112447 RVA: 0x0078334C File Offset: 0x0078154C
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterGroupAiComponent monsterGroupAiComponent = (MonsterGroupAiComponent)componentTemplate;
		return true;
	}
}
