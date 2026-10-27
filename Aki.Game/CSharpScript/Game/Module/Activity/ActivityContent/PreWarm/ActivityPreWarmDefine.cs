using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062B8 RID: 25272
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPreWarmDefine
	{
		// Token: 0x040213CF RID: 136143
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, string> titleNumIcons = new Dictionary<int, string>
		{
			{
				1,
				"SP_TitleNum01"
			},
			{
				2,
				"SP_TitleNum02"
			},
			{
				3,
				"SP_TitleNum03"
			},
			{
				4,
				"SP_TitleNum04"
			},
			{
				5,
				"SP_TitleNum05"
			},
			{
				6,
				"SP_TitleNum06"
			},
			{
				7,
				"SP_TitleNum07"
			}
		};

		// Token: 0x040213D0 RID: 136144
		public const int PREWARMTASKNUM = 7;

		// Token: 0x040213D1 RID: 136145
		[StaticVariableRuleIgnore]
		public static readonly List<int> leftCollectItems = new List<int>
		{
			1,
			2,
			3
		};

		// Token: 0x040213D2 RID: 136146
		[StaticVariableRuleIgnore]
		public static readonly List<int> rightCollectItems = new List<int>
		{
			4,
			5,
			6,
			7
		};

		// Token: 0x040213D3 RID: 136147
		public const int SKIPTIMESPEED = 5;
	}
}
