using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9B RID: 19099
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopTypeGridItem : LoopScrollMediumItemGrid<TrapDefenseBuildingDevelopItemData>
	{
		// Token: 0x06031805 RID: 202757 RVA: 0x00B7993C File Offset: 0x00B77B3C
		protected override void OnStart()
		{
			base.BindOnExtendTogglePress(new Action<MediumItemGridExtendCallback>(this.OnToggleDown));
			base.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnToggleUp));
		}

		// Token: 0x06031806 RID: 202758 RVA: 0x00B79962 File Offset: 0x00B77B62
		protected override void OnRefresh(TrapDefenseBuildingDevelopItemData data, bool isSelected, int gridIndex)
		{
			this.TrapData = data;
			this.SetSelected(isSelected, true);
			this.UpdateInfo();
		}

		// Token: 0x06031807 RID: 202759 RVA: 0x00B7997C File Offset: 0x00B77B7C
		public void UpdateInfo()
		{
			string bottomTextId = this.TrapData.GetIsUnlock() ? "TowerDefense_Building_BdLv_Text" : "TowerDefense_Building_BdLock_Text";
			bool flag = TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckNeedOrganNew(this.TrapData);
			bool? isReceivedFlagVisible = new bool?(TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckSlotEquipped(this.TrapData));
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(this.TrapData.Id);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ItemQualityNormal");
			bool? isRecommendOrgan = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetIsRecommendOrgan(this.TrapData);
			PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
			propMediumItemGrid.Data = this.TrapData;
			propMediumItemGrid.IsRecommendVisible = isRecommendOrgan;
			propMediumItemGrid.BottomTextId = bottomTextId;
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				(this.TrapData != null) ? this.TrapData.GetLevel() : ""
			};
			PropMediumItemGrid propMediumItemGrid2 = propMediumItemGrid;
			TrapDefenseBuildingDevelopItemData trapData = this.TrapData;
			propMediumItemGrid2.IsLockVisible = new bool?(trapData == null || !trapData.GetIsUnlock());
			PropMediumItemGrid propMediumItemGrid3 = propMediumItemGrid;
			bool value;
			if (!this.TrapData.IsInDungeon)
			{
				TrapDefenseBuildingDevelopItemData trapData2 = this.TrapData;
				if (trapData2 != null && trapData2.GetIsUnlock())
				{
					TrapDefenseBuildingDevelopItemData trapData3 = this.TrapData;
					value = (trapData3 != null && trapData3.CheckNeedRedDot());
					goto IL_137;
				}
			}
			value = false;
			IL_137:
			propMediumItemGrid3.IsRedDotVisible = new bool?(value);
			MediumItemGridBase mediumItemGridBase = propMediumItemGrid;
			TrapDefenseBuildingDevelopItemData trapData4 = this.TrapData;
			mediumItemGridBase.IconPath = ((trapData4 != null) ? trapData4.GetIconPath() : null);
			PropMediumItemGrid propMediumItemGrid4 = propMediumItemGrid;
			TrapDefenseBuildingDevelopItemData trapData5 = this.TrapData;
			propMediumItemGrid4.IsDisable = new bool?(trapData5 == null || !trapData5.GetIsUnlock());
			propMediumItemGrid.IsNewVisible = new bool?(isRecommendOrgan == null && flag);
			propMediumItemGrid.IsReceivedFlagVisible = isReceivedFlagVisible;
			propMediumItemGrid.IsBranchUpgrade = ((trapDefenseMachineIdInfo.Branch > 0) ? new bool?(true) : null);
			propMediumItemGrid.QualityIcon = resourcePath;
			PropMediumItemGrid parameters = propMediumItemGrid;
			base.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06031808 RID: 202760 RVA: 0x00B79B5B File Offset: 0x00B77D5B
		public void OnForceSelected()
		{
			if (TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetOrganClicked(this.TrapData))
			{
				this.UpdateState();
			}
			this.SetSelected(true, true);
		}

		// Token: 0x06031809 RID: 202761 RVA: 0x00B79B82 File Offset: 0x00B77D82
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
			if (TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetOrganClicked(this.TrapData))
			{
				this.UpdateState();
			}
			if (fireEvent)
			{
				Action<TrapDefenseBuildingDevelopItemData> onItemClickCallback = this.OnItemClickCallback;
				if (onItemClickCallback == null)
				{
					return;
				}
				onItemClickCallback(this.TrapData);
			}
		}

		// Token: 0x0603180A RID: 202762 RVA: 0x00B79BC2 File Offset: 0x00B77DC2
		protected override bool OnCanExecuteChange()
		{
			return this.CanExecuteChangeCb == null || this.CanExecuteChangeCb(this.TrapData);
		}

		// Token: 0x0603180B RID: 202763 RVA: 0x00B79BDF File Offset: 0x00B77DDF
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0603180C RID: 202764 RVA: 0x00B79BE9 File Offset: 0x00B77DE9
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603180D RID: 202765 RVA: 0x00B79BEB File Offset: 0x00B77DEB
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				IScrollViewDelegate<IGridProxy<TrapDefenseBuildingDevelopItemData>, TrapDefenseBuildingDevelopItemData> scrollViewDelegate = base.ScrollViewDelegate;
				if (scrollViewDelegate == null)
				{
					return;
				}
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, true);
			}
		}

		// Token: 0x0603180E RID: 202766 RVA: 0x00B79C0E File Offset: 0x00B77E0E
		private void OnToggleDown(MediumItemGridExtendCallback _)
		{
			Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> onPointDownCb = this.OnPointDownCb;
			if (onPointDownCb == null)
			{
				return;
			}
			onPointDownCb(this, this.TrapData);
		}

		// Token: 0x0603180F RID: 202767 RVA: 0x00B79C27 File Offset: 0x00B77E27
		private void OnToggleUp(MediumItemGridExtendCallback _)
		{
			Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> onPointUpCb = this.OnPointUpCb;
			if (onPointUpCb == null)
			{
				return;
			}
			onPointUpCb(this, this.TrapData);
		}

		// Token: 0x06031810 RID: 202768 RVA: 0x00B79C40 File Offset: 0x00B77E40
		public void UpdateState()
		{
			this.UpdateInfo();
		}

		// Token: 0x0401A767 RID: 108391
		private TrapDefenseBuildingDevelopItemData TrapData;

		// Token: 0x0401A768 RID: 108392
		public Action<TrapDefenseBuildingDevelopItemData> OnItemClickCallback;

		// Token: 0x0401A769 RID: 108393
		public Func<TrapDefenseBuildingDevelopItemData, bool> CanExecuteChangeCb;

		// Token: 0x0401A76A RID: 108394
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointDownCb;

		// Token: 0x0401A76B RID: 108395
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointUpCb;
	}
}
