using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FE2 RID: 16354
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceModel : ModelBase
	{
		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x06029634 RID: 169524 RVA: 0x00BA74B1 File Offset: 0x00BA56B1
		public bool IsViewTargetControl
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsViewTargetControl;
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x06029635 RID: 169525 RVA: 0x00BA74C4 File Offset: 0x00BA56C4
		public bool IsSubtitleUiUse
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsSubtitleUiUse;
			}
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x06029636 RID: 169526 RVA: 0x00BA74D7 File Offset: 0x00BA56D7
		public bool IsWaitRenderData
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsWaitRenderData;
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x06029637 RID: 169527 RVA: 0x00BA74EA File Offset: 0x00BA56EA
		public bool IsControlEntity
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsControlEntity;
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x06029638 RID: 169528 RVA: 0x00BA74FD File Offset: 0x00BA56FD
		public float PlayRate
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				if (playOptions == null)
				{
					return 1f;
				}
				return playOptions.PlayRate;
			}
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x06029639 RID: 169529 RVA: 0x00BA7514 File Offset: 0x00BA5714
		public bool DoNotHandlePlayerForControlEntityMode
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.DoNotHandlePlayerForControlEntityMode;
			}
		}

		// Token: 0x0602963A RID: 169530 RVA: 0x00BA7528 File Offset: 0x00BA5728
		public void Reset()
		{
			this.IsPaused = null;
			this.Config = null;
			this.SequenceData = null;
			this.BindingActorMap.Clear();
			this.BindingEntityMap.Clear();
			this.ControlEntityMap.Clear();
			this.FrameEvents.Clear();
			this.ActionQueue.Clear();
			this.FrameEventsMap.Clear();
			this.PlayOptions = null;
			this.PreviousMotionBlur = null;
			this.SubSeqLen = null;
			this.SubSeqIndex = -2;
			this.SeqMainCharacter = null;
			this.NeedsQueueLatentAction = null;
			this.CurLevelSeqActor = null;
			this.LatentActions.Clear();
			this.LastIndex = -2;
			this.NextIndex = -2;
			this.HidePlayerEntityHandle = null;
			this.CurSubtitleStartFrames.Clear();
			this.CurSubtitleEndFrames.Clear();
			this.CurShotStartFrames.Clear();
			this.CurShotEndFrames.Clear();
			this.CurFinalPos.Clear();
			this.IsFadeEnd.Clear();
			this.CurStartFrame = null;
			this.CurEndFrame = null;
			this.CurFrameRate = null;
			this.SelectedOption = null;
			this.CurSubtitle.Clear();
			this.Type = null;
			this.RelativeTransform = null;
			this.CurLanguageAudio = ELanguageAudio.All;
			this.NeedJumpWhenResume = false;
			this.AdditionSeqDirector = null;
			this.BlendInCharacters = new List<AActor>();
			this.BlendOutCharacters = new List<AActor>();
			this.NpcGroupPerform.Clear();
			this.NpcRelationMap.Clear();
			this.NeedHideNpcSet.Clear();
			this.QteKeyFrames.Clear();
			this.PlotBindingVehicle = null;
			this.NeedWaitSwitchSubLevelComplete = false;
			this.IsConstrainAspectActive = false;
			this.SkipUiWaiting = false;
			this.IsStartTransformBlending = false;
			this.StartTransformBlendElapsed = 0f;
			this.StartTransformBlendDuration = 0f;
			this.StartTransformBlendCallback = null;
			this.WaitSwitchTargetVisible = false;
			this.SwitchTargetWaitFrame = 0;
			this.PauseFrame = null;
			if (this.ForceStreamHandle != null)
			{
				this.ForceStreamHandle.Cancel();
				this.ForceStreamHandle = null;
			}
		}

		// Token: 0x0602963B RID: 169531 RVA: 0x00BA7750 File Offset: 0x00BA5950
		[NullableContext(2)]
		public ULevelSequence GetCurrentSequence()
		{
			if (this.SubSeqIndex == -1)
			{
				return null;
			}
			if (this.SubSeqIndex == -2)
			{
				return null;
			}
			int subSeqIndex = this.SubSeqIndex;
			int? subSeqLen = this.SubSeqLen;
			if (!(subSeqIndex < subSeqLen.GetValueOrDefault() & subSeqLen != null))
			{
				return null;
			}
			BP_SequenceData_C sequenceData = this.SequenceData;
			if (sequenceData == null)
			{
				return null;
			}
			return sequenceData.剧情资源.Get(this.SubSeqIndex);
		}

		// Token: 0x0602963C RID: 169532 RVA: 0x00BA77B4 File Offset: 0x00BA59B4
		[NullableContext(2)]
		public SSequencesKeyFrames GetCurrentKeyFramesInfo()
		{
			BP_SequenceData_C sequenceData = this.SequenceData;
			bool flag;
			if (sequenceData == null)
			{
				flag = false;
			}
			else
			{
				BP_SequenceData_Generated_C generatedData = sequenceData.GeneratedData;
				flag = ((generatedData != null) ? new bool?(generatedData.KeyFrames.IsValidIndex(this.SubSeqIndex)) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				return null;
			}
			return this.SequenceData.GeneratedData.KeyFrames.Get(this.SubSeqIndex);
		}

		// Token: 0x0602963D RID: 169533 RVA: 0x00BA781E File Offset: 0x00BA5A1E
		public bool IsFinish()
		{
			return this.SubSeqIndex == -1;
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x0602963E RID: 169534 RVA: 0x00BA782C File Offset: 0x00BA5A2C
		public bool HasBindingEntity
		{
			get
			{
				if (this.SequenceData == null)
				{
					return false;
				}
				TArray<FName> 绑定角色标签 = this.SequenceData.绑定角色标签;
				int num = 绑定角色标签.Num();
				for (int i = 0; i < num; i++)
				{
					FName fname = 绑定角色标签.Get(i);
					if (!(fname == SequenceDefine.HERO_TAG) && !fname.ToString().Contains("Perform_NPC") && !FNameUtil.IsEmpty(new FName?(fname)))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0602963F RID: 169535 RVA: 0x00BA78A0 File Offset: 0x00BA5AA0
		public bool WillFinish()
		{
			return this.NextIndex == -1;
		}

		// Token: 0x06029640 RID: 169536 RVA: 0x00BA78AB File Offset: 0x00BA5AAB
		public void QueueLatentAction(Action action)
		{
			this.LatentActions.Add(action);
		}

		// Token: 0x06029641 RID: 169537 RVA: 0x00BA78BC File Offset: 0x00BA5ABC
		public void RunLatentActions()
		{
			foreach (Action action in this.LatentActions)
			{
				action();
			}
			this.LatentActions.Clear();
		}

		// Token: 0x06029642 RID: 169538 RVA: 0x00BA7918 File Offset: 0x00BA5B18
		public bool GetLastFadeEnd()
		{
			return this.LastIndex >= 0 && this.IsFadeEnd.Count > this.LastIndex && this.IsFadeEnd[this.LastIndex];
		}

		// Token: 0x06029643 RID: 169539 RVA: 0x00BA7949 File Offset: 0x00BA5B49
		[NullableContext(2)]
		public Transform GetLastTransform()
		{
			if (this.LastIndex < 0 || this.CurFinalPos.Count <= this.LastIndex)
			{
				return null;
			}
			return this.CurFinalPos[this.LastIndex];
		}

		// Token: 0x06029644 RID: 169540 RVA: 0x00BA797A File Offset: 0x00BA5B7A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> GetFrameEvents(string key)
		{
			return this.FrameEvents.GetValueOrDefault(key);
		}

		// Token: 0x06029645 RID: 169541 RVA: 0x00BA7988 File Offset: 0x00BA5B88
		public new EPlotSequenceType? GetType()
		{
			if (this.Type == null && !this.UseRuntimeData)
			{
				this.Type = new EPlotSequenceType?(this.SequenceData.类型);
			}
			return this.Type;
		}

		// Token: 0x06029646 RID: 169542 RVA: 0x00BA79C0 File Offset: 0x00BA5BC0
		public bool HasSubtitle()
		{
			return this.CurSubtitleStartFrames.Count != 0 && this.CurSubtitleEndFrames.Count != 0;
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x06029647 RID: 169543 RVA: 0x00BA79DF File Offset: 0x00BA5BDF
		public bool IsEnding
		{
			get
			{
				return this.State == ESequenceState.Ending;
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x06029648 RID: 169544 RVA: 0x00BA79EA File Offset: 0x00BA5BEA
		public bool IsPlaying
		{
			get
			{
				return this.State > ESequenceState.Null;
			}
		}

		// Token: 0x170053C4 RID: 21444
		// (get) Token: 0x06029649 RID: 169545 RVA: 0x00BA79F8 File Offset: 0x00BA5BF8
		public bool ShouldDelayToNextFrame
		{
			get
			{
				string flowName = FlowController.Instance.GetFlowName();
				return (string.IsNullOrEmpty(flowName) || !FlowLaunchResCheckHardCodingList.TempDisableNextFrameDelay.Contains(flowName)) && this.HasBindingEntity;
			}
		}

		// Token: 0x0602964A RID: 169546 RVA: 0x00BA7A34 File Offset: 0x00BA5C34
		[NullableContext(2)]
		public void AddFinalPos(Transform trans)
		{
			if (trans == null)
			{
				this.CurFinalPos.Add(trans);
				return;
			}
			if (this.RelativeTransform != null)
			{
				Transform transform = Transform.Create();
				trans.ComposeTransforms(this.RelativeTransform, transform);
				this.CurFinalPos.Add(transform);
				return;
			}
			this.CurFinalPos.Add(trans);
		}

		// Token: 0x0602964B RID: 169547 RVA: 0x00BA7A88 File Offset: 0x00BA5C88
		public string GetPlayerBpClass()
		{
			PlayerInfoModel instance = PlayerInfoModel.Instance;
			TSoftClassPtr<AActor> tsoftClassPtr;
			if (instance == null || instance.GetPlayerGender() != EPlayerGender.Male)
			{
				BP_SequenceData_Generated_C generatedData = this.SequenceData.GeneratedData;
				tsoftClassPtr = ((generatedData != null) ? generatedData.FemalePlayerBP : null);
			}
			else
			{
				BP_SequenceData_Generated_C generatedData2 = this.SequenceData.GeneratedData;
				tsoftClassPtr = ((generatedData2 != null) ? generatedData2.MalePlayerBP : null);
			}
			TSoftClassPtr<AActor> tsoftClassPtr2 = tsoftClassPtr;
			if (tsoftClassPtr2 != null)
			{
				return tsoftClassPtr2.ToAssetPathName();
			}
			FlowController.Instance.LogError("GeneratedDA不存在，联系演出刷DA", default(ReadOnlySpan<ValueTuple<string, object>>));
			PlayerInfoModel instance2 = PlayerInfoModel.Instance;
			if (instance2 != null && instance2.GetPlayerGender() == EPlayerGender.Male)
			{
				return "/Game/Aki/Character/Role/MaleM/Nanzhu/Seq/BP_Nanzhu_Seq_V2.BP_Nanzhu_Seq_V2_C";
			}
			return "/Game/Aki/Character/Role/FemaleM/Nvzhu/Seq/BP_Nvzhu_Seq_V2.BP_Nvzhu_Seq_V2_C";
		}

		// Token: 0x0602964C RID: 169548 RVA: 0x00BA7B28 File Offset: 0x00BA5D28
		public float GetCurrentPlayPosition()
		{
			if (this.State != ESequenceState.Playing)
			{
				return 0f;
			}
			float? num = new float?(0f);
			ALevelSequenceActor curLevelSeqActor = this.CurLevelSeqActor;
			int? num2;
			if (curLevelSeqActor == null)
			{
				num2 = null;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer = curLevelSeqActor.SequencePlayer;
				num2 = ((sequencePlayer != null) ? new int?(sequencePlayer.GetCurrentTime().Time.FrameNumber.Value) : null);
			}
			int? num3 = num2;
			if (num3 != null)
			{
				float? num4 = num;
				int? num5 = num3;
				int? curStartFrame = this.CurStartFrame;
				num = num4 + ((num5 != null & curStartFrame != null) ? new float?((float)(num5.GetValueOrDefault() - curStartFrame.GetValueOrDefault())) : null) / this.CurFrameRate;
			}
			num += this.DurationOffset;
			return num.Value;
		}

		// Token: 0x0602964D RID: 169549 RVA: 0x00BA7C90 File Offset: 0x00BA5E90
		public List<int> GetCurKeyFrames()
		{
			BP_SequenceData_C sequenceData = this.SequenceData;
			bool flag;
			if (sequenceData == null)
			{
				flag = (null != null);
			}
			else
			{
				BP_SequenceData_Generated_C generatedData = sequenceData.GeneratedData;
				flag = (((generatedData != null) ? generatedData.KeyFrames : null) != null);
			}
			if (!flag)
			{
				return new List<int>();
			}
			if (!this.SequenceData.GeneratedData.KeyFrames.IsValidIndex(this.SubSeqIndex))
			{
				return new List<int>();
			}
			return new List<int>(ObjectUtils.ueArrayToArray<int>(this.SequenceData.GeneratedData.KeyFrames.Get(this.SubSeqIndex).KeyFrames));
		}

		// Token: 0x170053C5 RID: 21445
		// (get) Token: 0x0602964E RID: 169550 RVA: 0x00BA7D10 File Offset: 0x00BA5F10
		public static SequenceModel Instance
		{
			get
			{
				return SequenceModel._Instance;
			}
		}

		// Token: 0x0602964F RID: 169551 RVA: 0x00BA7D17 File Offset: 0x00BA5F17
		public static SequenceModel GetOrCreateInstance()
		{
			if (SequenceModel._Instance == null)
			{
				SequenceModel.CreateInstance();
			}
			return SequenceModel._Instance;
		}

		// Token: 0x06029650 RID: 169552 RVA: 0x00BA7D2B File Offset: 0x00BA5F2B
		public static bool CreateInstance()
		{
			if (SequenceModel._Instance != null)
			{
				return true;
			}
			SequenceModel._Instance = new SequenceModel();
			return true;
		}

		// Token: 0x06029651 RID: 169553 RVA: 0x00BA7D41 File Offset: 0x00BA5F41
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029652 RID: 169554 RVA: 0x00BA7D43 File Offset: 0x00BA5F43
		public static void ResetStaticDefaultValue()
		{
			SequenceModel._Instance = null;
		}

		// Token: 0x06029653 RID: 169555 RVA: 0x00BA7D4B File Offset: 0x00BA5F4B
		static SequenceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceModel.CreateStaticDefaultValue), new Action(SequenceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401692C RID: 92460
		public ESequenceState State;

		// Token: 0x0401692D RID: 92461
		public bool? IsPaused = new bool?(false);

		// Token: 0x0401692E RID: 92462
		[Nullable(2)]
		public PlaySequenceData Config;

		// Token: 0x0401692F RID: 92463
		[Nullable(2)]
		public BP_SequenceData_C SequenceData;

		// Token: 0x04016930 RID: 92464
		[Nullable(2)]
		public USkeletalMesh MainSeqCharacterMesh;

		// Token: 0x04016931 RID: 92465
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<UObject> TalkNpcList;

		// Token: 0x04016932 RID: 92466
		public Dictionary<FName, AActor> BindingActorMap = new Dictionary<FName, AActor>();

		// Token: 0x04016933 RID: 92467
		public Dictionary<FName, EntityHandle> BindingEntityMap = new Dictionary<FName, EntityHandle>();

		// Token: 0x04016934 RID: 92468
		public Dictionary<int, SequenceEntityInfo> ControlEntityMap = new Dictionary<int, SequenceEntityInfo>();

		// Token: 0x04016935 RID: 92469
		public Dictionary<string, List<ActionInfo>> FrameEvents = new Dictionary<string, List<ActionInfo>>();

		// Token: 0x04016936 RID: 92470
		public Queue<string> ActionQueue = new Queue<string>(4);

		// Token: 0x04016937 RID: 92471
		public Dictionary<int, HashSet<string>> FrameEventsMap = new Dictionary<int, HashSet<string>>();

		// Token: 0x04016938 RID: 92472
		[Nullable(2)]
		public SequencePlayOptions PlayOptions;

		// Token: 0x04016939 RID: 92473
		[Nullable(2)]
		public UKuroActorStreamingHandle ForceStreamHandle;

		// Token: 0x0401693A RID: 92474
		public float? PreviousMotionBlur = new float?(0f);

		// Token: 0x0401693B RID: 92475
		public int? SubSeqLen = new int?(0);

		// Token: 0x0401693C RID: 92476
		public int SubSeqIndex = -2;

		// Token: 0x0401693D RID: 92477
		[Nullable(2)]
		public AActor SeqMainCharacter;

		// Token: 0x0401693E RID: 92478
		[Nullable(2)]
		public AActor BlendInCharacter;

		// Token: 0x0401693F RID: 92479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> BlendInCharacters = new List<AActor>();

		// Token: 0x04016940 RID: 92480
		[Nullable(2)]
		public AActor BlendOutCharacter;

		// Token: 0x04016941 RID: 92481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> BlendOutCharacters = new List<AActor>();

		// Token: 0x04016942 RID: 92482
		public bool? NeedsQueueLatentAction = new bool?(false);

		// Token: 0x04016943 RID: 92483
		public List<Action> LatentActions = new List<Action>();

		// Token: 0x04016944 RID: 92484
		public int LastIndex = -2;

		// Token: 0x04016945 RID: 92485
		public int NextIndex = -2;

		// Token: 0x04016946 RID: 92486
		[Nullable(2)]
		public EntityHandle HidePlayerEntityHandle;

		// Token: 0x04016947 RID: 92487
		[Nullable(2)]
		public Action<bool> FinishCallback;

		// Token: 0x04016948 RID: 92488
		public EPlotSequenceType? Type;

		// Token: 0x04016949 RID: 92489
		[Nullable(2)]
		public Transform RelativeTransform;

		// Token: 0x0401694A RID: 92490
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<Transform> CurFinalPos = new List<Transform>();

		// Token: 0x0401694B RID: 92491
		public List<bool> IsFadeEnd = new List<bool>();

		// Token: 0x0401694C RID: 92492
		public ELanguageAudio CurLanguageAudio;

		// Token: 0x0401694D RID: 92493
		public float? DurationOffset = new float?(0f);

		// Token: 0x0401694E RID: 92494
		[Nullable(2)]
		public ALevelSequenceActor CurLevelSeqActor;

		// Token: 0x0401694F RID: 92495
		public List<int> CurSubtitleStartFrames = new List<int>();

		// Token: 0x04016950 RID: 92496
		public List<int> CurSubtitleEndFrames = new List<int>();

		// Token: 0x04016951 RID: 92497
		public List<int> CurShotStartFrames = new List<int>();

		// Token: 0x04016952 RID: 92498
		public List<int> CurShotEndFrames = new List<int>();

		// Token: 0x04016953 RID: 92499
		public int? CurStartFrame = new int?(0);

		// Token: 0x04016954 RID: 92500
		public int? CurEndFrame = new int?(0);

		// Token: 0x04016955 RID: 92501
		public float? CurFrameRate = new float?(0f);

		// Token: 0x04016956 RID: 92502
		public int? SelectedOption = new int?(0);

		// Token: 0x04016957 RID: 92503
		public PlotSubtitleConfig CurSubtitle = new PlotSubtitleConfig();

		// Token: 0x04016958 RID: 92504
		public bool NeedJumpWhenResume;

		// Token: 0x04016959 RID: 92505
		public List<int> QteKeyFrames = new List<int>();

		// Token: 0x0401695A RID: 92506
		public int? PauseFrame;

		// Token: 0x0401695B RID: 92507
		public bool IsSubtitleConfigInit;

		// Token: 0x0401695C RID: 92508
		public float DefaultGuardTime;

		// Token: 0x0401695D RID: 92509
		public float DefaultAudioDelay;

		// Token: 0x0401695E RID: 92510
		public float DefaultAudioTransitionDuration;

		// Token: 0x0401695F RID: 92511
		public float? EndLeastTime;

		// Token: 0x04016960 RID: 92512
		public bool UseRuntimeData = true;

		// Token: 0x04016961 RID: 92513
		public bool IsSeamless;

		// Token: 0x04016962 RID: 92514
		public HashSet<int> MuteQteList = new HashSet<int>();

		// Token: 0x04016963 RID: 92515
		public bool IsMuteAllQte;

		// Token: 0x04016964 RID: 92516
		public FVectorDouble HidePos = new FVectorDouble(0.0, 0.0, -999999.0);

		// Token: 0x04016965 RID: 92517
		public float DisableMotionBlurFrame;

		// Token: 0x04016966 RID: 92518
		public float BeginSwitchFrame;

		// Token: 0x04016967 RID: 92519
		public bool WaitSwitchTargetVisible;

		// Token: 0x04016968 RID: 92520
		public int SwitchTargetWaitFrame;

		// Token: 0x04016969 RID: 92521
		public bool TwiceAnimFlag;

		// Token: 0x0401696A RID: 92522
		[Nullable(2)]
		public ALevelSequenceActor AdditionSeqDirector;

		// Token: 0x0401696B RID: 92523
		public List<FName> NpcGroupPerform = new List<FName>();

		// Token: 0x0401696C RID: 92524
		public Dictionary<FName, NpcRelation> NpcRelationMap = new Dictionary<FName, NpcRelation>();

		// Token: 0x0401696D RID: 92525
		public HashSet<Entity> NeedHideNpcSet = new HashSet<Entity>();

		// Token: 0x0401696E RID: 92526
		[Nullable(2)]
		public EntityHandle PlotBindingVehicle;

		// Token: 0x0401696F RID: 92527
		public bool NeedWaitSwitchSubLevelComplete;

		// Token: 0x04016970 RID: 92528
		public bool EnablingUiBlend;

		// Token: 0x04016971 RID: 92529
		public bool IsConstrainAspectActive;

		// Token: 0x04016972 RID: 92530
		public bool IsStartTransformBlending;

		// Token: 0x04016973 RID: 92531
		public float StartTransformBlendElapsed;

		// Token: 0x04016974 RID: 92532
		public float StartTransformBlendDuration;

		// Token: 0x04016975 RID: 92533
		[Nullable(2)]
		public Action StartTransformBlendCallback;

		// Token: 0x04016976 RID: 92534
		public bool SkipUiWaiting;

		// Token: 0x04016977 RID: 92535
		[Nullable(2)]
		private static SequenceModel _Instance;
	}
}
