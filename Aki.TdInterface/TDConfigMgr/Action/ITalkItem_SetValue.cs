using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2D RID: 7981
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItem_SetValue
	{
		// Token: 0x04006578 RID: 25976
		public ETalkItemType? Type;

		// Token: 0x04006579 RID: 25977
		public int Id;

		// Token: 0x0400657A RID: 25978
		public int? PlotLineId;

		// Token: 0x0400657B RID: 25979
		public string PlotLineKey;

		// Token: 0x0400657C RID: 25980
		[Nullable(1)]
		public string Name;

		// Token: 0x0400657D RID: 25981
		public bool? _folded;

		// Token: 0x0400657E RID: 25982
		public EEditFlag? _editFlag;

		// Token: 0x0400657F RID: 25983
		public int? WhoId;

		// Token: 0x04006580 RID: 25984
		public int? TextId;

		// Token: 0x04006581 RID: 25985
		public string TidTalk;

		// Token: 0x04006582 RID: 25986
		public float? WaitTime;

		// Token: 0x04006583 RID: 25987
		public ICaptionParam CaptionParams;

		// Token: 0x04006584 RID: 25988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006585 RID: 25989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006586 RID: 25990
		public PlayMontage Montage;

		// Token: 0x04006587 RID: 25991
		public ICameraData CameraData;

		// Token: 0x04006588 RID: 25992
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006589 RID: 25993
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x0400658A RID: 25994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x0400658B RID: 25995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x0400658C RID: 25996
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x0400658D RID: 25997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x0400658E RID: 25998
		public IPostAkEventType TalkAkEvent;

		// Token: 0x0400658F RID: 25999
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006590 RID: 26000
		public IUniversalTone UniversalTone;

		// Token: 0x04006591 RID: 26001
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006592 RID: 26002
		public bool? PlayVoice;

		// Token: 0x04006593 RID: 26003
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006594 RID: 26004
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006595 RID: 26005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006596 RID: 26006
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006597 RID: 26007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006598 RID: 26008
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IActorVisibility> ActorVisibilityArray;
	}
}
