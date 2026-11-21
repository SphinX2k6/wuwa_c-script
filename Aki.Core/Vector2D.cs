using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FF RID: 255
[NullableContext(1)]
[Nullable(0)]
[Obsolete("手写数学库已废弃，请改用 UnrealEngine.FVector2DDouble")]
public class Vector2D : IVector2D, IClearable, ILogFormattedPrint
{
	// Token: 0x060009AB RID: 2475 RVA: 0x00031820 File Offset: 0x0002FA20
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator FVector2DDouble(Vector2D v)
	{
		if (v != null)
		{
			return new FVector2DDouble(v.X, v.Y);
		}
		return default(FVector2DDouble);
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x0003184B File Offset: 0x0002FA4B
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator Vector2D(FVector2DDouble v)
	{
		return Vector2D.Create(v.X, v.Y);
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x0003185E File Offset: 0x0002FA5E
	public Vector2D()
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00031866 File Offset: 0x0002FA66
	public Vector2D(double inX, double inY)
	{
		this.X = inX;
		this.Y = inY;
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003187C File Offset: 0x0002FA7C
	// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00031884 File Offset: 0x0002FA84
	double IVector2D.X
	{
		get
		{
			return this.X;
		}
		set
		{
			this.X = value;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0003188D File Offset: 0x0002FA8D
	// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00031895 File Offset: 0x0002FA95
	double IVector2D.Y
	{
		get
		{
			return this.Y;
		}
		set
		{
			this.Y = value;
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x0003189E File Offset: 0x0002FA9E
	public void FromUeVector2D(IVector2D inV)
	{
		this.X = inV.X;
		this.Y = inV.Y;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x000318B8 File Offset: 0x0002FAB8
	public static Vector2D Create(double x, double y)
	{
		return new Vector2D(x, y);
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x000318C1 File Offset: 0x0002FAC1
	public static Vector2D Create([Nullable(2)] IVector2D inV)
	{
		if (inV != null)
		{
			return new Vector2D(inV.X, inV.Y);
		}
		return new Vector2D();
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x000318DD File Offset: 0x0002FADD
	public static Vector2D Create()
	{
		return new Vector2D();
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000318E4 File Offset: 0x0002FAE4
	public FVector2D ToUeVector2D(bool isCacheUeObj = false)
	{
		return new FVector2D((float)this.X, (float)this.Y);
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000318F9 File Offset: 0x0002FAF9
	public FVector2DDouble ToUeVector2DDouble()
	{
		return new FVector2DDouble(this.X, this.Y);
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0003190C File Offset: 0x0002FB0C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
		defaultInterpolatedStringHandler.AppendLiteral("X=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.X);
		defaultInterpolatedStringHandler.AppendLiteral(", Y=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x0003195B File Offset: 0x0002FB5B
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00031964 File Offset: 0x0002FB64
	public void ToFormattedString(UnsafeStringBuilder sb)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(6, 2, sb);
		appendInterpolatedStringHandler.AppendLiteral("X=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.X);
		appendInterpolatedStringHandler.AppendLiteral(", Y=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		sb.Append(ref appendInterpolatedStringHandler);
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x000319B8 File Offset: 0x0002FBB8
	public Vector2D Addition(Vector2D inB, Vector2D outV)
	{
		outV.X = this.X + inB.X;
		outV.Y = this.Y + inB.Y;
		return outV;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x000319E1 File Offset: 0x0002FBE1
	public Vector2D Addition(double inB, Vector2D outV)
	{
		outV.X = this.X + inB;
		outV.Y = this.Y + inB;
		return outV;
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00031A00 File Offset: 0x0002FC00
	public Vector2D AdditionEqual(Vector2D b)
	{
		this.X += b.X;
		this.Y += b.Y;
		return this;
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00031A29 File Offset: 0x0002FC29
	public Vector2D AdditionEqual(FVector2D inB)
	{
		this.X += (double)inB.X;
		this.Y += (double)inB.Y;
		return this;
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00031A54 File Offset: 0x0002FC54
	public Vector2D AdditionEqual(double inB)
	{
		this.X += inB;
		this.Y += inB;
		return this;
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00031A73 File Offset: 0x0002FC73
	public Vector2D Subtraction(Vector2D b, Vector2D outV)
	{
		outV.X = this.X - b.X;
		outV.Y = this.Y - b.Y;
		return outV;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00031A9C File Offset: 0x0002FC9C
	public Vector2D Subtraction(double inB, Vector2D outV)
	{
		outV.X = this.X - inB;
		outV.Y = this.Y - inB;
		return outV;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00031ABB File Offset: 0x0002FCBB
	public Vector2D SubtractionEqual(Vector2D b)
	{
		this.X -= b.X;
		this.Y -= b.Y;
		return this;
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00031AE4 File Offset: 0x0002FCE4
	public Vector2D SubtractionEqual(double inB)
	{
		this.X -= inB;
		this.Y -= inB;
		return this;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00031B03 File Offset: 0x0002FD03
	public Vector2D Multiply(Vector2D b, Vector2D outV)
	{
		outV.X = this.X * b.X;
		outV.Y = this.Y * b.Y;
		return outV;
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00031B2C File Offset: 0x0002FD2C
	public Vector2D Multiply(double inB, Vector2D outV)
	{
		outV.X = this.X * inB;
		outV.Y = this.Y * inB;
		return outV;
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00031B4B File Offset: 0x0002FD4B
	public Vector2D MultiplyEqual(Vector2D b)
	{
		this.X *= b.X;
		this.Y *= b.Y;
		return this;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00031B74 File Offset: 0x0002FD74
	public Vector2D MultiplyEqual(FVector2D inB)
	{
		this.X *= (double)inB.X;
		this.Y *= (double)inB.Y;
		return this;
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00031B9F File Offset: 0x0002FD9F
	public Vector2D MultiplyEqual(double inB)
	{
		this.X *= inB;
		this.Y *= inB;
		return this;
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00031BBE File Offset: 0x0002FDBE
	public Vector2D Division(Vector2D b, Vector2D outV)
	{
		outV.X = this.X / b.X;
		outV.Y = this.Y / b.Y;
		return outV;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00031BE8 File Offset: 0x0002FDE8
	public Vector2D Division(double inB, Vector2D outV)
	{
		double num = 1.0 / inB;
		outV.X = this.X * num;
		outV.Y = this.Y * num;
		return outV;
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00031C1E File Offset: 0x0002FE1E
	public Vector2D DivisionEqual(Vector2D b)
	{
		this.X /= b.X;
		this.Y /= b.Y;
		return this;
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00031C48 File Offset: 0x0002FE48
	public Vector2D DivisionEqual(double inB)
	{
		double num = 1.0 / inB;
		this.X *= num;
		this.Y *= num;
		return this;
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00031C7E File Offset: 0x0002FE7E
	public void UnaryNegation(Vector2D outV)
	{
		outV.X = -this.X;
		outV.Y = -this.Y;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00031C9A File Offset: 0x0002FE9A
	public double DotProduct(Vector2D b)
	{
		return this.X * b.X + this.Y * b.Y;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00031CB7 File Offset: 0x0002FEB7
	public double DotProduct(in FVector2D b)
	{
		return this.X * (double)b.X + this.Y * (double)b.Y;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00031CD6 File Offset: 0x0002FED6
	public double CrossProduct(Vector2D b)
	{
		return this.X * b.Y - this.Y * b.X;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00031CF3 File Offset: 0x0002FEF3
	public double Size()
	{
		return Math.Sqrt(this.SizeSquared());
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00031D00 File Offset: 0x0002FF00
	public double SizeSquared()
	{
		return this.X * this.X + this.Y * this.Y;
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00031D1D File Offset: 0x0002FF1D
	public bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
	{
		return Math.Abs(this.X) <= tolerance && Math.Abs(this.Y) <= tolerance;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00031D40 File Offset: 0x0002FF40
	public bool Normalize(double tolerance = 9.99999993922529E-09)
	{
		double num = this.SizeSquared();
		if (num > tolerance)
		{
			double inB = 1.0 / Math.Sqrt(num);
			this.Multiply(inB, this);
			return true;
		}
		return false;
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00031D78 File Offset: 0x0002FF78
	public void GetSafeNormal(Vector2D outV, double tolerance = 9.99999993922529E-09)
	{
		double num = this.SizeSquared();
		if (num == 1.0)
		{
			outV.DeepCopy(this);
			return;
		}
		if (num < tolerance)
		{
			outV.Reset();
			return;
		}
		double inB = 1.0 / Math.Sqrt(num);
		this.Multiply(inB, outV);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00031DC5 File Offset: 0x0002FFC5
	public void DeepCopy(Vector2D inV)
	{
		this.Set(inV.X, inV.Y);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00031DDC File Offset: 0x0002FFDC
	public void GetRotated(double angleDeg, Vector2D outV)
	{
		double num = MathCommon.DegreeToRadian(angleDeg);
		double num2 = Math.Sin(num);
		double num3 = Math.Cos(num);
		outV.X = num3 * this.X - num2 * this.Y;
		outV.Y = num2 * this.X + num3 * this.Y;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00031E2C File Offset: 0x0003002C
	public void SphericalToUnitCartesian(Vector outV3D)
	{
		double num = Math.Sin(this.X);
		outV3D.X = Math.Cos(this.Y) * num;
		outV3D.Y = Math.Sin(this.Y) * num;
		outV3D.Z = Math.Cos(this.X);
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00031E7C File Offset: 0x0003007C
	public bool Equals(Vector2D b, double tolerance = 9.999999747378752E-05)
	{
		return Math.Abs(this.X - b.X) <= tolerance && Math.Abs(this.Y - b.Y) <= tolerance;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00031EAD File Offset: 0x000300AD
	public double GetMax()
	{
		return Math.Max(this.X, this.Y);
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00031EC0 File Offset: 0x000300C0
	public double GetAbsMax()
	{
		return Math.Max(Math.Abs(this.X), Math.Abs(this.Y));
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00031EDD File Offset: 0x000300DD
	public double GetMin()
	{
		return Math.Min(this.X, this.Y);
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00031EF0 File Offset: 0x000300F0
	public double GetAbsMin()
	{
		return Math.Min(Math.Abs(this.X), Math.Abs(this.Y));
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00031F10 File Offset: 0x00030110
	public double ToDirectionAndLength(Vector2D outDir)
	{
		double num = this.Size();
		if (num > 9.99999993922529E-09)
		{
			double num2 = 1.0 / num;
			outDir.X = this.X * num2;
			outDir.Y = this.Y * num2;
		}
		else
		{
			outDir.Reset();
		}
		return num;
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00031F61 File Offset: 0x00030161
	public void Set(double inX, double inY)
	{
		this.X = inX;
		this.Y = inY;
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00031F71 File Offset: 0x00030171
	public static double Distance(Vector2D v1, Vector2D v2)
	{
		return Math.Sqrt(Vector2D.DistSquared(v1, v2));
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00031F7F File Offset: 0x0003017F
	public static double DistSquared(Vector2D a, Vector2D b)
	{
		return Math.Pow(b.X - a.X, 2.0) + Math.Pow(b.Y - a.Y, 2.0);
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00031FB8 File Offset: 0x000301B8
	public void Reset()
	{
		this.X = 0.0;
		this.Y = 0.0;
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00031FD8 File Offset: 0x000301D8
	public bool ContainsNaN()
	{
		return !double.IsFinite(this.X) || !double.IsFinite(this.Y);
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00031FF7 File Offset: 0x000301F7
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x04000668 RID: 1640
	public double X;

	// Token: 0x04000669 RID: 1641
	public double Y;

	// Token: 0x0400066A RID: 1642
	public static readonly FVector2D ZeroVector = new FVector2D(0f, 0f);

	// Token: 0x0400066B RID: 1643
	public static readonly FVector2D UnitVector = new FVector2D(1f, 1f);

	// Token: 0x0400066C RID: 1644
	public static readonly FVector2D Unit45Deg = new FVector2D((float)Math.Sqrt(0.5), (float)Math.Sqrt(0.5));
}
