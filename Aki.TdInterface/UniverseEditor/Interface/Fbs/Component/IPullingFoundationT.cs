using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AF RID: 22447
	public class IPullingFoundationT
	{
		// Token: 0x1700A795 RID: 42901
		// (get) Token: 0x06025ACE RID: 154318 RVA: 0x005326F1 File Offset: 0x005308F1
		// (set) Token: 0x06025ACF RID: 154319 RVA: 0x005326F9 File Offset: 0x005308F9
		public bool Disabled { get; set; }

		// Token: 0x1700A796 RID: 42902
		// (get) Token: 0x06025AD0 RID: 154320 RVA: 0x00532702 File Offset: 0x00530902
		// (set) Token: 0x06025AD1 RID: 154321 RVA: 0x0053270A File Offset: 0x0053090A
		public IPullingCategoryMatchingFoundationT Config { get; set; }

		// Token: 0x1700A797 RID: 42903
		// (get) Token: 0x06025AD2 RID: 154322 RVA: 0x00532713 File Offset: 0x00530913
		// (set) Token: 0x06025AD3 RID: 154323 RVA: 0x0053271B File Offset: 0x0053091B
		public byte NullMask { get; set; }

		// Token: 0x06025AD4 RID: 154324 RVA: 0x00532724 File Offset: 0x00530924
		public IPullingFoundationT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
