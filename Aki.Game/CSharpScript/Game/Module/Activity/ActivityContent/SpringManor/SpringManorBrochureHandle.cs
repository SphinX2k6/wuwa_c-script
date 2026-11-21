using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FAF RID: 20399
	public class SpringManorBrochureHandle : SpringManorGameHandleBase
	{
		// Token: 0x060331D6 RID: 209366 RVA: 0x00E53A84 File Offset: 0x00E51C84
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

		// Token: 0x060331D7 RID: 209367 RVA: 0x00E53B4C File Offset: 0x00E51D4C
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

		// Token: 0x060331D8 RID: 209368 RVA: 0x00E53BE9 File Offset: 0x00E51DE9
		public override void EnterGame()
		{
			UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, null, null);
		}

		// Token: 0x060331D9 RID: 209369 RVA: 0x00E53BFC File Offset: 0x00E51DFC
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.SpringManorBrochureReward);
		}
	}
}
