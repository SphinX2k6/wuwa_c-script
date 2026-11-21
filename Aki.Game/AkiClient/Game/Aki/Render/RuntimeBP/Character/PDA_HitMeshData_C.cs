using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character
{
	// Token: 0x02003118 RID: 12568
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 148)]
	public class PDA_HitMeshData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC9E RID: 126110 RVA: 0x0091D521 File Offset: 0x0091B721
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_HitMeshData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C");
			}
			return PDA_HitMeshData_C._ClassPtr;
		}

		// Token: 0x0601EC9F RID: 126111 RVA: 0x0091D548 File Offset: 0x0091B748
		public PDA_HitMeshData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_HitMeshData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ECA0 RID: 126112 RVA: 0x0091D570 File Offset: 0x0091B770
		[NullableContext(1)]
		public PDA_HitMeshData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_HitMeshData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0601ECA1 RID: 126113 RVA: 0x0091D5A3 File Offset: 0x0091B7A3
		// (set) Token: 0x0601ECA2 RID: 126114 RVA: 0x0091D5B7 File Offset: 0x0091B7B7
		[Nullable(2)]
		public unsafe USkeletalMesh HitSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HitMeshData_C.__PropertyOffset_HitSkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HitMeshData_C.__PropertyOffset_HitSkeletalMesh, value);
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0601ECA3 RID: 126115 RVA: 0x0091D5CC File Offset: 0x0091B7CC
		// (set) Token: 0x0601ECA4 RID: 126116 RVA: 0x0091D5E0 File Offset: 0x0091B7E0
		public unsafe FTransform HitSkeletalMeshTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_HitSkeletalMeshTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_HitSkeletalMeshTransform) = value;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0601ECA5 RID: 126117 RVA: 0x0091D5F5 File Offset: 0x0091B7F5
		// (set) Token: 0x0601ECA6 RID: 126118 RVA: 0x0091D605 File Offset: 0x0091B805
		public unsafe float LastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_LastTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_LastTime) = value;
			}
		}

		// Token: 0x0601ECA7 RID: 126119 RVA: 0x0091D616 File Offset: 0x0091B816
		protected PDA_HitMeshData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105B8 RID: 67000
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C";

		// Token: 0x040105B9 RID: 67001
		private static IntPtr _ClassPtr;

		// Token: 0x040105BA RID: 67002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105BB RID: 67003
		internal static int __PropertyOffset_HitSkeletalMesh;

		// Token: 0x040105BC RID: 67004
		internal static int __PropertyOffset_HitSkeletalMeshTransform;

		// Token: 0x040105BD RID: 67005
		internal static int __PropertyOffset_LastTime;
	}
}
