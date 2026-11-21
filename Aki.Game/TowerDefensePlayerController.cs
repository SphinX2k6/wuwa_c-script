using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Fight.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000387 RID: 903
[NullableContext(2)]
[Nullable(0)]
public class TowerDefensePlayerController : IStaticVariableResetter
{
	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x060031EF RID: 12783 RVA: 0x0011E9F9 File Offset: 0x0011CBF9
	public static TowerDefensePlayerModel Model
	{
		get
		{
			return TowerDefensePlayerController.TDPlayerModel;
		}
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x0011EA00 File Offset: 0x0011CC00
	static TowerDefensePlayerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDefensePlayerController.CreateStaticDefaultValue), new Action(TowerDefensePlayerController.ResetStaticDefaultValue));
	}

	// Token: 0x060031F1 RID: 12785 RVA: 0x0011EA1F File Offset: 0x0011CC1F
	public static void CreateStaticDefaultValue()
	{
		TowerDefensePlayerController.TDPlayerModel = new TowerDefensePlayerModel();
		TowerDefensePlayerController.EKSC_REMOVE_REASON_FOLLOWER = new FName("Follower");
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x0011EA3A File Offset: 0x0011CC3A
	public static void ResetStaticDefaultValue()
	{
		TowerDefensePlayerController.TDPlayerModel = null;
		TowerDefensePlayerController.DelegateSkillCoolDown = null;
		TowerDefensePlayerController.DelegateSkillCoolDownChange = null;
		TowerDefensePlayerController.EKSC_REMOVE_REASON_FOLLOWER = null;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x0011EA59 File Offset: 0x0011CC59
	public static bool OnInit()
	{
		return true;
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x0011EA5C File Offset: 0x0011CC5C
	public static bool OnStart()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnPlayerFollowerEnableChange;
		Action<bool> handle;
		if ((handle = TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange) == null)
		{
			handle = (TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange = new Action<bool>(TowerDefensePlayerController.OnPlayerFollowerEnableChange));
		}
		if (!instance.Has(name, handle))
		{
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnPlayerFollowerEnableChange;
			Action<bool> handle2;
			if ((handle2 = TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange) == null)
			{
				handle2 = (TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange = new Action<bool>(TowerDefensePlayerController.OnPlayerFollowerEnableChange));
			}
			instance2.Add(name2, handle2);
		}
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnPlayerFollowerUnPossessed;
		Action handle3;
		if ((handle3 = TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed) == null)
		{
			handle3 = (TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed = new Action(TowerDefensePlayerController.OnPlayerFollowerUnPossessed));
		}
		if (!instance3.Has(name3, handle3))
		{
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnPlayerFollowerUnPossessed;
			Action handle4;
			if ((handle4 = TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed) == null)
			{
				handle4 = (TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed = new Action(TowerDefensePlayerController.OnPlayerFollowerUnPossessed));
			}
			instance4.Add(name4, handle4);
		}
		TowerDefensePlayerController.Model.PendingRoleHandle = TowerDefensePlayerController.GetPlayerEntityHandle();
		TowerDefensePlayerController.Model.TowerDefenseWorldDone = true;
		TowerDefensePlayerController.DoPossessRole(TowerDefensePlayerController.Model.PendingRoleHandle);
		EntityHandle playerFollowShooter = FollowUtils.GetPlayerFollowShooter(CreatureModel.Instance.GetPlayerId());
		if (playerFollowShooter == null || !TowerDefensePlayerController.CheckPlayerFollowerMatch(playerFollowShooter))
		{
			EventSystem instance5 = EventSystem.Instance;
			EEventName name5 = EEventName.OnPlayerFollowerPossessed;
			Action<EntityHandle> handle5;
			if ((handle5 = TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed) == null)
			{
				handle5 = (TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed = new Action<EntityHandle>(TowerDefensePlayerController.OnPlayerFollowerPossessed));
			}
			if (!instance5.Has(name5, handle5))
			{
				EventSystem instance6 = EventSystem.Instance;
				EEventName name6 = EEventName.OnPlayerFollowerPossessed;
				Action<EntityHandle> handle6;
				if ((handle6 = TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed) == null)
				{
					handle6 = (TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed = new Action<EntityHandle>(TowerDefensePlayerController.OnPlayerFollowerPossessed));
				}
				instance6.Add(name6, handle6);
			}
		}
		else
		{
			TowerDefensePlayerController.OnPlayerFollowerPossessed(playerFollowShooter);
		}
		TowerDefensePlayerController.TryInitKSCEnityt();
		TowerDefensePlayerController.AddRouletteGameplayTag();
		return true;
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x0011EBC5 File Offset: 0x0011CDC5
	public static void SyncMainLocations(float delta)
	{
		KscEntityHandle possessedPlayerHandle = TowerDefensePlayerController.Model.PossessedPlayerHandle;
		if (possessedPlayerHandle != null)
		{
			possessedPlayerHandle.SyncEntityLocation();
		}
		KscEntityHandle possessedFollowerHandle = TowerDefensePlayerController.Model.PossessedFollowerHandle;
		if (possessedFollowerHandle == null)
		{
			return;
		}
		possessedFollowerHandle.SyncEntityLocation();
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x0011EBF0 File Offset: 0x0011CDF0
	public static bool OnClear()
	{
		TowerDefensePlayerController.RemoveRouletteGameplayTag();
		TowerDefensePlayerController.ClearFollowerKSCData();
		TowerDefensePlayerController.TDPlayerModel = null;
		return true;
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x0011EC04 File Offset: 0x0011CE04
	public static bool OnStop()
	{
		TowerDefensePlayerController.RemoveRouletteGameplayTag();
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnPlayerFollowerEnableChange;
		Action<bool> handle;
		if ((handle = TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange) == null)
		{
			handle = (TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange = new Action<bool>(TowerDefensePlayerController.OnPlayerFollowerEnableChange));
		}
		if (instance.Has(name, handle))
		{
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnPlayerFollowerEnableChange;
			Action<bool> handle2;
			if ((handle2 = TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange) == null)
			{
				handle2 = (TowerDefensePlayerController.<>O.<0>__OnPlayerFollowerEnableChange = new Action<bool>(TowerDefensePlayerController.OnPlayerFollowerEnableChange));
			}
			instance2.Remove(name2, handle2);
		}
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnPlayerFollowerUnPossessed;
		Action handle3;
		if ((handle3 = TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed) == null)
		{
			handle3 = (TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed = new Action(TowerDefensePlayerController.OnPlayerFollowerUnPossessed));
		}
		if (instance3.Has(name3, handle3))
		{
			EventSystem instance4 = EventSystem.Instance;
			EEventName name4 = EEventName.OnPlayerFollowerUnPossessed;
			Action handle4;
			if ((handle4 = TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed) == null)
			{
				handle4 = (TowerDefensePlayerController.<>O.<1>__OnPlayerFollowerUnPossessed = new Action(TowerDefensePlayerController.OnPlayerFollowerUnPossessed));
			}
			instance4.Remove(name4, handle4);
		}
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.OnPlayerFollowerPossessed;
		Action<EntityHandle> handle5;
		if ((handle5 = TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed) == null)
		{
			handle5 = (TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed = new Action<EntityHandle>(TowerDefensePlayerController.OnPlayerFollowerPossessed));
		}
		if (instance5.Has(name5, handle5))
		{
			EventSystem instance6 = EventSystem.Instance;
			EEventName name6 = EEventName.OnPlayerFollowerPossessed;
			Action<EntityHandle> handle6;
			if ((handle6 = TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed) == null)
			{
				handle6 = (TowerDefensePlayerController.<>O.<2>__OnPlayerFollowerPossessed = new Action<EntityHandle>(TowerDefensePlayerController.OnPlayerFollowerPossessed));
			}
			instance6.Remove(name6, handle6);
		}
		TowerDefensePlayerController.ClearFollowerKSCData();
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		if (model != null)
		{
			model.OnStop();
		}
		return true;
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x0011ED32 File Offset: 0x0011CF32
	[NullableContext(1)]
	public static bool CheckPlayerFollowerMatch(EntityHandle followerHandle)
	{
		return followerHandle.Entity.GetComponent<CreatureDataComponent>().TrapAuxiliaryConfigIds != null;
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x0011ED48 File Offset: 0x0011CF48
	public static EntityHandle GetPlayerEntityHandle()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(playerId);
		long? num;
		if (teamPlayerData == null)
		{
			num = null;
		}
		else
		{
			SceneTeamGroup currentGroup = teamPlayerData.GetCurrentGroup();
			if (currentGroup == null)
			{
				num = null;
			}
			else
			{
				SceneTeamRole currentRole = currentGroup.GetCurrentRole();
				num = ((currentRole != null) ? new long?(currentRole.CreatureDataId) : null);
			}
		}
		long? num2 = num;
		return CreatureModel.Instance.GetEntity(num2.GetValueOrDefault());
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x0011EDC0 File Offset: 0x0011CFC0
	public static void TryInitKSCEnityt()
	{
		if (!TowerDefensePlayerController.Model.TowerDefenseWorldDone || TowerDefensePlayerController.Model.PendingFollowerCreatureId == null || TowerDefensePlayerController.Model.PendingFollowers == null)
		{
			return;
		}
		if (TowerDefensePlayerController.Model.HasInitKSCEntity)
		{
			return;
		}
		TowerDefensePlayerController.Model.HasInitKSCEntity = true;
		TowerDefensePlayerController.Model.PossessedFollowerHandle = new KscEntityHandle(null, TowerDefensePlayerController.Model.PendingFollowerCreatureId.Value);
		TowerDefensePlayerController.DoPossessFollowerProxy(TowerDefensePlayerController.Model.PendingFollowers);
		if (TowerDefensePlayerController.Model.CurrentFollowerProxyId == null)
		{
			TowerDefenseFollowerProxy primaryPossessedFollowerProxy = TowerDefensePlayerController.GetPrimaryPossessedFollowerProxy();
			if (primaryPossessedFollowerProxy != null && primaryPossessedFollowerProxy.ProxyId != null)
			{
				TowerDefensePlayerController.SetFollowerProxy(primaryPossessedFollowerProxy.ProxyId.Value);
			}
		}
		else
		{
			TowerDefensePlayerController.SetFollowerProxy(TowerDefensePlayerController.Model.CurrentFollowerProxyId.Value);
		}
		TowerDefensePlayerController.EnablePlayerFollower(TowerDefensePlayerController.Model.CurrentFollowerEnable);
		TowerDefensePlayerController.DoPlayerFollowerEnableChange(TowerDefensePlayerController.Model.CurrentFollowerEnable);
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x0011EEA8 File Offset: 0x0011D0A8
	[NullableContext(1)]
	private static void SetPendingFollowers(int[] proxyIds)
	{
		if (TowerDefensePlayerController.Model.PendingFollowers == null)
		{
			TowerDefensePlayerController.Model.PendingFollowers = Array.Empty<int>();
		}
		TowerDefensePlayerController.Model.PendingFollowers = proxyIds;
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x0011EED0 File Offset: 0x0011D0D0
	public static void DoPossessRole(EntityHandle entityHandle)
	{
		if (KscEnv.Instance.KscWorld == null)
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防感知玩家角色,世界非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (entityHandle == null || !entityHandle.Valid)
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防感知玩家角色,entity非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.PZ;
		UObject kscWorld = KscEnv.Instance.KscWorld;
		string log = "塔防感知玩家角色";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Spawned Player", entityHandle.Id);
		KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TowerDefensePlayerController.DoPossessRole_Impl(entityHandle);
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x0011EF78 File Offset: 0x0011D178
	[NullableContext(1)]
	private unsafe static void DoPossessRole_Impl(EntityHandle entityHandle)
	{
		if (TowerDefensePlayerController.Model.PossessedPlayerHandle != null)
		{
			long creatureDataId = TowerDefensePlayerController.Model.PossessedPlayerHandle.CreatureDataId;
			TowerDefensePlayerController.Model.PossessedPlayerHandle.CreatureDataId = entityHandle.CreatureDataId;
			TowerDefenseInputController.AddInputLayer();
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防绑定玩家战斗实体刷新";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old creature", creatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new creature", entityHandle.CreatureDataId);
			KscLog.Info(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		TowerDefenseInputController.AddInputLayer();
		if (entityHandle.Entity != null)
		{
			CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
			TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
			FTransformDouble transform = (tsBaseCharacter != null) ? tsBaseCharacter.D_GetTransform() : new FTransformDouble();
			KuroSimpleCombatController.Instance.AddEntityDt(entityHandle.CreatureDataId, TowerDefensePlayerModel.PlayerEntityKey, null, transform, delegate(AKSC_Entity kscEntity)
			{
				TowerDefensePlayerController.Model.PossessedPlayerHandle = new KscEntityHandle(kscEntity, entityHandle.CreatureDataId);
				KscLog.EModule flag2 = KscLog.EModule.Common;
				ELogAuthor author2 = ELogAuthor.PZ;
				UObject kscWorld2 = KscEnv.Instance.KscWorld;
				string log2 = "塔防绑定玩家战斗实体";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entity", entityHandle.Entity);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("creature", entityHandle.CreatureDataId);
				KscLog.Info(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			});
			return;
		}
		KscLog.Warn(KscLog.EModule.Common, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防绑定玩家战斗实体失败", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x0011F0D0 File Offset: 0x0011D2D0
	public static KscEntityHandle GetPossessedPlayer()
	{
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		if (model == null)
		{
			return null;
		}
		return model.PossessedPlayerHandle;
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x0011F0E2 File Offset: 0x0011D2E2
	public static EntityHandle GetPossessedPlayerEntity()
	{
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		if (model == null)
		{
			return null;
		}
		return model.PendingRoleHandle;
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x0011F0F4 File Offset: 0x0011D2F4
	[NullableContext(1)]
	private static void DoPossessFollowerProxy(int[] proxyIds)
	{
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies == null)
		{
			TowerDefensePlayerController.Model.PossessedFollowerProxies = new Dictionary<int, TowerDefenseFollowerProxy>();
		}
		TowerDefensePlayerController.Model.PossessedFollowerProxies.Clear();
		foreach (int num in proxyIds)
		{
			TowerDefenseFollowerProxy towerDefenseFollowerProxy = new TowerDefenseFollowerProxy(new int?(num));
			int[] followerSkillIdsByProxy = KscUtil.GetFollowerSkillIdsByProxy(num);
			int? followerPropertyIdByProxy = KscUtil.GetFollowerPropertyIdByProxy(num);
			towerDefenseFollowerProxy.SkillIds = followerSkillIdsByProxy;
			towerDefenseFollowerProxy.PropertyId = followerPropertyIdByProxy;
			TowerDefensePlayerController.Model.PossessedFollowerProxies[num] = towerDefenseFollowerProxy;
		}
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x0011F17C File Offset: 0x0011D37C
	private static TowerDefenseFollowerProxy GetPossessedFollowerProxy(int proxyId)
	{
		Dictionary<int, TowerDefenseFollowerProxy> possessedFollowerProxies = TowerDefensePlayerController.Model.PossessedFollowerProxies;
		TowerDefenseFollowerProxy result;
		if (possessedFollowerProxies == null || !possessedFollowerProxies.TryGetValue(proxyId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x0011F1A8 File Offset: 0x0011D3A8
	private static TowerDefenseFollowerProxy GetPrimaryPossessedFollowerProxy()
	{
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies == null)
		{
			return null;
		}
		using (Dictionary<int, TowerDefenseFollowerProxy>.Enumerator enumerator = TowerDefensePlayerController.Model.PossessedFollowerProxies.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, TowerDefenseFollowerProxy> keyValuePair = enumerator.Current;
				return TowerDefensePlayerController.GetPossessedFollowerProxy(keyValuePair.Key);
			}
		}
		return null;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x0011F218 File Offset: 0x0011D418
	private static void AddRouletteGameplayTag()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		if (playerEntity == null)
		{
			return;
		}
		BaseTagComponent component = playerEntity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["TowerDefence.轮盘"]));
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x0011F264 File Offset: 0x0011D464
	private static void RemoveRouletteGameplayTag()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		if (playerEntity == null)
		{
			return;
		}
		BaseTagComponent component = playerEntity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		component.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["TowerDefence.轮盘"]));
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x0011F2B0 File Offset: 0x0011D4B0
	private static void OnPlayerFollowerEnableChange(bool isEnable)
	{
		if (KscEnv.Instance.KscWorld == null)
		{
			return;
		}
		TowerDefensePlayerController.DoPlayerFollowerEnableChange(isEnable);
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x0011F2C5 File Offset: 0x0011D4C5
	[NullableContext(1)]
	private static void OnPlayerFollowerPossessed(EntityHandle followerHandle)
	{
		TowerDefensePlayerController.DoPlayerFollowerCreate(followerHandle);
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x0011F2CD File Offset: 0x0011D4CD
	private static void OnPlayerFollowerUnPossessed()
	{
		TowerDefensePlayerController.DoPlayerFollowerDestroy();
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x0011F2D4 File Offset: 0x0011D4D4
	public static void TogglePlayerFollower()
	{
		TowerDefensePlayerController.EnablePlayerFollower(!TowerDefensePlayerController.IsPlayerFollowerEnabled());
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x0011F2E3 File Offset: 0x0011D4E3
	public static void EnablePlayerFollower(bool isEnable)
	{
		TowerDefensePlayerController.Model.CurrentFollowerEnable = isEnable;
		FollowUtils.SetPlayerFollowShooterEnable(CreatureModel.Instance.GetPlayerId(), isEnable, BPEEnableFollowShooter.GameAbility, "");
		if (!isEnable)
		{
			TowerDefensePlayerController.RemoveChargeEffect();
			TowerDefensePlayerController.SetFollowerSKillAutoCast(false, true);
		}
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x0011F318 File Offset: 0x0011D518
	public unsafe static void DoPlayerFollowerEnableChange(bool isEnable)
	{
		if (isEnable)
		{
			KscEntityHandle possessedFollowerHandle = TowerDefensePlayerController.Model.PossessedFollowerHandle;
			if (possessedFollowerHandle != null && !possessedFollowerHandle.Valid && !TowerDefensePlayerController.Model.IsInFollowerInit)
			{
				long creatureDataId = TowerDefensePlayerController.Model.PossessedFollowerHandle.CreatureDataId;
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(creatureDataId);
				WorldEntity entity = (entity2 != null) ? entity2.Entity : null;
				if (entity == null)
				{
					KscLog.EModule flag = KscLog.EModule.Common;
					ELogAuthor author = ELogAuthor.PZ;
					UObject kscWorld = KscEnv.Instance.KscWorld;
					string log = "塔防跟随物更新可用性;绑定实体不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureId", creatureDataId);
					KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				KscLog.EModule flag2 = KscLog.EModule.Common;
				ELogAuthor author2 = ELogAuthor.PZ;
				UObject kscWorld2 = KscEnv.Instance.KscWorld;
				string log2 = "塔防跟随物更新";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entity", entity);
				KscLog.Info(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				FTransformDouble transform = (tsBaseCharacter != null) ? tsBaseCharacter.D_GetTransform() : new FTransformDouble();
				ValueTuple<FKSCEntityTableRow, string> valueTuple3;
				KuroSimpleCombatController.Instance.CurSubModel.EntityDataDt.TryGetValue(TowerDefensePlayerModel.FollowerEntityKey, out valueTuple3);
				string item = valueTuple3.Item2;
				CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
				EntityComponentPb entityComponentPb;
				SimpleCombatComponentPb combatComponent = component2.ComponentDataMap.TryGetValue("SimpleCombatComponentPb", out entityComponentPb) ? ((entityComponentPb != null) ? entityComponentPb.SimpleCombatComponentPb : null) : null;
				if (!string.IsNullOrEmpty(item))
				{
					TowerDefensePlayerController.Model.IsInFollowerInit = true;
					KuroSimpleCombatController.Instance.AsyncAddEntity(new KscEntityParam
					{
						CreatureId = creatureDataId,
						SimpleCombatId = TowerDefensePlayerModel.FollowerEntityKey,
						AssetPath = item,
						PropertyId = 0,
						Transform = transform,
						Buffs = ((combatComponent == null) ? null : new Dictionary<int, int>(combatComponent.BuffLayers)),
						FinishCallback = delegate(AKSC_Entity kscEntity)
						{
							KscLog.EModule flag4 = KscLog.EModule.Common;
							ELogAuthor author4 = ELogAuthor.PZ;
							UObject kscWorld4 = KscEnv.Instance.KscWorld;
							string log4 = "塔防跟随物绑定";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entity", entity);
							ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
							string item3 = "buff";
							SimpleCombatComponentPb combatComponent = combatComponent;
							ptr2 = new ValueTuple<string, object>(item3, (combatComponent != null) ? combatComponent.BuffLayers : null);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("kscHandle", TowerDefensePlayerController.Model.PossessedFollowerHandle);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("kscEntity", kscEntity);
							KscLog.Info(flag4, author4, kscWorld4, log4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
							KscEntityHandle possessedFollowerHandle3 = TowerDefensePlayerController.Model.PossessedFollowerHandle;
							if (possessedFollowerHandle3 != null)
							{
								possessedFollowerHandle3.SetKscEntity(kscEntity);
							}
							TowerDefensePlayerController.InitAllFollowerSkill();
							TowerDefensePlayerController.RefreshFollowerData();
							TowerDefensePlayerController.ListenFollowerCDAttribute();
							TowerDefensePlayerController.Model.IsInFollowerInit = false;
						}
					});
					return;
				}
				return;
			}
		}
		KscLog.EModule flag3 = KscLog.EModule.Common;
		ELogAuthor author3 = ELogAuthor.PZ;
		UObject kscWorld3 = KscEnv.Instance.KscWorld;
		string log3 = "塔防跟随物更新可用性";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isEnable", isEnable);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item2 = "kscValid";
		KscEntityHandle possessedFollowerHandle2 = TowerDefensePlayerController.Model.PossessedFollowerHandle;
		ptr = new ValueTuple<string, object>(item2, (possessedFollowerHandle2 != null) ? new bool?(possessedFollowerHandle2.Valid) : null);
		KscLog.Info(flag3, author3, kscWorld3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		if (possessedFollowerKscEntity != null)
		{
			possessedFollowerKscEntity.SetActorHiddenInGame(!isEnable);
			TArray<AActor> tarray = new TArray<AActor>();
			possessedFollowerKscEntity.GetAttachedActors(ref tarray, true);
			for (int i = 0; i < tarray.Num(); i++)
			{
				tarray.Get(i).SetActorHiddenInGame(!isEnable);
			}
		}
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x0011F5E4 File Offset: 0x0011D7E4
	private unsafe static void InitAllFollowerSkill()
	{
		Dictionary<string, int> followerSkillName2Index = TowerDefensePlayerController.GetFollowerSkillName2Index(TowerDefensePlayerController.Model.PossessedFollowerKscEntity);
		if (followerSkillName2Index == null)
		{
			KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "辅助机技能索引异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Dictionary<int, ValueTuple<FKSCSkillTableRow, string>> allSkillDataDt = KuroSimpleCombatController.Instance.GetAllSkillDataDt();
		if (TowerDefensePlayerController.Model.AllSkillId2SkillData == null)
		{
			TowerDefensePlayerController.Model.AllSkillId2SkillData = new Dictionary<int, TDPlayerDefine.ISkill>();
		}
		else
		{
			TowerDefensePlayerController.Model.AllSkillId2SkillData.Clear();
		}
		foreach (KeyValuePair<int, ValueTuple<FKSCSkillTableRow, string>> keyValuePair in allSkillDataDt)
		{
			FKSCSkillTableRow item = keyValuePair.Value.Item1;
			string item2 = keyValuePair.Value.Item2;
			int id = item.Id;
			int skillId = item.SkillId;
			EKSC_OperateType operateType = item.OperateType;
			if (skillId > 0)
			{
				TDPlayerDefine.Skill value = new TDPlayerDefine.Skill
				{
					SkillType = TDPlayerDefine.ESkillType.MontageSkill,
					SkillId = skillId,
					Time = item.PressTime,
					ChargeCueId = item.ChargeCueId,
					ChargeFullCueId = item.ChargeFullCueId,
					PsFeedback = item.PsFeedbackId,
					OperateType = item.OperateType
				};
				TowerDefensePlayerController.Model.AllSkillId2SkillData[id] = value;
			}
			else
			{
				string text = KscUtil.AssetPath2Name(item2);
				int skillId2;
				if (string.IsNullOrEmpty(text))
				{
					KscLog.EModule flag = KscLog.EModule.Skill;
					ELogAuthor author = ELogAuthor.PZ;
					UObject kscWorld = KscEnv.Instance.KscWorld;
					string log = "跟随物技能初始化忽略,名称异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rowId", id);
					KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (!followerSkillName2Index.TryGetValue(text, out skillId2))
				{
					KscLog.EModule flag2 = KscLog.EModule.Skill;
					ELogAuthor author2 = ELogAuthor.PZ;
					UObject kscWorld2 = KscEnv.Instance.KscWorld;
					string log2 = "跟随物技能初始化忽略,索引异常";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rowId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("name", text);
					KscLog.Info(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					TDPlayerDefine.Skill value2 = new TDPlayerDefine.Skill
					{
						SkillType = TDPlayerDefine.ESkillType.KscSkill,
						SkillId = skillId2,
						Time = item.PressTime,
						ChargeCueId = item.ChargeCueId,
						ChargeFullCueId = item.ChargeFullCueId,
						PsFeedback = item.PsFeedbackId,
						OperateType = item.OperateType
					};
					TowerDefensePlayerController.Model.AllSkillId2SkillData[id] = value2;
				}
			}
		}
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x0011F870 File Offset: 0x0011DA70
	public unsafe static void SetFollowerProxy(int proxyId)
	{
		TowerDefensePlayerController.Model.CurrentFollowerProxyId = new int?(proxyId);
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies == null)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防辅助机数据未初始化完成,等待初始化完成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", proxyId);
			KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies.Count <= 0)
		{
			KscLog.EModule flag2 = KscLog.EModule.Common;
			ELogAuthor author2 = ELogAuthor.PZ;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "塔防辅助机切换索引异常,没有捕获数据";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", proxyId);
			KscLog.Warn(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		TowerDefenseFollowerProxy item;
		if (!TowerDefensePlayerController.Model.PossessedFollowerProxies.TryGetValue(proxyId, out item))
		{
			KscLog.EModule flag3 = KscLog.EModule.Common;
			ELogAuthor author3 = ELogAuthor.PZ;
			UObject kscWorld3 = KscEnv.Instance.KscWorld;
			string log3 = "塔防辅助机切换索引异常,找不到id";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", proxyId);
			KscLog.Warn(flag3, author3, kscWorld3, log3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		KscLog.EModule flag4 = KscLog.EModule.Common;
		ELogAuthor author4 = ELogAuthor.PZ;
		UObject kscWorld4 = KscEnv.Instance.KscWorld;
		string log4 = "塔防辅助机切换索引";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("proxy id", proxyId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("proxy", item);
		KscLog.Info(flag4, author4, kscWorld4, log4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		TowerDefensePlayerController.RefreshFollowerData();
		float followerSkillRemainCD = TowerDefensePlayerController.GetFollowerSkillRemainCD(proxyId);
		KscLog.EModule flag5 = KscLog.EModule.Common;
		ELogAuthor author5 = ELogAuthor.PZ;
		UObject kscWorld5 = KscEnv.Instance.KscWorld;
		string log5 = "TZQ Debug";
		ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("cd", followerSkillRemainCD);
		KscLog.Info(flag5, author5, kscWorld5, log5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x0011F9EC File Offset: 0x0011DBEC
	public static int? GetFollowerProxyId()
	{
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		if (model == null)
		{
			return null;
		}
		return model.CurrentFollowerProxyId;
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x0011FA14 File Offset: 0x0011DC14
	private static void RefreshFollowerData()
	{
		TowerDefensePlayerController.UnBindFollowerOperateSkills();
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		TowerDefensePlayerController.BindFollowerOperateSkills(possessedFollowerKscEntity, TowerDefensePlayerController.Model.CurrentFollowerProxyId);
		TowerDefensePlayerController.BindFollowerAttrs(possessedFollowerKscEntity, TowerDefensePlayerController.Model.CurrentFollowerProxyId);
		TowerDefensePlayerController.SetListenSkillCD(possessedFollowerKscEntity, TowerDefensePlayerController.Model.CurrentFollowerProxyId);
		TowerDefensePlayerController.UpdateFollowMontageSkillCD();
		TowerDefensePlayerController.RemoveChargeEffect();
		TowerDefensePlayerController.RefreshFollowerCue();
		TowerDefensePlayerController.SetFollowerState(TDPlayerDefine.EFollowerState.None);
		TowerDefensePlayerController.ClearFollowerCdCue();
		TowerDefensePlayerController.RefreshFolloerCdCue(null);
		TowerDefensePlayerController.Model.IsInCharge = false;
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x0011FA8A File Offset: 0x0011DC8A
	public static bool IsPlayerFollowerEnabled()
	{
		return TowerDefensePlayerController.Model.PossessedFollowerEnabled;
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x0011FA98 File Offset: 0x0011DC98
	public unsafe static void DoPlayerFollowerCreate(EntityHandle followerHandle)
	{
		if (followerHandle == null)
		{
			KscLog.Warn(KscLog.EModule.Common, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防跟随物记录Id失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		long creatureDataId = followerHandle.CreatureDataId;
		int[] trapAuxiliaryConfigIds = followerHandle.Entity.GetComponent<CreatureDataComponent>().TrapAuxiliaryConfigIds;
		if (trapAuxiliaryConfigIds == null)
		{
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防辅助机监听创建不匹配";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entity", followerHandle.Entity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("creatureId", followerHandle.CreatureDataId);
			KscLog.Info(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		KscLog.EModule flag2 = KscLog.EModule.Common;
		ELogAuthor author2 = ELogAuthor.PZ;
		UObject kscWorld2 = KscEnv.Instance.KscWorld;
		string log2 = "检测到塔防辅助机实体加入";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("entity", followerHandle.Entity);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("configs", trapAuxiliaryConfigIds);
		KscLog.Info(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		TowerDefensePlayerController.Model.PendingFollowerCreatureId = new long?(followerHandle.CreatureDataId);
		TowerDefensePlayerController.SetPendingFollowers(trapAuxiliaryConfigIds);
		TowerDefensePlayerController.TryInitKSCEnityt();
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x0011FBCC File Offset: 0x0011DDCC
	public unsafe static void DoPlayerFollowerDestroy()
	{
		KscEntityHandle possessedFollowerHandle = TowerDefensePlayerController.Model.PossessedFollowerHandle;
		long? num = (possessedFollowerHandle != null) ? new long?(possessedFollowerHandle.CreatureDataId) : null;
		KscLog.EModule flag = KscLog.EModule.Common;
		ELogAuthor author = ELogAuthor.PZ;
		UObject kscWorld = KscEnv.Instance.KscWorld;
		string log = "塔防跟随物移除战斗实体";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("creatureId", num);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "kscEntity";
		KscEntityHandle possessedFollowerHandle2 = TowerDefensePlayerController.Model.PossessedFollowerHandle;
		ptr = new ValueTuple<string, object>(item, (possessedFollowerHandle2 != null) ? possessedFollowerHandle2.KscEntity : null);
		KscLog.Info(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (num != null)
		{
			KuroSimpleCombatController.Instance.RemoveEntity(num.Value, TowerDefensePlayerController.EKSC_REMOVE_REASON_FOLLOWER);
		}
		TowerDefensePlayerController.Model.PossessedFollowerHandle = null;
		TowerDefensePlayerController.UnBindFollowerOperateSkills();
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x0011FC9D File Offset: 0x0011DE9D
	public static void D_Fire(FTransformDouble transform, int skillIndex)
	{
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		if (possessedFollowerKscEntity == null)
		{
			return;
		}
		possessedFollowerKscEntity.D_Fire(transform, skillIndex);
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x0011FCB6 File Offset: 0x0011DEB6
	[NullableContext(1)]
	public static void BeginSkillFollower(TDPlayerDefine.ISkill skillData)
	{
		if (skillData.SkillType == TDPlayerDefine.ESkillType.KscSkill)
		{
			TowerDefensePlayerController.BeginKSCSkillFollower(skillData);
			return;
		}
		TowerDefensePlayerController.BeginMontageSkillFollower(skillData);
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x0011FCD0 File Offset: 0x0011DED0
	[NullableContext(1)]
	public static void BeginKSCSkillFollower(TDPlayerDefine.ISkill skillData)
	{
		AActor possessedFollowerActor = TowerDefensePlayerController.Model.PossessedFollowerActor;
		if (possessedFollowerActor != null)
		{
			TowerDefensePlayerController.D_Fire(possessedFollowerActor.D_GetTransform(), skillData.SkillId);
		}
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x0011FCFC File Offset: 0x0011DEFC
	[NullableContext(1)]
	private static void DispatchEnterCD(TDPlayerDefine.ISkill skillData, CharacterSkillCdComponent skillCDComp)
	{
		if (TowerDefensePlayerController.Model.CurrentFollowerProxyId == null)
		{
			return;
		}
		TDPlayerDefine.ISkill followListenSkillData = TowerDefensePlayerController.GetFollowListenSkillData(TowerDefensePlayerController.Model.CurrentFollowerProxyId.Value);
		if (followListenSkillData == null || followListenSkillData != skillData)
		{
			return;
		}
		float? num;
		if (skillCDComp == null)
		{
			num = null;
		}
		else
		{
			GroupSkillCdInfo groupSkillCdInfo = skillCDComp.GetGroupSkillCdInfo(skillData.SkillId);
			num = ((groupSkillCdInfo != null) ? new float?(groupSkillCdInfo.CurMaxCd) : null);
		}
		float? num2 = num;
		if (num2 != null)
		{
			float? num3 = num2;
			float num4 = 0f;
			if (num3.GetValueOrDefault() > num4 & num3 != null)
			{
				TowerDefensePlayerController.OnFollowerEnterSkillCd(0, num2.Value);
			}
		}
	}

	// Token: 0x06003216 RID: 12822 RVA: 0x0011FDA0 File Offset: 0x0011DFA0
	[NullableContext(1)]
	public static void BeginMontageSkillFollower(TDPlayerDefine.ISkill skillData)
	{
		int skillId = skillData.SkillId;
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		BaseSkillComponent baseSkillComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<BaseSkillComponent>() : null;
		Entity possessedFollowerEntity2 = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		CharacterSkillCdComponent characterSkillCdComponent = (possessedFollowerEntity2 != null) ? possessedFollowerEntity2.GetComponent<CharacterSkillCdComponent>() : null;
		if (baseSkillComponent == null || characterSkillCdComponent == null || characterSkillCdComponent.IsSkillInCd(skillId, true) || !baseSkillComponent.Active)
		{
			return;
		}
		TowerDefensePlayerController.BeginMontageSkillFollowerAsync(skillData, baseSkillComponent, characterSkillCdComponent).Forget();
	}

	// Token: 0x06003217 RID: 12823 RVA: 0x0011FE08 File Offset: 0x0011E008
	[NullableContext(1)]
	private static UniTask BeginMontageSkillFollowerAsync(TDPlayerDefine.ISkill skillData, BaseSkillComponent skillComp, CharacterSkillCdComponent skillCDComp)
	{
		TowerDefensePlayerController.<BeginMontageSkillFollowerAsync>d__45 <BeginMontageSkillFollowerAsync>d__;
		<BeginMontageSkillFollowerAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeginMontageSkillFollowerAsync>d__.skillData = skillData;
		<BeginMontageSkillFollowerAsync>d__.skillComp = skillComp;
		<BeginMontageSkillFollowerAsync>d__.skillCDComp = skillCDComp;
		<BeginMontageSkillFollowerAsync>d__.<>1__state = -1;
		<BeginMontageSkillFollowerAsync>d__.<>t__builder.Start<TowerDefensePlayerController.<BeginMontageSkillFollowerAsync>d__45>(ref <BeginMontageSkillFollowerAsync>d__);
		return <BeginMontageSkillFollowerAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003218 RID: 12824 RVA: 0x0011FE5C File Offset: 0x0011E05C
	public static TDPlayerDefine.ISkill GetFollowerSkillByOperateType(EKSC_OperateType operateType, float time)
	{
		if (TowerDefensePlayerController.Model.BindFollowerSkills == null || TowerDefensePlayerController.Model.BindFollowerSkills.Count == 0)
		{
			return null;
		}
		List<TDPlayerDefine.ISkill> list;
		if (!TowerDefensePlayerController.Model.BindFollowerSkills.TryGetValue(operateType, out list))
		{
			return null;
		}
		foreach (TDPlayerDefine.ISkill skill in list)
		{
			if (time >= skill.Time)
			{
				return skill;
			}
		}
		return null;
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x0011FEE8 File Offset: 0x0011E0E8
	private static void TryBeginMontageSkillFollower()
	{
		List<TDPlayerDefine.ISkill> list;
		if (TowerDefensePlayerController.Model.BindFollowerSkills == null || !TowerDefensePlayerController.Model.BindFollowerSkills.TryGetValue(EKSC_OperateType.AutoCast, out list) || list == null)
		{
			return;
		}
		foreach (TDPlayerDefine.ISkill skill in list)
		{
			if (skill.SkillType == TDPlayerDefine.ESkillType.MontageSkill)
			{
				TowerDefensePlayerController.BeginMontageSkillFollower(skill);
			}
		}
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x0011FF64 File Offset: 0x0011E164
	[NullableContext(1)]
	public static void OnCharSkillCountChanged(GroupSkillCdInfo cdInfo)
	{
		TowerDefensePlayerController.TryBeginMontageSkillFollower();
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x0011FF6B File Offset: 0x0011E16B
	public static void OnFollowerMontageSkillEnd(int entityId, int skillId)
	{
		TowerDefensePlayerController.TryBeginMontageSkillFollower();
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x0011FF74 File Offset: 0x0011E174
	public static void SetFollowerSKillAutoCast(bool bEnable, bool bForce)
	{
		if (TowerDefensePlayerController.Model.IsInAutoCast == bEnable && !bForce)
		{
			return;
		}
		TowerDefensePlayerController.Model.IsInAutoCast = bEnable;
		bool flag = false;
		List<TDPlayerDefine.ISkill> list;
		if (TowerDefensePlayerController.Model.BindFollowerSkills == null || !TowerDefensePlayerController.Model.BindFollowerSkills.TryGetValue(EKSC_OperateType.AutoCast, out list) || list == null)
		{
			return;
		}
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		if (possessedFollowerKscEntity == null || possessedFollowerEntity == null)
		{
			KscLog.Warn(KscLog.EModule.Input, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防辅助机:自动射击更改失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (TDPlayerDefine.ISkill skill in list)
		{
			if (skill.SkillType == TDPlayerDefine.ESkillType.MontageSkill)
			{
				if (bEnable)
				{
					TowerDefensePlayerController.BeginMontageSkillFollower(skill);
				}
				flag = true;
			}
			else
			{
				AKSC_Entity_AssistMachine aksc_Entity_AssistMachine = possessedFollowerKscEntity;
				int skillId = skill.SkillId;
				aksc_Entity_AssistMachine.SetSkillAutoCast(skillId, bEnable ? EKSC_SkillAutoCast.AutoCast : EKSC_SkillAutoCast.ManualCast);
			}
		}
		if (flag || bForce)
		{
			if (bEnable)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.CharSkillCountChanged;
				Action<GroupSkillCdInfo> handle;
				if ((handle = TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged) == null)
				{
					handle = (TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.OnCharSkillCountChanged));
				}
				if (!instance.Has<GroupSkillCdInfo>(name, handle))
				{
					EventSystem instance2 = EventSystem.Instance;
					EEventName name2 = EEventName.CharSkillCountChanged;
					Action<GroupSkillCdInfo> handle2;
					if ((handle2 = TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged) == null)
					{
						handle2 = (TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.OnCharSkillCountChanged));
					}
					instance2.Add<GroupSkillCdInfo>(name2, handle2);
				}
				EventSystem instance3 = EventSystem.Instance;
				object target = possessedFollowerEntity;
				EEventName name3 = EEventName.OnSkillEnd;
				Action<int, int> handle3;
				if ((handle3 = TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd) == null)
				{
					handle3 = (TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd = new Action<int, int>(TowerDefensePlayerController.OnFollowerMontageSkillEnd));
				}
				if (!instance3.HasWithTarget<int, int>(target, name3, handle3))
				{
					EventSystem instance4 = EventSystem.Instance;
					object target2 = possessedFollowerEntity;
					EEventName name4 = EEventName.OnSkillEnd;
					Action<int, int> handle4;
					if ((handle4 = TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd) == null)
					{
						handle4 = (TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd = new Action<int, int>(TowerDefensePlayerController.OnFollowerMontageSkillEnd));
					}
					instance4.AddWithTarget<int, int>(target2, name4, handle4);
					return;
				}
			}
			else
			{
				EventSystem instance5 = EventSystem.Instance;
				EEventName name5 = EEventName.CharSkillCountChanged;
				Action<GroupSkillCdInfo> handle5;
				if ((handle5 = TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged) == null)
				{
					handle5 = (TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.OnCharSkillCountChanged));
				}
				if (instance5.Has<GroupSkillCdInfo>(name5, handle5))
				{
					EventSystem instance6 = EventSystem.Instance;
					EEventName name6 = EEventName.CharSkillCountChanged;
					Action<GroupSkillCdInfo> handle6;
					if ((handle6 = TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged) == null)
					{
						handle6 = (TowerDefensePlayerController.<>O.<3>__OnCharSkillCountChanged = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.OnCharSkillCountChanged));
					}
					instance6.Remove<GroupSkillCdInfo>(name6, handle6);
				}
				EventSystem instance7 = EventSystem.Instance;
				object target3 = possessedFollowerEntity;
				EEventName name7 = EEventName.OnSkillEnd;
				Action<int, int> handle7;
				if ((handle7 = TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd) == null)
				{
					handle7 = (TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd = new Action<int, int>(TowerDefensePlayerController.OnFollowerMontageSkillEnd));
				}
				if (instance7.HasWithTarget<int, int>(target3, name7, handle7))
				{
					EventSystem instance8 = EventSystem.Instance;
					object target4 = possessedFollowerEntity;
					EEventName name8 = EEventName.OnSkillEnd;
					Action<int, int> handle8;
					if ((handle8 = TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd) == null)
					{
						handle8 = (TowerDefensePlayerController.<>O.<4>__OnFollowerMontageSkillEnd = new Action<int, int>(TowerDefensePlayerController.OnFollowerMontageSkillEnd));
					}
					instance8.RemoveWithTarget<int, int>(target4, name8, handle8);
				}
			}
		}
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x001201C8 File Offset: 0x0011E3C8
	public static void SetFollowerState(TDPlayerDefine.EFollowerState followerState)
	{
		TDPlayerDefine.EFollowerState followerState2 = TowerDefensePlayerController.Model.FollowerState;
		TowerDefensePlayerController.Model.FollowerState = followerState;
		if (followerState2 != followerState)
		{
			EventSystem.Instance.Emit(EEventName.RefreshTrapDefensePsFeedback);
		}
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x001201F4 File Offset: 0x0011E3F4
	public static void ClearFollowerCdCue()
	{
		if (TowerDefensePlayerController.Model.FollowerCdCueHandle != null)
		{
			Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
			CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
			foreach (int num in TowerDefensePlayerController.Model.FollowerCdCueHandle)
			{
				if (characterGameplayCueComponent != null)
				{
					characterGameplayCueComponent.RemoveCueByHandle((long)num);
				}
			}
			TowerDefensePlayerController.Model.FollowerCdCueHandle = new List<int>();
		}
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x00120284 File Offset: 0x0011E484
	private static void OnSkillReady()
	{
		TowerDefensePlayerController.RefreshFolloerCdCue(null);
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x0012028C File Offset: 0x0011E48C
	[NullableContext(1)]
	public static void RefreshFolloerCdCue(GroupSkillCdInfo _ = null)
	{
		int? currentFollowerProxyId = TowerDefensePlayerController.Model.CurrentFollowerProxyId;
		if (currentFollowerProxyId == null)
		{
			return;
		}
		TDPlayerDefine.EFollowerState efollowerState;
		if (TowerDefensePlayerController.GetFollowerSkillRemainCD(currentFollowerProxyId.Value) > 0f)
		{
			efollowerState = TDPlayerDefine.EFollowerState.InCD;
		}
		else
		{
			efollowerState = TDPlayerDefine.EFollowerState.CDReady;
		}
		if (efollowerState == TowerDefensePlayerController.Model.FollowerState)
		{
			return;
		}
		TowerDefensePlayerController.ClearFollowerCdCue();
		TowerDefensePlayerController.SetFollowerState(efollowerState);
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
		int[] followerCdCueIds = KscUtil.GetFollowerCdCueIds(currentFollowerProxyId.Value, efollowerState);
		if (followerCdCueIds == null || characterGameplayCueComponent == null)
		{
			return;
		}
		if (TowerDefensePlayerController.Model.FollowerCdCueHandle == null)
		{
			TowerDefensePlayerController.Model.FollowerCdCueHandle = new List<int>();
		}
		foreach (int num in followerCdCueIds)
		{
			int item = characterGameplayCueComponent.AddCue((long)num, null);
			TowerDefensePlayerController.Model.FollowerCdCueHandle.Add(item);
		}
	}

	// Token: 0x06003221 RID: 12833 RVA: 0x0012036C File Offset: 0x0011E56C
	public static void RemoveFollowerCue()
	{
		if (TowerDefensePlayerController.Model.FollowCueHandle != null)
		{
			Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
			CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
			foreach (int num in TowerDefensePlayerController.Model.FollowCueHandle)
			{
				if (characterGameplayCueComponent != null)
				{
					characterGameplayCueComponent.RemoveCueByHandle((long)num);
				}
			}
			TowerDefensePlayerController.Model.FollowCueHandle.Clear();
		}
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x001203FC File Offset: 0x0011E5FC
	public static void RefreshFollowerCue()
	{
		TowerDefensePlayerController.RemoveFollowerCue();
		if (TowerDefensePlayerController.Model.CurrentFollowerProxyId == null)
		{
			return;
		}
		int[] followerCueIds = KscUtil.GetFollowerCueIds(TowerDefensePlayerController.Model.CurrentFollowerProxyId.Value);
		if (followerCueIds == null || followerCueIds.Length == 0)
		{
			return;
		}
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (characterGameplayCueComponent == null)
		{
			return;
		}
		if (TowerDefensePlayerController.Model.FollowCueHandle == null)
		{
			TowerDefensePlayerController.Model.FollowCueHandle = new List<int>();
		}
		foreach (int num in followerCueIds)
		{
			int item = characterGameplayCueComponent.AddCue((long)num, null);
			List<int> followCueHandle = TowerDefensePlayerController.Model.FollowCueHandle;
			if (followCueHandle != null)
			{
				followCueHandle.Add(item);
			}
		}
	}

	// Token: 0x06003223 RID: 12835 RVA: 0x001204B4 File Offset: 0x0011E6B4
	public static void SetPsFeedbackId(string PsFeedbackId)
	{
		string psFeedbackId = TowerDefensePlayerController.Model.PsFeedbackId;
		TowerDefensePlayerController.Model.PsFeedbackId = PsFeedbackId;
		if (psFeedbackId != PsFeedbackId)
		{
			EventSystem.Instance.Emit(EEventName.RefreshTrapDefensePsFeedback);
		}
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x001204E4 File Offset: 0x0011E6E4
	public static void RemoveChargeEffect()
	{
		if (TowerDefensePlayerController.Model.ChargeCueHandle > 0)
		{
			Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
			CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
			if (characterGameplayCueComponent != null)
			{
				characterGameplayCueComponent.RemoveCueByHandle((long)TowerDefensePlayerController.Model.ChargeCueHandle);
			}
			TowerDefensePlayerController.Model.ChargeCueHandle = 0;
		}
		TowerDefensePlayerController.Model.LastSkillChargeFull = false;
		TowerDefensePlayerController.Model.ChargeSkill = null;
		TowerDefensePlayerController.SetPsFeedbackId(null);
		TowerDefensePlayerController.Model.PsFeedbackId = null;
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x0012055C File Offset: 0x0011E75C
	public static void TryPlayCharageEffect(EKSC_OperateType operateType, float time)
	{
		if (operateType != EKSC_OperateType.OnHold)
		{
			TowerDefensePlayerController.RemoveChargeEffect();
			return;
		}
		List<TDPlayerDefine.ISkill> list;
		if (TowerDefensePlayerController.Model.BindFollowerSkills == null || !TowerDefensePlayerController.Model.BindFollowerSkills.TryGetValue(EKSC_OperateType.OnRelease, out list) || list == null || list.Count == 0)
		{
			return;
		}
		bool flag = false;
		TDPlayerDefine.ISkill skill = null;
		int num = -1;
		if (time > list[0].Time)
		{
			flag = true;
			skill = list[0];
			num = 0;
		}
		else
		{
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (time <= list[i].Time)
				{
					skill = list[i];
					num = i;
					break;
				}
			}
		}
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		Entity possessedFollowerEntity = model.PossessedFollowerEntity;
		CharacterGameplayCueComponent characterGameplayCueComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterGameplayCueComponent>() : null;
		if (characterGameplayCueComponent == null)
		{
			return;
		}
		if (flag && !model.LastSkillChargeFull)
		{
			model.LastSkillChargeFull = true;
			if (skill.ChargeFullCueId > 0)
			{
				characterGameplayCueComponent.AddCue((long)skill.ChargeFullCueId, new GameplayCueParam?(new GameplayCueParam
				{
					Instant = true
				}));
			}
			TowerDefensePlayerController.SetPsFeedbackId(skill.PsFeedback);
		}
		if (model.ChargeSkill == skill)
		{
			return;
		}
		if (model.ChargeSkill != null && model.ChargeSkill.ChargeFullCueId > 0)
		{
			characterGameplayCueComponent.AddCue((long)model.ChargeSkill.ChargeFullCueId, new GameplayCueParam?(new GameplayCueParam
			{
				Instant = true
			}));
		}
		if (model.ChargeCueHandle > 0)
		{
			characterGameplayCueComponent.RemoveCueByHandle((long)model.ChargeCueHandle);
			model.ChargeCueHandle = 0;
		}
		if (skill != null)
		{
			int chargeCueId = skill.ChargeCueId;
			if (skill.ChargeCueId > 0)
			{
				model.ChargeCueHandle = characterGameplayCueComponent.AddCue((long)skill.ChargeCueId, null);
			}
		}
		TowerDefensePlayerController.SetPsFeedbackId((num + 1 < list.Count) ? list[num + 1].PsFeedback : null);
		model.ChargeSkill = skill;
	}

	// Token: 0x06003226 RID: 12838 RVA: 0x00120734 File Offset: 0x0011E934
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<string, int> GetFollowerSkillName2Index(AKSC_Entity_AssistMachine kscEntity)
	{
		if (kscEntity == null)
		{
			KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "获取跟随物<技能名,索引>异常,错误的逻辑实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		UKSC_SkillComp skillComp = kscEntity.GetSkillComp();
		TArray<UKSC_Skill> tarray = (skillComp != null) ? skillComp.Skills_ : null;
		int? num = (tarray != null) ? new int?(tarray.Num()) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				int num4 = 0;
				for (;;)
				{
					int num5 = num4;
					num2 = num;
					if (!(num5 < num2.GetValueOrDefault() & num2 != null))
					{
						break;
					}
					UKSC_Skill uksc_Skill = tarray.Get(num4);
					UKSC_DA_Skill uksc_DA_Skill = (uksc_Skill != null) ? uksc_Skill.DaSkill_ : null;
					if (uksc_DA_Skill == null)
					{
						KscLog.EModule flag = KscLog.EModule.Skill;
						ELogAuthor author = ELogAuthor.PZ;
						UObject kscWorld = KscEnv.Instance.KscWorld;
						string log = "获取跟随物<技能名,索引>忽略";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", num4);
						KscLog.Info(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						string name = uksc_DA_Skill.GetName();
						dictionary[name] = num4;
					}
					num4++;
				}
				return dictionary;
			}
		}
		KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "获取跟随物<技能名,索引>异常,实体没有技能", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x06003227 RID: 12839 RVA: 0x00120866 File Offset: 0x0011EA66
	private static int[] GetFollowerProxySkillIds(int proxyId)
	{
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies == null || TowerDefensePlayerController.Model.PossessedFollowerProxies.Count <= 0)
		{
			return null;
		}
		TowerDefenseFollowerProxy possessedFollowerProxy = TowerDefensePlayerController.GetPossessedFollowerProxy(proxyId);
		if (possessedFollowerProxy == null)
		{
			return null;
		}
		return possessedFollowerProxy.SkillIds;
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x0012089C File Offset: 0x0011EA9C
	public unsafe static void BindFollowerOperateSkills(AKSC_Entity_AssistMachine kscEntity, int? proxyId)
	{
		if (kscEntity == null)
		{
			KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "跟随物锚定战斗实体非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (proxyId == null)
		{
			KscLog.EModule flag = KscLog.EModule.Skill;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "跟随物输入非法的proxy id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("kscEntity", kscEntity);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int[] followerProxySkillIds = TowerDefensePlayerController.GetFollowerProxySkillIds(proxyId.Value);
		if (followerProxySkillIds == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Skill;
			ELogAuthor author2 = ELogAuthor.PZ;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "跟随物Proxy没有技能";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("kscEntity", kscEntity);
			KscLog.Warn(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		if (TowerDefensePlayerController.Model.BindFollowerSkills == null)
		{
			TowerDefensePlayerController.Model.BindFollowerSkills = new Dictionary<EKSC_OperateType, List<TDPlayerDefine.ISkill>>();
		}
		if (TowerDefensePlayerController.Model.SkillId2SkillData == null)
		{
			TowerDefensePlayerController.Model.SkillId2SkillData = new Dictionary<int, TDPlayerDefine.ISkill>();
		}
		foreach (int num in followerProxySkillIds)
		{
			TDPlayerDefine.ISkill skill;
			if (TowerDefensePlayerController.Model.AllSkillId2SkillData != null && TowerDefensePlayerController.Model.AllSkillId2SkillData.TryGetValue(num, out skill))
			{
				EKSC_OperateType operateType = skill.OperateType;
				List<TDPlayerDefine.ISkill> list;
				if (!TowerDefensePlayerController.Model.BindFollowerSkills.TryGetValue(operateType, out list) || list == null)
				{
					list = new List<TDPlayerDefine.ISkill>();
					TowerDefensePlayerController.Model.BindFollowerSkills[operateType] = list;
				}
				KscLog.EModule flag3 = KscLog.EModule.Skill;
				ELogAuthor author3 = ELogAuthor.PZ;
				UObject kscWorld3 = KscEnv.Instance.KscWorld;
				string log3 = "跟随物技能操作绑定";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillData", skill);
				KscLog.Info(flag3, author3, kscWorld3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				list.Add(skill);
				TowerDefensePlayerController.Model.SkillId2SkillData[num] = skill;
			}
			else
			{
				KscLog.EModule flag4 = KscLog.EModule.Skill;
				ELogAuthor author4 = ELogAuthor.TZQ;
				UObject kscWorld4 = KscEnv.Instance.KscWorld;
				string log4 = "辅助机技能操作绑定失败";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("skillId", num);
				KscLog.Info(flag4, author4, kscWorld4, log4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			}
		}
		foreach (KeyValuePair<EKSC_OperateType, List<TDPlayerDefine.ISkill>> keyValuePair in TowerDefensePlayerController.Model.BindFollowerSkills)
		{
			keyValuePair.Value.Sort((TDPlayerDefine.ISkill a, TDPlayerDefine.ISkill b) => b.Time.CompareTo(a.Time));
		}
	}

	// Token: 0x06003229 RID: 12841 RVA: 0x00120B18 File Offset: 0x0011ED18
	public static void UnBindFollowerOperateSkills()
	{
		TowerDefensePlayerController.SetFollowerSKillAutoCast(false, true);
		Dictionary<EKSC_OperateType, List<TDPlayerDefine.ISkill>> bindFollowerSkills = TowerDefensePlayerController.Model.BindFollowerSkills;
		if (bindFollowerSkills != null)
		{
			bindFollowerSkills.Clear();
		}
		Dictionary<int, TDPlayerDefine.ISkill> skillId2SkillData = TowerDefensePlayerController.Model.SkillId2SkillData;
		if (skillId2SkillData == null)
		{
			return;
		}
		skillId2SkillData.Clear();
	}

	// Token: 0x0600322A RID: 12842 RVA: 0x00120B4C File Offset: 0x0011ED4C
	public static void ClearFollowerKSCData()
	{
		TowerDefensePlayerController.RemoveChargeEffect();
		TowerDefensePlayerController.RemoveFollowerCue();
		TowerDefensePlayerController.ClearFollowerCdCue();
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		if (possessedFollowerKscEntity != null)
		{
			FOnSkillCD onSkillCD = possessedFollowerKscEntity.OnSkillCD;
			if (onSkillCD != null)
			{
				onSkillCD.Unbind();
			}
			FOnSkillReady onSkillReady = possessedFollowerKscEntity.OnSkillReady;
			if (onSkillReady != null)
			{
				onSkillReady.Unbind();
			}
			UKSC_SkillComp skillComp = possessedFollowerKscEntity.GetSkillComp();
			UKSC_AttrSet uksc_AttrSet = (skillComp != null) ? skillComp.AttrSet_ : null;
			if (uksc_AttrSet != null)
			{
				if (TowerDefensePlayerController.DelegateSkillCoolDown != null)
				{
					uksc_AttrSet.RemoveAttrListen(EKSC_AttrType.SkillCoolDown, TowerDefensePlayerController.DelegateSkillCoolDown);
					TowerDefensePlayerController.DelegateSkillCoolDown = null;
				}
				if (TowerDefensePlayerController.DelegateSkillCoolDownChange != null)
				{
					uksc_AttrSet.RemoveAttrListen(EKSC_AttrType.SkillCoolDownChange, TowerDefensePlayerController.DelegateSkillCoolDownChange);
					TowerDefensePlayerController.DelegateSkillCoolDownChange = null;
				}
			}
		}
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.CharSkillCountChanged;
		Action<GroupSkillCdInfo> handle;
		if ((handle = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
		{
			handle = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
		}
		if (instance.Has<GroupSkillCdInfo>(name, handle))
		{
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.CharSkillCountChanged;
			Action<GroupSkillCdInfo> handle2;
			if ((handle2 = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
			{
				handle2 = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
			}
			instance2.Remove<GroupSkillCdInfo>(name2, handle2);
		}
		Action<EKSC_AttrType, int> callBack;
		if ((callBack = TowerDefensePlayerController.<>O.<6>__OnFollowerCDAttr) == null)
		{
			callBack = (TowerDefensePlayerController.<>O.<6>__OnFollowerCDAttr = new Action<EKSC_AttrType, int>(TowerDefensePlayerController.OnFollowerCDAttr));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		Action<EKSC_AttrType, int> callBack2;
		if ((callBack2 = TowerDefensePlayerController.<>O.<7>__OnFollowerCDChangeAttr) == null)
		{
			callBack2 = (TowerDefensePlayerController.<>O.<7>__OnFollowerCDChangeAttr = new Action<EKSC_AttrType, int>(TowerDefensePlayerController.OnFollowerCDChangeAttr));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack2);
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x00120C74 File Offset: 0x0011EE74
	public static void ListenFollowerCDAttribute()
	{
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		UKSC_AttrSet uksc_AttrSet;
		if (possessedFollowerKscEntity == null)
		{
			uksc_AttrSet = null;
		}
		else
		{
			UKSC_SkillComp skillComp = possessedFollowerKscEntity.GetSkillComp();
			uksc_AttrSet = ((skillComp != null) ? skillComp.AttrSet_ : null);
		}
		UKSC_AttrSet uksc_AttrSet2 = uksc_AttrSet;
		if (uksc_AttrSet2 == null)
		{
			KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防辅助机:监听CD属性异常", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Action<EKSC_AttrType, int> callback;
		if ((callback = TowerDefensePlayerController.<>O.<6>__OnFollowerCDAttr) == null)
		{
			callback = (TowerDefensePlayerController.<>O.<6>__OnFollowerCDAttr = new Action<EKSC_AttrType, int>(TowerDefensePlayerController.OnFollowerCDAttr));
		}
		TowerDefensePlayerController.DelegateSkillCoolDown = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(callback);
		uksc_AttrSet2.AssignAttrListen(EKSC_AttrType.SkillCoolDown, TowerDefensePlayerController.DelegateSkillCoolDown);
		Action<EKSC_AttrType, int> callback2;
		if ((callback2 = TowerDefensePlayerController.<>O.<7>__OnFollowerCDChangeAttr) == null)
		{
			callback2 = (TowerDefensePlayerController.<>O.<7>__OnFollowerCDChangeAttr = new Action<EKSC_AttrType, int>(TowerDefensePlayerController.OnFollowerCDChangeAttr));
		}
		TowerDefensePlayerController.DelegateSkillCoolDownChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(callback2);
		uksc_AttrSet2.AssignAttrListen(EKSC_AttrType.SkillCoolDownChange, TowerDefensePlayerController.DelegateSkillCoolDownChange);
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x00120D2C File Offset: 0x0011EF2C
	private static void OnFollowerCDAttr(EKSC_AttrType attrType, int value)
	{
		TowerDefensePlayerController.UpdateFollowMontageSkillCD();
	}

	// Token: 0x0600322D RID: 12845 RVA: 0x00120D33 File Offset: 0x0011EF33
	private static void OnFollowerCDChangeAttr(EKSC_AttrType attrType, int value)
	{
		TowerDefensePlayerController.UpdateFollowMontageSkillCD();
	}

	// Token: 0x0600322E RID: 12846 RVA: 0x00120D3C File Offset: 0x0011EF3C
	private static void UpdateFollowMontageSkillCD()
	{
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		UKSC_SkillComp uksc_SkillComp = (possessedFollowerKscEntity != null) ? possessedFollowerKscEntity.GetSkillComp() : null;
		if (uksc_SkillComp == null)
		{
			return;
		}
		float skillCollDown = uksc_SkillComp.GetSkillCollDown();
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		CharacterSkillCdComponent characterSkillCdComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterSkillCdComponent>() : null;
		if (characterSkillCdComponent == null)
		{
			return;
		}
		Dictionary<int, TDPlayerDefine.ISkill> skillId2SkillData = TowerDefensePlayerController.Model.SkillId2SkillData;
		if (skillId2SkillData == null)
		{
			return;
		}
		foreach (KeyValuePair<int, TDPlayerDefine.ISkill> keyValuePair in skillId2SkillData)
		{
			TDPlayerDefine.ISkill value = keyValuePair.Value;
			if (value.SkillType == TDPlayerDefine.ESkillType.MontageSkill)
			{
				characterSkillCdComponent.ModifyCdInfo(value.SkillId, (float)((int)skillCollDown));
			}
		}
	}

	// Token: 0x0600322F RID: 12847 RVA: 0x00120DF8 File Offset: 0x0011EFF8
	public static void OnFollowerEnterSkillCd(int skillIndex, float cd)
	{
		if (TowerDefensePlayerController.Model.CurrentFollowerProxyId == null)
		{
			return;
		}
		TowerDefensePlayerController.RefreshFolloerCdCue(null);
		EventSystem.Instance.Emit<int, float>(EEventName.TrapFollowerSkillCd, TowerDefensePlayerController.Model.CurrentFollowerProxyId.Value, cd);
	}

	// Token: 0x06003230 RID: 12848 RVA: 0x00120E34 File Offset: 0x0011F034
	public static TDPlayerDefine.ISkill GetFollowListenSkillData(int proxyId)
	{
		if (KscUtil.GetFollowerCdSkillByProxy(proxyId).GetValueOrDefault() != 1)
		{
			return null;
		}
		int[] followerProxySkillIds = TowerDefensePlayerController.GetFollowerProxySkillIds(proxyId);
		if (followerProxySkillIds == null || followerProxySkillIds.Length != 1)
		{
			return null;
		}
		Dictionary<int, TDPlayerDefine.ISkill> allSkillId2SkillData = TowerDefensePlayerController.Model.AllSkillId2SkillData;
		TDPlayerDefine.ISkill result;
		if (allSkillId2SkillData == null || !allSkillId2SkillData.TryGetValue(followerProxySkillIds[0], out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003231 RID: 12849 RVA: 0x00120E88 File Offset: 0x0011F088
	public static TDPlayerDefine.ISkill GetSkillDataByRowId(int CDSkillRowId)
	{
		Dictionary<int, TDPlayerDefine.ISkill> skillId2SkillData = TowerDefensePlayerController.Model.SkillId2SkillData;
		TDPlayerDefine.ISkill result;
		if (skillId2SkillData == null || !skillId2SkillData.TryGetValue(CDSkillRowId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003232 RID: 12850 RVA: 0x00120EB4 File Offset: 0x0011F0B4
	public static void SetListenSkillCD(AKSC_Entity_AssistMachine kscEntity, int? proxyId)
	{
		if (proxyId == null || kscEntity == null)
		{
			KscLog.EModule flag = KscLog.EModule.Skill;
			ELogAuthor author = ELogAuthor.TZQ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防辅助机输入非法的proxy id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("proxyId", proxyId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FOnSkillCD onSkillCD = kscEntity.OnSkillCD;
		if (onSkillCD != null)
		{
			onSkillCD.Unbind();
		}
		FOnSkillReady onSkillReady = kscEntity.OnSkillReady;
		if (onSkillReady != null)
		{
			onSkillReady.Unbind();
		}
		TDPlayerDefine.ISkill followListenSkillData = TowerDefensePlayerController.GetFollowListenSkillData(proxyId.Value);
		if (followListenSkillData == null)
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.CharSkillCountChanged;
			Action<GroupSkillCdInfo> handle;
			if ((handle = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
			{
				handle = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
			}
			if (instance.Has<GroupSkillCdInfo>(name, handle))
			{
				EventSystem instance2 = EventSystem.Instance;
				EEventName name2 = EEventName.CharSkillCountChanged;
				Action<GroupSkillCdInfo> handle2;
				if ((handle2 = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
				{
					handle2 = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
				}
				instance2.Remove<GroupSkillCdInfo>(name2, handle2);
			}
			return;
		}
		if (followListenSkillData.SkillType != TDPlayerDefine.ESkillType.KscSkill)
		{
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.CharSkillCountChanged;
			Action<GroupSkillCdInfo> handle3;
			if ((handle3 = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
			{
				handle3 = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
			}
			if (!instance3.Has<GroupSkillCdInfo>(name3, handle3))
			{
				EventSystem instance4 = EventSystem.Instance;
				EEventName name4 = EEventName.CharSkillCountChanged;
				Action<GroupSkillCdInfo> handle4;
				if ((handle4 = TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue) == null)
				{
					handle4 = (TowerDefensePlayerController.<>O.<5>__RefreshFolloerCdCue = new Action<GroupSkillCdInfo>(TowerDefensePlayerController.RefreshFolloerCdCue));
				}
				instance4.Add<GroupSkillCdInfo>(name4, handle4);
			}
			return;
		}
		KscLog.EModule flag2 = KscLog.EModule.Skill;
		ELogAuthor author2 = ELogAuthor.TZQ;
		UObject kscWorld2 = KscEnv.Instance.KscWorld;
		string log2 = "塔防辅助机监听KSC技能CD";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("KSCSkillId", followListenSkillData.SkillId);
		KscLog.Info(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		kscEntity.ListenCDSkillIndex = followListenSkillData.SkillId;
		FOnSkillCD onSkillCD2 = kscEntity.OnSkillCD;
		if (onSkillCD2 != null)
		{
			Action<int, float> callback;
			if ((callback = TowerDefensePlayerController.<>O.<8>__OnFollowerEnterSkillCd) == null)
			{
				callback = (TowerDefensePlayerController.<>O.<8>__OnFollowerEnterSkillCd = new Action<int, float>(TowerDefensePlayerController.OnFollowerEnterSkillCd));
			}
			onSkillCD2.Bind(callback);
		}
		kscEntity.ListenSkillReadyIndex = followListenSkillData.SkillId;
		FOnSkillReady onSkillReady2 = kscEntity.OnSkillReady;
		if (onSkillReady2 == null)
		{
			return;
		}
		Action callback2;
		if ((callback2 = TowerDefensePlayerController.<>O.<9>__OnSkillReady) == null)
		{
			callback2 = (TowerDefensePlayerController.<>O.<9>__OnSkillReady = new Action(TowerDefensePlayerController.OnSkillReady));
		}
		onSkillReady2.Bind(callback2);
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x00121083 File Offset: 0x0011F283
	public static float GetFollowerSkillRemainCD(int proxyId)
	{
		return TowerDefensePlayerController.GetFollowerSkillCDInner(proxyId, true);
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x0012108C File Offset: 0x0011F28C
	public static float GetFollowerSkillCD(int proxyId)
	{
		return TowerDefensePlayerController.GetFollowerSkillCDInner(proxyId, false);
	}

	// Token: 0x06003235 RID: 12853 RVA: 0x00121098 File Offset: 0x0011F298
	private static float GetFollowerSkillCDInner(int proxyId, bool bRemainCd)
	{
		TDPlayerDefine.ISkill followListenSkillData = TowerDefensePlayerController.GetFollowListenSkillData(proxyId);
		if (followListenSkillData == null)
		{
			KscLog.EModule flag = KscLog.EModule.Skill;
			ELogAuthor author = ELogAuthor.TZQ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "塔防辅助机没有CD技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("proxyId", proxyId);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0f;
		}
		AKSC_Entity_AssistMachine possessedFollowerKscEntity = TowerDefensePlayerController.Model.PossessedFollowerKscEntity;
		if (possessedFollowerKscEntity == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Skill;
			ELogAuthor author2 = ELogAuthor.TZQ;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "塔防监听辅助机实体不存在";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("proxyId", proxyId);
			KscLog.Warn(flag2, author2, kscWorld2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return 0f;
		}
		if (followListenSkillData.SkillType != TDPlayerDefine.ESkillType.MontageSkill)
		{
			UKSC_SkillComp skillComp = possessedFollowerKscEntity.GetSkillComp();
			TArray<UKSC_Skill> tarray = (skillComp != null) ? skillComp.Skills_ : null;
			int? num = (tarray != null) ? new int?(tarray.Num()) : null;
			int skillId = followListenSkillData.SkillId;
			if (num != null)
			{
				int num2 = skillId;
				int? num3 = num;
				if (!(num2 >= num3.GetValueOrDefault() & num3 != null))
				{
					UKSC_Skill uksc_Skill = tarray.Get(skillId);
					if (uksc_Skill == null || !uksc_Skill.IsValid())
					{
						KscLog.EModule flag3 = KscLog.EModule.Skill;
						ELogAuthor author3 = ELogAuthor.TZQ;
						UObject kscWorld3 = KscEnv.Instance.KscWorld;
						string log3 = "塔防辅助机技能不合法";
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("proxyId", proxyId);
						KscLog.Warn(flag3, author3, kscWorld3, log3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						return 0f;
					}
					if (bRemainCd)
					{
						return uksc_Skill.GetSkillCoolDownRemain();
					}
					return uksc_Skill.GetSkillCoolDownMax();
				}
			}
			KscLog.EModule flag4 = KscLog.EModule.Skill;
			ELogAuthor author4 = ELogAuthor.TZQ;
			UObject kscWorld4 = KscEnv.Instance.KscWorld;
			string log4 = "塔防辅助机CDSkill不合法";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("proxyId", proxyId);
			KscLog.Warn(flag4, author4, kscWorld4, log4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return 0f;
		}
		Entity possessedFollowerEntity = TowerDefensePlayerController.Model.PossessedFollowerEntity;
		CharacterSkillCdComponent characterSkillCdComponent = (possessedFollowerEntity != null) ? possessedFollowerEntity.GetComponent<CharacterSkillCdComponent>() : null;
		GroupSkillCdInfo groupSkillCdInfo = (characterSkillCdComponent != null) ? characterSkillCdComponent.GetGroupSkillCdInfo(followListenSkillData.SkillId) : null;
		if (groupSkillCdInfo == null)
		{
			return 0f;
		}
		if (!bRemainCd)
		{
			return groupSkillCdInfo.CurMaxCd;
		}
		return groupSkillCdInfo.CurRemainingCd;
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00121268 File Offset: 0x0011F468
	private unsafe static void BindFollowerAttrs(AKSC_Entity_AssistMachine kscEntity, int? proxyId)
	{
		if (kscEntity == null)
		{
			KscLog.Warn(KscLog.EModule.Attr, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "跟随物锚定战斗实体非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (proxyId == null)
		{
			KscLog.EModule flag = KscLog.EModule.Attr;
			ELogAuthor author = ELogAuthor.PZ;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "跟随物输入非法的proxy id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("kscEntity", kscEntity);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		TowerDefenseFollowerProxy towerDefenseFollowerProxy;
		if (TowerDefensePlayerController.Model.PossessedFollowerProxies == null || !TowerDefensePlayerController.Model.PossessedFollowerProxies.TryGetValue(proxyId.Value, out towerDefenseFollowerProxy) || towerDefenseFollowerProxy == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Attr;
			ELogAuthor author2 = ELogAuthor.PZ;
			UObject kscWorld2 = KscEnv.Instance.KscWorld;
			string log2 = "跟随物输入非法的proxy";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("kscEntity", kscEntity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("proxy id", proxyId);
			KscLog.Warn(flag2, author2, kscWorld2, log2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		int? propertyId = towerDefenseFollowerProxy.PropertyId;
		if (propertyId == null)
		{
			KscLog.EModule flag3 = KscLog.EModule.Attr;
			ELogAuthor author3 = ELogAuthor.PZ;
			UObject kscWorld3 = KscEnv.Instance.KscWorld;
			string log3 = "跟随物proxy的属性数据异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("kscEntity", kscEntity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("proxy id", proxyId);
			KscLog.Warn(flag3, author3, kscWorld3, log3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
		if (curSubController == null)
		{
			return;
		}
		curSubController.SetAttrs(kscEntity, propertyId.Value, null);
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x001213E0 File Offset: 0x0011F5E0
	private static void DoCommit(EKSC_OperateType operateType, float time)
	{
		if (TowerDefensePlayerController.IsPlayerFollowerEnabled())
		{
			if (operateType != EKSC_OperateType.OnPress && !TowerDefensePlayerController.Model.IsInCharge)
			{
				return;
			}
			if (operateType == EKSC_OperateType.OnPress)
			{
				TowerDefensePlayerController.Model.IsInCharge = true;
			}
			else if (operateType == EKSC_OperateType.OnRelease)
			{
				TowerDefensePlayerController.Model.IsInCharge = false;
			}
			TowerDefensePlayerController.TryPlayCharageEffect(operateType, time);
			if (operateType == EKSC_OperateType.OnPress)
			{
				TowerDefensePlayerController.SetFollowerSKillAutoCast(!TowerDefensePlayerController.Model.IsInAutoCast, false);
			}
			TDPlayerDefine.ISkill followerSkillByOperateType = TowerDefensePlayerController.GetFollowerSkillByOperateType(operateType, time);
			if (followerSkillByOperateType != null)
			{
				TowerDefensePlayerController.BeginSkillFollower(followerSkillByOperateType);
				return;
			}
		}
		else
		{
			if (operateType == EKSC_OperateType.OnPress && !Info.Instance.IsInTouch())
			{
				KscLog.Info(KscLog.EModule.Input, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防输入层请求陷阱", default(ReadOnlySpan<ValueTuple<string, object>>));
				TowerDefenseEventController.Instance.OccupyTrap();
				return;
			}
			if (operateType == EKSC_OperateType.OnRelease && Info.Instance.IsInTouch())
			{
				KscLog.Info(KscLog.EModule.Input, ELogAuthor.PZ, KscEnv.Instance.KscWorld, "塔防输入层请求陷阱", default(ReadOnlySpan<ValueTuple<string, object>>));
				TowerDefenseEventController.Instance.OccupyTrap();
			}
		}
	}

	// Token: 0x06003238 RID: 12856 RVA: 0x001214C8 File Offset: 0x0011F6C8
	private static void DoUseItem()
	{
		if (!RouletteModel.Instance.IsExploreRouletteOpen(false))
		{
			return;
		}
		if (!TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop())
		{
			return;
		}
		int? exploreSkillId = TrapDefenseModel.Instance.BattleData.GetExploreSkillId();
		if (exploreSkillId != null)
		{
			TrapDefenseItem? trapDefenseItemByExploreToolId = TrapDefenseConfig.Instance.GetTrapDefenseItemByExploreToolId(exploreSkillId.Value);
			if (trapDefenseItemByExploreToolId != null)
			{
				TrapDefenseModel instance = TrapDefenseModel.Instance;
				TrapDefenseBattleItemData trapDefenseBattleItemData = (instance != null) ? instance.BattleInventoryData.GetItemData(trapDefenseItemByExploreToolId.Value.Id) : null;
				if (trapDefenseBattleItemData == null || trapDefenseBattleItemData.InventoryCount <= 0)
				{
					return;
				}
				TrapDefenseController.Instance.RequestTrapDefenseUseItem(trapDefenseItemByExploreToolId.Value.Id);
			}
		}
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x00121570 File Offset: 0x0011F770
	public static void HandleUseItem()
	{
		TowerDefensePlayerController.DoUseItem();
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x00121577 File Offset: 0x0011F777
	public static void HandleTowerDefenseCommitFast()
	{
		TowerDefensePlayerController.DoCommit(EKSC_OperateType.OnPress, 0f);
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x00121584 File Offset: 0x0011F784
	public static void HandleTowerDefenseCommit(EKSC_OperateType operateType, float time)
	{
		TowerDefensePlayerController.DoCommit(operateType, time);
	}

	// Token: 0x0600323C RID: 12860 RVA: 0x0012158D File Offset: 0x0011F78D
	public static void HandleTowerFollowerSelect(int proxyId)
	{
		TowerDefenseEventController.Instance.CancelCurrentPreviewTrap();
		TowerDefensePlayerController.SetFollowerProxy(proxyId);
		TowerDefensePlayerController.EnablePlayerFollower(true);
	}

	// Token: 0x0600323D RID: 12861 RVA: 0x001215A8 File Offset: 0x0011F7A8
	public static void PlayerDoSkill(int skillIndex)
	{
		TowerDefensePlayerModel model = TowerDefensePlayerController.Model;
		WorldEntity worldEntity;
		if (model == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle pendingRoleHandle = model.PendingRoleHandle;
			worldEntity = ((pendingRoleHandle != null) ? pendingRoleHandle.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 != null)
		{
			TowerDefensePlayerController.DoSkill(worldEntity2, skillIndex);
		}
	}

	// Token: 0x0600323E RID: 12862 RVA: 0x001215E0 File Offset: 0x0011F7E0
	[NullableContext(1)]
	public static void DoSkill(Entity entity, int skillIndex)
	{
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		long? num = (component != null) ? new long?(component.GetCreatureDataId()) : null;
		if (num == null)
		{
			KscLog.Warn(KscLog.EModule.Input, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防触发技能失败:无creatureId", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		KscEntityHandle kscEntityHandle = KuroSimpleCombatController.Instance.CurSubModel.GetKscEntityHandle(num.Value);
		if (kscEntityHandle == null || !kscEntityHandle.Valid)
		{
			KscLog.Warn(KscLog.EModule.Input, ELogAuthor.TZQ, KscEnv.Instance.KscWorld, "塔防触发技能失败:无绑定的kscEntity", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		AKSC_Entity kscEntity = kscEntityHandle.KscEntity;
		if (kscEntity == null)
		{
			return;
		}
		if (kscEntity is AKSC_Entity_AssistMachine)
		{
			CharacterActorComponent component2 = entity.GetComponent<CharacterActorComponent>();
			TsBaseCharacter tsBaseCharacter = (component2 != null) ? component2.Actor : null;
			if (tsBaseCharacter != null)
			{
				FTransformDouble ftransformDouble = tsBaseCharacter.D_GetTransform();
				((AKSC_Entity_AssistMachine)kscEntity).D_Fire(ftransformDouble, skillIndex);
				return;
			}
		}
		else
		{
			kscEntity.TryActiveSKill(skillIndex);
		}
	}

	// Token: 0x04002B80 RID: 11136
	private static TowerDefensePlayerModel TDPlayerModel;

	// Token: 0x04002B81 RID: 11137
	public static FOnKSCAttrChange DelegateSkillCoolDown;

	// Token: 0x04002B82 RID: 11138
	public static FOnKSCAttrChange DelegateSkillCoolDownChange;

	// Token: 0x04002B83 RID: 11139
	private static FName EKSC_REMOVE_REASON_FOLLOWER;

	// Token: 0x020066B9 RID: 26297
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021F67 RID: 139111
		[Nullable(0)]
		public static Action<bool> <0>__OnPlayerFollowerEnableChange;

		// Token: 0x04021F68 RID: 139112
		[Nullable(0)]
		public static Action <1>__OnPlayerFollowerUnPossessed;

		// Token: 0x04021F69 RID: 139113
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<EntityHandle> <2>__OnPlayerFollowerPossessed;

		// Token: 0x04021F6A RID: 139114
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<GroupSkillCdInfo> <3>__OnCharSkillCountChanged;

		// Token: 0x04021F6B RID: 139115
		[Nullable(0)]
		public static Action<int, int> <4>__OnFollowerMontageSkillEnd;

		// Token: 0x04021F6C RID: 139116
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<GroupSkillCdInfo> <5>__RefreshFolloerCdCue;

		// Token: 0x04021F6D RID: 139117
		[Nullable(0)]
		public static Action<EKSC_AttrType, int> <6>__OnFollowerCDAttr;

		// Token: 0x04021F6E RID: 139118
		[Nullable(0)]
		public static Action<EKSC_AttrType, int> <7>__OnFollowerCDChangeAttr;

		// Token: 0x04021F6F RID: 139119
		[Nullable(0)]
		public static Action<int, float> <8>__OnFollowerEnterSkillCd;

		// Token: 0x04021F70 RID: 139120
		[Nullable(0)]
		public static Action <9>__OnSkillReady;
	}
}
