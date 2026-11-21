using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.SwordControl
{
	// Token: 0x02005B48 RID: 23368
	[NullableContext(1)]
	[Nullable(0)]
	public class SwordControlGroundController : IStaticVariableResetter
	{
		// Token: 0x06039781 RID: 235393 RVA: 0x01020548 File Offset: 0x0101E748
		static SwordControlGroundController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SwordControlGroundController.CreateStaticDefaultValue), new Action(SwordControlGroundController.ResetStaticDefaultValue));
		}

		// Token: 0x06039782 RID: 235394 RVA: 0x01020670 File Offset: 0x0101E870
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

		// Token: 0x06039783 RID: 235395 RVA: 0x010206C4 File Offset: 0x0101E8C4
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

		// Token: 0x06039784 RID: 235396 RVA: 0x01020718 File Offset: 0x0101E918
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

		// Token: 0x06039785 RID: 235397 RVA: 0x010207F8 File Offset: 0x0101E9F8
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

		// Token: 0x06039786 RID: 235398 RVA: 0x010208C8 File Offset: 0x0101EAC8
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

		// Token: 0x06039787 RID: 235399 RVA: 0x01020930 File Offset: 0x0101EB30
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

		// Token: 0x06039788 RID: 235400 RVA: 0x010209B0 File Offset: 0x0101EBB0
		private static void StartTemporaryTimer(float duration)
		{
			SwordControlGroundController.RemoveTemporaryTimer();
			SwordControlGroundController.TemporaryTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				SwordControlGroundController.OnTemporaryTimerFinished();
			}, duration, null, "SwordControlGroundController.OpenTemporary", true, 1f);
		}

		// Token: 0x06039789 RID: 235401 RVA: 0x010209FD File Offset: 0x0101EBFD
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

		// Token: 0x0603978A RID: 235402 RVA: 0x01020A2C File Offset: 0x0101EC2C
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

		// Token: 0x0603978B RID: 235403 RVA: 0x01020A93 File Offset: 0x0101EC93
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

		// Token: 0x0603978C RID: 235404 RVA: 0x01020ACB File Offset: 0x0101ECCB
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

		// Token: 0x0603978D RID: 235405 RVA: 0x01020B04 File Offset: 0x0101ED04
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

		// Token: 0x0603978E RID: 235406 RVA: 0x01020B4C File Offset: 0x0101ED4C
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

		// Token: 0x0603978F RID: 235407 RVA: 0x01020B9C File Offset: 0x0101ED9C
		private static void RemoveTemporaryTimer()
		{
			TimerHandle temporaryTimer = SwordControlGroundController.TemporaryTimer;
			if (temporaryTimer != null)
			{
				temporaryTimer.Remove();
			}
			SwordControlGroundController.TemporaryTimer = null;
		}

		// Token: 0x06039790 RID: 235408 RVA: 0x01020BB5 File Offset: 0x0101EDB5
		private static float NormalizeDuration(float duration)
		{
			if (duration <= 0f)
			{
				return 3000f;
			}
			return duration;
		}

		// Token: 0x06039791 RID: 235409 RVA: 0x01020BC6 File Offset: 0x0101EDC6
		private static void SetInputRestricted(bool restricted)
		{
			if (SwordControlGroundController.InputRestricted == restricted)
			{
				return;
			}
			SwordControlGroundController.InputRestricted = restricted;
			OperationRestrictUtils.Instance.SetOperationRestrictByOption(restricted ? SwordControlGroundController.restrictOperationOption : SwordControlGroundController.enableOperationOption);
		}

		// Token: 0x06039792 RID: 235410 RVA: 0x01020BF0 File Offset: 0x0101EDF0
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

		// Token: 0x06039793 RID: 235411 RVA: 0x01020D1C File Offset: 0x0101EF1C
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

		// Token: 0x0401E524 RID: 124196
		private const float DEFAULT_TEMPORARY_DURATION = 3000f;

		// Token: 0x0401E525 RID: 124197
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

		// Token: 0x0401E526 RID: 124198
		[StaticVariableRuleIgnore]
		private static readonly IEnableAllPlayerOperation enableOperationOption = new IEnableAllPlayerOperation
		{
			Type = EPlayerOperationType.EnableAll
		};

		// Token: 0x0401E527 RID: 124199
		private static SwordControlGroundController.ESwordControlGroundOwner Owner;

		// Token: 0x0401E528 RID: 124200
		private static int? ViewId;

		// Token: 0x0401E529 RID: 124201
		[Nullable(2)]
		private static TimerHandle TemporaryTimer;

		// Token: 0x0401E52A RID: 124202
		private static bool IsOpening;

		// Token: 0x0401E52B RID: 124203
		private static bool IsClosing;

		// Token: 0x0401E52C RID: 124204
		private static bool InputRestricted;

		// Token: 0x0401E52D RID: 124205
		private static bool CloseAfterOpen;

		// Token: 0x0401E52E RID: 124206
		private static bool PendingGameplayOpenAfterClose;

		// Token: 0x0401E52F RID: 124207
		private static float PendingTemporaryDuration;

		// Token: 0x0401E530 RID: 124208
		private static bool CloseEventListening;

		// Token: 0x0200B730 RID: 46896
		[NullableContext(0)]
		private enum ESwordControlGroundOwner
		{
			// Token: 0x04038A32 RID: 231986
			None,
			// Token: 0x04038A33 RID: 231987
			Temporary,
			// Token: 0x04038A34 RID: 231988
			Gameplay
		}

		// Token: 0x0200B731 RID: 46897
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038A35 RID: 231989
			[Nullable(0)]
			public static TOpenViewCallBack <0>__OnOpenViewFinished;

			// Token: 0x04038A36 RID: 231990
			[Nullable(0)]
			public static Action<EUiViewName, int> <1>__OnCloseView;
		}
	}
}
