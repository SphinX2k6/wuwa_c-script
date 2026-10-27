using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F55 RID: 8021
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemQte_SetValue
	{
		// Token: 0x040068FF RID: 26879
		public ETalkItemType? Type;

		// Token: 0x04006900 RID: 26880
		public int Id;

		// Token: 0x04006901 RID: 26881
		public int? PlotLineId;

		// Token: 0x04006902 RID: 26882
		public string PlotLineKey;

		// Token: 0x04006903 RID: 26883
		[Nullable(1)]
		public string Name;

		// Token: 0x04006904 RID: 26884
		public bool? _folded;

		// Token: 0x04006905 RID: 26885
		public EEditFlag? _editFlag;

		// Token: 0x04006906 RID: 26886
		public int? WhoId;

		// Token: 0x04006907 RID: 26887
		public int? TextId;

		// Token: 0x04006908 RID: 26888
		public string TidTalk;

		// Token: 0x04006909 RID: 26889
		public float? WaitTime;

		// Token: 0x0400690A RID: 26890
		public ICaptionParam CaptionParams;

		// Token: 0x0400690B RID: 26891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400690C RID: 26892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x0400690D RID: 26893
		public PlayMontage Montage;

		// Token: 0x0400690E RID: 26894
		public ICameraData CameraData;

		// Token: 0x0400690F RID: 26895
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006910 RID: 26896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006911 RID: 26897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006912 RID: 26898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006913 RID: 26899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006914 RID: 26900
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006915 RID: 26901
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006916 RID: 26902
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006917 RID: 26903
		public IUniversalTone UniversalTone;

		// Token: 0x04006918 RID: 26904
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006919 RID: 26905
		public bool? PlayVoice;

		// Token: 0x0400691A RID: 26906
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400691B RID: 26907
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400691C RID: 26908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x0400691D RID: 26909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400691E RID: 26910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x0400691F RID: 26911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006920 RID: 26912
		public int QteId;
	}
}
