using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200099D RID: 2461
public class ActivityScratchTicketDefine : IStaticVariableResetter
{
	// Token: 0x06006C1D RID: 27677 RVA: 0x0021859B File Offset: 0x0021679B
	static ActivityScratchTicketDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketDefine.CreateStaticDefaultValue), new Action(ActivityScratchTicketDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06006C1E RID: 27678 RVA: 0x002185BC File Offset: 0x002167BC
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

	// Token: 0x06006C1F RID: 27679 RVA: 0x0021861B File Offset: 0x0021681B
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketDefine.DirectionToSequenceMap = null;
	}

	// Token: 0x040043B1 RID: 17329
	[Nullable(2)]
	public static Dictionary<EScratchDirectionType, ECellSequenceType> DirectionToSequenceMap;

	// Token: 0x040043B2 RID: 17330
	public const int SCRATCH_TICKET_REWRAD_CONFIG_ID = 1009;

	// Token: 0x040043B3 RID: 17331
	public const int FIRST_SHOW_REWARD_INTERVAL = 700;

	// Token: 0x040043B4 RID: 17332
	public const int SHOW_SHAKE_INTERVAL = 500;

	// Token: 0x040043B5 RID: 17333
	public const int CELL_SHOW_REWRD_INTERVAL = 100;

	// Token: 0x040043B6 RID: 17334
	public const int CELL_SHOW_WARNING_INTERVAL = 50;

	// Token: 0x040043B7 RID: 17335
	public const int FOREVER_DELAY_INTERVAL = 50;

	// Token: 0x040043B8 RID: 17336
	public const int LAST_DELAY_INTERVAL = 700;

	// Token: 0x040043B9 RID: 17337
	public const int REVEAL_DELAY_INTERVAL = 30;

	// Token: 0x040043BA RID: 17338
	public const int TOUCH_BOUNDARY_INTERVAL = 250;

	// Token: 0x040043BB RID: 17339
	public const int HAMSTER_B_SEQUENCE_INTERVAL = 700;

	// Token: 0x040043BC RID: 17340
	public const int HAMSTER_C_SEQUENCE_INTERVAL = 1000;
}
