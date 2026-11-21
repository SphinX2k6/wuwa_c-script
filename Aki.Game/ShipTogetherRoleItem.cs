using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F63 RID: 8035
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTogetherRoleItem : GridProxyAbstract<IShipTogetherRoleItemData>
{
	// Token: 0x06013E0A RID: 81418 RVA: 0x005CBC24 File Offset: 0x005C9E24
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

	// Token: 0x06013E0B RID: 81419 RVA: 0x005CBCAC File Offset: 0x005C9EAC
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

	// Token: 0x06013E0C RID: 81420 RVA: 0x005CBD0C File Offset: 0x005C9F0C
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

	// Token: 0x06013E0D RID: 81421 RVA: 0x005CBE40 File Offset: 0x005CA040
	public void BindOnClickToggleCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<UUIExtendToggle, int> func)
	{
		this.OnClickToggleCallBack = func;
	}

	// Token: 0x06013E0E RID: 81422 RVA: 0x005CBE49 File Offset: 0x005CA049
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

	// Token: 0x06013E0F RID: 81423 RVA: 0x005CBE84 File Offset: 0x005CA084
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

	// Token: 0x0400A975 RID: 43381
	private int RoleId;

	// Token: 0x0400A976 RID: 43382
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A977 RID: 43383
	private UUIExtendToggle Toggle;

	// Token: 0x0400A978 RID: 43384
	private Action<UUIExtendToggle, int> OnClickToggleCallBack;

	// Token: 0x0400A979 RID: 43385
	private bool IsInFormation;

	// Token: 0x02008268 RID: 33384
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402A1A3 RID: 172451
		public const int Toggle = 0;

		// Token: 0x0402A1A4 RID: 172452
		public const int NameText = 1;

		// Token: 0x0402A1A5 RID: 172453
		public const int FavorDesText = 2;

		// Token: 0x0402A1A6 RID: 172454
		public const int FavorLevelText = 3;

		// Token: 0x0402A1A7 RID: 172455
		public const int RoleItem = 4;
	}
}
