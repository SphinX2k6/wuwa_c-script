using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003A39 RID: 14905
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqBlendActor.BPI_SeqBlendActor_C")]
	public interface IBPI_SeqBlendActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F640 RID: 128576 RVA: 0x008B71FC File Offset: 0x008B53FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void EndSeqSwitchPose(AActor To)
		{
			IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams* ptr = stackalloc IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_SeqBlendActor_C.__EndSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBlendActor_C_ReflectionImplementationFields.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBlendActor_C_ReflectionImplementationFields.__EndSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F641 RID: 128577 RVA: 0x008B7254 File Offset: 0x008B5454
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BeginSeqSwitchPose(AActor From, AActor To, float SwitchTime)
		{
			IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams* ptr = stackalloc IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IBPI_SeqBlendActor_C.__BeginSeqSwitchPose_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqBlendActor_C_ReflectionImplementationFields.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			ptr->SwitchTime = SwitchTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqBlendActor_C_ReflectionImplementationFields.__BeginSeqSwitchPose_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F642 RID: 128578 RVA: 0x008B72C8 File Offset: 0x008B54C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0400F12E RID: 61742
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqBlendActor.BPI_SeqBlendActor_C";

		// Token: 0x02009AD1 RID: 39633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EndSeqSwitchPose_FunctionParams
		{
			// Token: 0x04031077 RID: 200823
			[FieldOffset(0)]
			public IntPtr To;
		}

		// Token: 0x02009AD2 RID: 39634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __BeginSeqSwitchPose_FunctionParams
		{
			// Token: 0x04031078 RID: 200824
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04031079 RID: 200825
			[FieldOffset(8)]
			public IntPtr To;

			// Token: 0x0403107A RID: 200826
			[FieldOffset(16)]
			public float SwitchTime;
		}

		// Token: 0x02009AD3 RID: 39635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSeqBlendMesh_FunctionParams
		{
			// Token: 0x0403107B RID: 200827
			[FieldOffset(0)]
			public IntPtr Mesh;
		}
	}
}
