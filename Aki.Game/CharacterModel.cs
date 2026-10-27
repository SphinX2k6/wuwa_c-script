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

// Token: 0x02002E32 RID: 11826
[NullableContext(1)]
[Nullable(0)]
public class CharacterModel : ModelBase
{
	// Token: 0x17002283 RID: 8835
	// (get) Token: 0x06018E9D RID: 102045 RVA: 0x0066C06B File Offset: 0x0066A26B
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

	// Token: 0x06018E9E RID: 102046 RVA: 0x0066C073 File Offset: 0x0066A273
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

	// Token: 0x06018E9F RID: 102047 RVA: 0x0066C0A1 File Offset: 0x0066A2A1
	public void ClearExtraEntitiesToEnterSelfCenteredState()
	{
		HashSet<EntityHandle> extraEntitiesToEnterSelfCenteredStateInternal = this.ExtraEntitiesToEnterSelfCenteredStateInternal;
		if (extraEntitiesToEnterSelfCenteredStateInternal == null)
		{
			return;
		}
		extraEntitiesToEnterSelfCenteredStateInternal.Clear();
	}

	// Token: 0x17002284 RID: 8836
	// (get) Token: 0x06018EA0 RID: 102048 RVA: 0x0066C0B3 File Offset: 0x0066A2B3
	public bool EnabledSelfCentered
	{
		get
		{
			return this.SelfCenteredModeInternal != ESelfCenteredMode.None || this.SelfCenteredTimeDilationInternal != 1f;
		}
	}

	// Token: 0x17002285 RID: 8837
	// (get) Token: 0x06018EA1 RID: 102049 RVA: 0x0066C0CF File Offset: 0x0066A2CF
	public ESelfCenteredMode SelfCenteredMode
	{
		get
		{
			return this.SelfCenteredModeInternal;
		}
	}

	// Token: 0x17002286 RID: 8838
	// (get) Token: 0x06018EA2 RID: 102050 RVA: 0x0066C0D7 File Offset: 0x0066A2D7
	public float SelfCenteredTimeDilation
	{
		get
		{
			return this.SelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x17002287 RID: 8839
	// (get) Token: 0x06018EA3 RID: 102051 RVA: 0x0066C0DF File Offset: 0x0066A2DF
	public float InverseSelfCenteredTimeDilation
	{
		get
		{
			return this.InverseSelfCenteredTimeDilationInternal;
		}
	}

	// Token: 0x06018EA4 RID: 102052 RVA: 0x0066C0E7 File Offset: 0x0066A2E7
	private void OnInitRole(EntityHandle entity)
	{
		if (this.SelfCenteredTimeDilationInternal == 1f)
		{
			return;
		}
		this.UpdateTeamSelfCenteredState();
	}

	// Token: 0x06018EA5 RID: 102053 RVA: 0x0066C0FD File Offset: 0x0066A2FD
	private void OnUpdateSceneTeam()
	{
		if (this.SelfCenteredTimeDilationInternal == 1f)
		{
			return;
		}
		this.UpdateTeamSelfCenteredState();
	}

	// Token: 0x06018EA6 RID: 102054 RVA: 0x0066C114 File Offset: 0x0066A314
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

	// Token: 0x06018EA7 RID: 102055 RVA: 0x0066C13E File Offset: 0x0066A33E
	private void OnLeaveLevelEvent()
	{
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06018EA8 RID: 102056 RVA: 0x0066C146 File Offset: 0x0066A346
	private void OnBackLoginEvent()
	{
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06018EA9 RID: 102057 RVA: 0x0066C14E File Offset: 0x0066A34E
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

	// Token: 0x06018EAA RID: 102058 RVA: 0x0066C163 File Offset: 0x0066A363
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PhantomExploreView && viewName != EUiViewName.ChatView && viewName != EUiViewName.ShopView)
		{
			return;
		}
		this.ExitAllSelfCenteredMode();
	}

	// Token: 0x06018EAB RID: 102059 RVA: 0x0066C194 File Offset: 0x0066A394
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

	// Token: 0x06018EAC RID: 102060 RVA: 0x0066C2AC File Offset: 0x0066A4AC
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

	// Token: 0x06018EAD RID: 102061 RVA: 0x0066C380 File Offset: 0x0066A580
	protected override bool OnLeaveLevel()
	{
		this.ClearData();
		return true;
	}

	// Token: 0x06018EAE RID: 102062 RVA: 0x0066C389 File Offset: 0x0066A589
	protected override bool OnChangeMode()
	{
		this.ExitAllSelfCenteredMode();
		return true;
	}

	// Token: 0x06018EAF RID: 102063 RVA: 0x0066C394 File Offset: 0x0066A594
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

	// Token: 0x06018EB0 RID: 102064 RVA: 0x0066C3DC File Offset: 0x0066A5DC
	public void ClearHandle(EntityHandle handle)
	{
		int index = handle.Index;
		if (index >= this.Handles.Count)
		{
			return;
		}
		this.Handles[index] = null;
	}

	// Token: 0x06018EB1 RID: 102065 RVA: 0x0066C40C File Offset: 0x0066A60C
	public void PushAwakeHandler(EntityHandle handle, Func<bool> onAwake, Func<bool> onSleep)
	{
		ValueTuple<EntityHandle, Func<bool>, Func<bool>> valueTuple = new ValueTuple<EntityHandle, Func<bool>, Func<bool>>(handle, onAwake, onSleep);
		this.AwakeQueue.Push(valueTuple);
		this.AwakeMap[handle] = valueTuple;
	}

	// Token: 0x06018EB2 RID: 102066 RVA: 0x0066C43C File Offset: 0x0066A63C
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

	// Token: 0x06018EB3 RID: 102067 RVA: 0x0066C484 File Offset: 0x0066A684
	public void ClearData()
	{
		this.AwakeQueue.Clear();
		this.AwakeMap.Clear();
	}

	// Token: 0x06018EB4 RID: 102068 RVA: 0x0066C49C File Offset: 0x0066A69C
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

	// Token: 0x06018EB5 RID: 102069 RVA: 0x0066C4E0 File Offset: 0x0066A6E0
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

	// Token: 0x06018EB6 RID: 102070 RVA: 0x0066C550 File Offset: 0x0066A750
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

	// Token: 0x06018EB7 RID: 102071 RVA: 0x0066C58C File Offset: 0x0066A78C
	public void SortItem(EntityHandle handle)
	{
		ValueTuple<EntityHandle, Func<bool>, Func<bool>> item;
		if (!this.AwakeMap.TryGetValue(handle, out item))
		{
			return;
		}
		this.AwakeQueue.Update(item);
	}

	// Token: 0x06018EB8 RID: 102072 RVA: 0x0066C5B7 File Offset: 0x0066A7B7
	public void EnterSelfCenteredMode(ESelfCenteredMode mode, float timeDilation, float duration = -1f)
	{
		this.EnableSelfCenteredMode(mode, timeDilation, duration);
		this.SwitchSelfCenteredMode(this.GetNextSelfCenteredMode());
	}

	// Token: 0x06018EB9 RID: 102073 RVA: 0x0066C5D0 File Offset: 0x0066A7D0
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

	// Token: 0x06018EBA RID: 102074 RVA: 0x0066C61E File Offset: 0x0066A81E
	public void ExitSelfCenteredMode(ESelfCenteredMode mode)
	{
		this.DisableSelfCenteredMode(mode);
		this.SwitchSelfCenteredMode(this.GetNextSelfCenteredMode());
	}

	// Token: 0x06018EBB RID: 102075 RVA: 0x0066C634 File Offset: 0x0066A834
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

	// Token: 0x06018EBC RID: 102076 RVA: 0x0066C6F0 File Offset: 0x0066A8F0
	public bool IsSelfCenteredModeEnabled(ESelfCenteredMode mode)
	{
		return (int)mode < this.SelfCenteredEnableModeArray.Length && this.SelfCenteredEnableModeArray[(int)mode];
	}

	// Token: 0x06018EBD RID: 102077 RVA: 0x0066C714 File Offset: 0x0066A914
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

	// Token: 0x06018EBE RID: 102078 RVA: 0x0066C7A7 File Offset: 0x0066A9A7
	public void DisableSelfCenteredMode(ESelfCenteredMode mode)
	{
		this.SelfCenteredEnableModeArray[(int)mode] = false;
		this.SelfCenteredTimeDilationArray[(int)mode] = 1f;
		this.SelfCenteredTimeDurationArray[(int)mode] = 0f;
	}

	// Token: 0x06018EBF RID: 102079 RVA: 0x0066C7CC File Offset: 0x0066A9CC
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

	// Token: 0x06018EC0 RID: 102080 RVA: 0x0066C82C File Offset: 0x0066AA2C
	private float GetSelfCenteredTimeDilationByMode(ESelfCenteredMode mode)
	{
		if (this.SelfCenteredEnableModeArray[(int)mode])
		{
			return this.SelfCenteredTimeDilationArray[(int)mode];
		}
		return 1f;
	}

	// Token: 0x06018EC1 RID: 102081 RVA: 0x0066C846 File Offset: 0x0066AA46
	private float GetSelfCenteredTimeDurationByMode(ESelfCenteredMode mode)
	{
		if (this.SelfCenteredEnableModeArray[(int)mode])
		{
			return this.SelfCenteredTimeDurationArray[(int)mode];
		}
		return 0f;
	}

	// Token: 0x06018EC2 RID: 102082 RVA: 0x0066C860 File Offset: 0x0066AA60
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

	// Token: 0x06018EC3 RID: 102083 RVA: 0x0066CAE8 File Offset: 0x0066ACE8
	private void OnEnterSkillSelfCenteredMode()
	{
		FormationAttributeController.Instance.AddThresholdListener(EFormationAttributeId.TimeScaleStrength, new TThresholdListener(this.StrengthEmptyCallback), 0f, 0f, "Strength.RoleStrengthComponent");
		FormationDataController.Instance.AddPlayerTag(CreatureModel.Instance.GetPlayerId(), new int?(GameplayTagDefine.EGameplayTagId["角色.Common.时间缩放.技能"]));
	}

	// Token: 0x06018EC4 RID: 102084 RVA: 0x0066CB44 File Offset: 0x0066AD44
	private void OnExitSkillSelfCenteredMode()
	{
		FormationAttributeController.Instance.RemoveThresholdListener(EFormationAttributeId.TimeScaleStrength, new TThresholdListener(this.StrengthEmptyCallback));
		FormationDataController.Instance.RemovePlayerTag(CreatureModel.Instance.GetPlayerId(), new int?(GameplayTagDefine.EGameplayTagId["角色.Common.时间缩放.技能"]));
	}

	// Token: 0x06018EC5 RID: 102085 RVA: 0x0066CB91 File Offset: 0x0066AD91
	private void StrengthEmptyCallback(EFormationAttributeId attrId, bool inInterval, float currentRatio)
	{
		if (this.SelfCenteredModeInternal == ESelfCenteredMode.Skill)
		{
			this.ExitSkillSelfCenteredMode();
		}
	}

	// Token: 0x06018EC6 RID: 102086 RVA: 0x0066CBA4 File Offset: 0x0066ADA4
	private void SetEffectSystemScaleEnable(bool enable)
	{
		for (int i = 0; i < 20; i++)
		{
			EffectSystem.Instance.SetAdditionTimeScaleEnable((ETimeScaleSourceType)i, enable);
		}
	}

	// Token: 0x06018EC7 RID: 102087 RVA: 0x0066CBCC File Offset: 0x0066ADCC
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

	// Token: 0x06018EC8 RID: 102088 RVA: 0x0066CC04 File Offset: 0x0066AE04
	private void UpdateTeamSelfCenteredState()
	{
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
		{
			this.SetEntitySelfCenterTimeDilation(this.InverseSelfCenteredTimeDilation, entityHandle);
		}
	}

	// Token: 0x06018EC9 RID: 102089 RVA: 0x0066CC64 File Offset: 0x0066AE64
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

	// Token: 0x17002288 RID: 8840
	// (get) Token: 0x06018ECA RID: 102090 RVA: 0x0066CCC8 File Offset: 0x0066AEC8
	public static CharacterModel Instance
	{
		get
		{
			return CharacterModel._Instance;
		}
	}

	// Token: 0x06018ECB RID: 102091 RVA: 0x0066CCCF File Offset: 0x0066AECF
	public static CharacterModel GetOrCreateInstance()
	{
		if (CharacterModel._Instance == null)
		{
			CharacterModel.CreateInstance();
		}
		return CharacterModel._Instance;
	}

	// Token: 0x06018ECC RID: 102092 RVA: 0x0066CCE3 File Offset: 0x0066AEE3
	public static bool CreateInstance()
	{
		if (CharacterModel._Instance != null)
		{
			return true;
		}
		CharacterModel._Instance = new CharacterModel();
		return true;
	}

	// Token: 0x06018ECD RID: 102093 RVA: 0x0066CCF9 File Offset: 0x0066AEF9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018ECE RID: 102094 RVA: 0x0066CCFB File Offset: 0x0066AEFB
	public static void ResetStaticDefaultValue()
	{
		CharacterModel._Instance = null;
	}

	// Token: 0x06018ECF RID: 102095 RVA: 0x0066CD03 File Offset: 0x0066AF03
	static CharacterModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterModel.CreateStaticDefaultValue), new Action(CharacterModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400BAE8 RID: 47848
	private const int ENTITY_LRU_CAPACITY = 300;

	// Token: 0x0400BAE9 RID: 47849
	[StaticVariableRuleIgnore]
	private static readonly global::Vector AEntityLocation = global::Vector.Create();

	// Token: 0x0400BAEA RID: 47850
	[StaticVariableRuleIgnore]
	private static readonly global::Vector BEntityLocation = global::Vector.Create();

	// Token: 0x0400BAEB RID: 47851
	private const int SELF_CENTERED_SKILL_ID = 210027;

	// Token: 0x0400BAEC RID: 47852
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly List<EntityHandle> Handles = new List<EntityHandle>();

	// Token: 0x0400BAED RID: 47853
	private readonly bool[] SelfCenteredEnableModeArray = new bool[6];

	// Token: 0x0400BAEE RID: 47854
	private readonly float[] SelfCenteredTimeDilationArray = new float[6];

	// Token: 0x0400BAEF RID: 47855
	private readonly float[] SelfCenteredTimeDurationArray = new float[6];

	// Token: 0x0400BAF0 RID: 47856
	private readonly List<int> SelfCenteredSequence = new List<int>();

	// Token: 0x0400BAF1 RID: 47857
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<EntityHandle> ExtraEntitiesToEnterSelfCenteredStateInternal;

	// Token: 0x0400BAF2 RID: 47858
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

	// Token: 0x0400BAF3 RID: 47859
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

	// Token: 0x0400BAF4 RID: 47860
	public bool TestSoarOn;

	// Token: 0x0400BAF5 RID: 47861
	public readonly Lru<BigInteger, WorldEntity> EntityPool = new Lru<BigInteger, WorldEntity>(300, (BigInteger key) => new WorldEntity(0, 0), null);

	// Token: 0x0400BAF6 RID: 47862
	private ESelfCenteredMode SelfCenteredModeInternal;

	// Token: 0x0400BAF7 RID: 47863
	private float SelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400BAF8 RID: 47864
	private float InverseSelfCenteredTimeDilationInternal = 1f;

	// Token: 0x0400BAF9 RID: 47865
	[Nullable(2)]
	private static CharacterModel _Instance;
}
