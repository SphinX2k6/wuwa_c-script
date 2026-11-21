using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F43 RID: 24387
	public class ISlideRailComponentT
	{
		// Token: 0x1700B499 RID: 46233
		// (get) Token: 0x06028FAC RID: 167852 RVA: 0x00599489 File Offset: 0x00597689
		// (set) Token: 0x06028FAD RID: 167853 RVA: 0x00599491 File Offset: 0x00597691
		public bool Disabled { get; set; }

		// Token: 0x1700B49A RID: 46234
		// (get) Token: 0x06028FAE RID: 167854 RVA: 0x0059949A File Offset: 0x0059769A
		// (set) Token: 0x06028FAF RID: 167855 RVA: 0x005994A2 File Offset: 0x005976A2
		public int SlideSpeed { get; set; }

		// Token: 0x1700B49B RID: 46235
		// (get) Token: 0x06028FB0 RID: 167856 RVA: 0x005994AB File Offset: 0x005976AB
		// (set) Token: 0x06028FB1 RID: 167857 RVA: 0x005994B3 File Offset: 0x005976B3
		public int UpSpeed { get; set; }

		// Token: 0x1700B49C RID: 46236
		// (get) Token: 0x06028FB2 RID: 167858 RVA: 0x005994BC File Offset: 0x005976BC
		// (set) Token: 0x06028FB3 RID: 167859 RVA: 0x005994C4 File Offset: 0x005976C4
		public int DownSpeed { get; set; }

		// Token: 0x1700B49D RID: 46237
		// (get) Token: 0x06028FB4 RID: 167860 RVA: 0x005994CD File Offset: 0x005976CD
		// (set) Token: 0x06028FB5 RID: 167861 RVA: 0x005994D5 File Offset: 0x005976D5
		public int RailSplineEntityId { get; set; }

		// Token: 0x1700B49E RID: 46238
		// (get) Token: 0x06028FB6 RID: 167862 RVA: 0x005994DE File Offset: 0x005976DE
		// (set) Token: 0x06028FB7 RID: 167863 RVA: 0x005994E6 File Offset: 0x005976E6
		public List<IExchangeSlideRailConfigT> ExchangeRailConfigs { get; set; }

		// Token: 0x1700B49F RID: 46239
		// (get) Token: 0x06028FB8 RID: 167864 RVA: 0x005994EF File Offset: 0x005976EF
		// (set) Token: 0x06028FB9 RID: 167865 RVA: 0x005994F7 File Offset: 0x005976F7
		public byte NullMask { get; set; }

		// Token: 0x06028FBA RID: 167866 RVA: 0x00599500 File Offset: 0x00597700
		public ISlideRailComponentT()
		{
			this.Disabled = false;
			this.SlideSpeed = 0;
			this.UpSpeed = 0;
			this.DownSpeed = 0;
			this.RailSplineEntityId = 0;
			this.ExchangeRailConfigs = null;
			this.NullMask = 0;
		}
	}
}
