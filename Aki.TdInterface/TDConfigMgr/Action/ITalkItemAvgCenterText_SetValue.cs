using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216A RID: 8554
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgCenterText_SetValue
	{
		// Token: 0x04006BB2 RID: 27570
		public ETalkItemType? Type;

		// Token: 0x04006BB3 RID: 27571
		public int Id;

		// Token: 0x04006BB4 RID: 27572
		public int? PlotLineId;

		// Token: 0x04006BB5 RID: 27573
		public string PlotLineKey;

		// Token: 0x04006BB6 RID: 27574
		[Nullable(0)]
		public string Name;

		// Token: 0x04006BB7 RID: 27575
		public bool? _folded;

		// Token: 0x04006BB8 RID: 27576
		public EEditFlag? _editFlag;

		// Token: 0x04006BB9 RID: 27577
		public int? WhoId;

		// Token: 0x04006BBA RID: 27578
		public int? TextId;

		// Token: 0x04006BBB RID: 27579
		public string TidTalk;

		// Token: 0x04006BBC RID: 27580
		public float? WaitTime;

		// Token: 0x04006BBD RID: 27581
		public ICaptionParam CaptionParams;

		// Token: 0x04006BBE RID: 27582
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006BBF RID: 27583
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006BC0 RID: 27584
		public PlayMontage Montage;

		// Token: 0x04006BC1 RID: 27585
		public ICameraData CameraData;

		// Token: 0x04006BC2 RID: 27586
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006BC3 RID: 27587
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006BC4 RID: 27588
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006BC5 RID: 27589
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006BC6 RID: 27590
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006BC7 RID: 27591
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006BC8 RID: 27592
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006BC9 RID: 27593
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006BCA RID: 27594
		public IUniversalTone UniversalTone;

		// Token: 0x04006BCB RID: 27595
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006BCC RID: 27596
		public bool? PlayVoice;

		// Token: 0x04006BCD RID: 27597
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006BCE RID: 27598
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006BCF RID: 27599
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006BD0 RID: 27600
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006BD1 RID: 27601
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006BD2 RID: 27602
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
