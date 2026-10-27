using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABC RID: 27324
	public class IModifyAlertValueT
	{
		// Token: 0x1700CAC0 RID: 51904
		// (get) Token: 0x0602FE36 RID: 196150 RVA: 0x00683B6B File Offset: 0x00681D6B
		// (set) Token: 0x0602FE37 RID: 196151 RVA: 0x00683B73 File Offset: 0x00681D73
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700CAC1 RID: 51905
		// (get) Token: 0x0602FE38 RID: 196152 RVA: 0x00683B7C File Offset: 0x00681D7C
		// (set) Token: 0x0602FE39 RID: 196153 RVA: 0x00683B84 File Offset: 0x00681D84
		public int AreaId { get; set; }

		// Token: 0x1700CAC2 RID: 51906
		// (get) Token: 0x0602FE3A RID: 196154 RVA: 0x00683B8D File Offset: 0x00681D8D
		// (set) Token: 0x0602FE3B RID: 196155 RVA: 0x00683B95 File Offset: 0x00681D95
		public TSetAlertValueTypeUnion SetType { get; set; }

		// Token: 0x1700CAC3 RID: 51907
		// (get) Token: 0x0602FE3C RID: 196156 RVA: 0x00683B9E File Offset: 0x00681D9E
		// (set) Token: 0x0602FE3D RID: 196157 RVA: 0x00683BA6 File Offset: 0x00681DA6
		public TAlertValueChangeSpeedUnion ChangeSpeed { get; set; }

		// Token: 0x0602FE3E RID: 196158 RVA: 0x00683BAF File Offset: 0x00681DAF
		public IModifyAlertValueT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.SetType = null;
			this.ChangeSpeed = null;
		}
	}
}
