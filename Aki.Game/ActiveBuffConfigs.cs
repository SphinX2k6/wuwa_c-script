using System;

// Token: 0x020023D1 RID: 9169
public class ActiveBuffConfigs
{
	// Token: 0x0400C107 RID: 49415
	public const long NULL_BUFF_ID = 0L;

	// Token: 0x0400C108 RID: 49416
	public const long DYNAMIC_BUFF_ID = -3L;

	// Token: 0x0400C109 RID: 49417
	public const int DEFAULT_BUFF_LEVEL = 1;

	// Token: 0x0400C10A RID: 49418
	public const int DEFAULT_GE_SERVER_ID = -1;

	// Token: 0x0400C10B RID: 49419
	public const int DEFAULT_SERVER_GE_DURATION = -1;

	// Token: 0x0400C10C RID: 49420
	[StaticVariableRuleIgnore]
	public static readonly float? USE_INTERNAL_DURATION;

	// Token: 0x0400C10D RID: 49421
	public const int INVALID_BUFF_HANDLE = -1;

	// Token: 0x0400C10E RID: 49422
	public const long NULL_INSTIGATOR_ID = 0L;

	// Token: 0x0400C10F RID: 49423
	public const float MIN_BUFF_REMAIN_DURATION = 0.0001f;

	// Token: 0x0400C110 RID: 49424
	public const int SUCCESS_INSTANT_BUFF_HANDLE = -2;

	// Token: 0x0400C111 RID: 49425
	public const int INFINITY_DURATION = -1;

	// Token: 0x0400C112 RID: 49426
	public const float MIN_BUFF_PERIOD = 0.034f;

	// Token: 0x0400C113 RID: 49427
	public const float MIN_BUFF_EXECUTION_EFFECT_PERIOD = 0.2f;

	// Token: 0x0400C114 RID: 49428
	public const int BUFF_HANDLE_ID_BYTE = 28;

	// Token: 0x0400C115 RID: 49429
	public const int BUFF_HANDLE_PREFIX_BYTE = 4;

	// Token: 0x0400C116 RID: 49430
	public const int HANDLE_MASK = 268435455;
}
