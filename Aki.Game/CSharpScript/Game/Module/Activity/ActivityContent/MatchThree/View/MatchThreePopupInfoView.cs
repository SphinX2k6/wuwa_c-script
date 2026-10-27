using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x0200649F RID: 25759
	public class MatchThreePopupInfoView : UiViewBase
	{
		// Token: 0x06040AF5 RID: 264949 RVA: 0x00FA87DE File Offset: 0x00FA69DE
		[NullableContext(1)]
		public MatchThreePopupInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040AF6 RID: 264950 RVA: 0x00FA87E8 File Offset: 0x00FA69E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickTabTile));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickTabEnv));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040AF7 RID: 264951 RVA: 0x00FA89E0 File Offset: 0x00FA6BE0
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePopupInfoView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePopupInfoView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040AF8 RID: 264952 RVA: 0x00FA8A23 File Offset: 0x00FA6C23
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			MatchThreePopupInfoViewParams @params = this.Params;
			if (@params != null && @params.HasFocus)
			{
				this.ApplyFocusScroll(true);
			}
			this.NeedPlayItemStartOnAfterShow = true;
		}

		// Token: 0x06040AF9 RID: 264953 RVA: 0x00FA8A4D File Offset: 0x00FA6C4D
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			this.PlayCurrentTabItemsStart();
			this.NeedPlayItemStartOnAfterShow = false;
			return UniTask.CompletedTask;
		}

		// Token: 0x06040AFA RID: 264954 RVA: 0x00FA8A61 File Offset: 0x00FA6C61
		protected override void OnAfterPlayStartSequence()
		{
			if (!base.IsDestroyOrDestroying)
			{
				MatchThreePopupInfoViewParams @params = this.Params;
				if (@params != null && @params.HasFocus)
				{
					this.ApplyFocusScroll(false);
					this.PlayFocusHighlight();
					this.ApplyNavigationFocus();
					return;
				}
			}
		}

		// Token: 0x06040AFB RID: 264955 RVA: 0x00FA8A96 File Offset: 0x00FA6C96
		protected override void OnAfterShow()
		{
			if (!this.NeedPlayItemStartOnAfterShow || base.IsDestroyOrDestroying)
			{
				return;
			}
			this.NeedPlayItemStartOnAfterShow = false;
			this.PlayCurrentTabItemsStart();
		}

		// Token: 0x06040AFC RID: 264956 RVA: 0x00FA8AB8 File Offset: 0x00FA6CB8
		private void PlayCurrentTabItemsStart()
		{
			if (this.CurrentTab == MatchThreePopupInfoView.EPopupInfoTab.Tile)
			{
				if (this.TileScroll == null)
				{
					return;
				}
				foreach (MatchThreePopupTileInfoItem matchThreePopupTileInfoItem in this.TileScroll.GetScrollItemList())
				{
					matchThreePopupTileInfoItem.PlayStartSequence();
				}
				return;
			}
			else
			{
				if (this.EnvScroll == null)
				{
					return;
				}
				foreach (MatchThreePopupEnvInfoItem matchThreePopupEnvInfoItem in this.EnvScroll.GetScrollItemList())
				{
					matchThreePopupEnvInfoItem.PlayStartSequence();
				}
				return;
			}
		}

		// Token: 0x06040AFD RID: 264957 RVA: 0x00FA8B6C File Offset: 0x00FA6D6C
		private void RefreshView()
		{
			if (this.Params == null)
			{
				return;
			}
			bool hasTile = this.Params.HasTile;
			bool hasEnv = this.Params.HasEnv;
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				UUIItem uuiitem = extendToggle.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(hasTile);
				}
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (extendToggle2 != null)
			{
				UUIItem uuiitem2 = extendToggle2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(hasEnv);
				}
			}
			this.SwitchTab(this.ResolveDefaultTab(), false);
		}

		// Token: 0x06040AFE RID: 264958 RVA: 0x00FA8BF4 File Offset: 0x00FA6DF4
		private MatchThreePopupInfoView.EPopupInfoTab ResolveDefaultTab()
		{
			if (this.Params == null)
			{
				return MatchThreePopupInfoView.EPopupInfoTab.Tile;
			}
			if (this.Params.FocusEnvIndex >= 0 && this.Params.HasEnv)
			{
				return MatchThreePopupInfoView.EPopupInfoTab.Env;
			}
			if (this.Params.FocusTileIndex >= 0 && this.Params.HasTile)
			{
				return MatchThreePopupInfoView.EPopupInfoTab.Tile;
			}
			if (!this.Params.HasTile)
			{
				return MatchThreePopupInfoView.EPopupInfoTab.Env;
			}
			return MatchThreePopupInfoView.EPopupInfoTab.Tile;
		}

		// Token: 0x06040AFF RID: 264959 RVA: 0x00FA8C55 File Offset: 0x00FA6E55
		private void ApplyFocusScroll(bool useLateScroll)
		{
			if (this.Params == null)
			{
				return;
			}
			if (this.CurrentTab == MatchThreePopupInfoView.EPopupInfoTab.Tile)
			{
				this.ScrollToTile(this.Params.FocusTileIndex, useLateScroll);
				return;
			}
			this.ScrollToEnv(this.Params.FocusEnvIndex, useLateScroll);
		}

		// Token: 0x06040B00 RID: 264960 RVA: 0x00FA8C90 File Offset: 0x00FA6E90
		private void ScrollToTile(int focusIndex, bool useLateScroll)
		{
			if (this.TileScroll == null || this.Params == null || focusIndex < 0 || focusIndex >= this.Params.TileList.Count)
			{
				return;
			}
			MatchThreePopupTileInfoItem scrollItemByIndex = this.TileScroll.GetScrollItemByIndex(focusIndex);
			UUIItem uuiitem = (scrollItemByIndex != null) ? scrollItemByIndex.GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			if (useLateScroll)
			{
				this.TileScroll.LateScrollTo(uuiitem, null, false);
				return;
			}
			this.TileScroll.ScrollTo(uuiitem, false);
		}

		// Token: 0x06040B01 RID: 264961 RVA: 0x00FA8D04 File Offset: 0x00FA6F04
		private void ScrollToEnv(int focusIndex, bool useLateScroll)
		{
			if (this.EnvScroll == null || this.Params == null || focusIndex < 0 || focusIndex >= this.Params.EnvList.Count)
			{
				return;
			}
			MatchThreePopupEnvInfoItem scrollItemByIndex = this.EnvScroll.GetScrollItemByIndex(focusIndex);
			UUIItem uuiitem = (scrollItemByIndex != null) ? scrollItemByIndex.GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			if (useLateScroll)
			{
				this.EnvScroll.LateScrollTo(uuiitem, null, false);
				return;
			}
			this.EnvScroll.ScrollTo(uuiitem, false);
		}

		// Token: 0x06040B02 RID: 264962 RVA: 0x00FA8D75 File Offset: 0x00FA6F75
		private void PlayFocusHighlight()
		{
			if (this.Params == null || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (this.CurrentTab == MatchThreePopupInfoView.EPopupInfoTab.Tile)
			{
				this.PlaySingleTileHighlight(this.Params.FocusTileIndex);
				return;
			}
			this.PlaySingleEnvHighlight(this.Params.FocusEnvIndex);
		}

		// Token: 0x06040B03 RID: 264963 RVA: 0x00FA8DB4 File Offset: 0x00FA6FB4
		private void ApplyNavigationFocus()
		{
			if (this.Params == null || base.IsDestroyOrDestroying)
			{
				return;
			}
			UUIItem uuiitem;
			if (this.CurrentTab == MatchThreePopupInfoView.EPopupInfoTab.Tile)
			{
				if (this.TileScroll == null || this.Params.FocusTileIndex < 0 || this.Params.FocusTileIndex >= this.Params.TileList.Count)
				{
					return;
				}
				MatchThreePopupTileInfoItem scrollItemByIndex = this.TileScroll.GetScrollItemByIndex(this.Params.FocusTileIndex);
				uuiitem = ((scrollItemByIndex != null) ? scrollItemByIndex.GetNavigationItem() : null);
			}
			else
			{
				if (this.EnvScroll == null || this.Params.FocusEnvIndex < 0 || this.Params.FocusEnvIndex >= this.Params.EnvList.Count)
				{
					return;
				}
				MatchThreePopupEnvInfoItem scrollItemByIndex2 = this.EnvScroll.GetScrollItemByIndex(this.Params.FocusEnvIndex);
				uuiitem = ((scrollItemByIndex2 != null) ? scrollItemByIndex2.GetNavigationItem() : null);
			}
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, true, false, false);
		}

		// Token: 0x06040B04 RID: 264964 RVA: 0x00FA8EA8 File Offset: 0x00FA70A8
		private void PlaySingleTileHighlight(int focusIndex)
		{
			if (this.TileScroll == null || this.Params == null || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (focusIndex < 0 || focusIndex >= this.Params.TileList.Count)
			{
				return;
			}
			MatchThreePopupTileInfoItem scrollItemByIndex = this.TileScroll.GetScrollItemByIndex(focusIndex);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.PlayHighlight();
		}

		// Token: 0x06040B05 RID: 264965 RVA: 0x00FA8EFC File Offset: 0x00FA70FC
		private void PlaySingleEnvHighlight(int focusIndex)
		{
			if (this.EnvScroll == null || this.Params == null || base.IsDestroyOrDestroying)
			{
				return;
			}
			if (focusIndex < 0 || focusIndex >= this.Params.EnvList.Count)
			{
				return;
			}
			MatchThreePopupEnvInfoItem scrollItemByIndex = this.EnvScroll.GetScrollItemByIndex(focusIndex);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.PlayHighlight();
		}

		// Token: 0x06040B06 RID: 264966 RVA: 0x00FA8F50 File Offset: 0x00FA7150
		private void SwitchTab(MatchThreePopupInfoView.EPopupInfoTab tab, bool fireEvent)
		{
			MatchThreePopupInfoViewParams @params = this.Params;
			bool flag = @params != null && @params.HasTile;
			MatchThreePopupInfoViewParams params2 = this.Params;
			bool flag2 = params2 != null && params2.HasEnv;
			if (tab == MatchThreePopupInfoView.EPopupInfoTab.Tile && !flag)
			{
				tab = MatchThreePopupInfoView.EPopupInfoTab.Env;
			}
			if (tab == MatchThreePopupInfoView.EPopupInfoTab.Env && !flag2)
			{
				tab = MatchThreePopupInfoView.EPopupInfoTab.Tile;
			}
			bool flag3 = tab == MatchThreePopupInfoView.EPopupInfoTab.Tile;
			this.CurrentTab = (flag3 ? MatchThreePopupInfoView.EPopupInfoTab.Tile : MatchThreePopupInfoView.EPopupInfoTab.Env);
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(flag3 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleState(flag3 ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, fireEvent, false, false);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
			if (scrollViewWithScrollbar != null)
			{
				UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag3 && flag);
				}
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = scrollViewWithScrollbar2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(!flag3 && flag2);
		}

		// Token: 0x06040B07 RID: 264967 RVA: 0x00FA9033 File Offset: 0x00FA7233
		private void OnClickTabTile(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (this.Params == null || !this.Params.HasTile)
			{
				this.SwitchTab(MatchThreePopupInfoView.EPopupInfoTab.Env, false);
				return;
			}
			this.SwitchTab(MatchThreePopupInfoView.EPopupInfoTab.Tile, false);
			this.PlayCurrentTabItemsStart();
		}

		// Token: 0x06040B08 RID: 264968 RVA: 0x00FA9066 File Offset: 0x00FA7266
		private void OnClickTabEnv(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			if (this.Params == null || !this.Params.HasEnv)
			{
				this.SwitchTab(MatchThreePopupInfoView.EPopupInfoTab.Tile, false);
				return;
			}
			this.SwitchTab(MatchThreePopupInfoView.EPopupInfoTab.Env, false);
			this.PlayCurrentTabItemsStart();
		}

		// Token: 0x06040B09 RID: 264969 RVA: 0x00FA9099 File Offset: 0x00FA7299
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x04021A8A RID: 137866
		[Nullable(2)]
		private MatchThreePopupInfoViewParams Params;

		// Token: 0x04021A8B RID: 137867
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MatchThreePopupTileInfoItem, MatchThreeInfoItemData> TileScroll;

		// Token: 0x04021A8C RID: 137868
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MatchThreePopupEnvInfoItem, MatchThreeInfoItemData> EnvScroll;

		// Token: 0x04021A8D RID: 137869
		private MatchThreePopupInfoView.EPopupInfoTab CurrentTab;

		// Token: 0x04021A8E RID: 137870
		private bool NeedPlayItemStartOnAfterShow;

		// Token: 0x0200C6A6 RID: 50854
		private enum EPopupInfoTab
		{
			// Token: 0x0403BF9F RID: 245663
			Tile,
			// Token: 0x0403BFA0 RID: 245664
			Env
		}
	}
}
