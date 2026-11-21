using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using AkiClient.Game.Aki.Render.RuntimeBP.SceneCapture_3To2;
using AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A4B RID: 10827
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class BpActorController : ControllerBase
{
	// Token: 0x0601B624 RID: 112164 RVA: 0x00867BB8 File Offset: 0x00865DB8
	public void SetDebugMediaDisabled(bool disabled)
	{
		this.DebugMediaDisabled = disabled;
		if (!this.DebugMediaDisabled)
		{
			return;
		}
		IBPI_SceneBp_C lastActiveMediaActor = this.LastActiveMediaActor;
		if (lastActiveMediaActor != null)
		{
			lastActiveMediaActor.Stop();
		}
		this.LastActiveMediaActor = null;
		IBPI_SceneBp_C lastActiveMediaActor_Extra = this.LastActiveMediaActor_Extra;
		if (lastActiveMediaActor_Extra != null)
		{
			lastActiveMediaActor_Extra.Stop();
		}
		this.LastActiveMediaActor_Extra = null;
	}

	// Token: 0x0601B625 RID: 112165 RVA: 0x00867C08 File Offset: 0x00865E08
	public void SetDebugSpecialMediaDisabled(bool disabled)
	{
		this.DebugSpecialMediaDisabled = disabled;
		if (!this.DebugSpecialMediaDisabled)
		{
			return;
		}
		foreach (BpActorController.ActiveResourceGroup activeResourceGroup in this.ActiveResourceGroups.Values)
		{
			foreach (MediaPlayForModel_Special_C mediaPlayForModel_Special_C in activeResourceGroup.Actors)
			{
				if (mediaPlayForModel_Special_C != null && mediaPlayForModel_Special_C.IsValid())
				{
					mediaPlayForModel_Special_C.Stop();
				}
			}
		}
		this.ActiveResourceGroups.Clear();
		this.PendingPlayMediaActors_Special.Clear();
		this.PendingCloseMediaActors_Special.Clear();
		this.PendingReleaseMediaActors_Special.Clear();
	}

	// Token: 0x0601B626 RID: 112166 RVA: 0x00867CE0 File Offset: 0x00865EE0
	public void SetDebugSpecialMediaSingleModeEnabled(bool enabled)
	{
		this.DebugSpecialMediaSingleModeEnabled = enabled;
		if (this.DebugSpecialMediaSingleModeEnabled)
		{
			foreach (BpActorController.ActiveResourceGroup activeResourceGroup in this.ActiveResourceGroups.Values)
			{
				foreach (MediaPlayForModel_Special_C mediaPlayForModel_Special_C in activeResourceGroup.Actors)
				{
					if (mediaPlayForModel_Special_C != null && mediaPlayForModel_Special_C.IsValid())
					{
						mediaPlayForModel_Special_C.Stop();
					}
				}
			}
			this.ActiveResourceGroups.Clear();
			this.PendingPlayMediaActors_Special.Clear();
			this.PendingCloseMediaActors_Special.Clear();
			this.PendingReleaseMediaActors_Special.Clear();
			this.DebugFixedMediaPlayer = null;
			this.DebugFixedMediaTexture = null;
			this.SpecialActorAssetLoadCompleted = false;
			this.LoadingSpecialActorAsset = false;
			this.TryLoadSpecialMediaActorAsset().Forget();
			Log.Instance.Info(ELogModule.World, ELogAuthor.CK, "[BpActorController] 已开启单资源调试模式, 正在从DA直接加载固定资源", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.DebugFixedMediaPlayer = null;
		this.DebugFixedMediaTexture = null;
		WorldController.Instance.ForceGarbageCollection(true);
		Log.Instance.Info(ELogModule.World, ELogAuthor.CK, "[BpActorController] 已关闭单资源调试模式", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601B627 RID: 112167 RVA: 0x00867E34 File Offset: 0x00866034
	private bool DebugImmediatePlayMedia_Special(MediaPlayForModel_Special_C actor, PDA_MediaPlayDataAsset_C dataAsset, int? pbDataId)
	{
		if (this.ActiveResourceGroups.Count > 0)
		{
			return false;
		}
		if (this.DebugFixedMediaPlayer == null || this.DebugFixedMediaTexture == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] DebugImmediatePlayMedia_Special: 固定资源尚未就绪(DA直接加载中)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", actor);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		actor.AllocatePlayerAsset(this.DebugFixedMediaPlayer, this.DebugFixedMediaTexture);
		actor.Start();
		this.ActiveResourceGroups[dataAsset] = new BpActorController.ActiveResourceGroup(this.DebugFixedMediaPlayer, this.DebugFixedMediaTexture, new HashSet<MediaPlayForModel_Special_C>
		{
			actor
		});
		return true;
	}

	// Token: 0x0601B628 RID: 112168 RVA: 0x00867ED0 File Offset: 0x008660D0
	private unsafe bool DebugImmediateStopMedia_Special(MediaPlayForModel_Special_C actor, PDA_MediaPlayDataAsset_C dataAsset, int? pbDataId, BpActorController.EPendingStopReason reason)
	{
		BpActorController.ActiveResourceGroup activeResourceGroup;
		if (!this.ActiveResourceGroups.TryGetValue(dataAsset, out activeResourceGroup) || !activeResourceGroup.Actors.Contains(actor))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] DebugImmediateStopMedia_Special: Actor无需停止";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("DataAsset", dataAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", (reason == BpActorController.EPendingStopReason.OutOfAOI) ? "OutOfAOI" : "ManualControl");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return true;
		}
		activeResourceGroup.Actors.Remove(actor);
		this.ActiveResourceGroups.Remove(dataAsset);
		actor.Stop();
		return true;
	}

	// Token: 0x0601B629 RID: 112169 RVA: 0x00867FDC File Offset: 0x008661DC
	protected override bool OnInit()
	{
		TArray<FGameBudgetBlueprintGroupConfig> tarray = new TArray<FGameBudgetBlueprintGroupConfig>();
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig.Group = EGameBudgetBlueprintGroup.Singleton;
		fgameBudgetBlueprintGroupConfig.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.BlueprintSingleton").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig2 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig2.Group = EGameBudgetBlueprintGroup.SceneActor;
		fgameBudgetBlueprintGroupConfig2.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.SceneBlueprintActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig3 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig3.Group = EGameBudgetBlueprintGroup.FarActor;
		fgameBudgetBlueprintGroupConfig3.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.FarBlueprintActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig4 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig4.Group = EGameBudgetBlueprintGroup.SuperFarActor;
		fgameBudgetBlueprintGroupConfig4.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.SuperFarBlueprintActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig5 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig5.Group = EGameBudgetBlueprintGroup.DynamicPhysicsInteractionActor;
		fgameBudgetBlueprintGroupConfig5.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.DynamicPhysicsInteractionActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig6 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig6.Group = EGameBudgetBlueprintGroup.StaticPhysicInteractionActor;
		fgameBudgetBlueprintGroupConfig6.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.StaticPhysicsInteractionActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig7 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig7.Group = EGameBudgetBlueprintGroup.HighPriorityPhysicInteractionActor;
		fgameBudgetBlueprintGroupConfig7.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.HighPriorityPhysicsInteractionActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig8 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig8.Group = EGameBudgetBlueprintGroup.SpecialBlueprintActor;
		fgameBudgetBlueprintGroupConfig8.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.SpecialBlueprintActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig9 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig9.Group = EGameBudgetBlueprintGroup.SparseGridPhysicsInteractionActor;
		fgameBudgetBlueprintGroupConfig9.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.SparseGridPhysicsInteractionActor").Value;
		FGameBudgetBlueprintGroupConfig fgameBudgetBlueprintGroupConfig10 = new FGameBudgetBlueprintGroupConfig();
		fgameBudgetBlueprintGroupConfig10.Group = EGameBudgetBlueprintGroup.ScreenDecalActor;
		fgameBudgetBlueprintGroupConfig10.GameBudgetGroupName = FNameUtil.GetDynamicFName("BlueprintTick.ScreenDecalActor").Value;
		tarray.Add(fgameBudgetBlueprintGroupConfig);
		tarray.Add(fgameBudgetBlueprintGroupConfig2);
		tarray.Add(fgameBudgetBlueprintGroupConfig3);
		tarray.Add(fgameBudgetBlueprintGroupConfig4);
		tarray.Add(fgameBudgetBlueprintGroupConfig5);
		tarray.Add(fgameBudgetBlueprintGroupConfig6);
		tarray.Add(fgameBudgetBlueprintGroupConfig7);
		tarray.Add(fgameBudgetBlueprintGroupConfig8);
		tarray.Add(fgameBudgetBlueprintGroupConfig9);
		tarray.Add(fgameBudgetBlueprintGroupConfig10);
		UKuroGameBudgetBlueprintDefine.Initialize(tarray);
		EventSystem.Instance.Add<int>(EEventName.SetEnvironmentInteraction, new Action<int>(this.OnSetEnvironmentInteraction));
		return true;
	}

	// Token: 0x0601B62A RID: 112170 RVA: 0x008681F4 File Offset: 0x008663F4
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int>(EEventName.SetEnvironmentInteraction, new Action<int>(this.OnSetEnvironmentInteraction));
		UKuroGameBudgetBlueprintDefine.Clear();
		return true;
	}

	// Token: 0x0601B62B RID: 112171 RVA: 0x00868218 File Offset: 0x00866418
	private void OnSetEnvironmentInteraction(int value)
	{
		UKuroGameBudgetSubSystem ukuroGameBudgetSubSystem = USubsystemBlueprintLibrary.GetWorldSubsystem(GlobalData.World, UKuroGameBudgetSubSystem.StaticClass()) as UKuroGameBudgetSubSystem;
		if (ukuroGameBudgetSubSystem != null)
		{
			ukuroGameBudgetSubSystem.SetEnvInteractChange(value > 0);
		}
	}

	// Token: 0x0601B62C RID: 112172 RVA: 0x0086824C File Offset: 0x0086644C
	public void RegisterBpActor(FName groupTag, IBPI_SceneBp_C sceneBp)
	{
		if (sceneBp == null)
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "BpActorController sceneBp 是空的", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (groupTag == this.MEDIA_ACTOR_GROUP)
		{
			AActor aactor = sceneBp as AActor;
			if (aactor == null)
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "BpActorController MediaActor 只能放在Actor下实现接口", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			aactor.SetActorTickEnabled(false);
			this.MediaActors.Add(sceneBp);
			return;
		}
		else if (groupTag == this.MEDIA_ACTOR_GROUP_EXTRA)
		{
			AActor aactor2 = sceneBp as AActor;
			if (aactor2 == null)
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "BpActorController MediaActor_Extra 只能放在Actor下实现接口", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			aactor2.SetActorTickEnabled(false);
			this.MediaActors_Extra.Add(sceneBp);
			return;
		}
		else if (groupTag == this.MEDIA_ACTOR_GROUP_SPECIAL)
		{
			MediaPlayForModel_Special_C mediaPlayForModel_Special_C = sceneBp as MediaPlayForModel_Special_C;
			if (mediaPlayForModel_Special_C == null)
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.CK, "[BpActorController] RegisterBpActor 失败: Actor类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			mediaPlayForModel_Special_C.SetActorTickEnabled(false);
			this.RegisterMediaActors_Special.Add(mediaPlayForModel_Special_C);
			this.TryLoadSpecialMediaActorAsset().Forget();
			return;
		}
		else
		{
			if (!(groupTag == this.SCENE_CAPTURE_3TO2_GROUP))
			{
				Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "SceneBp 注册失败,没有对应的处理类型", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UObject item = sceneBp as UObject;
			BP_SceneCapture_3To2_C bp_SceneCapture_3To2_C = sceneBp as BP_SceneCapture_3To2_C;
			if (bp_SceneCapture_3To2_C == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.HF;
				string message = "[BpActorController] SceneCapture_3To2 Actor类型错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SceneBpActor", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.LoadSceneCapture3To2Rt(bp_SceneCapture_3To2_C).Forget();
			return;
		}
	}

	// Token: 0x0601B62D RID: 112173 RVA: 0x008683DC File Offset: 0x008665DC
	private UniTask LoadSceneCapture3To2Rt(BP_SceneCapture_3To2_C actor)
	{
		BpActorController.<LoadSceneCapture3To2Rt>d__47 <LoadSceneCapture3To2Rt>d__;
		<LoadSceneCapture3To2Rt>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSceneCapture3To2Rt>d__.actor = actor;
		<LoadSceneCapture3To2Rt>d__.<>1__state = -1;
		<LoadSceneCapture3To2Rt>d__.<>t__builder.Start<BpActorController.<LoadSceneCapture3To2Rt>d__47>(ref <LoadSceneCapture3To2Rt>d__);
		return <LoadSceneCapture3To2Rt>d__.<>t__builder.Task;
	}

	// Token: 0x0601B62E RID: 112174 RVA: 0x00868420 File Offset: 0x00866620
	public unsafe void UnregisterBpActor(FName groupTag, IBPI_SceneBp_C sceneBp)
	{
		if (sceneBp == null)
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "BpActorController sceneBp 是空的", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (groupTag == this.MEDIA_ACTOR_GROUP)
		{
			if (!(sceneBp is AActor))
			{
				return;
			}
			this.MediaActors.Remove(sceneBp);
			if (this.MediaActors.Count == 0)
			{
				AActor aactor = this.LastActiveMediaActor as AActor;
				if (aactor != null && aactor.IsValid())
				{
					this.LastActiveMediaActor.Stop();
					this.LastActiveMediaActor = null;
				}
			}
			return;
		}
		else if (groupTag == this.MEDIA_ACTOR_GROUP_EXTRA)
		{
			if (!(sceneBp is AActor))
			{
				return;
			}
			this.MediaActors_Extra.Remove(sceneBp);
			if (this.MediaActors_Extra.Count == 0)
			{
				AActor aactor2 = this.LastActiveMediaActor_Extra as AActor;
				if (aactor2 != null && aactor2.IsValid())
				{
					this.LastActiveMediaActor_Extra.Stop();
					this.LastActiveMediaActor_Extra = null;
				}
			}
			return;
		}
		else if (groupTag == this.MEDIA_ACTOR_GROUP_SPECIAL)
		{
			MediaPlayForModel_Special_C mediaPlayForModel_Special_C = sceneBp as MediaPlayForModel_Special_C;
			if (mediaPlayForModel_Special_C == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.World;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[BpActorController] UnregisterBpActor失败: Actor类型错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SceneBpActor", sceneBp);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GroupTag", groupTag);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.RegisterMediaActors_Special.Remove(mediaPlayForModel_Special_C);
			ValueTuple<bool, bool> valueTuple = this.RemovePendingSpecialMediaActor(mediaPlayForModel_Special_C);
			PDA_MediaPlayDataAsset_C mediaPlayDataAsset = mediaPlayForModel_Special_C.MediaPlayDataAsset;
			BpActorController.ActiveResourceGroup activeResourceGroup2;
			BpActorController.ActiveResourceGroup activeResourceGroup = (mediaPlayDataAsset != null) ? (this.ActiveResourceGroups.TryGetValue(mediaPlayDataAsset, out activeResourceGroup2) ? activeResourceGroup2 : null) : null;
			if (activeResourceGroup != null && activeResourceGroup.Actors.Remove(mediaPlayForModel_Special_C))
			{
				if (activeResourceGroup.Actors.Count == 0 || mediaPlayForModel_Special_C.IsMainPlayer)
				{
					this.ActiveResourceGroups.Remove(mediaPlayDataAsset);
					this.PendingReleaseMediaActors_Special.Add(mediaPlayForModel_Special_C);
				}
			}
			else if (!valueTuple.Item1)
			{
				bool item = valueTuple.Item2;
			}
			if (this.RegisterMediaActors_Special.Count == 0)
			{
				foreach (BpActorController.ActiveResourceGroup activeResourceGroup3 in this.ActiveResourceGroups.Values)
				{
					foreach (MediaPlayForModel_Special_C mediaPlayForModel_Special_C2 in activeResourceGroup3.Actors)
					{
						if (mediaPlayForModel_Special_C2 != null && mediaPlayForModel_Special_C2.IsValid())
						{
							mediaPlayForModel_Special_C2.Stop();
						}
					}
				}
				this.ActiveResourceGroups.Clear();
				this.PendingPlayMediaActors_Special.Clear();
				this.PendingCloseMediaActors_Special.Clear();
				this.PendingReleaseMediaActors_Special.Clear();
				this.AvailableMediaPlayerPool.Clear();
				this.AvailableMediaTexturePool.Clear();
				this.SpecialActorAssetLoadCompleted = false;
				this.LoadingSpecialActorAsset = false;
			}
			return;
		}
		else
		{
			if (groupTag == this.SCENE_CAPTURE_3TO2_GROUP)
			{
				return;
			}
			Log.Instance.Error(ELogModule.World, ELogAuthor.ZWY, "SceneBp 反注册失败,没有对应的处理类型", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
	}

	// Token: 0x0601B62F RID: 112175 RVA: 0x00868738 File Offset: 0x00866938
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"PendingPlayRemoved",
		"PendingCloseRemoved"
	})]
	private ValueTuple<bool, bool> RemovePendingSpecialMediaActor([Nullable(1)] MediaPlayForModel_Special_C actor)
	{
		int num = this.PendingPlayMediaActors_Special.IndexOf(actor);
		bool flag = num != -1;
		if (flag)
		{
			this.PendingPlayMediaActors_Special.RemoveAt(num);
		}
		int num2 = this.PendingCloseMediaActors_Special.IndexOf(actor);
		bool flag2 = num2 != -1;
		if (flag2)
		{
			this.PendingCloseMediaActors_Special.RemoveAt(num2);
		}
		return new ValueTuple<bool, bool>(flag, flag2);
	}

	// Token: 0x0601B630 RID: 112176 RVA: 0x00868792 File Offset: 0x00866992
	private bool CheckDayState()
	{
		return TimeOfDayController.Instance.CheckInMinuteSpan(360, 1080);
	}

	// Token: 0x0601B631 RID: 112177 RVA: 0x008687A8 File Offset: 0x008669A8
	public void RegisterDayNightActor(IBPI_DayNightEvent_C dayNightBp)
	{
		if (!this.DayNightActors.Contains(dayNightBp))
		{
			this.DayNightActors.Add(dayNightBp);
			if (this.CheckDayState())
			{
				dayNightBp.OnEnterDay();
				return;
			}
			dayNightBp.OnEnterNight();
		}
	}

	// Token: 0x0601B632 RID: 112178 RVA: 0x008687DA File Offset: 0x008669DA
	public void UnregisterDayNightActor(IBPI_DayNightEvent_C dayNightBp)
	{
		if (this.DayNightActors.Contains(dayNightBp))
		{
			this.DayNightActors.Remove(dayNightBp);
		}
	}

	// Token: 0x0601B633 RID: 112179 RVA: 0x008687F8 File Offset: 0x008669F8
	public unsafe bool PendingPlayMedia_Special(MediaPlayForModel_Special_C actor, int? pbDataId)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] PendingPlayMedia_Special失败: Actor无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", actor);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (!this.RegisterMediaActors_Special.Contains(actor))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[BpActorController] PendingPlayMedia_Special失败: Actor未注册";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Actor", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("DataAsset", actor.MediaPlayDataAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
			return false;
		}
		PDA_MediaPlayDataAsset_C mediaPlayDataAsset = actor.MediaPlayDataAsset;
		if (mediaPlayDataAsset == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.World;
			ELogAuthor author3 = ELogAuthor.CK;
			string message3 = "[BpActorController] PendingPlayMedia_Special失败: Actor没有MediaPlayDataAsset";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Actor", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return false;
		}
		BpActorController.ActiveResourceGroup activeResourceGroup;
		this.ActiveResourceGroups.TryGetValue(mediaPlayDataAsset, out activeResourceGroup);
		if (activeResourceGroup != null && activeResourceGroup.Actors.Contains(actor))
		{
			int num = this.PendingCloseMediaActors_Special.IndexOf(actor);
			if (num != -1)
			{
				this.PendingCloseMediaActors_Special.RemoveAt(num);
				return true;
			}
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.World;
			ELogAuthor author4 = ELogAuthor.CK;
			string message4 = "[BpActorController] PendingPlayMedia_Special忽略: Actor已在播放中";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Actor", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("DataAsset", mediaPlayDataAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
			instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 4));
			return true;
		}
		else
		{
			if (this.DebugSpecialMediaSingleModeEnabled)
			{
				return this.DebugImmediatePlayMedia_Special(actor, mediaPlayDataAsset, pbDataId);
			}
			if (!this.PendingPlayMediaActors_Special.Contains(actor))
			{
				this.PendingPlayMediaActors_Special.Add(actor);
			}
			return true;
		}
	}

	// Token: 0x0601B634 RID: 112180 RVA: 0x00868AAC File Offset: 0x00866CAC
	public unsafe bool PendingStopMedia_Special(MediaPlayForModel_Special_C actor, int? pbDataId, BpActorController.EPendingStopReason reason = BpActorController.EPendingStopReason.ManualControl)
	{
		if (actor == null || !actor.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] PendingStopMedia_Special失败: Actor无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", actor);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		PDA_MediaPlayDataAsset_C mediaPlayDataAsset = actor.MediaPlayDataAsset;
		if (mediaPlayDataAsset == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[BpActorController] PendingStopMedia_Special失败: Actor没有MediaPlayDataAsset";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Actor", actor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return true;
		}
		if (this.DebugSpecialMediaSingleModeEnabled)
		{
			return this.DebugImmediateStopMedia_Special(actor, mediaPlayDataAsset, pbDataId, reason);
		}
		BpActorController.ActiveResourceGroup activeResourceGroup;
		if (this.ActiveResourceGroups.TryGetValue(mediaPlayDataAsset, out activeResourceGroup) && activeResourceGroup.Actors.Contains(actor))
		{
			if (!this.PendingCloseMediaActors_Special.Contains(actor))
			{
				this.PendingCloseMediaActors_Special.Add(actor);
			}
			return true;
		}
		int num = this.PendingPlayMediaActors_Special.IndexOf(actor);
		if (num != -1)
		{
			this.PendingPlayMediaActors_Special.RemoveAt(num);
			return true;
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.World;
		ELogAuthor author3 = ELogAuthor.CK;
		string message3 = "[BpActorController] PendingStopMedia_Special失败: Actor无需停止";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Actor", actor);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("DataAsset", mediaPlayDataAsset);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("IsMainPlayer", actor.IsMainPlayer);
		instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
		return true;
	}

	// Token: 0x0601B635 RID: 112181 RVA: 0x00868CB0 File Offset: 0x00866EB0
	private UniTask TryLoadSpecialMediaActorAsset()
	{
		BpActorController.<TryLoadSpecialMediaActorAsset>d__55 <TryLoadSpecialMediaActorAsset>d__;
		<TryLoadSpecialMediaActorAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLoadSpecialMediaActorAsset>d__.<>4__this = this;
		<TryLoadSpecialMediaActorAsset>d__.<>1__state = -1;
		<TryLoadSpecialMediaActorAsset>d__.<>t__builder.Start<BpActorController.<TryLoadSpecialMediaActorAsset>d__55>(ref <TryLoadSpecialMediaActorAsset>d__);
		return <TryLoadSpecialMediaActorAsset>d__.<>t__builder.Task;
	}

	// Token: 0x0601B636 RID: 112182 RVA: 0x00868CF4 File Offset: 0x00866EF4
	private void CheckDayNightChange()
	{
		if (this.DayNightActors.Count < 0)
		{
			return;
		}
		if (this.IsDayState == null)
		{
			this.IsDayState = new bool?(this.CheckDayState());
			return;
		}
		bool flag = this.CheckDayState();
		bool? isDayState = this.IsDayState;
		bool flag2 = flag;
		if (!(isDayState.GetValueOrDefault() == flag2 & isDayState != null))
		{
			this.IsDayState = new bool?(flag);
			if (flag)
			{
				using (HashSet<IBPI_DayNightEvent_C>.Enumerator enumerator = this.DayNightActors.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IBPI_DayNightEvent_C ibpi_DayNightEvent_C = enumerator.Current;
						AActor aactor = ibpi_DayNightEvent_C as AActor;
						if (aactor != null && aactor.IsValid())
						{
							ibpi_DayNightEvent_C.OnEnterDay();
						}
						else
						{
							this.PendingRemoveDayNightActors.Add(ibpi_DayNightEvent_C);
						}
					}
					goto IL_11E;
				}
			}
			foreach (IBPI_DayNightEvent_C ibpi_DayNightEvent_C2 in this.DayNightActors)
			{
				AActor aactor2 = ibpi_DayNightEvent_C2 as AActor;
				if (aactor2 != null && aactor2.IsValid())
				{
					ibpi_DayNightEvent_C2.OnEnterNight();
				}
				else
				{
					this.PendingRemoveDayNightActors.Add(ibpi_DayNightEvent_C2);
				}
			}
			IL_11E:
			if (this.PendingRemoveDayNightActors.Count > 0)
			{
				foreach (IBPI_DayNightEvent_C item in this.PendingRemoveDayNightActors)
				{
					this.DayNightActors.Remove(item);
				}
				this.PendingRemoveDayNightActors.Clear();
			}
		}
	}

	// Token: 0x0601B637 RID: 112183 RVA: 0x00868EA0 File Offset: 0x008670A0
	protected override void OnTick(float delta)
	{
		this.CheckMediaActor();
		this.CheckDayNightChange();
	}

	// Token: 0x0601B638 RID: 112184 RVA: 0x00868EB0 File Offset: 0x008670B0
	private void CheckMediaActor()
	{
		if (this.MediaActors.Count > 0 || this.MediaActors_Extra.Count > 0)
		{
			if (this.DebugMediaDisabled)
			{
				return;
			}
			this.BpMediaActorTickInternal++;
			if (this.BpMediaActorTickInternal > 30)
			{
				this.BpMediaActorTickInternal = 0;
			}
			if (this.MediaActors.Count > 0)
			{
				if (this.BpMediaActorTickInternal == 10)
				{
					this.CheckMediaActorClose();
					return;
				}
				if (this.BpMediaActorTickInternal == 15)
				{
					this.CheckMediaActorPlay();
					return;
				}
			}
			if (this.MediaActors_Extra.Count > 0)
			{
				if (this.BpMediaActorTickInternal == 20)
				{
					this.CheckMediaActorClose_Extra();
					return;
				}
				if (this.BpMediaActorTickInternal == 25)
				{
					this.CheckMediaActorPlay_Extra();
				}
			}
		}
		if (this.RegisterMediaActors_Special.Count > 0)
		{
			if (this.DebugSpecialMediaDisabled)
			{
				return;
			}
			if (!this.SpecialActorAssetLoadCompleted)
			{
				return;
			}
			this.HandleMediaActor_Special_OutOfAOI();
			this.FrameCounter++;
			if (this.FrameCounter >= 5)
			{
				this.FrameCounter = 0;
				this.ProcessMediaActorOneAction();
			}
		}
	}

	// Token: 0x0601B639 RID: 112185 RVA: 0x00868FB0 File Offset: 0x008671B0
	private unsafe void HandleMediaActor_Special_OutOfAOI()
	{
		Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
		foreach (KeyValuePair<PDA_MediaPlayDataAsset_C, BpActorController.ActiveResourceGroup> keyValuePair in this.ActiveResourceGroups)
		{
			PDA_MediaPlayDataAsset_C pda_MediaPlayDataAsset_C;
			BpActorController.ActiveResourceGroup activeResourceGroup;
			keyValuePair.Deconstruct(out pda_MediaPlayDataAsset_C, out activeResourceGroup);
			PDA_MediaPlayDataAsset_C item = pda_MediaPlayDataAsset_C;
			foreach (MediaPlayForModel_Special_C mediaPlayForModel_Special_C in activeResourceGroup.Actors)
			{
				if (mediaPlayForModel_Special_C.IsValid())
				{
					Vector vector = Vector.Create();
					Vector vector2 = vector;
					FVectorDouble fvectorDouble = mediaPlayForModel_Special_C.D_K2_GetActorLocation();
					vector2.FromUeVector(fvectorDouble);
					double num = Vector.Dist(cameraLocation, vector);
					int aoiRange = this.GetAoiRange(mediaPlayForModel_Special_C);
					if (aoiRange > 0 && (double)aoiRange < num && !this.PendingCloseMediaActors_Special.Contains(mediaPlayForModel_Special_C))
					{
						this.PendingStopMedia_Special(mediaPlayForModel_Special_C, null, BpActorController.EPendingStopReason.OutOfAOI);
						Log instance = Log.Instance;
						ELogModule module = ELogModule.World;
						ELogAuthor author = ELogAuthor.CK;
						string message = "[BpActorController] CheckMediaActor_Special_OutOfAOI: Actor超出AOI范围, 停止播放";
						<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", mediaPlayForModel_Special_C);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DataAsset", item);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Distance", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AoiRange", aoiRange);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IsMainPlayer", mediaPlayForModel_Special_C.IsMainPlayer);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
					}
				}
			}
		}
	}

	// Token: 0x0601B63A RID: 112186 RVA: 0x008691A4 File Offset: 0x008673A4
	private bool CheckMediaActor_Special_InAOI(MediaPlayForModel_Special_C actor)
	{
		if (!actor.IsValid())
		{
			return false;
		}
		Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
		Vector vector = Vector.Create();
		Vector vector2 = vector;
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		vector2.FromUeVector(fvectorDouble);
		double num = Vector.Dist(cameraLocation, vector);
		int aoiRange = this.GetAoiRange(actor);
		return aoiRange == 0 || num <= (double)aoiRange;
	}

	// Token: 0x0601B63B RID: 112187 RVA: 0x008691FC File Offset: 0x008673FC
	private bool HasPendingReleaseMediaResource()
	{
		this.TempInvalidReleaseActors.Clear();
		foreach (MediaPlayForModel_Special_C mediaPlayForModel_Special_C in this.PendingReleaseMediaActors_Special)
		{
			if (mediaPlayForModel_Special_C == null || !mediaPlayForModel_Special_C.IsValid())
			{
				this.TempInvalidReleaseActors.Add(mediaPlayForModel_Special_C);
			}
		}
		foreach (MediaPlayForModel_Special_C item in this.TempInvalidReleaseActors)
		{
			this.PendingReleaseMediaActors_Special.Remove(item);
		}
		return this.PendingReleaseMediaActors_Special.Count > 0;
	}

	// Token: 0x0601B63C RID: 112188 RVA: 0x008692C8 File Offset: 0x008674C8
	private unsafe void ProcessMediaActorOneAction()
	{
		if (this.PendingCloseMediaActors_Special.Count > 0)
		{
			MediaPlayForModel_Special_C mediaPlayForModel_Special_C = this.PendingCloseMediaActors_Special[0];
			this.PendingCloseMediaActors_Special.RemoveAt(0);
			if (mediaPlayForModel_Special_C != null && mediaPlayForModel_Special_C.IsValid())
			{
				PDA_MediaPlayDataAsset_C mediaPlayDataAsset = mediaPlayForModel_Special_C.MediaPlayDataAsset;
				BpActorController.ActiveResourceGroup activeResourceGroup;
				if (mediaPlayDataAsset != null && this.ActiveResourceGroups.TryGetValue(mediaPlayDataAsset, out activeResourceGroup) && activeResourceGroup != null)
				{
					activeResourceGroup.Actors.Remove(mediaPlayForModel_Special_C);
					if (activeResourceGroup.Actors.Count == 0)
					{
						this.ActiveResourceGroups.Remove(mediaPlayDataAsset);
						this.PendingReleaseMediaActors_Special.Add(mediaPlayForModel_Special_C);
						mediaPlayForModel_Special_C.Stop();
						return;
					}
					mediaPlayForModel_Special_C.Stop();
				}
			}
			return;
		}
		if (this.PendingPlayMediaActors_Special.Count > 0)
		{
			MediaPlayForModel_Special_C mediaPlayForModel_Special_C = this.PendingPlayMediaActors_Special[0];
			this.PendingPlayMediaActors_Special.RemoveAt(0);
			if (mediaPlayForModel_Special_C != null && mediaPlayForModel_Special_C.IsValid())
			{
				PDA_MediaPlayDataAsset_C mediaPlayDataAsset2 = mediaPlayForModel_Special_C.MediaPlayDataAsset;
				if (mediaPlayDataAsset2 != null)
				{
					if (!this.RegisterMediaActors_Special.Contains(mediaPlayForModel_Special_C))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.World;
						ELogAuthor author = ELogAuthor.CK;
						string message = "[BpActorController] ProcessMediaActorOneAction: Actor已反注册, 跳过待播放请求";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", mediaPlayForModel_Special_C);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DataAsset", mediaPlayForModel_Special_C.MediaPlayDataAsset);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsMainPlayer", mediaPlayForModel_Special_C.IsMainPlayer);
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						return;
					}
					if (!this.CheckMediaActor_Special_InAOI(mediaPlayForModel_Special_C))
					{
						this.PendingPlayMediaActors_Special.Add(mediaPlayForModel_Special_C);
						return;
					}
					BpActorController.ActiveResourceGroup activeResourceGroup2;
					if (this.ActiveResourceGroups.TryGetValue(mediaPlayDataAsset2, out activeResourceGroup2))
					{
						if (activeResourceGroup2.Actors.Contains(mediaPlayForModel_Special_C))
						{
							return;
						}
						mediaPlayForModel_Special_C.AllocatePlayerAsset(activeResourceGroup2.MediaPlayer, activeResourceGroup2.MediaTexture);
						mediaPlayForModel_Special_C.IsMainPlayer = false;
						mediaPlayForModel_Special_C.Start();
						activeResourceGroup2.Actors.Add(mediaPlayForModel_Special_C);
						return;
					}
					else
					{
						if (this.ActiveResourceGroups.Count >= 5)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.World;
							ELogAuthor author2 = ELogAuthor.CK;
							string message2 = "[BpActorController] ProcessMediaActorOneAction: 资源组已满, 无法分配新资源";
							<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("当前资源组数量", this.ActiveResourceGroups.Count);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("最大资源组数量", 5);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Actor", mediaPlayForModel_Special_C);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("DataAsset", mediaPlayDataAsset2);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("IsMainPlayer", mediaPlayForModel_Special_C.IsMainPlayer);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
							return;
						}
						if ((this.AvailableMediaPlayerPool.Count == 0 || this.AvailableMediaTexturePool.Count == 0) && this.HasPendingReleaseMediaResource())
						{
							this.PendingPlayMediaActors_Special.Add(mediaPlayForModel_Special_C);
							return;
						}
						if (this.AllocateToMediaPlayActor(mediaPlayForModel_Special_C))
						{
							UMediaPlayer shareMediaPlayer = mediaPlayForModel_Special_C.ShareMediaPlayer;
							UMediaTexture shareMediaTexture = mediaPlayForModel_Special_C.ShareMediaTexture;
							if (shareMediaPlayer != null && shareMediaTexture != null)
							{
								BpActorController.ActiveResourceGroup value = new BpActorController.ActiveResourceGroup(shareMediaPlayer, shareMediaTexture, new HashSet<MediaPlayForModel_Special_C>
								{
									mediaPlayForModel_Special_C
								});
								this.ActiveResourceGroups[mediaPlayDataAsset2] = value;
								mediaPlayForModel_Special_C.IsMainPlayer = true;
								mediaPlayForModel_Special_C.Start();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0601B63D RID: 112189 RVA: 0x008695F8 File Offset: 0x008677F8
	private unsafe bool AllocateToMediaPlayActor(MediaPlayForModel_Special_C actor)
	{
		if (this.AvailableMediaPlayerPool.Count == 0 || this.AvailableMediaTexturePool.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] AllocateToMediaPlayActor失败: 没有可用的资源";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AvailableMediaPlayerPool", this.AvailableMediaPlayerPool.Count);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AvailableMediaTexturePool", this.AvailableMediaTexturePool.Count);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		UMediaPlayer umediaPlayer = this.AvailableMediaPlayerPool[this.AvailableMediaPlayerPool.Count - 1];
		this.AvailableMediaPlayerPool.RemoveAt(this.AvailableMediaPlayerPool.Count - 1);
		UMediaTexture umediaTexture = this.AvailableMediaTexturePool[this.AvailableMediaTexturePool.Count - 1];
		this.AvailableMediaTexturePool.RemoveAt(this.AvailableMediaTexturePool.Count - 1);
		umediaTexture.SetMediaPlayer(umediaPlayer);
		actor.AllocatePlayerAsset(umediaPlayer, umediaTexture);
		return true;
	}

	// Token: 0x0601B63E RID: 112190 RVA: 0x00869704 File Offset: 0x00867904
	public unsafe void ReleaseFromMediaPlayActor(IBPI_SceneBp_C sceneBpActor)
	{
		MediaPlayForModel_Special_C mediaPlayForModel_Special_C = sceneBpActor as MediaPlayForModel_Special_C;
		if (mediaPlayForModel_Special_C == null || !mediaPlayForModel_Special_C.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[BpActorController] ReleaseFromMediaPlayActor失败: sceneBpActor类型错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SceneBpActor", sceneBpActor);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.PendingReleaseMediaActors_Special.Remove(mediaPlayForModel_Special_C);
		UMediaPlayer shareMediaPlayer = mediaPlayForModel_Special_C.ShareMediaPlayer;
		UMediaTexture shareMediaTexture = mediaPlayForModel_Special_C.ShareMediaTexture;
		PDA_MediaPlayDataAsset_C mediaPlayDataAsset = mediaPlayForModel_Special_C.MediaPlayDataAsset;
		if (shareMediaPlayer == null || shareMediaTexture == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.World;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[BpActorController] ReleaseFromMediaPlayActor失败: player或texture为空";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", mediaPlayForModel_Special_C);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DataAsset", mediaPlayDataAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ShareMediaPlayer", shareMediaPlayer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ShareMediaTexture", shareMediaTexture);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IsMainPlayer", mediaPlayForModel_Special_C.IsMainPlayer);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		if (this.DebugSpecialMediaSingleModeEnabled)
		{
			return;
		}
		BpActorController.ActiveResourceGroup activeResourceGroup = (mediaPlayDataAsset != null) ? this.ActiveResourceGroups.GetValueOrDefault(mediaPlayDataAsset) : null;
		if (((activeResourceGroup != null) ? activeResourceGroup.MediaPlayer : null) == shareMediaPlayer && activeResourceGroup.MediaTexture == shareMediaTexture)
		{
			return;
		}
		this.AvailableMediaPlayerPool.Add(shareMediaPlayer);
		this.AvailableMediaTexturePool.Add(shareMediaTexture);
		shareMediaTexture.SetMediaPlayer(null);
	}

	// Token: 0x0601B63F RID: 112191 RVA: 0x00869874 File Offset: 0x00867A74
	private int GetAoiRange(IBPI_SceneBp_C actor)
	{
		int result = 0;
		actor.GetAoiRange(ref result);
		return result;
	}

	// Token: 0x0601B640 RID: 112192 RVA: 0x0086988C File Offset: 0x00867A8C
	private bool GetShouldStopOnHide(IBPI_SceneBp_C actor)
	{
		bool result = false;
		actor.ShouldStopOnHide(ref result);
		return result;
	}

	// Token: 0x0601B641 RID: 112193 RVA: 0x008698A4 File Offset: 0x00867AA4
	private void CheckMediaActorClose()
	{
		if (this.MediaActors.Count > 0)
		{
			AActor aactor = this.LastActiveMediaActor as AActor;
			if (aactor != null && aactor.IsValid())
			{
				IBPI_SceneBp_C ibpi_SceneBp_C = null;
				Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
				double num = double.MaxValue;
				foreach (IBPI_SceneBp_C ibpi_SceneBp_C2 in this.MediaActors)
				{
					AActor aactor2 = ibpi_SceneBp_C2 as AActor;
					Vector vector = Vector.Create();
					Vector vector2 = vector;
					FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
					vector2.FromUeVector(fvectorDouble);
					double num2 = Vector.Dist(cameraLocation, vector);
					if (num2 < num && !this.GetShouldStopOnHide(ibpi_SceneBp_C2))
					{
						num = num2;
						ibpi_SceneBp_C = ibpi_SceneBp_C2;
					}
				}
				AActor aactor3 = ibpi_SceneBp_C as AActor;
				if (aactor3 != null && aactor3.IsValid() && this.LastActiveMediaActor == ibpi_SceneBp_C)
				{
					int aoiRange = this.GetAoiRange(ibpi_SceneBp_C);
					if (aoiRange > 0 && (double)(aoiRange + 1000) < num)
					{
						this.LastActiveMediaActor.Stop();
						this.LastActiveMediaActor = null;
						return;
					}
				}
				else
				{
					this.LastActiveMediaActor.Stop();
					this.LastActiveMediaActor = null;
				}
			}
		}
	}

	// Token: 0x0601B642 RID: 112194 RVA: 0x008699DC File Offset: 0x00867BDC
	private void CheckMediaActorPlay()
	{
		if (this.MediaActors.Count > 0)
		{
			AActor aactor = this.LastActiveMediaActor as AActor;
			if (aactor == null || !aactor.IsValid())
			{
				IBPI_SceneBp_C ibpi_SceneBp_C = null;
				Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
				double num = double.MaxValue;
				foreach (IBPI_SceneBp_C ibpi_SceneBp_C2 in this.MediaActors)
				{
					AActor aactor2 = ibpi_SceneBp_C2 as AActor;
					Vector vector = Vector.Create();
					Vector vector2 = vector;
					FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
					vector2.FromUeVector(fvectorDouble);
					double num2 = Vector.DistSquared(cameraLocation, vector);
					if (num2 < num && !this.GetShouldStopOnHide(ibpi_SceneBp_C2))
					{
						num = num2;
						ibpi_SceneBp_C = ibpi_SceneBp_C2;
					}
				}
				AActor aactor3 = ibpi_SceneBp_C as AActor;
				if (aactor3 == null || !aactor3.IsValid())
				{
					return;
				}
				num = Math.Sqrt(num);
				int aoiRange = this.GetAoiRange(ibpi_SceneBp_C);
				if (aoiRange > 0 && (double)aoiRange > num)
				{
					ibpi_SceneBp_C.Start();
					this.LastActiveMediaActor = ibpi_SceneBp_C;
				}
			}
		}
	}

	// Token: 0x0601B643 RID: 112195 RVA: 0x00869AF0 File Offset: 0x00867CF0
	private void CheckMediaActorClose_Extra()
	{
		if (this.MediaActors_Extra.Count > 0)
		{
			AActor aactor = this.LastActiveMediaActor_Extra as AActor;
			if (aactor != null && aactor.IsValid())
			{
				IBPI_SceneBp_C ibpi_SceneBp_C = null;
				Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
				double num = double.MaxValue;
				foreach (IBPI_SceneBp_C ibpi_SceneBp_C2 in this.MediaActors_Extra)
				{
					AActor aactor2 = ibpi_SceneBp_C2 as AActor;
					Vector vector = Vector.Create();
					Vector vector2 = vector;
					FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
					vector2.FromUeVector(fvectorDouble);
					double num2 = Vector.Dist(cameraLocation, vector);
					if (num2 < num && !this.GetShouldStopOnHide(ibpi_SceneBp_C2))
					{
						num = num2;
						ibpi_SceneBp_C = ibpi_SceneBp_C2;
					}
				}
				AActor aactor3 = ibpi_SceneBp_C as AActor;
				if (aactor3 != null && aactor3.IsValid() && this.LastActiveMediaActor_Extra == ibpi_SceneBp_C)
				{
					int aoiRange = this.GetAoiRange(ibpi_SceneBp_C);
					if (aoiRange > 0 && (double)(aoiRange + 1000) < num)
					{
						this.LastActiveMediaActor_Extra.Stop();
						this.LastActiveMediaActor_Extra = null;
						return;
					}
				}
				else
				{
					this.LastActiveMediaActor_Extra.Stop();
					this.LastActiveMediaActor_Extra = null;
				}
			}
		}
	}

	// Token: 0x0601B644 RID: 112196 RVA: 0x00869C28 File Offset: 0x00867E28
	private void CheckMediaActorPlay_Extra()
	{
		if (this.MediaActors_Extra.Count > 0)
		{
			AActor aactor = this.LastActiveMediaActor_Extra as AActor;
			if (aactor == null || !aactor.IsValid())
			{
				IBPI_SceneBp_C ibpi_SceneBp_C = null;
				Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
				double num = double.MaxValue;
				foreach (IBPI_SceneBp_C ibpi_SceneBp_C2 in this.MediaActors_Extra)
				{
					AActor aactor2 = ibpi_SceneBp_C2 as AActor;
					Vector vector = Vector.Create();
					Vector vector2 = vector;
					FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
					vector2.FromUeVector(fvectorDouble);
					double num2 = Vector.DistSquared(cameraLocation, vector);
					if (num2 < num && !this.GetShouldStopOnHide(ibpi_SceneBp_C2))
					{
						num = num2;
						ibpi_SceneBp_C = ibpi_SceneBp_C2;
					}
				}
				AActor aactor3 = ibpi_SceneBp_C as AActor;
				if (aactor3 == null || !aactor3.IsValid())
				{
					return;
				}
				num = Math.Sqrt(num);
				int aoiRange = this.GetAoiRange(ibpi_SceneBp_C);
				if (aoiRange > 0 && (double)aoiRange > num)
				{
					ibpi_SceneBp_C.Start();
					this.LastActiveMediaActor_Extra = ibpi_SceneBp_C;
				}
			}
		}
	}

	// Token: 0x17002C77 RID: 11383
	// (get) Token: 0x0601B645 RID: 112197 RVA: 0x00869D3C File Offset: 0x00867F3C
	public static BpActorController Instance
	{
		get
		{
			return BpActorController._Instance;
		}
	}

	// Token: 0x0601B646 RID: 112198 RVA: 0x00869D43 File Offset: 0x00867F43
	public static BpActorController GetOrCreateInstance()
	{
		if (BpActorController._Instance == null)
		{
			BpActorController.CreateInstance();
		}
		return BpActorController._Instance;
	}

	// Token: 0x0601B647 RID: 112199 RVA: 0x00869D57 File Offset: 0x00867F57
	public static bool CreateInstance()
	{
		if (BpActorController._Instance != null)
		{
			return true;
		}
		BpActorController._Instance = new BpActorController();
		return true;
	}

	// Token: 0x0601B648 RID: 112200 RVA: 0x00869D6D File Offset: 0x00867F6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B649 RID: 112201 RVA: 0x00869D6F File Offset: 0x00867F6F
	public static void ResetStaticDefaultValue()
	{
		BpActorController._Instance = null;
	}

	// Token: 0x0601B64A RID: 112202 RVA: 0x00869D77 File Offset: 0x00867F77
	static BpActorController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BpActorController.CreateStaticDefaultValue), new Action(BpActorController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ECE6 RID: 60646
	private const int AOI_OFFSET = 1000;

	// Token: 0x0400ECE7 RID: 60647
	private const int MEDIA_ACTOR_TICK_FEQ = 30;

	// Token: 0x0400ECE8 RID: 60648
	private readonly FName MEDIA_ACTOR_GROUP = new FName("MediaActor");

	// Token: 0x0400ECE9 RID: 60649
	private const int MEDIA_ACTOR_CHECKFRAME_CLOSE = 10;

	// Token: 0x0400ECEA RID: 60650
	private const int MEDIA_ACTOR_CHECKFRAME_PLAY = 15;

	// Token: 0x0400ECEB RID: 60651
	private readonly FName MEDIA_ACTOR_GROUP_EXTRA = new FName("MediaActor_Extra");

	// Token: 0x0400ECEC RID: 60652
	private const int MEDIA_ACTOR_EXTRA_CHECKFRAME_CLOSE = 20;

	// Token: 0x0400ECED RID: 60653
	private const int MEDIA_ACTOR_EXTRA_CHECKFRAME_PLAY = 25;

	// Token: 0x0400ECEE RID: 60654
	private readonly FName MEDIA_ACTOR_GROUP_SPECIAL = new FName("MediaActor_Special");

	// Token: 0x0400ECEF RID: 60655
	private readonly FName SCENE_CAPTURE_3TO2_GROUP = new FName("SceneCapture_3To2");

	// Token: 0x0400ECF0 RID: 60656
	private const int MEDIA_ACTOR_SPECIAL_MAX_ACTIVE = 5;

	// Token: 0x0400ECF1 RID: 60657
	private const int MEDIA_ACTOR_SPECIAL_FRAMES_PER_ACTION = 5;

	// Token: 0x0400ECF2 RID: 60658
	private const string SpecialMediaActorAssetPoolDAPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/SpecialMediaPlayActorAsset.SpecialMediaPlayActorAsset";

	// Token: 0x0400ECF3 RID: 60659
	private const int DAY_MINITE_START = 360;

	// Token: 0x0400ECF4 RID: 60660
	private const int DAY_MINITE_END = 1080;

	// Token: 0x0400ECF5 RID: 60661
	public bool DebugMediaDisabled;

	// Token: 0x0400ECF6 RID: 60662
	public bool DebugSpecialMediaDisabled;

	// Token: 0x0400ECF7 RID: 60663
	public bool DebugSpecialMediaSingleModeEnabled;

	// Token: 0x0400ECF8 RID: 60664
	[Nullable(2)]
	private UMediaPlayer DebugFixedMediaPlayer;

	// Token: 0x0400ECF9 RID: 60665
	[Nullable(2)]
	private UMediaTexture DebugFixedMediaTexture;

	// Token: 0x0400ECFA RID: 60666
	private int BpMediaActorTickInternal;

	// Token: 0x0400ECFB RID: 60667
	private readonly HashSet<IBPI_SceneBp_C> MediaActors = new HashSet<IBPI_SceneBp_C>();

	// Token: 0x0400ECFC RID: 60668
	[Nullable(2)]
	private IBPI_SceneBp_C LastActiveMediaActor;

	// Token: 0x0400ECFD RID: 60669
	private readonly HashSet<IBPI_SceneBp_C> MediaActors_Extra = new HashSet<IBPI_SceneBp_C>();

	// Token: 0x0400ECFE RID: 60670
	[Nullable(2)]
	private IBPI_SceneBp_C LastActiveMediaActor_Extra;

	// Token: 0x0400ECFF RID: 60671
	private readonly HashSet<IBPI_DayNightEvent_C> DayNightActors = new HashSet<IBPI_DayNightEvent_C>();

	// Token: 0x0400ED00 RID: 60672
	private bool LoadingSpecialActorAsset;

	// Token: 0x0400ED01 RID: 60673
	private bool SpecialActorAssetLoadCompleted;

	// Token: 0x0400ED02 RID: 60674
	private readonly List<UMediaPlayer> AvailableMediaPlayerPool = new List<UMediaPlayer>();

	// Token: 0x0400ED03 RID: 60675
	private readonly List<UMediaTexture> AvailableMediaTexturePool = new List<UMediaTexture>();

	// Token: 0x0400ED04 RID: 60676
	private readonly HashSet<MediaPlayForModel_Special_C> RegisterMediaActors_Special = new HashSet<MediaPlayForModel_Special_C>();

	// Token: 0x0400ED05 RID: 60677
	private readonly Dictionary<PDA_MediaPlayDataAsset_C, BpActorController.ActiveResourceGroup> ActiveResourceGroups = new Dictionary<PDA_MediaPlayDataAsset_C, BpActorController.ActiveResourceGroup>();

	// Token: 0x0400ED06 RID: 60678
	private readonly List<MediaPlayForModel_Special_C> PendingPlayMediaActors_Special = new List<MediaPlayForModel_Special_C>();

	// Token: 0x0400ED07 RID: 60679
	private readonly List<MediaPlayForModel_Special_C> PendingCloseMediaActors_Special = new List<MediaPlayForModel_Special_C>();

	// Token: 0x0400ED08 RID: 60680
	private readonly HashSet<MediaPlayForModel_Special_C> PendingReleaseMediaActors_Special = new HashSet<MediaPlayForModel_Special_C>();

	// Token: 0x0400ED09 RID: 60681
	private int FrameCounter;

	// Token: 0x0400ED0A RID: 60682
	private bool? IsDayState;

	// Token: 0x0400ED0B RID: 60683
	private readonly HashSet<IBPI_DayNightEvent_C> PendingRemoveDayNightActors = new HashSet<IBPI_DayNightEvent_C>();

	// Token: 0x0400ED0C RID: 60684
	private readonly List<MediaPlayForModel_Special_C> TempInvalidReleaseActors = new List<MediaPlayForModel_Special_C>();

	// Token: 0x0400ED0D RID: 60685
	[Nullable(2)]
	private static BpActorController _Instance;

	// Token: 0x02008B41 RID: 35649
	[NullableContext(0)]
	public enum EPendingStopReason
	{
		// Token: 0x0402C1FC RID: 180732
		OutOfAOI,
		// Token: 0x0402C1FD RID: 180733
		ManualControl
	}

	// Token: 0x02008B42 RID: 35650
	[Nullable(0)]
	internal class ActiveResourceGroup
	{
		// Token: 0x06042A81 RID: 273025 RVA: 0x013CAAEF File Offset: 0x013C8CEF
		public ActiveResourceGroup(UMediaPlayer mediaPlayer, UMediaTexture mediaTexture, HashSet<MediaPlayForModel_Special_C> actors)
		{
			this.MediaPlayer = mediaPlayer;
			this.MediaTexture = mediaTexture;
			this.Actors = actors;
		}

		// Token: 0x0402C1FE RID: 180734
		public UMediaPlayer MediaPlayer;

		// Token: 0x0402C1FF RID: 180735
		public UMediaTexture MediaTexture;

		// Token: 0x0402C200 RID: 180736
		public HashSet<MediaPlayForModel_Special_C> Actors;
	}
}
