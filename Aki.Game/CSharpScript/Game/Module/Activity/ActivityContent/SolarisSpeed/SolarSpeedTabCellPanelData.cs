using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B5 RID: 24757
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSpeedTabCellPanelData : ISolarSpeedTabCellPanelData
	{
		// Token: 0x170090CC RID: 37068
		// (get) Token: 0x0603E978 RID: 256376 RVA: 0x00F20465 File Offset: 0x00F1E665
		// (set) Token: 0x0603E979 RID: 256377 RVA: 0x00F2046D File Offset: 0x00F1E66D
		public int LevelId { get; set; }

		// Token: 0x170090CD RID: 37069
		// (get) Token: 0x0603E97A RID: 256378 RVA: 0x00F20476 File Offset: 0x00F1E676
		// (set) Token: 0x0603E97B RID: 256379 RVA: 0x00F2047E File Offset: 0x00F1E67E
		public string RomeNumberPath { get; set; }

		// Token: 0x170090CE RID: 37070
		// (get) Token: 0x0603E97C RID: 256380 RVA: 0x00F20487 File Offset: 0x00F1E687
		// (set) Token: 0x0603E97D RID: 256381 RVA: 0x00F2048F File Offset: 0x00F1E68F
		public string TitleTextId { get; set; }

		// Token: 0x170090CF RID: 37071
		// (get) Token: 0x0603E97E RID: 256382 RVA: 0x00F20498 File Offset: 0x00F1E698
		// (set) Token: 0x0603E97F RID: 256383 RVA: 0x00F204A0 File Offset: 0x00F1E6A0
		public bool IsChosen { get; set; }

		// Token: 0x170090D0 RID: 37072
		// (get) Token: 0x0603E980 RID: 256384 RVA: 0x00F204A9 File Offset: 0x00F1E6A9
		// (set) Token: 0x0603E981 RID: 256385 RVA: 0x00F204B1 File Offset: 0x00F1E6B1
		public bool IsRedDot { get; set; }
	}
}
