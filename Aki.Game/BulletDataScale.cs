using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DB2 RID: 11698
[NullableContext(1)]
[Nullable(0)]
public class BulletDataScale
{
	// Token: 0x170021A8 RID: 8616
	// (get) Token: 0x06018998 RID: 100760 RVA: 0x00649603 File Offset: 0x00647803
	public Vector SizeScale
	{
		get
		{
			if (this.SizeScaleInternal == null)
			{
				this.SizeScaleInternal = Vector.Create(this.Data.缩放倍率);
			}
			return this.SizeScaleInternal;
		}
	}

	// Token: 0x170021A9 RID: 8617
	// (get) Token: 0x06018999 RID: 100761 RVA: 0x0064962E File Offset: 0x0064782E
	[Nullable(2)]
	public UCurveVector ScaleCurve
	{
		[NullableContext(2)]
		get
		{
			if (!this.ScaleCurveInit)
			{
				this.ScaleCurveInit = true;
				this.ScaleCurveInternal = this.Data.缩放倍率曲线;
			}
			return this.ScaleCurveInternal;
		}
	}

	// Token: 0x170021AA RID: 8618
	// (get) Token: 0x0601899A RID: 100762 RVA: 0x00649656 File Offset: 0x00647856
	public bool ShapeSwitch
	{
		get
		{
			if (this.ShapeSwitchInternal == null)
			{
				this.ShapeSwitchInternal = new bool?(this.Data.特定形状开关);
			}
			return this.ShapeSwitchInternal.Value;
		}
	}

	// Token: 0x0601899B RID: 100763 RVA: 0x00649686 File Offset: 0x00647886
	public BulletDataScale(SReBulletDataScale data)
	{
		this.Data = data;
	}

	// Token: 0x0601899C RID: 100764 RVA: 0x00649695 File Offset: 0x00647895
	public bool Preload()
	{
		Vector sizeScale = this.SizeScale;
		UCurveVector scaleCurve = this.ScaleCurve;
		return true;
	}

	// Token: 0x0400B6C3 RID: 46787
	private readonly SReBulletDataScale Data;

	// Token: 0x0400B6C4 RID: 46788
	[Nullable(2)]
	private Vector SizeScaleInternal;

	// Token: 0x0400B6C5 RID: 46789
	[Nullable(2)]
	private UCurveVector ScaleCurveInternal;

	// Token: 0x0400B6C6 RID: 46790
	private bool ScaleCurveInit;

	// Token: 0x0400B6C7 RID: 46791
	private bool? ShapeSwitchInternal;
}
