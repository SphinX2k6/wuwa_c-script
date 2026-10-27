using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F33 RID: 7987
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgEnter_SetValue
	{
		// Token: 0x0400660B RID: 26123
		public ETalkItemType? Type;

		// Token: 0x0400660C RID: 26124
		public int Id;

		// Token: 0x0400660D RID: 26125
		public int? PlotLineId;

		// Token: 0x0400660E RID: 26126
		public string PlotLineKey;

		// Token: 0x0400660F RID: 26127
		[Nullable(1)]
		public string Name;

		// Token: 0x04006610 RID: 26128
		public bool? _folded;

		// Token: 0x04006611 RID: 26129
		public EEditFlag? _editFlag;

		// Token: 0x04006612 RID: 26130
		public int? WhoId;

		// Token: 0x04006613 RID: 26131
		public int? TextId;

		// Token: 0x04006614 RID: 26132
		public string TidTalk;

		// Token: 0x04006615 RID: 26133
		public float? WaitTime;

		// Token: 0x04006616 RID: 26134
		public ICaptionParam CaptionParams;

		// Token: 0x04006617 RID: 26135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006618 RID: 26136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006619 RID: 26137
		public PlayMontage Montage;

		// Token: 0x0400661A RID: 26138
		public ICameraData CameraData;

		// Token: 0x0400661B RID: 26139
		public SetFlowTemplate FlowTemplate;

		// Token: 0x0400661C RID: 26140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x0400661D RID: 26141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x0400661E RID: 26142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x0400661F RID: 26143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006620 RID: 26144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006621 RID: 26145
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006622 RID: 26146
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006623 RID: 26147
		public IUniversalTone UniversalTone;

		// Token: 0x04006624 RID: 26148
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006625 RID: 26149
		public bool? PlayVoice;

		// Token: 0x04006626 RID: 26150
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006627 RID: 26151
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006628 RID: 26152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006629 RID: 26153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400662A RID: 26154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x0400662B RID: 26155
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x0400662C RID: 26156
		[Nullable(1)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;

		// Token: 0x0400662D RID: 26157
		public EAvgRolePosition PositionConfig;
	}
}
