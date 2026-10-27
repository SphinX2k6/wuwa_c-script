using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3D RID: 7997
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk_SetValue
	{
		// Token: 0x0400672F RID: 26415
		public ETalkItemType? Type;

		// Token: 0x04006730 RID: 26416
		public int Id;

		// Token: 0x04006731 RID: 26417
		public int? PlotLineId;

		// Token: 0x04006732 RID: 26418
		public string PlotLineKey;

		// Token: 0x04006733 RID: 26419
		[Nullable(1)]
		public string Name;

		// Token: 0x04006734 RID: 26420
		public bool? _folded;

		// Token: 0x04006735 RID: 26421
		public EEditFlag? _editFlag;

		// Token: 0x04006736 RID: 26422
		public int? WhoId;

		// Token: 0x04006737 RID: 26423
		public int? TextId;

		// Token: 0x04006738 RID: 26424
		public string TidTalk;

		// Token: 0x04006739 RID: 26425
		public float? WaitTime;

		// Token: 0x0400673A RID: 26426
		public ICaptionParam CaptionParams;

		// Token: 0x0400673B RID: 26427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400673C RID: 26428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x0400673D RID: 26429
		public PlayMontage Montage;

		// Token: 0x0400673E RID: 26430
		public ICameraData CameraData;

		// Token: 0x0400673F RID: 26431
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006740 RID: 26432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006741 RID: 26433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006742 RID: 26434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006743 RID: 26435
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006744 RID: 26436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006745 RID: 26437
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006746 RID: 26438
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006747 RID: 26439
		public IUniversalTone UniversalTone;

		// Token: 0x04006748 RID: 26440
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006749 RID: 26441
		public bool? PlayVoice;

		// Token: 0x0400674A RID: 26442
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400674B RID: 26443
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400674C RID: 26444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x0400674D RID: 26445
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400674E RID: 26446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x0400674F RID: 26447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006750 RID: 26448
		[Nullable(1)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;

		// Token: 0x04006751 RID: 26449
		public EAvgRolePosition PositionConfig;
	}
}
