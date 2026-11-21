using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200554E RID: 21838
	public class DockyardTrawlListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x060362AD RID: 221869 RVA: 0x00F1E5F4 File Offset: 0x00F1C7F4
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText5";
			base.ComponentData.HelpBtnId = 194;
			this.MaxCount = DockyardModel.Instance.TrawlSize;
		}

		// Token: 0x060362AE RID: 221870 RVA: 0x00F1E626 File Offset: 0x00F1C826
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetTrawlDataList();
		}

		// Token: 0x060362AF RID: 221871 RVA: 0x00F1E634 File Offset: 0x00F1C834
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

		// Token: 0x0401C955 RID: 117077
		protected int MaxCount;
	}
}
