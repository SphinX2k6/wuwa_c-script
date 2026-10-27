using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F35 RID: 7989
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgExit_SetValue
	{
		// Token: 0x04006655 RID: 26197
		public ETalkItemType? Type;

		// Token: 0x04006656 RID: 26198
		public int Id;

		// Token: 0x04006657 RID: 26199
		public int? PlotLineId;

		// Token: 0x04006658 RID: 26200
		public string PlotLineKey;

		// Token: 0x04006659 RID: 26201
		[Nullable(1)]
		public string Name;

		// Token: 0x0400665A RID: 26202
		public bool? _folded;

		// Token: 0x0400665B RID: 26203
		public EEditFlag? _editFlag;

		// Token: 0x0400665C RID: 26204
		public int? WhoId;

		// Token: 0x0400665D RID: 26205
		public int? TextId;

		// Token: 0x0400665E RID: 26206
		public string TidTalk;

		// Token: 0x0400665F RID: 26207
		public float? WaitTime;

		// Token: 0x04006660 RID: 26208
		public ICaptionParam CaptionParams;

		// Token: 0x04006661 RID: 26209
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006662 RID: 26210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006663 RID: 26211
		public PlayMontage Montage;

		// Token: 0x04006664 RID: 26212
		public ICameraData CameraData;

		// Token: 0x04006665 RID: 26213
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006666 RID: 26214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006667 RID: 26215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006668 RID: 26216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006669 RID: 26217
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x0400666A RID: 26218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x0400666B RID: 26219
		public IPostAkEventType TalkAkEvent;

		// Token: 0x0400666C RID: 26220
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x0400666D RID: 26221
		public IUniversalTone UniversalTone;

		// Token: 0x0400666E RID: 26222
		public ITalkBackground BackgroundConfig;

		// Token: 0x0400666F RID: 26223
		public bool? PlayVoice;

		// Token: 0x04006670 RID: 26224
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006671 RID: 26225
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006672 RID: 26226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006673 RID: 26227
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006674 RID: 26228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006675 RID: 26229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006676 RID: 26230
		[Nullable(1)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;
	}
}
