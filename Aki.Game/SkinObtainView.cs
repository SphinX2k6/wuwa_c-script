using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A34 RID: 10804
[NullableContext(2)]
[Nullable(0)]
public class SkinObtainView : UiViewBase
{
	// Token: 0x060167E8 RID: 92136 RVA: 0x005B3ACE File Offset: 0x005B1CCE
	[NullableContext(1)]
	public SkinObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060167E9 RID: 92137 RVA: 0x005B3AD8 File Offset: 0x005B1CD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
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
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickShareBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060167EA RID: 92138 RVA: 0x005B3D14 File Offset: 0x005B1F14
	protected override void OnStart()
	{
		this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(4), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		SkinObtainViewData skinObtainViewData = (SkinObtainViewData)this.OpenParam;
		int configId = skinObtainViewData.ObtainSkinData[0].ConfigId;
		this.ObtainSkinData = RoleSkinModel.Instance.GetRoleSkinData(configId);
		RewardItemData[] otherRewardData = skinObtainViewData.OtherRewardData;
		if (otherRewardData != null)
		{
			List<TItem> list = new List<TItem>();
			foreach (RewardItemData rewardItemData in otherRewardData)
			{
				InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemData.ConfigId));
				if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.WeaponSkinItem)
				{
					InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(rewardItemData.ConfigId, 0);
					int count = 0;
					if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.VirtualItem)
					{
						count = rewardItemData.Count;
					}
					TItem item = new TItem(itemData, count);
					list.Add(item);
				}
			}
			this.ExtraRewardData = list.ToArray();
		}
	}

	// Token: 0x060167EB RID: 92139 RVA: 0x005B3DF2 File Offset: 0x005B1FF2
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060167EC RID: 92140 RVA: 0x005B3DF9 File Offset: 0x005B1FF9
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060167ED RID: 92141 RVA: 0x005B3E04 File Offset: 0x005B2004
	private void OnClickConfirmBtn()
	{
		int roleId = this.ObtainSkinData.GetRoleId();
		bool flag = this.ObtainSkinData.GetIfHaveRole();
		if (RoleModel.Instance.IsMainRole(roleId))
		{
			roleId = RoleModel.Instance.GetCurSelectMainRoleId().Value;
			flag = true;
		}
		if (!flag)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ObtainNoRole);
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
			return;
		}
		BlackScreenController.Instance.AddBlackScreenAsync("Start", "OpenRoleSkinView", "Black", "Default");
		base.CloseMe(delegate(bool _)
		{
			SkinController.Instance.SkipToSkinView(roleId, EUiTabViewName.RoleSkinTabView, true, this.ObtainSkinData.GetItemId(), delegate(bool _, int _)
			{
				BlackScreenController.Instance.RemoveBlackScreen("Close", "OpenRoleSkinView", "Default");
			}, null, null);
		});
	}

	// Token: 0x060167EE RID: 92142 RVA: 0x005B3EB4 File Offset: 0x005B20B4
	private void OnClickShareBtn()
	{
		RoleSkinData obtainSkinData = this.ObtainSkinData;
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = false,
			IsHiddenBattleView = false,
			HandBookPhotoData = null,
			RoleSkinData = obtainSkinData,
			ShareId = 16
		};
		UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
	}

	// Token: 0x060167EF RID: 92143 RVA: 0x005B3F03 File Offset: 0x005B2103
	protected override void OnBeforeShow()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "ObtainRoleSkin", Array.Empty<object>());
		this.RefreshView();
	}

	// Token: 0x060167F0 RID: 92144 RVA: 0x005B3F27 File Offset: 0x005B2127
	protected override void OnBeforeHide()
	{
	}

	// Token: 0x060167F1 RID: 92145 RVA: 0x005B3F2C File Offset: 0x005B212C
	private void RefreshView()
	{
		this.RefreshName(this.ObtainSkinData);
		this.RefreshSubName(this.ObtainSkinData);
		this.RefreshLayout(this.ObtainSkinData);
		this.RefreshRoleSpine(this.ObtainSkinData);
		this.RefreshFrameTextureColor(this.ObtainSkinData);
		this.RefreshFrameTextureColor2(this.ObtainSkinData);
	}

	// Token: 0x060167F2 RID: 92146 RVA: 0x005B3F84 File Offset: 0x005B2184
	private void RefreshName(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetText(2).SetText("", true);
			return;
		}
		string titleName = data.GetTitleName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), titleName, Array.Empty<object>());
	}

	// Token: 0x060167F3 RID: 92147 RVA: 0x005B3FC8 File Offset: 0x005B21C8
	private void RefreshSubName(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetText(3).SetText("", true);
			return;
		}
		string subTitle = data.GetSubTitle();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), subTitle, Array.Empty<object>());
	}

	// Token: 0x060167F4 RID: 92148 RVA: 0x005B400C File Offset: 0x005B220C
	private void RefreshLayout(RoleSkinData data)
	{
		if (this.ExtraRewardData == null)
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.SetActive(false);
			return;
		}
		else
		{
			TItem[] extraRewardData = this.ExtraRewardData;
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout2 = this.ItemLayout;
			if (itemLayout2 != null)
			{
				itemLayout2.SetActive(extraRewardData.Length != 0);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout3 = this.ItemLayout;
			if (itemLayout3 == null)
			{
				return;
			}
			itemLayout3.RefreshByData(extraRewardData.ToList<TItem>(), null, false);
			return;
		}
	}

	// Token: 0x060167F5 RID: 92149 RVA: 0x005B4068 File Offset: 0x005B2268
	private UniTask RefreshRoleSpine(RoleSkinData data)
	{
		SkinObtainView.<RefreshRoleSpine>d__17 <RefreshRoleSpine>d__;
		<RefreshRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleSpine>d__.<>4__this = this;
		<RefreshRoleSpine>d__.data = data;
		<RefreshRoleSpine>d__.<>1__state = -1;
		<RefreshRoleSpine>d__.<>t__builder.Start<SkinObtainView.<RefreshRoleSpine>d__17>(ref <RefreshRoleSpine>d__);
		return <RefreshRoleSpine>d__.<>t__builder.Task;
	}

	// Token: 0x060167F6 RID: 92150 RVA: 0x005B40B4 File Offset: 0x005B22B4
	private void RefreshFrameTextureColor(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(8).SetUIActive(false);
			return;
		}
		base.GetTexture(8).SetUIActive(true);
		FColor color = FColor.FromHex(data.GetObtainFrameColor1());
		base.GetTexture(8).SetColor(color);
	}

	// Token: 0x060167F7 RID: 92151 RVA: 0x005B40F8 File Offset: 0x005B22F8
	private void RefreshFrameTextureColor2(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(9).SetUIActive(false);
			return;
		}
		base.GetTexture(9).SetUIActive(true);
		FColor color = FColor.FromHex(data.GetObtainFrameColor2());
		base.GetTexture(9).SetColor(color);
	}

	// Token: 0x0400A700 RID: 42752
	private RoleSkinData ObtainSkinData;

	// Token: 0x0400A701 RID: 42753
	private TItem[] ExtraRewardData;

	// Token: 0x0400A702 RID: 42754
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x02009075 RID: 36981
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ED1E RID: 191774
		BackBtn,
		// Token: 0x0402ED1F RID: 191775
		TextureSpine,
		// Token: 0x0402ED20 RID: 191776
		TitleText,
		// Token: 0x0402ED21 RID: 191777
		TitleSubText,
		// Token: 0x0402ED22 RID: 191778
		HorizontalLayout,
		// Token: 0x0402ED23 RID: 191779
		RewardItem,
		// Token: 0x0402ED24 RID: 191780
		ConfirmBtn,
		// Token: 0x0402ED25 RID: 191781
		ShareBtn,
		// Token: 0x0402ED26 RID: 191782
		FrameTexture1,
		// Token: 0x0402ED27 RID: 191783
		FrameTexture2,
		// Token: 0x0402ED28 RID: 191784
		TextureImage,
		// Token: 0x0402ED29 RID: 191785
		RewardParentItem,
		// Token: 0x0402ED2A RID: 191786
		TextObtainTip
	}
}
