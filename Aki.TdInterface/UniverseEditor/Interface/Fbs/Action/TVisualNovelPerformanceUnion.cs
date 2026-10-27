using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007814 RID: 30740
	public class TVisualNovelPerformanceUnion
	{
		// Token: 0x1700E6FB RID: 59131
		// (get) Token: 0x06037BBC RID: 228284 RVA: 0x00788B68 File Offset: 0x00786D68
		// (set) Token: 0x06037BBD RID: 228285 RVA: 0x00788B70 File Offset: 0x00786D70
		public TVisualNovelPerformance Type { get; set; }

		// Token: 0x1700E6FC RID: 59132
		// (get) Token: 0x06037BBE RID: 228286 RVA: 0x00788B79 File Offset: 0x00786D79
		// (set) Token: 0x06037BBF RID: 228287 RVA: 0x00788B81 File Offset: 0x00786D81
		public object Value { get; set; }

		// Token: 0x06037BC0 RID: 228288 RVA: 0x00788B8A File Offset: 0x00786D8A
		public TVisualNovelPerformanceUnion()
		{
			this.Type = TVisualNovelPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x06037BC1 RID: 228289 RVA: 0x00788BA0 File Offset: 0x00786DA0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037BC2 RID: 228290 RVA: 0x00788BB2 File Offset: 0x00786DB2
		public IVisualNovelPerformanceActivityActionT AsIVisualNovelPerformanceActivityAction()
		{
			return this.As<IVisualNovelPerformanceActivityActionT>();
		}

		// Token: 0x06037BC3 RID: 228291 RVA: 0x00788BBA File Offset: 0x00786DBA
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceActivityAction(IVisualNovelPerformanceActivityActionT _ivisualnovelperformanceactivityaction)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceActivityAction,
				Value = _ivisualnovelperformanceactivityaction
			};
		}

		// Token: 0x06037BC4 RID: 228292 RVA: 0x00788BCF File Offset: 0x00786DCF
		public IVisualNovelPerformanceBackgroundMoveT AsIVisualNovelPerformanceBackgroundMove()
		{
			return this.As<IVisualNovelPerformanceBackgroundMoveT>();
		}

		// Token: 0x06037BC5 RID: 228293 RVA: 0x00788BD7 File Offset: 0x00786DD7
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceBackgroundMove(IVisualNovelPerformanceBackgroundMoveT _ivisualnovelperformancebackgroundmove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceBackgroundMove,
				Value = _ivisualnovelperformancebackgroundmove
			};
		}

		// Token: 0x06037BC6 RID: 228294 RVA: 0x00788BEC File Offset: 0x00786DEC
		public IVisualNovelPerformanceCgMoveT AsIVisualNovelPerformanceCgMove()
		{
			return this.As<IVisualNovelPerformanceCgMoveT>();
		}

		// Token: 0x06037BC7 RID: 228295 RVA: 0x00788BF4 File Offset: 0x00786DF4
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceCgMove(IVisualNovelPerformanceCgMoveT _ivisualnovelperformancecgmove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceCgMove,
				Value = _ivisualnovelperformancecgmove
			};
		}

		// Token: 0x06037BC8 RID: 228296 RVA: 0x00788C09 File Offset: 0x00786E09
		public IVisualNovelPerformanceEnterT AsIVisualNovelPerformanceEnter()
		{
			return this.As<IVisualNovelPerformanceEnterT>();
		}

		// Token: 0x06037BC9 RID: 228297 RVA: 0x00788C11 File Offset: 0x00786E11
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceEnter(IVisualNovelPerformanceEnterT _ivisualnovelperformanceenter)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceEnter,
				Value = _ivisualnovelperformanceenter
			};
		}

		// Token: 0x06037BCA RID: 228298 RVA: 0x00788C26 File Offset: 0x00786E26
		public IVisualNovelPerformanceEnterBlackScreenT AsIVisualNovelPerformanceEnterBlackScreen()
		{
			return this.As<IVisualNovelPerformanceEnterBlackScreenT>();
		}

		// Token: 0x06037BCB RID: 228299 RVA: 0x00788C2E File Offset: 0x00786E2E
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceEnterBlackScreen(IVisualNovelPerformanceEnterBlackScreenT _ivisualnovelperformanceenterblackscreen)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceEnterBlackScreen,
				Value = _ivisualnovelperformanceenterblackscreen
			};
		}

		// Token: 0x06037BCC RID: 228300 RVA: 0x00788C43 File Offset: 0x00786E43
		public IVisualNovelPerformanceExitT AsIVisualNovelPerformanceExit()
		{
			return this.As<IVisualNovelPerformanceExitT>();
		}

		// Token: 0x06037BCD RID: 228301 RVA: 0x00788C4B File Offset: 0x00786E4B
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceExit(IVisualNovelPerformanceExitT _ivisualnovelperformanceexit)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceExit,
				Value = _ivisualnovelperformanceexit
			};
		}

		// Token: 0x06037BCE RID: 228302 RVA: 0x00788C60 File Offset: 0x00786E60
		public IVisualNovelPerformanceLeaveBlackScreenT AsIVisualNovelPerformanceLeaveBlackScreen()
		{
			return this.As<IVisualNovelPerformanceLeaveBlackScreenT>();
		}

		// Token: 0x06037BCF RID: 228303 RVA: 0x00788C68 File Offset: 0x00786E68
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceLeaveBlackScreen(IVisualNovelPerformanceLeaveBlackScreenT _ivisualnovelperformanceleaveblackscreen)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceLeaveBlackScreen,
				Value = _ivisualnovelperformanceleaveblackscreen
			};
		}

		// Token: 0x06037BD0 RID: 228304 RVA: 0x00788C7D File Offset: 0x00786E7D
		public IVisualNovelPerformanceModifyRoleT AsIVisualNovelPerformanceModifyRole()
		{
			return this.As<IVisualNovelPerformanceModifyRoleT>();
		}

		// Token: 0x06037BD1 RID: 228305 RVA: 0x00788C85 File Offset: 0x00786E85
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceModifyRole(IVisualNovelPerformanceModifyRoleT _ivisualnovelperformancemodifyrole)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceModifyRole,
				Value = _ivisualnovelperformancemodifyrole
			};
		}

		// Token: 0x06037BD2 RID: 228306 RVA: 0x00788C9A File Offset: 0x00786E9A
		public IVisualNovelPerformanceMoveT AsIVisualNovelPerformanceMove()
		{
			return this.As<IVisualNovelPerformanceMoveT>();
		}

		// Token: 0x06037BD3 RID: 228307 RVA: 0x00788CA2 File Offset: 0x00786EA2
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceMove(IVisualNovelPerformanceMoveT _ivisualnovelperformancemove)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceMove,
				Value = _ivisualnovelperformancemove
			};
		}

		// Token: 0x06037BD4 RID: 228308 RVA: 0x00788CB8 File Offset: 0x00786EB8
		public IVisualNovelPerformancePlayScreenEffectT AsIVisualNovelPerformancePlayScreenEffect()
		{
			return this.As<IVisualNovelPerformancePlayScreenEffectT>();
		}

		// Token: 0x06037BD5 RID: 228309 RVA: 0x00788CC0 File Offset: 0x00786EC0
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformancePlayScreenEffect(IVisualNovelPerformancePlayScreenEffectT _ivisualnovelperformanceplayscreeneffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformancePlayScreenEffect,
				Value = _ivisualnovelperformanceplayscreeneffect
			};
		}

		// Token: 0x06037BD6 RID: 228310 RVA: 0x00788CD6 File Offset: 0x00786ED6
		public IVisualNovelPerformancePortraitEffectT AsIVisualNovelPerformancePortraitEffect()
		{
			return this.As<IVisualNovelPerformancePortraitEffectT>();
		}

		// Token: 0x06037BD7 RID: 228311 RVA: 0x00788CDE File Offset: 0x00786EDE
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformancePortraitEffect(IVisualNovelPerformancePortraitEffectT _ivisualnovelperformanceportraiteffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformancePortraitEffect,
				Value = _ivisualnovelperformanceportraiteffect
			};
		}

		// Token: 0x06037BD8 RID: 228312 RVA: 0x00788CF4 File Offset: 0x00786EF4
		public IVisualNovelPerformanceRoleIntroductionT AsIVisualNovelPerformanceRoleIntroduction()
		{
			return this.As<IVisualNovelPerformanceRoleIntroductionT>();
		}

		// Token: 0x06037BD9 RID: 228313 RVA: 0x00788CFC File Offset: 0x00786EFC
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceRoleIntroduction(IVisualNovelPerformanceRoleIntroductionT _ivisualnovelperformanceroleintroduction)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceRoleIntroduction,
				Value = _ivisualnovelperformanceroleintroduction
			};
		}

		// Token: 0x06037BDA RID: 228314 RVA: 0x00788D12 File Offset: 0x00786F12
		public IVisualNovelPerformanceSendAudioEventT AsIVisualNovelPerformanceSendAudioEvent()
		{
			return this.As<IVisualNovelPerformanceSendAudioEventT>();
		}

		// Token: 0x06037BDB RID: 228315 RVA: 0x00788D1A File Offset: 0x00786F1A
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceSendAudioEvent(IVisualNovelPerformanceSendAudioEventT _ivisualnovelperformancesendaudioevent)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceSendAudioEvent,
				Value = _ivisualnovelperformancesendaudioevent
			};
		}

		// Token: 0x06037BDC RID: 228316 RVA: 0x00788D30 File Offset: 0x00786F30
		public IVisualNovelPerformanceStopScreenEffectT AsIVisualNovelPerformanceStopScreenEffect()
		{
			return this.As<IVisualNovelPerformanceStopScreenEffectT>();
		}

		// Token: 0x06037BDD RID: 228317 RVA: 0x00788D38 File Offset: 0x00786F38
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceStopScreenEffect(IVisualNovelPerformanceStopScreenEffectT _ivisualnovelperformancestopscreeneffect)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceStopScreenEffect,
				Value = _ivisualnovelperformancestopscreeneffect
			};
		}

		// Token: 0x06037BDE RID: 228318 RVA: 0x00788D4E File Offset: 0x00786F4E
		public IVisualNovelPerformanceSwitchAudioStateT AsIVisualNovelPerformanceSwitchAudioState()
		{
			return this.As<IVisualNovelPerformanceSwitchAudioStateT>();
		}

		// Token: 0x06037BDF RID: 228319 RVA: 0x00788D56 File Offset: 0x00786F56
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceSwitchAudioState(IVisualNovelPerformanceSwitchAudioStateT _ivisualnovelperformanceswitchaudiostate)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceSwitchAudioState,
				Value = _ivisualnovelperformanceswitchaudiostate
			};
		}

		// Token: 0x06037BE0 RID: 228320 RVA: 0x00788D6C File Offset: 0x00786F6C
		public IVisualNovelPerformanceTransitionT AsIVisualNovelPerformanceTransition()
		{
			return this.As<IVisualNovelPerformanceTransitionT>();
		}

		// Token: 0x06037BE1 RID: 228321 RVA: 0x00788D74 File Offset: 0x00786F74
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceTransition(IVisualNovelPerformanceTransitionT _ivisualnovelperformancetransition)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceTransition,
				Value = _ivisualnovelperformancetransition
			};
		}

		// Token: 0x06037BE2 RID: 228322 RVA: 0x00788D8A File Offset: 0x00786F8A
		public IVisualNovelPerformanceUiShakeT AsIVisualNovelPerformanceUiShake()
		{
			return this.As<IVisualNovelPerformanceUiShakeT>();
		}

		// Token: 0x06037BE3 RID: 228323 RVA: 0x00788D92 File Offset: 0x00786F92
		public static TVisualNovelPerformanceUnion FromIVisualNovelPerformanceUiShake(IVisualNovelPerformanceUiShakeT _ivisualnovelperformanceuishake)
		{
			return new TVisualNovelPerformanceUnion
			{
				Type = TVisualNovelPerformance.IVisualNovelPerformanceUiShake,
				Value = _ivisualnovelperformanceuishake
			};
		}

		// Token: 0x06037BE4 RID: 228324 RVA: 0x00788DA8 File Offset: 0x00786FA8
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
			case TVisualNovelPerformance.IVisualNovelPerformanceUiShake:
				return IVisualNovelPerformanceUiShake.Pack(builder, _o.AsIVisualNovelPerformanceUiShake()).Value;
			default:
				return 0;
			}
		}
	}
}
