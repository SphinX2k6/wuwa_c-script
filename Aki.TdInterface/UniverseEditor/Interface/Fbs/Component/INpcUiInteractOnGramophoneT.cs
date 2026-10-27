using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005675 RID: 22133
	public class INpcUiInteractOnGramophoneT
	{
		// Token: 0x1700A433 RID: 42035
		// (get) Token: 0x06024DA3 RID: 150947 RVA: 0x00515F63 File Offset: 0x00514163
		// (set) Token: 0x06024DA4 RID: 150948 RVA: 0x00515F6B File Offset: 0x0051416B
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A434 RID: 42036
		// (get) Token: 0x06024DA5 RID: 150949 RVA: 0x00515F74 File Offset: 0x00514174
		// (set) Token: 0x06024DA6 RID: 150950 RVA: 0x00515F7C File Offset: 0x0051417C
		public string EnterMontage { get; set; }

		// Token: 0x1700A435 RID: 42037
		// (get) Token: 0x06024DA7 RID: 150951 RVA: 0x00515F85 File Offset: 0x00514185
		// (set) Token: 0x06024DA8 RID: 150952 RVA: 0x00515F8D File Offset: 0x0051418D
		public string StandByMontage { get; set; }

		// Token: 0x1700A436 RID: 42038
		// (get) Token: 0x06024DA9 RID: 150953 RVA: 0x00515F96 File Offset: 0x00514196
		// (set) Token: 0x06024DAA RID: 150954 RVA: 0x00515F9E File Offset: 0x0051419E
		public string SwitchMusicMontage { get; set; }

		// Token: 0x1700A437 RID: 42039
		// (get) Token: 0x06024DAB RID: 150955 RVA: 0x00515FA7 File Offset: 0x005141A7
		// (set) Token: 0x06024DAC RID: 150956 RVA: 0x00515FAF File Offset: 0x005141AF
		public string ExitMontage { get; set; }

		// Token: 0x1700A438 RID: 42040
		// (get) Token: 0x06024DAD RID: 150957 RVA: 0x00515FB8 File Offset: 0x005141B8
		// (set) Token: 0x06024DAE RID: 150958 RVA: 0x00515FC0 File Offset: 0x005141C0
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A439 RID: 42041
		// (get) Token: 0x06024DAF RID: 150959 RVA: 0x00515FC9 File Offset: 0x005141C9
		// (set) Token: 0x06024DB0 RID: 150960 RVA: 0x00515FD1 File Offset: 0x005141D1
		public IPlayFlowT FailedFlow { get; set; }

		// Token: 0x1700A43A RID: 42042
		// (get) Token: 0x06024DB1 RID: 150961 RVA: 0x00515FDA File Offset: 0x005141DA
		// (set) Token: 0x06024DB2 RID: 150962 RVA: 0x00515FE2 File Offset: 0x005141E2
		public IPlayFlowT SuccessFlow { get; set; }

		// Token: 0x06024DB3 RID: 150963 RVA: 0x00515FEB File Offset: 0x005141EB
		public INpcUiInteractOnGramophoneT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.SwitchMusicMontage = null;
			this.ExitMontage = null;
			this.EnterFlow = null;
			this.FailedFlow = null;
			this.SuccessFlow = null;
		}
	}
}
