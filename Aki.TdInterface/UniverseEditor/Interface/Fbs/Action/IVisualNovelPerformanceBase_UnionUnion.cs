using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D98 RID: 32152
	public class IVisualNovelPerformanceBase_UnionUnion
	{
		// Token: 0x1700F088 RID: 61576
		// (get) Token: 0x0603A0A8 RID: 237736 RVA: 0x007D2F78 File Offset: 0x007D1178
		// (set) Token: 0x0603A0A9 RID: 237737 RVA: 0x007D2F80 File Offset: 0x007D1180
		public IVisualNovelPerformanceBase_Union Type { get; set; }

		// Token: 0x1700F089 RID: 61577
		// (get) Token: 0x0603A0AA RID: 237738 RVA: 0x007D2F89 File Offset: 0x007D1189
		// (set) Token: 0x0603A0AB RID: 237739 RVA: 0x007D2F91 File Offset: 0x007D1191
		public object Value { get; set; }

		// Token: 0x0603A0AC RID: 237740 RVA: 0x007D2F9A File Offset: 0x007D119A
		public IVisualNovelPerformanceBase_UnionUnion()
		{
			this.Type = IVisualNovelPerformanceBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603A0AD RID: 237741 RVA: 0x007D2FB0 File Offset: 0x007D11B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A0AE RID: 237742 RVA: 0x007D2FC2 File Offset: 0x007D11C2
		public IVisualNovelPerformanceBaseT AsIVisualNovelPerformanceBase()
		{
			return this.As<IVisualNovelPerformanceBaseT>();
		}

		// Token: 0x0603A0AF RID: 237743 RVA: 0x007D2FCA File Offset: 0x007D11CA
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceBase(IVisualNovelPerformanceBaseT _ivisualnovelperformancebase)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBase,
				Value = _ivisualnovelperformancebase
			};
		}

		// Token: 0x0603A0B0 RID: 237744 RVA: 0x007D2FDF File Offset: 0x007D11DF
		public IVisualNovelPerformanceEnterT AsIVisualNovelPerformanceEnter()
		{
			return this.As<IVisualNovelPerformanceEnterT>();
		}

		// Token: 0x0603A0B1 RID: 237745 RVA: 0x007D2FE7 File Offset: 0x007D11E7
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceEnter(IVisualNovelPerformanceEnterT _ivisualnovelperformanceenter)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnter,
				Value = _ivisualnovelperformanceenter
			};
		}

		// Token: 0x0603A0B2 RID: 237746 RVA: 0x007D2FFC File Offset: 0x007D11FC
		public IVisualNovelPerformanceExitT AsIVisualNovelPerformanceExit()
		{
			return this.As<IVisualNovelPerformanceExitT>();
		}

		// Token: 0x0603A0B3 RID: 237747 RVA: 0x007D3004 File Offset: 0x007D1204
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceExit(IVisualNovelPerformanceExitT _ivisualnovelperformanceexit)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceExit,
				Value = _ivisualnovelperformanceexit
			};
		}

		// Token: 0x0603A0B4 RID: 237748 RVA: 0x007D3019 File Offset: 0x007D1219
		public IVisualNovelPerformanceMoveT AsIVisualNovelPerformanceMove()
		{
			return this.As<IVisualNovelPerformanceMoveT>();
		}

		// Token: 0x0603A0B5 RID: 237749 RVA: 0x007D3021 File Offset: 0x007D1221
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceMove(IVisualNovelPerformanceMoveT _ivisualnovelperformancemove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceMove,
				Value = _ivisualnovelperformancemove
			};
		}

		// Token: 0x0603A0B6 RID: 237750 RVA: 0x007D3036 File Offset: 0x007D1236
		public IVisualNovelPerformanceModifyRoleT AsIVisualNovelPerformanceModifyRole()
		{
			return this.As<IVisualNovelPerformanceModifyRoleT>();
		}

		// Token: 0x0603A0B7 RID: 237751 RVA: 0x007D303E File Offset: 0x007D123E
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceModifyRole(IVisualNovelPerformanceModifyRoleT _ivisualnovelperformancemodifyrole)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceModifyRole,
				Value = _ivisualnovelperformancemodifyrole
			};
		}

		// Token: 0x0603A0B8 RID: 237752 RVA: 0x007D3053 File Offset: 0x007D1253
		public IVisualNovelPerformancePortraitEffectT AsIVisualNovelPerformancePortraitEffect()
		{
			return this.As<IVisualNovelPerformancePortraitEffectT>();
		}

		// Token: 0x0603A0B9 RID: 237753 RVA: 0x007D305B File Offset: 0x007D125B
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformancePortraitEffect(IVisualNovelPerformancePortraitEffectT _ivisualnovelperformanceportraiteffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePortraitEffect,
				Value = _ivisualnovelperformanceportraiteffect
			};
		}

		// Token: 0x0603A0BA RID: 237754 RVA: 0x007D3070 File Offset: 0x007D1270
		public IVisualNovelPerformanceBackgroundMoveT AsIVisualNovelPerformanceBackgroundMove()
		{
			return this.As<IVisualNovelPerformanceBackgroundMoveT>();
		}

		// Token: 0x0603A0BB RID: 237755 RVA: 0x007D3078 File Offset: 0x007D1278
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceBackgroundMove(IVisualNovelPerformanceBackgroundMoveT _ivisualnovelperformancebackgroundmove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceBackgroundMove,
				Value = _ivisualnovelperformancebackgroundmove
			};
		}

		// Token: 0x0603A0BC RID: 237756 RVA: 0x007D308D File Offset: 0x007D128D
		public IVisualNovelPerformanceCgMoveT AsIVisualNovelPerformanceCgMove()
		{
			return this.As<IVisualNovelPerformanceCgMoveT>();
		}

		// Token: 0x0603A0BD RID: 237757 RVA: 0x007D3095 File Offset: 0x007D1295
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceCgMove(IVisualNovelPerformanceCgMoveT _ivisualnovelperformancecgmove)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceCgMove,
				Value = _ivisualnovelperformancecgmove
			};
		}

		// Token: 0x0603A0BE RID: 237758 RVA: 0x007D30AA File Offset: 0x007D12AA
		public IVisualNovelPerformanceEnterBlackScreenT AsIVisualNovelPerformanceEnterBlackScreen()
		{
			return this.As<IVisualNovelPerformanceEnterBlackScreenT>();
		}

		// Token: 0x0603A0BF RID: 237759 RVA: 0x007D30B2 File Offset: 0x007D12B2
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceEnterBlackScreen(IVisualNovelPerformanceEnterBlackScreenT _ivisualnovelperformanceenterblackscreen)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceEnterBlackScreen,
				Value = _ivisualnovelperformanceenterblackscreen
			};
		}

		// Token: 0x0603A0C0 RID: 237760 RVA: 0x007D30C8 File Offset: 0x007D12C8
		public IVisualNovelPerformanceLeaveBlackScreenT AsIVisualNovelPerformanceLeaveBlackScreen()
		{
			return this.As<IVisualNovelPerformanceLeaveBlackScreenT>();
		}

		// Token: 0x0603A0C1 RID: 237761 RVA: 0x007D30D0 File Offset: 0x007D12D0
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceLeaveBlackScreen(IVisualNovelPerformanceLeaveBlackScreenT _ivisualnovelperformanceleaveblackscreen)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceLeaveBlackScreen,
				Value = _ivisualnovelperformanceleaveblackscreen
			};
		}

		// Token: 0x0603A0C2 RID: 237762 RVA: 0x007D30E6 File Offset: 0x007D12E6
		public IVisualNovelPerformancePlayScreenEffectT AsIVisualNovelPerformancePlayScreenEffect()
		{
			return this.As<IVisualNovelPerformancePlayScreenEffectT>();
		}

		// Token: 0x0603A0C3 RID: 237763 RVA: 0x007D30EE File Offset: 0x007D12EE
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformancePlayScreenEffect(IVisualNovelPerformancePlayScreenEffectT _ivisualnovelperformanceplayscreeneffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformancePlayScreenEffect,
				Value = _ivisualnovelperformanceplayscreeneffect
			};
		}

		// Token: 0x0603A0C4 RID: 237764 RVA: 0x007D3104 File Offset: 0x007D1304
		public IVisualNovelPerformanceStopScreenEffectT AsIVisualNovelPerformanceStopScreenEffect()
		{
			return this.As<IVisualNovelPerformanceStopScreenEffectT>();
		}

		// Token: 0x0603A0C5 RID: 237765 RVA: 0x007D310C File Offset: 0x007D130C
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceStopScreenEffect(IVisualNovelPerformanceStopScreenEffectT _ivisualnovelperformancestopscreeneffect)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceStopScreenEffect,
				Value = _ivisualnovelperformancestopscreeneffect
			};
		}

		// Token: 0x0603A0C6 RID: 237766 RVA: 0x007D3122 File Offset: 0x007D1322
		public IVisualNovelPerformanceSendAudioEventT AsIVisualNovelPerformanceSendAudioEvent()
		{
			return this.As<IVisualNovelPerformanceSendAudioEventT>();
		}

		// Token: 0x0603A0C7 RID: 237767 RVA: 0x007D312A File Offset: 0x007D132A
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceSendAudioEvent(IVisualNovelPerformanceSendAudioEventT _ivisualnovelperformancesendaudioevent)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSendAudioEvent,
				Value = _ivisualnovelperformancesendaudioevent
			};
		}

		// Token: 0x0603A0C8 RID: 237768 RVA: 0x007D3140 File Offset: 0x007D1340
		public IVisualNovelPerformanceSwitchAudioStateT AsIVisualNovelPerformanceSwitchAudioState()
		{
			return this.As<IVisualNovelPerformanceSwitchAudioStateT>();
		}

		// Token: 0x0603A0C9 RID: 237769 RVA: 0x007D3148 File Offset: 0x007D1348
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceSwitchAudioState(IVisualNovelPerformanceSwitchAudioStateT _ivisualnovelperformanceswitchaudiostate)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceSwitchAudioState,
				Value = _ivisualnovelperformanceswitchaudiostate
			};
		}

		// Token: 0x0603A0CA RID: 237770 RVA: 0x007D315E File Offset: 0x007D135E
		public IVisualNovelPerformanceTransitionT AsIVisualNovelPerformanceTransition()
		{
			return this.As<IVisualNovelPerformanceTransitionT>();
		}

		// Token: 0x0603A0CB RID: 237771 RVA: 0x007D3166 File Offset: 0x007D1366
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceTransition(IVisualNovelPerformanceTransitionT _ivisualnovelperformancetransition)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceTransition,
				Value = _ivisualnovelperformancetransition
			};
		}

		// Token: 0x0603A0CC RID: 237772 RVA: 0x007D317C File Offset: 0x007D137C
		public IVisualNovelPerformanceRoleIntroductionT AsIVisualNovelPerformanceRoleIntroduction()
		{
			return this.As<IVisualNovelPerformanceRoleIntroductionT>();
		}

		// Token: 0x0603A0CD RID: 237773 RVA: 0x007D3184 File Offset: 0x007D1384
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceRoleIntroduction(IVisualNovelPerformanceRoleIntroductionT _ivisualnovelperformanceroleintroduction)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceRoleIntroduction,
				Value = _ivisualnovelperformanceroleintroduction
			};
		}

		// Token: 0x0603A0CE RID: 237774 RVA: 0x007D319A File Offset: 0x007D139A
		public IVisualNovelPerformanceActivityActionT AsIVisualNovelPerformanceActivityAction()
		{
			return this.As<IVisualNovelPerformanceActivityActionT>();
		}

		// Token: 0x0603A0CF RID: 237775 RVA: 0x007D31A2 File Offset: 0x007D13A2
		public static IVisualNovelPerformanceBase_UnionUnion FromIVisualNovelPerformanceActivityAction(IVisualNovelPerformanceActivityActionT _ivisualnovelperformanceactivityaction)
		{
			return new IVisualNovelPerformanceBase_UnionUnion
			{
				Type = IVisualNovelPerformanceBase_Union.IVisualNovelPerformanceActivityAction,
				Value = _ivisualnovelperformanceactivityaction
			};
		}

		// Token: 0x0603A0D0 RID: 237776 RVA: 0x007D31B8 File Offset: 0x007D13B8
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
