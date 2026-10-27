using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C25 RID: 15397
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGSplineMesh.BP_PCGSplineMesh_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_PCGSplineMesh_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023505 RID: 144645 RVA: 0x00920CE0 File Offset: 0x0091EEE0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGSplineMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGSplineMesh.BP_PCGSplineMesh_C");
			}
			return BP_PCGSplineMesh_C._ClassPtr;
		}

		// Token: 0x06023506 RID: 144646 RVA: 0x00920D04 File Offset: 0x0091EF04
		public BP_PCGSplineMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGSplineMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023507 RID: 144647 RVA: 0x00920D2C File Offset: 0x0091EF2C
		[NullableContext(1)]
		public BP_PCGSplineMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGSplineMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040A0 RID: 16544
		// (get) Token: 0x06023508 RID: 144648 RVA: 0x00920D5F File Offset: 0x0091EF5F
		// (set) Token: 0x06023509 RID: 144649 RVA: 0x00920D73 File Offset: 0x0091EF73
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGSplineMesh_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGSplineMesh_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170040A1 RID: 16545
		// (get) Token: 0x0602350A RID: 144650 RVA: 0x00920D88 File Offset: 0x0091EF88
		// (set) Token: 0x0602350B RID: 144651 RVA: 0x00920D9C File Offset: 0x0091EF9C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGSplineMesh_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGSplineMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602350C RID: 144652 RVA: 0x00920DB1 File Offset: 0x0091EFB1
		protected BP_PCGSplineMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116B6 RID: 71350
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_PCGSplineMesh.BP_PCGSplineMesh_C";

		// Token: 0x040116B7 RID: 71351
		private static IntPtr _ClassPtr;

		// Token: 0x040116B8 RID: 71352
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116B9 RID: 71353
		internal static int __PropertyOffset_0;

		// Token: 0x040116BA RID: 71354
		internal static int __PropertyOffset_1;
	}
}
