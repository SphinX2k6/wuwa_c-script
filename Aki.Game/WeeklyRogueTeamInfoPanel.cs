using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D44 RID: 11588
public class WeeklyRogueTeamInfoPanel : UiPanelBase
{
	// Token: 0x06018599 RID: 99737 RVA: 0x00632E9C File Offset: 0x0063109C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnDetail))
		};
	}

	// Token: 0x0601859A RID: 99738 RVA: 0x00632F48 File Offset: 0x00631148
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueTeamInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueTeamInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601859B RID: 99739 RVA: 0x00632F8B File Offset: 0x0063118B
	[NullableContext(1)]
	private WeeklyRogueInfoViewRoleItem CreateRoleItem()
	{
		return new WeeklyRogueInfoViewRoleItem
		{
			OnSelectedCallback = new Action<int>(this.OnSelectRole)
		};
	}

	// Token: 0x0601859C RID: 99740 RVA: 0x00632FA4 File Offset: 0x006311A4
	private void OnSelectRole(int index)
	{
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		if (teamItems.Count <= 0)
		{
			Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LPH, "肉鸽属性展示面板, 找不到主控角色实体!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(teamItems[index].GetConfigId, true);
		RoleController.Instance.OnSelectedRoleChange(roleDataById.GetRoleConfig().Id, roleDataById.GetRoleSkinId());
		GenericLayout<WeeklyRogueInfoViewRoleItem, int> roleListLayout = this.RoleListLayout;
		if (roleListLayout != null)
		{
			roleListLayout.SelectGridProxy(index, false);
		}
		this.UpdateAttribute();
	}

	// Token: 0x0601859D RID: 99741 RVA: 0x00633038 File Offset: 0x00631238
	private void OnBtnDetail()
	{
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		if (teamItems.Count <= 0)
		{
			Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LPH, "肉鸽属性展示面板, 找不到主控角色实体!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(teamItems[this.RoleListLayout.GetSelectedGridIndex()].GetConfigId, true);
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueAttributeDetailView, roleDataById.GetShowAttrList(), null);
	}

	// Token: 0x0601859E RID: 99742 RVA: 0x006330B4 File Offset: 0x006312B4
	private UniTask InitAttributeItemList()
	{
		WeeklyRogueTeamInfoPanel.<InitAttributeItemList>d__8 <InitAttributeItemList>d__;
		<InitAttributeItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAttributeItemList>d__.<>4__this = this;
		<InitAttributeItemList>d__.<>1__state = -1;
		<InitAttributeItemList>d__.<>t__builder.Start<WeeklyRogueTeamInfoPanel.<InitAttributeItemList>d__8>(ref <InitAttributeItemList>d__);
		return <InitAttributeItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0601859F RID: 99743 RVA: 0x006330F8 File Offset: 0x006312F8
	protected void UpdateAttribute()
	{
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		if (teamItems.Count <= 0)
		{
			Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LPH, "肉鸽属性展示面板, 找不到主控角色实体!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(teamItems[this.RoleListLayout.GetSelectedGridIndex()].GetConfigId, true);
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
		for (int i = 0; i < this.AttributeItemList.Count; i++)
		{
			AttributeItem attributeItem = this.AttributeItemList[i];
			int id = intArrayConfig[i];
			float showAttributeValueById = roleDataById.GetShowAttributeValueById(id);
			attributeItem.SetCurrentValue(showAttributeValueById);
			attributeItem.SetActive(true);
		}
	}

	// Token: 0x0400B4C2 RID: 46274
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GenericLayout<WeeklyRogueInfoViewRoleItem, int> RoleListLayout;

	// Token: 0x0400B4C3 RID: 46275
	[Nullable(1)]
	public List<AttributeItem> AttributeItemList = new List<AttributeItem>();

	// Token: 0x020092D2 RID: 37586
	private enum EWeeklyRogueTeamInfoPanelDefine
	{
		// Token: 0x0402F74A RID: 194378
		RoleListLayout,
		// Token: 0x0402F74B RID: 194379
		AttrPanelItem,
		// Token: 0x0402F74C RID: 194380
		AttrItem,
		// Token: 0x0402F74D RID: 194381
		BtnDetail,
		// Token: 0x0402F74E RID: 194382
		TxtBuffDesc
	}
}
