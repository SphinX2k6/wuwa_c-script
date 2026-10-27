using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D2 RID: 26066
	public class DockyardWareHouseListPanelModel : DockyardItemListPanelModel
	{
		// Token: 0x060415ED RID: 267757 RVA: 0x00FD764A File Offset: 0x00FD584A
		protected override void OnInit()
		{
			base.ComponentData.TitleText = "Fishing_CageText1";
		}

		// Token: 0x060415EE RID: 267758 RVA: 0x00FD765C File Offset: 0x00FD585C
		[NullableContext(1)]
		public override List<DockyardItemBlockOriginalData> GetShowItemList()
		{
			return DockyardModel.Instance.GetWareHouseDataList();
		}
	}
}
