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
	// Token: 0x0200371C RID: 14108
	public class TemporaryTeleportPanel : WorldMapSecondaryUiLayoutB
	{
		// Token: 0x06024B5E RID: 150366 RVA: 0x00A5D0ED File Offset: 0x00A5B2ED
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiItem_TemporaryTeleportPanel_Prefab";
		}

		// Token: 0x06024B5F RID: 150367 RVA: 0x00A5D0F4 File Offset: 0x00A5B2F4
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetRaycastTarget(false);
			}
			base.OnStart();
		}

		// Token: 0x06024B60 RID: 150368 RVA: 0x00A5D110 File Offset: 0x00A5B310
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

		// Token: 0x06024B61 RID: 150369 RVA: 0x00A5D26B File Offset: 0x00A5B46B
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

		// Token: 0x06024B62 RID: 150370 RVA: 0x00A5D297 File Offset: 0x00A5B497
		protected override void OnDelBtnClick()
		{
			this.OpenSureRemoveTemporaryTeleport();
		}

		// Token: 0x06024B63 RID: 150371 RVA: 0x00A5D2A0 File Offset: 0x00A5B4A0
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

		// Token: 0x06024B64 RID: 150372 RVA: 0x00A5D2E1 File Offset: 0x00A5B4E1
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

		// Token: 0x06024B65 RID: 150373 RVA: 0x00A5D318 File Offset: 0x00A5B518
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

		// Token: 0x06024B66 RID: 150374 RVA: 0x00A5D394 File Offset: 0x00A5B594
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

		// Token: 0x0401461C RID: 83484
		[Nullable(2)]
		private TemporaryTeleportMarkItem SelectedMarkItem;

		// Token: 0x02009460 RID: 37984
		public static class EComponents
		{
			// Token: 0x0402E647 RID: 190023
			public const int TemporaryTeleportPanel = 0;
		}
	}
}
