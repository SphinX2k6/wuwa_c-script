using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A43 RID: 14915
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopTypeGridItem : LoopScrollMediumItemGrid<TrapDefenseBuildingDevelopItemData>
	{
		// Token: 0x06026595 RID: 157077 RVA: 0x00ABD8F0 File Offset: 0x00ABBAF0
		protected override void OnStart()
		{
			base.BindOnExtendTogglePress(new Action<MediumItemGridExtendCallback>(this.OnToggleDown));
			base.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnToggleUp));
		}

		// Token: 0x06026596 RID: 157078 RVA: 0x00ABD916 File Offset: 0x00ABBB16
		protected override void OnRefresh(TrapDefenseBuildingDevelopItemData data, bool isSelected, int gridIndex)
		{
			this.TrapData = data;
			this.SetSelected(isSelected, true);
			this.UpdateInfo();
		}

		// Token: 0x06026597 RID: 157079 RVA: 0x00ABD930 File Offset: 0x00ABBB30
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

		// Token: 0x06026598 RID: 157080 RVA: 0x00ABDB0F File Offset: 0x00ABBD0F
		public void OnForceSelected()
		{
			if (TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetOrganClicked(this.TrapData))
			{
				this.UpdateState();
			}
			this.SetSelected(true, true);
		}

		// Token: 0x06026599 RID: 157081 RVA: 0x00ABDB36 File Offset: 0x00ABBD36
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

		// Token: 0x0602659A RID: 157082 RVA: 0x00ABDB76 File Offset: 0x00ABBD76
		protected override bool OnCanExecuteChange()
		{
			return this.CanExecuteChangeCb == null || this.CanExecuteChangeCb(this.TrapData);
		}

		// Token: 0x0602659B RID: 157083 RVA: 0x00ABDB93 File Offset: 0x00ABBD93
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0602659C RID: 157084 RVA: 0x00ABDB9D File Offset: 0x00ABBD9D
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602659D RID: 157085 RVA: 0x00ABDB9F File Offset: 0x00ABBD9F
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

		// Token: 0x0602659E RID: 157086 RVA: 0x00ABDBC2 File Offset: 0x00ABBDC2
		private void OnToggleDown(MediumItemGridExtendCallback _)
		{
			Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> onPointDownCb = this.OnPointDownCb;
			if (onPointDownCb == null)
			{
				return;
			}
			onPointDownCb(this, this.TrapData);
		}

		// Token: 0x0602659F RID: 157087 RVA: 0x00ABDBDB File Offset: 0x00ABBDDB
		private void OnToggleUp(MediumItemGridExtendCallback _)
		{
			Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> onPointUpCb = this.OnPointUpCb;
			if (onPointUpCb == null)
			{
				return;
			}
			onPointUpCb(this, this.TrapData);
		}

		// Token: 0x060265A0 RID: 157088 RVA: 0x00ABDBF4 File Offset: 0x00ABBDF4
		public void UpdateState()
		{
			this.UpdateInfo();
		}

		// Token: 0x040150B9 RID: 86201
		private TrapDefenseBuildingDevelopItemData TrapData;

		// Token: 0x040150BA RID: 86202
		public Action<TrapDefenseBuildingDevelopItemData> OnItemClickCallback;

		// Token: 0x040150BB RID: 86203
		public Func<TrapDefenseBuildingDevelopItemData, bool> CanExecuteChangeCb;

		// Token: 0x040150BC RID: 86204
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointDownCb;

		// Token: 0x040150BD RID: 86205
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointUpCb;
	}
}
