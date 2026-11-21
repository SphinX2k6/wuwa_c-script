using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;
using Google.Protobuf.Collections;

// Token: 0x02001FCC RID: 8140
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FlySkinModel : ModelBase
{
	// Token: 0x06014321 RID: 82721 RVA: 0x005E3D71 File Offset: 0x005E1F71
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.FlySkinRedDot);
		return true;
	}

	// Token: 0x06014322 RID: 82722 RVA: 0x005E3D84 File Offset: 0x005E1F84
	public void UpdateFlySkinEquipDataList(IReadOnlyList<FlyEquipData> dataList)
	{
		this.SkinIdToRoleIds.Clear();
		this.RoleIdToRoleEquipData.Clear();
		this.UnlockSkinIdSet.Clear();
		foreach (FlyEquipData flyEquipData in dataList)
		{
			int skinId = flyEquipData.SkinId;
			RepeatedField<int> roleIds = flyEquipData.RoleIds;
			this.AddUnlockSkinIdInternal(skinId);
			int skinType = SkinConfig.Instance.GetFlySkinConfig(skinId).Value.SkinType;
			foreach (int roleDataId in roleIds)
			{
				this.AddRoleFlySkinEquipData(roleDataId, skinId, (EFlySkinType)skinType);
			}
		}
	}

	// Token: 0x06014323 RID: 82723 RVA: 0x005E3E54 File Offset: 0x005E2054
	public void AddUnlockSkinId(int skinId)
	{
		if (skinId > 0)
		{
			this.AddUnlockSkinIdInternal(skinId);
			this.TryAddFlySkinRedDot(skinId);
		}
	}

	// Token: 0x06014324 RID: 82724 RVA: 0x005E3E69 File Offset: 0x005E2069
	private void AddUnlockSkinIdInternal(int skinId)
	{
		if (skinId > 0)
		{
			this.UnlockSkinIdSet.Add(skinId);
		}
	}

	// Token: 0x06014325 RID: 82725 RVA: 0x005E3E7C File Offset: 0x005E207C
	public bool CheckSkinIsUnlock(int skinId)
	{
		return skinId == 0 || this.UnlockSkinIdSet.Contains(skinId);
	}

	// Token: 0x06014326 RID: 82726 RVA: 0x005E3E8F File Offset: 0x005E208F
	public int GetFlySkinItemCount(int skinItemId)
	{
		if (this.CheckSkinIsUnlock(skinItemId))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06014327 RID: 82727 RVA: 0x005E3EA0 File Offset: 0x005E20A0
	public void EquipFlySkin(int roleDataId, int skinId)
	{
		if (skinId <= 0)
		{
			return;
		}
		int skinType = SkinConfig.Instance.GetFlySkinConfig(skinId).Value.SkinType;
		int roleEquipFlySkinId = this.GetRoleEquipFlySkinId(roleDataId, (EFlySkinType)skinType);
		if (roleEquipFlySkinId == skinId)
		{
			return;
		}
		this.DeleteRoleFlySkinEquipData(roleDataId, roleEquipFlySkinId, (EFlySkinType)skinType);
		this.AddRoleFlySkinEquipData(roleDataId, skinId, (EFlySkinType)skinType);
		EventSystem.Instance.Emit<int, EFlySkinType, int, int>(EEventName.OnRoleFlySkinChange, roleDataId, (EFlySkinType)skinType, roleEquipFlySkinId, skinId);
	}

	// Token: 0x06014328 RID: 82728 RVA: 0x005E3F04 File Offset: 0x005E2104
	public void UnLoadRoleFlySkinBySkinId(int roleDataId, int skinId)
	{
		int skinType = SkinConfig.Instance.GetFlySkinConfig(skinId).Value.SkinType;
		if (this.DeleteRoleFlySkinEquipData(roleDataId, skinId, (EFlySkinType)skinType))
		{
			EventSystem.Instance.Emit<int, EFlySkinType, int, int>(EEventName.OnRoleFlySkinChange, roleDataId, (EFlySkinType)skinType, skinId, 0);
		}
	}

	// Token: 0x06014329 RID: 82729 RVA: 0x005E3F4C File Offset: 0x005E214C
	public void UnLoadRoleFlySkinBySkinType(int roleDataId, EFlySkinType skinType)
	{
		RoleFlySkinEquipData roleFlySkinEquipData;
		if (!this.RoleIdToRoleEquipData.TryGetValue(roleDataId, out roleFlySkinEquipData))
		{
			return;
		}
		int num;
		if (!roleFlySkinEquipData.SkinEquipMap.TryGetValue(skinType, out num))
		{
			return;
		}
		if (this.DeleteRoleFlySkinEquipData(roleDataId, num, skinType))
		{
			EventSystem.Instance.Emit<int, EFlySkinType, int, int>(EEventName.OnRoleFlySkinChange, roleDataId, skinType, num, 0);
		}
	}

	// Token: 0x0601432A RID: 82730 RVA: 0x005E3F9C File Offset: 0x005E219C
	private void AddRoleFlySkinEquipData(int roleDataId, int skinId, EFlySkinType skinType)
	{
		List<int> list;
		if (!this.SkinIdToRoleIds.TryGetValue(skinId, out list))
		{
			list = new List<int>
			{
				roleDataId
			};
			this.SkinIdToRoleIds.Add(skinId, list);
		}
		else
		{
			list.Add(roleDataId);
		}
		RoleFlySkinEquipData roleFlySkinEquipData;
		if (!this.RoleIdToRoleEquipData.TryGetValue(roleDataId, out roleFlySkinEquipData))
		{
			roleFlySkinEquipData = new RoleFlySkinEquipData
			{
				RoleDataId = roleDataId
			};
			this.RoleIdToRoleEquipData.Add(roleDataId, roleFlySkinEquipData);
		}
		roleFlySkinEquipData.SkinEquipMap[skinType] = skinId;
		roleFlySkinEquipData.SkinEquipSet.Add(skinId);
	}

	// Token: 0x0601432B RID: 82731 RVA: 0x005E4020 File Offset: 0x005E2220
	private bool DeleteRoleFlySkinEquipData(int roleDataId, int skinId, EFlySkinType skinType)
	{
		List<int> list;
		if (!this.SkinIdToRoleIds.TryGetValue(skinId, out list))
		{
			return false;
		}
		int num = list.FindIndex((int roleId) => roleId == roleDataId);
		if (num == -1)
		{
			return false;
		}
		RoleFlySkinEquipData roleFlySkinEquipData;
		if (!this.RoleIdToRoleEquipData.TryGetValue(roleDataId, out roleFlySkinEquipData))
		{
			return false;
		}
		list.RemoveAt(num);
		roleFlySkinEquipData.SkinEquipMap.Remove(skinType);
		roleFlySkinEquipData.SkinEquipSet.Remove(skinId);
		return true;
	}

	// Token: 0x0601432C RID: 82732 RVA: 0x005E40A0 File Offset: 0x005E22A0
	public int GetRoleEquipFlySkinId(int roleDataId, EFlySkinType skinType)
	{
		RoleFlySkinEquipData roleFlySkinEquipData;
		if (!this.RoleIdToRoleEquipData.TryGetValue(roleDataId, out roleFlySkinEquipData))
		{
			return 0;
		}
		int result;
		if (roleFlySkinEquipData.SkinEquipMap.TryGetValue(skinType, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0601432D RID: 82733 RVA: 0x005E40D4 File Offset: 0x005E22D4
	public bool CheckAllRoleEquipFlySkin(int skinId, EFlySkinType skinType)
	{
		foreach (RoleInstance roleInstance in RoleModel.Instance.GetOfficialRoleList())
		{
			int roleEquipFlySkinId = this.GetRoleEquipFlySkinId(roleInstance.GetDataId(), skinType);
			if (skinId != roleEquipFlySkinId)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601432E RID: 82734 RVA: 0x005E4113 File Offset: 0x005E2313
	public bool CheckRoleEquipFlySkin(int roleDataId, int skinId, EFlySkinType skinType)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, skinType) == skinId;
	}

	// Token: 0x0601432F RID: 82735 RVA: 0x005E4120 File Offset: 0x005E2320
	public int GetRoleEquipParaglidingSkinId(int roleDataId)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, EFlySkinType.Paragliding);
	}

	// Token: 0x06014330 RID: 82736 RVA: 0x005E412A File Offset: 0x005E232A
	public int GetRoleEquipSoarWingSkinId(int roleDataId)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, EFlySkinType.SoarWing);
	}

	// Token: 0x06014331 RID: 82737 RVA: 0x005E4134 File Offset: 0x005E2334
	private bool TryAddFlySkinRedDot(int skinId)
	{
		if (skinId == 0)
		{
			return false;
		}
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, skinId))
		{
			return false;
		}
		NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, skinId);
		return true;
	}

	// Token: 0x06014332 RID: 82738 RVA: 0x005E415C File Offset: 0x005E235C
	public bool CheckFlySkinHasRedDotBySkinType(EFlySkinType skinType)
	{
		foreach (FlySkinConfig flySkinConfig in SkinConfig.Instance.GetFlySkinConfigListByType(skinType))
		{
			if (this.CheckSkinIsUnlock(flySkinConfig.Id) && NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FlySkinRedDot, flySkinConfig.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014333 RID: 82739 RVA: 0x005E41D4 File Offset: 0x005E23D4
	public bool CheckFlySkinHasRedDot()
	{
		return this.CheckFlySkinHasRedDotBySkinType(EFlySkinType.Paragliding) || this.CheckFlySkinHasRedDotBySkinType(EFlySkinType.SoarWing);
	}

	// Token: 0x06014334 RID: 82740 RVA: 0x005E41E8 File Offset: 0x005E23E8
	public FlySkinData GetFlySkinData(int itemId)
	{
		FlySkinData result;
		if (this.FlySkinMap.TryGetValue(itemId, out result))
		{
			return result;
		}
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId)) != InventoryDefine.EItemDataType.FlySkinItem)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FlySkin;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "无效的飞行皮肤道具id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		FlySkinData flySkinData = new FlySkinData(itemId);
		this.FlySkinMap.Add(itemId, flySkinData);
		return flySkinData;
	}

	// Token: 0x17001E49 RID: 7753
	// (get) Token: 0x06014335 RID: 82741 RVA: 0x005E4261 File Offset: 0x005E2461
	public static FlySkinModel Instance
	{
		get
		{
			return FlySkinModel._Instance;
		}
	}

	// Token: 0x06014336 RID: 82742 RVA: 0x005E4268 File Offset: 0x005E2468
	public static FlySkinModel GetOrCreateInstance()
	{
		if (FlySkinModel._Instance == null)
		{
			FlySkinModel.CreateInstance();
		}
		return FlySkinModel._Instance;
	}

	// Token: 0x06014337 RID: 82743 RVA: 0x005E427C File Offset: 0x005E247C
	public static bool CreateInstance()
	{
		if (FlySkinModel._Instance != null)
		{
			return true;
		}
		FlySkinModel._Instance = new FlySkinModel();
		return true;
	}

	// Token: 0x06014338 RID: 82744 RVA: 0x005E4292 File Offset: 0x005E2492
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014339 RID: 82745 RVA: 0x005E4294 File Offset: 0x005E2494
	public static void ResetStaticDefaultValue()
	{
		FlySkinModel._Instance = null;
	}

	// Token: 0x0601433A RID: 82746 RVA: 0x005E429C File Offset: 0x005E249C
	static FlySkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinModel.CreateStaticDefaultValue), new Action(FlySkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400AB80 RID: 43904
	private readonly HashSet<int> UnlockSkinIdSet = new HashSet<int>();

	// Token: 0x0400AB81 RID: 43905
	private readonly Dictionary<int, List<int>> SkinIdToRoleIds = new Dictionary<int, List<int>>();

	// Token: 0x0400AB82 RID: 43906
	private readonly Dictionary<int, RoleFlySkinEquipData> RoleIdToRoleEquipData = new Dictionary<int, RoleFlySkinEquipData>();

	// Token: 0x0400AB83 RID: 43907
	private readonly Dictionary<int, FlySkinData> FlySkinMap = new Dictionary<int, FlySkinData>();

	// Token: 0x0400AB84 RID: 43908
	[Nullable(2)]
	private static FlySkinModel _Instance;
}
