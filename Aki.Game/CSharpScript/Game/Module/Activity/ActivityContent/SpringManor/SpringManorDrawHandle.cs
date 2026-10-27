using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006032 RID: 24626
	public class SpringManorDrawHandle : SpringManorGameHandleBase
	{
		// Token: 0x0603E517 RID: 255255 RVA: 0x00F0CE4C File Offset: 0x00F0B04C
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
			Brochure? brochure = (instance2 != null) ? instance2.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.Character) : null;
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
			SpringManorConfig instance3 = SpringManorConfig.Instance;
			Brochure? brochure2 = (instance3 != null) ? instance3.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.EasterEggBook) : null;
			if (brochure2 != null)
			{
				for (int j = 0; j < brochure2.Value.BookItemIdsLength; j++)
				{
					int id2 = brochure2.Value.BookItemIds(j);
					if (SpringManorModel.Instance.ActivityData.GetBookItemStateById(id2) == EBrochureState.Rewarded)
					{
						num3++;
					}
				}
			}
			return num3;
		}

		// Token: 0x0603E518 RID: 255256 RVA: 0x00F0CF8C File Offset: 0x00F0B18C
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
			int? num3;
			if (instance2 == null)
			{
				num3 = null;
			}
			else
			{
				Brochure? springManorBrochureByActivityAndType = instance2.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.Character);
				num3 = ((springManorBrochureByActivityAndType != null) ? new int?(springManorBrochureByActivityAndType.GetValueOrDefault().BookItemIdsLength) : null);
			}
			int? num4 = num3;
			int valueOrDefault = num4.GetValueOrDefault();
			SpringManorConfig instance3 = SpringManorConfig.Instance;
			int? num5;
			if (instance3 == null)
			{
				num5 = null;
			}
			else
			{
				Brochure? springManorBrochureByActivityAndType = instance3.GetSpringManorBrochureByActivityAndType(num2.Value, EBrochureType.EasterEggBook);
				num5 = ((springManorBrochureByActivityAndType != null) ? new int?(springManorBrochureByActivityAndType.GetValueOrDefault().BookItemIdsLength) : null);
			}
			num4 = num5;
			int valueOrDefault2 = num4.GetValueOrDefault();
			return valueOrDefault + valueOrDefault2;
		}

		// Token: 0x0603E519 RID: 255257 RVA: 0x00F0D080 File Offset: 0x00F0B280
		public override void EnterGame()
		{
			SpringManorAlbumViewOpenParam param = new SpringManorAlbumViewOpenParam
			{
				OpenTab = EBrochureType.Character
			};
			UiManager.Instance.OpenView(EUiViewName.SpringManorAlbumView, param, null);
		}

		// Token: 0x0603E51A RID: 255258 RVA: 0x00F0D0AB File Offset: 0x00F0B2AB
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.SpringManorAlbumReward);
		}
	}
}
