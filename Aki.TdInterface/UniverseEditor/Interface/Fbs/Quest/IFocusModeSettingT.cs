using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A8 RID: 17064
	public class IFocusModeSettingT
	{
		// Token: 0x170074B1 RID: 29873
		// (get) Token: 0x06017E40 RID: 97856 RVA: 0x003697D2 File Offset: 0x003679D2
		// (set) Token: 0x06017E41 RID: 97857 RVA: 0x003697DA File Offset: 0x003679DA
		public bool CanOpenFocusMode { get; set; }

		// Token: 0x170074B2 RID: 29874
		// (get) Token: 0x06017E42 RID: 97858 RVA: 0x003697E3 File Offset: 0x003679E3
		// (set) Token: 0x06017E43 RID: 97859 RVA: 0x003697EB File Offset: 0x003679EB
		public bool IsFocusModeInherit { get; set; }

		// Token: 0x170074B3 RID: 29875
		// (get) Token: 0x06017E44 RID: 97860 RVA: 0x003697F4 File Offset: 0x003679F4
		// (set) Token: 0x06017E45 RID: 97861 RVA: 0x003697FC File Offset: 0x003679FC
		public bool CanAcceptInFocusMode { get; set; }

		// Token: 0x170074B4 RID: 29876
		// (get) Token: 0x06017E46 RID: 97862 RVA: 0x00369805 File Offset: 0x00367A05
		// (set) Token: 0x06017E47 RID: 97863 RVA: 0x0036980D File Offset: 0x00367A0D
		public bool IsFocusModeWhiteList { get; set; }

		// Token: 0x170074B5 RID: 29877
		// (get) Token: 0x06017E48 RID: 97864 RVA: 0x00369816 File Offset: 0x00367A16
		// (set) Token: 0x06017E49 RID: 97865 RVA: 0x0036981E File Offset: 0x00367A1E
		public byte NullMask { get; set; }

		// Token: 0x06017E4A RID: 97866 RVA: 0x00369827 File Offset: 0x00367A27
		public IFocusModeSettingT()
		{
			this.CanOpenFocusMode = false;
			this.IsFocusModeInherit = false;
			this.CanAcceptInFocusMode = false;
			this.IsFocusModeWhiteList = false;
			this.NullMask = 0;
		}
	}
}
