using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TeleportPanel
{
	// Token: 0x0200371D RID: 14109
	public class TeleportPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024B68 RID: 150376 RVA: 0x00A5D40D File Offset: 0x00A5B60D
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024B69 RID: 150377 RVA: 0x00A5D414 File Offset: 0x00A5B614
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.UnlockTeleport, new Action<int>(this.EventUnlockTeleport));
			base.OnBeforeShow();
		}

		// Token: 0x06024B6A RID: 150378 RVA: 0x00A5D438 File Offset: 0x00A5B638
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.UnlockTeleport, new Action<int>(this.EventUnlockTeleport));
			base.OnBeforeHide();
		}

		// Token: 0x06024B6B RID: 150379 RVA: 0x00A5D45C File Offset: 0x00A5B65C
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

		// Token: 0x06024B6C RID: 150380 RVA: 0x00A5D4D8 File Offset: 0x00A5B6D8
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.SelectedMarkItem = teleportMarkItem;
					this.LayoutContext.MarkItem = teleportMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonEnableClickByTeleportState(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					UUIText text = base.GetText(4);
					if (text != null)
					{
						text.ShowTextNew(this.SelectedMarkItem.GetLocaleDesc());
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

		// Token: 0x06024B6D RID: 150381 RVA: 0x00A5D58C File Offset: 0x00A5B78C
		private void EventUnlockTeleport(int teleportId)
		{
			TeleportMarkItem selectedMarkItem = this.SelectedMarkItem;
			int? num = (selectedMarkItem != null) ? new int?(selectedMarkItem.MarkConfigId) : null;
			if (!(teleportId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			base.Close();
		}

		// Token: 0x0401461D RID: 83485
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x02009461 RID: 37985
		public static class EComponents
		{
			// Token: 0x0402E648 RID: 190024
			public const int TeleportPanel = 0;
		}
	}
}
