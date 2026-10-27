using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A15 RID: 27157
	public class ILimitPlayerBlockAllT
	{
		// Token: 0x1700C979 RID: 51577
		// (get) Token: 0x0602F85D RID: 194653 RVA: 0x006786E2 File Offset: 0x006768E2
		// (set) Token: 0x0602F85E RID: 194654 RVA: 0x006786EA File Offset: 0x006768EA
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F85F RID: 194655 RVA: 0x006786F3 File Offset: 0x006768F3
		public ILimitPlayerBlockAllT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
