using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.HonamiPanel
{
	// Token: 0x0200374A RID: 14154
	public class HonamiScanMachinePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D0D RID: 150797 RVA: 0x00A6786D File Offset: 0x00A65A6D
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D0E RID: 150798 RVA: 0x00A67874 File Offset: 0x00A65A74
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
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06024D0F RID: 150799 RVA: 0x00A678F0 File Offset: 0x00A65AF0
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				HonamiScanMarkItem honamiScanMarkItem = param[0] as HonamiScanMarkItem;
				if (honamiScanMarkItem != null)
				{
					this.LayoutContext.MarkItem = honamiScanMarkItem;
					this.UpdateConfirmButtonEnableClickByTeleportState();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					UUIText text = base.GetText(4);
					if (text != null)
					{
						text.ShowTextNew(honamiScanMarkItem.GetLocaleDesc());
					}
					base.UpdateMultiMap();
					base.UpdateTopRightIconByTeleportState();
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext == null)
					{
						return;
					}
					layoutContext.SetConfirmBtnActive(!flag);
				}
			}
		}

		// Token: 0x06024D10 RID: 150800 RVA: 0x00A67990 File Offset: 0x00A65B90
		private void UpdateConfirmButtonEnableClickByTeleportState()
		{
			HonamiScanMarkItem honamiScanMarkItem = this.LayoutContext.MarkItem as HonamiScanMarkItem;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnEnableClick(honamiScanMarkItem == null || !honamiScanMarkItem.IsLocked);
		}

		// Token: 0x06024D11 RID: 150801 RVA: 0x00A679CD File Offset: 0x00A65BCD
		protected override void HandleTeleportAndTrack()
		{
			if (this.HandleTeleport())
			{
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x06024D12 RID: 150802 RVA: 0x00A679E0 File Offset: 0x00A65BE0
		protected unsafe override bool HandleTeleport()
		{
			HonamiScanMarkItem honamiScanMarkItem = this.LayoutContext.MarkItem as HonamiScanMarkItem;
			if (honamiScanMarkItem == null || honamiScanMarkItem.IsLocked)
			{
				return false;
			}
			HonamiStoryConfig instance = HonamiStoryConfig.Instance;
			HonamiStoryScanMachine? honamiStoryScanMachine = (instance != null) ? instance.GetScanMachineById((honamiScanMarkItem != null) ? honamiScanMarkItem.MarkConfig.Value.EntityConfigId : 0) : null;
			if (honamiStoryScanMachine == null)
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "[地图系统]->传送失败,找不到传送配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markId", honamiScanMarkItem.MarkId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsTracked", honamiScanMarkItem.IsTracked);
				MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ELogAuthor author2 = ELogAuthor.LYX;
			string message2 = "[地图系统]->传送";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("markId", honamiScanMarkItem.MarkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("IsTracked", honamiScanMarkItem.IsTracked);
			MapLogger.Debug(author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			HonamiStoryController.Instance.SetHonamiStoryLoadingInfoByTimingOnly(EHonamiStoryLoadingTimingType.MapPointTransfer);
			WorldMapController.Instance.TryTeleportByEntityId(honamiStoryScanMachine.Value.InstEntityTeleportId, null);
			return true;
		}

		// Token: 0x0200949F RID: 38047
		public static class EComponents
		{
			// Token: 0x0402E702 RID: 190210
			public const int HonamiScanMachinePanel = 0;
		}
	}
}
