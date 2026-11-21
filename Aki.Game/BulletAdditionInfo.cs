using System;
using System.Runtime.CompilerServices;

// Token: 0x0200236E RID: 9070
public class BulletAdditionInfo
{
	// Token: 0x170022D5 RID: 8917
	// (get) Token: 0x060165B3 RID: 91571 RVA: 0x006820AA File Offset: 0x006802AA
	public bool Valid
	{
		get
		{
			return this.ValidInternal;
		}
	}

	// Token: 0x060165B4 RID: 91572 RVA: 0x006820B2 File Offset: 0x006802B2
	public void Clear()
	{
		this.ValidInternal = false;
		this.SizeScale.Reset();
		this.IntervalScale = 0f;
		this.DurationAddition = 0f;
	}

	// Token: 0x060165B5 RID: 91573 RVA: 0x006820DC File Offset: 0x006802DC
	public void Init()
	{
		this.ValidInternal = true;
	}

	// Token: 0x0400BD71 RID: 48497
	[Nullable(1)]
	public readonly Vector SizeScale = Vector.Create();

	// Token: 0x0400BD72 RID: 48498
	public float IntervalScale;

	// Token: 0x0400BD73 RID: 48499
	public float DurationAddition;

	// Token: 0x0400BD74 RID: 48500
	private bool ValidInternal;
}
