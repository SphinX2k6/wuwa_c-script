using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216E RID: 8558
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgExit_SetValue
	{
		// Token: 0x04006C44 RID: 27716
		public ETalkItemType? Type;

		// Token: 0x04006C45 RID: 27717
		public int Id;

		// Token: 0x04006C46 RID: 27718
		public int? PlotLineId;

		// Token: 0x04006C47 RID: 27719
		public string PlotLineKey;

		// Token: 0x04006C48 RID: 27720
		[Nullable(0)]
		public string Name;

		// Token: 0x04006C49 RID: 27721
		public bool? _folded;

		// Token: 0x04006C4A RID: 27722
		public EEditFlag? _editFlag;

		// Token: 0x04006C4B RID: 27723
		public int? WhoId;

		// Token: 0x04006C4C RID: 27724
		public int? TextId;

		// Token: 0x04006C4D RID: 27725
		public string TidTalk;

		// Token: 0x04006C4E RID: 27726
		public float? WaitTime;

		// Token: 0x04006C4F RID: 27727
		public ICaptionParam CaptionParams;

		// Token: 0x04006C50 RID: 27728
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006C51 RID: 27729
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006C52 RID: 27730
		public PlayMontage Montage;

		// Token: 0x04006C53 RID: 27731
		public ICameraData CameraData;

		// Token: 0x04006C54 RID: 27732
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006C55 RID: 27733
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006C56 RID: 27734
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006C57 RID: 27735
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006C58 RID: 27736
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006C59 RID: 27737
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006C5A RID: 27738
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006C5B RID: 27739
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006C5C RID: 27740
		public IUniversalTone UniversalTone;

		// Token: 0x04006C5D RID: 27741
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006C5E RID: 27742
		public bool? PlayVoice;

		// Token: 0x04006C5F RID: 27743
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006C60 RID: 27744
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006C61 RID: 27745
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006C62 RID: 27746
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006C63 RID: 27747
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006C64 RID: 27748
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006C65 RID: 27749
		[Nullable(0)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;
	}
}
