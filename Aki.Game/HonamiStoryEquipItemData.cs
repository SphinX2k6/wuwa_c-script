using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E6C RID: 7788
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipItemData : HonamiStoryItemDataBase
{
	// Token: 0x0600ED21 RID: 60705 RVA: 0x00388044 File Offset: 0x00386244
	public override void Init(HonamiStoryItemInfo itemInfo)
	{
		base.Init(itemInfo);
		HonamiStoryEquipItemInfo honamiStoryEquipItemInfo = itemInfo.HonamiStoryEquipItemInfo;
		if (honamiStoryEquipItemInfo == null)
		{
			return;
		}
		this.MainPropLibraryId = honamiStoryEquipItemInfo.MainPropLibraryId;
		this.OriBuffTempId = honamiStoryEquipItemInfo.OriBuffTempId.ToList<int>();
		this.ChildBuffTempId = honamiStoryEquipItemInfo.ChildBuffTempId.ToList<int>();
		HonamiStoryEquip? config = this.GetConfig();
		this.RoleId = config.Value.RoleId;
		this.GroupId = config.Value.GroupId;
		this.BaseEnhance = config.Value.EnhanceLevel;
		this.WeaponTag = config.Value.Tag;
		this.WeaponEnhance = config.Value.TagEnhanceLevel;
		this.RoleEnhance = config.Value.RoleEnhanceLevel;
	}

	// Token: 0x0600ED22 RID: 60706 RVA: 0x00388116 File Offset: 0x00386316
	public HonamiStoryEquip? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryEquip(base.GetItemId());
	}

	// Token: 0x0600ED23 RID: 60707 RVA: 0x00388128 File Offset: 0x00386328
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600ED24 RID: 60708 RVA: 0x00388130 File Offset: 0x00386330
	public int GetGroupId()
	{
		return this.GroupId;
	}

	// Token: 0x0600ED25 RID: 60709 RVA: 0x00388138 File Offset: 0x00386338
	public int GetBaseEnhance()
	{
		return this.BaseEnhance;
	}

	// Token: 0x0600ED26 RID: 60710 RVA: 0x00388140 File Offset: 0x00386340
	public int GetWeaponTag()
	{
		return this.WeaponTag;
	}

	// Token: 0x0600ED27 RID: 60711 RVA: 0x00388148 File Offset: 0x00386348
	public int GetWeaponEnhance()
	{
		return this.WeaponEnhance;
	}

	// Token: 0x0600ED28 RID: 60712 RVA: 0x00388150 File Offset: 0x00386350
	public int GetRoleEnhance()
	{
		return this.RoleEnhance;
	}

	// Token: 0x0600ED29 RID: 60713 RVA: 0x00388158 File Offset: 0x00386358
	public int[] GetMainPropList()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryPropLibrary(this.MainPropLibraryId);
	}

	// Token: 0x0600ED2A RID: 60714 RVA: 0x0038816C File Offset: 0x0038636C
	public List<string> GetOriBuffDescList()
	{
		List<string> list = new List<string>();
		foreach (int libraryId in this.OriBuffTempId)
		{
			string honamiStoryBuffTempDescFromLibrary = HonamiStoryConfig.Instance.GetHonamiStoryBuffTempDescFromLibrary(libraryId);
			if (honamiStoryBuffTempDescFromLibrary != null)
			{
				list.Add(honamiStoryBuffTempDescFromLibrary);
			}
		}
		return list;
	}

	// Token: 0x0600ED2B RID: 60715 RVA: 0x003881D8 File Offset: 0x003863D8
	public List<IHonamiStoryTipsBuffInfo> GetBuffTempIdList(bool fromTeamView = false)
	{
		List<IHonamiStoryTipsBuffInfo> list = new List<IHonamiStoryTipsBuffInfo>();
		HonamiStoryEquip? config = this.GetConfig();
		int? roleId = (config.Value.RoleId == 0) ? null : new int?(config.Value.RoleId);
		int? tagId = (config.Value.Tag == 0) ? null : new int?(config.Value.Tag);
		foreach (int id in this.OriBuffTempId)
		{
			int? honamiStoryBuffTempLibrary = HonamiStoryConfig.Instance.GetHonamiStoryBuffTempLibrary(id);
			if (honamiStoryBuffTempLibrary != null)
			{
				HonamiStoryTipsBuffInfo item = new HonamiStoryTipsBuffInfo
				{
					BuffId = honamiStoryBuffTempLibrary.Value,
					TagId = tagId,
					RoleId = roleId,
					FromTeamView = fromTeamView
				};
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600ED2C RID: 60716 RVA: 0x003882E4 File Offset: 0x003864E4
	public List<string> GetChildBuffDescList()
	{
		List<string> list = new List<string>();
		foreach (int libraryId in this.ChildBuffTempId)
		{
			string honamiStoryBuffTempDescFromLibrary = HonamiStoryConfig.Instance.GetHonamiStoryBuffTempDescFromLibrary(libraryId);
			if (honamiStoryBuffTempDescFromLibrary != null)
			{
				list.Add(honamiStoryBuffTempDescFromLibrary);
			}
		}
		return list;
	}

	// Token: 0x04006E15 RID: 28181
	protected int MainPropLibraryId = -1;

	// Token: 0x04006E16 RID: 28182
	protected List<int> OriBuffTempId = new List<int>();

	// Token: 0x04006E17 RID: 28183
	protected List<int> ChildBuffTempId = new List<int>();

	// Token: 0x04006E18 RID: 28184
	protected int GroupId = -1;

	// Token: 0x04006E19 RID: 28185
	protected int RoleId = -1;

	// Token: 0x04006E1A RID: 28186
	protected int RoleEnhance = -1;

	// Token: 0x04006E1B RID: 28187
	protected int BaseEnhance = -1;

	// Token: 0x04006E1C RID: 28188
	protected int WeaponTag = -1;

	// Token: 0x04006E1D RID: 28189
	protected int WeaponEnhance = -1;
}
