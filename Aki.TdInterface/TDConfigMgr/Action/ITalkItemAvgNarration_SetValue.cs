using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002170 RID: 8560
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgNarration_SetValue
	{
		// Token: 0x04006C8B RID: 27787
		public ETalkItemType? Type;

		// Token: 0x04006C8C RID: 27788
		public int Id;

		// Token: 0x04006C8D RID: 27789
		public int? PlotLineId;

		// Token: 0x04006C8E RID: 27790
		public string PlotLineKey;

		// Token: 0x04006C8F RID: 27791
		[Nullable(0)]
		public string Name;

		// Token: 0x04006C90 RID: 27792
		public bool? _folded;

		// Token: 0x04006C91 RID: 27793
		public EEditFlag? _editFlag;

		// Token: 0x04006C92 RID: 27794
		public int? WhoId;

		// Token: 0x04006C93 RID: 27795
		public int? TextId;

		// Token: 0x04006C94 RID: 27796
		public string TidTalk;

		// Token: 0x04006C95 RID: 27797
		public float? WaitTime;

		// Token: 0x04006C96 RID: 27798
		public ICaptionParam CaptionParams;

		// Token: 0x04006C97 RID: 27799
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006C98 RID: 27800
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006C99 RID: 27801
		public PlayMontage Montage;

		// Token: 0x04006C9A RID: 27802
		public ICameraData CameraData;

		// Token: 0x04006C9B RID: 27803
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006C9C RID: 27804
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006C9D RID: 27805
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006C9E RID: 27806
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006C9F RID: 27807
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006CA0 RID: 27808
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006CA1 RID: 27809
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006CA2 RID: 27810
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006CA3 RID: 27811
		public IUniversalTone UniversalTone;

		// Token: 0x04006CA4 RID: 27812
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006CA5 RID: 27813
		public bool? PlayVoice;

		// Token: 0x04006CA6 RID: 27814
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006CA7 RID: 27815
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006CA8 RID: 27816
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006CA9 RID: 27817
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006CAA RID: 27818
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006CAB RID: 27819
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
