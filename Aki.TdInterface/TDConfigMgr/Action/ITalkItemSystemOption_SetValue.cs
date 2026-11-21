using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002198 RID: 8600
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemSystemOption_SetValue
	{
		// Token: 0x04006F42 RID: 28482
		public ETalkItemType? Type;

		// Token: 0x04006F43 RID: 28483
		public int Id;

		// Token: 0x04006F44 RID: 28484
		public int? PlotLineId;

		// Token: 0x04006F45 RID: 28485
		public string PlotLineKey;

		// Token: 0x04006F46 RID: 28486
		[Nullable(0)]
		public string Name;

		// Token: 0x04006F47 RID: 28487
		public bool? _folded;

		// Token: 0x04006F48 RID: 28488
		public EEditFlag? _editFlag;

		// Token: 0x04006F49 RID: 28489
		public int? WhoId;

		// Token: 0x04006F4A RID: 28490
		public int? TextId;

		// Token: 0x04006F4B RID: 28491
		public string TidTalk;

		// Token: 0x04006F4C RID: 28492
		public float? WaitTime;

		// Token: 0x04006F4D RID: 28493
		public ICaptionParam CaptionParams;

		// Token: 0x04006F4E RID: 28494
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006F4F RID: 28495
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006F50 RID: 28496
		public PlayMontage Montage;

		// Token: 0x04006F51 RID: 28497
		public ICameraData CameraData;

		// Token: 0x04006F52 RID: 28498
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006F53 RID: 28499
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006F54 RID: 28500
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006F55 RID: 28501
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006F56 RID: 28502
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006F57 RID: 28503
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006F58 RID: 28504
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006F59 RID: 28505
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006F5A RID: 28506
		public IUniversalTone UniversalTone;

		// Token: 0x04006F5B RID: 28507
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006F5C RID: 28508
		public bool? PlayVoice;

		// Token: 0x04006F5D RID: 28509
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006F5E RID: 28510
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006F5F RID: 28511
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006F60 RID: 28512
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006F61 RID: 28513
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006F62 RID: 28514
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006F63 RID: 28515
		[Nullable(0)]
		public ISystemOptionType OptionConfig;
	}
}
