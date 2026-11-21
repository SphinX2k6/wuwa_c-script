using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Letter.View
{
	// Token: 0x020046A3 RID: 18083
	public class LetterBlackScreenSuppressor
	{
		// Token: 0x0602D752 RID: 186194 RVA: 0x00CBAE88 File Offset: 0x00CB9088
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

		// Token: 0x0602D753 RID: 186195 RVA: 0x00CBAEF8 File Offset: 0x00CB90F8
		public UniTask Restore()
		{
			LetterBlackScreenSuppressor.<Restore>d__4 <Restore>d__;
			<Restore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Restore>d__.<>4__this = this;
			<Restore>d__.<>1__state = -1;
			<Restore>d__.<>t__builder.Start<LetterBlackScreenSuppressor.<Restore>d__4>(ref <Restore>d__);
			return <Restore>d__.<>t__builder.Task;
		}

		// Token: 0x04018593 RID: 99731
		private const float FadeInDurationSec = 0.001f;

		// Token: 0x04018594 RID: 99732
		private bool IsSuppressed;

		// Token: 0x04018595 RID: 99733
		private EFadeInScreenShowType SavedScreenType = EFadeInScreenShowType.Black;
	}
}
