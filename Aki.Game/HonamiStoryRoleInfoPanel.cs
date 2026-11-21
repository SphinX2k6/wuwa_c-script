using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013C2 RID: 5058
public class HonamiStoryRoleInfoPanel : UiPanelBase
{
	// Token: 0x0600C87C RID: 51324 RVA: 0x003BAD90 File Offset: 0x003B8F90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600C87D RID: 51325 RVA: 0x003BAE2C File Offset: 0x003B902C
	protected override void OnStart()
	{
		this.ActiveLayout = new GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo>(base.GetVerticalLayout(3), new Func<HonamiStoryEquipItemInfoItem>(this.CreateEquipItemInfoItem), null, false, true);
	}

	// Token: 0x0600C87E RID: 51326 RVA: 0x003BAE4F File Offset: 0x003B904F
	[NullableContext(1)]
	private HonamiStoryEquipItemInfoItem CreateEquipItemInfoItem()
	{
		return new HonamiStoryEquipItemInfoItem();
	}

	// Token: 0x0600C87F RID: 51327 RVA: 0x003BAE56 File Offset: 0x003B9056
	public void SetData(int roleId)
	{
		this.RoleId = roleId;
		this.RefreshEquipInfo();
	}

	// Token: 0x0600C880 RID: 51328 RVA: 0x003BAE68 File Offset: 0x003B9068
	private void RefreshEquipInfo()
	{
		HonamiStoryRoleEquipData roleEquipDataByRoleId = HonamiStoryModel.Instance.GetRoleEquipDataByRoleId(this.RoleId);
		if (roleEquipDataByRoleId == null)
		{
			GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> activeLayout = this.ActiveLayout;
			if (activeLayout != null)
			{
				activeLayout.SetActive(false);
			}
			base.GetItem(5).SetUIActive(false);
			return;
		}
		List<HonamiStoryEquipItemData> equipRoleItemList = roleEquipDataByRoleId.GetEquipRoleItemList();
		List<IHonamiStoryTipsBuffInfo> list = new List<IHonamiStoryTipsBuffInfo>();
		foreach (HonamiStoryEquipItemData honamiStoryEquipItemData in equipRoleItemList)
		{
			if (HonamiStoryUtil.CheckRolePowerValid(this.RoleId, honamiStoryEquipItemData.GetRoleId()))
			{
				List<IHonamiStoryTipsBuffInfo> buffTempIdList = honamiStoryEquipItemData.GetBuffTempIdList(true);
				if (buffTempIdList.Count > 0)
				{
					list.Add(buffTempIdList[0]);
				}
			}
		}
		bool flag = list.Count > 0;
		if (flag)
		{
			GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> activeLayout2 = this.ActiveLayout;
			if (activeLayout2 != null)
			{
				activeLayout2.RefreshByData(list, null, false);
			}
		}
		GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> activeLayout3 = this.ActiveLayout;
		if (activeLayout3 != null)
		{
			activeLayout3.SetActive(flag);
		}
		base.GetItem(5).SetUIActive(flag);
	}

	// Token: 0x0600C881 RID: 51329 RVA: 0x003BAF68 File Offset: 0x003B9168
	[NullableContext(1)]
	public void RefreshSkillInfo(string skillName, string skillInfo, string skillType, string[] skillInfoParam)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), skillName, Array.Empty<object>());
		if (skillInfoParam != null && skillInfoParam.Length != 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), skillInfo, skillInfoParam);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), skillInfo, Array.Empty<object>());
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(skillType, true);
		}
		GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> activeLayout = this.ActiveLayout;
		if (activeLayout == null)
		{
			return;
		}
		activeLayout.RefreshWithoutDataSync();
	}

	// Token: 0x040071F8 RID: 29176
	private int RoleId;

	// Token: 0x040071F9 RID: 29177
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> ActiveLayout;

	// Token: 0x02007686 RID: 30342
	internal enum EComponentType
	{
		// Token: 0x040267B1 RID: 157617
		SkillTypeNameText,
		// Token: 0x040267B2 RID: 157618
		SkillNameText,
		// Token: 0x040267B3 RID: 157619
		SkillInfoText,
		// Token: 0x040267B4 RID: 157620
		EquipInfoVerticalLayout,
		// Token: 0x040267B5 RID: 157621
		EquipInfoItem,
		// Token: 0x040267B6 RID: 157622
		EquipTitleItem
	}
}
