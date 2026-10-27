using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F49 RID: 8009
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage_SetValue
	{
		// Token: 0x040068A3 RID: 26787
		public ETalkItemType? Type;

		// Token: 0x040068A4 RID: 26788
		public int Id;

		// Token: 0x040068A5 RID: 26789
		public int? PlotLineId;

		// Token: 0x040068A6 RID: 26790
		public string PlotLineKey;

		// Token: 0x040068A7 RID: 26791
		[Nullable(1)]
		public string Name;

		// Token: 0x040068A8 RID: 26792
		public bool? _folded;

		// Token: 0x040068A9 RID: 26793
		public EEditFlag? _editFlag;

		// Token: 0x040068AA RID: 26794
		public int? WhoId;

		// Token: 0x040068AB RID: 26795
		public int? TextId;

		// Token: 0x040068AC RID: 26796
		public string TidTalk;

		// Token: 0x040068AD RID: 26797
		public float? WaitTime;

		// Token: 0x040068AE RID: 26798
		public ICaptionParam CaptionParams;

		// Token: 0x040068AF RID: 26799
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040068B0 RID: 26800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040068B1 RID: 26801
		public PlayMontage Montage;

		// Token: 0x040068B2 RID: 26802
		public ICameraData CameraData;

		// Token: 0x040068B3 RID: 26803
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040068B4 RID: 26804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040068B5 RID: 26805
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040068B6 RID: 26806
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040068B7 RID: 26807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040068B8 RID: 26808
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040068B9 RID: 26809
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040068BA RID: 26810
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040068BB RID: 26811
		public IUniversalTone UniversalTone;

		// Token: 0x040068BC RID: 26812
		public ITalkBackground BackgroundConfig;

		// Token: 0x040068BD RID: 26813
		public bool? PlayVoice;

		// Token: 0x040068BE RID: 26814
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040068BF RID: 26815
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040068C0 RID: 26816
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040068C1 RID: 26817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040068C2 RID: 26818
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040068C3 RID: 26819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x040068C4 RID: 26820
		[Nullable(1)]
		public ITalkItemPhoneMessageBase MessageType;

		// Token: 0x040068C5 RID: 26821
		public ITalkItemStyle Style;

		// Token: 0x040068C6 RID: 26822
		public float? OtherIsTypingDuration;
	}
}
