using System;
using System.Runtime.CompilerServices;

// Token: 0x020007DD RID: 2013
public class BusinessTipsCurrencyItem : CommonCurrencyItem
{
	// Token: 0x06005BC7 RID: 23495 RVA: 0x001D9BDC File Offset: 0x001D7DDC
	public override void AddEventListener()
	{
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x001D9BDE File Offset: 0x001D7DDE
	public override void RemoveEventListener()
	{
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x001D9BE0 File Offset: 0x001D7DE0
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveTimer();
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x001D9BF0 File Offset: 0x001D7DF0
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

	// Token: 0x06005BCB RID: 23499 RVA: 0x001D9C65 File Offset: 0x001D7E65
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

	// Token: 0x04003D4F RID: 15695
	[Nullable(2)]
	private TimerHandle RefreshTimer;
}
