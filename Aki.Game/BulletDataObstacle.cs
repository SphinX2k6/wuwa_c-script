using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x0200230A RID: 8970
[NullableContext(1)]
[Nullable(0)]
public class BulletDataObstacle
{
	// Token: 0x170021F3 RID: 8691
	// (get) Token: 0x0601622B RID: 90667 RVA: 0x0066EEBE File Offset: 0x0066D0BE
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

	// Token: 0x170021F4 RID: 8692
	// (get) Token: 0x0601622C RID: 90668 RVA: 0x0066EEE9 File Offset: 0x0066D0E9
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

	// Token: 0x0601622D RID: 90669 RVA: 0x0066EF19 File Offset: 0x0066D119
	public BulletDataObstacle(SReBulletDataObstacles data)
	{
		this.Data = data;
	}

	// Token: 0x0601622E RID: 90670 RVA: 0x0066EF28 File Offset: 0x0066D128
	public bool Preload()
	{
		Vector center = this.Center;
		float radius = this.Radius;
		return true;
	}

	// Token: 0x0400BA2A RID: 47658
	private readonly SReBulletDataObstacles Data;

	// Token: 0x0400BA2B RID: 47659
	[Nullable(2)]
	private Vector CenterInternal;

	// Token: 0x0400BA2C RID: 47660
	private float? RadiusInternal;
}
