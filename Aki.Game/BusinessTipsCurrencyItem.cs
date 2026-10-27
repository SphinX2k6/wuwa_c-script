using System;
using System.Runtime.CompilerServices;

// Token: 0x02001329 RID: 4905
public class BusinessTipsCurrencyItem : CommonCurrencyItem
{
	// Token: 0x0600882C RID: 34860 RVA: 0x001D0D70 File Offset: 0x001CEF70
	public override void AddEventListener()
	{
	}

	// Token: 0x0600882D RID: 34861 RVA: 0x001D0D72 File Offset: 0x001CEF72
	public override void RemoveEventListener()
	{
	}

	// Token: 0x0600882E RID: 34862 RVA: 0x001D0D74 File Offset: 0x001CEF74
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveTimer();
	}

	// Token: 0x0600882F RID: 34863 RVA: 0x001D0D84 File Offset: 0x001CEF84
	public void PlayReduceTweener(int curValue, int targetValue)
	{
		if (this.RefreshTimer != null)
		{
			this.RemoveTimer();
		}
		float curTime = 0f;
		int lastValue = curValue;
		float tweenTime = 1000f;
		this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
		{
			curTime = Math.Min(curTime + delta, tweenTime);
			int lastValue;
			lastValue += (int)Math.Floor((double)((float)(targetValue - lastValue) * (delta / tweenTime)) * Random.Shared.NextDouble());
			lastValue = lastValue;
			this.RefreshCountText(lastValue.ToString());
			if (curTime >= tweenTime)
			{
				this.RefreshCountText(targetValue.ToString());
				this.RemoveTimer();
			}
		}, 20f, 1f, null, null, true);
	}

	// Token: 0x06008830 RID: 34864 RVA: 0x001D0DF9 File Offset: 0x001CEFF9
	private void RemoveTimer()
	{
		if (this.RefreshTimer == null)
		{
			return;
		}
		if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}
	}

	// Token: 0x04003CB7 RID: 15543
	[Nullable(2)]
	private TimerHandle RefreshTimer;
}
