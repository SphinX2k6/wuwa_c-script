using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E6D RID: 15981
	public class IFocusModeSettingT
	{
		// Token: 0x17006ECD RID: 28365
		// (get) Token: 0x06016819 RID: 92185 RVA: 0x00340CA2 File Offset: 0x0033EEA2
		// (set) Token: 0x0601681A RID: 92186 RVA: 0x00340CAA File Offset: 0x0033EEAA
		public bool CanOpenFocusMode { get; set; }

		// Token: 0x17006ECE RID: 28366
		// (get) Token: 0x0601681B RID: 92187 RVA: 0x00340CB3 File Offset: 0x0033EEB3
		// (set) Token: 0x0601681C RID: 92188 RVA: 0x00340CBB File Offset: 0x0033EEBB
		public bool IsFocusModeInherit { get; set; }

		// Token: 0x17006ECF RID: 28367
		// (get) Token: 0x0601681D RID: 92189 RVA: 0x00340CC4 File Offset: 0x0033EEC4
		// (set) Token: 0x0601681E RID: 92190 RVA: 0x00340CCC File Offset: 0x0033EECC
		public bool CanAcceptInFocusMode { get; set; }

		// Token: 0x17006ED0 RID: 28368
		// (get) Token: 0x0601681F RID: 92191 RVA: 0x00340CD5 File Offset: 0x0033EED5
		// (set) Token: 0x06016820 RID: 92192 RVA: 0x00340CDD File Offset: 0x0033EEDD
		public bool IsFocusModeWhiteList { get; set; }

		// Token: 0x17006ED1 RID: 28369
		// (get) Token: 0x06016821 RID: 92193 RVA: 0x00340CE6 File Offset: 0x0033EEE6
		// (set) Token: 0x06016822 RID: 92194 RVA: 0x00340CEE File Offset: 0x0033EEEE
		public byte NullMask { get; set; }

		// Token: 0x06016823 RID: 92195 RVA: 0x00340CF7 File Offset: 0x0033EEF7
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
