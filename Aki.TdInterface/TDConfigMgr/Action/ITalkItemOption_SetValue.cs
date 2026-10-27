using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F47 RID: 8007
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemOption_SetValue
	{
		// Token: 0x0400685B RID: 26715
		public ETalkItemType? Type;

		// Token: 0x0400685C RID: 26716
		public int Id;

		// Token: 0x0400685D RID: 26717
		public int? PlotLineId;

		// Token: 0x0400685E RID: 26718
		public string PlotLineKey;

		// Token: 0x0400685F RID: 26719
		[Nullable(1)]
		public string Name;

		// Token: 0x04006860 RID: 26720
		public bool? _folded;

		// Token: 0x04006861 RID: 26721
		public EEditFlag? _editFlag;

		// Token: 0x04006862 RID: 26722
		public int? WhoId;

		// Token: 0x04006863 RID: 26723
		public int? TextId;

		// Token: 0x04006864 RID: 26724
		public string TidTalk;

		// Token: 0x04006865 RID: 26725
		public float? WaitTime;

		// Token: 0x04006866 RID: 26726
		public ICaptionParam CaptionParams;

		// Token: 0x04006867 RID: 26727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006868 RID: 26728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006869 RID: 26729
		public PlayMontage Montage;

		// Token: 0x0400686A RID: 26730
		public ICameraData CameraData;

		// Token: 0x0400686B RID: 26731
		public SetFlowTemplate FlowTemplate;

		// Token: 0x0400686C RID: 26732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x0400686D RID: 26733
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x0400686E RID: 26734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x0400686F RID: 26735
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006870 RID: 26736
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006871 RID: 26737
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006872 RID: 26738
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006873 RID: 26739
		public IUniversalTone UniversalTone;

		// Token: 0x04006874 RID: 26740
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006875 RID: 26741
		public bool? PlayVoice;

		// Token: 0x04006876 RID: 26742
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006877 RID: 26743
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006878 RID: 26744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006879 RID: 26745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400687A RID: 26746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x0400687B RID: 26747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x0400687C RID: 26748
		public IShowTalkCameraMotion CameraMotion;

		// Token: 0x0400687D RID: 26749
		public ITalkItemAutoPlayConfig AutoPlayConfig;
	}
}
