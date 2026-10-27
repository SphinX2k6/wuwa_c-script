using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5F RID: 8031
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelCenterText_SetValue
	{
		// Token: 0x04006998 RID: 27032
		public ETalkItemType? Type;

		// Token: 0x04006999 RID: 27033
		public int Id;

		// Token: 0x0400699A RID: 27034
		public int? PlotLineId;

		// Token: 0x0400699B RID: 27035
		public string PlotLineKey;

		// Token: 0x0400699C RID: 27036
		[Nullable(1)]
		public string Name;

		// Token: 0x0400699D RID: 27037
		public bool? _folded;

		// Token: 0x0400699E RID: 27038
		public EEditFlag? _editFlag;

		// Token: 0x0400699F RID: 27039
		public int? WhoId;

		// Token: 0x040069A0 RID: 27040
		public int? TextId;

		// Token: 0x040069A1 RID: 27041
		public string TidTalk;

		// Token: 0x040069A2 RID: 27042
		public float? WaitTime;

		// Token: 0x040069A3 RID: 27043
		public ICaptionParam CaptionParams;

		// Token: 0x040069A4 RID: 27044
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040069A5 RID: 27045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040069A6 RID: 27046
		public PlayMontage Montage;

		// Token: 0x040069A7 RID: 27047
		public ICameraData CameraData;

		// Token: 0x040069A8 RID: 27048
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040069A9 RID: 27049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040069AA RID: 27050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040069AB RID: 27051
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040069AC RID: 27052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040069AD RID: 27053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040069AE RID: 27054
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040069AF RID: 27055
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040069B0 RID: 27056
		public IUniversalTone UniversalTone;

		// Token: 0x040069B1 RID: 27057
		public ITalkBackground BackgroundConfig;

		// Token: 0x040069B2 RID: 27058
		public bool? PlayVoice;

		// Token: 0x040069B3 RID: 27059
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040069B4 RID: 27060
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040069B5 RID: 27061
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040069B6 RID: 27062
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040069B7 RID: 27063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040069B8 RID: 27064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x040069B9 RID: 27065
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x040069BA RID: 27066
		public IVisualNovelOptionGroupSolarSchoolExam OptionGroup;

		// Token: 0x040069BB RID: 27067
		public int? PlotKeyId;
	}
}
