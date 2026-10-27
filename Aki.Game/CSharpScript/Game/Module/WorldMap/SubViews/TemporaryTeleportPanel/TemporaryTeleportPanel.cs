using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TemporaryTeleportPanel
{
	// Token: 0x020047EB RID: 18411
	public class TemporaryTeleportPanel : WorldMapSecondaryUiLayoutB
	{
		// Token: 0x0603038E RID: 197518 RVA: 0x00B2D1A9 File Offset: 0x00B2B3A9
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_TemporaryTeleportPanel_Prefab";
		}

		// Token: 0x0603038F RID: 197519 RVA: 0x00B2D1B0 File Offset: 0x00B2B3B0
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetRaycastTarget(false);
			}
			base.OnStart();
		}

		// Token: 0x06030390 RID: 197520 RVA: 0x00B2D1CC File Offset: 0x00B2B3CC
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TemporaryTeleportMarkItem temporaryTeleportMarkItem = param[0] as TemporaryTeleportMarkItem;
				if (temporaryTeleportMarkItem != null)
				{
					this.LayoutContext.MarkItem = temporaryTeleportMarkItem;
					this.SelectedMarkItem = temporaryTeleportMarkItem;
					UUIText text = base.GetText(1);
					if (text != null)
					{
						text.SetText(StringUtils.Format("{0}{1}/{2}", new string[]
						{
							this.SelectedMarkItem.GetTitleText() ?? "",
							MapModel.Instance.GetMarkCountByType(EMarkType.TemporaryTeleport).ToString(),
							ConfigCommonParamById.GetIntConfig("TemporaryTeleportCountLimit").ToString()
						}), true);
					}
					ButtonItem rightConfirmBtn = this.RightConfirmBtn;
					if (rightConfirmBtn != null)
					{
						rightConfirmBtn.SetUiActive(false);
					}
					ButtonItem leftConfirmBtn = this.LeftConfirmBtn;
					if (leftConfirmBtn != null)
					{
						leftConfirmBtn.SetUiActive(false);
					}
					ButtonItem middleCenterBtn = this.MiddleCenterBtn;
					if (middleCenterBtn != null)
					{
						middleCenterBtn.SetUiActive(true);
					}
					base.SetDelBtnActive(true);
					this.SetSpriteByPath(this.SelectedMarkItem.IconPath, base.GetSprite(0), false, null, null);
					UUIText text2 = base.GetText(2);
					if (text2 != null)
					{
						text2.SetText(this.SelectedMarkItem.GetDescText() ?? "", true);
					}
					UUIText text3 = base.GetText(3);
					if (text3 != null)
					{
						text3.SetUIActive(false);
					}
					UUIItem item = base.GetItem(5);
					if (item != null)
					{
						item.SetUIActive(false);
					}
					this.UpdateButtonState();
					this.UpdateMultiMap();
				}
			}
		}

		// Token: 0x06030391 RID: 197521 RVA: 0x00B2D327 File Offset: 0x00B2B527
		protected override void OnMiddleCenterBtnClick(int index)
		{
			if (this.SelectedMarkItem != null)
			{
				MapController instance = MapController.Instance;
				if (instance != null)
				{
					instance.RequestTeleportToTargetByTemporaryTeleport(this.SelectedMarkItem.TeleportId, null);
				}
				base.Close();
			}
		}

		// Token: 0x06030392 RID: 197522 RVA: 0x00B2D353 File Offset: 0x00B2B553
		protected override void OnDelBtnClick()
		{
			this.OpenSureRemoveTemporaryTeleport();
		}

		// Token: 0x06030393 RID: 197523 RVA: 0x00B2D35C File Offset: 0x00B2B55C
		private void OpenSureRemoveTemporaryTeleport()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DestroyTemporaryTeleport);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.RemoveTemporaryTeleport);
			ConfirmBoxController instance = ConfirmBoxController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06030394 RID: 197524 RVA: 0x00B2D39D File Offset: 0x00B2B59D
		private void RemoveTemporaryTeleport()
		{
			if (this.SelectedMarkItem != null)
			{
				MapExploreToolController instance = MapExploreToolController.Instance;
				if (instance != null)
				{
					instance.RemoveTemporaryTeleportRequest((long)this.SelectedMarkItem.TeleportId, this.SelectedMarkItem.MarkId);
				}
				base.Close();
			}
		}

		// Token: 0x06030395 RID: 197525 RVA: 0x00B2D3D4 File Offset: 0x00B2B5D4
		private void UpdateButtonState()
		{
			ButtonItem middleCenterBtn = this.MiddleCenterBtn;
			if (middleCenterBtn != null)
			{
				middleCenterBtn.SetLocalText("TeleportFastMove", Array.Empty<object>());
			}
			OnlineModel instance = OnlineModel.Instance;
			if (instance != null && instance.GetIsTeamModel())
			{
				base.SetDelBtnActive(OnlineModel.Instance.GetIsMyTeam());
			}
			else
			{
				base.SetDelBtnActive(true);
			}
			ButtonItem middleCenterBtn2 = this.MiddleCenterBtn;
			if (middleCenterBtn2 == null)
			{
				return;
			}
			TemporaryTeleportMarkItem selectedMarkItem = this.SelectedMarkItem;
			middleCenterBtn2.SetEnableClick(selectedMarkItem == null || !selectedMarkItem.IsServerDisable);
		}

		// Token: 0x06030396 RID: 197526 RVA: 0x00B2D450 File Offset: 0x00B2B650
		private void UpdateMultiMap()
		{
			if (this.SelectedMarkItem == null)
			{
				return;
			}
			bool flag = this.SelectedMarkItem.ShowSecondaryUiMultiMapIcon();
			UUISprite sprite = base.GetSprite(11);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			string resourceId = flag ? "SP_MarkMultiMapSelect" : "SP_MarkTime";
			UiResourceConfig instance = UiResourceConfig.Instance;
			string path = (instance != null) ? instance.GetResourcePath(resourceId) : null;
			this.SetSpriteByPath(path, base.GetSprite(11), false, null, null);
		}

		// Token: 0x04019F68 RID: 106344
		[Nullable(2)]
		private TemporaryTeleportMarkItem SelectedMarkItem;

		// Token: 0x0200AAAE RID: 43694
		public static class EComponents
		{
			// Token: 0x04033EC1 RID: 212673
			public const int TemporaryTeleportPanel = 0;
		}
	}
}
