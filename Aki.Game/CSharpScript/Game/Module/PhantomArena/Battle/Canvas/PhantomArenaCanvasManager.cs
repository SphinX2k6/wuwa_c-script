using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Canvas
{
	// Token: 0x02004297 RID: 17047
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaCanvasManager
	{
		// Token: 0x0602B239 RID: 176697 RVA: 0x00C20197 File Offset: 0x00C1E397
		public void AddAreaCanvas(IAreaCanvas areaCanvas)
		{
			this.AreaCanvasList.Add(areaCanvas);
		}

		// Token: 0x0602B23A RID: 176698 RVA: 0x00C201A5 File Offset: 0x00C1E3A5
		public void ClearAreaCanvas()
		{
			this.AreaCanvasList = new List<IAreaCanvas>();
		}

		// Token: 0x0602B23B RID: 176699 RVA: 0x00C201B4 File Offset: 0x00C1E3B4
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

		// Token: 0x0602B23C RID: 176700 RVA: 0x00C20218 File Offset: 0x00C1E418
		public void ResetAreaCanvas()
		{
			foreach (IAreaCanvas areaCanvas in this.AreaCanvasList)
			{
				areaCanvas.CancelSortOrder();
				areaCanvas.ReceiveUiInteract(null);
			}
		}

		// Token: 0x040174E3 RID: 95459
		protected List<IAreaCanvas> AreaCanvasList = new List<IAreaCanvas>();
	}
}
