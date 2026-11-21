using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002178 RID: 8568
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemCenterText_SetValue
	{
		// Token: 0x04006D68 RID: 28008
		public ETalkItemType? Type;

		// Token: 0x04006D69 RID: 28009
		public int Id;

		// Token: 0x04006D6A RID: 28010
		public int? PlotLineId;

		// Token: 0x04006D6B RID: 28011
		public string PlotLineKey;

		// Token: 0x04006D6C RID: 28012
		[Nullable(0)]
		public string Name;

		// Token: 0x04006D6D RID: 28013
		public bool? _folded;

		// Token: 0x04006D6E RID: 28014
		public EEditFlag? _editFlag;

		// Token: 0x04006D6F RID: 28015
		public int? WhoId;

		// Token: 0x04006D70 RID: 28016
		public int? TextId;

		// Token: 0x04006D71 RID: 28017
		public string TidTalk;

		// Token: 0x04006D72 RID: 28018
		public float? WaitTime;

		// Token: 0x04006D73 RID: 28019
		public ICaptionParam CaptionParams;

		// Token: 0x04006D74 RID: 28020
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006D75 RID: 28021
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006D76 RID: 28022
		public PlayMontage Montage;

		// Token: 0x04006D77 RID: 28023
		public ICameraData CameraData;

		// Token: 0x04006D78 RID: 28024
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006D79 RID: 28025
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006D7A RID: 28026
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006D7B RID: 28027
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006D7C RID: 28028
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006D7D RID: 28029
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006D7E RID: 28030
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006D7F RID: 28031
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006D80 RID: 28032
		public IUniversalTone UniversalTone;

		// Token: 0x04006D81 RID: 28033
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006D82 RID: 28034
		public bool? PlayVoice;

		// Token: 0x04006D83 RID: 28035
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006D84 RID: 28036
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006D85 RID: 28037
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006D86 RID: 28038
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006D87 RID: 28039
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006D88 RID: 28040
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006D89 RID: 28041
		public IShowCenterTextParams CenterTextConfig;

		// Token: 0x04006D8A RID: 28042
		public bool? _IsPlotActionForPreview;
	}
}
