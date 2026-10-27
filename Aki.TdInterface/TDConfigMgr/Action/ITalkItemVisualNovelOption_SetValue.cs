using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F65 RID: 8037
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelOption_SetValue
	{
		// Token: 0x04006A85 RID: 27269
		public ETalkItemType? Type;

		// Token: 0x04006A86 RID: 27270
		public int Id;

		// Token: 0x04006A87 RID: 27271
		public int? PlotLineId;

		// Token: 0x04006A88 RID: 27272
		public string PlotLineKey;

		// Token: 0x04006A89 RID: 27273
		[Nullable(1)]
		public string Name;

		// Token: 0x04006A8A RID: 27274
		public bool? _folded;

		// Token: 0x04006A8B RID: 27275
		public EEditFlag? _editFlag;

		// Token: 0x04006A8C RID: 27276
		public int? WhoId;

		// Token: 0x04006A8D RID: 27277
		public int? TextId;

		// Token: 0x04006A8E RID: 27278
		public string TidTalk;

		// Token: 0x04006A8F RID: 27279
		public float? WaitTime;

		// Token: 0x04006A90 RID: 27280
		public ICaptionParam CaptionParams;

		// Token: 0x04006A91 RID: 27281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006A92 RID: 27282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006A93 RID: 27283
		public PlayMontage Montage;

		// Token: 0x04006A94 RID: 27284
		public ICameraData CameraData;

		// Token: 0x04006A95 RID: 27285
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006A96 RID: 27286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006A97 RID: 27287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006A98 RID: 27288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006A99 RID: 27289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006A9A RID: 27290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006A9B RID: 27291
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006A9C RID: 27292
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006A9D RID: 27293
		public IUniversalTone UniversalTone;

		// Token: 0x04006A9E RID: 27294
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006A9F RID: 27295
		public bool? PlayVoice;

		// Token: 0x04006AA0 RID: 27296
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006AA1 RID: 27297
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006AA2 RID: 27298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006AA3 RID: 27299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006AA4 RID: 27300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006AA5 RID: 27301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006AA6 RID: 27302
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006AA7 RID: 27303
		public IVisualNovelOptionGroupSolarSchoolExam OptionGroup;

		// Token: 0x04006AA8 RID: 27304
		public int? CustomDescTextId;

		// Token: 0x04006AA9 RID: 27305
		public string TidCustomDescText;

		// Token: 0x04006AAA RID: 27306
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04006AAB RID: 27307
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04006AAC RID: 27308
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04006AAD RID: 27309
		public int? PlotKeyId;
	}
}
