using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006031 RID: 24625
	public class SpringManorBrochureHandle : SpringManorGameHandleBase
	{
		// Token: 0x0603E512 RID: 255250 RVA: 0x00F0CCC0 File Offset: 0x00F0AEC0
		public override int GetCurrentProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				SpringManorData activityData = instance.ActivityData;
				num = ((activityData != null) ? new int?(activityData.Id) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return 0;
			}
			int num3 = 0;
			SpringManorConfig instance2 = SpringManorConfig.Instance;
			Brochure? brochure = (instance2 != null) ? instance2.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.Brochure) : null;
			if (brochure != null)
			{
				for (int i = 0; i < brochure.Value.BookItemIdsLength; i++)
				{
					int id = brochure.Value.BookItemIds(i);
					if (SpringManorModel.Instance.ActivityData.GetBookItemStateById(id) == EBrochureState.Rewarded)
					{
						num3++;
					}
				}
			}
			return num3;
		}

		// Token: 0x0603E513 RID: 255251 RVA: 0x00F0CD88 File Offset: 0x00F0AF88
		public override int GetTotalProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				SpringManorData activityData = instance.ActivityData;
				num = ((activityData != null) ? new int?(activityData.Id) : null);
			}
			int? num2 = num;
			if (num2 == null)
			{
				return 0;
			}
			SpringManorConfig instance2 = SpringManorConfig.Instance;
			Brochure? brochure;
			return ((instance2 != null) ? ((instance2.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.Brochure) != null) ? new int?(brochure.GetValueOrDefault().BookItemIdsLength) : null) : null).GetValueOrDefault();
		}

		// Token: 0x0603E514 RID: 255252 RVA: 0x00F0CE25 File Offset: 0x00F0B025
		public override void EnterGame()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, null, null);
		}

		// Token: 0x0603E515 RID: 255253 RVA: 0x00F0CE38 File Offset: 0x00F0B038
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.SpringManorBrochureReward);
		}
	}
}
