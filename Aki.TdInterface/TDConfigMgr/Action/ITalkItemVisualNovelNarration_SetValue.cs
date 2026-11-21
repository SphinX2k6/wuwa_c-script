using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200219C RID: 8604
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelNarration_SetValue
	{
		// Token: 0x04006FD2 RID: 28626
		public ETalkItemType? Type;

		// Token: 0x04006FD3 RID: 28627
		public int Id;

		// Token: 0x04006FD4 RID: 28628
		public int? PlotLineId;

		// Token: 0x04006FD5 RID: 28629
		public string PlotLineKey;

		// Token: 0x04006FD6 RID: 28630
		[Nullable(0)]
		public string Name;

		// Token: 0x04006FD7 RID: 28631
		public bool? _folded;

		// Token: 0x04006FD8 RID: 28632
		public EEditFlag? _editFlag;

		// Token: 0x04006FD9 RID: 28633
		public int? WhoId;

		// Token: 0x04006FDA RID: 28634
		public int? TextId;

		// Token: 0x04006FDB RID: 28635
		public string TidTalk;

		// Token: 0x04006FDC RID: 28636
		public float? WaitTime;

		// Token: 0x04006FDD RID: 28637
		public ICaptionParam CaptionParams;

		// Token: 0x04006FDE RID: 28638
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006FDF RID: 28639
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006FE0 RID: 28640
		public PlayMontage Montage;

		// Token: 0x04006FE1 RID: 28641
		public ICameraData CameraData;

		// Token: 0x04006FE2 RID: 28642
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006FE3 RID: 28643
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006FE4 RID: 28644
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006FE5 RID: 28645
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006FE6 RID: 28646
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006FE7 RID: 28647
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006FE8 RID: 28648
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006FE9 RID: 28649
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006FEA RID: 28650
		public IUniversalTone UniversalTone;

		// Token: 0x04006FEB RID: 28651
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006FEC RID: 28652
		public bool? PlayVoice;

		// Token: 0x04006FED RID: 28653
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006FEE RID: 28654
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006FEF RID: 28655
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006FF0 RID: 28656
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006FF1 RID: 28657
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006FF2 RID: 28658
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006FF3 RID: 28659
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006FF4 RID: 28660
		public IVisualNovelOptionGroupConfigBase OptionGroup;

		// Token: 0x04006FF5 RID: 28661
		public float? DialogDelay;

		// Token: 0x04006FF6 RID: 28662
		public bool? ClickShowFull;

		// Token: 0x04006FF7 RID: 28663
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04006FF8 RID: 28664
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04006FF9 RID: 28665
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04006FFA RID: 28666
		public int? PlotKeyId;

		// Token: 0x04006FFB RID: 28667
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x04006FFC RID: 28668
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
