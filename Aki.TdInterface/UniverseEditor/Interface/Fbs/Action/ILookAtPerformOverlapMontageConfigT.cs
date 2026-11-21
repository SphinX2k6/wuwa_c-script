using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717F RID: 29055
	public class ILookAtPerformOverlapMontageConfigT
	{
		// Token: 0x1700D4AC RID: 54444
		// (get) Token: 0x06032814 RID: 206868 RVA: 0x006D35A6 File Offset: 0x006D17A6
		// (set) Token: 0x06032815 RID: 206869 RVA: 0x006D35AE File Offset: 0x006D17AE
		public float OverlapMontageLoopDuration { get; set; }

		// Token: 0x1700D4AD RID: 54445
		// (get) Token: 0x06032816 RID: 206870 RVA: 0x006D35B7 File Offset: 0x006D17B7
		// (set) Token: 0x06032817 RID: 206871 RVA: 0x006D35BF File Offset: 0x006D17BF
		public int OverlapMontageRepeatTimes { get; set; }

		// Token: 0x1700D4AE RID: 54446
		// (get) Token: 0x06032818 RID: 206872 RVA: 0x006D35C8 File Offset: 0x006D17C8
		// (set) Token: 0x06032819 RID: 206873 RVA: 0x006D35D0 File Offset: 0x006D17D0
		public byte NullMask { get; set; }

		// Token: 0x0603281A RID: 206874 RVA: 0x006D35D9 File Offset: 0x006D17D9
		public ILookAtPerformOverlapMontageConfigT()
		{
			this.OverlapMontageLoopDuration = 0f;
			this.OverlapMontageRepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}
