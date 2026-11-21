using System;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002302 RID: 8962
public class BulletDataAimed
{
	// Token: 0x1700217E RID: 8574
	// (get) Token: 0x0601619D RID: 90525 RVA: 0x0066CC15 File Offset: 0x0066AE15
	public bool AimedCtrlDir
	{
		get
		{
			if (this.AimedCtrlDirInternal == null)
			{
				this.AimedCtrlDirInternal = new bool?(this.Data.瞄准发射);
			}
			return this.AimedCtrlDirInternal.Value;
		}
	}

	// Token: 0x1700217F RID: 8575
	// (get) Token: 0x0601619E RID: 90526 RVA: 0x0066CC45 File Offset: 0x0066AE45
	public float AngleOffset
	{
		get
		{
			if (this.AngleOffsetInternal == null)
			{
				this.AngleOffsetInternal = new float?(this.Data.瞄准子弹最大偏转角度);
			}
			return this.AngleOffsetInternal.Value;
		}
	}

	// Token: 0x17002180 RID: 8576
	// (get) Token: 0x0601619F RID: 90527 RVA: 0x0066CC75 File Offset: 0x0066AE75
	public float DistLimit
	{
		get
		{
			if (this.DistLimitInternal == null)
			{
				this.DistLimitInternal = new float?(this.Data.瞄准子弹最大射程);
			}
			return this.DistLimitInternal.Value;
		}
	}

	// Token: 0x060161A0 RID: 90528 RVA: 0x0066CCA5 File Offset: 0x0066AEA5
	public BulletDataAimed(SReBulletDataAimed data)
	{
		this.Data = data;
	}

	// Token: 0x0400B982 RID: 47490
	private readonly SReBulletDataAimed Data;

	// Token: 0x0400B983 RID: 47491
	private bool? AimedCtrlDirInternal;

	// Token: 0x0400B984 RID: 47492
	private float? AngleOffsetInternal;

	// Token: 0x0400B985 RID: 47493
	private float? DistLimitInternal;
}
