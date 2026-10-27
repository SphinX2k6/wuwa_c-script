using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F61 RID: 8033
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNarration_SetValue
	{
		// Token: 0x040069E3 RID: 27107
		public ETalkItemType? Type;

		// Token: 0x040069E4 RID: 27108
		public int Id;

		// Token: 0x040069E5 RID: 27109
		public int? PlotLineId;

		// Token: 0x040069E6 RID: 27110
		public string PlotLineKey;

		// Token: 0x040069E7 RID: 27111
		[Nullable(1)]
		public string Name;

		// Token: 0x040069E8 RID: 27112
		public bool? _folded;

		// Token: 0x040069E9 RID: 27113
		public EEditFlag? _editFlag;

		// Token: 0x040069EA RID: 27114
		public int? WhoId;

		// Token: 0x040069EB RID: 27115
		public int? TextId;

		// Token: 0x040069EC RID: 27116
		public string TidTalk;

		// Token: 0x040069ED RID: 27117
		public float? WaitTime;

		// Token: 0x040069EE RID: 27118
		public ICaptionParam CaptionParams;

		// Token: 0x040069EF RID: 27119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040069F0 RID: 27120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040069F1 RID: 27121
		public PlayMontage Montage;

		// Token: 0x040069F2 RID: 27122
		public ICameraData CameraData;

		// Token: 0x040069F3 RID: 27123
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040069F4 RID: 27124
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040069F5 RID: 27125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040069F6 RID: 27126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040069F7 RID: 27127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040069F8 RID: 27128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040069F9 RID: 27129
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040069FA RID: 27130
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040069FB RID: 27131
		public IUniversalTone UniversalTone;

		// Token: 0x040069FC RID: 27132
		public ITalkBackground BackgroundConfig;

		// Token: 0x040069FD RID: 27133
		public bool? PlayVoice;

		// Token: 0x040069FE RID: 27134
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040069FF RID: 27135
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006A00 RID: 27136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006A01 RID: 27137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006A02 RID: 27138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006A03 RID: 27139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006A04 RID: 27140
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006A05 RID: 27141
		public IVisualNovelOptionGroupSolarSchoolExam OptionGroup;

		// Token: 0x04006A06 RID: 27142
		public float? DialogDelay;

		// Token: 0x04006A07 RID: 27143
		public bool? ClickShowFull;

		// Token: 0x04006A08 RID: 27144
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04006A09 RID: 27145
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04006A0A RID: 27146
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04006A0B RID: 27147
		public int? PlotKeyId;

		// Token: 0x04006A0C RID: 27148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x04006A0D RID: 27149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
