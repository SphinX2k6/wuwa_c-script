using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200553C RID: 21820
	public class DockyardShopListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x06036216 RID: 221718 RVA: 0x00F1BFAB File Offset: 0x00F1A1AB
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText1";
			base.ComponentData.HelpBtnId = 194;
			this.MaxCount = DockyardModel.Instance.TrawlSize;
		}

		// Token: 0x06036217 RID: 221719 RVA: 0x00F1BFDD File Offset: 0x00F1A1DD
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetTrawlDataList();
		}

		// Token: 0x06036218 RID: 221720 RVA: 0x00F1BFEC File Offset: 0x00F1A1EC
		protected override bool CheckOtherCanDragCondition(bool fromDragResult)
		{
			if (base.CheckSelectedInList())
			{
				return true;
			}
			bool flag = base.ShowItemList.Count < this.MaxCount;
			if (fromDragResult && !flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_DraftFull", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0401C92F RID: 117039
		protected int MaxCount;
	}
}
