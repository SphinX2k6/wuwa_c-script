using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A27 RID: 10791
public class FlySkinObtainView : UiViewBase
{
	// Token: 0x060166FA RID: 91898 RVA: 0x005AD275 File Offset: 0x005AB475
	[NullableContext(1)]
	public FlySkinObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060166FB RID: 91899 RVA: 0x005AD2A4 File Offset: 0x005AB4A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060166FC RID: 91900 RVA: 0x005AD4E0 File Offset: 0x005AB6E0
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(4), this.InitGridItem, null, false, true);
		FlySkinObtainViewData flySkinObtainViewData = this.OpenParam as FlySkinObtainViewData;
		foreach (RewardItemData rewardItemData in flySkinObtainViewData.ObtainFlySkinData)
		{
			FlySkinData flySkinData = FlySkinModel.Instance.GetFlySkinData(rewardItemData.ConfigId);
			if (flySkinData != null && flySkinData.GetFlySkinConfig().SkinType == 1)
			{
				this.ObtainFlySkinData = flySkinData;
				break;
			}
		}
		List<RewardItemData> otherRewardData = flySkinObtainViewData.OtherRewardData;
		if (otherRewardData != null)
		{
			this.ExtraRewardData = new List<TItem>();
			foreach (RewardItemData rewardItemData2 in otherRewardData)
			{
				InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(rewardItemData2.ConfigId, 0);
				int count = 0;
				if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemData2.ConfigId)) == InventoryDefine.EItemDataType.VirtualItem)
				{
					count = rewardItemData2.Count;
				}
				TItem item = new TItem(itemData, count);
				this.ExtraRewardData.Add(item);
			}
		}
	}

	// Token: 0x060166FD RID: 91901 RVA: 0x005AD624 File Offset: 0x005AB824
	protected override void OnBeforeShow()
	{
		if (this.ObtainFlySkinData == null)
		{
			return;
		}
		base.GetSpine(1).SetActive(false, false);
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.ObtainFlySkinData.GetTitleName(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.ObtainFlySkinData.GetSubTitle(), Array.Empty<object>());
		base.SetTextureByPath(this.ObtainFlySkinData.GetTextureInSkinObtainView(), base.GetTexture(10), null, null);
		string hexStr = this.ObtainFlySkinData.GetObtainFrameColor1();
		base.GetTexture(8).SetColor(FColor.FromHex(hexStr));
		hexStr = this.ObtainFlySkinData.GetObtainFrameColor2();
		base.GetTexture(9).SetColor(FColor.FromHex(hexStr));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "ObtainFlySkin", Array.Empty<object>());
		this.RefreshLayout();
	}

	// Token: 0x060166FE RID: 91902 RVA: 0x005AD72C File Offset: 0x005AB92C
	private void RefreshLayout()
	{
		if (this.ExtraRewardData == null)
		{
			UUIItem item = base.GetItem(11);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			List<TItem> extraRewardData = this.ExtraRewardData;
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(extraRewardData.Count != 0);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(extraRewardData, null, false);
			return;
		}
	}

	// Token: 0x060166FF RID: 91903 RVA: 0x005AD78B File Offset: 0x005AB98B
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016700 RID: 91904 RVA: 0x005AD794 File Offset: 0x005AB994
	private void OnClickConfirmBtn()
	{
		BlackScreenController.Instance.AddBlackScreenAsync("Start", "OpenRoleSkinView", "Black", "Default");
		base.CloseMe(delegate(bool _)
		{
			int num = RoleModel.Instance.GetRoleSystemRoleList(false)[0];
			SkinController instance = SkinController.Instance;
			int roleId = num;
			EUiTabViewName flySkinTabView = EUiTabViewName.FlySkinTabView;
			bool needLoadRole = true;
			int selectRoleSkinId = -1;
			TOpenViewCallBack finishCallback = delegate(bool success, int viewId)
			{
				BlackScreenController.Instance.RemoveBlackScreen("Close", "OpenRoleSkinView", "Default");
			};
			FlySkinData obtainFlySkinData = this.ObtainFlySkinData;
			instance.SkipToSkinView(roleId, flySkinTabView, needLoadRole, selectRoleSkinId, finishCallback, (obtainFlySkinData != null) ? new int?(obtainFlySkinData.GetItemId()) : null, null);
		});
	}

	// Token: 0x0400A6BD RID: 42685
	[Nullable(2)]
	private FlySkinData ObtainFlySkinData;

	// Token: 0x0400A6BE RID: 42686
	[Nullable(2)]
	private List<TItem> ExtraRewardData;

	// Token: 0x0400A6BF RID: 42687
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x0400A6C0 RID: 42688
	[Nullable(1)]
	private readonly Func<CommonItemSmallItemGrid> InitGridItem = () => new CommonItemSmallItemGrid();

	// Token: 0x0200905D RID: 36957
	private enum EComponent
	{
		// Token: 0x0402EC31 RID: 191537
		BackBtn,
		// Token: 0x0402EC32 RID: 191538
		TextureSpine,
		// Token: 0x0402EC33 RID: 191539
		TitleText,
		// Token: 0x0402EC34 RID: 191540
		TitleSubText,
		// Token: 0x0402EC35 RID: 191541
		HorizontalLayout,
		// Token: 0x0402EC36 RID: 191542
		RewardItem,
		// Token: 0x0402EC37 RID: 191543
		ConfirmBtn,
		// Token: 0x0402EC38 RID: 191544
		ShareBtn,
		// Token: 0x0402EC39 RID: 191545
		FrameTexture1,
		// Token: 0x0402EC3A RID: 191546
		FrameTexture2,
		// Token: 0x0402EC3B RID: 191547
		TextureImage,
		// Token: 0x0402EC3C RID: 191548
		ItemRewardPanel,
		// Token: 0x0402EC3D RID: 191549
		TextObtainTip
	}
}
