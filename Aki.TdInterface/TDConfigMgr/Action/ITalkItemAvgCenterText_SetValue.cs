using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F31 RID: 7985
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgCenterText_SetValue
	{
		// Token: 0x040065C3 RID: 26051
		public ETalkItemType? Type;

		// Token: 0x040065C4 RID: 26052
		public int Id;

		// Token: 0x040065C5 RID: 26053
		public int? PlotLineId;

		// Token: 0x040065C6 RID: 26054
		public string PlotLineKey;

		// Token: 0x040065C7 RID: 26055
		[Nullable(1)]
		public string Name;

		// Token: 0x040065C8 RID: 26056
		public bool? _folded;

		// Token: 0x040065C9 RID: 26057
		public EEditFlag? _editFlag;

		// Token: 0x040065CA RID: 26058
		public int? WhoId;

		// Token: 0x040065CB RID: 26059
		public int? TextId;

		// Token: 0x040065CC RID: 26060
		public string TidTalk;

		// Token: 0x040065CD RID: 26061
		public float? WaitTime;

		// Token: 0x040065CE RID: 26062
		public ICaptionParam CaptionParams;

		// Token: 0x040065CF RID: 26063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040065D0 RID: 26064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040065D1 RID: 26065
		public PlayMontage Montage;

		// Token: 0x040065D2 RID: 26066
		public ICameraData CameraData;

		// Token: 0x040065D3 RID: 26067
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040065D4 RID: 26068
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040065D5 RID: 26069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040065D6 RID: 26070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040065D7 RID: 26071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040065D8 RID: 26072
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040065D9 RID: 26073
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040065DA RID: 26074
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040065DB RID: 26075
		public IUniversalTone UniversalTone;

		// Token: 0x040065DC RID: 26076
		public ITalkBackground BackgroundConfig;

		// Token: 0x040065DD RID: 26077
		public bool? PlayVoice;

		// Token: 0x040065DE RID: 26078
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040065DF RID: 26079
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040065E0 RID: 26080
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040065E1 RID: 26081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040065E2 RID: 26082
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040065E3 RID: 26083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
