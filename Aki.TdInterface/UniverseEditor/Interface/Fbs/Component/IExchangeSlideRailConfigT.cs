using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CC RID: 20940
	public class IExchangeSlideRailConfigT
	{
		// Token: 0x17009940 RID: 39232
		// (get) Token: 0x06021F40 RID: 139072 RVA: 0x004B5E33 File Offset: 0x004B4033
		// (set) Token: 0x06021F41 RID: 139073 RVA: 0x004B5E3B File Offset: 0x004B403B
		public int MaxExchangeDistance { get; set; }

		// Token: 0x17009941 RID: 39233
		// (get) Token: 0x06021F42 RID: 139074 RVA: 0x004B5E44 File Offset: 0x004B4044
		// (set) Token: 0x06021F43 RID: 139075 RVA: 0x004B5E4C File Offset: 0x004B404C
		public int MaxExchangeHigh { get; set; }

		// Token: 0x17009942 RID: 39234
		// (get) Token: 0x06021F44 RID: 139076 RVA: 0x004B5E55 File Offset: 0x004B4055
		// (set) Token: 0x06021F45 RID: 139077 RVA: 0x004B5E5D File Offset: 0x004B405D
		public List<INextSlideRailT> NextRails { get; set; }

		// Token: 0x17009943 RID: 39235
		// (get) Token: 0x06021F46 RID: 139078 RVA: 0x004B5E66 File Offset: 0x004B4066
		// (set) Token: 0x06021F47 RID: 139079 RVA: 0x004B5E6E File Offset: 0x004B406E
		public byte NullMask { get; set; }

		// Token: 0x06021F48 RID: 139080 RVA: 0x004B5E77 File Offset: 0x004B4077
		public IExchangeSlideRailConfigT()
		{
			this.MaxExchangeDistance = 0;
			this.MaxExchangeHigh = 0;
			this.NextRails = null;
			this.NullMask = 0;
		}
	}
}
