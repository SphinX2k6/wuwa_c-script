using System;
using Aki.Config;

// Token: 0x020027A0 RID: 10144
public class RoleGaitStatic : IStaticVariableResetter
{
	// Token: 0x060196E4 RID: 104164 RVA: 0x007C9462 File Offset: 0x007C7662
	static RoleGaitStatic()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleGaitStatic.CreateStaticDefaultValue), new Action(RoleGaitStatic.ResetStaticDefaultValue));
	}

	// Token: 0x060196E5 RID: 104165 RVA: 0x007C9484 File Offset: 0x007C7684
	public static void Init()
	{
		if (!RoleGaitStatic.IsInit)
		{
			RoleGaitStatic.MovementStatusGapValue = ConfigCommonParamById.GetFloatConfig("Move_Status_GapValue_GamePad").Value;
			RoleGaitStatic.MovementStatusGapValueSquare = RoleGaitStatic.MovementStatusGapValue * RoleGaitStatic.MovementStatusGapValue;
			RoleGaitStatic.IsInit = true;
		}
	}

	// Token: 0x060196E6 RID: 104166 RVA: 0x007C94C5 File Offset: 0x007C76C5
	public static void SetWalkOrRunRateForRocker(float newValue)
	{
		RoleGaitStatic._walkOrRunRate = Math.Min(newValue, 0.99f);
	}

	// Token: 0x060196E7 RID: 104167 RVA: 0x007C94D7 File Offset: 0x007C76D7
	public static float GetWalkOrRunRate()
	{
		return RoleGaitStatic._walkOrRunRate;
	}

	// Token: 0x060196E8 RID: 104168 RVA: 0x007C94DE File Offset: 0x007C76DE
	public static void CreateStaticDefaultValue()
	{
		RoleGaitStatic.MovementStatusGapValue = 0f;
		RoleGaitStatic.MovementStatusGapValueSquare = 0f;
		RoleGaitStatic.IsInit = false;
		RoleGaitStatic._walkOrRunRate = 0.3f;
	}

	// Token: 0x060196E9 RID: 104169 RVA: 0x007C9504 File Offset: 0x007C7704
	public static void ResetStaticDefaultValue()
	{
		RoleGaitStatic.MovementStatusGapValue = 0f;
		RoleGaitStatic.MovementStatusGapValueSquare = 0f;
		RoleGaitStatic.IsInit = false;
		RoleGaitStatic._walkOrRunRate = 0.3f;
	}

	// Token: 0x0400DEE5 RID: 57061
	private const float WALK_TO_RUN_RATE = 0.3f;

	// Token: 0x0400DEE6 RID: 57062
	public static float MovementStatusGapValue;

	// Token: 0x0400DEE7 RID: 57063
	public static float MovementStatusGapValueSquare;

	// Token: 0x0400DEE8 RID: 57064
	public static bool IsInit;

	// Token: 0x0400DEE9 RID: 57065
	private static float _walkOrRunRate;
}
