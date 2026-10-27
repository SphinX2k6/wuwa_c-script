using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F5D RID: 8029
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemSystemOption_SetValue
	{
		// Token: 0x0400694F RID: 26959
		public ETalkItemType? Type;

		// Token: 0x04006950 RID: 26960
		public int Id;

		// Token: 0x04006951 RID: 26961
		public int? PlotLineId;

		// Token: 0x04006952 RID: 26962
		public string PlotLineKey;

		// Token: 0x04006953 RID: 26963
		[Nullable(1)]
		public string Name;

		// Token: 0x04006954 RID: 26964
		public bool? _folded;

		// Token: 0x04006955 RID: 26965
		public EEditFlag? _editFlag;

		// Token: 0x04006956 RID: 26966
		public int? WhoId;

		// Token: 0x04006957 RID: 26967
		public int? TextId;

		// Token: 0x04006958 RID: 26968
		public string TidTalk;

		// Token: 0x04006959 RID: 26969
		public float? WaitTime;

		// Token: 0x0400695A RID: 26970
		public ICaptionParam CaptionParams;

		// Token: 0x0400695B RID: 26971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x0400695C RID: 26972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x0400695D RID: 26973
		public PlayMontage Montage;

		// Token: 0x0400695E RID: 26974
		public ICameraData CameraData;

		// Token: 0x0400695F RID: 26975
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006960 RID: 26976
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006961 RID: 26977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006962 RID: 26978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006963 RID: 26979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006964 RID: 26980
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006965 RID: 26981
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006966 RID: 26982
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006967 RID: 26983
		public IUniversalTone UniversalTone;

		// Token: 0x04006968 RID: 26984
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006969 RID: 26985
		public bool? PlayVoice;

		// Token: 0x0400696A RID: 26986
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x0400696B RID: 26987
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x0400696C RID: 26988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x0400696D RID: 26989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x0400696E RID: 26990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x0400696F RID: 26991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006970 RID: 26992
		[Nullable(1)]
		public ISystemOptionType OptionConfig;
	}
}
