using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAD RID: 28333
	public class IResetPresentationFailureT
	{
		// Token: 0x1700D2EE RID: 53998
		// (get) Token: 0x0603213D RID: 205117 RVA: 0x006C5949 File Offset: 0x006C3B49
		// (set) Token: 0x0603213E RID: 205118 RVA: 0x006C5951 File Offset: 0x006C3B51
		public EResetPresentationType Type { get; set; }

		// Token: 0x1700D2EF RID: 53999
		// (get) Token: 0x0603213F RID: 205119 RVA: 0x006C595A File Offset: 0x006C3B5A
		// (set) Token: 0x06032140 RID: 205120 RVA: 0x006C5962 File Offset: 0x006C3B62
		public float Duration { get; set; }

		// Token: 0x1700D2F0 RID: 54000
		// (get) Token: 0x06032141 RID: 205121 RVA: 0x006C596B File Offset: 0x006C3B6B
		// (set) Token: 0x06032142 RID: 205122 RVA: 0x006C5973 File Offset: 0x006C3B73
		public List<int> GamePlayCues { get; set; }

		// Token: 0x06032143 RID: 205123 RVA: 0x006C597C File Offset: 0x006C3B7C
		public IResetPresentationFailureT()
		{
			this.Type = EResetPresentationType.Failure;
			this.Duration = 0f;
			this.GamePlayCues = null;
		}
	}
}
