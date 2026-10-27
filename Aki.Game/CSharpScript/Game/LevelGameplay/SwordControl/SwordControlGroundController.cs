using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SwordControl
{
	// Token: 0x020069EB RID: 27115
	[NullableContext(1)]
	[Nullable(0)]
	public class SwordControlGroundController : IStaticVariableResetter
	{
		// Token: 0x06043738 RID: 276280 RVA: 0x0107BE70 File Offset: 0x0107A070
		static SwordControlGroundController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SwordControlGroundController.CreateStaticDefaultValue), new Action(SwordControlGroundController.ResetStaticDefaultValue));
		}

		// Token: 0x06043739 RID: 276281 RVA: 0x0107BF98 File Offset: 0x0107A198
		public static void CreateStaticDefaultValue()
		{
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
			SwordControlGroundController.ViewId = null;
			SwordControlGroundController.TemporaryTimer = null;
			SwordControlGroundController.IsOpening = false;
			SwordControlGroundController.IsClosing = false;
			SwordControlGroundController.InputRestricted = false;
			SwordControlGroundController.CloseAfterOpen = false;
			SwordControlGroundController.PendingGameplayOpenAfterClose = false;
			SwordControlGroundController.PendingTemporaryDuration = 3000f;
			SwordControlGroundController.CloseEventListening = false;
		}

		// Token: 0x0604373A RID: 276282 RVA: 0x0107BFEC File Offset: 0x0107A1EC
		public static void ResetStaticDefaultValue()
		{
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
			SwordControlGroundController.ViewId = null;
			SwordControlGroundController.TemporaryTimer = null;
			SwordControlGroundController.IsOpening = false;
			SwordControlGroundController.IsClosing = false;
			SwordControlGroundController.InputRestricted = false;
			SwordControlGroundController.CloseAfterOpen = false;
			SwordControlGroundController.PendingGameplayOpenAfterClose = false;
			SwordControlGroundController.PendingTemporaryDuration = 3000f;
			SwordControlGroundController.CloseEventListening = false;
		}

		// Token: 0x0604373B RID: 276283 RVA: 0x0107C040 File Offset: 0x0107A240
		public static void OpenTemporary(float duration = 3000f)
		{
			if (SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.Gameplay)
			{
				SwordControlGroundController.LogReturn("OpenTemporary", "GameplayOwner", 0);
				return;
			}
			if (SwordControlGroundController.IsClosing)
			{
				SwordControlGroundController.LogReturn("OpenTemporary", "Closing", 0);
				return;
			}
			float num = SwordControlGroundController.NormalizeDuration(duration);
			if (SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.Temporary)
			{
				SwordControlGroundController.PendingTemporaryDuration = num;
				if (!SwordControlGroundController.IsOpening)
				{
					SwordControlGroundController.StartTemporaryTimer(num);
				}
				return;
			}
			if (SwordControlGroundController.IsOpening)
			{
				SwordControlGroundController.LogReturn("OpenTemporary", "OpeningWithoutTemporaryOwner", 0);
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.SwordControlGroundView))
			{
				SwordControlGroundController.LogReturn("OpenTemporary", "ViewAlreadyOpenWithoutOwner", 0);
				return;
			}
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.Temporary;
			SwordControlGroundController.IsOpening = true;
			SwordControlGroundController.CloseAfterOpen = false;
			SwordControlGroundController.PendingTemporaryDuration = num;
			UiManager instance = UiManager.Instance;
			EUiViewName swordControlGroundView = EUiViewName.SwordControlGroundView;
			object param = null;
			TOpenViewCallBack finishCallback;
			if ((finishCallback = SwordControlGroundController.<>O.<0>__OnOpenViewFinished) == null)
			{
				finishCallback = (SwordControlGroundController.<>O.<0>__OnOpenViewFinished = new TOpenViewCallBack(SwordControlGroundController.OnOpenViewFinished));
			}
			instance.OpenView(swordControlGroundView, param, finishCallback);
		}

		// Token: 0x0604373C RID: 276284 RVA: 0x0107C120 File Offset: 0x0107A320
		public static void OpenByGameplay()
		{
			SwordControlGroundController.RemoveTemporaryTimer();
			if (SwordControlGroundController.IsClosing)
			{
				SwordControlGroundController.LogReturn("OpenByGameplay", "ClosingAndPendingOpen", 0);
				SwordControlGroundController.PendingGameplayOpenAfterClose = true;
				return;
			}
			if (SwordControlGroundController.IsOpening)
			{
				SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.Gameplay;
				SwordControlGroundController.CloseAfterOpen = false;
				SwordControlGroundController.LogReturn("OpenByGameplay", "OpeningAndPendingOpen", 0);
				return;
			}
			if (SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.Gameplay)
			{
				SwordControlGroundController.LogReturn("OpenByGameplay", "GameplayOwner", 0);
				return;
			}
			if (SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.Temporary)
			{
				SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.Gameplay;
				SwordControlGroundController.CloseAfterOpen = false;
				SwordControlGroundController.LogReturn("OpenByGameplay", "TemporaryOwner", 0);
				return;
			}
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.Gameplay;
			SwordControlGroundController.IsOpening = true;
			SwordControlGroundController.CloseAfterOpen = false;
			UiManager instance = UiManager.Instance;
			EUiViewName swordControlGroundView = EUiViewName.SwordControlGroundView;
			object param = null;
			TOpenViewCallBack finishCallback;
			if ((finishCallback = SwordControlGroundController.<>O.<0>__OnOpenViewFinished) == null)
			{
				finishCallback = (SwordControlGroundController.<>O.<0>__OnOpenViewFinished = new TOpenViewCallBack(SwordControlGroundController.OnOpenViewFinished));
			}
			instance.OpenView(swordControlGroundView, param, finishCallback);
		}

		// Token: 0x0604373D RID: 276285 RVA: 0x0107C1F0 File Offset: 0x0107A3F0
		public static void CloseByGameplay()
		{
			if (SwordControlGroundController.Owner != SwordControlGroundController.ESwordControlGroundOwner.Gameplay)
			{
				SwordControlGroundController.LogReturn("CloseByGameplay", "NotGameplayOwner", 0);
				return;
			}
			SwordControlGroundController.RemoveTemporaryTimer();
			if (SwordControlGroundController.IsOpening && SwordControlGroundController.ViewId == null)
			{
				SwordControlGroundController.LogReturn("CloseByGameplay", "OpeningWithoutViewId", 0);
				SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
				SwordControlGroundController.CloseAfterOpen = true;
				return;
			}
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
			SwordControlGroundController.CloseCurrentView();
		}

		// Token: 0x0604373E RID: 276286 RVA: 0x0107C258 File Offset: 0x0107A458
		private static void OnOpenViewFinished(bool success, int viewId)
		{
			SwordControlGroundController.IsOpening = false;
			if (!success)
			{
				SwordControlGroundController.LogReturn("OnOpenViewFinished", "OpenFailed", viewId);
				SwordControlGroundController.ResetState();
				return;
			}
			SwordControlGroundController.ViewId = new int?(viewId);
			SwordControlGroundController.AddCloseEventListener();
			SwordControlGroundController.SetInputRestricted(true);
			if (SwordControlGroundController.CloseAfterOpen || SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.None)
			{
				SwordControlGroundController.LogReturn("OnOpenViewFinished", "CloseAfterOpen", viewId);
				SwordControlGroundController.CloseAfterOpen = false;
				SwordControlGroundController.CloseCurrentView();
				return;
			}
			if (SwordControlGroundController.Owner == SwordControlGroundController.ESwordControlGroundOwner.Temporary)
			{
				SwordControlGroundController.StartTemporaryTimer(SwordControlGroundController.PendingTemporaryDuration);
			}
		}

		// Token: 0x0604373F RID: 276287 RVA: 0x0107C2D8 File Offset: 0x0107A4D8
		private static void StartTemporaryTimer(float duration)
		{
			SwordControlGroundController.RemoveTemporaryTimer();
			SwordControlGroundController.TemporaryTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				SwordControlGroundController.OnTemporaryTimerFinished();
			}, duration, null, "SwordControlGroundController.OpenTemporary", true, 1f);
		}

		// Token: 0x06043740 RID: 276288 RVA: 0x0107C325 File Offset: 0x0107A525
		private static void OnTemporaryTimerFinished()
		{
			SwordControlGroundController.TemporaryTimer = null;
			if (SwordControlGroundController.Owner != SwordControlGroundController.ESwordControlGroundOwner.Temporary)
			{
				SwordControlGroundController.LogReturn("OnTemporaryTimerFinished", "NotTemporaryOwner", 0);
				return;
			}
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
			SwordControlGroundController.CloseCurrentView();
		}

		// Token: 0x06043741 RID: 276289 RVA: 0x0107C354 File Offset: 0x0107A554
		private static void CloseCurrentView()
		{
			if (SwordControlGroundController.ViewId == null)
			{
				SwordControlGroundController.LogReturn("CloseCurrentView", "ViewIdUndefined", 0);
				SwordControlGroundController.ResetState();
				return;
			}
			int viewId = SwordControlGroundController.ViewId.Value;
			SwordControlGroundController.IsClosing = true;
			UiManager.Instance.CloseViewById(viewId, delegate(bool _)
			{
				int? viewId = SwordControlGroundController.ViewId;
				int viewId2 = viewId;
				if (viewId.GetValueOrDefault() == viewId2 & viewId != null)
				{
					SwordControlGroundController.ResetState();
				}
			});
		}

		// Token: 0x06043742 RID: 276290 RVA: 0x0107C3BB File Offset: 0x0107A5BB
		private static void AddCloseEventListener()
		{
			if (SwordControlGroundController.CloseEventListening)
			{
				return;
			}
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.CloseView;
			Action<EUiViewName, int> handle;
			if ((handle = SwordControlGroundController.<>O.<1>__OnCloseView) == null)
			{
				handle = (SwordControlGroundController.<>O.<1>__OnCloseView = new Action<EUiViewName, int>(SwordControlGroundController.OnCloseView));
			}
			instance.Add<EUiViewName, int>(name, handle);
			SwordControlGroundController.CloseEventListening = true;
		}

		// Token: 0x06043743 RID: 276291 RVA: 0x0107C3F3 File Offset: 0x0107A5F3
		private static void RemoveCloseEventListener()
		{
			if (!SwordControlGroundController.CloseEventListening)
			{
				return;
			}
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.CloseView;
			Action<EUiViewName, int> handle;
			if ((handle = SwordControlGroundController.<>O.<1>__OnCloseView) == null)
			{
				handle = (SwordControlGroundController.<>O.<1>__OnCloseView = new Action<EUiViewName, int>(SwordControlGroundController.OnCloseView));
			}
			instance.Remove<EUiViewName, int>(name, handle);
			SwordControlGroundController.CloseEventListening = false;
		}

		// Token: 0x06043744 RID: 276292 RVA: 0x0107C42C File Offset: 0x0107A62C
		private static void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (!(viewName != EUiViewName.SwordControlGroundView))
			{
				int? viewId2 = SwordControlGroundController.ViewId;
				if (viewId == viewId2.GetValueOrDefault() & viewId2 != null)
				{
					bool pendingGameplayOpenAfterClose = SwordControlGroundController.PendingGameplayOpenAfterClose;
					SwordControlGroundController.ResetState();
					if (pendingGameplayOpenAfterClose)
					{
						SwordControlGroundController.OpenByGameplay();
					}
					return;
				}
			}
		}

		// Token: 0x06043745 RID: 276293 RVA: 0x0107C474 File Offset: 0x0107A674
		private static void ResetState()
		{
			SwordControlGroundController.RemoveTemporaryTimer();
			SwordControlGroundController.RemoveCloseEventListener();
			SwordControlGroundController.Owner = SwordControlGroundController.ESwordControlGroundOwner.None;
			SwordControlGroundController.ViewId = null;
			SwordControlGroundController.IsOpening = false;
			SwordControlGroundController.IsClosing = false;
			SwordControlGroundController.CloseAfterOpen = false;
			SwordControlGroundController.PendingGameplayOpenAfterClose = false;
			SwordControlGroundController.PendingTemporaryDuration = 3000f;
			SwordControlGroundController.SetInputRestricted(false);
		}

		// Token: 0x06043746 RID: 276294 RVA: 0x0107C4C4 File Offset: 0x0107A6C4
		private static void RemoveTemporaryTimer()
		{
			TimerHandle temporaryTimer = SwordControlGroundController.TemporaryTimer;
			if (temporaryTimer != null)
			{
				temporaryTimer.Remove();
			}
			SwordControlGroundController.TemporaryTimer = null;
		}

		// Token: 0x06043747 RID: 276295 RVA: 0x0107C4DD File Offset: 0x0107A6DD
		private static float NormalizeDuration(float duration)
		{
			if (duration <= 0f)
			{
				return 3000f;
			}
			return duration;
		}

		// Token: 0x06043748 RID: 276296 RVA: 0x0107C4EE File Offset: 0x0107A6EE
		private static void SetInputRestricted(bool restricted)
		{
			if (SwordControlGroundController.InputRestricted == restricted)
			{
				return;
			}
			SwordControlGroundController.InputRestricted = restricted;
			OperationRestrictUtils.Instance.SetOperationRestrictByOption(restricted ? SwordControlGroundController.restrictOperationOption : SwordControlGroundController.enableOperationOption);
		}

		// Token: 0x06043749 RID: 276297 RVA: 0x0107C518 File Offset: 0x0107A718
		private unsafe static void LogReturn(string method, string reason, int viewId = 0)
		{
			if (viewId == 0)
			{
				viewId = SwordControlGroundController.ViewId.GetValueOrDefault();
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.HF;
			string message = "[SwordControlGroundController]接口调用提前返回";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("method", method);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("owner", SwordControlGroundController.GetOwnerName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("viewId", viewId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isOpening", SwordControlGroundController.IsOpening);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("isClosing", SwordControlGroundController.IsClosing);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("closeAfterOpen", SwordControlGroundController.CloseAfterOpen);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("pendingGameplayOpenAfterClose", SwordControlGroundController.PendingGameplayOpenAfterClose);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
		}

		// Token: 0x0604374A RID: 276298 RVA: 0x0107C644 File Offset: 0x0107A844
		private static string GetOwnerName()
		{
			SwordControlGroundController.ESwordControlGroundOwner owner = SwordControlGroundController.Owner;
			if (owner == SwordControlGroundController.ESwordControlGroundOwner.Temporary)
			{
				return "Temporary";
			}
			if (owner != SwordControlGroundController.ESwordControlGroundOwner.Gameplay)
			{
				return "None";
			}
			return "Gameplay";
		}

		// Token: 0x04023332 RID: 144178
		private const float DEFAULT_TEMPORARY_DURATION = 3000f;

		// Token: 0x04023333 RID: 144179
		[StaticVariableRuleIgnore]
		private static readonly IDisableModulePlayerOperation restrictOperationOption = new IDisableModulePlayerOperation
		{
			Type = EPlayerOperationType.DisableModule,
			SkillOption = new IDisableSectionalSkillOperation
			{
				Type = ESkillOperationType.DisableSection,
				DisplayMode = new EDisplayModeInSkillOp?(EDisplayModeInSkillOp.Disable),
				DisableSkillWheel = new bool?(true),
				DisableBattleSkill = new IDisableBattleSkillOptions
				{
					IsDisablePhantomSkill = new bool?(true),
					IsDisableCharacterSectionalSkill = new IDisableCharacterSectionalSkillOption
					{
						DisableJump = new bool?(true),
						DisableShowClimb = new bool?(true),
						DisableDodge = new bool?(true),
						DisableSkill1 = new bool?(true),
						DisableUltimateSkill = new bool?(true),
						DisableExploreInput = new bool?(true),
						DisableSwitchRole1 = new bool?(true),
						DisableSwitchRole2 = new bool?(true),
						DisableSwitchRole3 = new bool?(true),
						DisableLock = new bool?(true),
						DisableAim = new bool?(true)
					}
				},
				DisableSwitchRole = new bool?(true)
			}
		};

		// Token: 0x04023334 RID: 144180
		[StaticVariableRuleIgnore]
		private static readonly IEnableAllPlayerOperation enableOperationOption = new IEnableAllPlayerOperation
		{
			Type = EPlayerOperationType.EnableAll
		};

		// Token: 0x04023335 RID: 144181
		private static SwordControlGroundController.ESwordControlGroundOwner Owner;

		// Token: 0x04023336 RID: 144182
		private static int? ViewId;

		// Token: 0x04023337 RID: 144183
		[Nullable(2)]
		private static TimerHandle TemporaryTimer;

		// Token: 0x04023338 RID: 144184
		private static bool IsOpening;

		// Token: 0x04023339 RID: 144185
		private static bool IsClosing;

		// Token: 0x0402333A RID: 144186
		private static bool InputRestricted;

		// Token: 0x0402333B RID: 144187
		private static bool CloseAfterOpen;

		// Token: 0x0402333C RID: 144188
		private static bool PendingGameplayOpenAfterClose;

		// Token: 0x0402333D RID: 144189
		private static float PendingTemporaryDuration;

		// Token: 0x0402333E RID: 144190
		private static bool CloseEventListening;

		// Token: 0x0200CB51 RID: 52049
		[NullableContext(0)]
		private enum ESwordControlGroundOwner
		{
			// Token: 0x0403D650 RID: 251472
			None,
			// Token: 0x0403D651 RID: 251473
			Temporary,
			// Token: 0x0403D652 RID: 251474
			Gameplay
		}

		// Token: 0x0200CB52 RID: 52050
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403D653 RID: 251475
			[Nullable(0)]
			public static TOpenViewCallBack <0>__OnOpenViewFinished;

			// Token: 0x0403D654 RID: 251476
			[Nullable(0)]
			public static Action<EUiViewName, int> <1>__OnCloseView;
		}
	}
}
