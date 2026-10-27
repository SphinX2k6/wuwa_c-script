using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001A05 RID: 6661
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class DamageUiController : ControllerBase
{
	// Token: 0x0600C2F2 RID: 49906 RVA: 0x002C0EBF File Offset: 0x002BF0BF
	protected override bool OnInit()
	{
		DamageUiManager.Instance.Initialize();
		this.AddEvents();
		return true;
	}

	// Token: 0x0600C2F3 RID: 49907 RVA: 0x002C0ED2 File Offset: 0x002BF0D2
	protected override bool OnClear()
	{
		this.RemoveEvents();
		DamageUiManager.Instance.Clear();
		DamageUiManager.Instance.ClearDamageViewData();
		this.StopUeDamageUiManager();
		return true;
	}

	// Token: 0x0600C2F4 RID: 49908 RVA: 0x002C0EF5 File Offset: 0x002BF0F5
	protected override bool OnLeaveLevel()
	{
		DamageUiManager.Instance.OnLeaveLevel();
		this.StopUeDamageUiManager();
		return true;
	}

	// Token: 0x0600C2F5 RID: 49909 RVA: 0x002C0F08 File Offset: 0x002BF108
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	protected override ValueTuple<string, CustomPromise<bool>>? OnPreload()
	{
		CustomPromise<bool> promise = new CustomPromise<bool>();
		DamageUiManager.Instance.PreloadAsync().ContinueWith(delegate()
		{
			promise.SetResult(true);
		}).Forget(delegate(Exception error)
		{
			if (error != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "Preload异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", error.Message);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CombatInfo;
				ELogAuthor author2 = ELogAuthor.CFT;
				string message2 = "Preload异常";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", error);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			promise.SetResult(false);
		}, true);
		return new ValueTuple<string, CustomPromise<bool>>?(new ValueTuple<string, CustomPromise<bool>>("DamageUiController Preload", promise));
	}

	// Token: 0x0600C2F6 RID: 49910 RVA: 0x002C0F68 File Offset: 0x002BF168
	protected override void OnTick(float delta)
	{
		DamageUiManager.Instance.Tick(delta);
	}

	// Token: 0x0600C2F7 RID: 49911 RVA: 0x002C0F78 File Offset: 0x002BF178
	public void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoadCompleted));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Add<int>(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddUIDamage, new Action<int, GameplayCue, bool, int>(this.OnAddBuffDamageUi));
		if (GlobalData.IsPlayInEditor)
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.DamageView, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600C2F8 RID: 49912 RVA: 0x002C108C File Offset: 0x002BF28C
	public void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoadCompleted));
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRoleCompleted));
		EventSystem.Instance.Remove<int>(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.OnAddEntity));
		EventSystem.Instance.Remove<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddUIDamage, new Action<int, GameplayCue, bool, int>(this.OnAddBuffDamageUi));
		if (GlobalData.IsPlayInEditor)
		{
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.DamageView, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600C2F9 RID: 49913 RVA: 0x002C119D File Offset: 0x002BF39D
	private void OnWorldDone()
	{
		this.StartUeDamageUiManager();
	}

	// Token: 0x0600C2FA RID: 49914 RVA: 0x002C11A8 File Offset: 0x002BF3A8
	private void OnFormationLoadCompleted()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			this.AddEntityEvents(getCurrentEntity.Entity);
		}
	}

	// Token: 0x0600C2FB RID: 49915 RVA: 0x002C11D0 File Offset: 0x002BF3D0
	private void OnChangeRoleCompleted(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			this.AddEntityEvents(getCurrentEntity.Entity);
		}
	}

	// Token: 0x0600C2FC RID: 49916 RVA: 0x002C11F8 File Offset: 0x002BF3F8
	private void OnRoleGoDown(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		this.RemoveEntityEvents(entity);
	}

	// Token: 0x0600C2FD RID: 49917 RVA: 0x002C121C File Offset: 0x002BF41C
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		this.AddEntityEvents(handle.Entity);
	}

	// Token: 0x0600C2FE RID: 49918 RVA: 0x002C122A File Offset: 0x002BF42A
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.RemoveEntityEvents(handle.Entity);
	}

	// Token: 0x0600C2FF RID: 49919 RVA: 0x002C1238 File Offset: 0x002BF438
	[NullableContext(2)]
	private void AddEntityEvents(Entity entity)
	{
		if (entity == null)
		{
			return;
		}
		if (!EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityApplyDamage)))
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityApplyDamage));
		}
	}

	// Token: 0x0600C300 RID: 49920 RVA: 0x002C1273 File Offset: 0x002BF473
	[NullableContext(2)]
	private void RemoveEntityEvents(Entity entity)
	{
		if (entity == null)
		{
			return;
		}
		if (EventSystem.Instance.HasWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityApplyDamage)))
		{
			EventSystem.Instance.RemoveWithTarget(entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnEntityApplyDamage));
		}
	}

	// Token: 0x0600C301 RID: 49921 RVA: 0x002C12B0 File Offset: 0x002BF4B0
	private void OnEntityApplyDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		float damage = damageResult.Damage;
		Damage damageData = damageResult.DamageData;
		ECalculationType calculateType = (ECalculationType)damageData.CalculateType;
		if (calculateType == ECalculationType.Hurt)
		{
			BattleUiModel.Instance.ExploreModeData.BeHit(victim);
			DamageUiManager.Instance.ApplyDamage(damage, (int)damageResult.Element, damagePosition, victim, requirements.IsCritical.Value, false, damageData.DamageTextType, requirements.IsImmune.Value ? "Immune" : "", damageData.DamageTextAreaId);
			return;
		}
		if (calculateType != ECalculationType.Heal)
		{
			return;
		}
		CharacterActorComponent component = victim.GetComponent<CharacterActorComponent>();
		DamageUiManager.Instance.ApplyDamage(-damage, 0, component.ActorLocation, victim, false, true, damageData.DamageTextType, "", damageData.DamageTextAreaId);
	}

	// Token: 0x0600C302 RID: 49922 RVA: 0x002C1368 File Offset: 0x002BF568
	private void OnAddBuffDamageUi(int entityId, GameplayCue cue, bool isAdd, int handleId)
	{
		if (!isAdd)
		{
			return;
		}
		Entity entity = EntitySystem.Instance.Get(entityId);
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		string[] array = cue.Parameters();
		DamageUiManager.Instance.ApplyDamage(-1f, 0, component.ActorLocation, entity, false, true, (array.Length != 0) ? int.Parse(array[0]) : 0, (array.Length > 1) ? array[1] : "", (array.Length > 2) ? int.Parse(array[2]) : 0);
	}

	// Token: 0x0600C303 RID: 49923 RVA: 0x002C13DD File Offset: 0x002BF5DD
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		DamageUiManager.Instance.OnEditorPlatformChanged();
	}

	// Token: 0x0600C304 RID: 49924 RVA: 0x002C13EC File Offset: 0x002BF5EC
	private void OnBattleUiChildVisibleChanged()
	{
		UUIItem battleViewUnit = UiLayer.Instance.GetBattleViewUnit(0);
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.DamageView);
		battleViewUnit.SetUIActive(childVisible);
	}

	// Token: 0x0600C305 RID: 49925 RVA: 0x002C141C File Offset: 0x002BF61C
	public void SetDamageTimeScaleEnable(bool bEnable)
	{
		DamageUiManager.Instance.SetDamageTimeScaleEnable(bEnable);
	}

	// Token: 0x0600C306 RID: 49926 RVA: 0x002C1429 File Offset: 0x002BF629
	public int EnableDamageViewOptimization()
	{
		return DamageUiManager.Instance.EnableDamageViewOptimization();
	}

	// Token: 0x0600C307 RID: 49927 RVA: 0x002C1435 File Offset: 0x002BF635
	public void DisableDamageViewOptimization(int id)
	{
		DamageUiManager.Instance.DisableDamageViewOptimization(id);
	}

	// Token: 0x0600C308 RID: 49928 RVA: 0x002C1442 File Offset: 0x002BF642
	public void StartUeDamageUiManager()
	{
		DamageUiManager.Instance.StartUeDamageUiManager();
	}

	// Token: 0x0600C309 RID: 49929 RVA: 0x002C144E File Offset: 0x002BF64E
	public void StopUeDamageUiManager()
	{
		DamageUiManager.Instance.StopUeDamageUiManager();
	}

	// Token: 0x0600C30A RID: 49930 RVA: 0x002C145A File Offset: 0x002BF65A
	public void SetUeDamageConfig(FDamageConfig config, bool hideDamageCritEffect = false)
	{
		DamageUiManager.Instance.SetUeDamageConfig(config, hideDamageCritEffect);
	}

	// Token: 0x0600C30B RID: 49931 RVA: 0x002C1468 File Offset: 0x002BF668
	public void UpdateKscWorld()
	{
		DamageUiManager.Instance.UpdateKscWorld();
	}

	// Token: 0x17001049 RID: 4169
	// (get) Token: 0x0600C30C RID: 49932 RVA: 0x002C1474 File Offset: 0x002BF674
	public static DamageUiController Instance
	{
		get
		{
			return DamageUiController._Instance;
		}
	}

	// Token: 0x0600C30D RID: 49933 RVA: 0x002C147B File Offset: 0x002BF67B
	public static DamageUiController GetOrCreateInstance()
	{
		if (DamageUiController._Instance == null)
		{
			DamageUiController.CreateInstance();
		}
		return DamageUiController._Instance;
	}

	// Token: 0x0600C30E RID: 49934 RVA: 0x002C148F File Offset: 0x002BF68F
	public static bool CreateInstance()
	{
		if (DamageUiController._Instance != null)
		{
			return true;
		}
		DamageUiController._Instance = new DamageUiController();
		return true;
	}

	// Token: 0x0600C30F RID: 49935 RVA: 0x002C14A5 File Offset: 0x002BF6A5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C310 RID: 49936 RVA: 0x002C14A7 File Offset: 0x002BF6A7
	public static void ResetStaticDefaultValue()
	{
		DamageUiController._Instance = null;
	}

	// Token: 0x0600C311 RID: 49937 RVA: 0x002C14AF File Offset: 0x002BF6AF
	static DamageUiController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageUiController.CreateStaticDefaultValue), new Action(DamageUiController.ResetStaticDefaultValue));
	}

	// Token: 0x040059E9 RID: 23017
	[Nullable(2)]
	private static DamageUiController _Instance;
}
