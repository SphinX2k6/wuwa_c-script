using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003079 RID: 12409
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqBlendActor.BPI_SeqBlendActor_C")]
	public interface IBPI_SeqBlendActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601D95E RID: 121182 RVA: 0x008FC0F4 File Offset: 0x008FA2F4
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void EndSeqSwitchPose(AActor To)
		{
			IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams* ptr = stackalloc IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBlendActor_C_ReflectionImplementationFields.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBlendActor_C_ReflectionImplementationFields.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D95F RID: 121183 RVA: 0x008FC14C File Offset: 0x008FA34C
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void BeginSeqSwitchPose(AActor From, AActor To, float SwitchTime)
		{
			IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams* ptr = stackalloc IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBlendActor_C_ReflectionImplementationFields.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBlendActor_C_ReflectionImplementationFields.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D960 RID: 121184 RVA: 0x008FC1C0 File Offset: 0x008FA3C0
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe void GetSeqBlendMesh(ref USkeletalMeshComponent Mesh)
		{
			IBPI_SeqBlendActor_C.__GetSeqBlendMesh_FunctionParams* ptr = stackalloc IBPI_SeqBlendActor_C.__GetSeqBlendMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqBlendActor_C.__GetSeqBlendMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBlendActor_C_ReflectionImplementationFields.__GetSeqBlendMesh_NativeFunctionPtr, (void*)ptr, 1);
			ref IBPI_SeqBlendActor_C.__GetSeqBlendMesh_FunctionParams ptr2 = ref *ptr;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			ptr2.Mesh = ((uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBlendActor_C_ReflectionImplementationFields.__GetSeqBlendMesh_NativeFunctionPtr, (void*)ptr);
			Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(ptr->Mesh);
		}

		// Token: 0x0400F974 RID: 63860
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqBlendActor.BPI_SeqBlendActor_C";

		// Token: 0x02008D60 RID: 36192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EndSeqSwitchPose_FunctionParams
		{
			// Token: 0x0402C8EA RID: 182506
			[FieldOffset(0)]
			public IntPtr To;
		}

		// Token: 0x02008D61 RID: 36193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BeginSeqSwitchPose_FunctionParams
		{
			// Token: 0x0402C8EB RID: 182507
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x0402C8EC RID: 182508
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0402C8ED RID: 182509
			[FieldOffset(16)]
			public float SwitchTime;
		}

		// Token: 0x02008D62 RID: 36194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqBlendMesh_FunctionParams
		{
			// Token: 0x0402C8EE RID: 182510
			[FieldOffset(0)]
			public IntPtr Mesh;
		}
	}
}
