using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F00 RID: 7936
public class HonamiStoryRoleInfoPanel : UiPanelBase
{
	// Token: 0x0600F45D RID: 62557 RVA: 0x003AF29C File Offset: 0x003AD49C
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

	// Token: 0x0600F45E RID: 62558 RVA: 0x003AF338 File Offset: 0x003AD538
	protected override void OnStart()
	{
		this.ActiveLayout = new GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo>(base.GetVerticalLayout(3), new Func<HonamiStoryEquipItemInfoItem>(this.CreateEquipItemInfoItem), null, false, true);
	}

	// Token: 0x0600F45F RID: 62559 RVA: 0x003AF35B File Offset: 0x003AD55B
	[NullableContext(1)]
	private HonamiStoryEquipItemInfoItem CreateEquipItemInfoItem()
	{
		return new HonamiStoryEquipItemInfoItem();
	}

	// Token: 0x0600F460 RID: 62560 RVA: 0x003AF362 File Offset: 0x003AD562
	public void SetData(int roleId)
	{
		this.RoleId = roleId;
		this.RefreshEquipInfo();
	}

	// Token: 0x0600F461 RID: 62561 RVA: 0x003AF374 File Offset: 0x003AD574
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

	// Token: 0x0600F462 RID: 62562 RVA: 0x003AF474 File Offset: 0x003AD674
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

	// Token: 0x04007117 RID: 28951
	private int RoleId;

	// Token: 0x04007118 RID: 28952
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<HonamiStoryEquipItemInfoItem, IHonamiStoryTipsBuffInfo> ActiveLayout;

	// Token: 0x02008501 RID: 34049
	internal enum EComponentType
	{
		// Token: 0x0402B48D RID: 177293
		SkillTypeNameText,
		// Token: 0x0402B48E RID: 177294
		SkillNameText,
		// Token: 0x0402B48F RID: 177295
		SkillInfoText,
		// Token: 0x0402B490 RID: 177296
		EquipInfoVerticalLayout,
		// Token: 0x0402B491 RID: 177297
		EquipInfoItem,
		// Token: 0x0402B492 RID: 177298
		EquipTitleItem
	}
}
