using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F37 RID: 7991
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgNarration_SetValue
	{
		// Token: 0x0400669C RID: 26268
		public ETalkItemType? Type;

		// Token: 0x0400669D RID: 26269
		public int Id;

		// Token: 0x0400669E RID: 26270
		public int? PlotLineId;

		// Token: 0x0400669F RID: 26271
		public string PlotLineKey;

		// Token: 0x040066A0 RID: 26272
		[Nullable(1)]
		public string Name;

		// Token: 0x040066A1 RID: 26273
		public bool? _folded;

		// Token: 0x040066A2 RID: 26274
		public EEditFlag? _editFlag;

		// Token: 0x040066A3 RID: 26275
		public int? WhoId;

		// Token: 0x040066A4 RID: 26276
		public int? TextId;

		// Token: 0x040066A5 RID: 26277
		public string TidTalk;

		// Token: 0x040066A6 RID: 26278
		public float? WaitTime;

		// Token: 0x040066A7 RID: 26279
		public ICaptionParam CaptionParams;

		// Token: 0x040066A8 RID: 26280
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040066A9 RID: 26281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040066AA RID: 26282
		public PlayMontage Montage;

		// Token: 0x040066AB RID: 26283
		public ICameraData CameraData;

		// Token: 0x040066AC RID: 26284
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040066AD RID: 26285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040066AE RID: 26286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040066AF RID: 26287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040066B0 RID: 26288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040066B1 RID: 26289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040066B2 RID: 26290
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040066B3 RID: 26291
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040066B4 RID: 26292
		public IUniversalTone UniversalTone;

		// Token: 0x040066B5 RID: 26293
		public ITalkBackground BackgroundConfig;

		// Token: 0x040066B6 RID: 26294
		public bool? PlayVoice;

		// Token: 0x040066B7 RID: 26295
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040066B8 RID: 26296
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040066B9 RID: 26297
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040066BA RID: 26298
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040066BB RID: 26299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040066BC RID: 26300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
