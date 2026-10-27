using System;
using Aki.Config;

// Token: 0x02003231 RID: 12849
public class RoleGaitStatic : IStaticVariableResetter
{
	// Token: 0x0601BB5F RID: 113503 RVA: 0x007A0B56 File Offset: 0x0079ED56
	static RoleGaitStatic()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleGaitStatic.CreateStaticDefaultValue), new Action(RoleGaitStatic.ResetStaticDefaultValue));
	}

	// Token: 0x0601BB60 RID: 113504 RVA: 0x007A0B78 File Offset: 0x0079ED78
	public static void Init()
	{
		if (!RoleGaitStatic.IsInit)
		{
			RoleGaitStatic.MovementStatusGapValue = ConfigCommonParamById.GetFloatConfig("Move_Status_GapValue_GamePad").Value;
			RoleGaitStatic.MovementStatusGapValueSquare = RoleGaitStatic.MovementStatusGapValue * RoleGaitStatic.MovementStatusGapValue;
			RoleGaitStatic.IsInit = true;
		}
	}

	// Token: 0x0601BB61 RID: 113505 RVA: 0x007A0BB9 File Offset: 0x0079EDB9
	public static void SetWalkOrRunRateForRocker(float newValue)
	{
		RoleGaitStatic._walkOrRunRate = Math.Min(newValue, 0.99f);
	}

	// Token: 0x0601BB62 RID: 113506 RVA: 0x007A0BCB File Offset: 0x0079EDCB
	public static float GetWalkOrRunRate()
	{
		return RoleGaitStatic._walkOrRunRate;
	}

	// Token: 0x0601BB63 RID: 113507 RVA: 0x007A0BD2 File Offset: 0x0079EDD2
	public static void CreateStaticDefaultValue()
	{
		RoleGaitStatic.MovementStatusGapValue = 0f;
		RoleGaitStatic.MovementStatusGapValueSquare = 0f;
		RoleGaitStatic.IsInit = false;
		RoleGaitStatic._walkOrRunRate = 0.3f;
	}

	// Token: 0x0601BB64 RID: 113508 RVA: 0x007A0BF8 File Offset: 0x0079EDF8
	public static void ResetStaticDefaultValue()
	{
		RoleGaitStatic.MovementStatusGapValue = 0f;
		RoleGaitStatic.MovementStatusGapValueSquare = 0f;
		RoleGaitStatic.IsInit = false;
		RoleGaitStatic._walkOrRunRate = 0.3f;
	}

	// Token: 0x0400DA46 RID: 55878
	private const float WALK_TO_RUN_RATE = 0.3f;

	// Token: 0x0400DA47 RID: 55879
	public static float MovementStatusGapValue;

	// Token: 0x0400DA48 RID: 55880
	public static float MovementStatusGapValueSquare;

	// Token: 0x0400DA49 RID: 55881
	public static bool IsInit;

	// Token: 0x0400DA4A RID: 55882
	private static float _walkOrRunRate;
}
