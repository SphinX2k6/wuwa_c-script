using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020023EA RID: 9194
[NullableContext(1)]
[Nullable(0)]
public class PersonalRoleShowView : UiViewBase
{
	// Token: 0x060125E3 RID: 75235 RVA: 0x00486EDD File Offset: 0x004850DD
	public PersonalRoleShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060125E4 RID: 75236 RVA: 0x00486EE8 File Offset: 0x004850E8
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

	// Token: 0x060125E5 RID: 75237 RVA: 0x00486F68 File Offset: 0x00485168
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

	// Token: 0x060125E6 RID: 75238 RVA: 0x00487088 File Offset: 0x00485288
	protected override void OnStart()
	{
		this.CurInShowRoleId = (this.OpenParam as int?).GetValueOrDefault();
		this.ScrollView = new GenericScrollView<PersonalRoleMediumItemGrid>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PersonalRoleMediumItemGrid>(this.InitRoleItem), null);
	}

	// Token: 0x060125E7 RID: 75239 RVA: 0x004870D4 File Offset: 0x004852D4
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

	// Token: 0x060125E8 RID: 75240 RVA: 0x0048712C File Offset: 0x0048532C
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

	// Token: 0x060125E9 RID: 75241 RVA: 0x00487184 File Offset: 0x00485384
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

	// Token: 0x060125EA RID: 75242 RVA: 0x0048722C File Offset: 0x0048542C
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

	// Token: 0x060125EB RID: 75243 RVA: 0x0048729C File Offset: 0x0048549C
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

	// Token: 0x060125EC RID: 75244 RVA: 0x004872E4 File Offset: 0x004854E4
	protected override void OnAfterShow()
	{
		this.RoleIdList = RoleModel.Instance.GetRoleIdList();
		if (this.RoleIdList.Count > 0)
		{
			this.ScrollView.RefreshByData<int>(this.RoleIdList, null);
			this.CurSelectRoleId = this.RoleIdList[0];
			this.CurrentSelectedItem = this.ScrollView.GetScrollItemList()[0];
			this.CurrentSelectedItem.SetSelected(true, false);
			this.Refresh(this.CurSelectRoleId);
		}
	}

	// Token: 0x060125ED RID: 75245 RVA: 0x0048736B File Offset: 0x0048556B
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollView != null)
		{
			this.ScrollView.ClearChildren();
			this.ScrollView = null;
		}
	}

	// Token: 0x04008B03 RID: 35587
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<PersonalRoleMediumItemGrid> ScrollView;

	// Token: 0x04008B04 RID: 35588
	[Nullable(2)]
	private List<int> RoleIdList;

	// Token: 0x04008B05 RID: 35589
	private int CurSelectRoleId;

	// Token: 0x04008B06 RID: 35590
	private int CurInShowRoleId;

	// Token: 0x04008B07 RID: 35591
	private ERoleShowOpera CurRoleShowOpera;

	// Token: 0x04008B08 RID: 35592
	[Nullable(2)]
	private PersonalRoleMediumItemGrid CurrentSelectedItem;
}
