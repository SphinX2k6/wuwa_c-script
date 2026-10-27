using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759F RID: 30111
	public class IVisualNovelPerformanceBase_UnionUnion
	{
		// Token: 0x1700E45B RID: 58459
		// (get) Token: 0x06036C78 RID: 224376 RVA: 0x0076F9B0 File Offset: 0x0076DBB0
		// (set) Token: 0x06036C79 RID: 224377 RVA: 0x0076F9B8 File Offset: 0x0076DBB8
		public IVisualNovelPerformanceBase_Union Type { get; set; }

		// Token: 0x1700E45C RID: 58460
		// (get) Token: 0x06036C7A RID: 224378 RVA: 0x0076F9C1 File Offset: 0x0076DBC1
		// (set) Token: 0x06036C7B RID: 224379 RVA: 0x0076F9C9 File Offset: 0x0076DBC9
		public object Value { get; set; }

		// Token: 0x06036C7C RID: 224380 RVA: 0x0076F9D2 File Offset: 0x0076DBD2
		public IVisualNovelPerformanceBase_UnionUnion()
		{
			this.Type = IVisualNovelPerformanceBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036C7D RID: 224381 RVA: 0x0076F9E8 File Offset: 0x0076DBE8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036C7E RID: 224382 RVA: 0x0076F9FA File Offset: 0x0076DBFA
		public IVisualNovelPerformanceBaseT AsIVisualNovelPerformanceBase()
		{
			return this.As<IVisualNovelPerformanceBaseT>();
		}

		// Token: 0x06036C7F RID: 224383 RVA: 0x0076FA02 File Offset: 0x0076DC02
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceBase(IVisualNovelPerformanceBaseT _ivisualnovelperformancebase)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBase,
				Value = _ivisualnovelperformancebase
			};
		}

		// Token: 0x06036C80 RID: 224384 RVA: 0x0076FA17 File Offset: 0x0076DC17
		public IVisualNovelPerformanceEnterT AsIVisualNovelPerformanceEnter()
		{
			return this.As<IVisualNovelPerformanceEnterT>();
		}

		// Token: 0x06036C81 RID: 224385 RVA: 0x0076FA1F File Offset: 0x0076DC1F
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceEnter(IVisualNovelPerformanceEnterT _ivisualnovelperformanceenter)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnter,
				Value = _ivisualnovelperformanceenter
			};
		}

		// Token: 0x06036C82 RID: 224386 RVA: 0x0076FA34 File Offset: 0x0076DC34
		public IVisualNovelPerformanceExitT AsIVisualNovelPerformanceExit()
		{
			return this.As<IVisualNovelPerformanceExitT>();
		}

		// Token: 0x06036C83 RID: 224387 RVA: 0x0076FA3C File Offset: 0x0076DC3C
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceExit(IVisualNovelPerformanceExitT _ivisualnovelperformanceexit)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceExit,
				Value = _ivisualnovelperformanceexit
			};
		}

		// Token: 0x06036C84 RID: 224388 RVA: 0x0076FA51 File Offset: 0x0076DC51
		public IVisualNovelPerformanceMoveT AsIVisualNovelPerformanceMove()
		{
			return this.As<IVisualNovelPerformanceMoveT>();
		}

		// Token: 0x06036C85 RID: 224389 RVA: 0x0076FA59 File Offset: 0x0076DC59
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceMove(IVisualNovelPerformanceMoveT _ivisualnovelperformancemove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceMove,
				Value = _ivisualnovelperformancemove
			};
		}

		// Token: 0x06036C86 RID: 224390 RVA: 0x0076FA6E File Offset: 0x0076DC6E
		public IVisualNovelPerformanceModifyRoleT AsIVisualNovelPerformanceModifyRole()
		{
			return this.As<IVisualNovelPerformanceModifyRoleT>();
		}

		// Token: 0x06036C87 RID: 224391 RVA: 0x0076FA76 File Offset: 0x0076DC76
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceModifyRole(IVisualNovelPerformanceModifyRoleT _ivisualnovelperformancemodifyrole)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceModifyRole,
				Value = _ivisualnovelperformancemodifyrole
			};
		}

		// Token: 0x06036C88 RID: 224392 RVA: 0x0076FA8B File Offset: 0x0076DC8B
		public IVisualNovelPerformancePortraitEffectT AsIVisualNovelPerformancePortraitEffect()
		{
			return this.As<IVisualNovelPerformancePortraitEffectT>();
		}

		// Token: 0x06036C89 RID: 224393 RVA: 0x0076FA93 File Offset: 0x0076DC93
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformancePortraitEffect(IVisualNovelPerformancePortraitEffectT _ivisualnovelperformanceportraiteffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePortraitEffect,
				Value = _ivisualnovelperformanceportraiteffect
			};
		}

		// Token: 0x06036C8A RID: 224394 RVA: 0x0076FAA8 File Offset: 0x0076DCA8
		public IVisualNovelPerformanceUiShakeT AsIVisualNovelPerformanceUiShake()
		{
			return this.As<IVisualNovelPerformanceUiShakeT>();
		}

		// Token: 0x06036C8B RID: 224395 RVA: 0x0076FAB0 File Offset: 0x0076DCB0
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceUiShake(IVisualNovelPerformanceUiShakeT _ivisualnovelperformanceuishake)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceUiShake,
				Value = _ivisualnovelperformanceuishake
			};
		}

		// Token: 0x06036C8C RID: 224396 RVA: 0x0076FAC5 File Offset: 0x0076DCC5
		public IVisualNovelPerformanceBackgroundMoveT AsIVisualNovelPerformanceBackgroundMove()
		{
			return this.As<IVisualNovelPerformanceBackgroundMoveT>();
		}

		// Token: 0x06036C8D RID: 224397 RVA: 0x0076FACD File Offset: 0x0076DCCD
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceBackgroundMove(IVisualNovelPerformanceBackgroundMoveT _ivisualnovelperformancebackgroundmove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBackgroundMove,
				Value = _ivisualnovelperformancebackgroundmove
			};
		}

		// Token: 0x06036C8E RID: 224398 RVA: 0x0076FAE2 File Offset: 0x0076DCE2
		public IVisualNovelPerformanceCgMoveT AsIVisualNovelPerformanceCgMove()
		{
			return this.As<IVisualNovelPerformanceCgMoveT>();
		}

		// Token: 0x06036C8F RID: 224399 RVA: 0x0076FAEA File Offset: 0x0076DCEA
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceCgMove(IVisualNovelPerformanceCgMoveT _ivisualnovelperformancecgmove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceCgMove,
				Value = _ivisualnovelperformancecgmove
			};
		}

		// Token: 0x06036C90 RID: 224400 RVA: 0x0076FB00 File Offset: 0x0076DD00
		public IVisualNovelPerformanceEnterBlackScreenT AsIVisualNovelPerformanceEnterBlackScreen()
		{
			return this.As<IVisualNovelPerformanceEnterBlackScreenT>();
		}

		// Token: 0x06036C91 RID: 224401 RVA: 0x0076FB08 File Offset: 0x0076DD08
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceEnterBlackScreen(IVisualNovelPerformanceEnterBlackScreenT _ivisualnovelperformanceenterblackscreen)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnterBlackScreen,
				Value = _ivisualnovelperformanceenterblackscreen
			};
		}

		// Token: 0x06036C92 RID: 224402 RVA: 0x0076FB1E File Offset: 0x0076DD1E
		public IVisualNovelPerformanceLeaveBlackScreenT AsIVisualNovelPerformanceLeaveBlackScreen()
		{
			return this.As<IVisualNovelPerformanceLeaveBlackScreenT>();
		}

		// Token: 0x06036C93 RID: 224403 RVA: 0x0076FB26 File Offset: 0x0076DD26
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceLeaveBlackScreen(IVisualNovelPerformanceLeaveBlackScreenT _ivisualnovelperformanceleaveblackscreen)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceLeaveBlackScreen,
				Value = _ivisualnovelperformanceleaveblackscreen
			};
		}

		// Token: 0x06036C94 RID: 224404 RVA: 0x0076FB3C File Offset: 0x0076DD3C
		public IVisualNovelPerformancePlayScreenEffectT AsIVisualNovelPerformancePlayScreenEffect()
		{
			return this.As<IVisualNovelPerformancePlayScreenEffectT>();
		}

		// Token: 0x06036C95 RID: 224405 RVA: 0x0076FB44 File Offset: 0x0076DD44
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformancePlayScreenEffect(IVisualNovelPerformancePlayScreenEffectT _ivisualnovelperformanceplayscreeneffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePlayScreenEffect,
				Value = _ivisualnovelperformanceplayscreeneffect
			};
		}

		// Token: 0x06036C96 RID: 224406 RVA: 0x0076FB5A File Offset: 0x0076DD5A
		public IVisualNovelPerformanceStopScreenEffectT AsIVisualNovelPerformanceStopScreenEffect()
		{
			return this.As<IVisualNovelPerformanceStopScreenEffectT>();
		}

		// Token: 0x06036C97 RID: 224407 RVA: 0x0076FB62 File Offset: 0x0076DD62
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceStopScreenEffect(IVisualNovelPerformanceStopScreenEffectT _ivisualnovelperformancestopscreeneffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceStopScreenEffect,
				Value = _ivisualnovelperformancestopscreeneffect
			};
		}

		// Token: 0x06036C98 RID: 224408 RVA: 0x0076FB78 File Offset: 0x0076DD78
		public IVisualNovelPerformanceSendAudioEventT AsIVisualNovelPerformanceSendAudioEvent()
		{
			return this.As<IVisualNovelPerformanceSendAudioEventT>();
		}

		// Token: 0x06036C99 RID: 224409 RVA: 0x0076FB80 File Offset: 0x0076DD80
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceSendAudioEvent(IVisualNovelPerformanceSendAudioEventT _ivisualnovelperformancesendaudioevent)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSendAudioEvent,
				Value = _ivisualnovelperformancesendaudioevent
			};
		}

		// Token: 0x06036C9A RID: 224410 RVA: 0x0076FB96 File Offset: 0x0076DD96
		public IVisualNovelPerformanceSwitchAudioStateT AsIVisualNovelPerformanceSwitchAudioState()
		{
			return this.As<IVisualNovelPerformanceSwitchAudioStateT>();
		}

		// Token: 0x06036C9B RID: 224411 RVA: 0x0076FB9E File Offset: 0x0076DD9E
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceSwitchAudioState(IVisualNovelPerformanceSwitchAudioStateT _ivisualnovelperformanceswitchaudiostate)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSwitchAudioState,
				Value = _ivisualnovelperformanceswitchaudiostate
			};
		}

		// Token: 0x06036C9C RID: 224412 RVA: 0x0076FBB4 File Offset: 0x0076DDB4
		public IVisualNovelPerformanceTransitionT AsIVisualNovelPerformanceTransition()
		{
			return this.As<IVisualNovelPerformanceTransitionT>();
		}

		// Token: 0x06036C9D RID: 224413 RVA: 0x0076FBBC File Offset: 0x0076DDBC
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceTransition(IVisualNovelPerformanceTransitionT _ivisualnovelperformancetransition)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceTransition,
				Value = _ivisualnovelperformancetransition
			};
		}

		// Token: 0x06036C9E RID: 224414 RVA: 0x0076FBD2 File Offset: 0x0076DDD2
		public IVisualNovelPerformanceRoleIntroductionT AsIVisualNovelPerformanceRoleIntroduction()
		{
			return this.As<IVisualNovelPerformanceRoleIntroductionT>();
		}

		// Token: 0x06036C9F RID: 224415 RVA: 0x0076FBDA File Offset: 0x0076DDDA
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceRoleIntroduction(IVisualNovelPerformanceRoleIntroductionT _ivisualnovelperformanceroleintroduction)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceRoleIntroduction,
				Value = _ivisualnovelperformanceroleintroduction
			};
		}

		// Token: 0x06036CA0 RID: 224416 RVA: 0x0076FBF0 File Offset: 0x0076DDF0
		public IVisualNovelPerformanceActivityActionT AsIVisualNovelPerformanceActivityAction()
		{
			return this.As<IVisualNovelPerformanceActivityActionT>();
		}

		// Token: 0x06036CA1 RID: 224417 RVA: 0x0076FBF8 File Offset: 0x0076DDF8
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceActivityAction(IVisualNovelPerformanceActivityActionT _ivisualnovelperformanceactivityaction)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceActivityAction,
				Value = _ivisualnovelperformanceactivityaction
			};
		}

		// Token: 0x06036CA2 RID: 224418 RVA: 0x0076FC10 File Offset: 0x0076DE10
		public static int Pack(FlatBufferBuilder builder, IVisualNovelPerformanceBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBase:
				return IVisualNovelPerformanceBase.Pack(builder, _o.AsIVisualNovelPerformanceBase()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnter:
				return IVisualNovelPerformanceEnter.Pack(builder, _o.AsIVisualNovelPerformanceEnter()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceExit:
				return IVisualNovelPerformanceExit.Pack(builder, _o.AsIVisualNovelPerformanceExit()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceMove:
				return IVisualNovelPerformanceMove.Pack(builder, _o.AsIVisualNovelPerformanceMove()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceModifyRole:
				return IVisualNovelPerformanceModifyRole.Pack(builder, _o.AsIVisualNovelPerformanceModifyRole()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePortraitEffect:
				return IVisualNovelPerformancePortraitEffect.Pack(builder, _o.AsIVisualNovelPerformancePortraitEffect()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceUiShake:
				return IVisualNovelPerformanceUiShake.Pack(builder, _o.AsIVisualNovelPerformanceUiShake()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBackgroundMove:
				return IVisualNovelPerformanceBackgroundMove.Pack(builder, _o.AsIVisualNovelPerformanceBackgroundMove()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceCgMove:
				return IVisualNovelPerformanceCgMove.Pack(builder, _o.AsIVisualNovelPerformanceCgMove()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnterBlackScreen:
				return IVisualNovelPerformanceEnterBlackScreen.Pack(builder, _o.AsIVisualNovelPerformanceEnterBlackScreen()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceLeaveBlackScreen:
				return IVisualNovelPerformanceLeaveBlackScreen.Pack(builder, _o.AsIVisualNovelPerformanceLeaveBlackScreen()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePlayScreenEffect:
				return IVisualNovelPerformancePlayScreenEffect.Pack(builder, _o.AsIVisualNovelPerformancePlayScreenEffect()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceStopScreenEffect:
				return IVisualNovelPerformanceStopScreenEffect.Pack(builder, _o.AsIVisualNovelPerformanceStopScreenEffect()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSendAudioEvent:
				return IVisualNovelPerformanceSendAudioEvent.Pack(builder, _o.AsIVisualNovelPerformanceSendAudioEvent()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSwitchAudioState:
				return IVisualNovelPerformanceSwitchAudioState.Pack(builder, _o.AsIVisualNovelPerformanceSwitchAudioState()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceTransition:
				return IVisualNovelPerformanceTransition.Pack(builder, _o.AsIVisualNovelPerformanceTransition()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceRoleIntroduction:
				return IVisualNovelPerformanceRoleIntroduction.Pack(builder, _o.AsIVisualNovelPerformanceRoleIntroduction()).Value;
			case IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceActivityAction:
				return IVisualNovelPerformanceActivityAction.Pack(builder, _o.AsIVisualNovelPerformanceActivityAction()).Value;
			default:
				return 0;
			}
		}
	}
}
