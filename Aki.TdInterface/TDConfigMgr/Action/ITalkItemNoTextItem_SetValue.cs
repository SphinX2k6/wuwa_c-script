using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F45 RID: 8005
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemNoTextItem_SetValue
	{
		// Token: 0x04006812 RID: 26642
		public ETalkItemType? Type;

		// Token: 0x04006813 RID: 26643
		public int Id;

		// Token: 0x04006814 RID: 26644
		public int? PlotLineId;

		// Token: 0x04006815 RID: 26645
		public string PlotLineKey;

		// Token: 0x04006816 RID: 26646
		[Nullable(1)]
		public string Name;

		// Token: 0x04006817 RID: 26647
		public bool? _folded;

		// Token: 0x04006818 RID: 26648
		public EEditFlag? _editFlag;

		// Token: 0x04006819 RID: 26649
		public int? WhoId;

		// Token: 0x0400681A RID: 26650
		public int? TextId;

		// Token: 0x0400681B RID: 26651
		public string TidTalk;

		// Token: 0x0400681C RID: 26652
		public float? WaitTime;

		// Token: 0x0400681D RID: 26653
		public ICaptionParam CaptionParams;

		// Token: 0x0400681E RID: 26654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400681F RID: 26655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006820 RID: 26656
		public PlayMontage Montage;

		// Token: 0x04006821 RID: 26657
		public ICameraData CameraData;

		// Token: 0x04006822 RID: 26658
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006823 RID: 26659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006824 RID: 26660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006825 RID: 26661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006826 RID: 26662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006827 RID: 26663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006828 RID: 26664
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006829 RID: 26665
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x0400682A RID: 26666
		public IUniversalTone UniversalTone;

		// Token: 0x0400682B RID: 26667
		public ITalkBackground BackgroundConfig;

		// Token: 0x0400682C RID: 26668
		public bool? PlayVoice;

		// Token: 0x0400682D RID: 26669
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400682E RID: 26670
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400682F RID: 26671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006830 RID: 26672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006831 RID: 26673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006832 RID: 26674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006833 RID: 26675
		public IShowTalkCameraMotion CameraMotion;
	}
}
