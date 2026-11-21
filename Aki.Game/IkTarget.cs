using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001329 RID: 4905
[NullableContext(1)]
[Nullable(0)]
public class IkTarget
{
	// Token: 0x0600C0B7 RID: 49335 RVA: 0x0038FC80 File Offset: 0x0038DE80
	[NullableContext(2)]
	public IkTarget(Vector location = null, Quat rotation = null, double? alpha = null)
	{
		this.Location = (location ?? Vector.Create(0.0, 0.0, 0.0));
		this.Rotation = (rotation ?? Quat.Create(0.0, 0.0, 0.0, 1.0));
		this.Alpha = alpha.GetValueOrDefault();
	}

	// Token: 0x0600C0B8 RID: 49336 RVA: 0x0038FD44 File Offset: 0x0038DF44
	[NullableContext(2)]
	public bool Equals(IkTarget inB)
	{
		if (inB != null)
		{
			return this.Location.Equals(inB.Location, 9.999999747378752E-05) && this.Rotation.Equals(inB.Rotation, 0.0001f) && this.Alpha == inB.Alpha;
		}
		return this.Alpha == 0.0;
	}

	// Token: 0x0600C0B9 RID: 49337 RVA: 0x0038FDAC File Offset: 0x0038DFAC
	[NullableContext(2)]
	public void DeepCopy(IkTarget other)
	{
		if (other != null)
		{
			this.Location.DeepCopy(other.Location);
			this.Rotation.DeepCopy(other.Rotation);
			this.Alpha = other.Alpha;
			return;
		}
		this.Alpha = 0.0;
	}

	// Token: 0x0600C0BA RID: 49338 RVA: 0x0038FDFA File Offset: 0x0038DFFA
	public FIKTarget ToUeIkTarget()
	{
		FIKTarget cacheUeIkTarget = this.CacheUeIkTarget;
		cacheUeIkTarget.Location = this.Location.ToUeVectorOld();
		cacheUeIkTarget.Rotation = this.Rotation.ToUeQuat();
		cacheUeIkTarget.Alpha = (float)this.Alpha;
		return cacheUeIkTarget;
	}

	// Token: 0x04006ECD RID: 28365
	public Vector Location = Vector.Create();

	// Token: 0x04006ECE RID: 28366
	public Quat Rotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006ECF RID: 28367
	public double Alpha;

	// Token: 0x04006ED0 RID: 28368
	private readonly FIKTarget CacheUeIkTarget = new FIKTarget();
}
