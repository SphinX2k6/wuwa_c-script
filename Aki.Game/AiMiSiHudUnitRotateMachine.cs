using System;

// Token: 0x02001F43 RID: 8003
public class AiMiSiHudUnitRotateMachine
{
	// Token: 0x0600F761 RID: 63329 RVA: 0x003BD278 File Offset: 0x003BB478
	public bool Update(float delta, double yaw)
	{
		if (!this.IsInit)
		{
			this.LastYaw = yaw;
			this.IsInit = true;
			return false;
		}
		double num = yaw - this.LastYaw;
		if (num < -180.0)
		{
			num += 360.0;
		}
		else if (num > 180.0)
		{
			num -= 360.0;
		}
		this.LastYaw = yaw;
		double num2 = num / (double)delta;
		if (num2 > this.YawSpeedMin)
		{
			this.SetTargetDir(1);
		}
		else if (num2 < -this.YawSpeedMin)
		{
			this.SetTargetDir(-1);
		}
		else
		{
			this.SetTargetDir(0);
		}
		double curValue = this.CurValue;
		this.UpdateAnim(delta);
		return curValue != this.CurValue;
	}

	// Token: 0x0600F762 RID: 63330 RVA: 0x003BD328 File Offset: 0x003BB528
	private void SetTargetDir(int dir)
	{
		this.TargetDir = dir;
	}

	// Token: 0x0600F763 RID: 63331 RVA: 0x003BD334 File Offset: 0x003BB534
	private void UpdateAnim(float delta)
	{
		if (this.NextChangeDirCountdown > 0f)
		{
			this.NextChangeDirCountdown -= delta;
			if (this.NextChangeDirCountdown <= 0f)
			{
				this.NextChangeDirCountdown = 0f;
			}
		}
		else if (this.TargetDir != this.CurDir)
		{
			this.CurDir = this.TargetDir;
			this.NextChangeDirCountdown = (float)this.Countdown;
		}
		if (this.CurValue == (double)this.CurDir)
		{
			return;
		}
		if (this.CurValue < (double)this.CurDir)
		{
			this.CurValue += this.Speed * (double)delta;
			if (this.CurValue > (double)this.CurDir)
			{
				this.CurValue = (double)this.CurDir;
				return;
			}
		}
		else
		{
			this.CurValue -= this.Speed * (double)delta;
			if (this.CurValue < (double)this.CurDir)
			{
				this.CurValue = (double)this.CurDir;
			}
		}
	}

	// Token: 0x040072AE RID: 29358
	public double YawSpeedMin = 0.02;

	// Token: 0x040072AF RID: 29359
	public double Speed = 0.002;

	// Token: 0x040072B0 RID: 29360
	public int Countdown = 500;

	// Token: 0x040072B1 RID: 29361
	private double LastYaw;

	// Token: 0x040072B2 RID: 29362
	private bool IsInit;

	// Token: 0x040072B3 RID: 29363
	private int TargetDir;

	// Token: 0x040072B4 RID: 29364
	private int CurDir;

	// Token: 0x040072B5 RID: 29365
	private float NextChangeDirCountdown;

	// Token: 0x040072B6 RID: 29366
	public double CurValue;
}
