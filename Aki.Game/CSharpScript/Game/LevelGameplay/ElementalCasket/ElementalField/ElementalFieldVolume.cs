using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E95 RID: 28309
	public static class ElementalFieldVolume
	{
		// Token: 0x06044FDE RID: 282590 RVA: 0x0110D448 File Offset: 0x0110B648
		[NullableContext(1)]
		[return: Nullable(2)]
		public static IElementalFieldVolume createElementalFieldVolumeFromSnapshot(ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType> snapshot)
		{
			switch (snapshot.ShapeType)
			{
			case ESceneItemElementalFieldShapeType.Cone:
				return new ConeVolume(snapshot as ISceneItemElementalFieldConeSnapshot);
			case ESceneItemElementalFieldShapeType.Sphere:
			{
				ISceneItemElementalFieldSphereSnapshot sceneItemElementalFieldSphereSnapshot = snapshot as ISceneItemElementalFieldSphereSnapshot;
				return new SphereVolume(sceneItemElementalFieldSphereSnapshot.Center.X, sceneItemElementalFieldSphereSnapshot.Center.Y, sceneItemElementalFieldSphereSnapshot.Center.Z, sceneItemElementalFieldSphereSnapshot.SphereRadius);
			}
			case ESceneItemElementalFieldShapeType.Box:
			{
				ISceneItemElementalFieldBoxSnapshot sceneItemElementalFieldBoxSnapshot = snapshot as ISceneItemElementalFieldBoxSnapshot;
				return new BoxVolume(sceneItemElementalFieldBoxSnapshot.Center.X, sceneItemElementalFieldBoxSnapshot.Center.Y, sceneItemElementalFieldBoxSnapshot.Center.Z, sceneItemElementalFieldBoxSnapshot.BoxSize.X, sceneItemElementalFieldBoxSnapshot.BoxSize.Y, sceneItemElementalFieldBoxSnapshot.BoxSize.Z);
			}
			default:
				return null;
			}
		}

		// Token: 0x06044FDF RID: 282591 RVA: 0x0110D508 File Offset: 0x0110B708
		[NullableContext(2)]
		public static IElementalFieldVolume createElementalFieldVolumeFromShapeComp(UKuroFastCollisionShapeComponent shape)
		{
			if (shape == null || !shape.IsValid())
			{
				return null;
			}
			FVectorDouble fvectorDouble = ElementalCasketHelper.ComputeShapeCenterLocation(shape);
			ECollisionShapeKind kind = shape.Kind;
			if (kind == ECollisionShapeKind.Sphere)
			{
				return new SphereVolume(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z, (double)shape.Radius);
			}
			if (kind != ECollisionShapeKind.Box)
			{
				return null;
			}
			return new BoxVolume(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z, (double)shape.HalfExtent.X, (double)shape.HalfExtent.Y, (double)shape.HalfExtent.Z);
		}
	}
}
