using System;
using System.Runtime.CompilerServices;
using Aki.Common.Common;
using UnrealEngine;
using UnrealEngine.Bulitin.Utils;
using UnrealEngine.Extension;

// Token: 0x020000FD RID: 253
[NullableContext(1)]
[Nullable(0)]
[Obsolete("手写数学库已废弃，请改用 UnrealEngine.FTransformDouble")]
public class Transform : ITransform, IClearable, ILogFormattedPrint
{
	// Token: 0x060008E7 RID: 2279 RVA: 0x0002E768 File Offset: 0x0002C968
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator FTransformDouble(Transform v)
	{
		if (v != null)
		{
			return v.ToUeTransform();
		}
		return default(FTransformDouble);
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0002E788 File Offset: 0x0002C988
	[Obsolete("迁移期隐式转换：请确认不在每帧热点路径上")]
	public static implicit operator Transform(FTransformDouble v)
	{
		return Transform.Create(v);
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0002E795 File Offset: 0x0002C995
	private Transform()
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
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

	// Token: 0x060008EB RID: 2283 RVA: 0x0002E809 File Offset: 0x0002CA09
	public string ToFormattedString()
	{
		return this.ToString();
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x0002E814 File Offset: 0x0002CA14
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

	// Token: 0x060008ED RID: 2285 RVA: 0x0002E884 File Offset: 0x0002CA84
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

	// Token: 0x060008EE RID: 2286 RVA: 0x0002E930 File Offset: 0x0002CB30
	public static Transform Create(IQuat inR, IVector inT, IVector inS)
	{
		return new Transform
		{
			Rotation = Quat.Create(inR),
			Translation = Vector.Create(inT),
			Scale3D = Vector.Create(inS)
		};
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x0002E95C File Offset: 0x0002CB5C
	public static Transform Create()
	{
		return new Transform
		{
			Rotation = Quat.Create(0.0, 0.0, 0.0, 1.0),
			Translation = Vector.Create(),
			Scale3D = Vector.Create(1.0, 1.0, 1.0)
		};
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
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

	// Token: 0x060008F1 RID: 2289 RVA: 0x0002EA18 File Offset: 0x0002CC18
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

	// Token: 0x060008F2 RID: 2290 RVA: 0x0002EA60 File Offset: 0x0002CC60
	public FTransform ToUeTransformOld()
	{
		FQuat fquat = this.Rotation.ToUeQuat();
		FVector fvector = this.Translation.ToUeVectorOld();
		FVector fvector2 = this.Scale3D.ToUeVectorOld();
		return new FTransform(ref fquat, ref fvector, ref fvector2);
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x0002EA9C File Offset: 0x0002CC9C
	public FTransformDouble ToUeTransform()
	{
		FQuat fquat = this.Rotation.ToUeQuat();
		FVectorDouble fvectorDouble = this.Translation.ToUeVector(false);
		FVectorDouble fvectorDouble2 = this.Scale3D.ToUeVector(false);
		FVector fvector = fvectorDouble2;
		return new FTransformDouble(ref fquat, ref fvectorDouble, ref fvector);
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
	public void Set(IVector location, IQuat rotation, IVector scale)
	{
		this.Translation.Set(location.X, location.Y, location.Z);
		this.Rotation.Set(rotation.X, rotation.Y, rotation.Z, rotation.W);
		this.Scale3D.Set(scale.X, scale.Y, scale.Z);
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x0002EB4E File Offset: 0x0002CD4E
	public void SetLocation(IVector origin)
	{
		this.Translation.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x0002EB6D File Offset: 0x0002CD6D
	void ITransform.SetLocation(IVector value)
	{
		this.Translation.Set(value.X, value.Y, value.Z);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x0002EB8C File Offset: 0x0002CD8C
	public Vector GetLocation()
	{
		return this.Translation;
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x0002EB94 File Offset: 0x0002CD94
	IVector ITransform.GetLocation()
	{
		return this.Translation;
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x0002EB9C File Offset: 0x0002CD9C
	public void SetRotation(IQuat origin)
	{
		this.Rotation.Set(origin.X, origin.Y, origin.Z, origin.W);
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x0002EBC1 File Offset: 0x0002CDC1
	void ITransform.SetRotation(IQuat origin)
	{
		this.Rotation.Set(origin.X, origin.Y, origin.Z, origin.W);
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x0002EBE6 File Offset: 0x0002CDE6
	public Quat GetRotation()
	{
		return this.Rotation;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x0002EBEE File Offset: 0x0002CDEE
	IQuat ITransform.GetRotation()
	{
		return this.Rotation;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x0002EBF6 File Offset: 0x0002CDF6
	public void SetScale3D(IVector origin)
	{
		this.Scale3D.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x0002EC15 File Offset: 0x0002CE15
	void ITransform.SetScale3D(IVector origin)
	{
		this.Scale3D.Set(origin.X, origin.Y, origin.Z);
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x0002EC34 File Offset: 0x0002CE34
	public Vector GetScale3D()
	{
		return this.Scale3D;
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x0002EC3C File Offset: 0x0002CE3C
	IVector ITransform.GetScale3D()
	{
		return this.Scale3D;
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x0002EC44 File Offset: 0x0002CE44
	public void TransformPosition(Vector v, Vector @out)
	{
		this.Scale3D.Multiply(v, @out);
		this.Rotation.RotateVector(@out, @out);
		this.Translation.Addition(@out, @out);
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x0002EC6F File Offset: 0x0002CE6F
	public void TransformVector(Vector v, Vector @out)
	{
		this.Scale3D.Multiply(v, @out);
		this.Rotation.RotateVector(@out, @out);
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x0002EC8C File Offset: 0x0002CE8C
	public void TransformPositionNoScale(Vector v, Vector @out)
	{
		this.Rotation.RotateVector(v, @out);
		this.Translation.Addition(@out, @out);
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x0002ECA9 File Offset: 0x0002CEA9
	public void InverseTransformVector(Vector v, Vector @out)
	{
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(v, @out);
		this.Scale3D.Reciprocal(Transform.TmpVec);
		Transform.TmpVec.Multiply(@out, @out);
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x0002ECE4 File Offset: 0x0002CEE4
	public void InverseTransformPosition(Vector v, Vector @out)
	{
		v.Subtraction(this.Translation, @out);
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(@out, @out);
		this.Scale3D.Reciprocal(Transform.TmpVec);
		Transform.TmpVec.Multiply(@out, @out);
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x0002ED38 File Offset: 0x0002CF38
	public void InverseTransformPositionNoScale(Vector v, Vector @out)
	{
		v.Subtraction(this.Translation, @out);
		this.Rotation.Inverse(Transform.TmpQuat);
		Transform.TmpQuat.RotateVector(@out, @out);
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x0002ED64 File Offset: 0x0002CF64
	public void InverseTransformRotation(Quat q, Quat @out)
	{
		this.Rotation.Inverse(@out);
		@out.Multiply(q, @out);
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x0002ED7C File Offset: 0x0002CF7C
	public void TransformRotation(Rotator r, Quat @out)
	{
		Quat rotation = this.Rotation;
		Quat inQ = r.Quaternion(null);
		rotation.Multiply(inQ, @out);
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
	public void TransformRotation(Rotator r, Rotator @out)
	{
		Quat rotation = this.Rotation;
		Quat inQ = r.Quaternion(null);
		rotation.Multiply(inQ, Transform.TmpQuat);
		@out.FromUeRotator(Transform.TmpQuat.Rotator(null));
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
	public void ComposeTransforms(Transform target, Transform @out)
	{
		this.Translation.Multiply(target.Scale3D, @out.Translation);
		target.Rotation.RotateVector(@out.Translation, @out.Translation);
		target.Translation.Addition(@out.Translation, @out.Translation);
		this.Scale3D.Multiply(target.Scale3D, @out.Scale3D);
		target.Rotation.Multiply(this.Rotation, @out.Rotation);
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x0002EE5C File Offset: 0x0002D05C
	public void UnComposeTransform(Transform target, Transform @out)
	{
		target.Rotation.Inverse(@out.Rotation);
		@out.Rotation.Multiply(this.Rotation, @out.Rotation);
		this.Scale3D.Division(target.Scale3D, @out.Scale3D);
		this.Translation.Subtraction(target.Translation, @out.Translation);
		target.Rotation.UnRotateVector(@out.Translation, @out.Translation);
		@out.Translation.DivisionEqual(target.Scale3D);
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x0002EEEA File Offset: 0x0002D0EA
	public void Reset()
	{
		this.Translation.Reset();
		this.Scale3D.Reset();
		this.Rotation.Reset();
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x0002EF0D File Offset: 0x0002D10D
	public void Clear()
	{
		this.Reset();
	}

	// Token: 0x0400063B RID: 1595
	[Nullable(2)]
	private Vector Translation;

	// Token: 0x0400063C RID: 1596
	[Nullable(2)]
	private Quat Rotation;

	// Token: 0x0400063D RID: 1597
	[Nullable(2)]
	private Vector Scale3D;

	// Token: 0x0400063E RID: 1598
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVec = Vector.Create();

	// Token: 0x0400063F RID: 1599
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
}
