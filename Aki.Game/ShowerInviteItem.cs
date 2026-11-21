using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F7E RID: 8062
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShowerInviteItem : GridProxyAbstract<IShowerInviteItemData>
{
	// Token: 0x06013F17 RID: 81687 RVA: 0x005D0A88 File Offset: 0x005CEC88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x06013F18 RID: 81688 RVA: 0x005D0B3C File Offset: 0x005CED3C
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
		this.Toggle = base.GetExtendToggle(0);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.OnStateChange.Add(new Action<EToggleState>(this.OnClickToggle));
	}

	// Token: 0x06013F19 RID: 81689 RVA: 0x005D0B9C File Offset: 0x005CED9C
	[NullableContext(1)]
	public override void Refresh(IShowerInviteItemData data, bool isSelected, int gridIndex)
	{
		this.RoleInstance = data.RoleInstance;
		this.RoleId = data.RoleInstance.GetRoleId();
		this.IsInFormation = data.IsInFormation;
		this.RefreshState();
		CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
		{
			Data = this.RoleInstance,
			SkinId = new int?(this.RoleInstance.GetRoleSkinId()),
			ItemConfigId = new int?(this.RoleId),
			IsBlack = new bool?(this.IsInFormation)
		};
		SmallItemGrid itemGrid = this.ItemGrid;
		if (itemGrid != null)
		{
			itemGrid.Apply<CharacterSmallItemGrid>(parameters);
		}
		SmallItemGrid itemGrid2 = this.ItemGrid;
		if (itemGrid2 != null)
		{
			itemGrid2.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(this.RoleInstance.GetRoleRealName(), true);
		}
		int favorLevel = this.RoleInstance.GetFavorData().GetFavorLevel();
		base.GetText(2).SetUIActive(!this.IsInFormation);
		if (this.IsInFormation)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "CannotInviteInFormation", Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(4);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(favorLevel.ToString() ?? "", true);
	}

	// Token: 0x06013F1A RID: 81690 RVA: 0x005D0CF0 File Offset: 0x005CEEF0
	private void RefreshState()
	{
		if (this.IsInFormation)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
			return;
		}
		else
		{
			int rolePos = ShowerModel.Instance.GetRolePos(this.RoleInstance);
			if (rolePos != -1)
			{
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				UUIText text = base.GetText(6);
				if (text != null)
				{
					text.SetText((rolePos + 1).ToString(), true);
				}
			}
			else
			{
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
			}
			if (!ShowerModel.Instance.CheckRoleInCurPos(this.RoleInstance))
			{
				UUIExtendToggle toggle2 = this.Toggle;
				if (toggle2 != null)
				{
					toggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, false, true, false);
				}
				UUIExtendToggle toggle3 = this.Toggle;
				AActor aactor = (toggle3 != null) ? toggle3.GetOwner() : null;
				if (aactor != null)
				{
					aactor.SetActorScale3D(new FVector(1f, 1f, 1f));
				}
				return;
			}
			UUIExtendToggle toggle4 = this.Toggle;
			if (toggle4 == null)
			{
				return;
			}
			toggle4.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
	}

	// Token: 0x06013F1B RID: 81691 RVA: 0x005D0DF5 File Offset: 0x005CEFF5
	[NullableContext(1)]
	public void BindRoleSelectCallback(Action<RoleInstance> callback)
	{
		this.RoleSelectCallback = callback;
	}

	// Token: 0x06013F1C RID: 81692 RVA: 0x005D0DFE File Offset: 0x005CEFFE
	private void OnClickToggle(EToggleState state)
	{
		Action<RoleInstance> roleSelectCallback = this.RoleSelectCallback;
		if (roleSelectCallback == null)
		{
			return;
		}
		roleSelectCallback(this.RoleInstance);
	}

	// Token: 0x0400A9E1 RID: 43489
	private int RoleId;

	// Token: 0x0400A9E2 RID: 43490
	private RoleInstance RoleInstance;

	// Token: 0x0400A9E3 RID: 43491
	private bool IsInFormation;

	// Token: 0x0400A9E4 RID: 43492
	private UUIExtendToggle Toggle;

	// Token: 0x0400A9E5 RID: 43493
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<RoleInstance> RoleSelectCallback;

	// Token: 0x0400A9E6 RID: 43494
	private SmallItemGrid ItemGrid;

	// Token: 0x02008284 RID: 33412
	[NullableContext(0)]
	private class EShowerInviteItemComponents
	{
		// Token: 0x0402A23C RID: 172604
		public const int Toggle = 0;

		// Token: 0x0402A23D RID: 172605
		public const int RoleNameText = 1;

		// Token: 0x0402A23E RID: 172606
		public const int FavorDesText = 2;

		// Token: 0x0402A23F RID: 172607
		public const int RoleItem = 3;

		// Token: 0x0402A240 RID: 172608
		public const int FavorLevelText = 4;

		// Token: 0x0402A241 RID: 172609
		public const int NumItem = 5;

		// Token: 0x0402A242 RID: 172610
		public const int NumText = 6;
	}
}
