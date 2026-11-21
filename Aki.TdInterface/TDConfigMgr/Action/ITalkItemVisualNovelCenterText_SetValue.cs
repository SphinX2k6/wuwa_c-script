using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219A RID: 8602
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText_SetValue
	{
		// Token: 0x04006F89 RID: 28553
		public ETalkItemType? Type;

		// Token: 0x04006F8A RID: 28554
		public int Id;

		// Token: 0x04006F8B RID: 28555
		public int? PlotLineId;

		// Token: 0x04006F8C RID: 28556
		public string PlotLineKey;

		// Token: 0x04006F8D RID: 28557
		[Nullable(0)]
		public string Name;

		// Token: 0x04006F8E RID: 28558
		public bool? _folded;

		// Token: 0x04006F8F RID: 28559
		public EEditFlag? _editFlag;

		// Token: 0x04006F90 RID: 28560
		public int? WhoId;

		// Token: 0x04006F91 RID: 28561
		public int? TextId;

		// Token: 0x04006F92 RID: 28562
		public string TidTalk;

		// Token: 0x04006F93 RID: 28563
		public float? WaitTime;

		// Token: 0x04006F94 RID: 28564
		public ICaptionParam CaptionParams;

		// Token: 0x04006F95 RID: 28565
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006F96 RID: 28566
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006F97 RID: 28567
		public PlayMontage Montage;

		// Token: 0x04006F98 RID: 28568
		public ICameraData CameraData;

		// Token: 0x04006F99 RID: 28569
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006F9A RID: 28570
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006F9B RID: 28571
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006F9C RID: 28572
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006F9D RID: 28573
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006F9E RID: 28574
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006F9F RID: 28575
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006FA0 RID: 28576
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006FA1 RID: 28577
		public IUniversalTone UniversalTone;

		// Token: 0x04006FA2 RID: 28578
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006FA3 RID: 28579
		public bool? PlayVoice;

		// Token: 0x04006FA4 RID: 28580
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006FA5 RID: 28581
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006FA6 RID: 28582
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006FA7 RID: 28583
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006FA8 RID: 28584
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006FA9 RID: 28585
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006FAA RID: 28586
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006FAB RID: 28587
		public IVisualNovelOptionGroupConfigBase OptionGroup;

		// Token: 0x04006FAC RID: 28588
		public int? PlotKeyId;
	}
}
