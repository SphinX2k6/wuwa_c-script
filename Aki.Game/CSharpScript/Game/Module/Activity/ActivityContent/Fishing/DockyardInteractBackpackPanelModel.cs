using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065A4 RID: 26020
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x060413D6 RID: 267222 RVA: 0x00FCEFE9 File Offset: 0x00FCD1E9
		public void RegisterInteractPanel(DockyardInteractPanelModel interactPanel)
		{
			this.InteractPanelModel = interactPanel;
		}

		// Token: 0x060413D7 RID: 267223 RVA: 0x00FCEFF2 File Offset: 0x00FCD1F2
		public override bool IsQuickSellOpen()
		{
			return false;
		}

		// Token: 0x060413D8 RID: 267224 RVA: 0x00FCEFF5 File Offset: 0x00FCD1F5
		public override bool GetIsBackToWareHouseOpen()
		{
			return false;
		}

		// Token: 0x060413D9 RID: 267225 RVA: 0x00FCEFF8 File Offset: 0x00FCD1F8
		public void ShowScrollingTips()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_CantPutDown", Array.Empty<object>());
		}

		// Token: 0x04021F6B RID: 139115
		protected DockyardInteractPanelModel InteractPanelModel;

		// Token: 0x04021F6C RID: 139116
		public int ConfigId;
	}
}
