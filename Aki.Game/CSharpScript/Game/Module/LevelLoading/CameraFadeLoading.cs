using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Extension;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x020056BC RID: 22204
	[NullableContext(2)]
	[Nullable(0)]
	public class CameraFadeLoading
	{
		// Token: 0x060387C7 RID: 231367 RVA: 0x00D6AEB8 File Offset: 0x00D690B8
		public void EnterInterlude(float? duration = null, bool needBackToFight = false, bool? needCheckOpenView = null, int? treeId = null, EFadeInScreenShowType screenType = EFadeInScreenShowType.Black, Action callback = null)
		{
			float num = Math.Clamp(duration.GetValueOrDefault(1f), 0f, 30f);
			this.FadeIn(num * (float)TimeUtil.Instance.InverseMillisecond, needBackToFight, needCheckOpenView.GetValueOrDefault(true), treeId, screenType, callback);
		}

		// Token: 0x060387C8 RID: 231368 RVA: 0x00D6AF04 File Offset: 0x00D69104
		public void ExitInterlude(float duration = 1f, Action callback = null)
		{
			float num = Math.Clamp(duration, 0f, 30f);
			this.FadeOut(num * (float)TimeUtil.Instance.InverseMillisecond, callback);
		}

		// Token: 0x060387C9 RID: 231369 RVA: 0x00D6AF36 File Offset: 0x00D69136
		public bool IsInFade()
		{
			return this.LoadingFade;
		}

		// Token: 0x060387CA RID: 231370 RVA: 0x00D6AF3E File Offset: 0x00D6913E
		public bool IsInFadeOut()
		{
			return LevelLoadingModel.Instance.CameraFadeHidePromise != null;
		}

		// Token: 0x060387CB RID: 231371 RVA: 0x00D6AF50 File Offset: 0x00D69150
		private void FadeIn(float duration = 1f, bool needBackToFight = false, bool needCheckOpenView = true, int? treeId = null, EFadeInScreenShowType screenType = EFadeInScreenShowType.Black, Action callback = null)
		{
			if (this.LoadingFade)
			{
				return;
			}
			this.LoadingFade = true;
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (screenType != EFadeInScreenShowType.White)
			{
				if (screenType == EFadeInScreenShowType.Black)
				{
					characterCameraManager.FadeColor = this.ColorBlack;
				}
			}
			else
			{
				characterCameraManager.FadeColor = this.ColorWhite;
			}
			BlackScreenFadeController.Instance.ChangeColor(screenType);
			this.AddBlackScreen(duration, needBackToFight, needCheckOpenView, treeId).Finally(delegate()
			{
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}).Forget();
		}

		// Token: 0x060387CC RID: 231372 RVA: 0x00D6AFD4 File Offset: 0x00D691D4
		private void FadeOut(float duration = 1f, Action callback = null)
		{
			this.RemoveBlackScreen(duration).Finally(delegate()
			{
				this.LoadingFade = false;
				Action callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2();
			}).Forget();
		}

		// Token: 0x060387CD RID: 231373 RVA: 0x00D6B014 File Offset: 0x00D69214
		private UniTask AddBlackScreen(float num, bool needBackToFight = false, bool needCheckOpenView = true, int? treeId = null)
		{
			CameraFadeLoading.<AddBlackScreen>d__12 <AddBlackScreen>d__;
			<AddBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddBlackScreen>d__.num = num;
			<AddBlackScreen>d__.needBackToFight = needBackToFight;
			<AddBlackScreen>d__.needCheckOpenView = needCheckOpenView;
			<AddBlackScreen>d__.treeId = treeId;
			<AddBlackScreen>d__.<>1__state = -1;
			<AddBlackScreen>d__.<>t__builder.Start<CameraFadeLoading.<AddBlackScreen>d__12>(ref <AddBlackScreen>d__);
			return <AddBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x060387CE RID: 231374 RVA: 0x00D6B070 File Offset: 0x00D69270
		private UniTask RemoveBlackScreen(float num)
		{
			CameraFadeLoading.<RemoveBlackScreen>d__13 <RemoveBlackScreen>d__;
			<RemoveBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveBlackScreen>d__.num = num;
			<RemoveBlackScreen>d__.<>1__state = -1;
			<RemoveBlackScreen>d__.<>t__builder.Start<CameraFadeLoading.<RemoveBlackScreen>d__13>(ref <RemoveBlackScreen>d__);
			return <RemoveBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x060387CF RID: 231375 RVA: 0x00D6B0B4 File Offset: 0x00D692B4
		public EFadeInScreenShowType ColorSearch()
		{
			if (Global.CharacterCameraManager.FadeColor.R >= 0.5f && Global.CharacterCameraManager.FadeColor.G >= 0.5f && Global.CharacterCameraManager.FadeColor.B >= 0.5f)
			{
				return EFadeInScreenShowType.White;
			}
			return EFadeInScreenShowType.Black;
		}

		// Token: 0x060387D0 RID: 231376 RVA: 0x00D6B108 File Offset: 0x00D69308
		public bool SetColor(EFadeInScreenShowType type)
		{
			if (!this.IsInFade())
			{
				return false;
			}
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (type != EFadeInScreenShowType.White)
			{
				if (type == EFadeInScreenShowType.Black)
				{
					characterCameraManager.FadeColor = this.ColorBlack;
				}
			}
			else
			{
				characterCameraManager.FadeColor = this.ColorWhite;
			}
			BlackScreenFadeController.Instance.ChangeColor(type);
			return true;
		}

		// Token: 0x0401DAA4 RID: 121508
		private bool LoadingFade;

		// Token: 0x0401DAA5 RID: 121509
		private readonly FLinearColor ColorBlack = new FLinearColor(0f, 0f, 0f, 1f);

		// Token: 0x0401DAA6 RID: 121510
		private readonly FLinearColor ColorWhite = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x0401DAA7 RID: 121511
		private const float INTERLUDE_FADE_IN_TIME = 1f;

		// Token: 0x0401DAA8 RID: 121512
		private const float INTERLUDE_FADE_OUT_TIME = 1f;

		// Token: 0x0401DAA9 RID: 121513
		private const float INTERLUDE_LIMIT_TIME = 30f;
	}
}
