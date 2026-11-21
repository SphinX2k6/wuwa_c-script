using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021A2 RID: 8610
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemVisualNovelTalk_SetValue
	{
		// Token: 0x040070C1 RID: 28865
		public ETalkItemType? Type;

		// Token: 0x040070C2 RID: 28866
		public int Id;

		// Token: 0x040070C3 RID: 28867
		public int? PlotLineId;

		// Token: 0x040070C4 RID: 28868
		public string PlotLineKey;

		// Token: 0x040070C5 RID: 28869
		[Nullable(0)]
		public string Name;

		// Token: 0x040070C6 RID: 28870
		public bool? _folded;

		// Token: 0x040070C7 RID: 28871
		public EEditFlag? _editFlag;

		// Token: 0x040070C8 RID: 28872
		public int? WhoId;

		// Token: 0x040070C9 RID: 28873
		public int? TextId;

		// Token: 0x040070CA RID: 28874
		public string TidTalk;

		// Token: 0x040070CB RID: 28875
		public float? WaitTime;

		// Token: 0x040070CC RID: 28876
		public ICaptionParam CaptionParams;

		// Token: 0x040070CD RID: 28877
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;

		// Token: 0x040070CE RID: 28878
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkOption> Options;

		// Token: 0x040070CF RID: 28879
		public PlayMontage Montage;

		// Token: 0x040070D0 RID: 28880
		public ICameraData CameraData;

		// Token: 0x040070D1 RID: 28881
		public SetFlowTemplate FlowTemplate;

		// Token: 0x040070D2 RID: 28882
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<SetFlowTemplate> FlowTemplateList;

		// Token: 0x040070D3 RID: 28883
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IMontageData> ActorMontageArray;

		// Token: 0x040070D4 RID: 28884
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFaceExpression> ActorFaceExpressionArray;

		// Token: 0x040070D5 RID: 28885
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorLookAt> ActorLookAtArray;

		// Token: 0x040070D6 RID: 28886
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorTurnTo> ActorTurnToArray;

		// Token: 0x040070D7 RID: 28887
		public IPostAkEventType TalkAkEvent;

		// Token: 0x040070D8 RID: 28888
		public IPostAkEventType TalkEndAkEvent;

		// Token: 0x040070D9 RID: 28889
		public IUniversalTone UniversalTone;

		// Token: 0x040070DA RID: 28890
		public ITalkBackground BackgroundConfig;

		// Token: 0x040070DB RID: 28891
		public bool? PlayVoice;

		// Token: 0x040070DC RID: 28892
		public ITimeLimitOptionGroup TimeLimitOptionGroup;

		// Token: 0x040070DD RID: 28893
		public IGamepadShakeInTalk GamepadShake;

		// Token: 0x040070DE RID: 28894
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> IntroActions;

		// Token: 0x040070DF RID: 28895
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorFxEmote> ActorFxEmoteArray;

		// Token: 0x040070E0 RID: 28896
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITalkEffectActionType> TalkEffectArray;

		// Token: 0x040070E1 RID: 28897
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IActorVisibility> ActorVisibilityArray;

		// Token: 0x040070E2 RID: 28898
		public EVisualNovelOptionInteractionType? OptionInteractionType;

		// Token: 0x040070E3 RID: 28899
		public IVisualNovelOptionGroupConfigBase OptionGroup;

		// Token: 0x040070E4 RID: 28900
		public float? DialogDelay;

		// Token: 0x040070E5 RID: 28901
		public bool? ClickShowFull;

		// Token: 0x040070E6 RID: 28902
		public string Interjection;

		// Token: 0x040070E7 RID: 28903
		public IVisualNovelPortraitTransform Transform;

		// Token: 0x040070E8 RID: 28904
		public IVisualNovelRoleConfig RoleConfig;

		// Token: 0x040070E9 RID: 28905
		public IVisualNovelBackgroundBase VisualNovelBackgroundConfig;

		// Token: 0x040070EA RID: 28906
		public IVisualNovelCgBase CgConfig;

		// Token: 0x040070EB RID: 28907
		public IVisualNovelDisplayItemBase DisplayItemConfig;

		// Token: 0x040070EC RID: 28908
		public int? PlotKeyId;

		// Token: 0x040070ED RID: 28909
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> StartPerformances;

		// Token: 0x040070EE RID: 28910
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IVisualNovelPerformanceBase> EndPerformances;
	}
}
