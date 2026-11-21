using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A08 RID: 10760
[NullableContext(1)]
[Nullable(0)]
public class BeizerQuadraticCurve
{
	// Token: 0x0601B1CC RID: 111052 RVA: 0x00851FD3 File Offset: 0x008501D3
	public void InitByThreePoints(Vector pointA, Vector pointB, Vector controlPoint)
	{
		this.PointA = pointA;
		this.PointB = pointB;
		this.ControlPoint = controlPoint;
	}

	// Token: 0x0601B1CD RID: 111053 RVA: 0x00851FEC File Offset: 0x008501EC
	public void InitByPhysics(Vector pointA, Vector pointB, Vector speedA, double delta)
	{
		this.PointA = pointA;
		this.PointB = pointB;
		speedA.Multiply(delta, this.TempVector);
		this.ControlPoint = Vector.Create();
		this.PointA.Addition(this.TempVector, this.ControlPoint);
	}

	// Token: 0x0601B1CE RID: 111054 RVA: 0x0085203C File Offset: 0x0085023C
	public void InitByFactor(Vector pointA, Vector pointB, Vector upVetcor, double factor, double centerFactor)
	{
		this.PointA = pointA;
		this.PointB = pointB;
		this.ControlPoint = Vector.Create();
		this.PointB.Subtraction(this.PointA, this.TempVector);
		double num = this.TempVector.Size();
		this.TempVector.CrossProduct(upVetcor, this.TempVector2);
		this.TempVector2.Normalize(9.99999993922529E-09);
		this.PointA.Addition(this.PointB, this.TempVector3);
		this.TempVector3.Multiply(centerFactor, this.TempVector3);
		this.TempVector2.Multiply(num * factor, this.TempVector2);
		this.TempVector2.Addition(this.TempVector3, this.ControlPoint);
	}

	// Token: 0x0601B1CF RID: 111055 RVA: 0x00852108 File Offset: 0x00850308
	public Vector GetPos(double factor)
	{
		double num = 1.0 - factor;
		this.PointA.Multiply(num * num, this.TempVector);
		this.ControlPoint.Multiply(2.0 * num * factor, this.TempVector2);
		this.TempVector.Addition(this.TempVector2, this.TempVector3);
		this.PointB.Multiply(factor * factor, this.TempVector2);
		this.TempVector3.Addition(this.TempVector2, this.TempVector);
		return this.TempVector;
	}

	// Token: 0x0601B1D0 RID: 111056 RVA: 0x008521A0 File Offset: 0x008503A0
	public Vector GetDerivativeAt(double factor)
	{
		double num = 1.0 - factor;
		this.PointA.Multiply(-2.0 * num, this.TempVector);
		this.ControlPoint.Multiply(2.0 * num - 2.0 * factor, this.TempVector2);
		this.TempVector.Addition(this.TempVector2, this.TempVector3);
		this.PointB.Multiply(2.0 * factor, this.TempVector2);
		this.TempVector3.Addition(this.TempVector2, this.TempVector);
		return this.TempVector;
	}

	// Token: 0x0601B1D1 RID: 111057 RVA: 0x00852254 File Offset: 0x00850454
	public double GetPolylineLength()
	{
		this.ControlPoint.Subtraction(this.PointA, this.TempVector);
		this.PointB.Subtraction(this.PointA, this.TempVector2);
		return this.TempVector.Size() + this.TempVector2.Size();
	}

	// Token: 0x0400EB98 RID: 60312
	[Nullable(2)]
	protected Vector PointA;

	// Token: 0x0400EB99 RID: 60313
	[Nullable(2)]
	protected Vector PointB;

	// Token: 0x0400EB9A RID: 60314
	[Nullable(2)]
	protected Vector ControlPoint;

	// Token: 0x0400EB9B RID: 60315
	protected Vector TempVector = Vector.Create();

	// Token: 0x0400EB9C RID: 60316
	protected Vector TempVector2 = Vector.Create();

	// Token: 0x0400EB9D RID: 60317
	protected Vector TempVector3 = Vector.Create();
}
