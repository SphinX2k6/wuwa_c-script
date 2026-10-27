using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A74 RID: 14964
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/AN_Yangyang_SpawnBirds.AN_Yangyang_SpawnBirds_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class AN_Yangyang_SpawnBirds_C : UKuroAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAE7 RID: 129767 RVA: 0x008BF892 File Offset: 0x008BDA92
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (AN_Yangyang_SpawnBirds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/YangYangBirds/AN_Yangyang_SpawnBirds.AN_Yangyang_SpawnBirds_C");
			}
			return AN_Yangyang_SpawnBirds_C._ClassPtr;
		}

		// Token: 0x0601FAE8 RID: 129768 RVA: 0x008BF8B8 File Offset: 0x008BDAB8
		public AN_Yangyang_SpawnBirds_C() : this(BuiltinUtils.AllocNativeUObject(AN_Yangyang_SpawnBirds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAE9 RID: 129769 RVA: 0x008BF8E0 File Offset: 0x008BDAE0
		[NullableContext(1)]
		public AN_Yangyang_SpawnBirds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AN_Yangyang_SpawnBirds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FAEA RID: 129770 RVA: 0x008BF914 File Offset: 0x008BDB14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool Received_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams* ptr = stackalloc AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AN_Yangyang_SpawnBirds_C.__Received_Notify_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AN_Yangyang_SpawnBirds_C.__Received_Notify_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601FAEB RID: 129771 RVA: 0x008BF988 File Offset: 0x008BDB88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool Received_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams* ptr = stackalloc AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AN_Yangyang_SpawnBirds_C.__Received_Notify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AN_Yangyang_SpawnBirds_C.__Received_Notify_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AN_Yangyang_SpawnBirds_C.__Received_Notify_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601FAEC RID: 129772 RVA: 0x008BF9FA File Offset: 0x008BDBFA
		protected AN_Yangyang_SpawnBirds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F412 RID: 62482
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/AN_Yangyang_SpawnBirds.AN_Yangyang_SpawnBirds_C";

		// Token: 0x0400F413 RID: 62483
		private static IntPtr _ClassPtr;

		// Token: 0x0400F414 RID: 62484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F415 RID: 62485
		private static IntPtr __Received_Notify_NativeFunctionPtr;

		// Token: 0x02009B35 RID: 39733
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __Received_Notify_FunctionParams
		{
			// Token: 0x04031146 RID: 201030
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031147 RID: 201031
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031148 RID: 201032
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
