using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200216C RID: 8556
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgEnter_SetValue
	{
		// Token: 0x04006BFA RID: 27642
		public ETalkItemType? Type;

		// Token: 0x04006BFB RID: 27643
		public int Id;

		// Token: 0x04006BFC RID: 27644
		public int? PlotLineId;

		// Token: 0x04006BFD RID: 27645
		public string PlotLineKey;

		// Token: 0x04006BFE RID: 27646
		[Nullable(0)]
		public string Name;

		// Token: 0x04006BFF RID: 27647
		public bool? _folded;

		// Token: 0x04006C00 RID: 27648
		public EEditFlag? _editFlag;

		// Token: 0x04006C01 RID: 27649
		public int? WhoId;

		// Token: 0x04006C02 RID: 27650
		public int? TextId;

		// Token: 0x04006C03 RID: 27651
		public string TidTalk;

		// Token: 0x04006C04 RID: 27652
		public float? WaitTime;

		// Token: 0x04006C05 RID: 27653
		public ICaptionParam CaptionParams;

		// Token: 0x04006C06 RID: 27654
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006C07 RID: 27655
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006C08 RID: 27656
		public PlayMontage Montage;

		// Token: 0x04006C09 RID: 27657
		public ICameraData CameraData;

		// Token: 0x04006C0A RID: 27658
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006C0B RID: 27659
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006C0C RID: 27660
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006C0D RID: 27661
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006C0E RID: 27662
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006C0F RID: 27663
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006C10 RID: 27664
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006C11 RID: 27665
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006C12 RID: 27666
		public IUniversalTone UniversalTone;

		// Token: 0x04006C13 RID: 27667
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006C14 RID: 27668
		public bool? PlayVoice;

		// Token: 0x04006C15 RID: 27669
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006C16 RID: 27670
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006C17 RID: 27671
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006C18 RID: 27672
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006C19 RID: 27673
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006C1A RID: 27674
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006C1B RID: 27675
		[Nullable(0)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;

		// Token: 0x04006C1C RID: 27676
		public EAvgRolePosition PositionConfig;
	}
}
