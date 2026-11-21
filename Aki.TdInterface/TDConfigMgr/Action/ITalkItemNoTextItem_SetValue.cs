using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217E RID: 8574
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemNoTextItem_SetValue
	{
		// Token: 0x04006E01 RID: 28161
		public ETalkItemType? Type;

		// Token: 0x04006E02 RID: 28162
		public int Id;

		// Token: 0x04006E03 RID: 28163
		public int? PlotLineId;

		// Token: 0x04006E04 RID: 28164
		public string PlotLineKey;

		// Token: 0x04006E05 RID: 28165
		[Nullable(0)]
		public string Name;

		// Token: 0x04006E06 RID: 28166
		public bool? _folded;

		// Token: 0x04006E07 RID: 28167
		public EEditFlag? _editFlag;

		// Token: 0x04006E08 RID: 28168
		public int? WhoId;

		// Token: 0x04006E09 RID: 28169
		public int? TextId;

		// Token: 0x04006E0A RID: 28170
		public string TidTalk;

		// Token: 0x04006E0B RID: 28171
		public float? WaitTime;

		// Token: 0x04006E0C RID: 28172
		public ICaptionParam CaptionParams;

		// Token: 0x04006E0D RID: 28173
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006E0E RID: 28174
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006E0F RID: 28175
		public PlayMontage Montage;

		// Token: 0x04006E10 RID: 28176
		public ICameraData CameraData;

		// Token: 0x04006E11 RID: 28177
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006E12 RID: 28178
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006E13 RID: 28179
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006E14 RID: 28180
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006E15 RID: 28181
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006E16 RID: 28182
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006E17 RID: 28183
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006E18 RID: 28184
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006E19 RID: 28185
		public IUniversalTone UniversalTone;

		// Token: 0x04006E1A RID: 28186
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006E1B RID: 28187
		public bool? PlayVoice;

		// Token: 0x04006E1C RID: 28188
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006E1D RID: 28189
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006E1E RID: 28190
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006E1F RID: 28191
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006E20 RID: 28192
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006E21 RID: 28193
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006E22 RID: 28194
		public IShowTalkCameraMotion CameraMotion;
	}
}
