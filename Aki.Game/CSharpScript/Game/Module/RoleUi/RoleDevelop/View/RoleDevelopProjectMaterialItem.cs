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
	// Token: 0x02004D3F RID: 19775
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectMaterialItem : GridProxyAbstract<RoleDevelopProjectMaterialItemData>
	{
		// Token: 0x0603317B RID: 209275 RVA: 0x00BE7A08 File Offset: 0x00BE5C08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603317C RID: 209276 RVA: 0x00BE7B7C File Offset: 0x00BE5D7C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectMaterialItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectMaterialItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603317D RID: 209277 RVA: 0x00BE7BBF File Offset: 0x00BE5DBF
		public override void Refresh(RoleDevelopProjectMaterialItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshContent();
		}

		// Token: 0x0603317E RID: 209278 RVA: 0x00BE7BD0 File Offset: 0x00BE5DD0
		private void RefreshContent()
		{
			RoleDevelopProjectMaterialItemData itemData = this.ItemData;
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			RoleDevTypeManage? typeManageConfig = RoleDevConfig.Instance.GetTypeManageConfig((int)groupItem.Type);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), typeManageConfig.Value.TypeDescribe, Array.Empty<object>());
			List<RoleDevelopNeedItem> data = RoleDevelopUtil.SortItemsByQuality(new List<RoleDevelopNeedItem>(groupItem.Items));
			this.MaterialItemLayout.RefreshByData(data, null, false);
			this.RefreshWeeklyMaterialText(itemData);
			bool flag = RoleDevelopUtil.CheckIsItemsHaveUnknownMaterial(groupItem.Items);
			bool flag2 = RoleDevelopUtil.CheckIsAllNeedItemsEnough(groupItem.Items);
			base.GetItem(6).SetUIActive(flag2 && !flag);
			this.ButtonConfirm.SetUiActive(!flag);
			this.ButtonConfirm.SetLocalTextNew(flag ? "RoleProject_Access_None" : "RoleProject_Button03", Array.Empty<object>());
			this.ButtonConfirm.SetEnableClick(!flag);
			base.GetItem(5).SetUIActive(flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "RoleProject_Access_None", Array.Empty<object>());
			base.GetItem(8).SetUIActive(RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem));
			this.RefreshDoubleIcon();
		}

		// Token: 0x0603317F RID: 209279 RVA: 0x00BE7D00 File Offset: 0x00BE5F00
		private void RefreshWeeklyMaterialText(RoleDevelopProjectMaterialItemData data)
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

		// Token: 0x06033180 RID: 209280 RVA: 0x00BE7E80 File Offset: 0x00BE6080
		private void RefreshDoubleIcon()
		{
			RoleDevelopItemGroup groupItem = this.ItemData.GroupItem;
			if (groupItem.Items.TrueForAll((RoleDevelopNeedItem item) => RoleDevelopUtil.IsUnknownItem(item.ItemId)))
			{
				base.GetItem(9).SetUIActive(false);
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
			base.GetItem(9).SetUIActive(uiactive);
		}

		// Token: 0x06033181 RID: 209281 RVA: 0x00BE7F34 File Offset: 0x00BE6134
		public bool HasItem(int configId)
		{
			return this.ItemData != null && this.ItemData.GroupItem.Items.Exists((RoleDevelopNeedItem item) => item.ItemId == configId);
		}

		// Token: 0x06033182 RID: 209282 RVA: 0x00BE7F79 File Offset: 0x00BE6179
		public void RefreshSelf()
		{
			if (this.ItemData == null)
			{
				return;
			}
			this.RefreshContent();
		}

		// Token: 0x06033183 RID: 209283 RVA: 0x00BE7F8A File Offset: 0x00BE618A
		private RoleDevelopProjectMaterialListItem CreateMaterialItem()
		{
			return new RoleDevelopProjectMaterialListItem();
		}

		// Token: 0x06033184 RID: 209284 RVA: 0x00BE7F94 File Offset: 0x00BE6194
		private void OnClickJump(int value)
		{
			RoleDevelopProjectMaterialItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			RoleDevelopItemGroup groupItem = itemData.GroupItem;
			itemData.JumpCallback(groupItem);
			if (itemData.LogRoleId != null && itemData.LogMainPage != null && itemData.LogSubPage != null)
			{
				ERoleDevelopLogItemState value2 = ERoleDevelopLogItemState.Normal;
				if (!RoleDevelopUtil.CheckIsAllNeedItemsEnough(groupItem.Items))
				{
					value2 = (RoleDevelopModel.Instance.IsItemGroupCanBeSupplemented(groupItem) ? ERoleDevelopLogItemState.CanComplement : ERoleDevelopLogItemState.NotComplement);
				}
				RoleController.Instance.LogRoleDevelopClick(itemData.LogRoleId.Value, itemData.LogMainPage.Value, itemData.LogSubPage.Value, new ERoleDevelopLogItemState?(value2));
			}
		}

		// Token: 0x0401B299 RID: 111257
		private RoleDevelopProjectMaterialItemData ItemData;

		// Token: 0x0401B29A RID: 111258
		private ButtonItem ButtonConfirm;

		// Token: 0x0401B29B RID: 111259
		private GenericLayout<RoleDevelopProjectMaterialListItem, RoleDevelopNeedItem> MaterialItemLayout;

		// Token: 0x0200AE9E RID: 44702
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035062 RID: 217186
			public const int TxtTitle = 0;

			// Token: 0x04035063 RID: 217187
			public const int TxtMatLimit = 1;

			// Token: 0x04035064 RID: 217188
			public const int HorizontalLayoutContent = 2;

			// Token: 0x04035065 RID: 217189
			public const int ItemBaseB = 3;

			// Token: 0x04035066 RID: 217190
			public const int ItemBtnConfirm = 4;

			// Token: 0x04035067 RID: 217191
			public const int ItemPanelNotObtained = 5;

			// Token: 0x04035068 RID: 217192
			public const int ItemFinishTag = 6;

			// Token: 0x04035069 RID: 217193
			public const int TextNoMaterial = 7;

			// Token: 0x0403506A RID: 217194
			public const int ItemSupplement = 8;

			// Token: 0x0403506B RID: 217195
			public const int ItemDouble = 9;
		}
	}
}
