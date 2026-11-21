using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B4 RID: 22708
	public class SolarSchoolEndingSummaryAction : SolarSchoolActionBase
	{
		// Token: 0x06037EF3 RID: 229107 RVA: 0x00FA26A0 File Offset: 0x00FA08A0
		protected override void OnStart()
		{
			SolarSchoolModel.Instance.BeginDayChangeLoading();
			SolarSchoolEndingSummaryViewParam param = new SolarSchoolEndingSummaryViewParam(SolarSchoolGamePlayModel.Instance.ActivityId, new Action(base.MarkDone));
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolEndingSummaryView, param, null);
			this.ViewOpened = true;
		}

		// Token: 0x06037EF4 RID: 229108 RVA: 0x00FA26EB File Offset: 0x00FA08EB
		protected override void OnDelete()
		{
			if (!this.ViewOpened)
			{
				return;
			}
			this.ViewOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolEndingSummaryView, null);
		}

		// Token: 0x0401D810 RID: 120848
		private bool ViewOpened;
	}
}
