using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005550 RID: 21840
	public class DockyardWareHouseListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x060362B2 RID: 221874 RVA: 0x00F1E68A File Offset: 0x00F1C88A
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText1";
		}

		// Token: 0x060362B3 RID: 221875 RVA: 0x00F1E69C File Offset: 0x00F1C89C
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetWareHouseDataList();
		}
	}
}
