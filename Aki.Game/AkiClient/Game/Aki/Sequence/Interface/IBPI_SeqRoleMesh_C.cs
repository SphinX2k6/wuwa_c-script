using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Interface
{
	// Token: 0x02003A3B RID: 14907
	[UnrealObjectPath("/Game/Aki/Sequence/Interface/BPI_SeqRoleMesh.BPI_SeqRoleMesh_C")]
	public interface IBPI_SeqRoleMesh_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F645 RID: 128581 RVA: 0x008B7388 File Offset: 0x008B5588
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetSeqMeshRef(ref TSoftObjectPtr<USkeletalMesh> MeshRef)
		{
			IBPI_SeqRoleMesh_C.__GetSeqMeshRef_FunctionParams* ptr = stackalloc IBPI_SeqRoleMesh_C.__GetSeqMeshRef_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(IBPI_SeqRoleMesh_C.__GetSeqMeshRef_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SeqRoleMesh_C_ReflectionImplementationFields.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr, 1);
			if (MeshRef != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->MeshRef, MeshRef.NativePtr, 1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SeqRoleMesh_C_ReflectionImplementationFields.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr);
			if (MeshRef != null)
			{
				FSoftObjectPtr.NativeCopy(MeshRef.NativePtr, &ptr->MeshRef, 1);
			}
			UnrealReflectionUtils.DestroyStruct(IBPI_SeqRoleMesh_C_ReflectionImplementationFields.__GetSeqMeshRef_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0400F130 RID: 61744
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Interface/BPI_SeqRoleMesh.BPI_SeqRoleMesh_C";

		// Token: 0x02009AD5 RID: 39637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSeqMeshRef_FunctionParams
		{
			// Token: 0x0403107D RID: 200829
			[FieldOffset(0)]
			public byte MeshRef;
		}
	}
}
