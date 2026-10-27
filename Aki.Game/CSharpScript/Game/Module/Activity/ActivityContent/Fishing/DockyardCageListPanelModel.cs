using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200659D RID: 26013
	public class DockyardCageListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x06041398 RID: 267160 RVA: 0x00FCE504 File Offset: 0x00FCC704
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText3";
			base.ComponentData.HelpBtnId = 193;
			DockyardCageData cageDataByConfigId = FishingModel.Instance.GetCageDataByConfigId(this.ConfigId);
			this.MaxCount = ((cageDataByConfigId != null) ? cageDataByConfigId.Data.MaxCount : 0);
			base.ComponentData.GetCountText = (() => base.ShowItemList.Count.ToString() + "/" + this.MaxCount.ToString());
			if (this.GetShowItemList().Count < this.MaxCount)
			{
				double shipCageNextHarvestTimeStamp = (double)FishingModel.Instance.GetShipCageNextHarvestTimeStamp(this.ConfigId);
				double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
				double remainTime = (shipCageNextHarvestTimeStamp - serverTimeStamp) / (double)TimeUtil.Instance.InverseMillisecond;
				string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat4(remainTime).CountDownText;
				base.ComponentData.TimeText = countDownText;
			}
		}

		// Token: 0x06041399 RID: 267161 RVA: 0x00FCE5CB File Offset: 0x00FCC7CB
		public void Init(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x0604139A RID: 267162 RVA: 0x00FCE5D4 File Offset: 0x00FCC7D4
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return FishingModel.Instance.GetCageDataList(this.ConfigId);
		}

		// Token: 0x0604139B RID: 267163 RVA: 0x00FCE5E8 File Offset: 0x00FCC7E8
		protected override bool CheckOtherCanDragCondition(bool fromDragResult)
		{
			if (base.CheckSelectedInList())
			{
				return true;
			}
			bool flag = base.ShowItemList.Count < this.MaxCount;
			if (fromDragResult && !flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_CageFull", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x04021F4C RID: 139084
		private int ConfigId;

		// Token: 0x04021F4D RID: 139085
		private int MaxCount;
	}
}
