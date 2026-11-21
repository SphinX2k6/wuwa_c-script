using System;

// Token: 0x02001405 RID: 5125
public class AiMiSiHudUnitRotateMachine
{
	// Token: 0x0600CB80 RID: 52096 RVA: 0x003C8D64 File Offset: 0x003C6F64
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

	// Token: 0x0600CB81 RID: 52097 RVA: 0x003C8E14 File Offset: 0x003C7014
	private void SetTargetDir(int dir)
	{
		this.TargetDir = dir;
	}

	// Token: 0x0600CB82 RID: 52098 RVA: 0x003C8E20 File Offset: 0x003C7020
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

	// Token: 0x0400738F RID: 29583
	public double YawSpeedMin = 0.02;

	// Token: 0x04007390 RID: 29584
	public double Speed = 0.002;

	// Token: 0x04007391 RID: 29585
	public int Countdown = 500;

	// Token: 0x04007392 RID: 29586
	private double LastYaw;

	// Token: 0x04007393 RID: 29587
	private bool IsInit;

	// Token: 0x04007394 RID: 29588
	private int TargetDir;

	// Token: 0x04007395 RID: 29589
	private int CurDir;

	// Token: 0x04007396 RID: 29590
	private float NextChangeDirCountdown;

	// Token: 0x04007397 RID: 29591
	public double CurValue;
}
