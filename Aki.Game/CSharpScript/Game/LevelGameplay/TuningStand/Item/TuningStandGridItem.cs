using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x020069D6 RID: 27094
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TuningStandGridItem : GridProxyAbstract<TuningGridData>
	{
		// Token: 0x0604369E RID: 276126 RVA: 0x010794D1 File Offset: 0x010776D1
		[NullableContext(1)]
		public override void Refresh(TuningGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			if (this.Grid != null)
			{
				this.Grid.SetUiActive(false);
				this.ResetGrid();
				this.PlayShowAnim();
			}
		}

		// Token: 0x0604369F RID: 276127 RVA: 0x01079504 File Offset: 0x01077704
		public UniTask CreateGrid()
		{
			TuningStandGridItem.<CreateGrid>d__4 <CreateGrid>d__;
			<CreateGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGrid>d__.<>4__this = this;
			<CreateGrid>d__.<>1__state = -1;
			<CreateGrid>d__.<>t__builder.Start<TuningStandGridItem.<CreateGrid>d__4>(ref <CreateGrid>d__);
			return <CreateGrid>d__.<>t__builder.Task;
		}

		// Token: 0x060436A0 RID: 276128 RVA: 0x01079547 File Offset: 0x01077747
		public void RefreshGrid()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.OnRefreshGrid();
		}

		// Token: 0x060436A1 RID: 276129 RVA: 0x01079562 File Offset: 0x01077762
		public TuningStandGridBase GetGrid()
		{
			return this.Grid;
		}

		// Token: 0x060436A2 RID: 276130 RVA: 0x0107956A File Offset: 0x0107776A
		private void ResetGrid()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.ResetGrid(this.Data);
		}

		// Token: 0x060436A3 RID: 276131 RVA: 0x0107958C File Offset: 0x0107778C
		public void PlayShowAnim()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			if (this.TimeHandle != null)
			{
				if (TimerSystem.Instance.Has(this.TimeHandle))
				{
					TimerSystem.Instance.Remove(this.TimeHandle);
				}
				this.TimeHandle = null;
			}
			double dist = this.Data.GetCenterDistance();
			if (dist == 0.0)
			{
				this.Grid.SetUiActive(true);
				this.Grid.PlayInAnim(0f);
				return;
			}
			double num = 0.0;
			int num2 = 1;
			while ((double)num2 <= dist)
			{
				num += (double)(330 / num2);
				num2++;
			}
			this.TimeHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Grid.SetUiActive(true);
				this.Grid.PlayInAnim((float)dist);
			}, (float)((long)(num / 2.0)), null, null, true, 1f);
		}

		// Token: 0x060436A4 RID: 276132 RVA: 0x0107967D File Offset: 0x0107787D
		public void OnLinkMiss(bool isEnd)
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.OnLinkMiss(isEnd);
		}

		// Token: 0x060436A5 RID: 276133 RVA: 0x01079699 File Offset: 0x01077899
		public void StartRevolving()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.StartRevolving();
		}

		// Token: 0x040232C9 RID: 144073
		protected TuningGridData Data;

		// Token: 0x040232CA RID: 144074
		protected TuningStandGridBase Grid;

		// Token: 0x040232CB RID: 144075
		protected TimerHandle TimeHandle;
	}
}
