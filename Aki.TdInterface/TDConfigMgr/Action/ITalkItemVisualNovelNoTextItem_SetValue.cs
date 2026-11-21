using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219E RID: 8606
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNoTextItem_SetValue
	{
		// Token: 0x04007022 RID: 28706
		public ETalkItemType? Type;

		// Token: 0x04007023 RID: 28707
		public int Id;

		// Token: 0x04007024 RID: 28708
		public int? PlotLineId;

		// Token: 0x04007025 RID: 28709
		public string PlotLineKey;

		// Token: 0x04007026 RID: 28710
		[Nullable(0)]
		public string Name;

		// Token: 0x04007027 RID: 28711
		public bool? _folded;

		// Token: 0x04007028 RID: 28712
		public EEditFlag? _editFlag;

		// Token: 0x04007029 RID: 28713
		public int? WhoId;

		// Token: 0x0400702A RID: 28714
		public int? TextId;

		// Token: 0x0400702B RID: 28715
		public string TidTalk;

		// Token: 0x0400702C RID: 28716
		public float? WaitTime;

		// Token: 0x0400702D RID: 28717
		public ICaptionParam CaptionParams;

		// Token: 0x0400702E RID: 28718
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400702F RID: 28719
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04007030 RID: 28720
		public PlayMontage Montage;

		// Token: 0x04007031 RID: 28721
		public ICameraData CameraData;

		// Token: 0x04007032 RID: 28722
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04007033 RID: 28723
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04007034 RID: 28724
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04007035 RID: 28725
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04007036 RID: 28726
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04007037 RID: 28727
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04007038 RID: 28728
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04007039 RID: 28729
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x0400703A RID: 28730
		public IUniversalTone UniversalTone;

		// Token: 0x0400703B RID: 28731
		public ITalkBackground BackgroundConfig;

		// Token: 0x0400703C RID: 28732
		public bool? PlayVoice;

		// Token: 0x0400703D RID: 28733
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400703E RID: 28734
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400703F RID: 28735
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04007040 RID: 28736
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04007041 RID: 28737
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04007042 RID: 28738
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04007043 RID: 28739
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04007044 RID: 28740
		public IVisualNovelOptionGroupConfigBase OptionGroup;

		// Token: 0x04007045 RID: 28741
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04007046 RID: 28742
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04007047 RID: 28743
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04007048 RID: 28744
		public int? PlotKeyId;

		// Token: 0x04007049 RID: 28745
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x0400704A RID: 28746
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
