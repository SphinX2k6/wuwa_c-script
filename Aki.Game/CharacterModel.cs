using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200238E RID: 9102
[NullableContext(1)]
[Nullable(0)]
public class CharacterModel : ModelBase
{
	// Token: 0x170022F6 RID: 8950
	// (get) Token: 0x0601676A RID: 92010 RVA: 0x00691F63 File Offset: 0x00690163
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<EntityHandle> ExtraEntitiesToEnterSelfCenteredState
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.ExtraEntitiesToEnterSelfCenteredStateInternal;
		}
	}

	// Token: 0x0601676B RID: 92011 RVA: 0x00691F6B File Offset: 0x0069016B
	[NullableContext(2)]
	public void AddExtraEntityToEnterSelfCenteredState(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		if (this.ExtraEntitiesToEnterSelfCenteredStateInternal == null)
		{
			this.ExtraEntitiesToEnterSelfCenteredStateInternal = new HashSet<EntityHandle>();
		}
		this.ExtraEntitiesToEnterSelfCenteredStateInternal.Add(entityHandle);
	}

	// Token: 0x0601676C RID: 92012 RVA: 0x00691F99 File Offset: 0x00690199
	public void ClearExtraEntitiesToEnterSelfCenteredState()
	{
		HashSet<EntityHandle> extraEntitiesToEnterSelfCenteredStateInternal = this.ExtraEntitiesToEnterSelfCenteredStateInternal;
		if (extraEntitiesToEnterSelfCenteredStateInternal == null)
		{
			return;
		}
		extraEntitiesToEnterSelfCenteredStateInternal.Clear();
	}

	// Token: 0x170022F7 RID: 8951
	// (get) Token: 0x0601676D RID: 92013 RVA: 0x00691FAB File Offset: 0x006901AB
	public bool EnabledSelfCentered
	{
		get
		{
			return this.SelfCenteredModeInternal != ESelfCenteredMode.None || this.SelfCenteredTimeDilationInternal != 1f;
		}
	}

	// Token: 0x170022F8 RID: 8952
	// (get) Token: 0x0601676E RID: 92014 RVA: 0x00691FC7 File Offset: 0x006901C7
	public ESelfCenteredMode SelfCenteredMode
	{
		get
		{
			return this.SelfCenteredModeInternal;
		}
	}

	// Token: 0x170022F9 RID: 8953
	// (get) Token: 0x0601676F RID: 92015 RVA: 0x00691FCF File Offset: 0x006901CF
	public float SelfCenteredTimeDilation
	{
		get
		{
			return this.SelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x170022FA RID: 8954
	// (get) Token: 0x06016770 RID: 92016 RVA: 0x00691FD7 File Offset: 0x006901D7
	public float InverseSelfCenteredTimeDilation
	{
		get
		{
			return this.InverseSelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x06016771 RID: 92017 RVA: 0x00691FDF File Offset: 0x006901DF
	private void OnInitRole(EntityHandle entity)
	{
		if (this.SelfCenteredTimeDilationInternal == 1f)
		{
			return;
		}
		this.UpdateTeamSelfCenteredState();
	}

	// Token: 0x06016772 RID: 92018 RVA: 0x00691FF5 File Offset: 0x006901F5
	private void OnUpdateSceneTeam()
	{
		if (this.SelfCenteredTimeDilationInternal == 1f)
		{
			return;
		}
		this.UpdateTeamSelfCenteredState();
	}

	// Token: 0x06016773 RID: 92019 RVA: 0x0069200C File Offset: 0x0069020C
	private void OnPlotNetworkStart(PlotInfo plotInfo)
	{
		EPlotLevel plotLevel = plotInfo.PlotLevel;
		bool flag = plotLevel - EPlotLevel.LevelD <= 1;
		if (flag)
		{
			return;
		}
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016774 RID: 92020 RVA: 0x00692036 File Offset: 0x00690236
	private void OnLeaveLevelEvent()
	{
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016775 RID: 92021 RVA: 0x0069203E File Offset: 0x0069023E
	private void OnBackLoginEvent()
	{
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016776 RID: 92022 RVA: 0x00692046 File Offset: 0x00690246
	private void OnSetGamePaused(bool paused)
	{
		if (!paused)
		{
			return;
		}
		if (!this.EnabledSelfCentered)
		{
			return;
		}
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016777 RID: 92023 RVA: 0x0069205B File Offset: 0x0069025B
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhantomExploreView && viewName != EUiViewName.ChatView && viewName != EUiViewName.ShopView)
		{
			return;
		}
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06016778 RID: 92024 RVA: 0x0069208C File Offset: 0x0069028C
	protected override bool OnInit()
	{
		this.Handles.Clear();
		this.SelfCenteredSequence.Add(5);
		this.SelfCenteredSequence.Add(3);
		this.SelfCenteredSequence.Add(2);
		this.SelfCenteredSequence.Add(1);
		this.SelfCenteredSequence.Add(4);
		EventSystem.Instance.Add<EntityHandle>(EEventName.OnInitRole, new Action<EntityHandle>(this.OnInitRole));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotNetworkStart));
		EventSystem.Instance.Add(EEventName.DoLeaveLevel, new Action(this.OnLeaveLevelEvent));
		EventSystem.Instance.Add(EEventName.BackLoginView, new Action(this.OnBackLoginEvent));
		EventSystem.Instance.Add<bool>(EEventName.OnSetGamePaused, new Action<bool>(this.OnSetGamePaused));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		return true;
	}

	// Token: 0x06016779 RID: 92025 RVA: 0x006921A4 File Offset: 0x006903A4
	protected override bool OnClear()
	{
		this.ClearData();
		EventSystem.Instance.Remove<EntityHandle>(EEventName.OnInitRole, new Action<EntityHandle>(this.OnInitRole));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		EventSystem.Instance.Remove<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnPlotNetworkStart));
		EventSystem.Instance.Remove(EEventName.DoLeaveLevel, new Action(this.OnLeaveLevelEvent));
		EventSystem.Instance.Remove(EEventName.BackLoginView, new Action(this.OnBackLoginEvent));
		EventSystem.Instance.Remove<bool>(EEventName.OnSetGamePaused, new Action<bool>(this.OnSetGamePaused));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		return true;
	}

	// Token: 0x0601677A RID: 92026 RVA: 0x00692278 File Offset: 0x00690478
	protected override bool OnLeaveLevel()
	{
		this.ClearData();
		return true;
	}

	// Token: 0x0601677B RID: 92027 RVA: 0x00692281 File Offset: 0x00690481
	protected override bool OnChangeMode()
	{
		this.ExitAllSelfCenteredMode();
		return true;
	}

	// Token: 0x0601677C RID: 92028 RVA: 0x0069228C File Offset: 0x0069048C
	public EntityHandle CreateHandle(WorldEntity entity)
	{
		int index = entity.Index;
		while (this.Handles.Count <= index)
		{
			this.Handles.Add(null);
		}
		EntityHandle entityHandle = new EntityHandle(entity);
		this.Handles[index] = entityHandle;
		return entityHandle;
	}

	// Token: 0x0601677D RID: 92029 RVA: 0x006922D4 File Offset: 0x006904D4
	public void ClearHandle(EntityHandle handle)
	{
		int index = handle.Index;
		if (index >= this.Handles.Count)
		{
			return;
		}
		this.Handles[index] = null;
	}

	// Token: 0x0601677E RID: 92030 RVA: 0x00692304 File Offset: 0x00690504
	public void PushAwakeHandler(EntityHandle handle, Func<bool> onAwake, Func<bool> onSleep)
	{
		ValueTuple<EntityHandle, Func<bool>, Func<bool>> valueTuple = new ValueTuple<EntityHandle, Func<bool>, Func<bool>>(handle, onAwake, onSleep);
		this.AwakeQueue.Push(valueTuple);
		this.AwakeMap[handle] = valueTuple;
	}

	// Token: 0x0601677F RID: 92031 RVA: 0x00692334 File Offset: 0x00690534
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	public ValueTuple<EntityHandle, Func<bool>, Func<bool>>? PopAwakeHandler()
	{
		if (this.AwakeQueue.Empty)
		{
			return null;
		}
		ValueTuple<EntityHandle, Func<bool>, Func<bool>> valueTuple = this.AwakeQueue.Pop();
		this.AwakeMap.Remove(valueTuple.Item1);
		return new ValueTuple<EntityHandle, Func<bool>, Func<bool>>?(valueTuple);
	}

	// Token: 0x06016780 RID: 92032 RVA: 0x0069237C File Offset: 0x0069057C
	public void ClearData()
	{
		this.AwakeQueue.Clear();
		this.AwakeMap.Clear();
	}

	// Token: 0x06016781 RID: 92033 RVA: 0x00692394 File Offset: 0x00690594
	[NullableContext(2)]
	public EntityHandle GetHandle(int id)
	{
		if (id == 0)
		{
			return null;
		}
		int num = (int)((uint)id >> 16);
		if (num >= this.Handles.Count)
		{
			return null;
		}
		EntityHandle entityHandle = this.Handles[num];
		if (entityHandle != null && entityHandle.Id == id)
		{
			return entityHandle;
		}
		return null;
	}

	// Token: 0x06016782 RID: 92034 RVA: 0x006923D8 File Offset: 0x006905D8
	[NullableContext(2)]
	public EntityHandle GetHandleByEntity(Entity entity)
	{
		if (entity == null)
		{
			return null;
		}
		int index = entity.Index;
		if (index >= this.Handles.Count)
		{
			return null;
		}
		EntityHandle entityHandle = this.Handles[index];
		int? num = (entityHandle != null) ? new int?(entityHandle.Id) : null;
		int id = entity.Id;
		if (num.GetValueOrDefault() == id & num != null)
		{
			return entityHandle;
		}
		return null;
	}

	// Token: 0x06016783 RID: 92035 RVA: 0x00692448 File Offset: 0x00690648
	public bool IsValid(int id)
	{
		int num = (int)((uint)id >> 16);
		if (num >= this.Handles.Count)
		{
			return false;
		}
		EntityHandle entityHandle = this.Handles[num];
		return entityHandle != null && entityHandle.Id == id;
	}

	// Token: 0x06016784 RID: 92036 RVA: 0x00692484 File Offset: 0x00690684
	public void SortItem(EntityHandle handle)
	{
		ValueTuple<EntityHandle, Func<bool>, Func<bool>> item;
		if (!this.AwakeMap.TryGetValue(handle, out item))
		{
			return;
		}
		this.AwakeQueue.Update(item);
	}

	// Token: 0x06016785 RID: 92037 RVA: 0x006924AF File Offset: 0x006906AF
	public void EnterSelfCenteredMode(ESelfCenteredMode mode, float timeDilation, float duration = -1f)
	{
		this.EnableSelfCenteredMode(mode, timeDilation, duration);
		this.SwitchSelfCenteredMode(this.GetNextSelfCenteredMode());
	}

	// Token: 0x06016786 RID: 92038 RVA: 0x006924C8 File Offset: 0x006906C8
	public void ExitSkillSelfCenteredMode()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		BaseSkillComponent baseSkillComponent;
		if (baseCharacter == null)
		{
			baseSkillComponent = null;
		}
		else
		{
			Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
			baseSkillComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseSkillComponent>() : null);
		}
		BaseSkillComponent baseSkillComponent2 = baseSkillComponent;
		if (baseSkillComponent2 != null && baseSkillComponent2.Valid)
		{
			baseSkillComponent2.BeginSkillAsync(210027, null);
		}
		CharacterController.Instance.ExitSelfCenteredMode(ESelfCenteredMode.Skill);
	}

	// Token: 0x06016787 RID: 92039 RVA: 0x00692516 File Offset: 0x00690716
	public void ExitSelfCenteredMode(ESelfCenteredMode mode)
	{
		this.DisableSelfCenteredMode(mode);
		this.SwitchSelfCenteredMode(this.GetNextSelfCenteredMode());
	}

	// Token: 0x06016788 RID: 92040 RVA: 0x0069252C File Offset: 0x0069072C
	public void ExitAllSelfCenteredMode()
	{
		if (this.IsSelfCenteredModeEnabled(ESelfCenteredMode.Skill))
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			BaseSkillComponent baseSkillComponent;
			if (baseCharacter == null)
			{
				baseSkillComponent = null;
			}
			else
			{
				Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
				baseSkillComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseSkillComponent>() : null);
			}
			BaseSkillComponent baseSkillComponent2 = baseSkillComponent;
			if (baseSkillComponent2 != null && baseSkillComponent2.Valid)
			{
				baseSkillComponent2.BeginSkillAsync(210027, null);
			}
		}
		foreach (int num in this.SelfCenteredSequence)
		{
			this.SelfCenteredEnableModeArray[num] = false;
			this.SelfCenteredTimeDilationArray[num] = 1f;
			this.SelfCenteredTimeDurationArray[num] = 0f;
		}
		this.SwitchSelfCenteredMode(this.GetNextSelfCenteredMode());
	}

	// Token: 0x06016789 RID: 92041 RVA: 0x006925E8 File Offset: 0x006907E8
	public bool IsSelfCenteredModeEnabled(ESelfCenteredMode mode)
	{
		return (int)mode < this.SelfCenteredEnableModeArray.Length && this.SelfCenteredEnableModeArray[(int)mode];
	}

	// Token: 0x0601678A RID: 92042 RVA: 0x0069260C File Offset: 0x0069080C
	public unsafe void EnableSelfCenteredMode(ESelfCenteredMode mode, float timeDilation, float duration = -1f)
	{
		if ((double)timeDilation <= 1E-08)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "Error SelfCentered TimeDilation.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mode", mode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TimeDilation", timeDilation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.SelfCenteredEnableModeArray[(int)mode] = true;
		this.SelfCenteredTimeDilationArray[(int)mode] = timeDilation;
		this.SelfCenteredTimeDurationArray[(int)mode] = duration;
	}

	// Token: 0x0601678B RID: 92043 RVA: 0x0069269F File Offset: 0x0069089F
	public void DisableSelfCenteredMode(ESelfCenteredMode mode)
	{
		this.SelfCenteredEnableModeArray[(int)mode] = false;
		this.SelfCenteredTimeDilationArray[(int)mode] = 1f;
		this.SelfCenteredTimeDurationArray[(int)mode] = 0f;
	}

	// Token: 0x0601678C RID: 92044 RVA: 0x006926C4 File Offset: 0x006908C4
	public ESelfCenteredMode GetNextSelfCenteredMode()
	{
		foreach (int num in this.SelfCenteredSequence)
		{
			if (this.SelfCenteredEnableModeArray[num])
			{
				return (ESelfCenteredMode)num;
			}
		}
		return ESelfCenteredMode.None;
	}

	// Token: 0x0601678D RID: 92045 RVA: 0x00692724 File Offset: 0x00690924
	private float GetSelfCenteredTimeDilationByMode(ESelfCenteredMode mode)
	{
		if (this.SelfCenteredEnableModeArray[(int)mode])
		{
			return this.SelfCenteredTimeDilationArray[(int)mode];
		}
		return 1f;
	}

	// Token: 0x0601678E RID: 92046 RVA: 0x0069273E File Offset: 0x0069093E
	private float GetSelfCenteredTimeDurationByMode(ESelfCenteredMode mode)
	{
		if (this.SelfCenteredEnableModeArray[(int)mode])
		{
			return this.SelfCenteredTimeDurationArray[(int)mode];
		}
		return 0f;
	}

	// Token: 0x0601678F RID: 92047 RVA: 0x00692758 File Offset: 0x00690958
	public unsafe bool SwitchSelfCenteredMode(ESelfCenteredMode mode)
	{
		float selfCenteredTimeDilationByMode = this.GetSelfCenteredTimeDilationByMode(mode);
		if (this.SelfCenteredModeInternal == mode && MathUtils.Instance.IsNearlyEqual((double)this.SelfCenteredTimeDilationInternal, (double)selfCenteredTimeDilationByMode, null))
		{
			return false;
		}
		ESelfCenteredMode selfCenteredModeInternal = this.SelfCenteredModeInternal;
		this.SelfCenteredModeInternal = mode;
		this.SelfCenteredTimeDilationInternal = selfCenteredTimeDilationByMode;
		this.InverseSelfCenteredTimeDilationInternal = 1f / selfCenteredTimeDilationByMode;
		UGameplayStatics.SetGlobalTimeDilation(GlobalData.GameInstance, selfCenteredTimeDilationByMode);
		Time.Instance.SetInverseSelfCenteredTimeDilation(this.InverseSelfCenteredTimeDilationInternal);
		Time.Instance.SetFlowTimeDilation(this.InverseSelfCenteredTimeDilationInternal);
		FormationDataController.Instance.SetTimeDilation(this.InverseSelfCenteredTimeDilation);
		USequencerManager sequencerManager = ALGUIManagerActor.GetSequencerManager(GlobalData.World);
		if (sequencerManager != null)
		{
			sequencerManager.SetGlobalPlayRate(this.InverseSelfCenteredTimeDilation);
		}
		ALTweenActor ltweenInstance = ALTweenActor.GetLTweenInstance(GlobalData.World);
		if (ltweenInstance != null)
		{
			ltweenInstance.SetGlobalPlayRate(this.InverseSelfCenteredTimeDilation);
		}
		if (MathUtils.Instance.IsNearlyEqual((double)this.SelfCenteredTimeDilationInternal, 1.0, null))
		{
			AudioSystem.Instance.SetState("level_2_5_time_slow", "none", true);
			AudioSystem.Instance.PostEvent("disable_monster_effect_2_5_time_slow");
			this.SetEffectSystemScaleEnable(false);
			TimerSystem.Instance.Next(delegate(float _)
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				BaseTagComponent baseTagComponent;
				if (baseCharacter == null)
				{
					baseTagComponent = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
					baseTagComponent = ((characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<BaseTagComponent>() : null);
				}
				BaseTagComponent baseTagComponent2 = baseTagComponent;
				bool flag = baseTagComponent2 != null && baseTagComponent2.Valid && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态.翱翔"]);
				if (MathUtils.Instance.IsNearlyEqual((double)this.SelfCenteredTimeDilationInternal, 1.0, null) && !flag)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.TargetFPS -1", null);
					return;
				}
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.TargetFPS 1200", null);
			}, null, null);
			EffectSystem.Instance.EnableNiagaraDownSampling();
			RenderUtil.UnsetNeedRenderKuroToonDepth();
		}
		else
		{
			AudioSystem.Instance.SetState("level_2_5_time_slow", "enable", true);
			AudioSystem.Instance.PostEvent("enable_monster_effect_2_5_time_slow");
			this.SetEffectSystemScaleEnable(true);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.TargetFPS 1200", null);
			EffectSystem.Instance.DisableNiagaraDownSampling();
			RenderUtil.SetNeedRenderKuroToonDepth();
		}
		this.UpdateTeamSelfCenteredState();
		this.UpdateExtraEntitySelfCenteredState();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "SelfCentered Change.";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timeDilation", selfCenteredTimeDilationByMode);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SelfCenteredMode", this.SelfCenteredModeInternal);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (selfCenteredModeInternal != ESelfCenteredMode.Skill && this.SelfCenteredModeInternal == ESelfCenteredMode.Skill)
		{
			this.OnEnterSkillSelfCenteredMode();
		}
		else if (selfCenteredModeInternal == ESelfCenteredMode.Skill)
		{
			this.OnExitSkillSelfCenteredMode();
		}
		EventSystem.Instance.Emit<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, this.SelfCenteredModeInternal, selfCenteredTimeDilationByMode);
		SlowTimePush slowTimePush = SlowTimePush.Create();
		slowTimePush.Dilation = selfCenteredTimeDilationByMode;
		slowTimePush.Flag = (selfCenteredTimeDilationByMode != 1f);
		slowTimePush.Duration = (int)(this.GetSelfCenteredTimeDurationByMode(mode) * (float)TimeUtil.Instance.InverseMillisecond);
		Net.Instance.Send(EPushMessageId.SlowTimePush, slowTimePush);
		return true;
	}

	// Token: 0x06016790 RID: 92048 RVA: 0x006929E0 File Offset: 0x00690BE0
	private void OnEnterSkillSelfCenteredMode()
	{
		FormationAttributeController.Instance.AddThresholdListener(EFormationAttributeId.TimeScaleStrength, new TThresholdListener(this.StrengthEmptyCallback), 0f, 0f, "Strength.RoleStrengthComponent");
		FormationDataController.Instance.AddPlayerTag(CreatureModel.Instance.GetPlayerId(), new int?(GameplayTagDefine.EGameplayTagId["角色.Common.时间缩放.技能"]));
	}

	// Token: 0x06016791 RID: 92049 RVA: 0x00692A3C File Offset: 0x00690C3C
	private void OnExitSkillSelfCenteredMode()
	{
		FormationAttributeController.Instance.RemoveThresholdListener(EFormationAttributeId.TimeScaleStrength, new TThresholdListener(this.StrengthEmptyCallback));
		FormationDataController.Instance.RemovePlayerTag(CreatureModel.Instance.GetPlayerId(), new int?(GameplayTagDefine.EGameplayTagId["角色.Common.时间缩放.技能"]));
	}

	// Token: 0x06016792 RID: 92050 RVA: 0x00692A89 File Offset: 0x00690C89
	private void StrengthEmptyCallback(EFormationAttributeId attrId, bool inInterval, float currentRatio)
	{
		if (this.SelfCenteredModeInternal == ESelfCenteredMode.Skill)
		{
			this.ExitSkillSelfCenteredMode();
		}
	}

	// Token: 0x06016793 RID: 92051 RVA: 0x00692A9C File Offset: 0x00690C9C
	private void SetEffectSystemScaleEnable(bool enable)
	{
		for (int i = 0; i < 20; i++)
		{
			EffectSystem.Instance.SetAdditionTimeScaleEnable((ETimeScaleSourceType)i, enable);
		}
	}

	// Token: 0x06016794 RID: 92052 RVA: 0x00692AC4 File Offset: 0x00690CC4
	private void SetEntitySelfCenterTimeDilation(float timeDilation, EntityHandle entityHandle)
	{
		if (!entityHandle.Valid)
		{
			return;
		}
		CharacterSelfCenterComponent component = entityHandle.Entity.GetComponent<CharacterSelfCenterComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		component.SetSelfCenterTimeDilation(timeDilation, true);
	}

	// Token: 0x06016795 RID: 92053 RVA: 0x00692AFC File Offset: 0x00690CFC
	private void UpdateTeamSelfCenteredState()
	{
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
		{
			this.SetEntitySelfCenterTimeDilation(this.InverseSelfCenteredTimeDilation, entityHandle);
		}
	}

	// Token: 0x06016796 RID: 92054 RVA: 0x00692B5C File Offset: 0x00690D5C
	private void UpdateExtraEntitySelfCenteredState()
	{
		if (this.ExtraEntitiesToEnterSelfCenteredStateInternal != null)
		{
			foreach (EntityHandle entityHandle in this.ExtraEntitiesToEnterSelfCenteredStateInternal)
			{
				this.SetEntitySelfCenterTimeDilation(this.InverseSelfCenteredTimeDilation, entityHandle);
			}
		}
	}

	// Token: 0x170022FB RID: 8955
	// (get) Token: 0x06016797 RID: 92055 RVA: 0x00692BC0 File Offset: 0x00690DC0
	public static CharacterModel Instance
	{
		get
		{
			return CharacterModel._Instance;
		}
	}

	// Token: 0x06016798 RID: 92056 RVA: 0x00692BC7 File Offset: 0x00690DC7
	public static CharacterModel GetOrCreateInstance()
	{
		if (CharacterModel._Instance == null)
		{
			CharacterModel.CreateInstance();
		}
		return CharacterModel._Instance;
	}

	// Token: 0x06016799 RID: 92057 RVA: 0x00692BDB File Offset: 0x00690DDB
	public static bool CreateInstance()
	{
		if (CharacterModel._Instance != null)
		{
			return true;
		}
		CharacterModel._Instance = new CharacterModel();
		return true;
	}

	// Token: 0x0601679A RID: 92058 RVA: 0x00692BF1 File Offset: 0x00690DF1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601679B RID: 92059 RVA: 0x00692BF3 File Offset: 0x00690DF3
	public static void ResetStaticDefaultValue()
	{
		CharacterModel._Instance = null;
	}

	// Token: 0x0601679C RID: 92060 RVA: 0x00692BFB File Offset: 0x00690DFB
	static CharacterModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterModel.CreateStaticDefaultValue), new Action(CharacterModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400BE76 RID: 48758
	private const int ENTITY_LRU_CAPACITY = 300;

	// Token: 0x0400BE77 RID: 48759
	[StaticVariableRuleIgnore]
	private static readonly global::Vector AEntityLocation = global::Vector.Create();

	// Token: 0x0400BE78 RID: 48760
	[StaticVariableRuleIgnore]
	private static readonly global::Vector BEntityLocation = global::Vector.Create();

	// Token: 0x0400BE79 RID: 48761
	private const int SELF_CENTERED_SKILL_ID = 210027;

	// Token: 0x0400BE7A RID: 48762
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityHandle> Handles = new List<EntityHandle>();

	// Token: 0x0400BE7B RID: 48763
	private readonly bool[] SelfCenteredEnableModeArray = new bool[6];

	// Token: 0x0400BE7C RID: 48764
	private readonly float[] SelfCenteredTimeDilationArray = new float[6];

	// Token: 0x0400BE7D RID: 48765
	private readonly float[] SelfCenteredTimeDurationArray = new float[6];

	// Token: 0x0400BE7E RID: 48766
	private readonly List<int> SelfCenteredSequence = new List<int>();

	// Token: 0x0400BE7F RID: 48767
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<EntityHandle> ExtraEntitiesToEnterSelfCenteredStateInternal;

	// Token: 0x0400BE80 RID: 48768
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1,
		1
	})]
	public readonly PriorityQueue<ValueTuple<EntityHandle, Func<bool>, Func<bool>>> AwakeQueue = new PriorityQueue<ValueTuple<EntityHandle, Func<bool>, Func<bool>>>(delegate([Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] ValueTuple<EntityHandle, Func<bool>, Func<bool>> a, [Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})] ValueTuple<EntityHandle, Func<bool>, Func<bool>> b)
	{
		EntityHandle item = a.Item1;
		EntityHandle item2 = b.Item1;
		int priority = (int)item2.Priority;
		int priority2 = (int)item.Priority;
		if (priority != priority2)
		{
			return priority - priority2;
		}
		CreatureDataComponent creatureDataComponent;
		if (!item.Valid)
		{
			creatureDataComponent = null;
		}
		else
		{
			WorldEntity entity = item.Entity;
			creatureDataComponent = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		CreatureDataComponent creatureDataComponent2 = creatureDataComponent;
		CreatureDataComponent creatureDataComponent3;
		if (!item2.Valid)
		{
			creatureDataComponent3 = null;
		}
		else
		{
			WorldEntity entity2 = item2.Entity;
			creatureDataComponent3 = ((entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null);
		}
		CreatureDataComponent creatureDataComponent4 = creatureDataComponent3;
		if (creatureDataComponent2 == null || creatureDataComponent4 == null)
		{
			return 0;
		}
		FVectorDouble location = creatureDataComponent2.GetLocation();
		CharacterModel.AEntityLocation.X = location.X;
		CharacterModel.AEntityLocation.Y = location.Y;
		CharacterModel.AEntityLocation.Z = location.Z;
		FVectorDouble location2 = creatureDataComponent4.GetLocation();
		CharacterModel.BEntityLocation.X = location2.X;
		CharacterModel.BEntityLocation.Y = location2.Y;
		CharacterModel.BEntityLocation.Z = location2.Z;
		global::Vector roleLocation = GameModeModel.Instance.RoleLocation;
		double num = global::Vector.DistSquared(roleLocation, CharacterModel.AEntityLocation);
		double value = global::Vector.DistSquared(roleLocation, CharacterModel.BEntityLocation);
		return num.CompareTo(value);
	});

	// Token: 0x0400BE81 RID: 48769
	[Nullable(new byte[]
	{
		1,
		1,
		0,
		1,
		1,
		1
	})]
	private readonly Dictionary<EntityHandle, ValueTuple<EntityHandle, Func<bool>, Func<bool>>> AwakeMap = new Dictionary<EntityHandle, ValueTuple<EntityHandle, Func<bool>, Func<bool>>>();

	// Token: 0x0400BE82 RID: 48770
	public bool TestSoarOn;

	// Token: 0x0400BE83 RID: 48771
	public readonly Lru<BigInteger, WorldEntity> EntityPool = new Lru<BigInteger, WorldEntity>(300, (BigInteger key) => new WorldEntity(0, 0), null);

	// Token: 0x0400BE84 RID: 48772
	private ESelfCenteredMode SelfCenteredModeInternal;

	// Token: 0x0400BE85 RID: 48773
	private float SelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400BE86 RID: 48774
	private float InverseSelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400BE87 RID: 48775
	[Nullable(2)]
	private static CharacterModel _Instance;
}
