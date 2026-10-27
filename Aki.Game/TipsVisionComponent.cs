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

// Token: 0x020018F6 RID: 6390
[NullableContext(1)]
[Nullable(0)]
public class TipsVisionComponent : TipsBaseSubComponent
{
	// Token: 0x0600BB48 RID: 47944 RVA: 0x002A69F4 File Offset: 0x002A4BF4
	public TipsVisionComponent(UUIItem rootUiItem) : base(rootUiItem)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_TipsVision", rootUiItem, false);
	}

	// Token: 0x0600BB49 RID: 47945 RVA: 0x002A6A0C File Offset: 0x002A4C0C
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

	// Token: 0x0600BB4A RID: 47946 RVA: 0x002A6C2C File Offset: 0x002A4E2C
	protected override UniTask OnBeforeStartAsync()
	{
		TipsVisionComponent.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TipsVisionComponent.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BB4B RID: 47947 RVA: 0x002A6C70 File Offset: 0x002A4E70
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		this.TipsLockButton = new TipsLockButton(item);
		this.TipsAttributePanel = new GenericLayoutNew<TipsAttributeItem>(base.GetVerticalLayout(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TipsAttributeItem>(this.CreateAttributeItem), null);
		this.Layout = new GenericLayoutNew<global::VisionDetailDescItem>(base.GetVerticalLayout(12), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<global::VisionDetailDescItem>(this.CreateInfoItem), null);
		UUIItem item2 = base.GetItem(5);
		this.TipsGetWayPanel = new TipsGetWayPanel(item2);
	}

	// Token: 0x0600BB4C RID: 47948 RVA: 0x002A6CE4 File Offset: 0x002A4EE4
	protected override void OnBeforeDestroy()
	{
		if (this.Data != null)
		{
			this.Data = null;
			ItemTipsModel.Instance.SetCurrentItemTipsData(null);
		}
	}

	// Token: 0x0600BB4D RID: 47949 RVA: 0x002A6D00 File Offset: 0x002A4F00
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

	// Token: 0x0600BB4E RID: 47950 RVA: 0x002A6D54 File Offset: 0x002A4F54
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

	// Token: 0x0600BB4F RID: 47951 RVA: 0x002A6DB4 File Offset: 0x002A4FB4
	private ILayoutItem<TipsAttributeItem> CreateAttributeItem(object data, UUIItem uiItem, int index)
	{
		TipsAttributeItem value = new TipsAttributeItem(uiItem, (ITipsAttributeItemData)data);
		return new LayoutItem<TipsAttributeItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600BB50 RID: 47952 RVA: 0x002A6DE8 File Offset: 0x002A4FE8
	private void DescLayout(VisionDetailInfoComponentData data)
	{
		this.Layout.RebuildLayoutByDataNew<VisionDetailDesc>(data.DescData, null);
	}

	// Token: 0x0600BB51 RID: 47953 RVA: 0x002A6E0F File Offset: 0x002A500F
	private void RefreshGetWayPanel(IGetWayItemData[] getWayData)
	{
		base.GetItem(5).SetUIActive(getWayData != null && getWayData.Length != 0);
		if (getWayData != null)
		{
			this.TipsGetWayPanel.Refresh(getWayData);
		}
	}

	// Token: 0x0600BB52 RID: 47954 RVA: 0x002A6E37 File Offset: 0x002A5037
	private void RefreshLimitTimePanel(string limitTimeTxt)
	{
		base.GetItem(6).SetUIActive(limitTimeTxt != null);
		if (!string.IsNullOrEmpty(limitTimeTxt))
		{
			base.GetText(7).ShowTextNew(limitTimeTxt);
		}
	}

	// Token: 0x0600BB53 RID: 47955 RVA: 0x002A6E60 File Offset: 0x002A5060
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

	// Token: 0x0600BB54 RID: 47956 RVA: 0x002A6FB8 File Offset: 0x002A51B8
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

	// Token: 0x04005503 RID: 21763
	[Nullable(2)]
	private TipsVisionData Data;

	// Token: 0x04005504 RID: 21764
	[Nullable(2)]
	private TipsLockButton TipsLockButton;

	// Token: 0x04005505 RID: 21765
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TipsAttributeItem> TipsAttributePanel;

	// Token: 0x04005506 RID: 21766
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<global::VisionDetailDescItem> Layout;

	// Token: 0x04005507 RID: 21767
	[Nullable(2)]
	private TipsGetWayPanel TipsGetWayPanel;

	// Token: 0x04005508 RID: 21768
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x02007E6C RID: 32364
	[NullableContext(0)]
	private class ETipsVisionNode
	{
		// Token: 0x040295D9 RID: 169433
		public const int CostText = 0;

		// Token: 0x040295DA RID: 169434
		public const int TxtUpgrade = 1;

		// Token: 0x040295DB RID: 169435
		public const int BtnLock = 2;

		// Token: 0x040295DC RID: 169436
		public const int PanelProperty = 3;

		// Token: 0x040295DD RID: 169437
		public const int PanelPropertyItem = 4;

		// Token: 0x040295DE RID: 169438
		public const int PanelPath = 5;

		// Token: 0x040295DF RID: 169439
		public const int PanelLimitTime = 6;

		// Token: 0x040295E0 RID: 169440
		public const int TxtLimitTime = 7;

		// Token: 0x040295E1 RID: 169441
		public const int PanelEquip = 8;

		// Token: 0x040295E2 RID: 169442
		public const int TextureEquipIcon = 9;

		// Token: 0x040295E3 RID: 169443
		public const int TxtEquip = 10;

		// Token: 0x040295E4 RID: 169444
		public const int SuitElementItem = 11;

		// Token: 0x040295E5 RID: 169445
		public const int DetailVerticalScroller = 12;

		// Token: 0x040295E6 RID: 169446
		public const int PnlEchoStack = 13;

		// Token: 0x040295E7 RID: 169447
		public const int TextNum = 14;
	}
}
