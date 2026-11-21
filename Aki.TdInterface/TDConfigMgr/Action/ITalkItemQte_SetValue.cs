using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218E RID: 8590
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemQte_SetValue
	{
		// Token: 0x04006EEE RID: 28398
		public ETalkItemType? Type;

		// Token: 0x04006EEF RID: 28399
		public int Id;

		// Token: 0x04006EF0 RID: 28400
		public int? PlotLineId;

		// Token: 0x04006EF1 RID: 28401
		public string PlotLineKey;

		// Token: 0x04006EF2 RID: 28402
		[Nullable(0)]
		public string Name;

		// Token: 0x04006EF3 RID: 28403
		public bool? _folded;

		// Token: 0x04006EF4 RID: 28404
		public EEditFlag? _editFlag;

		// Token: 0x04006EF5 RID: 28405
		public int? WhoId;

		// Token: 0x04006EF6 RID: 28406
		public int? TextId;

		// Token: 0x04006EF7 RID: 28407
		public string TidTalk;

		// Token: 0x04006EF8 RID: 28408
		public float? WaitTime;

		// Token: 0x04006EF9 RID: 28409
		public ICaptionParam CaptionParams;

		// Token: 0x04006EFA RID: 28410
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006EFB RID: 28411
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006EFC RID: 28412
		public PlayMontage Montage;

		// Token: 0x04006EFD RID: 28413
		public ICameraData CameraData;

		// Token: 0x04006EFE RID: 28414
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006EFF RID: 28415
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006F00 RID: 28416
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006F01 RID: 28417
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006F02 RID: 28418
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006F03 RID: 28419
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006F04 RID: 28420
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006F05 RID: 28421
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006F06 RID: 28422
		public IUniversalTone UniversalTone;

		// Token: 0x04006F07 RID: 28423
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006F08 RID: 28424
		public bool? PlayVoice;

		// Token: 0x04006F09 RID: 28425
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006F0A RID: 28426
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006F0B RID: 28427
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006F0C RID: 28428
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006F0D RID: 28429
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006F0E RID: 28430
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006F0F RID: 28431
		public int QteId;
	}
}
