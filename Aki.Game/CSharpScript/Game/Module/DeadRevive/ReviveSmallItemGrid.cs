using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AAC RID: 19116
	public class ReviveSmallItemGrid : SmallItemGrid
	{
		// Token: 0x0602FD48 RID: 195912 RVA: 0x00D590CC File Offset: 0x00D572CC
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

		// Token: 0x0602FD49 RID: 195913 RVA: 0x00D591B4 File Offset: 0x00D573B4
		public void RefreshCoolDown()
		{
			double buffItemRemainCdTime = BuffItemModel.Instance.GetBuffItemRemainCdTime(this.ItemId.Value);
			base.SetCoolDown(new float?((float)buffItemRemainCdTime), new float?((float)this.TotalCdTime));
		}

		// Token: 0x0602FD4A RID: 195914 RVA: 0x00D591F0 File Offset: 0x00D573F0
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

		// Token: 0x0602FD4B RID: 195915 RVA: 0x00D5922E File Offset: 0x00D5742E
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

		// Token: 0x0401963D RID: 103997
		public int? ItemId;

		// Token: 0x0401963E RID: 103998
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401963F RID: 103999
		private int RemainCdTime = -1;

		// Token: 0x04019640 RID: 104000
		private int TotalCdTime = 1;
	}
}
