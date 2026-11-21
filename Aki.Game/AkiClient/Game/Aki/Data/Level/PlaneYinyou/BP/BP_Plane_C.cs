using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP
{
	// Token: 0x020031C8 RID: 12744
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_Plane_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8D5 RID: 129237 RVA: 0x00930413 File Offset: 0x0092E613
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Plane_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C");
			}
			return BP_Plane_C._ClassPtr;
		}

		// Token: 0x0601F8D6 RID: 129238 RVA: 0x00930438 File Offset: 0x0092E638
		public BP_Plane_C() : this(BuiltinUtils.AllocNativeUObject(BP_Plane_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8D7 RID: 129239 RVA: 0x00930460 File Offset: 0x0092E660
		[NullableContext(1)]
		public BP_Plane_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Plane_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0601F8D8 RID: 129240 RVA: 0x00930493 File Offset: 0x0092E693
		// (set) Token: 0x0601F8D9 RID: 129241 RVA: 0x009304A7 File Offset: 0x0092E6A7
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_SkeletalMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0601F8DA RID: 129242 RVA: 0x009304BC File Offset: 0x0092E6BC
		// (set) Token: 0x0601F8DB RID: 129243 RVA: 0x009304D0 File Offset: 0x0092E6D0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Plane_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x009304E5 File Offset: 0x0092E6E5
		protected BP_Plane_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010ECC RID: 69324
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/PlaneYinyou/BP/BP_Plane.BP_Plane_C";

		// Token: 0x04010ECD RID: 69325
		private static IntPtr _ClassPtr;

		// Token: 0x04010ECE RID: 69326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010ECF RID: 69327
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x04010ED0 RID: 69328
		internal static int __PropertyOffset_DefaultSceneRoot;
	}
}
