using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9A RID: 19098
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopDragDataItem : CommonDragLogicDataItem<TrapDefenseBuildingDevelopItemData>
	{
		// Token: 0x060317FF RID: 202751 RVA: 0x00B798BD File Offset: 0x00B77ABD
		public override bool CheckIfCanDrag()
		{
			return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckIfCanDrag();
		}

		// Token: 0x06031800 RID: 202752 RVA: 0x00B798CE File Offset: 0x00B77ACE
		public override bool CheckIfCurrentDragIndex(int index)
		{
			return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckIfCurrentDragIndex(index);
		}

		// Token: 0x06031801 RID: 202753 RVA: 0x00B798E0 File Offset: 0x00B77AE0
		public override void SetCurrentDragIndex(int index)
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetCurrentDragIndex(index);
		}

		// Token: 0x06031802 RID: 202754 RVA: 0x00B798F2 File Offset: 0x00B77AF2
		public override void ClearCurrentDragIndex()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.ClearCurrentDragIndex();
		}

		// Token: 0x06031803 RID: 202755 RVA: 0x00B79903 File Offset: 0x00B77B03
		public override float GetClickTime()
		{
			if (this.ClickTime == -1f)
			{
				this.ClickTime = (float)TrapDefenseConfig.Instance.GetDragItemClickTime();
			}
			return this.ClickTime;
		}

		// Token: 0x0401A766 RID: 108390
		private float ClickTime = -1f;
	}
}
