using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B7 RID: 25527
	[NullableContext(1)]
	public interface IMowingBuffIntroduceData
	{
		// Token: 0x17009395 RID: 37781
		// (get) Token: 0x06040385 RID: 263045
		// (set) Token: 0x06040386 RID: 263046
		string BackgroundPath { get; set; }

		// Token: 0x17009396 RID: 37782
		// (get) Token: 0x06040387 RID: 263047
		// (set) Token: 0x06040388 RID: 263048
		string LevelTextId { get; set; }

		// Token: 0x17009397 RID: 37783
		// (get) Token: 0x06040389 RID: 263049
		// (set) Token: 0x0604038A RID: 263050
		string[] LevelTextArgs { get; set; }

		// Token: 0x17009398 RID: 37784
		// (get) Token: 0x0604038B RID: 263051
		// (set) Token: 0x0604038C RID: 263052
		string NameTextId { get; set; }

		// Token: 0x17009399 RID: 37785
		// (get) Token: 0x0604038D RID: 263053
		// (set) Token: 0x0604038E RID: 263054
		string TipsTextId { get; set; }

		// Token: 0x1700939A RID: 37786
		// (get) Token: 0x0604038F RID: 263055
		// (set) Token: 0x06040390 RID: 263056
		string[] TipsArgs { get; set; }

		// Token: 0x1700939B RID: 37787
		// (get) Token: 0x06040391 RID: 263057
		// (set) Token: 0x06040392 RID: 263058
		string IconPath { get; set; }

		// Token: 0x1700939C RID: 37788
		// (get) Token: 0x06040393 RID: 263059
		// (set) Token: 0x06040394 RID: 263060
		string HexColor { get; set; }

		// Token: 0x1700939D RID: 37789
		// (get) Token: 0x06040395 RID: 263061
		// (set) Token: 0x06040396 RID: 263062
		bool IsUnlock { get; set; }
	}
}
