using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FF RID: 255
[NullableContext(1)]
[Nullable(0)]
public class Vector2D : IVector2D, IClearable, ILogFormattedPrint
{
	// Token: 0x0600095D RID: 2397 RVA: 0x00030F12 File Offset: 0x0002F112
	public Vector2D()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00030F1A File Offset: 0x0002F11A
	public Vector2D(double inX, double inY)
	{
		this.X = inX;
		this.Y = inY;
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x0600095F RID: 2399 RVA: 0x00030F30 File Offset: 0x0002F130
	// (set) Token: 0x06000960 RID: 2400 RVA: 0x00030F38 File Offset: 0x0002F138
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

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000961 RID: 2401 RVA: 0x00030F41 File Offset: 0x0002F141
	// (set) Token: 0x06000962 RID: 2402 RVA: 0x00030F49 File Offset: 0x0002F149
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

	// Token: 0x06000963 RID: 2403 RVA: 0x00030F52 File Offset: 0x0002F152
	public void FromUeVector2D(IVector2D inV)
	{
		this.X = inV.X;
		this.Y = inV.Y;
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00030F6C File Offset: 0x0002F16C
	public static Vector2D Create(double x, double y)
	{
		return new Vector2D(x, y);
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00030F75 File Offset: 0x0002F175
	public static Vector2D Create([Nullable(2)] IVector2D inV)
	{
		if (inV != null)
		{
			return new Vector2D(inV.X, inV.Y);
		}
		return new Vector2D();
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00030F91 File Offset: 0x0002F191
	public static Vector2D Create()
	{
		return new Vector2D();
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00030F98 File Offset: 0x0002F198
	public FVector2D ToUeVector2D(bool isCacheUeObj = false)
	{
		return new FVector2D((float)this.X, (float)this.Y);
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00030FB0 File Offset: 0x0002F1B0
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 2);
		defaultInterpolatedStringHandler.AppendLiteral("X=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.X);
		defaultInterpolatedStringHandler.AppendLiteral(", Y=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00030FFF File Offset: 0x0002F1FF
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00031008 File Offset: 0x0002F208
	public void ToFormattedString(UnsafeStringBuilder sb)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(6, 2, sb);
		appendInterpolatedStringHandler.AppendLiteral("X=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.X);
		appendInterpolatedStringHandler.AppendLiteral(", Y=");
		appendInterpolatedStringHandler.AppendFormatted<double>(this.Y);
		sb.Append(ref appendInterpolatedStringHandler);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x0003105C File Offset: 0x0002F25C
	public Vector2D Addition(Vector2D inB, Vector2D outV)
	{
		outV.X = this.X + inB.X;
		outV.Y = this.Y + inB.Y;
		return outV;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00031085 File Offset: 0x0002F285
	public Vector2D Addition(double inB, Vector2D outV)
	{
		outV.X = this.X + inB;
		outV.Y = this.Y + inB;
		return outV;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x000310A4 File Offset: 0x0002F2A4
	public Vector2D AdditionEqual(Vector2D b)
	{
		this.X += b.X;
		this.Y += b.Y;
		return this;
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x000310CD File Offset: 0x0002F2CD
	public Vector2D AdditionEqual(FVector2D inB)
	{
		this.X += (double)inB.X;
		this.Y += (double)inB.Y;
		return this;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x000310F8 File Offset: 0x0002F2F8
	public Vector2D AdditionEqual(double inB)
	{
		this.X += inB;
		this.Y += inB;
		return this;
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00031117 File Offset: 0x0002F317
	public Vector2D Subtraction(Vector2D b, Vector2D outV)
	{
		outV.X = this.X - b.X;
		outV.Y = this.Y - b.Y;
		return outV;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00031140 File Offset: 0x0002F340
	public Vector2D Subtraction(double inB, Vector2D outV)
	{
		outV.X = this.X - inB;
		outV.Y = this.Y - inB;
		return outV;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x0003115F File Offset: 0x0002F35F
	public Vector2D SubtractionEqual(Vector2D b)
	{
		this.X -= b.X;
		this.Y -= b.Y;
		return this;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00031188 File Offset: 0x0002F388
	public Vector2D SubtractionEqual(double inB)
	{
		this.X -= inB;
		this.Y -= inB;
		return this;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x000311A7 File Offset: 0x0002F3A7
	public Vector2D Multiply(Vector2D b, Vector2D outV)
	{
		outV.X = this.X * b.X;
		outV.Y = this.Y * b.Y;
		return outV;
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x000311D0 File Offset: 0x0002F3D0
	public Vector2D Multiply(double inB, Vector2D outV)
	{
		outV.X = this.X * inB;
		outV.Y = this.Y * inB;
		return outV;
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x000311EF File Offset: 0x0002F3EF
	public Vector2D MultiplyEqual(Vector2D b)
	{
		this.X *= b.X;
		this.Y *= b.Y;
		return this;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00031218 File Offset: 0x0002F418
	public Vector2D MultiplyEqual(FVector2D inB)
	{
		this.X *= (double)inB.X;
		this.Y *= (double)inB.Y;
		return this;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00031243 File Offset: 0x0002F443
	public Vector2D MultiplyEqual(double inB)
	{
		this.X *= inB;
		this.Y *= inB;
		return this;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00031262 File Offset: 0x0002F462
	public Vector2D Division(Vector2D b, Vector2D outV)
	{
		outV.X = this.X / b.X;
		outV.Y = this.Y / b.Y;
		return outV;
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x0003128C File Offset: 0x0002F48C
	public Vector2D Division(double inB, Vector2D outV)
	{
		double num = 1.0 / inB;
		outV.X = this.X * num;
		outV.Y = this.Y * num;
		return outV;
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x000312C2 File Offset: 0x0002F4C2
	public Vector2D DivisionEqual(Vector2D b)
	{
		this.X /= b.X;
		this.Y /= b.Y;
		return this;
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x000312EC File Offset: 0x0002F4EC
	public Vector2D DivisionEqual(double inB)
	{
		double num = 1.0 / inB;
		this.X *= num;
		this.Y *= num;
		return this;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00031322 File Offset: 0x0002F522
	public void UnaryNegation(Vector2D outV)
	{
		outV.X = -this.X;
		outV.Y = -this.Y;
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0003133E File Offset: 0x0002F53E
	public double DotProduct(Vector2D b)
	{
		return this.X * b.X + this.Y * b.Y;
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x0003135B File Offset: 0x0002F55B
	public double DotProduct(in FVector2D b)
	{
		return this.X * (double)b.X + this.Y * (double)b.Y;
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0003137A File Offset: 0x0002F57A
	public double CrossProduct(Vector2D b)
	{
		return this.X * b.Y - this.Y * b.X;
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00031397 File Offset: 0x0002F597
	public double Size()
	{
		return Math.Sqrt(this.SizeSquared());
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x000313A4 File Offset: 0x0002F5A4
	public double SizeSquared()
	{
		return this.X * this.X + this.Y * this.Y;
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x000313C1 File Offset: 0x0002F5C1
	public bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
	{
		return Math.Abs(this.X) <= tolerance && Math.Abs(this.Y) <= tolerance;
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x000313E4 File Offset: 0x0002F5E4
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

	// Token: 0x06000985 RID: 2437 RVA: 0x0003141C File Offset: 0x0002F61C
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

	// Token: 0x06000986 RID: 2438 RVA: 0x00031469 File Offset: 0x0002F669
	public void DeepCopy(Vector2D inV)
	{
		this.Set(inV.X, inV.Y);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00031480 File Offset: 0x0002F680
	public void GetRotated(double angleDeg, Vector2D outV)
	{
		double num = MathCommon.DegreeToRadian(angleDeg);
		double num2 = Math.Sin(num);
		double num3 = Math.Cos(num);
		outV.X = num3 * this.X - num2 * this.Y;
		outV.Y = num2 * this.X + num3 * this.Y;
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x000314D0 File Offset: 0x0002F6D0
	public void SphericalToUnitCartesian(Vector outV3D)
	{
		double num = Math.Sin(this.X);
		outV3D.X = Math.Cos(this.Y) * num;
		outV3D.Y = Math.Sin(this.Y) * num;
		outV3D.Z = Math.Cos(this.X);
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00031520 File Offset: 0x0002F720
	public bool Equals(Vector2D b, double tolerance = 9.999999747378752E-05)
	{
		return Math.Abs(this.X - b.X) <= tolerance && Math.Abs(this.Y - b.Y) <= tolerance;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00031551 File Offset: 0x0002F751
	public double GetMax()
	{
		return Math.Max(this.X, this.Y);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00031564 File Offset: 0x0002F764
	public double GetAbsMax()
	{
		return Math.Max(Math.Abs(this.X), Math.Abs(this.Y));
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00031581 File Offset: 0x0002F781
	public double GetMin()
	{
		return Math.Min(this.X, this.Y);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00031594 File Offset: 0x0002F794
	public double GetAbsMin()
	{
		return Math.Min(Math.Abs(this.X), Math.Abs(this.Y));
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000315B4 File Offset: 0x0002F7B4
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

	// Token: 0x0600098F RID: 2447 RVA: 0x00031605 File Offset: 0x0002F805
	public void Set(double inX, double inY)
	{
		this.X = inX;
		this.Y = inY;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00031615 File Offset: 0x0002F815
	public static double Distance(Vector2D v1, Vector2D v2)
	{
		return Math.Sqrt(Vector2D.DistSquared(v1, v2));
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00031623 File Offset: 0x0002F823
	public static double DistSquared(Vector2D a, Vector2D b)
	{
		return Math.Pow(b.X - a.X, 2.0) + Math.Pow(b.Y - a.Y, 2.0);
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x0003165C File Offset: 0x0002F85C
	public void Reset()
	{
		this.X = 0.0;
		this.Y = 0.0;
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x0003167C File Offset: 0x0002F87C
	public bool ContainsNaN()
	{
		return !double.IsFinite(this.X) || !double.IsFinite(this.Y);
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0003169B File Offset: 0x0002F89B
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x0400065D RID: 1629
	public double X;

	// Token: 0x0400065E RID: 1630
	public double Y;

	// Token: 0x0400065F RID: 1631
	public static readonly FVector2D ZeroVector = new FVector2D(0f, 0f);

	// Token: 0x04000660 RID: 1632
	public static readonly FVector2D UnitVector = new FVector2D(1f, 1f);

	// Token: 0x04000661 RID: 1633
	public static readonly FVector2D Unit45Deg = new FVector2D((float)Math.Sqrt(0.5), (float)Math.Sqrt(0.5));
}
