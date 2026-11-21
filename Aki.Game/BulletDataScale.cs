using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x0200230C RID: 8972
[NullableContext(1)]
[Nullable(0)]
public class BulletDataScale
{
	// Token: 0x17002204 RID: 8708
	// (get) Token: 0x06016240 RID: 90688 RVA: 0x0066F40B File Offset: 0x0066D60B
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

	// Token: 0x17002205 RID: 8709
	// (get) Token: 0x06016241 RID: 90689 RVA: 0x0066F436 File Offset: 0x0066D636
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

	// Token: 0x17002206 RID: 8710
	// (get) Token: 0x06016242 RID: 90690 RVA: 0x0066F45E File Offset: 0x0066D65E
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

	// Token: 0x06016243 RID: 90691 RVA: 0x0066F48E File Offset: 0x0066D68E
	public BulletDataScale(SReBulletDataScale data)
	{
		this.Data = data;
	}

	// Token: 0x06016244 RID: 90692 RVA: 0x0066F49D File Offset: 0x0066D69D
	public bool Preload()
	{
		Vector sizeScale = this.SizeScale;
		UCurveVector scaleCurve = this.ScaleCurve;
		return true;
	}

	// Token: 0x0400BA3D RID: 47677
	private readonly SReBulletDataScale Data;

	// Token: 0x0400BA3E RID: 47678
	[Nullable(2)]
	private Vector SizeScaleInternal;

	// Token: 0x0400BA3F RID: 47679
	[Nullable(2)]
	private UCurveVector ScaleCurveInternal;

	// Token: 0x0400BA40 RID: 47680
	private bool ScaleCurveInit;

	// Token: 0x0400BA41 RID: 47681
	private bool? ShapeSwitchInternal;
}
