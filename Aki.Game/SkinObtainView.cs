using System;
using System.Collections.Generic;
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

// Token: 0x02001FAF RID: 8111
[NullableContext(2)]
[Nullable(0)]
public class SkinObtainView : UiViewBase
{
	// Token: 0x060141F1 RID: 82417 RVA: 0x005DEC46 File Offset: 0x005DCE46
	[NullableContext(1)]
	public SkinObtainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060141F2 RID: 82418 RVA: 0x005DEC50 File Offset: 0x005DCE50
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

	// Token: 0x060141F3 RID: 82419 RVA: 0x005DEE8C File Offset: 0x005DD08C
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

	// Token: 0x060141F4 RID: 82420 RVA: 0x005DEF6A File Offset: 0x005DD16A
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060141F5 RID: 82421 RVA: 0x005DEF71 File Offset: 0x005DD171
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060141F6 RID: 82422 RVA: 0x005DEF7C File Offset: 0x005DD17C
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

	// Token: 0x060141F7 RID: 82423 RVA: 0x005DF02C File Offset: 0x005DD22C
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

	// Token: 0x060141F8 RID: 82424 RVA: 0x005DF07B File Offset: 0x005DD27B
	protected override void OnBeforeShow()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "ObtainRoleSkin", Array.Empty<object>());
		this.RefreshView();
	}

	// Token: 0x060141F9 RID: 82425 RVA: 0x005DF09F File Offset: 0x005DD29F
	protected override void OnBeforeHide()
	{
	}

	// Token: 0x060141FA RID: 82426 RVA: 0x005DF0A4 File Offset: 0x005DD2A4
	private void RefreshView()
	{
		this.RefreshName(this.ObtainSkinData);
		this.RefreshSubName(this.ObtainSkinData);
		this.RefreshLayout(this.ObtainSkinData);
		this.RefreshRoleSpine(this.ObtainSkinData);
		this.RefreshFrameTextureColor(this.ObtainSkinData);
		this.RefreshFrameTextureColor2(this.ObtainSkinData);
	}

	// Token: 0x060141FB RID: 82427 RVA: 0x005DF0FC File Offset: 0x005DD2FC
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

	// Token: 0x060141FC RID: 82428 RVA: 0x005DF140 File Offset: 0x005DD340
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

	// Token: 0x060141FD RID: 82429 RVA: 0x005DF184 File Offset: 0x005DD384
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
			itemLayout3.RefreshByData(extraRewardData, null, false);
			return;
		}
	}

	// Token: 0x060141FE RID: 82430 RVA: 0x005DF1DC File Offset: 0x005DD3DC
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

	// Token: 0x060141FF RID: 82431 RVA: 0x005DF228 File Offset: 0x005DD428
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

	// Token: 0x06014200 RID: 82432 RVA: 0x005DF26C File Offset: 0x005DD46C
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

	// Token: 0x0400AAEB RID: 43755
	private RoleSkinData ObtainSkinData;

	// Token: 0x0400AAEC RID: 43756
	private TItem[] ExtraRewardData;

	// Token: 0x0400AAED RID: 43757
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x020082BC RID: 33468
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A416 RID: 173078
		BackBtn,
		// Token: 0x0402A417 RID: 173079
		TextureSpine,
		// Token: 0x0402A418 RID: 173080
		TitleText,
		// Token: 0x0402A419 RID: 173081
		TitleSubText,
		// Token: 0x0402A41A RID: 173082
		HorizontalLayout,
		// Token: 0x0402A41B RID: 173083
		RewardItem,
		// Token: 0x0402A41C RID: 173084
		ConfirmBtn,
		// Token: 0x0402A41D RID: 173085
		ShareBtn,
		// Token: 0x0402A41E RID: 173086
		FrameTexture1,
		// Token: 0x0402A41F RID: 173087
		FrameTexture2,
		// Token: 0x0402A420 RID: 173088
		TextureImage,
		// Token: 0x0402A421 RID: 173089
		RewardParentItem,
		// Token: 0x0402A422 RID: 173090
		TextObtainTip
	}
}
