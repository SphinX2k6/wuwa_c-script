using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A0 RID: 8608
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelOption_SetValue
	{
		// Token: 0x04007070 RID: 28784
		public ETalkItemType? Type;

		// Token: 0x04007071 RID: 28785
		public int Id;

		// Token: 0x04007072 RID: 28786
		public int? PlotLineId;

		// Token: 0x04007073 RID: 28787
		public string PlotLineKey;

		// Token: 0x04007074 RID: 28788
		[Nullable(0)]
		public string Name;

		// Token: 0x04007075 RID: 28789
		public bool? _folded;

		// Token: 0x04007076 RID: 28790
		public EEditFlag? _editFlag;

		// Token: 0x04007077 RID: 28791
		public int? WhoId;

		// Token: 0x04007078 RID: 28792
		public int? TextId;

		// Token: 0x04007079 RID: 28793
		public string TidTalk;

		// Token: 0x0400707A RID: 28794
		public float? WaitTime;

		// Token: 0x0400707B RID: 28795
		public ICaptionParam CaptionParams;

		// Token: 0x0400707C RID: 28796
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400707D RID: 28797
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x0400707E RID: 28798
		public PlayMontage Montage;

		// Token: 0x0400707F RID: 28799
		public ICameraData CameraData;

		// Token: 0x04007080 RID: 28800
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04007081 RID: 28801
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04007082 RID: 28802
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04007083 RID: 28803
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04007084 RID: 28804
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04007085 RID: 28805
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04007086 RID: 28806
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04007087 RID: 28807
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04007088 RID: 28808
		public IUniversalTone UniversalTone;

		// Token: 0x04007089 RID: 28809
		public ITalkBackground BackgroundConfig;

		// Token: 0x0400708A RID: 28810
		public bool? PlayVoice;

		// Token: 0x0400708B RID: 28811
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400708C RID: 28812
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400708D RID: 28813
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x0400708E RID: 28814
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400708F RID: 28815
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04007090 RID: 28816
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04007091 RID: 28817
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04007092 RID: 28818
		public IVisualNovelOptionGroupConfigBase OptionGroup;

		// Token: 0x04007093 RID: 28819
		public string TidCustomDescText;

		// Token: 0x04007094 RID: 28820
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04007095 RID: 28821
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04007096 RID: 28822
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04007097 RID: 28823
		public int? PlotKeyId;
	}
}
