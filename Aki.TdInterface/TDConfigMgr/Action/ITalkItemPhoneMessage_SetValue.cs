using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002182 RID: 8578
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemPhoneMessage_SetValue
	{
		// Token: 0x04006E92 RID: 28306
		public ETalkItemType? Type;

		// Token: 0x04006E93 RID: 28307
		public int Id;

		// Token: 0x04006E94 RID: 28308
		public int? PlotLineId;

		// Token: 0x04006E95 RID: 28309
		public string PlotLineKey;

		// Token: 0x04006E96 RID: 28310
		[Nullable(0)]
		public string Name;

		// Token: 0x04006E97 RID: 28311
		public bool? _folded;

		// Token: 0x04006E98 RID: 28312
		public EEditFlag? _editFlag;

		// Token: 0x04006E99 RID: 28313
		public int? WhoId;

		// Token: 0x04006E9A RID: 28314
		public int? TextId;

		// Token: 0x04006E9B RID: 28315
		public string TidTalk;

		// Token: 0x04006E9C RID: 28316
		public float? WaitTime;

		// Token: 0x04006E9D RID: 28317
		public ICaptionParam CaptionParams;

		// Token: 0x04006E9E RID: 28318
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006E9F RID: 28319
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006EA0 RID: 28320
		public PlayMontage Montage;

		// Token: 0x04006EA1 RID: 28321
		public ICameraData CameraData;

		// Token: 0x04006EA2 RID: 28322
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006EA3 RID: 28323
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006EA4 RID: 28324
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006EA5 RID: 28325
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006EA6 RID: 28326
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006EA7 RID: 28327
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006EA8 RID: 28328
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006EA9 RID: 28329
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006EAA RID: 28330
		public IUniversalTone UniversalTone;

		// Token: 0x04006EAB RID: 28331
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006EAC RID: 28332
		public bool? PlayVoice;

		// Token: 0x04006EAD RID: 28333
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006EAE RID: 28334
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006EAF RID: 28335
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006EB0 RID: 28336
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006EB1 RID: 28337
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006EB2 RID: 28338
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006EB3 RID: 28339
		[Nullable(0)]
		public ITalkItemPhoneMessageBase MessageType;

		// Token: 0x04006EB4 RID: 28340
		public ITalkItemStyle Style;

		// Token: 0x04006EB5 RID: 28341
		public float? OtherIsTypingDuration;
	}
}
