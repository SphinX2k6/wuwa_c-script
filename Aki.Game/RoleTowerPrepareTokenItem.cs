using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CE8 RID: 7400
public class RoleTowerPrepareTokenItem : UiPanelBase
{
	// Token: 0x06012511 RID: 75025 RVA: 0x005672E8 File Offset: 0x005654E8
	[NullableContext(1)]
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012512 RID: 75026 RVA: 0x005672F4 File Offset: 0x005654F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x06012513 RID: 75027 RVA: 0x005673B4 File Offset: 0x005655B4
	public void Refresh(int tokenId)
	{
		bool flag = tokenId > 0;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(flag);
		}
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 != null)
		{
			item3.SetUIActive(RoleTowerModel.Instance.HasTokenRedDot());
		}
		if (!flag)
		{
			return;
		}
		this.RefreshIcon(tokenId, base.GetTexture(1));
	}

	// Token: 0x06012514 RID: 75028 RVA: 0x00567434 File Offset: 0x00565634
	[NullableContext(2)]
	private void RefreshIcon(int tokenId, UUITexture icon)
	{
		if (icon == null)
		{
			return;
		}
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(tokenId);
		ItemConfig itemConfig = (tokenCfg != null) ? InventoryConfig.Instance.GetItemConfigData(tokenCfg.Value.ItemId) : null;
		if (itemConfig == null)
		{
			icon.SetUIActive(false);
			return;
		}
		icon.SetUIActive(true);
		base.SetTextureByPath(itemConfig.IconMiddle ?? string.Empty, icon, null, null);
	}

	// Token: 0x06012515 RID: 75029 RVA: 0x005674A9 File Offset: 0x005656A9
	private void OnClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x04009FBB RID: 40891
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02007FEF RID: 32751
	private static class EChildType
	{
		// Token: 0x0402963D RID: 169533
		public const int Btn = 0;

		// Token: 0x0402963E RID: 169534
		public const int TexIcon = 1;

		// Token: 0x0402963F RID: 169535
		public const int PnlCount = 2;

		// Token: 0x04029640 RID: 169536
		public const int TxtCount = 3;

		// Token: 0x04029641 RID: 169537
		public const int EmptyItem = 6;

		// Token: 0x04029642 RID: 169538
		public const int PnlRedDot = 11;
	}
}
