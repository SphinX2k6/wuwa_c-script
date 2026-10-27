using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F67 RID: 8039
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk_SetValue
	{
		// Token: 0x04006AD9 RID: 27353
		public ETalkItemType? Type;

		// Token: 0x04006ADA RID: 27354
		public int Id;

		// Token: 0x04006ADB RID: 27355
		public int? PlotLineId;

		// Token: 0x04006ADC RID: 27356
		public string PlotLineKey;

		// Token: 0x04006ADD RID: 27357
		[Nullable(1)]
		public string Name;

		// Token: 0x04006ADE RID: 27358
		public bool? _folded;

		// Token: 0x04006ADF RID: 27359
		public EEditFlag? _editFlag;

		// Token: 0x04006AE0 RID: 27360
		public int? WhoId;

		// Token: 0x04006AE1 RID: 27361
		public int? TextId;

		// Token: 0x04006AE2 RID: 27362
		public string TidTalk;

		// Token: 0x04006AE3 RID: 27363
		public float? WaitTime;

		// Token: 0x04006AE4 RID: 27364
		public ICaptionParam CaptionParams;

		// Token: 0x04006AE5 RID: 27365
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006AE6 RID: 27366
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006AE7 RID: 27367
		public PlayMontage Montage;

		// Token: 0x04006AE8 RID: 27368
		public ICameraData CameraData;

		// Token: 0x04006AE9 RID: 27369
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006AEA RID: 27370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006AEB RID: 27371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006AEC RID: 27372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006AED RID: 27373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006AEE RID: 27374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006AEF RID: 27375
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006AF0 RID: 27376
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006AF1 RID: 27377
		public IUniversalTone UniversalTone;

		// Token: 0x04006AF2 RID: 27378
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006AF3 RID: 27379
		public bool? PlayVoice;

		// Token: 0x04006AF4 RID: 27380
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006AF5 RID: 27381
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006AF6 RID: 27382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006AF7 RID: 27383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006AF8 RID: 27384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006AF9 RID: 27385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006AFA RID: 27386
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x04006AFB RID: 27387
		public IVisualNovelOptionGroupSolarSchoolExam OptionGroup;

		// Token: 0x04006AFC RID: 27388
		public float? DialogDelay;

		// Token: 0x04006AFD RID: 27389
		public bool? ClickShowFull;

		// Token: 0x04006AFE RID: 27390
		public string Interjection;

		// Token: 0x04006AFF RID: 27391
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x04006B00 RID: 27392
		public IVisualNovelRoleConfig RoleConfig;

		// Token: 0x04006B01 RID: 27393
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x04006B02 RID: 27394
		public IVisualNovelCgBase CgConfig;

		// Token: 0x04006B03 RID: 27395
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x04006B04 RID: 27396
		public int? PlotKeyId;

		// Token: 0x04006B05 RID: 27397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x04006B06 RID: 27398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
