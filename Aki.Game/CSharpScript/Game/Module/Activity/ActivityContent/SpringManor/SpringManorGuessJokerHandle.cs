using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006034 RID: 24628
	public class SpringManorGuessJokerHandle : SpringManorGameHandleBase
	{
		// Token: 0x0603E521 RID: 255265 RVA: 0x00F0D10E File Offset: 0x00F0B30E
		public override int GetCurrentProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetGuessJokerCurrentProgress();
		}

		// Token: 0x0603E522 RID: 255266 RVA: 0x00F0D125 File Offset: 0x00F0B325
		public override int GetTotalProgress()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance == null)
			{
				return 0;
			}
			return instance.ActivityData.GetGuessJokerTotalProgress();
		}

		// Token: 0x0603E523 RID: 255267 RVA: 0x00F0D13C File Offset: 0x00F0B33C
		public override void EnterGame()
		{
			GuessJokerGamePlayModel.Instance.OpenSelectRoleView(0).ContinueWith(delegate()
			{
				UiManager.Instance.CloseView(EUiViewName.SpringManorGameplayEntryView, null);
			});
		}

		// Token: 0x0603E524 RID: 255268 RVA: 0x00F0D16E File Offset: 0x00F0B36E
		public override ERedDotName? GetRedDotName()
		{
			return new ERedDotName?(ERedDotName.GuessJokerUnlockLevel);
		}
	}
}
