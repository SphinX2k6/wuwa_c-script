using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002A03 RID: 10755
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShowerInviteItem : GridProxyAbstract<IShowerInviteItemData>
{
	// Token: 0x06016510 RID: 91408 RVA: 0x005A5AB0 File Offset: 0x005A3CB0
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

	// Token: 0x06016511 RID: 91409 RVA: 0x005A5B64 File Offset: 0x005A3D64
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

	// Token: 0x06016512 RID: 91410 RVA: 0x005A5BC4 File Offset: 0x005A3DC4
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

	// Token: 0x06016513 RID: 91411 RVA: 0x005A5D18 File Offset: 0x005A3F18
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

	// Token: 0x06016514 RID: 91412 RVA: 0x005A5E1D File Offset: 0x005A401D
	[NullableContext(1)]
	public void BindRoleSelectCallback(Action<RoleInstance> callback)
	{
		this.RoleSelectCallback = callback;
	}

	// Token: 0x06016515 RID: 91413 RVA: 0x005A5E26 File Offset: 0x005A4026
	private void OnClickToggle(EToggleState state)
	{
		Action<RoleInstance> roleSelectCallback = this.RoleSelectCallback;
		if (roleSelectCallback == null)
		{
			return;
		}
		roleSelectCallback(this.RoleInstance);
	}

	// Token: 0x0400A5F7 RID: 42487
	private int RoleId;

	// Token: 0x0400A5F8 RID: 42488
	private RoleInstance RoleInstance;

	// Token: 0x0400A5F9 RID: 42489
	private bool IsInFormation;

	// Token: 0x0400A5FA RID: 42490
	private UUIExtendToggle Toggle;

	// Token: 0x0400A5FB RID: 42491
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<RoleInstance> RoleSelectCallback;

	// Token: 0x0400A5FC RID: 42492
	private SmallItemGrid ItemGrid;

	// Token: 0x0200903D RID: 36925
	[NullableContext(0)]
	private class EShowerInviteItemComponents
	{
		// Token: 0x0402EB44 RID: 191300
		public const int Toggle = 0;

		// Token: 0x0402EB45 RID: 191301
		public const int RoleNameText = 1;

		// Token: 0x0402EB46 RID: 191302
		public const int FavorDesText = 2;

		// Token: 0x0402EB47 RID: 191303
		public const int RoleItem = 3;

		// Token: 0x0402EB48 RID: 191304
		public const int FavorLevelText = 4;

		// Token: 0x0402EB49 RID: 191305
		public const int NumItem = 5;

		// Token: 0x0402EB4A RID: 191306
		public const int NumText = 6;
	}
}
