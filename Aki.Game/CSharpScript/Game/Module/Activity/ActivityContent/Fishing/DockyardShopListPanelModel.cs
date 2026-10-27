using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065BE RID: 26046
	public class DockyardShopListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x06041551 RID: 267601 RVA: 0x00FD4F6F File Offset: 0x00FD316F
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText1";
			base.ComponentData.HelpBtnId = 194;
			this.MaxCount = DockyardModel.Instance.TrawlSize;
		}

		// Token: 0x06041552 RID: 267602 RVA: 0x00FD4FA1 File Offset: 0x00FD31A1
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetTrawlDataList();
		}

		// Token: 0x06041553 RID: 267603 RVA: 0x00FD4FB0 File Offset: 0x00FD31B0
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

		// Token: 0x04021FFE RID: 139262
		protected int MaxCount;
	}
}
