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
	// Token: 0x02004819 RID: 18457
	public class HonamiScanMachinePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x0603053D RID: 197949 RVA: 0x00B377B1 File Offset: 0x00B359B1
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x0603053E RID: 197950 RVA: 0x00B377B8 File Offset: 0x00B359B8
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

		// Token: 0x0603053F RID: 197951 RVA: 0x00B37834 File Offset: 0x00B35A34
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

		// Token: 0x06030540 RID: 197952 RVA: 0x00B378D4 File Offset: 0x00B35AD4
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

		// Token: 0x06030541 RID: 197953 RVA: 0x00B37911 File Offset: 0x00B35B11
		protected override void HandleTeleportAndTrack()
		{
			if (this.HandleTeleport())
			{
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x06030542 RID: 197954 RVA: 0x00B37924 File Offset: 0x00B35B24
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

		// Token: 0x0200AAF0 RID: 43760
		public static class EComponents
		{
			// Token: 0x04033F82 RID: 212866
			public const int HonamiScanMachinePanel = 0;
		}
	}
}
