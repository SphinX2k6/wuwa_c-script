using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002172 RID: 8562
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgOption_SetValue
	{
		// Token: 0x04006CD1 RID: 27857
		public ETalkItemType? Type;

		// Token: 0x04006CD2 RID: 27858
		public int Id;

		// Token: 0x04006CD3 RID: 27859
		public int? PlotLineId;

		// Token: 0x04006CD4 RID: 27860
		public string PlotLineKey;

		// Token: 0x04006CD5 RID: 27861
		[Nullable(0)]
		public string Name;

		// Token: 0x04006CD6 RID: 27862
		public bool? _folded;

		// Token: 0x04006CD7 RID: 27863
		public EEditFlag? _editFlag;

		// Token: 0x04006CD8 RID: 27864
		public int? WhoId;

		// Token: 0x04006CD9 RID: 27865
		public int? TextId;

		// Token: 0x04006CDA RID: 27866
		public string TidTalk;

		// Token: 0x04006CDB RID: 27867
		public float? WaitTime;

		// Token: 0x04006CDC RID: 27868
		public ICaptionParam CaptionParams;

		// Token: 0x04006CDD RID: 27869
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006CDE RID: 27870
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006CDF RID: 27871
		public PlayMontage Montage;

		// Token: 0x04006CE0 RID: 27872
		public ICameraData CameraData;

		// Token: 0x04006CE1 RID: 27873
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006CE2 RID: 27874
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006CE3 RID: 27875
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006CE4 RID: 27876
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006CE5 RID: 27877
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006CE6 RID: 27878
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006CE7 RID: 27879
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006CE8 RID: 27880
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006CE9 RID: 27881
		public IUniversalTone UniversalTone;

		// Token: 0x04006CEA RID: 27882
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006CEB RID: 27883
		public bool? PlayVoice;

		// Token: 0x04006CEC RID: 27884
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006CED RID: 27885
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006CEE RID: 27886
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006CEF RID: 27887
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006CF0 RID: 27888
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006CF1 RID: 27889
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
