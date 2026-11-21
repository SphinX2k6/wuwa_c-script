using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002176 RID: 8566
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAvgTalk_SetValue
	{
		// Token: 0x04006D1E RID: 27934
		public ETalkItemType? Type;

		// Token: 0x04006D1F RID: 27935
		public int Id;

		// Token: 0x04006D20 RID: 27936
		public int? PlotLineId;

		// Token: 0x04006D21 RID: 27937
		public string PlotLineKey;

		// Token: 0x04006D22 RID: 27938
		[Nullable(0)]
		public string Name;

		// Token: 0x04006D23 RID: 27939
		public bool? _folded;

		// Token: 0x04006D24 RID: 27940
		public EEditFlag? _editFlag;

		// Token: 0x04006D25 RID: 27941
		public int? WhoId;

		// Token: 0x04006D26 RID: 27942
		public int? TextId;

		// Token: 0x04006D27 RID: 27943
		public string TidTalk;

		// Token: 0x04006D28 RID: 27944
		public float? WaitTime;

		// Token: 0x04006D29 RID: 27945
		public ICaptionParam CaptionParams;

		// Token: 0x04006D2A RID: 27946
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x04006D2B RID: 27947
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x04006D2C RID: 27948
		public PlayMontage Montage;

		// Token: 0x04006D2D RID: 27949
		public ICameraData CameraData;

		// Token: 0x04006D2E RID: 27950
		public SetFlowTemplate FlowTemplate;

		// Token: 0x04006D2F RID: 27951
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x04006D30 RID: 27952
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x04006D31 RID: 27953
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x04006D32 RID: 27954
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x04006D33 RID: 27955
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x04006D34 RID: 27956
		public IPostAkEventType TalkAkEvent;

		// Token: 0x04006D35 RID: 27957
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x04006D36 RID: 27958
		public IUniversalTone UniversalTone;

		// Token: 0x04006D37 RID: 27959
		public ITalkBackground BackgroundConfig;

		// Token: 0x04006D38 RID: 27960
		public bool? PlayVoice;

		// Token: 0x04006D39 RID: 27961
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x04006D3A RID: 27962
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x04006D3B RID: 27963
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x04006D3C RID: 27964
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x04006D3D RID: 27965
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x04006D3E RID: 27966
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x04006D3F RID: 27967
		[Nullable(0)]
		public ITalkItemAvgRoleConfig AvgRoleConfig;

		// Token: 0x04006D40 RID: 27968
		public EAvgRolePosition PositionConfig;
	}
}
