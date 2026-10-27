using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E12 RID: 11794
public class BulletAdditionInfo
{
	// Token: 0x1700226D RID: 8813
	// (get) Token: 0x06018CF2 RID: 101618 RVA: 0x0065BF4A File Offset: 0x0065A14A
	public bool Valid
	{
		get
		{
			return this.ValidInternal;
		}
	}

	// Token: 0x06018CF3 RID: 101619 RVA: 0x0065BF52 File Offset: 0x0065A152
	public void Clear()
	{
		this.ValidInternal = false;
		this.SizeScale.Reset();
		this.IntervalScale = 0f;
		this.DurationAddition = 0f;
	}

	// Token: 0x06018CF4 RID: 101620 RVA: 0x0065BF7C File Offset: 0x0065A17C
	public void Init()
	{
		this.ValidInternal = true;
	}

	// Token: 0x0400B9E3 RID: 47587
	[Nullable(1)]
	public readonly Vector SizeScale = Vector.Create();

	// Token: 0x0400B9E4 RID: 47588
	public float IntervalScale;

	// Token: 0x0400B9E5 RID: 47589
	public float DurationAddition;

	// Token: 0x0400B9E6 RID: 47590
	private bool ValidInternal;
}
