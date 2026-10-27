using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005862 RID: 22626
	public class IResetSelfPosComponentT
	{
		// Token: 0x1700A928 RID: 43304
		// (get) Token: 0x060261AC RID: 156076 RVA: 0x00540ED8 File Offset: 0x0053F0D8
		// (set) Token: 0x060261AD RID: 156077 RVA: 0x00540EE0 File Offset: 0x0053F0E0
		public bool Disabled { get; set; }

		// Token: 0x1700A929 RID: 43305
		// (get) Token: 0x060261AE RID: 156078 RVA: 0x00540EE9 File Offset: 0x0053F0E9
		// (set) Token: 0x060261AF RID: 156079 RVA: 0x00540EF1 File Offset: 0x0053F0F1
		public float ResetRadius { get; set; }

		// Token: 0x1700A92A RID: 43306
		// (get) Token: 0x060261B0 RID: 156080 RVA: 0x00540EFA File Offset: 0x0053F0FA
		// (set) Token: 0x060261B1 RID: 156081 RVA: 0x00540F02 File Offset: 0x0053F102
		public bool IsDisableResetPosAfterThrow { get; set; }

		// Token: 0x1700A92B RID: 43307
		// (get) Token: 0x060261B2 RID: 156082 RVA: 0x00540F0B File Offset: 0x0053F10B
		// (set) Token: 0x060261B3 RID: 156083 RVA: 0x00540F13 File Offset: 0x0053F113
		public bool IsResetPosAfterThrow { get; set; }

		// Token: 0x1700A92C RID: 43308
		// (get) Token: 0x060261B4 RID: 156084 RVA: 0x00540F1C File Offset: 0x0053F11C
		// (set) Token: 0x060261B5 RID: 156085 RVA: 0x00540F24 File Offset: 0x0053F124
		public float ResetPosDelayTime { get; set; }

		// Token: 0x1700A92D RID: 43309
		// (get) Token: 0x060261B6 RID: 156086 RVA: 0x00540F2D File Offset: 0x0053F12D
		// (set) Token: 0x060261B7 RID: 156087 RVA: 0x00540F35 File Offset: 0x0053F135
		public byte NullMask { get; set; }

		// Token: 0x060261B8 RID: 156088 RVA: 0x00540F3E File Offset: 0x0053F13E
		public IResetSelfPosComponentT()
		{
			this.Disabled = false;
			this.ResetRadius = 0f;
			this.IsDisableResetPosAfterThrow = false;
			this.IsResetPosAfterThrow = false;
			this.ResetPosDelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
