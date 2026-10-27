using System;

// Token: 0x02002E7F RID: 11903
public class ActiveBuffConfigs
{
	// Token: 0x0400BD70 RID: 48496
	public const long NULL_BUFF_ID = 0L;

	// Token: 0x0400BD71 RID: 48497
	public const long DYNAMIC_BUFF_ID = -3L;

	// Token: 0x0400BD72 RID: 48498
	public const int DEFAULT_BUFF_LEVEL = 1;

	// Token: 0x0400BD73 RID: 48499
	public const int DEFAULT_GE_SERVER_ID = -1;

	// Token: 0x0400BD74 RID: 48500
	public const int DEFAULT_SERVER_GE_DURATION = -1;

	// Token: 0x0400BD75 RID: 48501
	[StaticVariableRuleIgnore]
	public static readonly float? USE_INTERNAL_DURATION;

	// Token: 0x0400BD76 RID: 48502
	public const int INVALID_BUFF_HANDLE = -1;

	// Token: 0x0400BD77 RID: 48503
	public const long NULL_INSTIGATOR_ID = 0L;

	// Token: 0x0400BD78 RID: 48504
	public const float MIN_BUFF_REMAIN_DURATION = 0.0001f;

	// Token: 0x0400BD79 RID: 48505
	public const int SUCCESS_INSTANT_BUFF_HANDLE = -2;

	// Token: 0x0400BD7A RID: 48506
	public const int INFINITY_DURATION = -1;

	// Token: 0x0400BD7B RID: 48507
	public const float MIN_BUFF_PERIOD = 0.034f;

	// Token: 0x0400BD7C RID: 48508
	public const float MIN_BUFF_EXECUTION_EFFECT_PERIOD = 0.2f;

	// Token: 0x0400BD7D RID: 48509
	public const int BUFF_HANDLE_ID_BYTE = 28;

	// Token: 0x0400BD7E RID: 48510
	public const int BUFF_HANDLE_PREFIX_BYTE = 4;

	// Token: 0x0400BD7F RID: 48511
	public const int HANDLE_MASK = 268435455;
}
