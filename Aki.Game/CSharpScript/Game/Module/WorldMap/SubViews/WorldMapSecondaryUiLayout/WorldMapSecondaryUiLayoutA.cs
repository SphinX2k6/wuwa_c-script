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
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
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
	// Token: 0x020047C7 RID: 18375
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiLayoutA : WorldMapSecondaryUi
	{
		// Token: 0x06030250 RID: 197200 RVA: 0x00B28004 File Offset: 0x00B26204
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

		// Token: 0x06030251 RID: 197201 RVA: 0x00B280A8 File Offset: 0x00B262A8
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapSecondaryUiLayoutA.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapSecondaryUiLayoutA.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030252 RID: 197202 RVA: 0x00B280EC File Offset: 0x00B262EC
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

		// Token: 0x06030253 RID: 197203 RVA: 0x00B28150 File Offset: 0x00B26350
		private void InitContext()
		{
			this.LayoutContext = new WorldMapSecondaryUiContext();
			this.LayoutContext.SetSpriteByPathAction = new TSetSpriteByPathAction(this.SetSpriteByPath);
			this.LayoutContext.Icon = base.GetSprite(0);
			this.LayoutContext.Title = base.GetText(1);
			this.LayoutContext.AreaText = base.GetText(3);
			this.LayoutContext.AreaIconItem = base.GetItem(22);
			this.LayoutContext.DescriptionText = base.GetText(4);
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

		// Token: 0x06030254 RID: 197204 RVA: 0x00B282C8 File Offset: 0x00B264C8
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

		// Token: 0x06030255 RID: 197205 RVA: 0x00B28354 File Offset: 0x00B26554
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

		// Token: 0x06030256 RID: 197206 RVA: 0x00B284B4 File Offset: 0x00B266B4
		private void RefreshScrollArrow()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(55);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			bool flag = !scrollViewWithScrollbar.CheckContentUnderSize();
			float y = scrollViewWithScrollbar.Progress.Y;
			UUIItem item = base.GetItem(53);
			if (item != null)
			{
				item.SetUIActive(flag && y > 0.001f);
			}
			UUIItem item2 = base.GetItem(54);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag && y < 0.999f);
		}

		// Token: 0x06030257 RID: 197207 RVA: 0x00B28528 File Offset: 0x00B26728
		protected bool UpdateQuickGoto()
		{
			bool flag = MarkUiUtils.IsShowGoto(this.LayoutContext.MarkItem);
			this.UpdateQuickGotoActive(flag);
			return flag;
		}

		// Token: 0x06030258 RID: 197208 RVA: 0x00B28550 File Offset: 0x00B26750
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
			bool isHide = markItem.MarkItemEntity.GamePlay.IsHide;
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive((!allowTeleportByUi || !flag || isHide) && !HonamiStoryUtil.CheckInHonamiStoryDungeon());
			}
			if (isHide)
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

		// Token: 0x06030259 RID: 197209 RVA: 0x00B2860C File Offset: 0x00B2680C
		protected virtual bool IsFastReturnAvailable()
		{
			return false;
		}

		// Token: 0x0603025A RID: 197210 RVA: 0x00B28610 File Offset: 0x00B26810
		protected void UpdateHidePlayMapTipPanel()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			bool isHide = markItem.MarkItemEntity.GamePlay.IsHide;
			MapTipsActivateTipPanel mapTipsActivateTipPanel = this.MapTipsActivateTipPanel;
			if (mapTipsActivateTipPanel != null)
			{
				mapTipsActivateTipPanel.SetUiActive(isHide);
			}
			if (isHide)
			{
				MarkCommonGamePlayStateComponent component = markItem.MarkItemEntity.GetComponent<MarkCommonGamePlayStateComponent>(EMapComponent.MarkCommonGamePlayState);
				int? num = (component != null) ? component.GetRelativeDungeonId() : null;
				int? num2 = (component != null) ? component.GetRelativeId() : null;
				if (component != null && num != null && num2 != null)
				{
					string hideTip = LevelPlayReportModel.Instance.GetLevelPlayHideReason(num.Value, num2.Value);
					MapTipsActivateTipPanel mapTipsActivateTipPanel2 = this.MapTipsActivateTipPanel;
					if (mapTipsActivateTipPanel2 == null)
					{
						return;
					}
					mapTipsActivateTipPanel2.SetHideTip(hideTip);
					return;
				}
				else
				{
					int valueOrDefault = markItem.MarkItemEntity.GetComponent<MarkEntityComponent>(EMapComponent.MarkEntity).EntityId.GetValueOrDefault();
					string hideTip = MapModel.Instance.GetMarkHideReason(markItem.MapId, valueOrDefault);
					MapTipsActivateTipPanel mapTipsActivateTipPanel3 = this.MapTipsActivateTipPanel;
					if (mapTipsActivateTipPanel3 == null)
					{
						return;
					}
					mapTipsActivateTipPanel3.SetHideTip(hideTip);
				}
			}
		}

		// Token: 0x0603025B RID: 197211 RVA: 0x00B28710 File Offset: 0x00B26910
		protected virtual void UpdateEnableFastMoveLayout()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			IMarkShowState markExtraShowState = MapModel.Instance.GetMarkExtraShowState(markItem.MarkId);
			bool flag = markExtraShowState == null || markExtraShowState.ShowFlag != MapMarkShowFlag.ShowDisable;
			bool flag2 = configMarkItem == null || !configMarkItem.IsLocked;
			bool flag3;
			if (configMarkItem == null)
			{
				flag3 = false;
			}
			else
			{
				ConfigMarkItem configMarkItem2 = configMarkItem;
				flag3 = (((configMarkItem2.MarkConfig != null) ? new int?(configMarkItem2.MarkConfig.GetValueOrDefault().EnableQuickTransfer) : null).GetValueOrDefault() == 1);
			}
			bool flag4 = flag3;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				layoutContext.SetConfirmBtnActive(flag4 && flag2);
			}
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetEnableClick(flag2);
			}
			this.UpdateQuickGotoActive(!flag4 || !flag2);
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

		// Token: 0x0603025C RID: 197212 RVA: 0x00B28848 File Offset: 0x00B26A48
		protected void UpdateMarkItemRelativeLayout()
		{
			this.UpdateMultiMap();
			this.UpdateTopRightIconActive();
		}

		// Token: 0x0603025D RID: 197213 RVA: 0x00B28858 File Offset: 0x00B26A58
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

		// Token: 0x0603025E RID: 197214 RVA: 0x00B288B4 File Offset: 0x00B26AB4
		protected void UpdateTopRightIconActive()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			if (markItem == null)
			{
				return;
			}
			bool active = markItem.MarkItemEntity.ViewLifeCircle.IsChildViewVisible(EMarkViewComponentType.TopRightIcon, false);
			string topRightIconPath = markItem.MarkItemEntity.Resource.TopRightIconPath;
			this.UpdateTopRightIcon(active, topRightIconPath);
		}

		// Token: 0x0603025F RID: 197215 RVA: 0x00B28900 File Offset: 0x00B26B00
		protected void UpdateTopRightIconByTeleportState()
		{
			if (!this.LayoutContext.MarkItem.MarkItemEntity.GamePlay.IsDisable)
			{
				this.UpdateTopRightIcon(false, null);
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MarkBlock");
			this.UpdateTopRightIcon(true, resourcePath);
		}

		// Token: 0x06030260 RID: 197216 RVA: 0x00B28950 File Offset: 0x00B26B50
		protected void UpdateTopRightIcon(bool active, string iconPath = null)
		{
			base.GetSprite(24).SetUIActive(active);
			if (active && !StringUtils.IsEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, base.GetSprite(24), false, null, null);
			}
		}

		// Token: 0x06030261 RID: 197217 RVA: 0x00B28990 File Offset: 0x00B26B90
		protected void UpdateRightDownIconActive()
		{
			this.UpdateMultiMapIconActive();
		}

		// Token: 0x06030262 RID: 197218 RVA: 0x00B28998 File Offset: 0x00B26B98
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

		// Token: 0x06030263 RID: 197219 RVA: 0x00B289DC File Offset: 0x00B26BDC
		protected void UpdateDownStateIcon(bool active, string iconPath = null)
		{
			base.GetSprite(23).SetUIActive(active);
			if (active && !StringUtils.IsEmpty(iconPath))
			{
				this.SetSpriteByPath(iconPath, base.GetSprite(23), false, null, null);
			}
		}

		// Token: 0x06030264 RID: 197220 RVA: 0x00B28A1C File Offset: 0x00B26C1C
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

		// Token: 0x06030265 RID: 197221 RVA: 0x00B28B08 File Offset: 0x00B26D08
		[NullableContext(1)]
		public void UpdateRewardLayout(int dropId, string titleKey)
		{
			List<TItem> itemListByDropId = this.GetItemListByDropId(dropId);
			this.UpdateRewardLayoutByList(itemListByDropId, titleKey);
		}

		// Token: 0x06030266 RID: 197222 RVA: 0x00B28B28 File Offset: 0x00B26D28
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

		// Token: 0x06030267 RID: 197223 RVA: 0x00B28BD8 File Offset: 0x00B26DD8
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

		// Token: 0x06030268 RID: 197224 RVA: 0x00B28C21 File Offset: 0x00B26E21
		protected virtual void OnConfirmBtnClick(int index)
		{
			this.HandleTeleportAndTrack();
		}

		// Token: 0x06030269 RID: 197225 RVA: 0x00B28C29 File Offset: 0x00B26E29
		protected virtual void OnTrackBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x0603026A RID: 197226 RVA: 0x00B28C31 File Offset: 0x00B26E31
		protected virtual void OnGotoBtnClick(int index)
		{
			this.HandleQuickGoto();
		}

		// Token: 0x0603026B RID: 197227 RVA: 0x00B28C39 File Offset: 0x00B26E39
		protected virtual void OnDetailBtnClick()
		{
		}

		// Token: 0x0603026C RID: 197228 RVA: 0x00B28C3B File Offset: 0x00B26E3B
		protected virtual void OnStripBtnClick()
		{
		}

		// Token: 0x0603026D RID: 197229 RVA: 0x00B28C3D File Offset: 0x00B26E3D
		protected virtual void OnDelBtnClick()
		{
		}

		// Token: 0x0603026E RID: 197230 RVA: 0x00B28C3F File Offset: 0x00B26E3F
		protected virtual void HandleTeleportAndTrack()
		{
			if (this.HandleTeleport())
			{
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x0603026F RID: 197231 RVA: 0x00B28C50 File Offset: 0x00B26E50
		protected virtual void HandleFastMoveAndTrack()
		{
			ConfigMarkItem configMarkItem = this.LayoutContext.MarkItem as ConfigMarkItem;
			bool flag = configMarkItem == null || !configMarkItem.IsLocked;
			bool flag2;
			if (configMarkItem == null)
			{
				flag2 = false;
			}
			else
			{
				ConfigMarkItem configMarkItem2 = configMarkItem;
				flag2 = (((configMarkItem2.MarkConfig != null) ? new int?(configMarkItem2.MarkConfig.GetValueOrDefault().EnableQuickTransfer) : null).GetValueOrDefault() == 1);
			}
			bool flag3 = flag2;
			if (flag && flag3)
			{
				this.HandleTeleportAndTrack();
				return;
			}
			this.HandleTrack();
		}

		// Token: 0x06030270 RID: 197232 RVA: 0x00B28CCC File Offset: 0x00B26ECC
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
			ConfigMarkItem configMarkItem2 = configMarkItem;
			if (configMarkItem2.MarkConfig != null && configMarkItem2.MarkConfig.GetValueOrDefault().InstanceDungeonId != 0)
			{
				WorldMapController.Instance.TryEntityTeleport(configMarkItem.MarkConfigId, null);
			}
			else
			{
				WorldMapController.Instance.TryTeleport(configMarkItem.MarkConfigId, null);
			}
			return true;
		}

		// Token: 0x06030271 RID: 197233 RVA: 0x00B28DA0 File Offset: 0x00B26FA0
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

		// Token: 0x06030272 RID: 197234 RVA: 0x00B28E64 File Offset: 0x00B27064
		protected virtual void HandleQuickGoto()
		{
			MarkItem markItem = this.LayoutContext.MarkItem;
			MarkItem markItem2 = MarkUiUtils.FindNearbyValidGotoMark(this.Map, markItem);
			if (markItem2 != null)
			{
				MarkUiUtils.QuickGotoTeleport(markItem, markItem2, new TOnTelSuccessCallBack(base.Close));
			}
		}

		// Token: 0x06030273 RID: 197235 RVA: 0x00B28EA0 File Offset: 0x00B270A0
		protected override void OnAfterShowWorldMapSecondaryUi()
		{
			WorldMapSecondaryUiAutoPilotContext autoPilotContext = this.AutoPilotContext;
			if (autoPilotContext == null)
			{
				return;
			}
			autoPilotContext.UpdateAutoPilotState();
		}

		// Token: 0x06030274 RID: 197236 RVA: 0x00B28EB2 File Offset: 0x00B270B2
		private void RefreshPanel(MarkItem markItem)
		{
			this.OnRefreshPanel();
		}

		// Token: 0x06030275 RID: 197237 RVA: 0x00B28EBA File Offset: 0x00B270BA
		protected virtual void OnRefreshPanel()
		{
			WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
		}

		// Token: 0x04019EF5 RID: 106229
		private const float SCROLL_ARROW_TOLERANCE = 0.001f;

		// Token: 0x04019EF6 RID: 106230
		private ButtonItem ConfirmButton;

		// Token: 0x04019EF7 RID: 106231
		protected ButtonItem TrackBtn;

		// Token: 0x04019EF8 RID: 106232
		protected ButtonItem GotoBtn;

		// Token: 0x04019EF9 RID: 106233
		protected MapTipsActivateTipPanel MapTipsActivateTipPanel;

		// Token: 0x04019EFA RID: 106234
		protected MediumItemListPanel DeliveryPropView;

		// Token: 0x04019EFB RID: 106235
		protected WorldMapSecondaryUiAutoPilotContext AutoPilotContext;

		// Token: 0x04019EFC RID: 106236
		protected WorldMapSecondaryUiContext LayoutContext;

		// Token: 0x04019EFD RID: 106237
		private Action UpdateTopRightIconHandle;
	}
}
