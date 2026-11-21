using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark.Misc;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020036F8 RID: 14072
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiLayoutA : WorldMapSecondaryUi
	{
		// Token: 0x06024A20 RID: 150048 RVA: 0x00A57E10 File Offset: 0x00A56010
		protected unsafe override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = WorldMapDefine.SecondaryUiPanelComponentsRegisterInfoA;
			int num = 3;
			List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
			Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Delegate>(15, new Action(this.OnDetailBtnClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(18, new Action(this.OnStripBtnClick));
			num2++;
			*span[num2] = new ValueTuple<int, Delegate>(39, new Action(this.OnDelBtnClick));
			this.BtnBindInfo = list;
		}

		// Token: 0x06024A21 RID: 150049 RVA: 0x00A57EB4 File Offset: 0x00A560B4
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUiLayoutA.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUiLayoutA.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024A22 RID: 150050 RVA: 0x00A57EF8 File Offset: 0x00A560F8
		protected override void OnStart()
		{
			this.RootItem.SetRaycastTarget(false);
			this.UpdateTopRightIconHandle = new Action(this.UpdateTopRightIconActive);
			EventSystem.Instance.Add(EEventName.OnMarkTopRightIconUpdate, this.UpdateTopRightIconHandle);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(55);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.OnLateUpdate.Bind(delegate(float _)
			{
				this.RefreshScrollArrow();
			});
		}

		// Token: 0x06024A23 RID: 150051 RVA: 0x00A57F5C File Offset: 0x00A5615C
		private void InitContext()
		{
			this.LayoutContext = new WorldMapSecondaryUiContext
			{
				SetSpriteByPathAction = new TSetSpriteByPathAction(this.SetSpriteByPath),
				Icon = base.GetSprite(0),
				Title = base.GetText(1),
				AreaText = base.GetText(3),
				AreaIconItem = base.GetItem(22),
				DescriptionText = base.GetText(4)
			};
			if (this.ConfirmButton != null)
			{
				this.LayoutContext.SetConfirmBtnItem(this.ConfirmButton);
			}
			this.LayoutContext.TrackButtonItem = this.TrackBtn;
			this.LayoutContext.DownStateIcon = base.GetSprite(23);
			this.LayoutContext.PanelProgressItem = base.GetItem(14);
			this.LayoutContext.PanelListLayout = base.GetVerticalLayout(5);
			this.LayoutContext.DelButton = base.GetButton(39);
			this.LayoutContext.MapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			this.AutoPilotContext = new WorldMapSecondaryUiAutoPilotContext(this.LayoutContext);
			this.AutoPilotContext.SetCloseSecondaryUiFunction(new Action(base.Close));
			this.AutoPilotContext.SetDownStateBtnRoot(base.GetItem(27));
			this.AutoPilotContext.SetUiParent(base.GetItem(47));
			this.AutoPilotContext.RefreshPanelCallback = new Action<MarkItem>(this.RefreshPanel);
		}

		// Token: 0x06024A24 RID: 150052 RVA: 0x00A580B4 File Offset: 0x00A562B4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnMarkTopRightIconUpdate, this.UpdateTopRightIconHandle);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(55);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnLateUpdate.Unbind();
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.Destroy(null);
			}
			ButtonItem trackBtn = this.TrackBtn;
			if (trackBtn != null)
			{
				trackBtn.Destroy(null);
			}
			ButtonItem gotoBtn = this.GotoBtn;
			if (gotoBtn != null)
			{
				gotoBtn.Destroy(null);
			}
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.Destroy(null);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06024A25 RID: 150053 RVA: 0x00A58140 File Offset: 0x00A56340
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.GetItem(14).SetUIActive(true);
			base.GetItem(26).SetUIActive(false);
			base.GetVerticalLayout(5).RootUIComp.Get().SetUIActive(true);
			base.GetItem(25).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetVerticalLayout(16).RootUIComp.Get().SetUIActive(false);
			base.GetSprite(24).SetUIActive(false);
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive(false);
			}
			base.GetButton(39).RootUIComp.Get().SetUIActive(false);
			base.GetVerticalLayout(40).RootUIComp.Get().SetUIActive(false);
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext != null)
			{
				autoPilotContext.SetMap(this.Map);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext2 = this.AutoPilotContext;
			if (autoPilotContext2 != null)
			{
				autoPilotContext2.SetDownStateBtnRootActive(true);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext3 = this.AutoPilotContext;
			if (autoPilotContext3 != null)
			{
				autoPilotContext3.SetAutoPilotNavBtnActive(false);
			}
			WorldMapSecondaryUiAutoPilotContext autoPilotContext4 = this.AutoPilotContext;
			if (autoPilotContext4 != null)
			{
				autoPilotContext4.RefreshAutoPilotTrackBtnGroup(false);
			}
			UUIItem item = base.GetItem(53);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(54);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06024A26 RID: 150054 RVA: 0x00A582A0 File Offset: 0x00A564A0
		private void RefreshScrollArrow()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(55);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			bool flag = !scrollViewWithScrollbar.CheckContentUnderSize();
			float num = scrollViewWithScrollbar.Progress.Y;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			MarkItem markItem = (layoutContext != null) ? layoutContext.MarkItem : null;
			ValueTuple<EMarkType, int>? valueTuple = (markItem != null) ? new ValueTuple<EMarkType, int>?(new ValueTuple<EMarkType, int>(markItem.MarkType, markItem.MarkId)) : null;
			ValueTuple<EMarkType, int>? valueTuple2 = valueTuple;
			ValueTuple<EMarkType, int>? lastScrollMark = this.LastScrollMark;
			bool flag2 = valueTuple2 != null;
			bool flag3;
			if (flag2 != (lastScrollMark != null))
			{
				flag3 = true;
			}
			else if (!flag2)
			{
				flag3 = false;
			}
			else
			{
				ValueTuple<EMarkType, int> valueOrDefault = valueTuple2.GetValueOrDefault();
				ValueTuple<EMarkType, int> valueOrDefault2 = lastScrollMark.GetValueOrDefault();
				flag3 = (valueOrDefault.Item1 != valueOrDefault2.Item1 || valueOrDefault.Item2 != valueOrDefault2.Item2);
			}
			if (flag3)
			{
				this.LastScrollMark = valueTuple;
				this.LastScrollProgress = 0f;
				this.LastContentHeight = -1f;
			}
			AUIBaseActor content = scrollViewWithScrollbar.GetContent();
			float? num2;
			if (content == null)
			{
				num2 = null;
			}
			else
			{
				UUIItem uiitem = content.GetUIItem();
				num2 = ((uiitem != null) ? new float?(uiitem.GetHeight()) : null);
			}
			float? num3 = num2;
			float valueOrDefault3 = num3.GetValueOrDefault();
			if (Math.Abs(valueOrDefault3 - this.LastContentHeight) > 0.0001f)
			{
				this.LastContentHeight = valueOrDefault3;
				scrollViewWithScrollbar.ScrollToEnd();
				scrollViewWithScrollbar.SetScrollProgress(this.LastScrollProgress);
				num = this.LastScrollProgress;
			}
			if (flag)
			{
				this.LastScrollProgress = Math.Clamp(num, 0f, 1f);
			}
			UUIItem item = base.GetItem(53);
			if (item != null)
			{
				item.SetUIActive(flag && num > 0.001f);
			}
			UUIItem item2 = base.GetItem(54);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag && num < 0.999f);
		}

		// Token: 0x06024A27 RID: 150055 RVA: 0x00A5845C File Offset: 0x00A5665C
		protected bool UpdateQuickGoto()
		{
			bool flag = MarkUiUtils.IsShowGoto(this.LayoutContext.MarkItem);
			this.UpdateQuickGotoActive(flag);
			return flag;
		}

		// Token: 0x06024A28 RID: 150056 RVA: 0x00A58484 File Offset: 0x00A56684
		protected void UpdateQuickGotoActive(bool showGoto)
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			base.GetItem(32).SetUIActive(showGoto);
			if (!showGoto)
			{
				this.UpdateHidePlayMapTipPanel();
				return;
			}
			UUISelectableComponent button = base.GetButton(29);
			bool allowTeleportByUi = TeleportModel.Instance.AllowTeleportByUi;
			bool flag = MarkUiUtils.FindNearbyValidGotoMark(this.Map, markItem) != null || this.IsFastReturnAvailable();
			button.SetSelfInteractive(allowTeleportByUi && flag);
			bool flag2 = markItem.IsMarkDisabled();
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive((!allowTeleportByUi || !flag || flag2) && !HonamiStoryUtil.CheckInHonamiStoryDungeon());
			}
			if (flag2)
			{
				this.UpdateHidePlayMapTipPanel();
				return;
			}
			MapTipsActivateTipPanel mapTipsActivateTipPanel2 = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel2 == null)
			{
				return;
			}
			mapTipsActivateTipPanel2.SetDistanceTips();
		}

		// Token: 0x06024A29 RID: 150057 RVA: 0x00A58533 File Offset: 0x00A56733
		protected virtual bool IsFastReturnAvailable()
		{
			return false;
		}

		// Token: 0x06024A2A RID: 150058 RVA: 0x00A58538 File Offset: 0x00A56738
		protected void UpdateHidePlayMapTipPanel()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			bool flag = markItem.IsMarkDisabled();
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive(flag);
			}
			if (flag)
			{
				MapTipsActivateTipPanel mapTipsActivateTipPanel2 = this.MapTipsActivateTipPanel;
				if (mapTipsActivateTipPanel2 == null)
				{
					return;
				}
				mapTipsActivateTipPanel2.SetHideTip(markItem.GetMarkHideReason());
			}
		}

		// Token: 0x06024A2B RID: 150059 RVA: 0x00A58584 File Offset: 0x00A56784
		protected virtual void UpdateEnableFastMoveLayout()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			bool flag = MapModel.Instance.GetMarkExtraShowState(markItem.MarkId).ShowFlag != MapMarkShowFlag.ShowDisable;
			bool flag2 = configMarkItem == null || !configMarkItem.IsLocked;
			MapMark? mapMark;
			bool flag3 = configMarkItem != null && ((configMarkItem.MarkConfig != null) ? new int?(mapMark.GetValueOrDefault().EnableQuickTransfer) : null).GetValueOrDefault() == 1;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				layoutContext.SetConfirmBtnActive(flag3 && flag2);
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetEnableClick(flag2);
			}
			this.UpdateQuickGotoActive(!flag3 || !flag2);
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markItem.MarkId);
			if (configMark != null && configMark.Value.IsDisableBtnGoto)
			{
				base.GetItem(27).SetUIActive(false);
			}
			if (!flag)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
				this.UpdateTopRightIcon(true, resourcePath);
				return;
			}
			this.UpdateTopRightIconActive();
		}

		// Token: 0x06024A2C RID: 150060 RVA: 0x00A586B2 File Offset: 0x00A568B2
		protected void UpdateMarkItemRelativeLayout()
		{
			this.UpdateMultiMap();
			this.UpdateTopRightIconActive();
		}

		// Token: 0x06024A2D RID: 150061 RVA: 0x00A586C0 File Offset: 0x00A568C0
		protected void UpdateMultiMap()
		{
			bool flag = this.LayoutContext.MarkItem.ShowSecondaryUiMultiMapIcon();
			base.GetSprite(23).SetUIActive(flag);
			if (flag)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkMultiMapSelect");
				this.SetSpriteByPath(resourcePath, base.GetSprite(23), false, null, null);
			}
		}

		// Token: 0x06024A2E RID: 150062 RVA: 0x00A5871C File Offset: 0x00A5691C
		protected void UpdateTopRightIconActive()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			if (markItem == null)
			{
				return;
			}
			bool showTopRightIcon = markItem.ShowTopRightIcon;
			string topRightIconPath = markItem.TopRightIconPath;
			this.UpdateTopRightIcon(showTopRightIcon, topRightIconPath);
		}

		// Token: 0x06024A2F RID: 150063 RVA: 0x00A58750 File Offset: 0x00A56950
		protected void UpdateTopRightIconByTeleportState()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			if (!MapModel.Instance.IsMarkDisable(markItem.MarkId, markItem.IsMarkDisabled()))
			{
				this.UpdateTopRightIcon(false, null);
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
			this.UpdateTopRightIcon(true, resourcePath);
		}

		// Token: 0x06024A30 RID: 150064 RVA: 0x00A587A8 File Offset: 0x00A569A8
		protected void UpdateTopRightIcon(bool active, string iconPath = null)
		{
			base.GetSprite(24).SetUIActive(active);
			if (active && !StringUtils.IsEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, base.GetSprite(24), false, null, null);
			}
		}

		// Token: 0x06024A31 RID: 150065 RVA: 0x00A587E8 File Offset: 0x00A569E8
		protected void UpdateRightDownIconActive()
		{
			this.UpdateMultiMapIconActive();
		}

		// Token: 0x06024A32 RID: 150066 RVA: 0x00A587F0 File Offset: 0x00A569F0
		protected void UpdateMultiMapIconActive()
		{
			bool flag = this.LayoutContext.MarkItem.ShowSecondaryUiMultiMapIcon();
			if (flag)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkMultiMapSelect");
				this.UpdateDownStateIcon(flag, resourcePath);
				return;
			}
			this.UpdateDownStateIcon(flag, null);
		}

		// Token: 0x06024A33 RID: 150067 RVA: 0x00A58834 File Offset: 0x00A56A34
		protected void UpdateDownStateIcon(bool active, string iconPath = null)
		{
			base.GetSprite(23).SetUIActive(active);
			if (active && !StringUtils.IsEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, base.GetSprite(23), false, null, null);
			}
		}

		// Token: 0x06024A34 RID: 150068 RVA: 0x00A58874 File Offset: 0x00A56A74
		protected bool UpdateDeliveryPropLayout()
		{
			MapMark? markConfig = (this.LayoutContext.MarkItem as ConfigMarkItem).MarkConfig;
			List<TItem> list = null;
			if (markConfig.Value.DeliveryPropLength > 0)
			{
				list = new List<TItem>();
				for (int i = 0; i < markConfig.Value.DeliveryPropLength; i++)
				{
					DicIntInt? dicIntInt = markConfig.Value.DeliveryProp(i);
					TItem item = new TItem
					{
						ItemData = new InventoryDefine.GetItemData(dicIntInt.Value.Key, 0),
						Count = dicIntInt.Value.Value
					};
					list.Add(item);
				}
			}
			if (((list != null) ? list.Count : 0) > 0)
			{
				this.UpdateRewardLayoutByList(list, "Mark_Submit_Material_Text");
				return true;
			}
			base.GetVerticalLayout(40).RootUIComp.Get().SetUIActive(false);
			return false;
		}

		// Token: 0x06024A35 RID: 150069 RVA: 0x00A58960 File Offset: 0x00A56B60
		[NullableContext(1)]
		public void UpdateRewardLayout(int dropId, string titleKey)
		{
			List<TItem> itemListByDropId = this.GetItemListByDropId(dropId);
			this.UpdateRewardLayoutByList(itemListByDropId, titleKey);
		}

		// Token: 0x06024A36 RID: 150070 RVA: 0x00A58980 File Offset: 0x00A56B80
		[NullableContext(1)]
		public List<TItem> GetItemListByDropId(int dropId)
		{
			List<TItem> list = new List<TItem>();
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId);
			if (dropPackage != null && dropPackage.GetValueOrDefault().DropPreviewLength > 0)
			{
				for (int i = 0; i < dropPackage.Value.DropPreviewLength; i++)
				{
					DicIntInt? dicIntInt = dropPackage.Value.DropPreview(i);
					list.Add(new TItem
					{
						ItemData = new InventoryDefine.GetItemData(dicIntInt.Value.Key, 0),
						Count = dicIntInt.Value.Value
					});
				}
			}
			return list;
		}

		// Token: 0x06024A37 RID: 150071 RVA: 0x00A58A30 File Offset: 0x00A56C30
		[NullableContext(1)]
		public void UpdateRewardLayoutByList(List<TItem> list, string titleKey)
		{
			if (list.Count == 0)
			{
				return;
			}
			base.GetVerticalLayout(40).RootUIComp.Get().SetUIActive(true);
			this.DeliveryPropView.SetTitleNewTxt(titleKey);
			this.DeliveryPropView.Refresh(list);
		}

		// Token: 0x06024A38 RID: 150072 RVA: 0x00A58A79 File Offset: 0x00A56C79
		protected virtual void OnConfirmBtnClick(int index)
		{
			this.HandleTeleportAndTrack();
		}

		// Token: 0x06024A39 RID: 150073 RVA: 0x00A58A81 File Offset: 0x00A56C81
		protected virtual void OnTrackBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x06024A3A RID: 150074 RVA: 0x00A58A89 File Offset: 0x00A56C89
		protected virtual void OnGotoBtnClick(int index)
		{
			this.HandleQuickGoto();
		}

		// Token: 0x06024A3B RID: 150075 RVA: 0x00A58A91 File Offset: 0x00A56C91
		protected virtual void OnDetailBtnClick()
		{
		}

		// Token: 0x06024A3C RID: 150076 RVA: 0x00A58A93 File Offset: 0x00A56C93
		protected virtual void OnStripBtnClick()
		{
		}

		// Token: 0x06024A3D RID: 150077 RVA: 0x00A58A95 File Offset: 0x00A56C95
		protected virtual void OnDelBtnClick()
		{
		}

		// Token: 0x06024A3E RID: 150078 RVA: 0x00A58A97 File Offset: 0x00A56C97
		protected virtual void HandleTeleportAndTrack()
		{
			if (this.HandleTeleport())
			{
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x06024A3F RID: 150079 RVA: 0x00A58AA8 File Offset: 0x00A56CA8
		protected virtual void HandleFastMoveAndTrack()
		{
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			bool flag = configMarkItem == null || !configMarkItem.IsLocked;
			MapMark? mapMark;
			bool flag2 = configMarkItem != null && ((configMarkItem.MarkConfig != null) ? new int?(mapMark.GetValueOrDefault().EnableQuickTransfer) : null).GetValueOrDefault() == 1;
			if (flag && flag2)
			{
				this.HandleTeleportAndTrack();
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x06024A40 RID: 150080 RVA: 0x00A58B28 File Offset: 0x00A56D28
		protected unsafe virtual bool HandleTeleport()
		{
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			if (configMarkItem == null)
			{
				return false;
			}
			if (configMarkItem.IsLocked)
			{
				return false;
			}
			ELogAuthor author = ELogAuthor.LYX;
			string message = "[地图系统]->传送";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markId", configMarkItem.MarkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsTracked", configMarkItem.IsTracked);
			MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			MapMark? mapMark;
			if (configMarkItem.MarkConfig != null && mapMark.GetValueOrDefault().InstanceDungeonId != 0)
			{
				WorldMapController.Instance.TryEntityTeleport(configMarkItem.MarkConfigId, null);
			}
			else
			{
				WorldMapController.Instance.TryTeleport(configMarkItem.MarkConfigId, null);
			}
			return true;
		}

		// Token: 0x06024A41 RID: 150081 RVA: 0x00A58C00 File Offset: 0x00A56E00
		protected unsafe virtual void HandleTrack()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			if (markItem == null)
			{
				return;
			}
			base.CheckAndShowCrossMapTips(markItem);
			ELogAuthor author = ELogAuthor.LRX;
			string message = "[地图系统]->追踪";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("markId", markItem.MarkId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsTracked", markItem.IsTracked);
			MapLogger.Debug(author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
			{
				MarkType = markItem.MarkType,
				MarkId = markItem.MarkId,
				Track = !markItem.IsTracked
			}, null);
			base.Close();
		}

		// Token: 0x06024A42 RID: 150082 RVA: 0x00A58CC4 File Offset: 0x00A56EC4
		protected virtual void HandleQuickGoto()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			MarkItem markItem2 = MarkUiUtils.FindNearbyValidGotoMark(this.Map, markItem);
			if (markItem2 != null)
			{
				MarkUiUtils.QuickGotoTeleport(markItem, markItem2, new TOnTelSuccessCallBack(base.Close));
			}
		}

		// Token: 0x06024A43 RID: 150083 RVA: 0x00A58D00 File Offset: 0x00A56F00
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext == null)
			{
				return;
			}
			autoPilotContext.UpdateAutoPilotState();
		}

		// Token: 0x06024A44 RID: 150084 RVA: 0x00A58D12 File Offset: 0x00A56F12
		private void RefreshPanel(MarkItem markItem)
		{
			this.OnRefreshPanel();
		}

		// Token: 0x06024A45 RID: 150085 RVA: 0x00A58D1A File Offset: 0x00A56F1A
		protected virtual void OnRefreshPanel()
		{
			WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
		}

		// Token: 0x040145A6 RID: 83366
		private const float SCROLL_ARROW_TOLERANCE = 0.001f;

		// Token: 0x040145A7 RID: 83367
		private ButtonItem ConfirmButton;

		// Token: 0x040145A8 RID: 83368
		protected ButtonItem TrackBtn;

		// Token: 0x040145A9 RID: 83369
		protected ButtonItem GotoBtn;

		// Token: 0x040145AA RID: 83370
		protected MapTipsActivateTipPanel MapTipsActivateTipPanel;

		// Token: 0x040145AB RID: 83371
		protected MediumItemListPanel DeliveryPropView;

		// Token: 0x040145AC RID: 83372
		protected WorldMapSecondaryUiAutoPilotContext AutoPilotContext;

		// Token: 0x040145AD RID: 83373
		protected WorldMapSecondaryUiContext LayoutContext;

		// Token: 0x040145AE RID: 83374
		private Action UpdateTopRightIconHandle;

		// Token: 0x040145AF RID: 83375
		[Nullable(0)]
		private ValueTuple<EMarkType, int>? LastScrollMark;

		// Token: 0x040145B0 RID: 83376
		private float LastScrollProgress;

		// Token: 0x040145B1 RID: 83377
		private float LastContentHeight = -1f;
	}
}
