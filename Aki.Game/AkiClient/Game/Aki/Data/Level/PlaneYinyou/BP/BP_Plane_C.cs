using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP
{
	// Token: 0x02003F0C RID: 16140
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_Plane_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028F43 RID: 167747 RVA: 0x009B84C8 File Offset: 0x009B66C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Plane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C");
			}
			return BP_Plane_C._ClassPtr;
		}

		// Token: 0x06028F44 RID: 167748 RVA: 0x009B84EC File Offset: 0x009B66EC
		public BP_Plane_C() : this(BuiltinUtils.AllocNativeUObject(BP_Plane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028F45 RID: 167749 RVA: 0x009B8514 File Offset: 0x009B6714
		[NullableContext(1)]
		public BP_Plane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Plane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006098 RID: 24728
		// (get) Token: 0x06028F46 RID: 167750 RVA: 0x009B8547 File Offset: 0x009B6747
		// (set) Token: 0x06028F47 RID: 167751 RVA: 0x009B855B File Offset: 0x009B675B
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x06028F48 RID: 167752 RVA: 0x009B8570 File Offset: 0x009B6770
		// (set) Token: 0x06028F49 RID: 167753 RVA: 0x009B8584 File Offset: 0x009B6784
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06028F4A RID: 167754 RVA: 0x009B8599 File Offset: 0x009B6799
		protected BP_Plane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F2D RID: 85805
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C";

		// Token: 0x04014F2E RID: 85806
		private static IntPtr _ClassPtr;

		// Token: 0x04014F2F RID: 85807
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F30 RID: 85808
		internal static int __PropertyOffset_0;

		// Token: 0x04014F31 RID: 85809
		internal static int __PropertyOffset_1;
	}
}
