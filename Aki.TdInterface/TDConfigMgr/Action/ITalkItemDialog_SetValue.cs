using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F41 RID: 8001
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDialog_SetValue
	{
		// Token: 0x040067C3 RID: 26563
		public ETalkItemType? Type;

		// Token: 0x040067C4 RID: 26564
		public int Id;

		// Token: 0x040067C5 RID: 26565
		public int? PlotLineId;

		// Token: 0x040067C6 RID: 26566
		public string PlotLineKey;

		// Token: 0x040067C7 RID: 26567
		[Nullable(1)]
		public string Name;

		// Token: 0x040067C8 RID: 26568
		public bool? _folded;

		// Token: 0x040067C9 RID: 26569
		public EEditFlag? _editFlag;

		// Token: 0x040067CA RID: 26570
		public int? WhoId;

		// Token: 0x040067CB RID: 26571
		public int? TextId;

		// Token: 0x040067CC RID: 26572
		public string TidTalk;

		// Token: 0x040067CD RID: 26573
		public float? WaitTime;

		// Token: 0x040067CE RID: 26574
		public ICaptionParam CaptionParams;

		// Token: 0x040067CF RID: 26575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040067D0 RID: 26576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040067D1 RID: 26577
		public PlayMontage Montage;

		// Token: 0x040067D2 RID: 26578
		public ICameraData CameraData;

		// Token: 0x040067D3 RID: 26579
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040067D4 RID: 26580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040067D5 RID: 26581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040067D6 RID: 26582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040067D7 RID: 26583
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040067D8 RID: 26584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040067D9 RID: 26585
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040067DA RID: 26586
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040067DB RID: 26587
		public IUniversalTone UniversalTone;

		// Token: 0x040067DC RID: 26588
		public ITalkBackground BackgroundConfig;

		// Token: 0x040067DD RID: 26589
		public bool? PlayVoice;

		// Token: 0x040067DE RID: 26590
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040067DF RID: 26591
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040067E0 RID: 26592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040067E1 RID: 26593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040067E2 RID: 26594
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040067E3 RID: 26595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x040067E4 RID: 26596
		public ITalkItemStyle Style;

		// Token: 0x040067E5 RID: 26597
		public IShowTalkCameraMotion CameraMotion;

		// Token: 0x040067E6 RID: 26598
		public ITalkItemAutoPlayConfig AutoPlayConfig;

		// Token: 0x040067E7 RID: 26599
		public bool? NoMouthAnim;

		// Token: 0x040067E8 RID: 26600
		public float? OtherIsTypingDuration;
	}
}
