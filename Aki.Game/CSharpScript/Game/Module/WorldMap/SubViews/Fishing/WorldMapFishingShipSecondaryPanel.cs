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
	// Token: 0x02004826 RID: 18470
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapFishingShipSecondaryPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030596 RID: 198038 RVA: 0x00B391EF File Offset: 0x00B373EF
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030597 RID: 198039 RVA: 0x00B391F8 File Offset: 0x00B373F8
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapFishingShipSecondaryPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapFishingShipSecondaryPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030598 RID: 198040 RVA: 0x00B3923C File Offset: 0x00B3743C
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

		// Token: 0x06030599 RID: 198041 RVA: 0x00B39294 File Offset: 0x00B37494
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

		// Token: 0x0603059A RID: 198042 RVA: 0x00B392FC File Offset: 0x00B374FC
		private void RefreshTipList()
		{
			List<IWorldMapSecondaryTipItemParam> data = new List<IWorldMapSecondaryTipItemParam>
			{
				this.GetCapacityTipItemData()
			};
			this.WorldMapSecondaryTipList.RefreshByData(data);
		}

		// Token: 0x0603059B RID: 198043 RVA: 0x00B39328 File Offset: 0x00B37528
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

		// Token: 0x0603059C RID: 198044 RVA: 0x00B3939D File Offset: 0x00B3759D
		protected override void OnConfirmBtnClick(int index)
		{
			FishingController.Instance.FishingTeleportToBoat();
		}

		// Token: 0x0401A01B RID: 106523
		private WorldMapSecondaryTipListPanel WorldMapSecondaryTipList;

		// Token: 0x0200AAFC RID: 43772
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F9E RID: 212894
			public const int FishingShip = 0;
		}
	}
}
