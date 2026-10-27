using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063B4 RID: 25524
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffUnitData : IMowingBuffUnitData
	{
		// Token: 0x1700937E RID: 37758
		// (get) Token: 0x06040355 RID: 262997 RVA: 0x00F8B55A File Offset: 0x00F8975A
		// (set) Token: 0x06040356 RID: 262998 RVA: 0x00F8B562 File Offset: 0x00F89762
		public int Index { get; set; }

		// Token: 0x1700937F RID: 37759
		// (get) Token: 0x06040357 RID: 262999 RVA: 0x00F8B56B File Offset: 0x00F8976B
		// (set) Token: 0x06040358 RID: 263000 RVA: 0x00F8B573 File Offset: 0x00F89773
		public int BuffId { get; set; }

		// Token: 0x17009380 RID: 37760
		// (get) Token: 0x06040359 RID: 263001 RVA: 0x00F8B57C File Offset: 0x00F8977C
		// (set) Token: 0x0604035A RID: 263002 RVA: 0x00F8B584 File Offset: 0x00F89784
		public bool IsActive { get; set; }

		// Token: 0x17009381 RID: 37761
		// (get) Token: 0x0604035B RID: 263003 RVA: 0x00F8B58D File Offset: 0x00F8978D
		// (set) Token: 0x0604035C RID: 263004 RVA: 0x00F8B595 File Offset: 0x00F89795
		public bool IsChosen { get; set; }

		// Token: 0x17009382 RID: 37762
		// (get) Token: 0x0604035D RID: 263005 RVA: 0x00F8B59E File Offset: 0x00F8979E
		// (set) Token: 0x0604035E RID: 263006 RVA: 0x00F8B5A6 File Offset: 0x00F897A6
		public string IconPath { get; set; }

		// Token: 0x17009383 RID: 37763
		// (get) Token: 0x0604035F RID: 263007 RVA: 0x00F8B5AF File Offset: 0x00F897AF
		// (set) Token: 0x06040360 RID: 263008 RVA: 0x00F8B5B7 File Offset: 0x00F897B7
		public string NameTextId { get; set; }

		// Token: 0x17009384 RID: 37764
		// (get) Token: 0x06040361 RID: 263009 RVA: 0x00F8B5C0 File Offset: 0x00F897C0
		// (set) Token: 0x06040362 RID: 263010 RVA: 0x00F8B5C8 File Offset: 0x00F897C8
		public int ThresholdCount { get; set; }
	}
}
