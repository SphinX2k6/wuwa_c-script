using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F39 RID: 7993
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgOption_SetValue
	{
		// Token: 0x040066E2 RID: 26338
		public ETalkItemType? Type;

		// Token: 0x040066E3 RID: 26339
		public int Id;

		// Token: 0x040066E4 RID: 26340
		public int? PlotLineId;

		// Token: 0x040066E5 RID: 26341
		public string PlotLineKey;

		// Token: 0x040066E6 RID: 26342
		[Nullable(1)]
		public string Name;

		// Token: 0x040066E7 RID: 26343
		public bool? _folded;

		// Token: 0x040066E8 RID: 26344
		public EEditFlag? _editFlag;

		// Token: 0x040066E9 RID: 26345
		public int? WhoId;

		// Token: 0x040066EA RID: 26346
		public int? TextId;

		// Token: 0x040066EB RID: 26347
		public string TidTalk;

		// Token: 0x040066EC RID: 26348
		public float? WaitTime;

		// Token: 0x040066ED RID: 26349
		public ICaptionParam CaptionParams;

		// Token: 0x040066EE RID: 26350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040066EF RID: 26351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x040066F0 RID: 26352
		public PlayMontage Montage;

		// Token: 0x040066F1 RID: 26353
		public ICameraData CameraData;

		// Token: 0x040066F2 RID: 26354
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040066F3 RID: 26355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040066F4 RID: 26356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040066F5 RID: 26357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040066F6 RID: 26358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040066F7 RID: 26359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040066F8 RID: 26360
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040066F9 RID: 26361
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040066FA RID: 26362
		public IUniversalTone UniversalTone;

		// Token: 0x040066FB RID: 26363
		public ITalkBackground BackgroundConfig;

		// Token: 0x040066FC RID: 26364
		public bool? PlayVoice;

		// Token: 0x040066FD RID: 26365
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040066FE RID: 26366
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040066FF RID: 26367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006700 RID: 26368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006701 RID: 26369
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006702 RID: 26370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
