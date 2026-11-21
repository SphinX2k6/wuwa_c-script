using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200238F RID: 9103
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class CharacterShadowController : ControllerBase
{
	// Token: 0x170022FC RID: 8956
	// (get) Token: 0x0601679F RID: 92063 RVA: 0x00692D95 File Offset: 0x00690F95
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060167A0 RID: 92064 RVA: 0x00692D98 File Offset: 0x00690F98
	protected override bool OnInit()
	{
		this.GetConfigByGameSetting();
		this.OnAddEvents();
		this.LastDate = new DateTime?(DateTime.Now);
		return true;
	}

	// Token: 0x060167A1 RID: 92065 RVA: 0x00692DB7 File Offset: 0x00690FB7
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x060167A2 RID: 92066 RVA: 0x00692DC0 File Offset: 0x00690FC0
	private void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.SetImageQuality, new Action(this.OnSetImageQuality));
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		this.CharacterShadowConfigChangedDelegate = DelegateUtils.ToManualReleaseDelegate<FOnCharacterShadowConfigChanged>(new Action<FName>(this.OnCharacterShadowConfigChanged));
		UKuroCharRenderingComponent.BindCharacterShadowConfigChangedCallback(this.CharacterShadowConfigChangedDelegate);
	}

	// Token: 0x060167A3 RID: 92067 RVA: 0x00692E44 File Offset: 0x00691044
	private void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.SetImageQuality, new Action(this.OnSetImageQuality));
		EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		if (this.CharacterShadowConfigChangedDelegate != null)
		{
			UKuroCharRenderingComponent.UnbindCharacterShadowConfigChangedCallback();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FName>(this.OnCharacterShadowConfigChanged));
			this.CharacterShadowConfigChangedDelegate = null;
		}
	}

	// Token: 0x060167A4 RID: 92068 RVA: 0x00692ECA File Offset: 0x006910CA
	private void OnCharacterShadowConfigChanged(FName cVarName)
	{
		this.GetConfigByGameSetting();
	}

	// Token: 0x060167A5 RID: 92069 RVA: 0x00692ED2 File Offset: 0x006910D2
	private void OnSetImageQuality()
	{
		this.GetConfigByGameSetting();
	}

	// Token: 0x060167A6 RID: 92070 RVA: 0x00692EDC File Offset: 0x006910DC
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		WorldEntity entity = handle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		if (creatureDataComponent != null && creatureDataComponent.IsCharacter())
		{
			if (creatureDataComponent.IsRole() || creatureDataComponent.GetSummonerPlayerId() != 0 || creatureDataComponent.IsVision())
			{
				this.RoleEntityHandles.Add(handle);
				return;
			}
			BaseCharacterComponent component = handle.Entity.GetComponent<BaseCharacterComponent>();
			if (component != null && component.Actor.IsValid() && (this.EnableRealShadowNum == 0 || (this.MaxDecalShadowDistance > 0 && !PlotModel.Instance.IsInHighLevelPlot())))
			{
				CharRenderingComponent charRenderingComponent = component.Actor.CharRenderingComponent;
				if (charRenderingComponent == null)
				{
					return;
				}
				charRenderingComponent.DisableAllShadowByDecalShadowComponent();
			}
		}
	}

	// Token: 0x060167A7 RID: 92071 RVA: 0x00692F7B File Offset: 0x0069117B
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.RoleEntityHandles.Remove(handle);
	}

	// Token: 0x060167A8 RID: 92072 RVA: 0x00692F8C File Offset: 0x0069118C
	private void GetConfigByGameSetting()
	{
		float consoleVariableFloatValue = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.CharacterShadow.RealShadowDistanceOverride");
		int consoleVariableIntValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.Kuro.CharacterShadow.RealShadowNumOverride");
		float consoleVariableFloatValue2 = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.CharacterShadow.DecalShadowDistanceOverride");
		this.EnableRealShadowDistance = ((consoleVariableFloatValue >= 0f) ? ((int)consoleVariableFloatValue) : GameSettingsDeviceRender.Instance.GetMaxRoleShadowDistance());
		this.EnableRealShadowNum = ((consoleVariableIntValue >= 0) ? consoleVariableIntValue : GameSettingsDeviceRender.Instance.GetMaxRoleShadowNum());
		this.MaxDecalShadowDistance = ((consoleVariableFloatValue2 >= 0f) ? ((int)consoleVariableFloatValue2) : GameSettingsDeviceRender.Instance.GetMaxDecalShadowDistance());
		this.IsMainPlayerUseRealRoleShadow = (GameSettingsDeviceRender.Instance.IsMainPlayerUseRealRoleShadow() != 0);
	}

	// Token: 0x060167A9 RID: 92073 RVA: 0x0069301C File Offset: 0x0069121C
	private UniTask TrySendMessage()
	{
		CharacterShadowController.<TrySendMessage>d__24 <TrySendMessage>d__;
		<TrySendMessage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TrySendMessage>d__.<>4__this = this;
		<TrySendMessage>d__.<>1__state = -1;
		<TrySendMessage>d__.<>t__builder.Start<CharacterShadowController.<TrySendMessage>d__24>(ref <TrySendMessage>d__);
		return <TrySendMessage>d__.<>t__builder.Task;
	}

	// Token: 0x060167AA RID: 92074 RVA: 0x00693060 File Offset: 0x00691260
	protected override void OnTick(float deltaTime)
	{
		if (Net.Instance.IsFinishLogin())
		{
			this.TrySendMessage().Forget();
		}
		if (TickSystem.Instance.IsPaused)
		{
			return;
		}
		if (Time.Instance.Frame - this.LastUpdateFrame < 15)
		{
			return;
		}
		bool debugLogEnabled = this.DebugLogEnabled;
		this.LastUpdateFrame = Time.Instance.Frame;
		if (!PlotModel.Instance.IsInHighLevelPlot() && this.MaxDecalShadowDistance > 0)
		{
			CreatureModel.Instance.GetEntitiesInRange((float)this.MaxDecalShadowDistance, EEntityTypeQuery.Character, this.QueryEntityResultCache, true, false);
			int num = 0;
			this.RealShadowEntitiesSet.Clear();
			this.DecalShadowEntitiesSet.Clear();
			foreach (EntityHandle entityHandle in this.QueryEntityResultCache)
			{
				if (entityHandle.Valid)
				{
					BaseCharacterComponent component = entityHandle.Entity.GetComponent<BaseCharacterComponent>();
					if (component != null && component.Actor.IsValid())
					{
						AActor owner = component.Owner;
						if (owner != null && owner.WasRecentlyRenderedOnScreen(0.2f))
						{
							if (this.EnableRealShadowNum > 0 && num < this.EnableRealShadowNum && entityHandle.Entity.DistanceWithCamera < (float)this.EnableRealShadowDistance)
							{
								CharRenderingComponent charRenderingComponent = component.Actor.CharRenderingComponent;
								if (charRenderingComponent != null)
								{
									charRenderingComponent.SetDecalShadowEnabled(false);
								}
								CharRenderingComponent charRenderingComponent2 = component.Actor.CharRenderingComponent;
								if (charRenderingComponent2 != null)
								{
									charRenderingComponent2.SetRealTimeShadowEnabled(true);
								}
								this.RealShadowEntitiesSet.Add(entityHandle);
								num++;
								if (this.DebugLogEnabled)
								{
								}
							}
							else
							{
								if (num >= this.EnableRealShadowNum)
								{
									CharRenderingComponent charRenderingComponent3 = component.Actor.CharRenderingComponent;
									if (charRenderingComponent3 != null)
									{
										charRenderingComponent3.SetDecalShadowEnabled(true);
									}
									CharRenderingComponent charRenderingComponent4 = component.Actor.CharRenderingComponent;
									if (charRenderingComponent4 != null)
									{
										charRenderingComponent4.SetRealTimeShadowEnabled(false);
									}
									this.DecalShadowEntitiesSet.Add(entityHandle);
								}
								bool debugLogEnabled2 = this.DebugLogEnabled;
							}
						}
					}
				}
			}
			foreach (EntityHandle entityHandle2 in this.LastFrameDecalShadowEntitiesSet)
			{
				if (entityHandle2.Valid && !this.RealShadowEntitiesSet.Contains(entityHandle2) && !this.DecalShadowEntitiesSet.Contains(entityHandle2))
				{
					BaseCharacterComponent component2 = entityHandle2.Entity.GetComponent<BaseCharacterComponent>();
					if (component2 != null && component2.Actor.IsValid())
					{
						CharRenderingComponent charRenderingComponent5 = component2.Actor.CharRenderingComponent;
						if (charRenderingComponent5 != null)
						{
							charRenderingComponent5.DisableAllShadowByDecalShadowComponent();
						}
					}
				}
			}
		}
		this.LastFrameDecalShadowEntitiesSet = new HashSet<EntityHandle>(this.DecalShadowEntitiesSet);
		foreach (EntityHandle entityHandle3 in this.RoleEntityHandles)
		{
			if (entityHandle3.Valid)
			{
				BaseCharacterComponent component3 = entityHandle3.Entity.GetComponent<BaseCharacterComponent>();
				if (component3 != null && component3.Actor.IsValid())
				{
					WorldEntity entity = entityHandle3.Entity;
					if (entity != null && entity.Active)
					{
						if (this.IsMainPlayerUseRealRoleShadow)
						{
							CharRenderingComponent charRenderingComponent6 = component3.Actor.CharRenderingComponent;
							if (charRenderingComponent6 != null)
							{
								charRenderingComponent6.SetDecalShadowEnabled(false);
							}
							CharRenderingComponent charRenderingComponent7 = component3.Actor.CharRenderingComponent;
							if (charRenderingComponent7 != null)
							{
								charRenderingComponent7.SetRealTimeShadowEnabled(true);
							}
						}
						else
						{
							CharRenderingComponent charRenderingComponent8 = component3.Actor.CharRenderingComponent;
							if (charRenderingComponent8 != null)
							{
								charRenderingComponent8.SetDecalShadowEnabled(true);
							}
							CharRenderingComponent charRenderingComponent9 = component3.Actor.CharRenderingComponent;
							if (charRenderingComponent9 != null)
							{
								charRenderingComponent9.SetRealTimeShadowEnabled(false);
							}
						}
					}
					else
					{
						CharRenderingComponent charRenderingComponent10 = component3.Actor.CharRenderingComponent;
						if (charRenderingComponent10 != null)
						{
							charRenderingComponent10.DisableAllShadowByDecalShadowComponent();
						}
					}
					bool debugLogEnabled3 = this.DebugLogEnabled;
				}
			}
		}
	}

	// Token: 0x170022FD RID: 8957
	// (get) Token: 0x060167AB RID: 92075 RVA: 0x00693440 File Offset: 0x00691640
	public static CharacterShadowController Instance
	{
		get
		{
			return CharacterShadowController._Instance;
		}
	}

	// Token: 0x060167AC RID: 92076 RVA: 0x00693447 File Offset: 0x00691647
	public static CharacterShadowController GetOrCreateInstance()
	{
		if (CharacterShadowController._Instance == null)
		{
			CharacterShadowController.CreateInstance();
		}
		return CharacterShadowController._Instance;
	}

	// Token: 0x060167AD RID: 92077 RVA: 0x0069345B File Offset: 0x0069165B
	public static bool CreateInstance()
	{
		if (CharacterShadowController._Instance != null)
		{
			return true;
		}
		CharacterShadowController._Instance = new CharacterShadowController();
		return true;
	}

	// Token: 0x060167AE RID: 92078 RVA: 0x00693471 File Offset: 0x00691671
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060167AF RID: 92079 RVA: 0x00693473 File Offset: 0x00691673
	public static void ResetStaticDefaultValue()
	{
		CharacterShadowController._Instance = null;
	}

	// Token: 0x060167B0 RID: 92080 RVA: 0x0069347B File Offset: 0x0069167B
	static CharacterShadowController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterShadowController.CreateStaticDefaultValue), new Action(CharacterShadowController.ResetStaticDefaultValue));
	}

	// Token: 0x0400BE88 RID: 48776
	private int EnableRealShadowDistance;

	// Token: 0x0400BE89 RID: 48777
	private int EnableRealShadowNum;

	// Token: 0x0400BE8A RID: 48778
	private int MaxDecalShadowDistance;

	// Token: 0x0400BE8B RID: 48779
	private int LastUpdateFrame;

	// Token: 0x0400BE8C RID: 48780
	private bool IsMainPlayerUseRealRoleShadow;

	// Token: 0x0400BE8D RID: 48781
	private readonly HashSet<EntityHandle> RoleEntityHandles = new HashSet<EntityHandle>();

	// Token: 0x0400BE8E RID: 48782
	private readonly List<EntityHandle> QueryEntityResultCache = new List<EntityHandle>();

	// Token: 0x0400BE8F RID: 48783
	private readonly HashSet<EntityHandle> DecalShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BE90 RID: 48784
	private readonly HashSet<EntityHandle> RealShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BE91 RID: 48785
	private HashSet<EntityHandle> LastFrameDecalShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BE92 RID: 48786
	private readonly bool DebugLogEnabled;

	// Token: 0x0400BE93 RID: 48787
	[Nullable(2)]
	private FOnCharacterShadowConfigChanged CharacterShadowConfigChangedDelegate;

	// Token: 0x0400BE94 RID: 48788
	private DateTime? LastDate;

	// Token: 0x0400BE95 RID: 48789
	[Nullable(2)]
	private static CharacterShadowController _Instance;
}
