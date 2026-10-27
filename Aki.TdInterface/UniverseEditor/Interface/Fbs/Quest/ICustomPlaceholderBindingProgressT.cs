using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC2 RID: 15810
	public class ICustomPlaceholderBindingProgressT
	{
		// Token: 0x17006D26 RID: 27942
		// (get) Token: 0x06016103 RID: 90371 RVA: 0x00330C7F File Offset: 0x0032EE7F
		// (set) Token: 0x06016104 RID: 90372 RVA: 0x00330C87 File Offset: 0x0032EE87
		public string PlaceHolderName { get; set; }

		// Token: 0x17006D27 RID: 27943
		// (get) Token: 0x06016105 RID: 90373 RVA: 0x00330C90 File Offset: 0x0032EE90
		// (set) Token: 0x06016106 RID: 90374 RVA: 0x00330C98 File Offset: 0x0032EE98
		public IPlayerHavingItemCountT BindingProgressType { get; set; }

		// Token: 0x06016107 RID: 90375 RVA: 0x00330CA1 File Offset: 0x0032EEA1
		public ICustomPlaceholderBindingProgressT()
		{
			this.PlaceHolderName = null;
			this.BindingProgressType = null;
		}
	}
}
