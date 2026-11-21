using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008055 RID: 32853
	public class TVisualNovelPerformanceUnion
	{
		// Token: 0x1700F35B RID: 62299
		// (get) Token: 0x0603B16D RID: 242029 RVA: 0x007EE5DA File Offset: 0x007EC7DA
		// (set) Token: 0x0603B16E RID: 242030 RVA: 0x007EE5E2 File Offset: 0x007EC7E2
		public TVisualNovelPerformance Type { get; set; }

		// Token: 0x1700F35C RID: 62300
		// (get) Token: 0x0603B16F RID: 242031 RVA: 0x007EE5EB File Offset: 0x007EC7EB
		// (set) Token: 0x0603B170 RID: 242032 RVA: 0x007EE5F3 File Offset: 0x007EC7F3
		public object Value { get; set; }

		// Token: 0x0603B171 RID: 242033 RVA: 0x007EE5FC File Offset: 0x007EC7FC
		public TVisualNovelPerformanceUnion()
		{
			this.Type = TVisualNovelPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x0603B172 RID: 242034 RVA: 0x007EE612 File Offset: 0x007EC812
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B173 RID: 242035 RVA: 0x007EE624 File Offset: 0x007EC824
		public IVisualNovelPerformanceActivityActionT AsIVisualNovelPerformanceActivityAction()
		{
			return this.As<IVisualNovelPerformanceActivityActionT>();
		}

		// Token: 0x0603B174 RID: 242036 RVA: 0x007EE62C File Offset: 0x007EC82C
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceActivityAction(IVisualNovelPerformanceActivityActionT _ivisualnovelperformanceactivityaction)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceActivityAction,
				Value = _ivisualnovelperformanceactivityaction
			};
		}

		// Token: 0x0603B175 RID: 242037 RVA: 0x007EE641 File Offset: 0x007EC841
		public IVisualNovelPerformanceBackgroundMoveT AsIVisualNovelPerformanceBackgroundMove()
		{
			return this.As<IVisualNovelPerformanceBackgroundMoveT>();
		}

		// Token: 0x0603B176 RID: 242038 RVA: 0x007EE649 File Offset: 0x007EC849
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceBackgroundMove(IVisualNovelPerformanceBackgroundMoveT _ivisualnovelperformancebackgroundmove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove,
				Value = _ivisualnovelperformancebackgroundmove
			};
		}

		// Token: 0x0603B177 RID: 242039 RVA: 0x007EE65E File Offset: 0x007EC85E
		public IVisualNovelPerformanceCgMoveT AsIVisualNovelPerformanceCgMove()
		{
			return this.As<IVisualNovelPerformanceCgMoveT>();
		}

		// Token: 0x0603B178 RID: 242040 RVA: 0x007EE666 File Offset: 0x007EC866
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceCgMove(IVisualNovelPerformanceCgMoveT _ivisualnovelperformancecgmove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceCgMove,
				Value = _ivisualnovelperformancecgmove
			};
		}

		// Token: 0x0603B179 RID: 242041 RVA: 0x007EE67B File Offset: 0x007EC87B
		public IVisualNovelPerformanceEnterT AsIVisualNovelPerformanceEnter()
		{
			return this.As<IVisualNovelPerformanceEnterT>();
		}

		// Token: 0x0603B17A RID: 242042 RVA: 0x007EE683 File Offset: 0x007EC883
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceEnter(IVisualNovelPerformanceEnterT _ivisualnovelperformanceenter)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceEnter,
				Value = _ivisualnovelperformanceenter
			};
		}

		// Token: 0x0603B17B RID: 242043 RVA: 0x007EE698 File Offset: 0x007EC898
		public IVisualNovelPerformanceEnterBlackScreenT AsIVisualNovelPerformanceEnterBlackScreen()
		{
			return this.As<IVisualNovelPerformanceEnterBlackScreenT>();
		}

		// Token: 0x0603B17C RID: 242044 RVA: 0x007EE6A0 File Offset: 0x007EC8A0
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceEnterBlackScreen(IVisualNovelPerformanceEnterBlackScreenT _ivisualnovelperformanceenterblackscreen)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen,
				Value = _ivisualnovelperformanceenterblackscreen
			};
		}

		// Token: 0x0603B17D RID: 242045 RVA: 0x007EE6B5 File Offset: 0x007EC8B5
		public IVisualNovelPerformanceExitT AsIVisualNovelPerformanceExit()
		{
			return this.As<IVisualNovelPerformanceExitT>();
		}

		// Token: 0x0603B17E RID: 242046 RVA: 0x007EE6BD File Offset: 0x007EC8BD
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceExit(IVisualNovelPerformanceExitT _ivisualnovelperformanceexit)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceExit,
				Value = _ivisualnovelperformanceexit
			};
		}

		// Token: 0x0603B17F RID: 242047 RVA: 0x007EE6D2 File Offset: 0x007EC8D2
		public IVisualNovelPerformanceLeaveBlackScreenT AsIVisualNovelPerformanceLeaveBlackScreen()
		{
			return this.As<IVisualNovelPerformanceLeaveBlackScreenT>();
		}

		// Token: 0x0603B180 RID: 242048 RVA: 0x007EE6DA File Offset: 0x007EC8DA
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceLeaveBlackScreen(IVisualNovelPerformanceLeaveBlackScreenT _ivisualnovelperformanceleaveblackscreen)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen,
				Value = _ivisualnovelperformanceleaveblackscreen
			};
		}

		// Token: 0x0603B181 RID: 242049 RVA: 0x007EE6EF File Offset: 0x007EC8EF
		public IVisualNovelPerformanceModifyRoleT AsIVisualNovelPerformanceModifyRole()
		{
			return this.As<IVisualNovelPerformanceModifyRoleT>();
		}

		// Token: 0x0603B182 RID: 242050 RVA: 0x007EE6F7 File Offset: 0x007EC8F7
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceModifyRole(IVisualNovelPerformanceModifyRoleT _ivisualnovelperformancemodifyrole)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceModifyRole,
				Value = _ivisualnovelperformancemodifyrole
			};
		}

		// Token: 0x0603B183 RID: 242051 RVA: 0x007EE70C File Offset: 0x007EC90C
		public IVisualNovelPerformanceMoveT AsIVisualNovelPerformanceMove()
		{
			return this.As<IVisualNovelPerformanceMoveT>();
		}

		// Token: 0x0603B184 RID: 242052 RVA: 0x007EE714 File Offset: 0x007EC914
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceMove(IVisualNovelPerformanceMoveT _ivisualnovelperformancemove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceMove,
				Value = _ivisualnovelperformancemove
			};
		}

		// Token: 0x0603B185 RID: 242053 RVA: 0x007EE72A File Offset: 0x007EC92A
		public IVisualNovelPerformancePlayScreenEffectT AsIVisualNovelPerformancePlayScreenEffect()
		{
			return this.As<IVisualNovelPerformancePlayScreenEffectT>();
		}

		// Token: 0x0603B186 RID: 242054 RVA: 0x007EE732 File Offset: 0x007EC932
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformancePlayScreenEffect(IVisualNovelPerformancePlayScreenEffectT _ivisualnovelperformanceplayscreeneffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect,
				Value = _ivisualnovelperformanceplayscreeneffect
			};
		}

		// Token: 0x0603B187 RID: 242055 RVA: 0x007EE748 File Offset: 0x007EC948
		public IVisualNovelPerformancePortraitEffectT AsIVisualNovelPerformancePortraitEffect()
		{
			return this.As<IVisualNovelPerformancePortraitEffectT>();
		}

		// Token: 0x0603B188 RID: 242056 RVA: 0x007EE750 File Offset: 0x007EC950
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformancePortraitEffect(IVisualNovelPerformancePortraitEffectT _ivisualnovelperformanceportraiteffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect,
				Value = _ivisualnovelperformanceportraiteffect
			};
		}

		// Token: 0x0603B189 RID: 242057 RVA: 0x007EE766 File Offset: 0x007EC966
		public IVisualNovelPerformanceRoleIntroductionT AsIVisualNovelPerformanceRoleIntroduction()
		{
			return this.As<IVisualNovelPerformanceRoleIntroductionT>();
		}

		// Token: 0x0603B18A RID: 242058 RVA: 0x007EE76E File Offset: 0x007EC96E
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceRoleIntroduction(IVisualNovelPerformanceRoleIntroductionT _ivisualnovelperformanceroleintroduction)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction,
				Value = _ivisualnovelperformanceroleintroduction
			};
		}

		// Token: 0x0603B18B RID: 242059 RVA: 0x007EE784 File Offset: 0x007EC984
		public IVisualNovelPerformanceSendAudioEventT AsIVisualNovelPerformanceSendAudioEvent()
		{
			return this.As<IVisualNovelPerformanceSendAudioEventT>();
		}

		// Token: 0x0603B18C RID: 242060 RVA: 0x007EE78C File Offset: 0x007EC98C
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceSendAudioEvent(IVisualNovelPerformanceSendAudioEventT _ivisualnovelperformancesendaudioevent)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent,
				Value = _ivisualnovelperformancesendaudioevent
			};
		}

		// Token: 0x0603B18D RID: 242061 RVA: 0x007EE7A2 File Offset: 0x007EC9A2
		public IVisualNovelPerformanceStopScreenEffectT AsIVisualNovelPerformanceStopScreenEffect()
		{
			return this.As<IVisualNovelPerformanceStopScreenEffectT>();
		}

		// Token: 0x0603B18E RID: 242062 RVA: 0x007EE7AA File Offset: 0x007EC9AA
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceStopScreenEffect(IVisualNovelPerformanceStopScreenEffectT _ivisualnovelperformancestopscreeneffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect,
				Value = _ivisualnovelperformancestopscreeneffect
			};
		}

		// Token: 0x0603B18F RID: 242063 RVA: 0x007EE7C0 File Offset: 0x007EC9C0
		public IVisualNovelPerformanceSwitchAudioStateT AsIVisualNovelPerformanceSwitchAudioState()
		{
			return this.As<IVisualNovelPerformanceSwitchAudioStateT>();
		}

		// Token: 0x0603B190 RID: 242064 RVA: 0x007EE7C8 File Offset: 0x007EC9C8
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceSwitchAudioState(IVisualNovelPerformanceSwitchAudioStateT _ivisualnovelperformanceswitchaudiostate)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState,
				Value = _ivisualnovelperformanceswitchaudiostate
			};
		}

		// Token: 0x0603B191 RID: 242065 RVA: 0x007EE7DE File Offset: 0x007EC9DE
		public IVisualNovelPerformanceTransitionT AsIVisualNovelPerformanceTransition()
		{
			return this.As<IVisualNovelPerformanceTransitionT>();
		}

		// Token: 0x0603B192 RID: 242066 RVA: 0x007EE7E6 File Offset: 0x007EC9E6
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceTransition(IVisualNovelPerformanceTransitionT _ivisualnovelperformancetransition)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceTransition,
				Value = _ivisualnovelperformancetransition
			};
		}

		// Token: 0x0603B193 RID: 242067 RVA: 0x007EE7FC File Offset: 0x007EC9FC
		public static int Pack(FlatBufferBuilder builder, TVisualNovelPerformanceUnion _o)
		{
			switch (_o.Type)
			{
			case TVisualNovelPerformance.IVisualNovelPerformanceActivityAction:
				return IVisualNovelPerformanceActivityAction.Pack(builder, _o.AsIVisualNovelPerformanceActivityAction()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove:
				return IVisualNovelPerformanceBackgroundMove.Pack(builder, _o.AsIVisualNovelPerformanceBackgroundMove()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceCgMove:
				return IVisualNovelPerformanceCgMove.Pack(builder, _o.AsIVisualNovelPerformanceCgMove()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceEnter:
				return IVisualNovelPerformanceEnter.Pack(builder, _o.AsIVisualNovelPerformanceEnter()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen:
				return IVisualNovelPerformanceEnterBlackScreen.Pack(builder, _o.AsIVisualNovelPerformanceEnterBlackScreen()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceExit:
				return IVisualNovelPerformanceExit.Pack(builder, _o.AsIVisualNovelPerformanceExit()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen:
				return IVisualNovelPerformanceLeaveBlackScreen.Pack(builder, _o.AsIVisualNovelPerformanceLeaveBlackScreen()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceModifyRole:
				return IVisualNovelPerformanceModifyRole.Pack(builder, _o.AsIVisualNovelPerformanceModifyRole()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceMove:
				return IVisualNovelPerformanceMove.Pack(builder, _o.AsIVisualNovelPerformanceMove()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect:
				return IVisualNovelPerformancePlayScreenEffect.Pack(builder, _o.AsIVisualNovelPerformancePlayScreenEffect()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect:
				return IVisualNovelPerformancePortraitEffect.Pack(builder, _o.AsIVisualNovelPerformancePortraitEffect()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction:
				return IVisualNovelPerformanceRoleIntroduction.Pack(builder, _o.AsIVisualNovelPerformanceRoleIntroduction()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent:
				return IVisualNovelPerformanceSendAudioEvent.Pack(builder, _o.AsIVisualNovelPerformanceSendAudioEvent()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect:
				return IVisualNovelPerformanceStopScreenEffect.Pack(builder, _o.AsIVisualNovelPerformanceStopScreenEffect()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState:
				return IVisualNovelPerformanceSwitchAudioState.Pack(builder, _o.AsIVisualNovelPerformanceSwitchAudioState()).Value;
			case TVisualNovelPerformance.IVisualNovelPerformanceTransition:
				return IVisualNovelPerformanceTransition.Pack(builder, _o.AsIVisualNovelPerformanceTransition()).Value;
			default:
				return 0;
			}
		}
	}
}
