using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DB0 RID: 11696
[NullableContext(1)]
[Nullable(0)]
public class BulletDataObstacle
{
	// Token: 0x17002197 RID: 8599
	// (get) Token: 0x06018983 RID: 100739 RVA: 0x006490CE File Offset: 0x006472CE
	public Vector Center
	{
		get
		{
			if (this.CenterInternal == null)
			{
				this.CenterInternal = Vector.Create(this.Data.检测位置);
			}
			return this.CenterInternal;
		}
	}

	// Token: 0x17002198 RID: 8600
	// (get) Token: 0x06018984 RID: 100740 RVA: 0x006490F9 File Offset: 0x006472F9
	public float Radius
	{
		get
		{
			if (this.RadiusInternal == null)
			{
				this.RadiusInternal = new float?(this.Data.检测距离);
			}
			return this.RadiusInternal.Value;
		}
	}

	// Token: 0x06018985 RID: 100741 RVA: 0x00649129 File Offset: 0x00647329
	public BulletDataObstacle(SReBulletDataObstacles data)
	{
		this.Data = data;
	}

	// Token: 0x06018986 RID: 100742 RVA: 0x00649138 File Offset: 0x00647338
	public bool Preload()
	{
		Vector center = this.Center;
		float radius = this.Radius;
		return true;
	}

	// Token: 0x0400B6B0 RID: 46768
	private readonly SReBulletDataObstacles Data;

	// Token: 0x0400B6B1 RID: 46769
	[Nullable(2)]
	private Vector CenterInternal;

	// Token: 0x0400B6B2 RID: 46770
	private float? RadiusInternal;
}
