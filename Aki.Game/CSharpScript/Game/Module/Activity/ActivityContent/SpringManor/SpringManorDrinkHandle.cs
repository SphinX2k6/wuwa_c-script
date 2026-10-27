using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006033 RID: 24627
	public class SpringManorDrinkHandle : SpringManorGameHandleBase
	{
		// Token: 0x0603E51C RID: 255260 RVA: 0x00F0D0BF File Offset: 0x00F0B2BF
		public override int GetCurrentProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetDrinksCurrentProgress();
		}

		// Token: 0x0603E51D RID: 255261 RVA: 0x00F0D0D6 File Offset: 0x00F0B2D6
		public override int GetTotalProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetDrinksTotalProgress();
		}

		// Token: 0x0603E51E RID: 255262 RVA: 0x00F0D0ED File Offset: 0x00F0B2ED
		public override void EnterGame()
		{
			DrinksController.Instance.OpenMainView(EDrinksGameplayOpenWay.FromView);
		}

		// Token: 0x0603E51F RID: 255263 RVA: 0x00F0D0FA File Offset: 0x00F0B2FA
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.DrinksUnlockLevel);
		}
	}
}
