using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FB2 RID: 20402
	public class SpringManorGuessJokerHandle : SpringManorGameHandleBase
	{
		// Token: 0x060331E5 RID: 209381 RVA: 0x00E53ED2 File Offset: 0x00E520D2
		public override int GetCurrentProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetGuessJokerCurrentProgress();
		}

		// Token: 0x060331E6 RID: 209382 RVA: 0x00E53EE9 File Offset: 0x00E520E9
		public override int GetTotalProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetGuessJokerTotalProgress();
		}

		// Token: 0x060331E7 RID: 209383 RVA: 0x00E53F00 File Offset: 0x00E52100
		public override void EnterGame()
		{
			GuessJokerGamePlayModel.Instance.OpenSelectRoleView(0).ContinueWith(delegate()
			{
				UiManager.Instance.CloseView(EUiViewName.SpringManorGameplayEntryView, null);
			});
		}

		// Token: 0x060331E8 RID: 209384 RVA: 0x00E53F32 File Offset: 0x00E52132
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.GuessJokerUnlockLevel);
		}
	}
}
