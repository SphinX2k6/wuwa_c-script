using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014E5 RID: 5349
public class ActivityScratchTicketDefine : IStaticVariableResetter
{
	// Token: 0x06009843 RID: 38979 RVA: 0x0020E85B File Offset: 0x0020CA5B
	static ActivityScratchTicketDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketDefine.CreateStaticDefaultValue), new Action(ActivityScratchTicketDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06009844 RID: 38980 RVA: 0x0020E87C File Offset: 0x0020CA7C
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EScratchDirectionType, ECellSequenceType> dictionary = new Dictionary<EScratchDirectionType, ECellSequenceType>();
		dictionary[EScratchDirectionType.Center] = ECellSequenceType.Center;
		dictionary[EScratchDirectionType.Left] = ECellSequenceType.Left;
		dictionary[EScratchDirectionType.Right] = ECellSequenceType.Right;
		dictionary[EScratchDirectionType.Top] = ECellSequenceType.Top;
		dictionary[EScratchDirectionType.Bottom] = ECellSequenceType.Bottom;
		dictionary[EScratchDirectionType.LeftTop] = ECellSequenceType.Left;
		dictionary[EScratchDirectionType.LeftBottom] = ECellSequenceType.Left;
		dictionary[EScratchDirectionType.RightTop] = ECellSequenceType.Left;
		dictionary[EScratchDirectionType.RightBottom] = ECellSequenceType.Left;
		ActivityScratchTicketDefine.DirectionToSequenceMap = dictionary;
	}

	// Token: 0x06009845 RID: 38981 RVA: 0x0020E8DB File Offset: 0x0020CADB
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketDefine.DirectionToSequenceMap = null;
	}

	// Token: 0x0400430C RID: 17164
	[Nullable(2)]
	public static Dictionary<EScratchDirectionType, ECellSequenceType> DirectionToSequenceMap;

	// Token: 0x0400430D RID: 17165
	public const int SCRATCH_TICKET_REWRAD_CONFIG_ID = 1009;

	// Token: 0x0400430E RID: 17166
	public const int FIRST_SHOW_REWARD_INTERVAL = 700;

	// Token: 0x0400430F RID: 17167
	public const int SHOW_SHAKE_INTERVAL = 500;

	// Token: 0x04004310 RID: 17168
	public const int CELL_SHOW_REWRD_INTERVAL = 100;

	// Token: 0x04004311 RID: 17169
	public const int CELL_SHOW_WARNING_INTERVAL = 50;

	// Token: 0x04004312 RID: 17170
	public const int FOREVER_DELAY_INTERVAL = 50;

	// Token: 0x04004313 RID: 17171
	public const int LAST_DELAY_INTERVAL = 700;

	// Token: 0x04004314 RID: 17172
	public const int REVEAL_DELAY_INTERVAL = 30;

	// Token: 0x04004315 RID: 17173
	public const int TOUCH_BOUNDARY_INTERVAL = 250;

	// Token: 0x04004316 RID: 17174
	public const int HAMSTER_B_SEQUENCE_INTERVAL = 700;

	// Token: 0x04004317 RID: 17175
	public const int HAMSTER_C_SEQUENCE_INTERVAL = 1000;
}
