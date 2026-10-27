using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F63 RID: 8035
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNoTextItem_SetValue
	{
		// Token: 0x04006A35 RID: 27189
		public ETalkItemType? Type;

		// Token: 0x04006A36 RID: 27190
		public int Id;

		// Token: 0x04006A37 RID: 27191
		public int? PlotLineId;

		// Token: 0x04006A38 RID: 27192
		public string PlotLineKey;

		// Token: 0x04006A39 RID: 27193
		[Nullable(1)]
		public string Name;

		// Token: 0x04006A3A RID: 27194
		public bool? _folded;

		// Token: 0x04006A3B RID: 27195
		public EEditFlag? _editFlag;

		// Token: 0x04006A3C RID: 27196
		public int? WhoId;

		// Token: 0x04006A3D RID: 27197
		public int? TextId;

		// Token: 0x04006A3E RID: 27198
		public string TidTalk;

		// Token: 0x04006A3F RID: 27199
		public float? WaitTime;

		// Token: 0x04006A40 RID: 27200
		public ICaptionParam CaptionParams;

		// Token: 0x04006A41 RID: 27201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006A42 RID: 27202
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006A43 RID: 27203
		public PlayMontage Montage;

		// Token: 0x04006A44 RID: 27204
		public ICameraData CameraData;

		// Token: 0x04006A45 RID: 27205
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006A46 RID: 27206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006A47 RID: 27207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006A48 RID: 27208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006A49 RID: 27209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006A4A RID: 27210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006A4B RID: 27211
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006A4C RID: 27212
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006A4D RID: 27213
		public IUniversalTone UniversalTone;

		// Token: 0x04006A4E RID: 27214
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006A4F RID: 27215
		public bool? PlayVoice;

		// Token: 0x04006A50 RID: 27216
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006A51 RID: 27217
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006A52 RID: 27218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006A53 RID: 27219
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006A54 RID: 27220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006A55 RID: 27221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006A56 RID: 27222
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006A57 RID: 27223
		public IVisualNovelOptionGroupSolarSchoolExam OptionGroup;

		// Token: 0x04006A58 RID: 27224
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04006A59 RID: 27225
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04006A5A RID: 27226
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04006A5B RID: 27227
		public int? PlotKeyId;

		// Token: 0x04006A5C RID: 27228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x04006A5D RID: 27229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
