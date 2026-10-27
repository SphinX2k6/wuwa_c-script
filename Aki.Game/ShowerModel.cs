using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02002A00 RID: 10752
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShowerModel : ModelBase
{
	// Token: 0x17001DC7 RID: 7623
	// (get) Token: 0x060164F0 RID: 91376 RVA: 0x005A540B File Offset: 0x005A360B
	public int CurSelectPosIndex
	{
		get
		{
			return this.CurSelectPosIndexInternal;
		}
	}

	// Token: 0x17001DC8 RID: 7624
	// (get) Token: 0x060164F1 RID: 91377 RVA: 0x005A5413 File Offset: 0x005A3613
	public int PosCount
	{
		get
		{
			return this.RolePosIdList.Count;
		}
	}

	// Token: 0x060164F2 RID: 91378 RVA: 0x005A5420 File Offset: 0x005A3620
	public string GetInviteNumString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SelectInviteMap.Count);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PosCount);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060164F3 RID: 91379 RVA: 0x005A5468 File Offset: 0x005A3668
	[NullableContext(2)]
	public RoleInstance GetRoleInstanceByPos(int posIndex)
	{
		RoleInstance result;
		if (this.SelectInviteMap.TryGetValue(posIndex, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060164F4 RID: 91380 RVA: 0x005A5488 File Offset: 0x005A3688
	[NullableContext(2)]
	public void SetShowerSeatConfigIds(List<int> configIds)
	{
		if (configIds != null && !this.IsInShower)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			object obj;
			if (baseCharacter == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				obj = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			object obj2 = obj;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (obj2 != null) ? obj2.GetComponent<CharacterDriveVehicleComponent>() : null;
			int num = (characterDriveVehicleComponent != null) ? characterDriveVehicleComponent.Seat : -1;
			if (num == -1)
			{
				Log.Instance.Error(ELogModule.Vehicle, ELogAuthor.LRC, "共浴 玩家座位id undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.VehicleSeatConfigIds = configIds;
			this.RolePosIdList.Clear();
			for (int i = 0; i < this.VehicleSeatConfigIds.Count; i++)
			{
				if (i != num)
				{
					this.RolePosIdList.Add(i);
				}
			}
		}
	}

	// Token: 0x060164F5 RID: 91381 RVA: 0x005A5538 File Offset: 0x005A3738
	[NullableContext(2)]
	public WorldEntity GetShowerSeatEntityByPos(int posIndex)
	{
		if (posIndex >= this.PosCount)
		{
			return null;
		}
		int num = this.VehicleSeatConfigIds[this.RolePosIdList[posIndex]];
		if (num == 0)
		{
			return null;
		}
		List<EntityHandle> list = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesWithPbDataId(num, ref list);
		WorldEntity worldEntity;
		if (list.Count <= 0)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityHandle = list[0];
			worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null)
		{
			return null;
		}
		return worldEntity2;
	}

	// Token: 0x060164F6 RID: 91382 RVA: 0x005A55A6 File Offset: 0x005A37A6
	public void RightPos()
	{
		if (this.CurSelectPosIndexInternal >= this.PosCount - 1)
		{
			this.CurSelectPosIndexInternal = 0;
			return;
		}
		this.CurSelectPosIndexInternal++;
	}

	// Token: 0x060164F7 RID: 91383 RVA: 0x005A55CE File Offset: 0x005A37CE
	public void LeftPos()
	{
		if (this.CurSelectPosIndexInternal <= 0)
		{
			this.CurSelectPosIndexInternal = this.PosCount - 1;
			return;
		}
		this.CurSelectPosIndexInternal--;
	}

	// Token: 0x060164F8 RID: 91384 RVA: 0x005A55F6 File Offset: 0x005A37F6
	public void ChangePos(int posIndex)
	{
		if (posIndex >= this.PosCount || posIndex < 0)
		{
			return;
		}
		this.CurSelectPosIndexInternal = posIndex;
	}

	// Token: 0x060164F9 RID: 91385 RVA: 0x005A5610 File Offset: 0x005A3810
	public void InviteRole(RoleInstance roleInstance)
	{
		int curSelectPosIndexInternal = this.CurSelectPosIndexInternal;
		int num = -1;
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.SelectInviteMap)
		{
			if (keyValuePair.Value.GetRoleId() == roleInstance.GetRoleId())
			{
				num = keyValuePair.Key;
				break;
			}
		}
		if (curSelectPosIndexInternal == num)
		{
			this.SelectInviteMap.Remove(curSelectPosIndexInternal);
			return;
		}
		RoleInstance value;
		if (this.SelectInviteMap.TryGetValue(curSelectPosIndexInternal, out value))
		{
			this.SelectInviteMap[curSelectPosIndexInternal] = roleInstance;
			if (num != -1)
			{
				this.SelectInviteMap[num] = value;
				return;
			}
		}
		else
		{
			if (num != -1)
			{
				this.SelectInviteMap.Remove(num);
			}
			this.SelectInviteMap[curSelectPosIndexInternal] = roleInstance;
		}
	}

	// Token: 0x060164FA RID: 91386 RVA: 0x005A56E4 File Offset: 0x005A38E4
	public int GetRolePos(RoleInstance roleInstance)
	{
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.SelectInviteMap)
		{
			if (keyValuePair.Value.GetRoleId() == roleInstance.GetRoleId())
			{
				return keyValuePair.Key;
			}
		}
		return -1;
	}

	// Token: 0x060164FB RID: 91387 RVA: 0x005A5754 File Offset: 0x005A3954
	public bool CheckRoleInCurPos(RoleInstance roleInstance)
	{
		RoleInstance roleInstance2;
		return this.SelectInviteMap.TryGetValue(this.CurSelectPosIndexInternal, out roleInstance2) && roleInstance2.GetRoleId() == roleInstance.GetRoleId();
	}

	// Token: 0x060164FC RID: 91388 RVA: 0x005A5788 File Offset: 0x005A3988
	public void ExitAndClear()
	{
		this.VehicleSeatConfigIds.Clear();
		this.RolePosIdList.Clear();
		this.SelectInviteMap.Clear();
		this.CurInviteMap.Clear();
		this.IsInShower = false;
		this.CurSelectPosIndexInternal = 0;
		if (UiManager.Instance.IsViewOpen(EUiViewName.ShowerMainView))
		{
			UiManager.Instance.CloseView(EUiViewName.ShowerMainView, null);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.ShowerInviteView))
		{
			UiManager.Instance.CloseView(EUiViewName.ShowerInviteView, null);
		}
	}

	// Token: 0x060164FD RID: 91389 RVA: 0x005A5811 File Offset: 0x005A3A11
	public void ClearCurInviteRoles()
	{
		this.SelectInviteMap.Clear();
		this.CurSelectPosIndexInternal = 0;
	}

	// Token: 0x060164FE RID: 91390 RVA: 0x005A5828 File Offset: 0x005A3A28
	public void ResetCurInviteRoles()
	{
		this.SelectInviteMap.Clear();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.CurInviteMap)
		{
			this.SelectInviteMap[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x060164FF RID: 91391 RVA: 0x005A5898 File Offset: 0x005A3A98
	public void SendAndSave()
	{
		this.IsInShower = true;
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.CurInviteMap)
		{
			if (!this.SelectInviteMap.ContainsKey(keyValuePair.Key))
			{
				EventSystem.Instance.Emit<int, int>(EEventName.OnRemoveRideSharingPassenger, keyValuePair.Value.GetRoleId(), this.RolePosIdList[keyValuePair.Key]);
			}
		}
		foreach (KeyValuePair<int, RoleInstance> keyValuePair2 in this.SelectInviteMap)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnChangeRideSharingPassenger, keyValuePair2.Value.GetRoleId(), this.RolePosIdList[keyValuePair2.Key]);
		}
		this.CurInviteMap.Clear();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair3 in this.SelectInviteMap)
		{
			this.CurInviteMap[keyValuePair3.Key] = keyValuePair3.Value;
		}
	}

	// Token: 0x17001DC9 RID: 7625
	// (get) Token: 0x06016500 RID: 91392 RVA: 0x005A59F8 File Offset: 0x005A3BF8
	public static ShowerModel Instance
	{
		get
		{
			return ShowerModel._Instance;
		}
	}

	// Token: 0x06016501 RID: 91393 RVA: 0x005A59FF File Offset: 0x005A3BFF
	public static ShowerModel GetOrCreateInstance()
	{
		if (ShowerModel._Instance == null)
		{
			ShowerModel.CreateInstance();
		}
		return ShowerModel._Instance;
	}

	// Token: 0x06016502 RID: 91394 RVA: 0x005A5A13 File Offset: 0x005A3C13
	public static bool CreateInstance()
	{
		if (ShowerModel._Instance != null)
		{
			return true;
		}
		ShowerModel._Instance = new ShowerModel();
		return true;
	}

	// Token: 0x06016503 RID: 91395 RVA: 0x005A5A29 File Offset: 0x005A3C29
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016504 RID: 91396 RVA: 0x005A5A2B File Offset: 0x005A3C2B
	public static void ResetStaticDefaultValue()
	{
		ShowerModel._Instance = null;
	}

	// Token: 0x06016505 RID: 91397 RVA: 0x005A5A33 File Offset: 0x005A3C33
	static ShowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShowerModel.CreateStaticDefaultValue), new Action(ShowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A5EE RID: 42478
	private readonly Dictionary<int, RoleInstance> SelectInviteMap = new Dictionary<int, RoleInstance>();

	// Token: 0x0400A5EF RID: 42479
	private readonly Dictionary<int, RoleInstance> CurInviteMap = new Dictionary<int, RoleInstance>();

	// Token: 0x0400A5F0 RID: 42480
	private int CurSelectPosIndexInternal;

	// Token: 0x0400A5F1 RID: 42481
	private List<int> VehicleSeatConfigIds = new List<int>();

	// Token: 0x0400A5F2 RID: 42482
	private readonly List<int> RolePosIdList = new List<int>();

	// Token: 0x0400A5F3 RID: 42483
	public bool IsInShower;

	// Token: 0x0400A5F4 RID: 42484
	[Nullable(2)]
	private static ShowerModel _Instance;
}
