using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A42 RID: 14914
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopDragDataItem : CommonDragLogicDataItem<TrapDefenseBuildingDevelopItemData>
	{
		// Token: 0x0602658F RID: 157071 RVA: 0x00ABD871 File Offset: 0x00ABBA71
		public override bool CheckIfCanDrag()
		{
			return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckIfCanDrag();
		}

		// Token: 0x06026590 RID: 157072 RVA: 0x00ABD882 File Offset: 0x00ABBA82
		public override bool CheckIfCurrentDragIndex(int index)
		{
			return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckIfCurrentDragIndex(index);
		}

		// Token: 0x06026591 RID: 157073 RVA: 0x00ABD894 File Offset: 0x00ABBA94
		public override void SetCurrentDragIndex(int index)
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.SetCurrentDragIndex(index);
		}

		// Token: 0x06026592 RID: 157074 RVA: 0x00ABD8A6 File Offset: 0x00ABBAA6
		public override void ClearCurrentDragIndex()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.ClearCurrentDragIndex();
		}

		// Token: 0x06026593 RID: 157075 RVA: 0x00ABD8B7 File Offset: 0x00ABBAB7
		public override float GetClickTime()
		{
			if (this.ClickTime == -1f)
			{
				this.ClickTime = (float)TrapDefenseConfig.Instance.GetDragItemClickTime();
			}
			return this.ClickTime;
		}

		// Token: 0x040150B8 RID: 86200
		private float ClickTime = -1f;
	}
}
