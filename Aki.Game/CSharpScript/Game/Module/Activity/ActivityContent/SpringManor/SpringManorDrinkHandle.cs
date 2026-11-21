using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FB1 RID: 20401
	public class SpringManorDrinkHandle : SpringManorGameHandleBase
	{
		// Token: 0x060331E0 RID: 209376 RVA: 0x00E53E83 File Offset: 0x00E52083
		public override int GetCurrentProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetDrinksCurrentProgress();
		}

		// Token: 0x060331E1 RID: 209377 RVA: 0x00E53E9A File Offset: 0x00E5209A
		public override int GetTotalProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetDrinksTotalProgress();
		}

		// Token: 0x060331E2 RID: 209378 RVA: 0x00E53EB1 File Offset: 0x00E520B1
		public override void EnterGame()
		{
			DrinksController.Instance.OpenMainView(EDrinksGameplayOpenWay.FromView);
		}

		// Token: 0x060331E3 RID: 209379 RVA: 0x00E53EBE File Offset: 0x00E520BE
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.DrinksUnlockLevel);
		}
	}
}
