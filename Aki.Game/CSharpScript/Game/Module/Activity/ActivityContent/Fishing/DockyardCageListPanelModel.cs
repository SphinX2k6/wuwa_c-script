using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200551B RID: 21787
	public class DockyardCageListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x0603605D RID: 221277 RVA: 0x00F15518 File Offset: 0x00F13718
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

		// Token: 0x0603605E RID: 221278 RVA: 0x00F155DF File Offset: 0x00F137DF
		public void Init(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x0603605F RID: 221279 RVA: 0x00F155E8 File Offset: 0x00F137E8
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return FishingModel.Instance.GetCageDataList(this.ConfigId);
		}

		// Token: 0x06036060 RID: 221280 RVA: 0x00F155FC File Offset: 0x00F137FC
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

		// Token: 0x0401C87D RID: 116861
		private int ConfigId;

		// Token: 0x0401C87E RID: 116862
		private int MaxCount;
	}
}
