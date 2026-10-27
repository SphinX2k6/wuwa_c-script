using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B8 RID: 25528
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffIntroduceData : IMowingBuffIntroduceData
	{
		// Token: 0x1700939E RID: 37790
		// (get) Token: 0x06040397 RID: 263063 RVA: 0x00F8B669 File Offset: 0x00F89869
		// (set) Token: 0x06040398 RID: 263064 RVA: 0x00F8B671 File Offset: 0x00F89871
		public string BackgroundPath { get; set; }

		// Token: 0x1700939F RID: 37791
		// (get) Token: 0x06040399 RID: 263065 RVA: 0x00F8B67A File Offset: 0x00F8987A
		// (set) Token: 0x0604039A RID: 263066 RVA: 0x00F8B682 File Offset: 0x00F89882
		public string LevelTextId { get; set; }

		// Token: 0x170093A0 RID: 37792
		// (get) Token: 0x0604039B RID: 263067 RVA: 0x00F8B68B File Offset: 0x00F8988B
		// (set) Token: 0x0604039C RID: 263068 RVA: 0x00F8B693 File Offset: 0x00F89893
		public string[] LevelTextArgs { get; set; }

		// Token: 0x170093A1 RID: 37793
		// (get) Token: 0x0604039D RID: 263069 RVA: 0x00F8B69C File Offset: 0x00F8989C
		// (set) Token: 0x0604039E RID: 263070 RVA: 0x00F8B6A4 File Offset: 0x00F898A4
		public string NameTextId { get; set; }

		// Token: 0x170093A2 RID: 37794
		// (get) Token: 0x0604039F RID: 263071 RVA: 0x00F8B6AD File Offset: 0x00F898AD
		// (set) Token: 0x060403A0 RID: 263072 RVA: 0x00F8B6B5 File Offset: 0x00F898B5
		public string TipsTextId { get; set; }

		// Token: 0x170093A3 RID: 37795
		// (get) Token: 0x060403A1 RID: 263073 RVA: 0x00F8B6BE File Offset: 0x00F898BE
		// (set) Token: 0x060403A2 RID: 263074 RVA: 0x00F8B6C6 File Offset: 0x00F898C6
		public string[] TipsArgs { get; set; }

		// Token: 0x170093A4 RID: 37796
		// (get) Token: 0x060403A3 RID: 263075 RVA: 0x00F8B6CF File Offset: 0x00F898CF
		// (set) Token: 0x060403A4 RID: 263076 RVA: 0x00F8B6D7 File Offset: 0x00F898D7
		public string IconPath { get; set; }

		// Token: 0x170093A5 RID: 37797
		// (get) Token: 0x060403A5 RID: 263077 RVA: 0x00F8B6E0 File Offset: 0x00F898E0
		// (set) Token: 0x060403A6 RID: 263078 RVA: 0x00F8B6E8 File Offset: 0x00F898E8
		public string HexColor { get; set; }

		// Token: 0x170093A6 RID: 37798
		// (get) Token: 0x060403A7 RID: 263079 RVA: 0x00F8B6F1 File Offset: 0x00F898F1
		// (set) Token: 0x060403A8 RID: 263080 RVA: 0x00F8B6F9 File Offset: 0x00F898F9
		public bool IsUnlock { get; set; }
	}
}
