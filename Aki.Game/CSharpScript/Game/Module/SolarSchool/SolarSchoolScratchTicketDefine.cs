using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005942 RID: 22850
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketDefine : IStaticVariableResetter
	{
		// Token: 0x060384E3 RID: 230627 RVA: 0x00FBE3F4 File Offset: 0x00FBC5F4
		static SolarSchoolScratchTicketDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolScratchTicketDefine.CreateStaticDefaultValue), new Action(SolarSchoolScratchTicketDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060384E4 RID: 230628 RVA: 0x00FBE414 File Offset: 0x00FBC614
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
			SolarSchoolScratchTicketDefine.DirectionToSequenceMap = dictionary;
		}

		// Token: 0x060384E5 RID: 230629 RVA: 0x00FBE473 File Offset: 0x00FBC673
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolScratchTicketDefine.DirectionToSequenceMap = null;
		}

		// Token: 0x0401DA72 RID: 121458
		[Nullable(2)]
		public static Dictionary<EScratchDirectionType, ECellSequenceType> DirectionToSequenceMap;

		// Token: 0x0401DA73 RID: 121459
		public const int SCRATCH_TICKET_REWRAD_CONFIG_ID = 1009;

		// Token: 0x0401DA74 RID: 121460
		public const int FIRST_SHOW_REWARD_INTERVAL = 700;

		// Token: 0x0401DA75 RID: 121461
		public const int SHOW_SHAKE_INTERVAL = 500;

		// Token: 0x0401DA76 RID: 121462
		public const int CELL_SHOW_REWRD_INTERVAL = 100;

		// Token: 0x0401DA77 RID: 121463
		public const int CELL_SHOW_WARNING_INTERVAL = 50;

		// Token: 0x0401DA78 RID: 121464
		public const int FOREVER_DELAY_INTERVAL = 50;

		// Token: 0x0401DA79 RID: 121465
		public const int LAST_DELAY_INTERVAL = 700;

		// Token: 0x0401DA7A RID: 121466
		public const int TOUCH_BOUNDARY_INTERVAL = 250;

		// Token: 0x0401DA7B RID: 121467
		public const int HAMSTER_B_SEQUENCE_INTERVAL = 700;

		// Token: 0x0401DA7C RID: 121468
		public const int HAMSTER_C_SEQUENCE_INTERVAL = 1000;

		// Token: 0x0401DA7D RID: 121469
		public const string TITLE_TXT = "SolarSchoolFes_lotteryname";

		// Token: 0x0401DA7E RID: 121470
		public const string DESC_TXT = "SolarSchoolFes_lotterydesc";

		// Token: 0x0401DA7F RID: 121471
		public const string CAPTION_RESOURCE_ID = "UiItem_SolarSchoolCaptionC";
	}
}
