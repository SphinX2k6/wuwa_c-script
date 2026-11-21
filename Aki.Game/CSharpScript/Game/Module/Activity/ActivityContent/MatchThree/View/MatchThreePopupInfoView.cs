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
	// Token: 0x0200541D RID: 21533
	public class MatchThreePopupInfoView : UiViewBase
	{
		// Token: 0x060357B9 RID: 219065 RVA: 0x00EEF826 File Offset: 0x00EEDA26
		[NullableContext(1)]
		public MatchThreePopupInfoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060357BA RID: 219066 RVA: 0x00EEF830 File Offset: 0x00EEDA30
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

		// Token: 0x060357BB RID: 219067 RVA: 0x00EEFA28 File Offset: 0x00EEDC28
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePopupInfoView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePopupInfoView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357BC RID: 219068 RVA: 0x00EEFA6B File Offset: 0x00EEDC6B
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

		// Token: 0x060357BD RID: 219069 RVA: 0x00EEFA95 File Offset: 0x00EEDC95
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			this.PlayCurrentTabItemsStart();
			this.NeedPlayItemStartOnAfterShow = false;
			return UniTask.CompletedTask;
		}

		// Token: 0x060357BE RID: 219070 RVA: 0x00EEFAA9 File Offset: 0x00EEDCA9
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

		// Token: 0x060357BF RID: 219071 RVA: 0x00EEFADE File Offset: 0x00EEDCDE
		protected override void OnAfterShow()
		{
			if (!this.NeedPlayItemStartOnAfterShow || base.IsDestroyOrDestroying)
			{
				return;
			}
			this.NeedPlayItemStartOnAfterShow = false;
			this.PlayCurrentTabItemsStart();
		}

		// Token: 0x060357C0 RID: 219072 RVA: 0x00EEFB00 File Offset: 0x00EEDD00
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

		// Token: 0x060357C1 RID: 219073 RVA: 0x00EEFBB4 File Offset: 0x00EEDDB4
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

		// Token: 0x060357C2 RID: 219074 RVA: 0x00EEFC3C File Offset: 0x00EEDE3C
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

		// Token: 0x060357C3 RID: 219075 RVA: 0x00EEFC9D File Offset: 0x00EEDE9D
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

		// Token: 0x060357C4 RID: 219076 RVA: 0x00EEFCD8 File Offset: 0x00EEDED8
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

		// Token: 0x060357C5 RID: 219077 RVA: 0x00EEFD4C File Offset: 0x00EEDF4C
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

		// Token: 0x060357C6 RID: 219078 RVA: 0x00EEFDBD File Offset: 0x00EEDFBD
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

		// Token: 0x060357C7 RID: 219079 RVA: 0x00EEFDFC File Offset: 0x00EEDFFC
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

		// Token: 0x060357C8 RID: 219080 RVA: 0x00EEFEF0 File Offset: 0x00EEE0F0
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

		// Token: 0x060357C9 RID: 219081 RVA: 0x00EEFF44 File Offset: 0x00EEE144
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

		// Token: 0x060357CA RID: 219082 RVA: 0x00EEFF98 File Offset: 0x00EEE198
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

		// Token: 0x060357CB RID: 219083 RVA: 0x00EF007B File Offset: 0x00EEE27B
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

		// Token: 0x060357CC RID: 219084 RVA: 0x00EF00AE File Offset: 0x00EEE2AE
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

		// Token: 0x060357CD RID: 219085 RVA: 0x00EF00E1 File Offset: 0x00EEE2E1
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C3BB RID: 115643
		[Nullable(2)]
		private MatchThreePopupInfoViewParams Params;

		// Token: 0x0401C3BC RID: 115644
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MatchThreePopupTileInfoItem, MatchThreeInfoItemData> TileScroll;

		// Token: 0x0401C3BD RID: 115645
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<MatchThreePopupEnvInfoItem, MatchThreeInfoItemData> EnvScroll;

		// Token: 0x0401C3BE RID: 115646
		private MatchThreePopupInfoView.EPopupInfoTab CurrentTab;

		// Token: 0x0401C3BF RID: 115647
		private bool NeedPlayItemStartOnAfterShow;

		// Token: 0x0200B08C RID: 45196
		private enum EPopupInfoTab
		{
			// Token: 0x040368FA RID: 223482
			Tile,
			// Token: 0x040368FB RID: 223483
			Env
		}
	}
}
