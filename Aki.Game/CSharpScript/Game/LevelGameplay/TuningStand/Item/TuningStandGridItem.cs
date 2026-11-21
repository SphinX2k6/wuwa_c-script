using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Item
{
	// Token: 0x02005B32 RID: 23346
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TuningStandGridItem : GridProxyAbstract<TuningGridData>
	{
		// Token: 0x060396DA RID: 235226 RVA: 0x0101D985 File Offset: 0x0101BB85
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

		// Token: 0x060396DB RID: 235227 RVA: 0x0101D9B8 File Offset: 0x0101BBB8
		public UniTask CreateGrid()
		{
			TuningStandGridItem.<CreateGrid>d__4 <CreateGrid>d__;
			<CreateGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGrid>d__.<>4__this = this;
			<CreateGrid>d__.<>1__state = -1;
			<CreateGrid>d__.<>t__builder.Start<TuningStandGridItem.<CreateGrid>d__4>(ref <CreateGrid>d__);
			return <CreateGrid>d__.<>t__builder.Task;
		}

		// Token: 0x060396DC RID: 235228 RVA: 0x0101D9FB File Offset: 0x0101BBFB
		public void RefreshGrid()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.OnRefreshGrid();
		}

		// Token: 0x060396DD RID: 235229 RVA: 0x0101DA16 File Offset: 0x0101BC16
		public TuningStandGridBase GetGrid()
		{
			return this.Grid;
		}

		// Token: 0x060396DE RID: 235230 RVA: 0x0101DA1E File Offset: 0x0101BC1E
		private void ResetGrid()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.ResetGrid(this.Data);
		}

		// Token: 0x060396DF RID: 235231 RVA: 0x0101DA40 File Offset: 0x0101BC40
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

		// Token: 0x060396E0 RID: 235232 RVA: 0x0101DB31 File Offset: 0x0101BD31
		public void OnLinkMiss(bool isEnd)
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.OnLinkMiss(isEnd);
		}

		// Token: 0x060396E1 RID: 235233 RVA: 0x0101DB4D File Offset: 0x0101BD4D
		public void StartRevolving()
		{
			if (this.Data.GridType == ETuningStandGridType.Empty)
			{
				return;
			}
			this.Grid.StartRevolving();
		}

		// Token: 0x0401E4B9 RID: 124089
		protected TuningGridData Data;

		// Token: 0x0401E4BA RID: 124090
		protected TuningStandGridBase Grid;

		// Token: 0x0401E4BB RID: 124091
		protected TimerHandle TimeHandle;
	}
}
