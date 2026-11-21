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

// Token: 0x0200229E RID: 8862
public class WeeklyRogueTeamInfoPanel : UiPanelBase
{
	// Token: 0x06015E3B RID: 89659 RVA: 0x00658EAC File Offset: 0x006570AC
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

	// Token: 0x06015E3C RID: 89660 RVA: 0x00658F58 File Offset: 0x00657158
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueTeamInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueTeamInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015E3D RID: 89661 RVA: 0x00658F9B File Offset: 0x0065719B
	[NullableContext(1)]
	private WeeklyRogueInfoViewRoleItem CreateRoleItem()
	{
		return new WeeklyRogueInfoViewRoleItem
		{
			OnSelectedCallback = new Action<int>(this.OnSelectRole)
		};
	}

	// Token: 0x06015E3E RID: 89662 RVA: 0x00658FB4 File Offset: 0x006571B4
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

	// Token: 0x06015E3F RID: 89663 RVA: 0x00659048 File Offset: 0x00657248
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

	// Token: 0x06015E40 RID: 89664 RVA: 0x006590C4 File Offset: 0x006572C4
	private UniTask InitAttributeItemList()
	{
		WeeklyRogueTeamInfoPanel.<InitAttributeItemList>d__8 <InitAttributeItemList>d__;
		<InitAttributeItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAttributeItemList>d__.<>4__this = this;
		<InitAttributeItemList>d__.<>1__state = -1;
		<InitAttributeItemList>d__.<>t__builder.Start<WeeklyRogueTeamInfoPanel.<InitAttributeItemList>d__8>(ref <InitAttributeItemList>d__);
		return <InitAttributeItemList>d__.<>t__builder.Task;
	}

	// Token: 0x06015E41 RID: 89665 RVA: 0x00659108 File Offset: 0x00657308
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

	// Token: 0x0400B837 RID: 47159
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public GenericLayout<WeeklyRogueInfoViewRoleItem, int> RoleListLayout;

	// Token: 0x0400B838 RID: 47160
	[Nullable(1)]
	public List<AttributeItem> AttributeItemList = new List<AttributeItem>();

	// Token: 0x020084F9 RID: 34041
	private enum EWeeklyRogueTeamInfoPanelDefine
	{
		// Token: 0x0402ADD2 RID: 175570
		RoleListLayout,
		// Token: 0x0402ADD3 RID: 175571
		AttrPanelItem,
		// Token: 0x0402ADD4 RID: 175572
		AttrItem,
		// Token: 0x0402ADD5 RID: 175573
		BtnDetail,
		// Token: 0x0402ADD6 RID: 175574
		TxtBuffDesc
	}
}
