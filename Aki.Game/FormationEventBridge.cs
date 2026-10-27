using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

// Token: 0x02001BB1 RID: 7089
[NullableContext(1)]
[Nullable(0)]
public class FormationEventBridge
{
	// Token: 0x0600D36F RID: 54127 RVA: 0x00309A96 File Offset: 0x00307C96
	private static void OnWorldDoneAndCloseLoading()
	{
		FormationController.Instance.PreloadFormationUi();
	}

	// Token: 0x0600D370 RID: 54128 RVA: 0x00309AA2 File Offset: 0x00307CA2
	private static void OnLoadingNetDataDone()
	{
		FormationNetHandler.GetFormationDataRequest();
	}

	// Token: 0x0600D371 RID: 54129 RVA: 0x00309AAC File Offset: 0x00307CAC
	private static void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		int? num = (getCurrentTeamItem != null) ? new int?(getCurrentTeamItem.GetConfigId) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				FormationData currentFormationData = FormationModel.Instance.CurrentFormationData;
				if (currentFormationData == null)
				{
					return;
				}
				currentFormationData.SetCurrentRole(num.Value);
				return;
			}
		}
	}

	// Token: 0x0600D372 RID: 54130 RVA: 0x00309B1A File Offset: 0x00307D1A
	private static void OnCloseView(EUiViewName viewName, int viewId)
	{
		FormationNetHandler.FlushCachedNotify(viewName);
	}

	// Token: 0x0600D373 RID: 54131 RVA: 0x00309B22 File Offset: 0x00307D22
	private static void OnPrewarFormationChanged()
	{
		BattleTeamModel.Instance.RefreshAllMultiRoleData();
	}

	// Token: 0x0600D374 RID: 54132 RVA: 0x00309B30 File Offset: 0x00307D30
	private unsafe static void OnPrewarReadyChanged(int playerId, bool ready)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[BattleTeam]玩家{PlayerId} 返回准备游戏,是否准备:{IsReady}";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("{PlayerId}", playerId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("{IsReady}", ready);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		BattleTeamModel.Instance.SetPlayerReady(playerId, ready);
	}

	// Token: 0x0600D375 RID: 54133 RVA: 0x00309BA6 File Offset: 0x00307DA6
	private static void OnDissolvePrewar()
	{
		FormationController.Instance.CloseBattleTeamView();
	}

	// Token: 0x0600D376 RID: 54134 RVA: 0x00309BB4 File Offset: 0x00307DB4
	private static void OnRoleLevelUp(int configId, int exp, int level)
	{
		FormationEventBridge.UpdateSelfRoleSlot(configId, delegate(BattleRoleData roleData)
		{
			roleData.Level = level;
		});
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.LevelUp);
	}

	// Token: 0x0600D377 RID: 54135 RVA: 0x00309BF4 File Offset: 0x00307DF4
	private static void OnRoleSkinChanged(int configId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(configId, true);
		if (roleDataById == null)
		{
			return;
		}
		int newSkinId = roleDataById.GetRoleSkinId();
		FormationEventBridge.UpdateSelfRoleSlot(configId, delegate(BattleRoleData roleData)
		{
			roleData.SkinId = newSkinId;
		});
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.SkinChange);
	}

	// Token: 0x0600D378 RID: 54136 RVA: 0x00309C48 File Offset: 0x00307E48
	public static void RegisterAll()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDoneAndCloseLoading;
		Action handle;
		if ((handle = FormationEventBridge.<>O.<0>__OnWorldDoneAndCloseLoading) == null)
		{
			handle = (FormationEventBridge.<>O.<0>__OnWorldDoneAndCloseLoading = new Action(FormationEventBridge.OnWorldDoneAndCloseLoading));
		}
		instance.Add(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.OnLoadingNetDataDone;
		Action handle2;
		if ((handle2 = FormationEventBridge.<>O.<1>__OnLoadingNetDataDone) == null)
		{
			handle2 = (FormationEventBridge.<>O.<1>__OnLoadingNetDataDone = new Action(FormationEventBridge.OnLoadingNetDataDone));
		}
		instance2.Add(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnChangeRole;
		Action<EntityHandle, EntityHandle> handle3;
		if ((handle3 = FormationEventBridge.<>O.<2>__OnChangeRole) == null)
		{
			handle3 = (FormationEventBridge.<>O.<2>__OnChangeRole = new Action<EntityHandle, EntityHandle>(FormationEventBridge.OnChangeRole));
		}
		instance3.Add<EntityHandle, EntityHandle>(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.CloseView;
		Action<EUiViewName, int> handle4;
		if ((handle4 = FormationEventBridge.<>O.<3>__OnCloseView) == null)
		{
			handle4 = (FormationEventBridge.<>O.<3>__OnCloseView = new Action<EUiViewName, int>(FormationEventBridge.OnCloseView));
		}
		instance4.Add<EUiViewName, int>(name4, handle4);
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.PrewarFormationChanged;
		Action handle5;
		if ((handle5 = FormationEventBridge.<>O.<4>__OnPrewarFormationChanged) == null)
		{
			handle5 = (FormationEventBridge.<>O.<4>__OnPrewarFormationChanged = new Action(FormationEventBridge.OnPrewarFormationChanged));
		}
		instance5.Add(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.PrewarReadyChanged;
		Action<int, bool> handle6;
		if ((handle6 = FormationEventBridge.<>O.<5>__OnPrewarReadyChanged) == null)
		{
			handle6 = (FormationEventBridge.<>O.<5>__OnPrewarReadyChanged = new Action<int, bool>(FormationEventBridge.OnPrewarReadyChanged));
		}
		instance6.Add(name6, handle6);
		EventSystem instance7 = EventSystem.Instance;
		EEventName name7 = EEventName.DissolvePrewar;
		Action handle7;
		if ((handle7 = FormationEventBridge.<>O.<6>__OnDissolvePrewar) == null)
		{
			handle7 = (FormationEventBridge.<>O.<6>__OnDissolvePrewar = new Action(FormationEventBridge.OnDissolvePrewar));
		}
		instance7.Add(name7, handle7);
		EventSystem instance8 = EventSystem.Instance;
		EEventName name8 = EEventName.RoleLevelUp;
		Action<int, int, int> handle8;
		if ((handle8 = FormationEventBridge.<>O.<7>__OnRoleLevelUp) == null)
		{
			handle8 = (FormationEventBridge.<>O.<7>__OnRoleLevelUp = new Action<int, int, int>(FormationEventBridge.OnRoleLevelUp));
		}
		instance8.Add(name8, handle8);
		EventSystem instance9 = EventSystem.Instance;
		EEventName name9 = EEventName.OnRoleSkinChange;
		Action<int> handle9;
		if ((handle9 = FormationEventBridge.<>O.<8>__OnRoleSkinChanged) == null)
		{
			handle9 = (FormationEventBridge.<>O.<8>__OnRoleSkinChanged = new Action<int>(FormationEventBridge.OnRoleSkinChanged));
		}
		instance9.Add(name9, handle9);
	}

	// Token: 0x0600D379 RID: 54137 RVA: 0x00309DD8 File Offset: 0x00307FD8
	public static void UnregisterAll()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDoneAndCloseLoading;
		Action handle;
		if ((handle = FormationEventBridge.<>O.<0>__OnWorldDoneAndCloseLoading) == null)
		{
			handle = (FormationEventBridge.<>O.<0>__OnWorldDoneAndCloseLoading = new Action(FormationEventBridge.OnWorldDoneAndCloseLoading));
		}
		instance.Remove(name, handle);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.OnLoadingNetDataDone;
		Action handle2;
		if ((handle2 = FormationEventBridge.<>O.<1>__OnLoadingNetDataDone) == null)
		{
			handle2 = (FormationEventBridge.<>O.<1>__OnLoadingNetDataDone = new Action(FormationEventBridge.OnLoadingNetDataDone));
		}
		instance2.Remove(name2, handle2);
		EventSystem instance3 = EventSystem.Instance;
		EEventName name3 = EEventName.OnChangeRole;
		Action<EntityHandle, EntityHandle> handle3;
		if ((handle3 = FormationEventBridge.<>O.<2>__OnChangeRole) == null)
		{
			handle3 = (FormationEventBridge.<>O.<2>__OnChangeRole = new Action<EntityHandle, EntityHandle>(FormationEventBridge.OnChangeRole));
		}
		instance3.Remove(name3, handle3);
		EventSystem instance4 = EventSystem.Instance;
		EEventName name4 = EEventName.CloseView;
		Action<EUiViewName, int> handle4;
		if ((handle4 = FormationEventBridge.<>O.<3>__OnCloseView) == null)
		{
			handle4 = (FormationEventBridge.<>O.<3>__OnCloseView = new Action<EUiViewName, int>(FormationEventBridge.OnCloseView));
		}
		instance4.Remove(name4, handle4);
		EventSystem instance5 = EventSystem.Instance;
		EEventName name5 = EEventName.PrewarFormationChanged;
		Action handle5;
		if ((handle5 = FormationEventBridge.<>O.<4>__OnPrewarFormationChanged) == null)
		{
			handle5 = (FormationEventBridge.<>O.<4>__OnPrewarFormationChanged = new Action(FormationEventBridge.OnPrewarFormationChanged));
		}
		instance5.Remove(name5, handle5);
		EventSystem instance6 = EventSystem.Instance;
		EEventName name6 = EEventName.PrewarReadyChanged;
		Action<int, bool> handle6;
		if ((handle6 = FormationEventBridge.<>O.<5>__OnPrewarReadyChanged) == null)
		{
			handle6 = (FormationEventBridge.<>O.<5>__OnPrewarReadyChanged = new Action<int, bool>(FormationEventBridge.OnPrewarReadyChanged));
		}
		instance6.Remove(name6, handle6);
		EventSystem instance7 = EventSystem.Instance;
		EEventName name7 = EEventName.DissolvePrewar;
		Action handle7;
		if ((handle7 = FormationEventBridge.<>O.<6>__OnDissolvePrewar) == null)
		{
			handle7 = (FormationEventBridge.<>O.<6>__OnDissolvePrewar = new Action(FormationEventBridge.OnDissolvePrewar));
		}
		instance7.Remove(name7, handle7);
		EventSystem instance8 = EventSystem.Instance;
		EEventName name8 = EEventName.RoleLevelUp;
		Action<int, int, int> handle8;
		if ((handle8 = FormationEventBridge.<>O.<7>__OnRoleLevelUp) == null)
		{
			handle8 = (FormationEventBridge.<>O.<7>__OnRoleLevelUp = new Action<int, int, int>(FormationEventBridge.OnRoleLevelUp));
		}
		instance8.Remove(name8, handle8);
		EventSystem instance9 = EventSystem.Instance;
		EEventName name9 = EEventName.OnRoleSkinChange;
		Action<int> handle9;
		if ((handle9 = FormationEventBridge.<>O.<8>__OnRoleSkinChanged) == null)
		{
			handle9 = (FormationEventBridge.<>O.<8>__OnRoleSkinChanged = new Action<int>(FormationEventBridge.OnRoleSkinChanged));
		}
		instance9.Remove(name9, handle9);
	}

	// Token: 0x0600D37A RID: 54138 RVA: 0x00309F68 File Offset: 0x00308168
	private static void UpdateSelfRoleSlot(int configId, Action<BattleRoleData> mutator)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		bool flag = false;
		foreach (BattleRoleSlotData battleRoleSlotData in instance.GetAllSlots())
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null && roleData.IsSelf && roleData.ConfigId == configId)
			{
				mutator(roleData);
				flag = true;
			}
		}
		if (flag && instance.Context.IsMultiInstanceDungeon)
		{
			InstanceDungeonEntranceController.Instance.MatchChangeRoleRequest(instance.OwnRoleConfigIdList.Item1);
		}
	}

	// Token: 0x02008175 RID: 33141
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A3E6 RID: 173030
		[Nullable(0)]
		public static Action <0>__OnWorldDoneAndCloseLoading;

		// Token: 0x0402A3E7 RID: 173031
		[Nullable(0)]
		public static Action <1>__OnLoadingNetDataDone;

		// Token: 0x0402A3E8 RID: 173032
		[Nullable(new byte[]
		{
			0,
			1,
			2
		})]
		public static Action<EntityHandle, EntityHandle> <2>__OnChangeRole;

		// Token: 0x0402A3E9 RID: 173033
		[Nullable(0)]
		public static Action<EUiViewName, int> <3>__OnCloseView;

		// Token: 0x0402A3EA RID: 173034
		[Nullable(0)]
		public static Action <4>__OnPrewarFormationChanged;

		// Token: 0x0402A3EB RID: 173035
		[Nullable(0)]
		public static Action<int, bool> <5>__OnPrewarReadyChanged;

		// Token: 0x0402A3EC RID: 173036
		[Nullable(0)]
		public static Action <6>__OnDissolvePrewar;

		// Token: 0x0402A3ED RID: 173037
		[Nullable(0)]
		public static Action<int, int, int> <7>__OnRoleLevelUp;

		// Token: 0x0402A3EE RID: 173038
		[Nullable(0)]
		public static Action<int> <8>__OnRoleSkinChanged;
	}
}
