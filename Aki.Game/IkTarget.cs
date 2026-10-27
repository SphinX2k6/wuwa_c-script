using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E67 RID: 7783
[NullableContext(1)]
[Nullable(0)]
public class IkTarget
{
	// Token: 0x0600EC98 RID: 60568 RVA: 0x00383FC4 File Offset: 0x003821C4
	[NullableContext(2)]
	public IkTarget(Vector location = null, Quat rotation = null, double? alpha = null)
	{
		this.Location = (location ?? Vector.Create(0.0, 0.0, 0.0));
		this.Rotation = (rotation ?? Quat.Create(0.0, 0.0, 0.0, 1.0));
		this.Alpha = alpha.GetValueOrDefault();
	}

	// Token: 0x0600EC99 RID: 60569 RVA: 0x00384088 File Offset: 0x00382288
	[NullableContext(2)]
	public bool Equals(IkTarget inB)
	{
		if (inB != null)
		{
			return this.Location.Equals(inB.Location, 9.999999747378752E-05) && this.Rotation.Equals(inB.Rotation, 0.0001f) && this.Alpha == inB.Alpha;
		}
		return this.Alpha == 0.0;
	}

	// Token: 0x0600EC9A RID: 60570 RVA: 0x003840F0 File Offset: 0x003822F0
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

	// Token: 0x0600EC9B RID: 60571 RVA: 0x0038413E File Offset: 0x0038233E
	public FIKTarget ToUeIkTarget()
	{
		FIKTarget cacheUeIkTarget = this.CacheUeIkTarget;
		cacheUeIkTarget.Location = this.Location.ToUeVectorOld();
		cacheUeIkTarget.Rotation = this.Rotation.ToUeQuat();
		cacheUeIkTarget.Alpha = (float)this.Alpha;
		return cacheUeIkTarget;
	}

	// Token: 0x04006DEC RID: 28140
	public Vector Location = Vector.Create();

	// Token: 0x04006DED RID: 28141
	public Quat Rotation = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04006DEE RID: 28142
	public double Alpha;

	// Token: 0x04006DEF RID: 28143
	private readonly FIKTarget CacheUeIkTarget = new FIKTarget();
}
