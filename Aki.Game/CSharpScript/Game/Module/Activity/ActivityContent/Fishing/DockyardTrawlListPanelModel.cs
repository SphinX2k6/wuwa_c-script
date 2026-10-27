using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D0 RID: 26064
	public class DockyardTrawlListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x060415E8 RID: 267752 RVA: 0x00FD75B4 File Offset: 0x00FD57B4
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText5";
			base.ComponentData.HelpBtnId = 194;
			this.MaxCount = DockyardModel.Instance.TrawlSize;
		}

		// Token: 0x060415E9 RID: 267753 RVA: 0x00FD75E6 File Offset: 0x00FD57E6
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetTrawlDataList();
		}

		// Token: 0x060415EA RID: 267754 RVA: 0x00FD75F4 File Offset: 0x00FD57F4
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

		// Token: 0x04022024 RID: 139300
		protected int MaxCount;
	}
}
