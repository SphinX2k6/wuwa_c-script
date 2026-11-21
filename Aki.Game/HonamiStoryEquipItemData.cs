using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x0200132E RID: 4910
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipItemData : HonamiStoryItemDataBase
{
	// Token: 0x0600C140 RID: 49472 RVA: 0x00393C50 File Offset: 0x00391E50
	public override void Init(HonamiStoryItemInfo itemInfo)
	{
		base.Init(itemInfo);
		HonamiStoryEquipItemInfo honamiStoryEquipItemInfo = itemInfo.HonamiStoryEquipItemInfo;
		if (honamiStoryEquipItemInfo == null)
		{
			return;
		}
		this.MainPropLibraryId = honamiStoryEquipItemInfo.MainPropLibraryId;
		this.OriBuffTempId = new List<int>(honamiStoryEquipItemInfo.OriBuffTempId);
		this.ChildBuffTempId = new List<int>(honamiStoryEquipItemInfo.ChildBuffTempId);
		HonamiStoryEquip? config = this.GetConfig();
		this.RoleId = config.Value.RoleId;
		this.GroupId = config.Value.GroupId;
		this.BaseEnhance = config.Value.EnhanceLevel;
		this.WeaponTag = config.Value.Tag;
		this.WeaponEnhance = config.Value.TagEnhanceLevel;
		this.RoleEnhance = config.Value.RoleEnhanceLevel;
	}

	// Token: 0x0600C141 RID: 49473 RVA: 0x00393D22 File Offset: 0x00391F22
	public HonamiStoryEquip? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryEquip(base.GetItemId());
	}

	// Token: 0x0600C142 RID: 49474 RVA: 0x00393D34 File Offset: 0x00391F34
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x0600C143 RID: 49475 RVA: 0x00393D3C File Offset: 0x00391F3C
	public int GetGroupId()
	{
		return this.GroupId;
	}

	// Token: 0x0600C144 RID: 49476 RVA: 0x00393D44 File Offset: 0x00391F44
	public int GetBaseEnhance()
	{
		return this.BaseEnhance;
	}

	// Token: 0x0600C145 RID: 49477 RVA: 0x00393D4C File Offset: 0x00391F4C
	public int GetWeaponTag()
	{
		return this.WeaponTag;
	}

	// Token: 0x0600C146 RID: 49478 RVA: 0x00393D54 File Offset: 0x00391F54
	public int GetWeaponEnhance()
	{
		return this.WeaponEnhance;
	}

	// Token: 0x0600C147 RID: 49479 RVA: 0x00393D5C File Offset: 0x00391F5C
	public int GetRoleEnhance()
	{
		return this.RoleEnhance;
	}

	// Token: 0x0600C148 RID: 49480 RVA: 0x00393D64 File Offset: 0x00391F64
	public int[] GetMainPropList()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryPropLibrary(this.MainPropLibraryId);
	}

	// Token: 0x0600C149 RID: 49481 RVA: 0x00393D78 File Offset: 0x00391F78
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

	// Token: 0x0600C14A RID: 49482 RVA: 0x00393DE4 File Offset: 0x00391FE4
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

	// Token: 0x0600C14B RID: 49483 RVA: 0x00393EF0 File Offset: 0x003920F0
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

	// Token: 0x04006EF6 RID: 28406
	protected int MainPropLibraryId = -1;

	// Token: 0x04006EF7 RID: 28407
	protected List<int> OriBuffTempId = new List<int>();

	// Token: 0x04006EF8 RID: 28408
	protected List<int> ChildBuffTempId = new List<int>();

	// Token: 0x04006EF9 RID: 28409
	protected int GroupId = -1;

	// Token: 0x04006EFA RID: 28410
	protected int RoleId = -1;

	// Token: 0x04006EFB RID: 28411
	protected int RoleEnhance = -1;

	// Token: 0x04006EFC RID: 28412
	protected int BaseEnhance = -1;

	// Token: 0x04006EFD RID: 28413
	protected int WeaponTag = -1;

	// Token: 0x04006EFE RID: 28414
	protected int WeaponEnhance = -1;
}
