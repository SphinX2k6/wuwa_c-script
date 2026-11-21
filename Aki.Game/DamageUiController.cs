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

// Token: 0x02000EC4 RID: 3780
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class DamageUiController : ControllerBase
{
	// Token: 0x06009700 RID: 38656 RVA: 0x002CBEAB File Offset: 0x002CA0AB
	protected override bool OnInit()
	{
		DamageUiManager.Instance.Initialize();
		this.AddEvents();
		return true;
	}

	// Token: 0x06009701 RID: 38657 RVA: 0x002CBEBE File Offset: 0x002CA0BE
	protected override bool OnClear()
	{
		this.RemoveEvents();
		DamageUiManager.Instance.Clear();
		DamageUiManager.Instance.ClearDamageViewData();
		this.StopUeDamageUiManager();
		return true;
	}

	// Token: 0x06009702 RID: 38658 RVA: 0x002CBEE1 File Offset: 0x002CA0E1
	protected override bool OnLeaveLevel()
	{
		DamageUiManager.Instance.OnLeaveLevel();
		this.StopUeDamageUiManager();
		return true;
	}

	// Token: 0x06009703 RID: 38659 RVA: 0x002CBEF4 File Offset: 0x002CA0F4
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

	// Token: 0x06009704 RID: 38660 RVA: 0x002CBF54 File Offset: 0x002CA154
	protected override void OnTick(float delta)
	{
		DamageUiManager.Instance.Tick(delta);
	}

	// Token: 0x06009705 RID: 38661 RVA: 0x002CBF64 File Offset: 0x002CA164
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

	// Token: 0x06009706 RID: 38662 RVA: 0x002CC078 File Offset: 0x002CA278
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

	// Token: 0x06009707 RID: 38663 RVA: 0x002CC189 File Offset: 0x002CA389
	private void OnWorldDone()
	{
		this.StartUeDamageUiManager();
	}

	// Token: 0x06009708 RID: 38664 RVA: 0x002CC194 File Offset: 0x002CA394
	private void OnFormationLoadCompleted()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			this.AddEntityEvents(getCurrentEntity.Entity);
		}
	}

	// Token: 0x06009709 RID: 38665 RVA: 0x002CC1BC File Offset: 0x002CA3BC
	private void OnChangeRoleCompleted(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null)
		{
			this.AddEntityEvents(getCurrentEntity.Entity);
		}
	}

	// Token: 0x0600970A RID: 38666 RVA: 0x002CC1E4 File Offset: 0x002CA3E4
	private void OnRoleGoDown(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		this.RemoveEntityEvents(entity);
	}

	// Token: 0x0600970B RID: 38667 RVA: 0x002CC208 File Offset: 0x002CA408
	private void OnAddEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
	{
		this.AddEntityEvents(handle.Entity);
	}

	// Token: 0x0600970C RID: 38668 RVA: 0x002CC216 File Offset: 0x002CA416
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		this.RemoveEntityEvents(handle.Entity);
	}

	// Token: 0x0600970D RID: 38669 RVA: 0x002CC224 File Offset: 0x002CA424
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

	// Token: 0x0600970E RID: 38670 RVA: 0x002CC25F File Offset: 0x002CA45F
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

	// Token: 0x0600970F RID: 38671 RVA: 0x002CC29C File Offset: 0x002CA49C
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

	// Token: 0x06009710 RID: 38672 RVA: 0x002CC354 File Offset: 0x002CA554
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

	// Token: 0x06009711 RID: 38673 RVA: 0x002CC3C9 File Offset: 0x002CA5C9
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		DamageUiManager.Instance.OnEditorPlatformChanged();
	}

	// Token: 0x06009712 RID: 38674 RVA: 0x002CC3D8 File Offset: 0x002CA5D8
	private void OnBattleUiChildVisibleChanged()
	{
		UUIItem battleViewUnit = UiLayer.Instance.GetBattleViewUnit(0);
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.DamageView);
		battleViewUnit.SetUIActive(childVisible);
	}

	// Token: 0x06009713 RID: 38675 RVA: 0x002CC408 File Offset: 0x002CA608
	public void SetDamageTimeScaleEnable(bool bEnable)
	{
		DamageUiManager.Instance.SetDamageTimeScaleEnable(bEnable);
	}

	// Token: 0x06009714 RID: 38676 RVA: 0x002CC415 File Offset: 0x002CA615
	public int EnableDamageViewOptimization()
	{
		return DamageUiManager.Instance.EnableDamageViewOptimization();
	}

	// Token: 0x06009715 RID: 38677 RVA: 0x002CC421 File Offset: 0x002CA621
	public void DisableDamageViewOptimization(int id)
	{
		DamageUiManager.Instance.DisableDamageViewOptimization(id);
	}

	// Token: 0x06009716 RID: 38678 RVA: 0x002CC42E File Offset: 0x002CA62E
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.DamageShowNotify, false, false)]
	public static void DamageShowNotify(Entity owner, [Nullable(1)] DamageShowNotify data, CombatCommon combatCommon = null)
	{
		if (owner == null)
		{
			return;
		}
		DamageUiController.Instance.ApplyExtraDamage(data.Id, data.Damage, owner);
	}

	// Token: 0x06009717 RID: 38679 RVA: 0x002CC44C File Offset: 0x002CA64C
	public void ApplyExtraDamage(int id, int damage, Entity victim)
	{
		if (damage == 0)
		{
			return;
		}
		ExtraDamageText? config = ConfigExtraDamageTextById.GetConfig(id, true);
		if (config == null)
		{
			return;
		}
		CharacterActorComponent component = victim.GetComponent<CharacterActorComponent>();
		bool bCure = damage > 0;
		DamageUiManager.Instance.ApplyDamage((float)damage, 0, component.ActorLocation, victim, false, bCure, config.Value.DamageTextId, "", config.Value.DamageTextAreaId);
	}

	// Token: 0x06009718 RID: 38680 RVA: 0x002CC4B4 File Offset: 0x002CA6B4
	public void StartUeDamageUiManager()
	{
		DamageUiManager.Instance.StartUeDamageUiManager();
	}

	// Token: 0x06009719 RID: 38681 RVA: 0x002CC4C0 File Offset: 0x002CA6C0
	public void StopUeDamageUiManager()
	{
		DamageUiManager.Instance.StopUeDamageUiManager();
	}

	// Token: 0x0600971A RID: 38682 RVA: 0x002CC4CC File Offset: 0x002CA6CC
	public void SetUeDamageConfig(FDamageConfig config, bool hideDamageCritEffect = false)
	{
		DamageUiManager.Instance.SetUeDamageConfig(config, hideDamageCritEffect);
	}

	// Token: 0x0600971B RID: 38683 RVA: 0x002CC4DA File Offset: 0x002CA6DA
	public void UpdateKscWorld()
	{
		DamageUiManager.Instance.UpdateKscWorld();
	}

	// Token: 0x1700106E RID: 4206
	// (get) Token: 0x0600971C RID: 38684 RVA: 0x002CC4E6 File Offset: 0x002CA6E6
	public static DamageUiController Instance
	{
		get
		{
			return DamageUiController._Instance;
		}
	}

	// Token: 0x0600971D RID: 38685 RVA: 0x002CC4ED File Offset: 0x002CA6ED
	public static DamageUiController GetOrCreateInstance()
	{
		if (DamageUiController._Instance == null)
		{
			DamageUiController.CreateInstance();
		}
		return DamageUiController._Instance;
	}

	// Token: 0x0600971E RID: 38686 RVA: 0x002CC501 File Offset: 0x002CA701
	public static bool CreateInstance()
	{
		if (DamageUiController._Instance != null)
		{
			return true;
		}
		DamageUiController._Instance = new DamageUiController();
		return true;
	}

	// Token: 0x0600971F RID: 38687 RVA: 0x002CC517 File Offset: 0x002CA717
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009720 RID: 38688 RVA: 0x002CC519 File Offset: 0x002CA719
	public static void ResetStaticDefaultValue()
	{
		DamageUiController._Instance = null;
	}

	// Token: 0x06009721 RID: 38689 RVA: 0x002CC521 File Offset: 0x002CA721
	static DamageUiController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageUiController.CreateStaticDefaultValue), new Action(DamageUiController.ResetStaticDefaultValue));
	}

	// Token: 0x04005AB8 RID: 23224
	[Nullable(2)]
	private static DamageUiController _Instance;
}
