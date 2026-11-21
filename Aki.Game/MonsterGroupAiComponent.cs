using System;

// Token: 0x02002730 RID: 10032
public class MonsterGroupAiComponent : BaseGroupAiComponent
{
	// Token: 0x06019274 RID: 103028 RVA: 0x007AB50E File Offset: 0x007A970E
	public override void OnGroupPatrolRegistered()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.关卡.群组巡逻"]));
	}

	// Token: 0x06019275 RID: 103029 RVA: 0x007AB539 File Offset: 0x007A9739
	public override bool ShouldForceResetPatrolOnLargeDelta()
	{
		return false;
	}

	// Token: 0x06019276 RID: 103030 RVA: 0x007AB53C File Offset: 0x007A973C
	public override void PushPatrolMoveInfo(EGroupPatrolMemberRole role)
	{
		if (role == EGroupPatrolMemberRole.Captain)
		{
			return;
		}
		base.PushPatrolMoveInfo(role);
	}

	// Token: 0x17002802 RID: 10242
	// (get) Token: 0x06019277 RID: 103031 RVA: 0x007AB54A File Offset: 0x007A974A
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002803 RID: 10243
	// (get) Token: 0x06019278 RID: 103032 RVA: 0x007AB54D File Offset: 0x007A974D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}
}
