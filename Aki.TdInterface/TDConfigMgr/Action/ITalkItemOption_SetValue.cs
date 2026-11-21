using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002180 RID: 8576
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemOption_SetValue
	{
		// Token: 0x04006E4A RID: 28234
		public ETalkItemType? Type;

		// Token: 0x04006E4B RID: 28235
		public int Id;

		// Token: 0x04006E4C RID: 28236
		public int? PlotLineId;

		// Token: 0x04006E4D RID: 28237
		public string PlotLineKey;

		// Token: 0x04006E4E RID: 28238
		[Nullable(0)]
		public string Name;

		// Token: 0x04006E4F RID: 28239
		public bool? _folded;

		// Token: 0x04006E50 RID: 28240
		public EEditFlag? _editFlag;

		// Token: 0x04006E51 RID: 28241
		public int? WhoId;

		// Token: 0x04006E52 RID: 28242
		public int? TextId;

		// Token: 0x04006E53 RID: 28243
		public string TidTalk;

		// Token: 0x04006E54 RID: 28244
		public float? WaitTime;

		// Token: 0x04006E55 RID: 28245
		public ICaptionParam CaptionParams;

		// Token: 0x04006E56 RID: 28246
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006E57 RID: 28247
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006E58 RID: 28248
		public PlayMontage Montage;

		// Token: 0x04006E59 RID: 28249
		public ICameraData CameraData;

		// Token: 0x04006E5A RID: 28250
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006E5B RID: 28251
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006E5C RID: 28252
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006E5D RID: 28253
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006E5E RID: 28254
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006E5F RID: 28255
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006E60 RID: 28256
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006E61 RID: 28257
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006E62 RID: 28258
		public IUniversalTone UniversalTone;

		// Token: 0x04006E63 RID: 28259
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006E64 RID: 28260
		public bool? PlayVoice;

		// Token: 0x04006E65 RID: 28261
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006E66 RID: 28262
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006E67 RID: 28263
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006E68 RID: 28264
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006E69 RID: 28265
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006E6A RID: 28266
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006E6B RID: 28267
		public IShowTalkCameraMotion CameraMotion;

		// Token: 0x04006E6C RID: 28268
		public ITalkItemAutoPlayConfig AutoPlayConfig;
	}
}
