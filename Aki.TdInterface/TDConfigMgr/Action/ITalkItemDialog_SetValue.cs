using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217A RID: 8570
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog_SetValue
	{
		// Token: 0x04006DB2 RID: 28082
		public ETalkItemType? Type;

		// Token: 0x04006DB3 RID: 28083
		public int Id;

		// Token: 0x04006DB4 RID: 28084
		public int? PlotLineId;

		// Token: 0x04006DB5 RID: 28085
		public string PlotLineKey;

		// Token: 0x04006DB6 RID: 28086
		[Nullable(0)]
		public string Name;

		// Token: 0x04006DB7 RID: 28087
		public bool? _folded;

		// Token: 0x04006DB8 RID: 28088
		public EEditFlag? _editFlag;

		// Token: 0x04006DB9 RID: 28089
		public int? WhoId;

		// Token: 0x04006DBA RID: 28090
		public int? TextId;

		// Token: 0x04006DBB RID: 28091
		public string TidTalk;

		// Token: 0x04006DBC RID: 28092
		public float? WaitTime;

		// Token: 0x04006DBD RID: 28093
		public ICaptionParam CaptionParams;

		// Token: 0x04006DBE RID: 28094
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006DBF RID: 28095
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006DC0 RID: 28096
		public PlayMontage Montage;

		// Token: 0x04006DC1 RID: 28097
		public ICameraData CameraData;

		// Token: 0x04006DC2 RID: 28098
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006DC3 RID: 28099
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006DC4 RID: 28100
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006DC5 RID: 28101
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006DC6 RID: 28102
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006DC7 RID: 28103
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006DC8 RID: 28104
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006DC9 RID: 28105
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006DCA RID: 28106
		public IUniversalTone UniversalTone;

		// Token: 0x04006DCB RID: 28107
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006DCC RID: 28108
		public bool? PlayVoice;

		// Token: 0x04006DCD RID: 28109
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006DCE RID: 28110
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006DCF RID: 28111
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006DD0 RID: 28112
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006DD1 RID: 28113
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006DD2 RID: 28114
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006DD3 RID: 28115
		public ITalkItemStyle Style;

		// Token: 0x04006DD4 RID: 28116
		public IShowTalkCameraMotion CameraMotion;

		// Token: 0x04006DD5 RID: 28117
		public ITalkItemAutoPlayConfig AutoPlayConfig;

		// Token: 0x04006DD6 RID: 28118
		public bool? NoMouthAnim;

		// Token: 0x04006DD7 RID: 28119
		public float? OtherIsTypingDuration;
	}
}
