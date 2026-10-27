using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E0 RID: 25568
	public class IClientPreEnableSubLevelsT
	{
		// Token: 0x1700BE77 RID: 48759
		// (get) Token: 0x0602C3BB RID: 181179 RVA: 0x00612774 File Offset: 0x00610974
		// (set) Token: 0x0602C3BC RID: 181180 RVA: 0x0061277C File Offset: 0x0061097C
		public List<string> EnableLevels { get; set; }

		// Token: 0x1700BE78 RID: 48760
		// (get) Token: 0x0602C3BD RID: 181181 RVA: 0x00612785 File Offset: 0x00610985
		// (set) Token: 0x0602C3BE RID: 181182 RVA: 0x0061278D File Offset: 0x0061098D
		public List<string> DisableLevels { get; set; }

		// Token: 0x1700BE79 RID: 48761
		// (get) Token: 0x0602C3BF RID: 181183 RVA: 0x00612796 File Offset: 0x00610996
		// (set) Token: 0x0602C3C0 RID: 181184 RVA: 0x0061279E File Offset: 0x0061099E
		public IEnableSubLevelTransitionWithSceneCaptureT TransitionOption { get; set; }

		// Token: 0x1700BE7A RID: 48762
		// (get) Token: 0x0602C3C1 RID: 181185 RVA: 0x006127A7 File Offset: 0x006109A7
		// (set) Token: 0x0602C3C2 RID: 181186 RVA: 0x006127AF File Offset: 0x006109AF
		public bool IsWaitForEnableComplete { get; set; }

		// Token: 0x1700BE7B RID: 48763
		// (get) Token: 0x0602C3C3 RID: 181187 RVA: 0x006127B8 File Offset: 0x006109B8
		// (set) Token: 0x0602C3C4 RID: 181188 RVA: 0x006127C0 File Offset: 0x006109C0
		public byte NullMask { get; set; }

		// Token: 0x0602C3C5 RID: 181189 RVA: 0x006127C9 File Offset: 0x006109C9
		public IClientPreEnableSubLevelsT()
		{
			this.EnableLevels = null;
			this.DisableLevels = null;
			this.TransitionOption = null;
			this.IsWaitForEnableComplete = false;
			this.NullMask = 0;
		}
	}
}
