using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityCondition
{
	// Token: 0x02005A82 RID: 23170
	public static class ActivityConditionDefine
	{
		// Token: 0x0401E0E5 RID: 123109
		public const int ConditionPoolCapacity = 100;

		// Token: 0x0401E0E6 RID: 123110
		public const int ConditionParamsPoolCapacity = 32;

		// Token: 0x0401E0E7 RID: 123111
		public const char ParamListSeparator = '|';

		// Token: 0x0200B69D RID: 46749
		[NullableContext(1)]
		[Nullable(0)]
		public static class ParamKey
		{
			// Token: 0x040387F6 RID: 231414
			public const string LocationIds = "LocationIds";

			// Token: 0x040387F7 RID: 231415
			public const string Key = "Key";

			// Token: 0x040387F8 RID: 231416
			public const string Value = "Value";

			// Token: 0x040387F9 RID: 231417
			public const string BehaviorId = "BehaviorId";

			// Token: 0x040387FA RID: 231418
			public const string OnlySuccess = "OnlySuccess";

			// Token: 0x040387FB RID: 231419
			public const string Count = "Count";

			// Token: 0x040387FC RID: 231420
			public const string EndingIds = "EndingIds";

			// Token: 0x040387FD RID: 231421
			public const string EndingId = "EndingId";

			// Token: 0x040387FE RID: 231422
			public const string StartMonth = "StartMonth";

			// Token: 0x040387FF RID: 231423
			public const string StartDay = "StartDay";

			// Token: 0x04038800 RID: 231424
			public const string EndMonth = "EndMonth";

			// Token: 0x04038801 RID: 231425
			public const string EndDay = "EndDay";

			// Token: 0x04038802 RID: 231426
			public const string Month = "Month";

			// Token: 0x04038803 RID: 231427
			public const string Day = "Day";

			// Token: 0x04038804 RID: 231428
			public const string IncludeSelf = "IncludeSelf";

			// Token: 0x04038805 RID: 231429
			public const string ExamId = "ExamId";

			// Token: 0x04038806 RID: 231430
			public const string Min = "Min";

			// Token: 0x04038807 RID: 231431
			public const string Max = "Max";

			// Token: 0x04038808 RID: 231432
			public const string ItemId = "ItemId";

			// Token: 0x04038809 RID: 231433
			public const string InfluenceId = "InfluenceId";

			// Token: 0x0403880A RID: 231434
			public const string Level = "Level";

			// Token: 0x0403880B RID: 231435
			public const string LocationId = "LocationId";

			// Token: 0x0403880C RID: 231436
			public const string RoleId = "RoleId";

			// Token: 0x0403880D RID: 231437
			public const string FavorLevel = "FavorLevel";

			// Token: 0x0403880E RID: 231438
			public const string Attr = "Attr";

			// Token: 0x0403880F RID: 231439
			public const string Stages = "Stages";

			// Token: 0x04038810 RID: 231440
			public const string State = "State";

			// Token: 0x04038811 RID: 231441
			public const string TimeSlots = "TimeSlots";

			// Token: 0x04038812 RID: 231442
			public const string InstanceIds = "InstanceIds";

			// Token: 0x04038813 RID: 231443
			public const string Weekdays = "Weekdays";

			// Token: 0x04038814 RID: 231444
			public const string ShopId = "ShopId";

			// Token: 0x04038815 RID: 231445
			public const string GoodsId = "GoodsId";

			// Token: 0x04038816 RID: 231446
			public const string QuestId = "QuestId";

			// Token: 0x04038817 RID: 231447
			public const string QuestNodeId = "QuestNodeId";
		}
	}
}
