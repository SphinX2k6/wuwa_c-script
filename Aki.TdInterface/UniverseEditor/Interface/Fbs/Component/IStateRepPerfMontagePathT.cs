using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BA RID: 22970
	public class IStateRepPerfMontagePathT
	{
		// Token: 0x1700AC5E RID: 44126
		// (get) Token: 0x06026EBD RID: 159421 RVA: 0x0055ADAC File Offset: 0x00558FAC
		// (set) Token: 0x06026EBE RID: 159422 RVA: 0x0055ADB4 File Offset: 0x00558FB4
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700AC5F RID: 44127
		// (get) Token: 0x06026EBF RID: 159423 RVA: 0x0055ADBD File Offset: 0x00558FBD
		// (set) Token: 0x06026EC0 RID: 159424 RVA: 0x0055ADC5 File Offset: 0x00558FC5
		public string MontagePath { get; set; }

		// Token: 0x1700AC60 RID: 44128
		// (get) Token: 0x06026EC1 RID: 159425 RVA: 0x0055ADCE File Offset: 0x00558FCE
		// (set) Token: 0x06026EC2 RID: 159426 RVA: 0x0055ADD6 File Offset: 0x00558FD6
		public string MontageName { get; set; }

		// Token: 0x06026EC3 RID: 159427 RVA: 0x0055ADDF File Offset: 0x00558FDF
		public IStateRepPerfMontagePathT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.MontagePath = null;
			this.MontageName = null;
		}
	}
}
