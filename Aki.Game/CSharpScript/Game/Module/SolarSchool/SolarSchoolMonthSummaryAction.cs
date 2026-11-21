using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058BD RID: 22717
	public class SolarSchoolMonthSummaryAction : SolarSchoolActionBase
	{
		// Token: 0x06037F1C RID: 229148 RVA: 0x00FA3286 File Offset: 0x00FA1486
		protected override void OnStart()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolMonthSummaryView, new Action(this.<OnStart>g__OnViewClosed|1_0), null);
			this.ViewOpened = true;
		}

		// Token: 0x06037F1D RID: 229149 RVA: 0x00FA32AB File Offset: 0x00FA14AB
		protected override void OnDelete()
		{
			this.CloseOpenedView();
		}

		// Token: 0x06037F1E RID: 229150 RVA: 0x00FA32B3 File Offset: 0x00FA14B3
		private void CloseOpenedView()
		{
			if (!this.ViewOpened)
			{
				return;
			}
			this.ViewOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolMonthSummaryView, null);
		}

		// Token: 0x06037F20 RID: 229152 RVA: 0x00FA32DD File Offset: 0x00FA14DD
		[CompilerGenerated]
		private void <OnStart>g__OnViewClosed|1_0()
		{
			this.ViewOpened = false;
			base.MarkDone();
		}

		// Token: 0x0401D825 RID: 120869
		private bool ViewOpened;
	}
}
