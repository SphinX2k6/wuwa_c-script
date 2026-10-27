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

// Token: 0x02002E33 RID: 11827
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class CharacterShadowController : ControllerBase
{
	// Token: 0x17002289 RID: 8841
	// (get) Token: 0x06018ED2 RID: 102098 RVA: 0x0066CE9D File Offset: 0x0066B09D
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06018ED3 RID: 102099 RVA: 0x0066CEA0 File Offset: 0x0066B0A0
	protected override bool OnInit()
	{
		this.GetConfigByGameSetting();
		this.OnAddEvents();
		this.LastDate = new DateTime?(DateTime.Now);
		return true;
	}

	// Token: 0x06018ED4 RID: 102100 RVA: 0x0066CEBF File Offset: 0x0066B0BF
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x06018ED5 RID: 102101 RVA: 0x0066CEC8 File Offset: 0x0066B0C8
	private void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.SetImageQuality, new Action(this.OnSetImageQuality));
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		this.CharacterShadowConfigChangedDelegate = DelegateUtils.ToManualReleaseDelegate<FOnCharacterShadowConfigChanged>(new Action<FName>(this.OnCharacterShadowConfigChanged));
		UKuroCharRenderingComponent.BindCharacterShadowConfigChangedCallback(this.CharacterShadowConfigChangedDelegate);
	}

	// Token: 0x06018ED6 RID: 102102 RVA: 0x0066CF4C File Offset: 0x0066B14C
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

	// Token: 0x06018ED7 RID: 102103 RVA: 0x0066CFD2 File Offset: 0x0066B1D2
	private void OnCharacterShadowConfigChanged(FName cVarName)
	{
		this.GetConfigByGameSetting();
	}

	// Token: 0x06018ED8 RID: 102104 RVA: 0x0066CFDA File Offset: 0x0066B1DA
	private void OnSetImageQuality()
	{
		this.GetConfigByGameSetting();
	}

	// Token: 0x06018ED9 RID: 102105 RVA: 0x0066CFE4 File Offset: 0x0066B1E4
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

	// Token: 0x06018EDA RID: 102106 RVA: 0x0066D083 File Offset: 0x0066B283
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.RoleEntityHandles.Remove(handle);
	}

	// Token: 0x06018EDB RID: 102107 RVA: 0x0066D094 File Offset: 0x0066B294
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

	// Token: 0x06018EDC RID: 102108 RVA: 0x0066D124 File Offset: 0x0066B324
	private UniTask TrySendMessage()
	{
		CharacterShadowController.<TrySendMessage>d__24 <TrySendMessage>d__;
		<TrySendMessage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TrySendMessage>d__.<>4__this = this;
		<TrySendMessage>d__.<>1__state = -1;
		<TrySendMessage>d__.<>t__builder.Start<CharacterShadowController.<TrySendMessage>d__24>(ref <TrySendMessage>d__);
		return <TrySendMessage>d__.<>t__builder.Task;
	}

	// Token: 0x06018EDD RID: 102109 RVA: 0x0066D168 File Offset: 0x0066B368
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

	// Token: 0x1700228A RID: 8842
	// (get) Token: 0x06018EDE RID: 102110 RVA: 0x0066D548 File Offset: 0x0066B748
	public static CharacterShadowController Instance
	{
		get
		{
			return CharacterShadowController._Instance;
		}
	}

	// Token: 0x06018EDF RID: 102111 RVA: 0x0066D54F File Offset: 0x0066B74F
	public static CharacterShadowController GetOrCreateInstance()
	{
		if (CharacterShadowController._Instance == null)
		{
			CharacterShadowController.CreateInstance();
		}
		return CharacterShadowController._Instance;
	}

	// Token: 0x06018EE0 RID: 102112 RVA: 0x0066D563 File Offset: 0x0066B763
	public static bool CreateInstance()
	{
		if (CharacterShadowController._Instance != null)
		{
			return true;
		}
		CharacterShadowController._Instance = new CharacterShadowController();
		return true;
	}

	// Token: 0x06018EE1 RID: 102113 RVA: 0x0066D579 File Offset: 0x0066B779
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018EE2 RID: 102114 RVA: 0x0066D57B File Offset: 0x0066B77B
	public static void ResetStaticDefaultValue()
	{
		CharacterShadowController._Instance = null;
	}

	// Token: 0x06018EE3 RID: 102115 RVA: 0x0066D583 File Offset: 0x0066B783
	static CharacterShadowController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterShadowController.CreateStaticDefaultValue), new Action(CharacterShadowController.ResetStaticDefaultValue));
	}

	// Token: 0x0400BAFA RID: 47866
	private int EnableRealShadowDistance;

	// Token: 0x0400BAFB RID: 47867
	private int EnableRealShadowNum;

	// Token: 0x0400BAFC RID: 47868
	private int MaxDecalShadowDistance;

	// Token: 0x0400BAFD RID: 47869
	private int LastUpdateFrame;

	// Token: 0x0400BAFE RID: 47870
	private bool IsMainPlayerUseRealRoleShadow;

	// Token: 0x0400BAFF RID: 47871
	private readonly HashSet<EntityHandle> RoleEntityHandles = new HashSet<EntityHandle>();

	// Token: 0x0400BB00 RID: 47872
	private readonly List<EntityHandle> QueryEntityResultCache = new List<EntityHandle>();

	// Token: 0x0400BB01 RID: 47873
	private readonly HashSet<EntityHandle> DecalShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BB02 RID: 47874
	private readonly HashSet<EntityHandle> RealShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BB03 RID: 47875
	private HashSet<EntityHandle> LastFrameDecalShadowEntitiesSet = new HashSet<EntityHandle>();

	// Token: 0x0400BB04 RID: 47876
	private readonly bool DebugLogEnabled;

	// Token: 0x0400BB05 RID: 47877
	[Nullable(2)]
	private FOnCharacterShadowConfigChanged CharacterShadowConfigChangedDelegate;

	// Token: 0x0400BB06 RID: 47878
	private DateTime? LastDate;

	// Token: 0x0400BB07 RID: 47879
	[Nullable(2)]
	private static CharacterShadowController _Instance;
}
