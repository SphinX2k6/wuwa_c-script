using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018CF RID: 6351
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleShowView : UiViewBase
{
	// Token: 0x0600FA95 RID: 64149 RVA: 0x004943E9 File Offset: 0x004925E9
	public PersonalRoleShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA96 RID: 64150 RVA: 0x004943F4 File Offset: 0x004925F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirmButton))
		};
	}

	// Token: 0x0600FA97 RID: 64151 RVA: 0x00494474 File Offset: 0x00492674
	private void OnClickConfirmButton()
	{
		List<RoleShowEntry> roleShowList = PersonalModel.Instance.GetRoleShowList();
		int count = roleShowList.Count;
		List<int> list = new List<int>();
		if (this.CurRoleShowOpera == ERoleShowOpera.Add)
		{
			for (int i = 0; i < count; i++)
			{
				RoleShowEntry roleShowEntry = roleShowList[i];
				list.Add(roleShowEntry.Proto_RoleId);
			}
			list.Add(this.CurSelectRoleId);
		}
		else if (this.CurRoleShowOpera == ERoleShowOpera.Remove)
		{
			for (int j = 0; j < count; j++)
			{
				RoleShowEntry roleShowEntry2 = roleShowList[j];
				if (roleShowEntry2.Proto_RoleId != this.CurSelectRoleId)
				{
					list.Add(roleShowEntry2.Proto_RoleId);
				}
			}
		}
		else if (this.CurRoleShowOpera == ERoleShowOpera.Replace)
		{
			for (int k = 0; k < count; k++)
			{
				RoleShowEntry roleShowEntry3 = roleShowList[k];
				if (roleShowEntry3.Proto_RoleId == this.CurSelectRoleId)
				{
					list.Add(this.CurInShowRoleId);
				}
				else if (roleShowEntry3.Proto_RoleId == this.CurInShowRoleId)
				{
					list.Add(this.CurSelectRoleId);
				}
				else
				{
					list.Add(roleShowEntry3.Proto_RoleId);
				}
			}
		}
		PersonalController.Instance.SendRoleShowListUpdateRequest(list);
		base.CloseMe(null);
	}

	// Token: 0x0600FA98 RID: 64152 RVA: 0x00494594 File Offset: 0x00492794
	protected override void OnStart()
	{
		this.CurInShowRoleId = (this.OpenParam as int?).GetValueOrDefault();
		this.ScrollView = new GenericScrollView<PersonalRoleMediumItemGrid>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalRoleMediumItemGrid>(this.InitRoleItem), null);
	}

	// Token: 0x0600FA99 RID: 64153 RVA: 0x004945E0 File Offset: 0x004927E0
	private ILayoutItem<PersonalRoleMediumItemGrid> InitRoleItem(object roleId, UUIItem uiItem, int index)
	{
		PersonalRoleMediumItemGrid personalRoleMediumItemGrid = new PersonalRoleMediumItemGrid();
		personalRoleMediumItemGrid.Initialize(uiItem.GetOwner());
		personalRoleMediumItemGrid.Refresh((int)roleId, false, index);
		personalRoleMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.RoleItemToggleClick));
		return new LayoutItem<PersonalRoleMediumItemGrid>
		{
			Key = index,
			Value = personalRoleMediumItemGrid
		};
	}

	// Token: 0x0600FA9A RID: 64154 RVA: 0x00494638 File Offset: 0x00492838
	private void RoleItemToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		PersonalRoleMediumItemGrid currentSelectedItem = this.CurrentSelectedItem;
		if (currentSelectedItem != null)
		{
			currentSelectedItem.SetSelected(false, false);
		}
		this.CurrentSelectedItem = (callbackParameter.MediumItemGrid as PersonalRoleMediumItemGrid);
		PersonalRoleMediumItemGrid currentSelectedItem2 = this.CurrentSelectedItem;
		if (currentSelectedItem2 != null)
		{
			currentSelectedItem2.SetSelected(true, false);
		}
		int roleId = (int)callbackParameter.Data;
		this.Refresh(roleId);
	}

	// Token: 0x0600FA9B RID: 64155 RVA: 0x00494690 File Offset: 0x00492890
	protected void Refresh(int roleId)
	{
		this.CurSelectRoleId = roleId;
		bool flag = this.CurInShowRoleId == this.CurSelectRoleId;
		List<RoleShowEntry> roleShowList = PersonalModel.Instance.GetRoleShowList();
		base.GetButton(1).RootUIComp.Get().SetUIActive(true);
		bool flag2 = this.IsRoleInShow(this.CurSelectRoleId);
		if (roleShowList.Count == 1 && flag2)
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			return;
		}
		if (this.CurInShowRoleId == 0)
		{
			if (!flag2)
			{
				this.SetConfirmButtonState(ERoleShowOpera.Add);
				return;
			}
			this.SetConfirmButtonState(ERoleShowOpera.Remove);
			return;
		}
		else
		{
			if (flag)
			{
				this.SetConfirmButtonState(ERoleShowOpera.Remove);
				return;
			}
			this.SetConfirmButtonState(ERoleShowOpera.Replace);
			return;
		}
	}

	// Token: 0x0600FA9C RID: 64156 RVA: 0x00494738 File Offset: 0x00492938
	private void SetConfirmButtonState(ERoleShowOpera state)
	{
		this.CurRoleShowOpera = state;
		UUIText text = base.GetText(2);
		switch (state)
		{
		case ERoleShowOpera.Add:
			LguiUtil.Instance.SetLocalText(text, "JoinText", Array.Empty<object>());
			return;
		case ERoleShowOpera.Replace:
			LguiUtil.Instance.SetLocalText(text, "ChangeText", Array.Empty<object>());
			return;
		case ERoleShowOpera.Remove:
			LguiUtil.Instance.SetLocalText(text, "GoDownText", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x0600FA9D RID: 64157 RVA: 0x004947A8 File Offset: 0x004929A8
	protected bool IsRoleInShow(int roleId)
	{
		List<RoleShowEntry> roleShowList = PersonalModel.Instance.GetRoleShowList();
		int count = roleShowList.Count;
		bool result = false;
		for (int i = 0; i < count; i++)
		{
			if (roleShowList[i].Proto_RoleId == this.CurSelectRoleId)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600FA9E RID: 64158 RVA: 0x004947F0 File Offset: 0x004929F0
	protected override void OnAfterShow()
	{
		this.RoleIdList = RoleModel.Instance.GetRoleIdList(null);
		if (this.RoleIdList.Count > 0)
		{
			this.ScrollView.RefreshByData<int>(this.RoleIdList, null);
			this.CurSelectRoleId = this.RoleIdList[0];
			this.CurrentSelectedItem = this.ScrollView.GetScrollItemList()[0];
			this.CurrentSelectedItem.SetSelected(true, false);
			this.Refresh(this.CurSelectRoleId);
		}
	}

	// Token: 0x0600FA9F RID: 64159 RVA: 0x00494878 File Offset: 0x00492A78
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollView != null)
		{
			this.ScrollView.ClearChildren();
			this.ScrollView = null;
		}
	}

	// Token: 0x04008C4A RID: 35914
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<PersonalRoleMediumItemGrid> ScrollView;

	// Token: 0x04008C4B RID: 35915
	[Nullable(2)]
	private List<int> RoleIdList;

	// Token: 0x04008C4C RID: 35916
	private int CurSelectRoleId;

	// Token: 0x04008C4D RID: 35917
	private int CurInShowRoleId;

	// Token: 0x04008C4E RID: 35918
	private ERoleShowOpera CurRoleShowOpera;

	// Token: 0x04008C4F RID: 35919
	[Nullable(2)]
	private PersonalRoleMediumItemGrid CurrentSelectedItem;
}
