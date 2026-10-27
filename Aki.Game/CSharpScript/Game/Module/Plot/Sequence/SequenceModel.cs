using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005018 RID: 20504
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceModel : ModelBase
	{
		// Token: 0x17008006 RID: 32774
		// (get) Token: 0x06034791 RID: 214929 RVA: 0x00C5BF71 File Offset: 0x00C5A171
		public bool IsViewTargetControl
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsViewTargetControl;
			}
		}

		// Token: 0x17008007 RID: 32775
		// (get) Token: 0x06034792 RID: 214930 RVA: 0x00C5BF84 File Offset: 0x00C5A184
		public bool IsSubtitleUiUse
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsSubtitleUiUse;
			}
		}

		// Token: 0x17008008 RID: 32776
		// (get) Token: 0x06034793 RID: 214931 RVA: 0x00C5BF97 File Offset: 0x00C5A197
		public bool IsWaitRenderData
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsWaitRenderData;
			}
		}

		// Token: 0x17008009 RID: 32777
		// (get) Token: 0x06034794 RID: 214932 RVA: 0x00C5BFAA File Offset: 0x00C5A1AA
		public bool IsControlEntity
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.IsControlEntity;
			}
		}

		// Token: 0x1700800A RID: 32778
		// (get) Token: 0x06034795 RID: 214933 RVA: 0x00C5BFBD File Offset: 0x00C5A1BD
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

		// Token: 0x1700800B RID: 32779
		// (get) Token: 0x06034796 RID: 214934 RVA: 0x00C5BFD4 File Offset: 0x00C5A1D4
		public bool DoNotHandlePlayerForControlEntityMode
		{
			get
			{
				SequencePlayOptions playOptions = this.PlayOptions;
				return playOptions != null && playOptions.DoNotHandlePlayerForControlEntityMode;
			}
		}

		// Token: 0x06034797 RID: 214935 RVA: 0x00C5BFE8 File Offset: 0x00C5A1E8
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
			this.PauseFrame = null;
			if (this.ForceStreamHandle != null)
			{
				this.ForceStreamHandle.Cancel();
				this.ForceStreamHandle = null;
			}
		}

		// Token: 0x06034798 RID: 214936 RVA: 0x00C5C204 File Offset: 0x00C5A404
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

		// Token: 0x06034799 RID: 214937 RVA: 0x00C5C268 File Offset: 0x00C5A468
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

		// Token: 0x0603479A RID: 214938 RVA: 0x00C5C2D2 File Offset: 0x00C5A4D2
		public bool IsFinish()
		{
			return this.SubSeqIndex == -1;
		}

		// Token: 0x1700800C RID: 32780
		// (get) Token: 0x0603479B RID: 214939 RVA: 0x00C5C2E0 File Offset: 0x00C5A4E0
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

		// Token: 0x0603479C RID: 214940 RVA: 0x00C5C354 File Offset: 0x00C5A554
		public bool WillFinish()
		{
			return this.NextIndex == -1;
		}

		// Token: 0x0603479D RID: 214941 RVA: 0x00C5C35F File Offset: 0x00C5A55F
		public void QueueLatentAction(Action action)
		{
			this.LatentActions.Add(action);
		}

		// Token: 0x0603479E RID: 214942 RVA: 0x00C5C370 File Offset: 0x00C5A570
		public void RunLatentActions()
		{
			foreach (Action action in this.LatentActions)
			{
				action();
			}
			this.LatentActions.Clear();
		}

		// Token: 0x0603479F RID: 214943 RVA: 0x00C5C3CC File Offset: 0x00C5A5CC
		public bool GetLastFadeEnd()
		{
			return this.LastIndex >= 0 && this.IsFadeEnd.Count > this.LastIndex && this.IsFadeEnd[this.LastIndex];
		}

		// Token: 0x060347A0 RID: 214944 RVA: 0x00C5C3FD File Offset: 0x00C5A5FD
		[NullableContext(2)]
		public Transform GetLastTransform()
		{
			if (this.LastIndex < 0 || this.CurFinalPos.Count <= this.LastIndex)
			{
				return null;
			}
			return this.CurFinalPos[this.LastIndex];
		}

		// Token: 0x060347A1 RID: 214945 RVA: 0x00C5C42E File Offset: 0x00C5A62E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> GetFrameEvents(string key)
		{
			return this.FrameEvents.GetValueOrDefault(key);
		}

		// Token: 0x060347A2 RID: 214946 RVA: 0x00C5C43C File Offset: 0x00C5A63C
		public new EPlotSequenceType? GetType()
		{
			if (this.Type == null && !this.UseRuntimeData)
			{
				this.Type = new EPlotSequenceType?(this.SequenceData.类型);
			}
			return this.Type;
		}

		// Token: 0x060347A3 RID: 214947 RVA: 0x00C5C474 File Offset: 0x00C5A674
		public bool HasSubtitle()
		{
			return this.CurSubtitleStartFrames.Count != 0 && this.CurSubtitleEndFrames.Count != 0;
		}

		// Token: 0x1700800D RID: 32781
		// (get) Token: 0x060347A4 RID: 214948 RVA: 0x00C5C493 File Offset: 0x00C5A693
		public bool IsEnding
		{
			get
			{
				return this.State == ESequenceState.Ending;
			}
		}

		// Token: 0x1700800E RID: 32782
		// (get) Token: 0x060347A5 RID: 214949 RVA: 0x00C5C49E File Offset: 0x00C5A69E
		public bool IsPlaying
		{
			get
			{
				return this.State > ESequenceState.Null;
			}
		}

		// Token: 0x1700800F RID: 32783
		// (get) Token: 0x060347A6 RID: 214950 RVA: 0x00C5C4AC File Offset: 0x00C5A6AC
		public bool ShouldDelayToNextFrame
		{
			get
			{
				string flowName = FlowController.Instance.GetFlowName();
				return (string.IsNullOrEmpty(flowName) || !FlowLaunchResCheckHardCodingList.TempDisableNextFrameDelay.Contains(flowName)) && this.HasBindingEntity;
			}
		}

		// Token: 0x060347A7 RID: 214951 RVA: 0x00C5C4E8 File Offset: 0x00C5A6E8
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

		// Token: 0x060347A8 RID: 214952 RVA: 0x00C5C53C File Offset: 0x00C5A73C
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

		// Token: 0x060347A9 RID: 214953 RVA: 0x00C5C5DC File Offset: 0x00C5A7DC
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

		// Token: 0x060347AA RID: 214954 RVA: 0x00C5C744 File Offset: 0x00C5A944
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

		// Token: 0x17008010 RID: 32784
		// (get) Token: 0x060347AB RID: 214955 RVA: 0x00C5C7C4 File Offset: 0x00C5A9C4
		public static SequenceModel Instance
		{
			get
			{
				return SequenceModel._Instance;
			}
		}

		// Token: 0x060347AC RID: 214956 RVA: 0x00C5C7CB File Offset: 0x00C5A9CB
		public static SequenceModel GetOrCreateInstance()
		{
			if (SequenceModel._Instance == null)
			{
				SequenceModel.CreateInstance();
			}
			return SequenceModel._Instance;
		}

		// Token: 0x060347AD RID: 214957 RVA: 0x00C5C7DF File Offset: 0x00C5A9DF
		public static bool CreateInstance()
		{
			if (SequenceModel._Instance != null)
			{
				return true;
			}
			SequenceModel._Instance = new SequenceModel();
			return true;
		}

		// Token: 0x060347AE RID: 214958 RVA: 0x00C5C7F5 File Offset: 0x00C5A9F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060347AF RID: 214959 RVA: 0x00C5C7F7 File Offset: 0x00C5A9F7
		public static void ResetStaticDefaultValue()
		{
			SequenceModel._Instance = null;
		}

		// Token: 0x060347B0 RID: 214960 RVA: 0x00C5C7FF File Offset: 0x00C5A9FF
		static SequenceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SequenceModel.CreateStaticDefaultValue), new Action(SequenceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF43 RID: 114499
		public ESequenceState State;

		// Token: 0x0401BF44 RID: 114500
		public bool? IsPaused = new bool?(false);

		// Token: 0x0401BF45 RID: 114501
		[Nullable(2)]
		public PlaySequenceData Config;

		// Token: 0x0401BF46 RID: 114502
		[Nullable(2)]
		public BP_SequenceData_C SequenceData;

		// Token: 0x0401BF47 RID: 114503
		[Nullable(2)]
		public USkeletalMesh MainSeqCharacterMesh;

		// Token: 0x0401BF48 RID: 114504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<UObject> TalkNpcList;

		// Token: 0x0401BF49 RID: 114505
		public Dictionary<FName, AActor> BindingActorMap = new Dictionary<FName, AActor>();

		// Token: 0x0401BF4A RID: 114506
		public Dictionary<FName, EntityHandle> BindingEntityMap = new Dictionary<FName, EntityHandle>();

		// Token: 0x0401BF4B RID: 114507
		public Dictionary<int, SequenceEntityInfo> ControlEntityMap = new Dictionary<int, SequenceEntityInfo>();

		// Token: 0x0401BF4C RID: 114508
		public Dictionary<string, List<ActionInfo>> FrameEvents = new Dictionary<string, List<ActionInfo>>();

		// Token: 0x0401BF4D RID: 114509
		public Queue<string> ActionQueue = new Queue<string>(4);

		// Token: 0x0401BF4E RID: 114510
		public Dictionary<int, HashSet<string>> FrameEventsMap = new Dictionary<int, HashSet<string>>();

		// Token: 0x0401BF4F RID: 114511
		[Nullable(2)]
		public SequencePlayOptions PlayOptions;

		// Token: 0x0401BF50 RID: 114512
		[Nullable(2)]
		public UKuroActorStreamingHandle ForceStreamHandle;

		// Token: 0x0401BF51 RID: 114513
		public float? PreviousMotionBlur = new float?(0f);

		// Token: 0x0401BF52 RID: 114514
		public int? SubSeqLen = new int?(0);

		// Token: 0x0401BF53 RID: 114515
		public int SubSeqIndex = -2;

		// Token: 0x0401BF54 RID: 114516
		[Nullable(2)]
		public AActor SeqMainCharacter;

		// Token: 0x0401BF55 RID: 114517
		[Nullable(2)]
		public AActor BlendInCharacter;

		// Token: 0x0401BF56 RID: 114518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> BlendInCharacters = new List<AActor>();

		// Token: 0x0401BF57 RID: 114519
		[Nullable(2)]
		public AActor BlendOutCharacter;

		// Token: 0x0401BF58 RID: 114520
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AActor> BlendOutCharacters = new List<AActor>();

		// Token: 0x0401BF59 RID: 114521
		public bool? NeedsQueueLatentAction = new bool?(false);

		// Token: 0x0401BF5A RID: 114522
		public List<Action> LatentActions = new List<Action>();

		// Token: 0x0401BF5B RID: 114523
		public int LastIndex = -2;

		// Token: 0x0401BF5C RID: 114524
		public int NextIndex = -2;

		// Token: 0x0401BF5D RID: 114525
		[Nullable(2)]
		public EntityHandle HidePlayerEntityHandle;

		// Token: 0x0401BF5E RID: 114526
		[Nullable(2)]
		public Action<bool> FinishCallback;

		// Token: 0x0401BF5F RID: 114527
		public EPlotSequenceType? Type;

		// Token: 0x0401BF60 RID: 114528
		[Nullable(2)]
		public Transform RelativeTransform;

		// Token: 0x0401BF61 RID: 114529
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<Transform> CurFinalPos = new List<Transform>();

		// Token: 0x0401BF62 RID: 114530
		public List<bool> IsFadeEnd = new List<bool>();

		// Token: 0x0401BF63 RID: 114531
		public ELanguageAudio CurLanguageAudio;

		// Token: 0x0401BF64 RID: 114532
		public float? DurationOffset = new float?(0f);

		// Token: 0x0401BF65 RID: 114533
		[Nullable(2)]
		public ALevelSequenceActor CurLevelSeqActor;

		// Token: 0x0401BF66 RID: 114534
		public List<int> CurSubtitleStartFrames = new List<int>();

		// Token: 0x0401BF67 RID: 114535
		public List<int> CurSubtitleEndFrames = new List<int>();

		// Token: 0x0401BF68 RID: 114536
		public List<int> CurShotStartFrames = new List<int>();

		// Token: 0x0401BF69 RID: 114537
		public List<int> CurShotEndFrames = new List<int>();

		// Token: 0x0401BF6A RID: 114538
		public int? CurStartFrame = new int?(0);

		// Token: 0x0401BF6B RID: 114539
		public int? CurEndFrame = new int?(0);

		// Token: 0x0401BF6C RID: 114540
		public float? CurFrameRate = new float?(0f);

		// Token: 0x0401BF6D RID: 114541
		public int? SelectedOption = new int?(0);

		// Token: 0x0401BF6E RID: 114542
		public PlotSubtitleConfig CurSubtitle = new PlotSubtitleConfig();

		// Token: 0x0401BF6F RID: 114543
		public bool NeedJumpWhenResume;

		// Token: 0x0401BF70 RID: 114544
		public List<int> QteKeyFrames = new List<int>();

		// Token: 0x0401BF71 RID: 114545
		public int? PauseFrame;

		// Token: 0x0401BF72 RID: 114546
		public bool IsSubtitleConfigInit;

		// Token: 0x0401BF73 RID: 114547
		public float DefaultGuardTime;

		// Token: 0x0401BF74 RID: 114548
		public float DefaultAudioDelay;

		// Token: 0x0401BF75 RID: 114549
		public float DefaultAudioTransitionDuration;

		// Token: 0x0401BF76 RID: 114550
		public float? EndLeastTime;

		// Token: 0x0401BF77 RID: 114551
		public bool UseRuntimeData = true;

		// Token: 0x0401BF78 RID: 114552
		public bool IsSeamless;

		// Token: 0x0401BF79 RID: 114553
		public HashSet<int> MuteQteList = new HashSet<int>();

		// Token: 0x0401BF7A RID: 114554
		public bool IsMuteAllQte;

		// Token: 0x0401BF7B RID: 114555
		public FVectorDouble HidePos = new FVectorDouble(0.0, 0.0, -999999.0);

		// Token: 0x0401BF7C RID: 114556
		public float DisableMotionBlurFrame;

		// Token: 0x0401BF7D RID: 114557
		public float BeginSwitchFrame;

		// Token: 0x0401BF7E RID: 114558
		public bool TwiceAnimFlag;

		// Token: 0x0401BF7F RID: 114559
		[Nullable(2)]
		public ALevelSequenceActor AdditionSeqDirector;

		// Token: 0x0401BF80 RID: 114560
		public List<FName> NpcGroupPerform = new List<FName>();

		// Token: 0x0401BF81 RID: 114561
		public Dictionary<FName, NpcRelation> NpcRelationMap = new Dictionary<FName, NpcRelation>();

		// Token: 0x0401BF82 RID: 114562
		public HashSet<Entity> NeedHideNpcSet = new HashSet<Entity>();

		// Token: 0x0401BF83 RID: 114563
		[Nullable(2)]
		public EntityHandle PlotBindingVehicle;

		// Token: 0x0401BF84 RID: 114564
		public bool NeedWaitSwitchSubLevelComplete;

		// Token: 0x0401BF85 RID: 114565
		public bool EnablingUiBlend;

		// Token: 0x0401BF86 RID: 114566
		public bool IsConstrainAspectActive;

		// Token: 0x0401BF87 RID: 114567
		public bool IsStartTransformBlending;

		// Token: 0x0401BF88 RID: 114568
		public float StartTransformBlendElapsed;

		// Token: 0x0401BF89 RID: 114569
		public float StartTransformBlendDuration;

		// Token: 0x0401BF8A RID: 114570
		[Nullable(2)]
		public Action StartTransformBlendCallback;

		// Token: 0x0401BF8B RID: 114571
		public bool SkipUiWaiting;

		// Token: 0x0401BF8C RID: 114572
		[Nullable(2)]
		private static SequenceModel _Instance;
	}
}
