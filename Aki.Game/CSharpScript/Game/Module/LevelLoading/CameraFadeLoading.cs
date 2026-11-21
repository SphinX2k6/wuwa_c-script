using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Extension;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.LevelLoading
{
	// Token: 0x02004693 RID: 18067
	[NullableContext(2)]
	[Nullable(0)]
	public class CameraFadeLoading
	{
		// Token: 0x0602D6CE RID: 186062 RVA: 0x00CB9000 File Offset: 0x00CB7200
		public void EnterInterlude(float? duration = null, bool needBackToFight = false, bool? needCheckOpenView = null, int? treeId = null, EFadeInScreenShowType screenType = EFadeInScreenShowType.Black, Action callback = null)
		{
			float num = Math.Clamp(duration.GetValueOrDefault(1f), 0f, 30f);
			this.FadeIn(num * (float)TimeUtil.Instance.InverseMillisecond, needBackToFight, needCheckOpenView.GetValueOrDefault(true), treeId, screenType, callback);
		}

		// Token: 0x0602D6CF RID: 186063 RVA: 0x00CB904C File Offset: 0x00CB724C
		public void ExitInterlude(float duration = 1f, Action callback = null)
		{
			float num = Math.Clamp(duration, 0f, 30f);
			this.FadeOut(num * (float)TimeUtil.Instance.InverseMillisecond, callback);
		}

		// Token: 0x0602D6D0 RID: 186064 RVA: 0x00CB907E File Offset: 0x00CB727E
		public bool IsInFade()
		{
			return this.LoadingFade;
		}

		// Token: 0x0602D6D1 RID: 186065 RVA: 0x00CB9086 File Offset: 0x00CB7286
		public bool IsInFadeOut()
		{
			return LevelLoadingModel.Instance.CameraFadeHidePromise != null;
		}

		// Token: 0x0602D6D2 RID: 186066 RVA: 0x00CB9098 File Offset: 0x00CB7298
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

		// Token: 0x0602D6D3 RID: 186067 RVA: 0x00CB911C File Offset: 0x00CB731C
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

		// Token: 0x0602D6D4 RID: 186068 RVA: 0x00CB915C File Offset: 0x00CB735C
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

		// Token: 0x0602D6D5 RID: 186069 RVA: 0x00CB91B8 File Offset: 0x00CB73B8
		private UniTask RemoveBlackScreen(float num)
		{
			CameraFadeLoading.<RemoveBlackScreen>d__13 <RemoveBlackScreen>d__;
			<RemoveBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveBlackScreen>d__.num = num;
			<RemoveBlackScreen>d__.<>1__state = -1;
			<RemoveBlackScreen>d__.<>t__builder.Start<CameraFadeLoading.<RemoveBlackScreen>d__13>(ref <RemoveBlackScreen>d__);
			return <RemoveBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6D6 RID: 186070 RVA: 0x00CB91FC File Offset: 0x00CB73FC
		public EFadeInScreenShowType ColorSearch()
		{
			if (Global.CharacterCameraManager.FadeColor.R >= 0.5f && Global.CharacterCameraManager.FadeColor.G >= 0.5f && Global.CharacterCameraManager.FadeColor.B >= 0.5f)
			{
				return EFadeInScreenShowType.White;
			}
			return EFadeInScreenShowType.Black;
		}

		// Token: 0x0602D6D7 RID: 186071 RVA: 0x00CB9250 File Offset: 0x00CB7450
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
			BlackScreenFadeController.Instance.ChangeColorByForce(type);
			return true;
		}

		// Token: 0x04018531 RID: 99633
		private bool LoadingFade;

		// Token: 0x04018532 RID: 99634
		private readonly FLinearColor ColorBlack = new FLinearColor(0f, 0f, 0f, 1f);

		// Token: 0x04018533 RID: 99635
		private readonly FLinearColor ColorWhite = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x04018534 RID: 99636
		private const float INTERLUDE_FADE_IN_TIME = 1f;

		// Token: 0x04018535 RID: 99637
		private const float INTERLUDE_FADE_OUT_TIME = 1f;

		// Token: 0x04018536 RID: 99638
		private const float INTERLUDE_LIMIT_TIME = 30f;
	}
}
