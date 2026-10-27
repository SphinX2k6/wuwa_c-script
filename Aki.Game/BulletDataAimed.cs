using System;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DA8 RID: 11688
public class BulletDataAimed
{
	// Token: 0x17002123 RID: 8483
	// (get) Token: 0x060188F6 RID: 100598 RVA: 0x00646D6E File Offset: 0x00644F6E
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

	// Token: 0x17002124 RID: 8484
	// (get) Token: 0x060188F7 RID: 100599 RVA: 0x00646D9E File Offset: 0x00644F9E
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

	// Token: 0x17002125 RID: 8485
	// (get) Token: 0x060188F8 RID: 100600 RVA: 0x00646DCE File Offset: 0x00644FCE
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

	// Token: 0x060188F9 RID: 100601 RVA: 0x00646DFE File Offset: 0x00644FFE
	public BulletDataAimed(SReBulletDataAimed data)
	{
		this.Data = data;
	}

	// Token: 0x0400B609 RID: 46601
	private readonly SReBulletDataAimed Data;

	// Token: 0x0400B60A RID: 46602
	private bool? AimedCtrlDirInternal;

	// Token: 0x0400B60B RID: 46603
	private float? AngleOffsetInternal;

	// Token: 0x0400B60C RID: 46604
	private float? DistLimitInternal;
}
