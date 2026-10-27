using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F3F RID: 7999
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText_SetValue
	{
		// Token: 0x04006779 RID: 26489
		public ETalkItemType? Type;

		// Token: 0x0400677A RID: 26490
		public int Id;

		// Token: 0x0400677B RID: 26491
		public int? PlotLineId;

		// Token: 0x0400677C RID: 26492
		public string PlotLineKey;

		// Token: 0x0400677D RID: 26493
		[Nullable(1)]
		public string Name;

		// Token: 0x0400677E RID: 26494
		public bool? _folded;

		// Token: 0x0400677F RID: 26495
		public EEditFlag? _editFlag;

		// Token: 0x04006780 RID: 26496
		public int? WhoId;

		// Token: 0x04006781 RID: 26497
		public int? TextId;

		// Token: 0x04006782 RID: 26498
		public string TidTalk;

		// Token: 0x04006783 RID: 26499
		public float? WaitTime;

		// Token: 0x04006784 RID: 26500
		public ICaptionParam CaptionParams;

		// Token: 0x04006785 RID: 26501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006786 RID: 26502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006787 RID: 26503
		public PlayMontage Montage;

		// Token: 0x04006788 RID: 26504
		public ICameraData CameraData;

		// Token: 0x04006789 RID: 26505
		public SetFlowTemplate FlowTemplate;

		// Token: 0x0400678A RID: 26506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x0400678B RID: 26507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x0400678C RID: 26508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x0400678D RID: 26509
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x0400678E RID: 26510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x0400678F RID: 26511
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006790 RID: 26512
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006791 RID: 26513
		public IUniversalTone UniversalTone;

		// Token: 0x04006792 RID: 26514
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006793 RID: 26515
		public bool? PlayVoice;

		// Token: 0x04006794 RID: 26516
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006795 RID: 26517
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006796 RID: 26518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006797 RID: 26519
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006798 RID: 26520
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006799 RID: 26521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x0400679A RID: 26522
		public IShowCenterTextParams CenterTextConfig;

		// Token: 0x0400679B RID: 26523
		public bool? _IsPlotActionForPreview;
	}
}
