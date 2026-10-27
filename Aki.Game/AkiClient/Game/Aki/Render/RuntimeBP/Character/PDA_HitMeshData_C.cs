using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character
{
	// Token: 0x02003DF3 RID: 15859
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 148)]
	public class PDA_HitMeshData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060279A1 RID: 162209 RVA: 0x00995CEB File Offset: 0x00993EEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_HitMeshData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C");
			}
			return PDA_HitMeshData_C._ClassPtr;
		}

		// Token: 0x060279A2 RID: 162210 RVA: 0x00995D10 File Offset: 0x00993F10
		public PDA_HitMeshData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_HitMeshData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060279A3 RID: 162211 RVA: 0x00995D38 File Offset: 0x00993F38
		[NullableContext(1)]
		public PDA_HitMeshData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_HitMeshData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x060279A4 RID: 162212 RVA: 0x00995D6B File Offset: 0x00993F6B
		// (set) Token: 0x060279A5 RID: 162213 RVA: 0x00995D7F File Offset: 0x00993F7F
		[Nullable(2)]
		public unsafe USkeletalMesh HitSkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HitMeshData_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_HitMeshData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x060279A6 RID: 162214 RVA: 0x00995D94 File Offset: 0x00993F94
		// (set) Token: 0x060279A7 RID: 162215 RVA: 0x00995DA8 File Offset: 0x00993FA8
		public unsafe FTransform HitSkeletalMeshTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x060279A8 RID: 162216 RVA: 0x00995DBD File Offset: 0x00993FBD
		// (set) Token: 0x060279A9 RID: 162217 RVA: 0x00995DCD File Offset: 0x00993FCD
		public unsafe float LastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_HitMeshData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060279AA RID: 162218 RVA: 0x00995DDE File Offset: 0x00993FDE
		protected PDA_HitMeshData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014070 RID: 82032
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/PDA_HitMeshData.PDA_HitMeshData_C";

		// Token: 0x04014071 RID: 82033
		private static IntPtr _ClassPtr;

		// Token: 0x04014072 RID: 82034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014073 RID: 82035
		internal static int __PropertyOffset_0;

		// Token: 0x04014074 RID: 82036
		internal static int __PropertyOffset_1;

		// Token: 0x04014075 RID: 82037
		internal static int __PropertyOffset_2;
	}
}
