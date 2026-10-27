using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TeleportPanel
{
	// Token: 0x020047EC RID: 18412
	public class TeleportPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030398 RID: 197528 RVA: 0x00B2D4C9 File Offset: 0x00B2B6C9
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030399 RID: 197529 RVA: 0x00B2D4D0 File Offset: 0x00B2B6D0
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.UnlockTeleport, new Action<int>(this.EventUnlockTeleport));
			base.OnBeforeShow();
		}

		// Token: 0x0603039A RID: 197530 RVA: 0x00B2D4F4 File Offset: 0x00B2B6F4
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.UnlockTeleport, new Action<int>(this.EventUnlockTeleport));
			base.OnBeforeHide();
		}

		// Token: 0x0603039B RID: 197531 RVA: 0x00B2D518 File Offset: 0x00B2B718
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

		// Token: 0x0603039C RID: 197532 RVA: 0x00B2D594 File Offset: 0x00B2B794
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

		// Token: 0x0603039D RID: 197533 RVA: 0x00B2D648 File Offset: 0x00B2B848
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

		// Token: 0x04019F69 RID: 106345
		[Nullable(2)]
		private TeleportMarkItem SelectedMarkItem;

		// Token: 0x0200AAAF RID: 43695
		public static class EComponents
		{
			// Token: 0x04033EC2 RID: 212674
			public const int TeleportPanel = 0;
		}
	}
}
