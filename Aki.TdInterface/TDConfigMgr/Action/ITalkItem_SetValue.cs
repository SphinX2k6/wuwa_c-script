using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002166 RID: 8550
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItem_SetValue
	{
		// Token: 0x04006B67 RID: 27495
		public ETalkItemType? Type;

		// Token: 0x04006B68 RID: 27496
		public int Id;

		// Token: 0x04006B69 RID: 27497
		public int? PlotLineId;

		// Token: 0x04006B6A RID: 27498
		public string PlotLineKey;

		// Token: 0x04006B6B RID: 27499
		[Nullable(0)]
		public string Name;

		// Token: 0x04006B6C RID: 27500
		public bool? _folded;

		// Token: 0x04006B6D RID: 27501
		public EEditFlag? _editFlag;

		// Token: 0x04006B6E RID: 27502
		public int? WhoId;

		// Token: 0x04006B6F RID: 27503
		public int? TextId;

		// Token: 0x04006B70 RID: 27504
		public string TidTalk;

		// Token: 0x04006B71 RID: 27505
		public float? WaitTime;

		// Token: 0x04006B72 RID: 27506
		public ICaptionParam CaptionParams;

		// Token: 0x04006B73 RID: 27507
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006B74 RID: 27508
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006B75 RID: 27509
		public PlayMontage Montage;

		// Token: 0x04006B76 RID: 27510
		public ICameraData CameraData;

		// Token: 0x04006B77 RID: 27511
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006B78 RID: 27512
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006B79 RID: 27513
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006B7A RID: 27514
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006B7B RID: 27515
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006B7C RID: 27516
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006B7D RID: 27517
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006B7E RID: 27518
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006B7F RID: 27519
		public IUniversalTone UniversalTone;

		// Token: 0x04006B80 RID: 27520
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006B81 RID: 27521
		public bool? PlayVoice;

		// Token: 0x04006B82 RID: 27522
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006B83 RID: 27523
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006B84 RID: 27524
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006B85 RID: 27525
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006B86 RID: 27526
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006B87 RID: 27527
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
