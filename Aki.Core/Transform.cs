using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FD RID: 253
[NullableContext(1)]
[Nullable(0)]
public class Transform : ITransform, IClearable, ILogFormattedPrint
{
	// Token: 0x0600089D RID: 2205 RVA: 0x0002DED7 File Offset: 0x0002C0D7
	private Transform()
	{
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 3);
		defaultInterpolatedStringHandler.AppendLiteral("Translation=");
		defaultInterpolatedStringHandler.AppendFormatted<Vector>(this.Translation);
		defaultInterpolatedStringHandler.AppendLiteral(", Rotation=");
		defaultInterpolatedStringHandler.AppendFormatted<Quat>(this.Rotation);
		defaultInterpolatedStringHandler.AppendLiteral(", Scale3D=");
		defaultInterpolatedStringHandler.AppendFormatted<Vector>(this.Scale3D);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0002DF49 File Offset: 0x0002C149
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x0002DF54 File Offset: 0x0002C154
	public void ToFormattedString(UnsafeStringBuilder sb)
	{
		UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(33, 3, sb);
		appendInterpolatedStringHandler.AppendLiteral("Translation=");
		appendInterpolatedStringHandler.AppendFormatted<Vector>(this.Translation);
		appendInterpolatedStringHandler.AppendLiteral(", Rotation=");
		appendInterpolatedStringHandler.AppendFormatted<Quat>(this.Rotation);
		appendInterpolatedStringHandler.AppendLiteral(", Scale3D=");
		appendInterpolatedStringHandler.AppendFormatted<Vector>(this.Scale3D);
		sb.Append(ref appendInterpolatedStringHandler);
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x0002DFC4 File Offset: 0x0002C1C4
	public static Transform Create([Nullable(2)] ITransform inT)
	{
		Transform transform = new Transform();
		if (inT != null)
		{
			transform.Rotation = Quat.Create(inT.GetRotation());
			transform.Translation = Vector.Create(inT.GetLocation());
			transform.Scale3D = Vector.Create(inT.GetScale3D());
		}
		else
		{
			transform.Rotation = Quat.Create(0.0, 0.0, 0.0, 1.0);
			transform.Translation = Vector.Create();
			transform.Scale3D = Vector.Create(1.0, 1.0, 1.0);
		}
		return transform;
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x0002E070 File Offset: 0x0002C270
	public static Transform Create(IQuat inR, IVector inT, IVector inS)
	{
		return new Transform
		{
			Rotation = Quat.Create(inR),
			Translation = Vector.Create(inT),
			Scale3D = Vector.Create(inS)
		};
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0002E09C File Offset: 0x0002C29C
	public static Transform Create()
	{
		return new Transform
		{
			Rotation = Quat.Create(0.0, 0.0, 0.0, 1.0),
			Translation = Vector.Create(),
			Scale3D = Vector.Create(1.0, 1.0, 1.0)
		};
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x0002E110 File Offset: 0x0002C310
	public void FromUeTransform(in FTransform inT)
	{
		this.Rotation.FromUeQuat(inT.GetRotation());
		Vector translation = this.Translation;
		FVector fvector = inT.GetTranslation();
		translation.FromUeVector(fvector);
		Vector scale3D = this.Scale3D;
		fvector = inT.GetScale3D();
		scale3D.FromUeVector(fvector);
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002E158 File Offset: 0x0002C358
	public void FromUeTransform(in FTransformDouble inT)
	{
		this.Rotation.FromUeQuat(inT.GetRotation());
		Vector translation = this.Translation;
		FVectorDouble translation2 = inT.GetTranslation();
		translation.FromUeVector(translation2);
		Vector scale3D = this.Scale3D;
		FVector scale3D2 = inT.GetScale3D();
		scale3D.FromUeVector(scale3D2);
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
	public FTransform ToUeTransformOld()
	{
		FQuat fquat = this.Rotation.ToUeQuat();
		FVector fvector = this.Translation.ToUeVectorOld();
		FVector fvector2 = this.Scale3D.ToUeVectorOld();
		return new FTransform(ref fquat, ref fvector, ref fvector2);
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x0002E1DC File Offset: 0x0002C3DC
	public FTransformDouble ToUeTransform()
	{
		FQuat fquat = this.Rotation.ToUeQuat();
		FVectorDouble fvectorDouble = this.Translation.ToUeVector(false);
		FVectorDouble fvectorDouble2 = this.Scale3D.ToUeVector(false);
		FVector fvector = fvectorDouble2;
		return new FTransformDouble(ref fquat, ref fvectorDouble, ref fvector);
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0002E224 File Offset: 0x0002C424
	public void Set(IVector location, IQuat rotation, IVector scale)
	{
		this.Translation.Set(location.X, location.Y, location.Z);
		this.Rotation.Set(rotation.X, rotation.Y, rotation.Z, rotation.W);
		this.Scale3D.Set(scale.X, scale.Y, scale.Z);
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0002E28E File Offset: 0x0002C48E
	public void SetLocation(IVector origin)
	{
		this.Translation.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0002E2AD File Offset: 0x0002C4AD
	void ITransform.SetLocation(IVector value)
	{
		this.Translation.Set(value.X, value.Y, value.Z);
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0002E2CC File Offset: 0x0002C4CC
	public Vector GetLocation()
	{
		return this.Translation;
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002E2D4 File Offset: 0x0002C4D4
	IVector ITransform.GetLocation()
	{
		return this.Translation;
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002E2DC File Offset: 0x0002C4DC
	public void SetRotation(IQuat origin)
	{
		this.Rotation.Set(origin.X, origin.Y, origin.Z, origin.W);
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002E301 File Offset: 0x0002C501
	void ITransform.SetRotation(IQuat origin)
	{
		this.Rotation.Set(origin.X, origin.Y, origin.Z, origin.W);
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0002E326 File Offset: 0x0002C526
	public Quat GetRotation()
	{
		return this.Rotation;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0002E32E File Offset: 0x0002C52E
	IQuat ITransform.GetRotation()
	{
		return this.Rotation;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0002E336 File Offset: 0x0002C536
	public void SetScale3D(IVector origin)
	{
		this.Scale3D.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x0002E355 File Offset: 0x0002C555
	void ITransform.SetScale3D(IVector origin)
	{
		this.Scale3D.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002E374 File Offset: 0x0002C574
	public Vector GetScale3D()
	{
		return this.Scale3D;
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x0002E37C File Offset: 0x0002C57C
	IVector ITransform.GetScale3D()
	{
		return this.Scale3D;
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x0002E384 File Offset: 0x0002C584
	public void TransformPosition(Vector v, Vector @out)
	{
		this.Scale3D.Multiply(v, @out);
		this.Rotation.RotateVector(@out, @out);
		this.Translation.Addition(@out, @out);
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x0002E3AF File Offset: 0x0002C5AF
	public void TransformVector(Vector v, Vector @out)
	{
		this.Scale3D.Multiply(v, @out);
		this.Rotation.RotateVector(@out, @out);
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x0002E3CC File Offset: 0x0002C5CC
	public void TransformPositionNoScale(Vector v, Vector @out)
	{
		this.Rotation.RotateVector(v, @out);
		this.Translation.Addition(@out, @out);
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x0002E3E9 File Offset: 0x0002C5E9
	public void InverseTransformVector(Vector v, Vector @out)
	{
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(v, @out);
		this.Scale3D.Reciprocal(Transform.TmpVec);
		Transform.TmpVec.Multiply(@out, @out);
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x0002E424 File Offset: 0x0002C624
	public void InverseTransformPosition(Vector v, Vector @out)
	{
		v.Subtraction(this.Translation, @out);
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(@out, @out);
		this.Scale3D.Reciprocal(Transform.TmpVec);
		Transform.TmpVec.Multiply(@out, @out);
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0002E478 File Offset: 0x0002C678
	public void InverseTransformPositionNoScale(Vector v, Vector @out)
	{
		v.Subtraction(this.Translation, @out);
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(@out, @out);
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0002E4A4 File Offset: 0x0002C6A4
	public void InverseTransformRotation(Quat q, Quat @out)
	{
		this.Rotation.Inverse(@out);
		@out.Multiply(q, @out);
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0002E4BC File Offset: 0x0002C6BC
	public void TransformRotation(Rotator r, Quat @out)
	{
		Quat rotation = this.Rotation;
		Quat inQ = r.Quaternion(null);
		rotation.Multiply(inQ, @out);
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x0002E4E0 File Offset: 0x0002C6E0
	public void TransformRotation(Rotator r, Rotator @out)
	{
		Quat rotation = this.Rotation;
		Quat inQ = r.Quaternion(null);
		rotation.Multiply(inQ, Transform.TmpQuat);
		@out.FromUeRotator(Transform.TmpQuat.Rotator(null));
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0002E518 File Offset: 0x0002C718
	public void ComposeTransforms(Transform target, Transform @out)
	{
		this.Translation.Multiply(target.Scale3D, @out.Translation);
		target.Rotation.RotateVector(@out.Translation, @out.Translation);
		target.Translation.Addition(@out.Translation, @out.Translation);
		this.Scale3D.Multiply(target.Scale3D, @out.Scale3D);
		target.Rotation.Multiply(this.Rotation, @out.Rotation);
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0002E59C File Offset: 0x0002C79C
	public void UnComposeTransform(Transform target, Transform @out)
	{
		target.Rotation.Inverse(@out.Rotation);
		@out.Rotation.Multiply(this.Rotation, @out.Rotation);
		this.Scale3D.Division(target.Scale3D, @out.Scale3D);
		this.Translation.Subtraction(target.Translation, @out.Translation);
		target.Rotation.UnRotateVector(@out.Translation, @out.Translation);
		@out.Translation.DivisionEqual(target.Scale3D);
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0002E62A File Offset: 0x0002C82A
	public void Reset()
	{
		this.Translation.Reset();
		this.Scale3D.Reset();
		this.Rotation.Reset();
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0002E64D File Offset: 0x0002C84D
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x04000630 RID: 1584
	[Nullable(2)]
	private Vector Translation;

	// Token: 0x04000631 RID: 1585
	[Nullable(2)]
	private Quat Rotation;

	// Token: 0x04000632 RID: 1586
	[Nullable(2)]
	private Vector Scale3D;

	// Token: 0x04000633 RID: 1587
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVec = Vector.Create();

	// Token: 0x04000634 RID: 1588
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
}
