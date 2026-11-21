using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Phantom.Vision.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DAF RID: 3503
[NullableContext(1)]
[Nullable(0)]
public class TipsVisionComponent : TipsBaseSubComponent
{
	// Token: 0x06008F32 RID: 36658 RVA: 0x002B1154 File Offset: 0x002AF354
	public TipsVisionComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsVision", rootUiItem, false);
	}

	// Token: 0x06008F33 RID: 36659 RVA: 0x002B116C File Offset: 0x002AF36C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008F34 RID: 36660 RVA: 0x002B138C File Offset: 0x002AF58C
	protected override UniTask OnBeforeStartAsync()
	{
		TipsVisionComponent.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TipsVisionComponent.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008F35 RID: 36661 RVA: 0x002B13D0 File Offset: 0x002AF5D0
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		this.TipsLockButton = new TipsLockButton(item);
		this.TipsAttributePanel = new GenericLayoutNew<TipsAttributeItem>(base.GetVerticalLayout(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsAttributeItem>(this.CreateAttributeItem), null);
		this.Layout = new GenericLayoutNew<global::VisionDetailDescItem>(base.GetVerticalLayout(12), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<global::VisionDetailDescItem>(this.CreateInfoItem), null);
		UUIItem item2 = base.GetItem(5);
		this.TipsGetWayPanel = new TipsGetWayPanel(item2);
	}

	// Token: 0x06008F36 RID: 36662 RVA: 0x002B1444 File Offset: 0x002AF644
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x06008F37 RID: 36663 RVA: 0x002B1460 File Offset: 0x002AF660
	public override void Refresh(ItemTipsData data)
	{
		TipsVisionData tipsVisionData = (TipsVisionData)data;
		Action action = delegate()
		{
			TipsVisionData data2 = this.Data;
			base.GetText(0).SetText(data2.Cost.ToString(), true);
			base.GetText(1).SetUIActive(data2.UpgradeLevel != null);
			base.GetText(1).SetText(data2.UpgradeLevel, true);
			if (data2.IncId > 0)
			{
				this.TipsLockButton.Refresh(data2.IncId, data2.CanClickLockButton);
				this.TipsLockButton.SetDeprecateToggleVisible(data2.CanDeprecate());
			}
			TipsLockButton tipsLockButton = this.TipsLockButton;
			if (tipsLockButton != null)
			{
				tipsLockButton.SetUiActive(data2.IncId > 0);
			}
			this.TipsAttributePanel.RebuildLayoutByDataNew<ITipsAttributeItemData>(data2.AttributeData, null);
			PhantomBattleData dataBase = data2.VisionDetailInfoComponentData.DataBase;
			if (dataBase != null && dataBase.GetFetterGroupId() > 0)
			{
				this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(dataBase.GetFetterGroupConfig()));
				this.VisionFetterSuitItem.SetUiActive(true);
			}
			else
			{
				this.VisionFetterSuitItem.SetUiActive(false);
			}
			this.DescLayout(data2.VisionDetailInfoComponentData);
			this.RefreshGetWayPanel(data2.GetWayData);
			this.RefreshLimitTimePanel(data2.LimitTimeTxt);
			this.RefreshEquipPanel(data2);
			bool canStack = data2.CanStack;
			bool flag = canStack && data2.SelectedCount > 0;
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetUIActive(canStack);
			}
			if (text != null && canStack)
			{
				if (flag)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(data2.SelectedCount);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(data2.StackCount);
					string item = defaultInterpolatedStringHandler.ToStringAndClear();
					LguiUtil.Instance.SetLocalTextNew(text, "PhantomStack_AmountPickedTips", new <>z__ReadOnlySingleElementList<object>(item));
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, "PhantomStack_AmountTips", new <>z__ReadOnlySingleElementList<object>(data2.StackCount));
				}
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		};
		this.Data = tipsVisionData;
		ItemTipsModel.Instance.SetCurrentItemTipsData(tipsVisionData);
		if (base.InAsyncLoading())
		{
			this.OperationMap["Refresh"] = action;
			return;
		}
		action();
	}

	// Token: 0x06008F38 RID: 36664 RVA: 0x002B14B4 File Offset: 0x002AF6B4
	private ILayoutItem<global::VisionDetailDescItem> CreateInfoItem(object data, UUIItem uiItem, int index)
	{
		global::VisionDetailDescItem descItem = new global::VisionDetailDescItem(uiItem);
		descItem.Init().ContinueWith(delegate()
		{
			descItem.Update((VisionDetailDesc)data);
			descItem.SetActive(true);
		});
		return new LayoutItem<global::VisionDetailDescItem>
		{
			Key = index,
			Value = descItem
		};
	}

	// Token: 0x06008F39 RID: 36665 RVA: 0x002B1514 File Offset: 0x002AF714
	private ILayoutItem<TipsAttributeItem> CreateAttributeItem(object data, UUIItem uiItem, int index)
	{
		TipsAttributeItem value = new TipsAttributeItem(uiItem, (ITipsAttributeItemData)data);
		return new LayoutItem<TipsAttributeItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x06008F3A RID: 36666 RVA: 0x002B1548 File Offset: 0x002AF748
	private void DescLayout(VisionDetailInfoComponentData data)
	{
		this.Layout.RebuildLayoutByDataNew<VisionDetailDesc>(data.DescData, null);
	}

	// Token: 0x06008F3B RID: 36667 RVA: 0x002B156F File Offset: 0x002AF76F
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		base.GetItem(5).SetUIActive(getWayData != null && getWayData.Length != 0);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x06008F3C RID: 36668 RVA: 0x002B1597 File Offset: 0x002AF797
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(6).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(7).ShowTextNew(limitTimeTxt);
		}
	}

	// Token: 0x06008F3D RID: 36669 RVA: 0x002B15C0 File Offset: 0x002AF7C0
	private unsafe void RefreshEquipPanel(TipsVisionData data)
	{
		int? equippedId = data.EquippedId;
		bool isEquip = data.IsEquip;
		RoleDataBase roleDataBase = null;
		if (equippedId != null)
		{
			roleDataBase = RoleModel.Instance.GetRoleDataById(equippedId.Value, true);
			if (roleDataBase == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ItemHint;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "找不到装备角色但是认为被装备中";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", equippedId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("visionId", data.IncId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("visionConfigId", data.ConfigId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				base.GetItem(8).SetUIActive(false);
				return;
			}
		}
		base.GetItem(8).SetUIActive(isEquip);
		if (roleDataBase == null)
		{
			return;
		}
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleDataBase.GetRoleSkinId());
		if (isEquip && roleSkinData != null)
		{
			base.SetRoleSkinIcon(roleSkinData.GetRoleSkinConfig().RoleHeadIcon, base.GetTexture(9), roleSkinData.GetItemId(), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "VisionEquipping", new <>z__ReadOnlySingleElementList<object>(roleDataBase.GetName(null)));
		}
	}

	// Token: 0x06008F3E RID: 36670 RVA: 0x002B1718 File Offset: 0x002AF918
	public override void SetLockButtonShow(bool isShow)
	{
		Action action = delegate()
		{
			this.GetItem(2).SetUIActive(isShow);
		};
		if (base.InAsyncLoading())
		{
			this.OperationMap["SetLockButtonShow"] = action;
			return;
		}
		action();
	}

	// Token: 0x040055AE RID: 21934
	[Nullable(2)]
	private TipsVisionData Data;

	// Token: 0x040055AF RID: 21935
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x040055B0 RID: 21936
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsAttributeItem> TipsAttributePanel;

	// Token: 0x040055B1 RID: 21937
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<global::VisionDetailDescItem> Layout;

	// Token: 0x040055B2 RID: 21938
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x040055B3 RID: 21939
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02006FF3 RID: 28659
	[NullableContext(0)]
	private class ETipsVisionNode
	{
		// Token: 0x04024905 RID: 149765
		public const int CostText = 0;

		// Token: 0x04024906 RID: 149766
		public const int TxtUpgrade = 1;

		// Token: 0x04024907 RID: 149767
		public const int BtnLock = 2;

		// Token: 0x04024908 RID: 149768
		public const int PanelProperty = 3;

		// Token: 0x04024909 RID: 149769
		public const int PanelPropertyItem = 4;

		// Token: 0x0402490A RID: 149770
		public const int PanelPath = 5;

		// Token: 0x0402490B RID: 149771
		public const int PanelLimitTime = 6;

		// Token: 0x0402490C RID: 149772
		public const int TxtLimitTime = 7;

		// Token: 0x0402490D RID: 149773
		public const int PanelEquip = 8;

		// Token: 0x0402490E RID: 149774
		public const int TextureEquipIcon = 9;

		// Token: 0x0402490F RID: 149775
		public const int TxtEquip = 10;

		// Token: 0x04024910 RID: 149776
		public const int SuitElementItem = 11;

		// Token: 0x04024911 RID: 149777
		public const int DetailVerticalScroller = 12;

		// Token: 0x04024912 RID: 149778
		public const int PnlEchoStack = 13;

		// Token: 0x04024913 RID: 149779
		public const int TextNum = 14;
	}
}
