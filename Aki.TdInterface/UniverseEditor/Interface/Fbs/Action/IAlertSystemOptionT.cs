using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F4 RID: 26612
	public class IAlertSystemOptionT
	{
		// Token: 0x1700C3AA RID: 50090
		// (get) Token: 0x0602D75D RID: 186205 RVA: 0x006397B4 File Offset: 0x006379B4
		// (set) Token: 0x0602D75E RID: 186206 RVA: 0x006397BC File Offset: 0x006379BC
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700C3AB RID: 50091
		// (get) Token: 0x0602D75F RID: 186207 RVA: 0x006397C5 File Offset: 0x006379C5
		// (set) Token: 0x0602D760 RID: 186208 RVA: 0x006397CD File Offset: 0x006379CD
		public int AreaId { get; set; }

		// Token: 0x0602D761 RID: 186209 RVA: 0x006397D6 File Offset: 0x006379D6
		public IAlertSystemOptionT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
		}
	}
}
