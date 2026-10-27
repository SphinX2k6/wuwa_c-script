using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007506 RID: 29958
	public class IVehicleEnteringNpcTargetT
	{
		// Token: 0x1700E354 RID: 58196
		// (get) Token: 0x060367B8 RID: 223160 RVA: 0x00766C6C File Offset: 0x00764E6C
		// (set) Token: 0x060367B9 RID: 223161 RVA: 0x00766C74 File Offset: 0x00764E74
		public EVehicleEnteringTarget Type { get; set; }

		// Token: 0x1700E355 RID: 58197
		// (get) Token: 0x060367BA RID: 223162 RVA: 0x00766C7D File Offset: 0x00764E7D
		// (set) Token: 0x060367BB RID: 223163 RVA: 0x00766C85 File Offset: 0x00764E85
		public int TargetVehicle { get; set; }

		// Token: 0x1700E356 RID: 58198
		// (get) Token: 0x060367BC RID: 223164 RVA: 0x00766C8E File Offset: 0x00764E8E
		// (set) Token: 0x060367BD RID: 223165 RVA: 0x00766C96 File Offset: 0x00764E96
		public int TargetNpc { get; set; }

		// Token: 0x1700E357 RID: 58199
		// (get) Token: 0x060367BE RID: 223166 RVA: 0x00766C9F File Offset: 0x00764E9F
		// (set) Token: 0x060367BF RID: 223167 RVA: 0x00766CA7 File Offset: 0x00764EA7
		public byte NullMask { get; set; }

		// Token: 0x060367C0 RID: 223168 RVA: 0x00766CB0 File Offset: 0x00764EB0
		public IVehicleEnteringNpcTargetT()
		{
			this.Type = EVehicleEnteringTarget.Player;
			this.TargetVehicle = 0;
			this.TargetNpc = 0;
			this.NullMask = 0;
		}
	}
}
