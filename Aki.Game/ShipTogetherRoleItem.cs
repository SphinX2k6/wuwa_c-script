using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029E8 RID: 10728
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTogetherRoleItem : GridProxyAbstract<IShipTogetherRoleItemData>
{
	// Token: 0x06016403 RID: 91139 RVA: 0x005A0C30 File Offset: 0x0059EE30
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06016404 RID: 91140 RVA: 0x005A0CB8 File Offset: 0x0059EEB8
	protected override void OnStart()
	{
		this.ItemGrid = new SmallItemGrid();
		this.ItemGrid.Initialize(base.GetItem(4).GetOwner());
		this.Toggle = base.GetExtendToggle(0);
		UUIExtendToggle toggle = this.Toggle;
		if (toggle == null)
		{
			return;
		}
		toggle.OnStateChange.Add(new Action<EToggleState>(this.OnClickToggle));
	}

	// Token: 0x06016405 RID: 91141 RVA: 0x005A0D18 File Offset: 0x0059EF18
	[NullableContext(1)]
	public override void Refresh(IShipTogetherRoleItemData data, bool isSelected, int gridIndex)
	{
		RoleInstance roleInstance = data.RoleInstance;
		this.RoleId = roleInstance.GetRoleId();
		this.IsInFormation = data.IsInFormation;
		this.RefreshState();
		CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
		{
			Data = data,
			SkinId = new int?(roleInstance.GetRoleSkinId()),
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
			text.SetText(roleInstance.GetRoleRealName(), true);
		}
		int favorLevel = roleInstance.GetFavorData().GetFavorLevel();
		base.GetText(2).SetUIActive(!this.IsInFormation);
		if (this.IsInFormation)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "CannotInviteInFormation", Array.Empty<object>());
			return;
		}
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(favorLevel.ToString() ?? "", true);
	}

	// Token: 0x06016406 RID: 91142 RVA: 0x005A0E4C File Offset: 0x0059F04C
	public void BindOnClickToggleCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<UUIExtendToggle, int> func)
	{
		this.OnClickToggleCallBack = func;
	}

	// Token: 0x06016407 RID: 91143 RVA: 0x005A0E55 File Offset: 0x0059F055
	private void OnClickToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				Action<UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
				if (onClickToggleCallBack == null)
				{
					return;
				}
				onClickToggleCallBack(null, 0);
			}
			return;
		}
		Action<UUIExtendToggle, int> onClickToggleCallBack2 = this.OnClickToggleCallBack;
		if (onClickToggleCallBack2 == null)
		{
			return;
		}
		onClickToggleCallBack2(this.Toggle, this.RoleId);
	}

	// Token: 0x06016408 RID: 91144 RVA: 0x005A0E90 File Offset: 0x0059F090
	private void RefreshState()
	{
		if (this.IsInFormation)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			return;
		}
		else if (this.RoleId == ShipTogetherModel.Instance.CurrentSelectTogetherRoleId)
		{
			UUIExtendToggle toggle2 = this.Toggle;
			if (toggle2 == null)
			{
				return;
			}
			toggle2.SetToggleStateForce(EToggleState.ETT_Checked, true, false, false);
			return;
		}
		else
		{
			UUIExtendToggle toggle3 = this.Toggle;
			if (toggle3 == null)
			{
				return;
			}
			toggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
	}

	// Token: 0x0400A58B RID: 42379
	private int RoleId;

	// Token: 0x0400A58C RID: 42380
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A58D RID: 42381
	private UUIExtendToggle Toggle;

	// Token: 0x0400A58E RID: 42382
	private Action<UUIExtendToggle, int> OnClickToggleCallBack;

	// Token: 0x0400A58F RID: 42383
	private bool IsInFormation;

	// Token: 0x02009021 RID: 36897
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402EAAB RID: 191147
		public const int Toggle = 0;

		// Token: 0x0402EAAC RID: 191148
		public const int NameText = 1;

		// Token: 0x0402EAAD RID: 191149
		public const int FavorDesText = 2;

		// Token: 0x0402EAAE RID: 191150
		public const int FavorLevelText = 3;

		// Token: 0x0402EAAF RID: 191151
		public const int RoleItem = 4;
	}
}
