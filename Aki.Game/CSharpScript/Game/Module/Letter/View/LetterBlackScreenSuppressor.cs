using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020056CC RID: 22220
	public class LetterBlackScreenSuppressor
	{
		// Token: 0x06038842 RID: 231490 RVA: 0x00D6C8D0 File Offset: 0x00D6AAD0
		public void Suppress()
		{
			if (this.IsSuppressed)
			{
				return;
			}
			if (!LevelLoadingController.Instance.CheckIsOpen(new ELoadingPerform?(ELoadingPerform.CameraFade)))
			{
				return;
			}
			this.IsSuppressed = true;
			this.SavedScreenType = BlackScreenFadeController.Instance.GetScreenColorType().GetValueOrDefault(EFadeInScreenShowType.Black);
			Global.CharacterCameraManager.FadeAmount = 0f;
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, null, null, null);
		}

		// Token: 0x06038843 RID: 231491 RVA: 0x00D6C940 File Offset: 0x00D6AB40
		public UniTask Restore()
		{
			LetterBlackScreenSuppressor.<Restore>d__4 <Restore>d__;
			<Restore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Restore>d__.<>4__this = this;
			<Restore>d__.<>1__state = -1;
			<Restore>d__.<>t__builder.Start<LetterBlackScreenSuppressor.<Restore>d__4>(ref <Restore>d__);
			return <Restore>d__.<>t__builder.Task;
		}

		// Token: 0x0401DAFD RID: 121597
		private const float FadeInDurationSec = 0.001f;

		// Token: 0x0401DAFE RID: 121598
		private bool IsSuppressed;

		// Token: 0x0401DAFF RID: 121599
		private EFadeInScreenShowType SavedScreenType = EFadeInScreenShowType.Black;
	}
}
