using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005522 RID: 21794
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x0603609B RID: 221339 RVA: 0x00F15FED File Offset: 0x00F141ED
		public void RegisterInteractPanel(DockyardInteractPanelModel interactPanel)
		{
			this.InteractPanelModel = interactPanel;
		}

		// Token: 0x0603609C RID: 221340 RVA: 0x00F15FF6 File Offset: 0x00F141F6
		public override bool IsQuickSellOpen()
		{
			return false;
		}

		// Token: 0x0603609D RID: 221341 RVA: 0x00F15FF9 File Offset: 0x00F141F9
		public override bool GetIsBackToWareHouseOpen()
		{
			return false;
		}

		// Token: 0x0603609E RID: 221342 RVA: 0x00F15FFC File Offset: 0x00F141FC
		public void ShowScrollingTips()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_CantPutDown", Array.Empty<object>());
		}

		// Token: 0x0401C89C RID: 116892
		protected DockyardInteractPanelModel InteractPanelModel;

		// Token: 0x0401C89D RID: 116893
		public int ConfigId;
	}
}
