using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02003757 RID: 14167
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingShipSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D66 RID: 150886 RVA: 0x00A692BB File Offset: 0x00A674BB
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D67 RID: 150887 RVA: 0x00A692C4 File Offset: 0x00A674C4
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingShipSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingShipSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024D68 RID: 150888 RVA: 0x00A69308 File Offset: 0x00A67508
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				UUIText areaText = layoutContext.AreaText;
				if (areaText != null)
				{
					areaText.SetUIActive(false);
				}
			}
			WorldMapSecondaryUiContext layoutContext2 = this.LayoutContext;
			if (layoutContext2 == null)
			{
				return;
			}
			UUIVerticalLayout panelListLayout = layoutContext2.PanelListLayout;
			if (panelListLayout == null)
			{
				return;
			}
			panelListLayout.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06024D69 RID: 150889 RVA: 0x00A69360 File Offset: 0x00A67560
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				FishingShipMarkItem fishingShipMarkItem = param[0] as FishingShipMarkItem;
				if (fishingShipMarkItem != null)
				{
					this.LayoutContext.MarkItem = fishingShipMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext != null)
					{
						layoutContext.SetConfirmBtnText("Fishing_FastOnBoat", Array.Empty<object>());
					}
					this.RefreshTipList();
					base.UpdateQuickGotoActive(false);
				}
			}
		}

		// Token: 0x06024D6A RID: 150890 RVA: 0x00A693C8 File Offset: 0x00A675C8
		private void RefreshTipList()
		{
			List<IWorldMapSecondaryTipItemParam> data = new List<IWorldMapSecondaryTipItemParam>
			{
				this.GetCapacityTipItemData()
			};
			this.WorldMapSecondaryTipList.RefreshByData(data);
		}

		// Token: 0x06024D6B RID: 150891 RVA: 0x00A693F4 File Offset: 0x00A675F4
		private IWorldMapSecondaryTipItemParam GetCapacityTipItemData()
		{
			int backpackUseSize = DockyardModel.Instance.BackpackUseSize;
			int backpackSize = DockyardModel.Instance.BackpackSize;
			string multiText = TextConfig.Instance.GetMultiText("Fishing_MarkText1", Array.Empty<string>());
			string multiText2 = TextConfig.Instance.GetMultiText("Fishing_QTE_Count", new string[]
			{
				backpackUseSize.ToString(),
				backpackSize.ToString()
			});
			return new WorldMapSecondaryTipItemParam
			{
				Name = multiText,
				Desc = multiText2
			};
		}

		// Token: 0x06024D6C RID: 150892 RVA: 0x00A69469 File Offset: 0x00A67669
		protected override void OnConfirmBtnClick(int index)
		{
			FishingController.Instance.FishingTeleportToBoat();
		}

		// Token: 0x040146CF RID: 83663
		private WorldMapSecondaryTipListPanel WorldMapSecondaryTipList;

		// Token: 0x020094AB RID: 38059
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E71E RID: 190238
			public const int FishingShip = 0;
		}
	}
}
