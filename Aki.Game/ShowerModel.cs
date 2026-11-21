using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001F7B RID: 8059
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ShowerModel : ModelBase
{
	// Token: 0x17001E20 RID: 7712
	// (get) Token: 0x06013EF7 RID: 81655 RVA: 0x005D03E3 File Offset: 0x005CE5E3
	public int CurSelectPosIndex
	{
		get
		{
			return this.CurSelectPosIndexInternal;
		}
	}

	// Token: 0x17001E21 RID: 7713
	// (get) Token: 0x06013EF8 RID: 81656 RVA: 0x005D03EB File Offset: 0x005CE5EB
	public int PosCount
	{
		get
		{
			return this.RolePosIdList.Count;
		}
	}

	// Token: 0x06013EF9 RID: 81657 RVA: 0x005D03F8 File Offset: 0x005CE5F8
	public string GetInviteNumString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.SelectInviteMap.Count);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PosCount);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06013EFA RID: 81658 RVA: 0x005D0440 File Offset: 0x005CE640
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

	// Token: 0x06013EFB RID: 81659 RVA: 0x005D0460 File Offset: 0x005CE660
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

	// Token: 0x06013EFC RID: 81660 RVA: 0x005D0510 File Offset: 0x005CE710
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

	// Token: 0x06013EFD RID: 81661 RVA: 0x005D057E File Offset: 0x005CE77E
	public void RightPos()
	{
		if (this.CurSelectPosIndexInternal >= this.PosCount - 1)
		{
			this.CurSelectPosIndexInternal = 0;
			return;
		}
		this.CurSelectPosIndexInternal++;
	}

	// Token: 0x06013EFE RID: 81662 RVA: 0x005D05A6 File Offset: 0x005CE7A6
	public void LeftPos()
	{
		if (this.CurSelectPosIndexInternal <= 0)
		{
			this.CurSelectPosIndexInternal = this.PosCount - 1;
			return;
		}
		this.CurSelectPosIndexInternal--;
	}

	// Token: 0x06013EFF RID: 81663 RVA: 0x005D05CE File Offset: 0x005CE7CE
	public void ChangePos(int posIndex)
	{
		if (posIndex >= this.PosCount || posIndex < 0)
		{
			return;
		}
		this.CurSelectPosIndexInternal = posIndex;
	}

	// Token: 0x06013F00 RID: 81664 RVA: 0x005D05E8 File Offset: 0x005CE7E8
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

	// Token: 0x06013F01 RID: 81665 RVA: 0x005D06BC File Offset: 0x005CE8BC
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

	// Token: 0x06013F02 RID: 81666 RVA: 0x005D072C File Offset: 0x005CE92C
	public bool CheckRoleInCurPos(RoleInstance roleInstance)
	{
		RoleInstance roleInstance2;
		return this.SelectInviteMap.TryGetValue(this.CurSelectPosIndexInternal, out roleInstance2) && roleInstance2.GetRoleId() == roleInstance.GetRoleId();
	}

	// Token: 0x06013F03 RID: 81667 RVA: 0x005D0760 File Offset: 0x005CE960
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

	// Token: 0x06013F04 RID: 81668 RVA: 0x005D07E9 File Offset: 0x005CE9E9
	public void ClearCurInviteRoles()
	{
		this.SelectInviteMap.Clear();
		this.CurSelectPosIndexInternal = 0;
	}

	// Token: 0x06013F05 RID: 81669 RVA: 0x005D0800 File Offset: 0x005CEA00
	public void ResetCurInviteRoles()
	{
		this.SelectInviteMap.Clear();
		foreach (KeyValuePair<int, RoleInstance> keyValuePair in this.CurInviteMap)
		{
			this.SelectInviteMap[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x06013F06 RID: 81670 RVA: 0x005D0870 File Offset: 0x005CEA70
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

	// Token: 0x17001E22 RID: 7714
	// (get) Token: 0x06013F07 RID: 81671 RVA: 0x005D09D0 File Offset: 0x005CEBD0
	public static ShowerModel Instance
	{
		get
		{
			return ShowerModel._Instance;
		}
	}

	// Token: 0x06013F08 RID: 81672 RVA: 0x005D09D7 File Offset: 0x005CEBD7
	public static ShowerModel GetOrCreateInstance()
	{
		if (ShowerModel._Instance == null)
		{
			ShowerModel.CreateInstance();
		}
		return ShowerModel._Instance;
	}

	// Token: 0x06013F09 RID: 81673 RVA: 0x005D09EB File Offset: 0x005CEBEB
	public static bool CreateInstance()
	{
		if (ShowerModel._Instance != null)
		{
			return true;
		}
		ShowerModel._Instance = new ShowerModel();
		return true;
	}

	// Token: 0x06013F0A RID: 81674 RVA: 0x005D0A01 File Offset: 0x005CEC01
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013F0B RID: 81675 RVA: 0x005D0A03 File Offset: 0x005CEC03
	public static void ResetStaticDefaultValue()
	{
		ShowerModel._Instance = null;
	}

	// Token: 0x06013F0C RID: 81676 RVA: 0x005D0A0B File Offset: 0x005CEC0B
	static ShowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShowerModel.CreateStaticDefaultValue), new Action(ShowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A9D8 RID: 43480
	private readonly Dictionary<int, RoleInstance> SelectInviteMap = new Dictionary<int, RoleInstance>();

	// Token: 0x0400A9D9 RID: 43481
	private readonly Dictionary<int, RoleInstance> CurInviteMap = new Dictionary<int, RoleInstance>();

	// Token: 0x0400A9DA RID: 43482
	private int CurSelectPosIndexInternal;

	// Token: 0x0400A9DB RID: 43483
	private List<int> VehicleSeatConfigIds = new List<int>();

	// Token: 0x0400A9DC RID: 43484
	private readonly List<int> RolePosIdList = new List<int>();

	// Token: 0x0400A9DD RID: 43485
	public bool IsInShower;

	// Token: 0x0400A9DE RID: 43486
	[Nullable(2)]
	private static ShowerModel _Instance;
}
