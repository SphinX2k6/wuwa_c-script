using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A3D RID: 10813
[NullableContext(1)]
[Nullable(0)]
public class SpaceUtils : IStaticVariableResetter
{
	// Token: 0x0601B3EA RID: 111594 RVA: 0x0085DD8C File Offset: 0x0085BF8C
	static SpaceUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpaceUtils.CreateStaticDefaultValue), new Action(SpaceUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0601B3EB RID: 111595 RVA: 0x0085DF7C File Offset: 0x0085C17C
	private static Vector GetVectorFromPool()
	{
		if (SpaceUtils.VectorPool.Count > 0)
		{
			Vector result = SpaceUtils.VectorPool[SpaceUtils.VectorPool.Count - 1];
			SpaceUtils.VectorPool.RemoveAt(SpaceUtils.VectorPool.Count - 1);
			return result;
		}
		return Vector.Create();
	}

	// Token: 0x0601B3EC RID: 111596 RVA: 0x0085DFC8 File Offset: 0x0085C1C8
	private static void ReleaseVectorArray(List<Vector> array)
	{
		SpaceUtils.VectorPool.AddRange(array);
		array.Clear();
	}

	// Token: 0x0601B3ED RID: 111597 RVA: 0x0085DFDC File Offset: 0x0085C1DC
	public static bool IsComponentInRingArea(Vector ringCenter, Vector ringSize, UPrimitiveComponent component, [Nullable(2)] Vector upVector = null)
	{
		FBoxSphereBounds fboxSphereBounds = component.D_GetComponentBounds();
		SpaceUtils.BoundsCenter.FromUeVector(fboxSphereBounds.Origin);
		SpaceUtils.BoundsExtent.FromUeVector(fboxSphereBounds.BoxExtent);
		double num = ringSize.X * ringSize.X;
		if (num < SpaceUtils.BoundsExtent.X * SpaceUtils.BoundsExtent.X || num < SpaceUtils.BoundsExtent.Y * SpaceUtils.BoundsExtent.Y)
		{
			SpaceUtils.BoundsCenter.Z = 0.0;
			SpaceUtils.BoundsExtent.Z = 0.0;
			SpaceUtils.TempVectorForHugComponent.Set(ringCenter.X, ringCenter.Y, 0.0);
			return SpaceUtils.IsComponentInRingAreaWhenCompHuge(SpaceUtils.BoundsCenter, SpaceUtils.BoundsExtent, SpaceUtils.TempVectorForHugComponent, ringSize.X);
		}
		SpaceUtils.BoundsQuat.FromUeQuat(component.K2_GetComponentQuaternion());
		SpaceUtils.BoundsCenter.Subtraction(ringCenter, SpaceUtils.TmpVector2);
		double z = ringSize.Z;
		double num2 = ringSize.Y * ringSize.Y;
		ERangeValid erangeValid = ERangeValid.None;
		ERangeValid erangeValid2 = ERangeValid.None;
		foreach (Vector inB in SpaceUtils.boundPoints)
		{
			SpaceUtils.BoundsExtent.Multiply(inB, SpaceUtils.TmpVector);
			SpaceUtils.BoundsQuat.RotateVector(SpaceUtils.TmpVector, SpaceUtils.TmpVector);
			SpaceUtils.TmpVector.AdditionEqual(SpaceUtils.TmpVector2);
			if (upVector != null)
			{
				double num3 = SpaceUtils.TmpVector.DotProduct(upVector);
				if (erangeValid2 != ERangeValid.InRange)
				{
					if (num3 > z)
					{
						erangeValid2 |= ERangeValid.Above;
					}
					else if (-num3 > z)
					{
						erangeValid2 |= ERangeValid.Below;
					}
					else
					{
						erangeValid2 = ERangeValid.InRange;
					}
				}
			}
			else if (erangeValid2 != ERangeValid.InRange)
			{
				if (SpaceUtils.TmpVector.Z > z)
				{
					erangeValid2 |= ERangeValid.Above;
				}
				else if (-SpaceUtils.TmpVector.Z > z)
				{
					erangeValid2 |= ERangeValid.Below;
				}
				else
				{
					erangeValid2 = ERangeValid.InRange;
				}
			}
			if (upVector != null)
			{
				Vector.VectorPlaneProject(SpaceUtils.TmpVector, upVector, SpaceUtils.TmpVector3);
				double num4 = SpaceUtils.TmpVector3.SizeSquared();
				if (erangeValid != ERangeValid.InRange)
				{
					if (num4 > num)
					{
						erangeValid |= ERangeValid.Above;
					}
					else if (num4 < num2)
					{
						erangeValid |= ERangeValid.Below;
					}
					else
					{
						erangeValid = ERangeValid.InRange;
					}
				}
			}
			else
			{
				double num5 = SpaceUtils.TmpVector.SizeSquared2D();
				if (erangeValid != ERangeValid.InRange)
				{
					if (num5 > num)
					{
						erangeValid |= ERangeValid.Above;
					}
					else if (num5 < num2)
					{
						erangeValid |= ERangeValid.Below;
					}
					else
					{
						erangeValid = ERangeValid.InRange;
					}
				}
			}
			if (erangeValid2 == ERangeValid.InRange && erangeValid == ERangeValid.InRange)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601B3EE RID: 111598 RVA: 0x0085E230 File Offset: 0x0085C430
	private static bool IsComponentInRingAreaWhenCompHuge(Vector componentLocation, Vector boxExt, Vector ringLocation, double maxRadius)
	{
		ringLocation.Subtraction(componentLocation, SpaceUtils.TempMinDistance);
		if (SpaceUtils.TempMinDistance.X < 0.0)
		{
			SpaceUtils.TempMinDistance.X = -SpaceUtils.TempMinDistance.X;
		}
		if (SpaceUtils.TempMinDistance.Y < 0.0)
		{
			SpaceUtils.TempMinDistance.Y = -SpaceUtils.TempMinDistance.Y;
		}
		SpaceUtils.TempMinDistance.SubtractionEqual(boxExt);
		bool flag = false;
		if (SpaceUtils.TempMinDistance.X < 0.0)
		{
			SpaceUtils.TempMinDistance.X = 0.0;
			flag = true;
		}
		if (SpaceUtils.TempMinDistance.Y < 0.0)
		{
			if (flag)
			{
				return true;
			}
			SpaceUtils.TempMinDistance.Y = 0.0;
		}
		return SpaceUtils.TempMinDistance.DotProduct(SpaceUtils.TempMinDistance) <= maxRadius * maxRadius;
	}

	// Token: 0x0601B3EF RID: 111599 RVA: 0x0085E31A File Offset: 0x0085C51A
	private static bool IgnoreInSectorArea(double sectorRadius)
	{
		return SpaceUtils.BoundsExtent.X > sectorRadius || SpaceUtils.BoundsExtent.Y > sectorRadius;
	}

	// Token: 0x0601B3F0 RID: 111600 RVA: 0x0085E338 File Offset: 0x0085C538
	public static bool IsComponentInSectorArea(Vector sectorCenter, Vector sectorSize, Quat sectorQuat, UPrimitiveComponent component)
	{
		FBoxSphereBounds fboxSphereBounds = component.D_GetComponentBounds();
		SpaceUtils.BoundsExtent.FromUeVector(fboxSphereBounds.BoxExtent);
		if (SpaceUtils.IgnoreInSectorArea(sectorSize.X))
		{
			return true;
		}
		SpaceUtils.BoundsCenter.FromUeVector(fboxSphereBounds.Origin);
		SpaceUtils.BoundsQuat.FromUeQuat(component.K2_GetComponentQuaternion());
		SpaceUtils.BoundsCenter.Subtraction(sectorCenter, SpaceUtils.TmpVector2);
		sectorQuat.Inverse(SpaceUtils.InverseQuat);
		double num = sectorSize.X * sectorSize.X;
		double num2 = 0.01745329238474369 * sectorSize.Y * 0.5;
		bool flag = num2 < 1.5707963267948966;
		double z = sectorSize.Z;
		ERangeValid erangeValid = ERangeValid.None;
		ERangeValid erangeValid2 = ERangeValid.None;
		ERangeValid erangeValid3 = ERangeValid.None;
		foreach (Vector inB in SpaceUtils.boundPoints)
		{
			SpaceUtils.BoundsExtent.Multiply(inB, SpaceUtils.TmpVector);
			SpaceUtils.BoundsQuat.RotateVector(SpaceUtils.TmpVector, SpaceUtils.TmpVector);
			SpaceUtils.TmpVector.AdditionEqual(SpaceUtils.TmpVector2);
			SpaceUtils.InverseQuat.RotateVector(SpaceUtils.TmpVector, SpaceUtils.TmpVector);
			if (erangeValid2 != ERangeValid.InRange)
			{
				if (SpaceUtils.TmpVector.Z > z)
				{
					erangeValid2 |= ERangeValid.Above;
				}
				else if (-SpaceUtils.TmpVector.Z > z)
				{
					erangeValid2 |= ERangeValid.Below;
				}
				else
				{
					erangeValid2 = ERangeValid.InRange;
				}
			}
			double num3 = SpaceUtils.TmpVector.SizeSquared2D();
			if (erangeValid != ERangeValid.InRange && num3 <= num)
			{
				erangeValid = ERangeValid.InRange;
			}
			double num4 = Math.Atan2(SpaceUtils.TmpVector.Y, SpaceUtils.TmpVector.X);
			if (erangeValid3 != ERangeValid.InRange)
			{
				if (flag)
				{
					if (num4 > num2)
					{
						Vector vectorFromPool = SpaceUtils.GetVectorFromPool();
						vectorFromPool.DeepCopy(SpaceUtils.TmpVector);
						SpaceUtils.RightPoints.Add(vectorFromPool);
					}
					else if (-num4 > num2)
					{
						Vector vectorFromPool2 = SpaceUtils.GetVectorFromPool();
						vectorFromPool2.DeepCopy(SpaceUtils.TmpVector);
						SpaceUtils.LeftPoints.Add(vectorFromPool2);
					}
					else
					{
						erangeValid3 = ERangeValid.InRange;
					}
				}
				else if (Math.Abs(num4) <= num2)
				{
					erangeValid3 = ERangeValid.InRange;
				}
			}
			if (erangeValid2 == ERangeValid.InRange && erangeValid == ERangeValid.InRange && erangeValid3 == ERangeValid.InRange)
			{
				if (flag)
				{
					SpaceUtils.ReleaseVectorArray(SpaceUtils.LeftPoints);
					SpaceUtils.ReleaseVectorArray(SpaceUtils.RightPoints);
				}
				return true;
			}
		}
		if (flag)
		{
			if (erangeValid2 == ERangeValid.InRange && erangeValid == ERangeValid.InRange && SpaceUtils.CheckLineCrossX())
			{
				SpaceUtils.ReleaseVectorArray(SpaceUtils.LeftPoints);
				SpaceUtils.ReleaseVectorArray(SpaceUtils.RightPoints);
				return true;
			}
			SpaceUtils.ReleaseVectorArray(SpaceUtils.LeftPoints);
			SpaceUtils.ReleaseVectorArray(SpaceUtils.RightPoints);
		}
		return false;
	}

	// Token: 0x0601B3F1 RID: 111601 RVA: 0x0085E598 File Offset: 0x0085C798
	private static bool CheckLineCrossX()
	{
		foreach (Vector vector in SpaceUtils.LeftPoints)
		{
			foreach (Vector vector2 in SpaceUtils.RightPoints)
			{
				if (Math.Abs(vector2.Y - vector.Y) >= 1E-08 && vector2.X - (vector2.X - vector.X) / (vector2.Y - vector.Y) * vector2.Y >= 0.0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0601B3F2 RID: 111602 RVA: 0x0085E680 File Offset: 0x0085C880
	public static bool IsLocationInSideBullet(BulletInfo bulletInfo, Vector location)
	{
		double num = Vector.DistSquared(bulletInfo.GetCollisionLocation(true), location);
		BulletDataBase @base = bulletInfo.BulletDataMain.Base;
		Vector size = @base.Size;
		switch (@base.Shape)
		{
		case EBulletShape.Cube:
			return num < size.X * size.X && num < size.Y * size.Y && num < size.Z * size.Z;
		case EBulletShape.Sphere:
			return num < size.X * size.X;
		case EBulletShape.Cylinder:
			return num < size.Y * size.Y;
		}
		return false;
	}

	// Token: 0x0601B3F3 RID: 111603 RVA: 0x0085E728 File Offset: 0x0085C928
	public static void CreateStaticDefaultValue()
	{
		SpaceUtils.VectorPool = new List<Vector>();
		SpaceUtils.LeftPoints = new List<Vector>();
		SpaceUtils.RightPoints = new List<Vector>();
	}

	// Token: 0x0601B3F4 RID: 111604 RVA: 0x0085E748 File Offset: 0x0085C948
	public static void ResetStaticDefaultValue()
	{
		SpaceUtils.VectorPool = null;
		SpaceUtils.LeftPoints = null;
		SpaceUtils.RightPoints = null;
	}

	// Token: 0x0400EC91 RID: 60561
	[StaticVariableRuleIgnore]
	private static readonly Vector[] boundPoints = new Vector[]
	{
		Vector.Create(1.0, 1.0, 1.0),
		Vector.Create(1.0, 1.0, -1.0),
		Vector.Create(1.0, -1.0, 1.0),
		Vector.Create(1.0, -1.0, -1.0),
		Vector.Create(-1.0, 1.0, 1.0),
		Vector.Create(-1.0, 1.0, -1.0),
		Vector.Create(-1.0, -1.0, 1.0),
		Vector.Create(-1.0, -1.0, -1.0)
	};

	// Token: 0x0400EC92 RID: 60562
	[StaticVariableRuleIgnore]
	private static readonly Vector BoundsCenter = Vector.Create();

	// Token: 0x0400EC93 RID: 60563
	[StaticVariableRuleIgnore]
	private static readonly Vector BoundsExtent = Vector.Create();

	// Token: 0x0400EC94 RID: 60564
	[StaticVariableRuleIgnore]
	private static readonly Quat BoundsQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400EC95 RID: 60565
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400EC96 RID: 60566
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400EC97 RID: 60567
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x0400EC98 RID: 60568
	[StaticVariableRuleIgnore]
	private static readonly Quat InverseQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400EC99 RID: 60569
	private static List<Vector> VectorPool;

	// Token: 0x0400EC9A RID: 60570
	private static List<Vector> LeftPoints;

	// Token: 0x0400EC9B RID: 60571
	private static List<Vector> RightPoints;

	// Token: 0x0400EC9C RID: 60572
	[StaticVariableRuleIgnore]
	private static readonly Vector TempVectorForHugComponent = Vector.Create();

	// Token: 0x0400EC9D RID: 60573
	[StaticVariableRuleIgnore]
	private static readonly Vector TempMinDistance = Vector.Create();
}
