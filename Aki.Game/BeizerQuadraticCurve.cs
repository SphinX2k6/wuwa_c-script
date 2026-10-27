using System;
using System.Runtime.CompilerServices;

// Token: 0x02003494 RID: 13460
[NullableContext(1)]
[Nullable(0)]
public class BeizerQuadraticCurve
{
	// Token: 0x0601D4D0 RID: 120016 RVA: 0x0082AD6F File Offset: 0x00828F6F
	public void InitByThreePoints(Vector pointA, Vector pointB, Vector controlPoint)
	{
		this.PointA = pointA;
		this.PointB = pointB;
		this.ControlPoint = controlPoint;
	}

	// Token: 0x0601D4D1 RID: 120017 RVA: 0x0082AD88 File Offset: 0x00828F88
	public void InitByPhysics(Vector pointA, Vector pointB, Vector speedA, double delta)
	{
		this.PointA = pointA;
		this.PointB = pointB;
		speedA.Multiply(delta, this.TempVector);
		this.ControlPoint = Vector.Create();
		this.PointA.Addition(this.TempVector, this.ControlPoint);
	}

	// Token: 0x0601D4D2 RID: 120018 RVA: 0x0082ADD8 File Offset: 0x00828FD8
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

	// Token: 0x0601D4D3 RID: 120019 RVA: 0x0082AEA4 File Offset: 0x008290A4
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

	// Token: 0x0601D4D4 RID: 120020 RVA: 0x0082AF3C File Offset: 0x0082913C
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

	// Token: 0x0601D4D5 RID: 120021 RVA: 0x0082AFF0 File Offset: 0x008291F0
	public double GetPolylineLength()
	{
		this.ControlPoint.Subtraction(this.PointA, this.TempVector);
		this.PointB.Subtraction(this.PointA, this.TempVector2);
		return this.TempVector.Size() + this.TempVector2.Size();
	}

	// Token: 0x0400E6E3 RID: 59107
	[Nullable(2)]
	protected Vector PointA;

	// Token: 0x0400E6E4 RID: 59108
	[Nullable(2)]
	protected Vector PointB;

	// Token: 0x0400E6E5 RID: 59109
	[Nullable(2)]
	protected Vector ControlPoint;

	// Token: 0x0400E6E6 RID: 59110
	protected Vector TempVector = Vector.Create();

	// Token: 0x0400E6E7 RID: 59111
	protected Vector TempVector2 = Vector.Create();

	// Token: 0x0400E6E8 RID: 59112
	protected Vector TempVector3 = Vector.Create();
}
