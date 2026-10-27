using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200503D RID: 20541
	public class ICountDownTextTipT
	{
		// Token: 0x1700950F RID: 38159
		// (get) Token: 0x06020E9D RID: 134813 RVA: 0x0049381B File Offset: 0x00491A1B
		// (set) Token: 0x06020E9E RID: 134814 RVA: 0x00493823 File Offset: 0x00491A23
		public ETrampleTipType Type { get; set; }

		// Token: 0x17009510 RID: 38160
		// (get) Token: 0x06020E9F RID: 134815 RVA: 0x0049382C File Offset: 0x00491A2C
		// (set) Token: 0x06020EA0 RID: 134816 RVA: 0x00493834 File Offset: 0x00491A34
		public string TidCountDownTip { get; set; }

		// Token: 0x06020EA1 RID: 134817 RVA: 0x0049383D File Offset: 0x00491A3D
		public ICountDownTextTipT()
		{
			this.Type = ETrampleTipType.CountDownTextTip;
			this.TidCountDownTip = null;
		}
	}
}
