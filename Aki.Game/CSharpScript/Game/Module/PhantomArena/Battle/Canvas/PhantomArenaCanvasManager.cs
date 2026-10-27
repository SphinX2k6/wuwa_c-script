using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Canvas
{
	// Token: 0x020052C7 RID: 21191
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCanvasManager
	{
		// Token: 0x0603633E RID: 222014 RVA: 0x00CD2A6F File Offset: 0x00CD0C6F
		public void AddAreaCanvas(IAreaCanvas areaCanvas)
		{
			this.AreaCanvasList.Add(areaCanvas);
		}

		// Token: 0x0603633F RID: 222015 RVA: 0x00CD2A7D File Offset: 0x00CD0C7D
		public void ClearAreaCanvas()
		{
			this.AreaCanvasList = new List<IAreaCanvas>();
		}

		// Token: 0x06036340 RID: 222016 RVA: 0x00CD2A8C File Offset: 0x00CD0C8C
		public void SortOrderAreaCanvas(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo, ISkillInteractMainUiInteract uiInteract)
		{
			foreach (IAreaCanvas areaCanvas in this.AreaCanvasList)
			{
				if (areaCanvas.CheckCanvasSortOrder(tagList, skillTriggerInfo))
				{
					areaCanvas.HandleSortOrder();
					areaCanvas.ReceiveUiInteract(uiInteract);
				}
			}
		}

		// Token: 0x06036341 RID: 222017 RVA: 0x00CD2AF0 File Offset: 0x00CD0CF0
		public void ResetAreaCanvas()
		{
			foreach (IAreaCanvas areaCanvas in this.AreaCanvasList)
			{
				areaCanvas.CancelSortOrder();
				areaCanvas.ReceiveUiInteract(null);
			}
		}

		// Token: 0x0401CAAE RID: 117422
		protected List<IAreaCanvas> AreaCanvasList = new List<IAreaCanvas>();
	}
}
