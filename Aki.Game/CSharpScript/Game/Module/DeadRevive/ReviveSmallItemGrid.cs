using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005ACB RID: 23243
	public class ReviveSmallItemGrid : SmallItemGrid
	{
		// Token: 0x0603ADD6 RID: 241110 RVA: 0x00E083EC File Offset: 0x00E065EC
		public void Refresh(int itemId, int itemCount)
		{
			this.ItemId = new int?(itemId);
			int num = (int)BuffItemModel.Instance.GetBuffItemRemainCdTime(itemId);
			PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
			propSmallItemGrid.Data = itemId;
			propSmallItemGrid.ItemConfigId = new int?(itemId);
			string bottomText;
			if (itemCount <= 0)
			{
				bottomText = "";
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(itemCount);
				bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			propSmallItemGrid.BottomText = bottomText;
			propSmallItemGrid.CoolDownTime = new int?(num);
			PropSmallItemGrid parameters = propSmallItemGrid;
			base.Apply<PropSmallItemGrid>(parameters);
			this.RemainCdTime = num;
			this.TotalCdTime = (int)BuffItemModel.Instance.GetBuffItemTotalCdTime(this.ItemId.Value);
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			}
			this.Timer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnCoolDownRefresh), 20f, 1f, null, null, true);
		}

		// Token: 0x0603ADD7 RID: 241111 RVA: 0x00E084D4 File Offset: 0x00E066D4
		public void RefreshCoolDown()
		{
			double buffItemRemainCdTime = BuffItemModel.Instance.GetBuffItemRemainCdTime(this.ItemId.Value);
			base.SetCoolDown(new float?((float)buffItemRemainCdTime), new float?((float)this.TotalCdTime));
		}

		// Token: 0x0603ADD8 RID: 241112 RVA: 0x00E08510 File Offset: 0x00E06710
		private void OnCoolDownRefresh(float _)
		{
			if (this.RemainCdTime <= 0)
			{
				if (this.Timer != null)
				{
					TimerSystem.GameplayTimeInstance.Remove(this.Timer);
				}
				this.Timer = null;
				return;
			}
			this.RefreshCoolDown();
			this.RemainCdTime = this.RemainCdTime;
		}

		// Token: 0x0603ADD9 RID: 241113 RVA: 0x00E0854E File Offset: 0x00E0674E
		protected void OnDestroyed()
		{
			this.ItemId = null;
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			}
			this.Timer = null;
			this.RemainCdTime = -1;
			this.TotalCdTime = 1;
		}

		// Token: 0x0401EB81 RID: 125825
		public int? ItemId;

		// Token: 0x0401EB82 RID: 125826
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401EB83 RID: 125827
		private int RemainCdTime = -1;

		// Token: 0x0401EB84 RID: 125828
		private int TotalCdTime = 1;
	}
}
