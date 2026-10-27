using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D3A RID: 19770
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopOverviewMaterialItem : GridProxyAbstract<RoleDevelopOverviewMaterialItemData>
	{
		// Token: 0x0603313E RID: 209214 RVA: 0x00BE6894 File Offset: 0x00BE4A94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603313F RID: 209215 RVA: 0x00BE69E8 File Offset: 0x00BE4BE8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopOverviewMaterialItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopOverviewMaterialItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033140 RID: 209216 RVA: 0x00BE6A2B File Offset: 0x00BE4C2B
		public override void Refresh(RoleDevelopOverviewMaterialItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshContent();
		}

		// Token: 0x06033141 RID: 209217 RVA: 0x00BE6A3C File Offset: 0x00BE4C3C
		private void RefreshContent()
		{
			RoleDevelopOverviewMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			RoleDevTypeManage? typeManageConfig = RoleDevConfig.Instance.GetTypeManageConfig((int)groupItem.Type);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), typeManageConfig.Value.TypeDescribe, Array.Empty<object>());
			List<RoleDevelopNeedItem> data = RoleDevelopUtil.SortItemsByQuality(new List<RoleDevelopNeedItem>(groupItem.Items));
			this.MaterialItemLayout.RefreshByData(data, null, false);
			this.RefreshWeeklyMaterialText(itemData);
			bool flag = RoleDevelopUtil.CheckIsItemsHaveUnknownMaterial(groupItem.Items);
			this.ButtonConfirm.SetUiActive(!flag);
			this.ButtonConfirm.SetLocalTextNew(flag ? "RoleProject_Access_None" : "RoleProject_Button03", Array.Empty<object>());
			this.ButtonConfirm.SetEnableClick(!flag);
			base.GetItem(7).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "RoleProject_Access_None", Array.Empty<object>());
			base.GetItem(6).SetUIActive(RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem));
			this.RefreshDoubleIcon();
		}

		// Token: 0x06033142 RID: 209218 RVA: 0x00BE6B48 File Offset: 0x00BE4D48
		private void RefreshWeeklyMaterialText(RoleDevelopOverviewMaterialItemData data)
		{
			RoleDevelopItemGroup groupItem = data.GroupItem;
			RoleDevCulProjectConfig? roleDevCulProjectConfig;
			int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
			bool flag = false;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in groupItem.Items)
			{
				int itemId = roleDevelopNeedItem.ItemId;
				int? num2 = num;
				if (!(itemId == num2.GetValueOrDefault() & num2 != null))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null && itemJumpGroupConfig.GetValueOrDefault().ItemType == 5)
					{
						flag = true;
						break;
					}
				}
			}
			UUIText text = base.GetText(1);
			if (flag)
			{
				text.SetUIActive(true);
				int num3 = 1;
				ExchangeShared? exchangeShareConfig = ExchangeRewardConfig.Instance.GetExchangeShareConfig(new int?(num3));
				int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(num3);
				int maxCount = exchangeShareConfig.Value.MaxCount;
				int value = maxCount - exchangeRewardShareCount;
				LguiUtil instance = LguiUtil.Instance;
				UUIText uiText = text;
				string textTableId = "ReceivedCount";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(maxCount);
				instance.SetLocalText(uiText, textTableId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x06033143 RID: 209219 RVA: 0x00BE6CC8 File Offset: 0x00BE4EC8
		private void RefreshDoubleIcon()
		{
			RoleDevelopItemGroup groupItem = this.ItemData.GroupItem;
			if (groupItem.Items.TrueForAll((RoleDevelopNeedItem item) => RoleDevelopUtil.IsUnknownItem(item.ItemId)))
			{
				base.GetItem(5).SetUIActive(false);
				return;
			}
			List<EDungeonType> dungeonTypesByItemDetection = RoleDevelopUtil.GetDungeonTypesByItemDetection(groupItem.Items);
			bool uiactive = false;
			using (List<EDungeonType>.Enumerator enumerator = dungeonTypesByItemDetection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleDevelopUtil.IsDungeonShowDouble(enumerator.Current))
					{
						uiactive = true;
						break;
					}
				}
			}
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x06033144 RID: 209220 RVA: 0x00BE6D78 File Offset: 0x00BE4F78
		public bool HasItem(int configId)
		{
			return this.ItemData != null && this.ItemData.GroupItem.Items.Exists((RoleDevelopNeedItem item) => item.ItemId == configId);
		}

		// Token: 0x06033145 RID: 209221 RVA: 0x00BE6DBD File Offset: 0x00BE4FBD
		public void RefreshSelf()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshContent();
		}

		// Token: 0x06033146 RID: 209222 RVA: 0x00BE6DCE File Offset: 0x00BE4FCE
		private RoleDevelopProjectMaterialListItem CreateMaterialItem()
		{
			return new RoleDevelopProjectMaterialListItem();
		}

		// Token: 0x06033147 RID: 209223 RVA: 0x00BE6DD8 File Offset: 0x00BE4FD8
		private void OnClickJump(int value)
		{
			RoleDevelopOverviewMaterialItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			itemData.JumpCallback(groupItem);
		}

		// Token: 0x0401B28A RID: 111242
		private RoleDevelopOverviewMaterialItemData ItemData;

		// Token: 0x0401B28B RID: 111243
		private ButtonItem ButtonConfirm;

		// Token: 0x0401B28C RID: 111244
		private GenericLayout<RoleDevelopProjectMaterialListItem, RoleDevelopNeedItem> MaterialItemLayout;

		// Token: 0x0200AE97 RID: 44695
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x0403503D RID: 217149
			public const int TxtTitle = 0;

			// Token: 0x0403503E RID: 217150
			public const int TxtMatLimit = 1;

			// Token: 0x0403503F RID: 217151
			public const int HorizontalLayoutContent = 2;

			// Token: 0x04035040 RID: 217152
			public const int ItemBaseB = 3;

			// Token: 0x04035041 RID: 217153
			public const int ItemBtnConfirm = 4;

			// Token: 0x04035042 RID: 217154
			public const int ItemDouble = 5;

			// Token: 0x04035043 RID: 217155
			public const int ItemSupplement = 6;

			// Token: 0x04035044 RID: 217156
			public const int ItemPanelNotObtained = 7;

			// Token: 0x04035045 RID: 217157
			public const int TxtNotObtained = 8;
		}
	}
}
