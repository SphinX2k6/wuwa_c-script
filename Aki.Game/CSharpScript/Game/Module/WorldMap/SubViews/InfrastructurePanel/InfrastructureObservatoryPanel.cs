using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InfrastructurePanel
{
	// Token: 0x02003747 RID: 14151
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrastructureObservatoryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024CF1 RID: 150769 RVA: 0x00A66A8A File Offset: 0x00A64C8A
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024CF2 RID: 150770 RVA: 0x00A66A94 File Offset: 0x00A64C94
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureObservatoryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureObservatoryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024CF3 RID: 150771 RVA: 0x00A66AD8 File Offset: 0x00A64CD8
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 == null)
			{
				return;
			}
			verticalLayout2.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06024CF4 RID: 150772 RVA: 0x00A66B54 File Offset: 0x00A64D54
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				InfrObservatoryMarkItem infrObservatoryMarkItem = param[0] as InfrObservatoryMarkItem;
				if (infrObservatoryMarkItem != null)
				{
					this.LayoutContext.MarkItem = infrObservatoryMarkItem;
					this.UpdateConfirmButtonEnableClickByTeleportState();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					UUIText text = base.GetText(4);
					if (text != null)
					{
						text.ShowTextNew(infrObservatoryMarkItem.GetLocaleDesc());
					}
					base.UpdateMultiMap();
					base.UpdateTopRightIconByTeleportState();
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext != null)
					{
						layoutContext.SetConfirmBtnActive(!flag);
					}
					this.RefreshGiftTip();
					GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> verticalLayout = this.VerticalLayout;
					if (verticalLayout == null)
					{
						return;
					}
					verticalLayout.RefreshByData(this.GetVerticalLayoutData(), null, false);
				}
			}
		}

		// Token: 0x06024CF5 RID: 150773 RVA: 0x00A66C14 File Offset: 0x00A64E14
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			InfrObservatoryMarkItem infrObservatoryMarkItem = this.LayoutContext.MarkItem as InfrObservatoryMarkItem;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnEnableClick(infrObservatoryMarkItem == null || !infrObservatoryMarkItem.IsLocked);
		}

		// Token: 0x06024CF6 RID: 150774 RVA: 0x00A66C54 File Offset: 0x00A64E54
		private void RefreshGiftTip()
		{
			int fireLevel = InfrastructureModel.Instance.FireLevel;
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			InfrLevel? infrLevel = (instance != null) ? instance.GetLevelConfigById(fireLevel) : null;
			if (infrLevel == null)
			{
				return;
			}
			InfrastructureConfig instance2 = InfrastructureConfig.Instance;
			int num = (instance2 != null) ? instance2.GetMaxLevel() : 0;
			InventoryModel instance3 = InventoryModel.Instance;
			InfrLevel value = infrLevel.Value;
			bool flag = true;
			foreach (DicIntInt dicIntInt in value.RequirementIter())
			{
				int? num2 = (instance3 != null) ? new int?(instance3.GetItemCountByConfigId(dicIntInt.Key, 0)) : null;
				int value2 = dicIntInt.Value;
				if (!(num2.GetValueOrDefault() >= value2 & num2 != null))
				{
					flag = false;
					break;
				}
			}
			if (fireLevel < num && InfrastructureModel.Instance.FireStatus == InfrStatusPb.InfrStatusProgress && flag)
			{
				UUIItem item = base.GetItem(25);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIText text = base.GetText(30);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew("Map_BuildObser_BuildAllowedTips");
			}
		}

		// Token: 0x06024CF7 RID: 150775 RVA: 0x00A66D84 File Offset: 0x00A64F84
		private unsafe List<IMapSubViewListItemData> GetVerticalLayoutData()
		{
			int fireLevel = InfrastructureModel.Instance.FireLevel;
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			int num = (instance != null) ? instance.GetMaxLevel() : 0;
			if (fireLevel < num)
			{
				return new List<IMapSubViewListItemData>();
			}
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(InfrastructureModel.Instance.FireLevelReachTime * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
			int num2 = 1;
			List<IMapSubViewListItemData> list = new List<IMapSubViewListItemData>(num2);
			CollectionsMarshal.SetCount<IMapSubViewListItemData>(list, num2);
			Span<IMapSubViewListItemData> span = CollectionsMarshal.AsSpan<IMapSubViewListItemData>(list);
			int index = 0;
			*span[index] = new MapSubViewListItemData
			{
				LeftTextId = "Build_CompleteTime",
				RightText = TimeUtil.Instance.DateFormat3(localDateTime),
				ShowBtnHelp = false,
				ShowIcon = false,
				ShowSprite = false,
				ShowScaleIcon = false
			};
			return list;
		}

		// Token: 0x040146B7 RID: 83639
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<MapVerticalLayoutItem, IMapSubViewListItemData> VerticalLayout;

		// Token: 0x02009497 RID: 38039
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6EE RID: 190190
			public const int InfrObservatoryPanel = 0;
		}
	}
}
