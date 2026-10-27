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

// Token: 0x02002A51 RID: 10833
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FlySkinModel : ModelBase
{
	// Token: 0x06016900 RID: 92416 RVA: 0x005B7C2D File Offset: 0x005B5E2D
	protected override bool OnClear()
	{
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.FlySkinRedDot);
		return true;
	}

	// Token: 0x06016901 RID: 92417 RVA: 0x005B7C40 File Offset: 0x005B5E40
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

	// Token: 0x06016902 RID: 92418 RVA: 0x005B7D10 File Offset: 0x005B5F10
	public void AddUnlockSkinId(int skinId)
	{
		if (skinId > 0)
		{
			this.AddUnlockSkinIdInternal(skinId);
			this.TryAddFlySkinRedDot(skinId);
		}
	}

	// Token: 0x06016903 RID: 92419 RVA: 0x005B7D25 File Offset: 0x005B5F25
	private void AddUnlockSkinIdInternal(int skinId)
	{
		if (skinId > 0)
		{
			this.UnlockSkinIdSet.Add(skinId);
		}
	}

	// Token: 0x06016904 RID: 92420 RVA: 0x005B7D38 File Offset: 0x005B5F38
	public bool CheckSkinIsUnlock(int skinId)
	{
		return skinId == 0 || this.UnlockSkinIdSet.Contains(skinId);
	}

	// Token: 0x06016905 RID: 92421 RVA: 0x005B7D4B File Offset: 0x005B5F4B
	public int GetFlySkinItemCount(int skinItemId)
	{
		if (this.CheckSkinIsUnlock(skinItemId))
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06016906 RID: 92422 RVA: 0x005B7D5C File Offset: 0x005B5F5C
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

	// Token: 0x06016907 RID: 92423 RVA: 0x005B7DC0 File Offset: 0x005B5FC0
	public void UnLoadRoleFlySkinBySkinId(int roleDataId, int skinId)
	{
		int skinType = SkinConfig.Instance.GetFlySkinConfig(skinId).Value.SkinType;
		if (this.DeleteRoleFlySkinEquipData(roleDataId, skinId, (EFlySkinType)skinType))
		{
			EventSystem.Instance.Emit<int, EFlySkinType, int, int>(EEventName.OnRoleFlySkinChange, roleDataId, (EFlySkinType)skinType, skinId, 0);
		}
	}

	// Token: 0x06016908 RID: 92424 RVA: 0x005B7E08 File Offset: 0x005B6008
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

	// Token: 0x06016909 RID: 92425 RVA: 0x005B7E58 File Offset: 0x005B6058
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

	// Token: 0x0601690A RID: 92426 RVA: 0x005B7EDC File Offset: 0x005B60DC
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

	// Token: 0x0601690B RID: 92427 RVA: 0x005B7F5C File Offset: 0x005B615C
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

	// Token: 0x0601690C RID: 92428 RVA: 0x005B7F90 File Offset: 0x005B6190
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

	// Token: 0x0601690D RID: 92429 RVA: 0x005B7FCF File Offset: 0x005B61CF
	public bool CheckRoleEquipFlySkin(int roleDataId, int skinId, EFlySkinType skinType)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, skinType) == skinId;
	}

	// Token: 0x0601690E RID: 92430 RVA: 0x005B7FDC File Offset: 0x005B61DC
	public int GetRoleEquipParaglidingSkinId(int roleDataId)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, EFlySkinType.Paragliding);
	}

	// Token: 0x0601690F RID: 92431 RVA: 0x005B7FE6 File Offset: 0x005B61E6
	public int GetRoleEquipSoarWingSkinId(int roleDataId)
	{
		return this.GetRoleEquipFlySkinId(roleDataId, EFlySkinType.SoarWing);
	}

	// Token: 0x06016910 RID: 92432 RVA: 0x005B7FF0 File Offset: 0x005B61F0
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

	// Token: 0x06016911 RID: 92433 RVA: 0x005B8018 File Offset: 0x005B6218
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

	// Token: 0x06016912 RID: 92434 RVA: 0x005B8090 File Offset: 0x005B6290
	public bool CheckFlySkinHasRedDot()
	{
		return this.CheckFlySkinHasRedDotBySkinType(EFlySkinType.Paragliding) || this.CheckFlySkinHasRedDotBySkinType(EFlySkinType.SoarWing);
	}

	// Token: 0x06016913 RID: 92435 RVA: 0x005B80A4 File Offset: 0x005B62A4
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

	// Token: 0x17001DF1 RID: 7665
	// (get) Token: 0x06016914 RID: 92436 RVA: 0x005B811D File Offset: 0x005B631D
	public static FlySkinModel Instance
	{
		get
		{
			return FlySkinModel._Instance;
		}
	}

	// Token: 0x06016915 RID: 92437 RVA: 0x005B8124 File Offset: 0x005B6324
	public static FlySkinModel GetOrCreateInstance()
	{
		if (FlySkinModel._Instance == null)
		{
			FlySkinModel.CreateInstance();
		}
		return FlySkinModel._Instance;
	}

	// Token: 0x06016916 RID: 92438 RVA: 0x005B8138 File Offset: 0x005B6338
	public static bool CreateInstance()
	{
		if (FlySkinModel._Instance != null)
		{
			return true;
		}
		FlySkinModel._Instance = new FlySkinModel();
		return true;
	}

	// Token: 0x06016917 RID: 92439 RVA: 0x005B814E File Offset: 0x005B634E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016918 RID: 92440 RVA: 0x005B8150 File Offset: 0x005B6350
	public static void ResetStaticDefaultValue()
	{
		FlySkinModel._Instance = null;
	}

	// Token: 0x06016919 RID: 92441 RVA: 0x005B8158 File Offset: 0x005B6358
	static FlySkinModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinModel.CreateStaticDefaultValue), new Action(FlySkinModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400A77C RID: 42876
	private readonly HashSet<int> UnlockSkinIdSet = new HashSet<int>();

	// Token: 0x0400A77D RID: 42877
	private readonly Dictionary<int, List<int>> SkinIdToRoleIds = new Dictionary<int, List<int>>();

	// Token: 0x0400A77E RID: 42878
	private readonly Dictionary<int, RoleFlySkinEquipData> RoleIdToRoleEquipData = new Dictionary<int, RoleFlySkinEquipData>();

	// Token: 0x0400A77F RID: 42879
	private readonly Dictionary<int, FlySkinData> FlySkinMap = new Dictionary<int, FlySkinData>();

	// Token: 0x0400A780 RID: 42880
	[Nullable(2)]
	private static FlySkinModel _Instance;
}
