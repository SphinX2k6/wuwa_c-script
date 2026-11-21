using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC
{
	// Token: 0x020032B2 RID: 12978
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class GPUNPCData_C : UBakedBoneInstanceDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B94 RID: 134036 RVA: 0x0094D715 File Offset: 0x0094B915
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GPUNPCData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C");
			}
			return GPUNPCData_C._ClassPtr;
		}

		// Token: 0x06020B95 RID: 134037 RVA: 0x0094D73C File Offset: 0x0094B93C
		public GPUNPCData_C() : this(BuiltinUtils.AllocNativeUObject(GPUNPCData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B96 RID: 134038 RVA: 0x0094D764 File Offset: 0x0094B964
		[NullableContext(1)]
		public GPUNPCData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GPUNPCData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x06020B97 RID: 134039 RVA: 0x0094D797 File Offset: 0x0094B997
		// (set) Token: 0x06020B98 RID: 134040 RVA: 0x0094D7AB File Offset: 0x0094B9AB
		[Nullable(2)]
		public unsafe USkeletalMesh SkeletalMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_SkeletalMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_SkeletalMesh, value);
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x06020B99 RID: 134041 RVA: 0x0094D7C0 File Offset: 0x0094B9C0
		// (set) Token: 0x06020B9A RID: 134042 RVA: 0x0094D7D4 File Offset: 0x0094B9D4
		[Nullable(2)]
		public unsafe PD_NpcSetupData_C NpcSetupData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_NpcSetupData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_NpcSetupData, value);
			}
		}

		// Token: 0x06020B9B RID: 134043 RVA: 0x0094D7E9 File Offset: 0x0094B9E9
		[SkipLocalsInit]
		public virtual void 清空非合批资源()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__清空非合批资源_NativeFunctionPtr, null);
		}

		// Token: 0x06020B9C RID: 134044 RVA: 0x0094D800 File Offset: 0x0094BA00
		[SkipLocalsInit]
		public unsafe virtual void HasCombinedBakedBoneTexture(ref bool Result)
		{
			GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams* ptr = stackalloc GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__HasCombinedBakedBoneTexture_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__HasCombinedBakedBoneTexture_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x06020B9D RID: 134045 RVA: 0x0094D850 File Offset: 0x0094BA50
		[SkipLocalsInit]
		public unsafe virtual void GetTotalNumFrames(ref int OutTotalNumFrames)
		{
			GPUNPCData_C.__GetTotalNumFrames_FunctionParams* ptr = stackalloc GPUNPCData_C.__GetTotalNumFrames_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GPUNPCData_C.__GetTotalNumFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__GetTotalNumFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTotalNumFrames = OutTotalNumFrames;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__GetTotalNumFrames_NativeFunctionPtr, (void*)ptr);
			OutTotalNumFrames = ptr->OutTotalNumFrames;
		}

		// Token: 0x06020B9E RID: 134046 RVA: 0x0094D8A0 File Offset: 0x0094BAA0
		[SkipLocalsInit]
		public unsafe virtual void GetMaxNumTracks(ref int OutMaxNumTracks)
		{
			GPUNPCData_C.__GetMaxNumTracks_FunctionParams* ptr = stackalloc GPUNPCData_C.__GetMaxNumTracks_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GPUNPCData_C.__GetMaxNumTracks_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__GetMaxNumTracks_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutMaxNumTracks = OutMaxNumTracks;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__GetMaxNumTracks_NativeFunctionPtr, (void*)ptr);
			OutMaxNumTracks = ptr->OutMaxNumTracks;
		}

		// Token: 0x06020B9F RID: 134047 RVA: 0x0094D8F0 File Offset: 0x0094BAF0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void GetMeshesFromNPCSetupData(ref USkeletalMesh OutMainMesh, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMesh> OutSubMeshes)
		{
			GPUNPCData_C.__GetMeshesFromNPCSetupData_FunctionParams* ptr = stackalloc GPUNPCData_C.__GetMeshesFromNPCSetupData_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GPUNPCData_C.__GetMeshesFromNPCSetupData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__GetMeshesFromNPCSetupData_NativeFunctionPtr, (void*)ptr, 1);
			ref GPUNPCData_C.__GetMeshesFromNPCSetupData_FunctionParams ptr2 = ref *ptr;
			USkeletalMesh uskeletalMesh = OutMainMesh;
			ptr2.OutMainMesh = ((uskeletalMesh != null) ? uskeletalMesh.NativePtr : IntPtr.Zero);
			TArray<USkeletalMesh> tarray = OutSubMeshes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSubMeshes);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__GetMeshesFromNPCSetupData_NativeFunctionPtr, (void*)ptr);
			OutMainMesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMesh>(ptr->OutMainMesh);
			TArray<USkeletalMesh> tarray2 = OutSubMeshes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubMeshes);
			}
			UnrealReflectionUtils.DestroyStruct(GPUNPCData_C.__GetMeshesFromNPCSetupData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020BA0 RID: 134048 RVA: 0x0094D990 File Offset: 0x0094BB90
		[SkipLocalsInit]
		public unsafe virtual void HasSetSkeletalMesh(ref bool HasSet)
		{
			GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams* ptr = stackalloc GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__HasSetSkeletalMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HasSet = HasSet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__HasSetSkeletalMesh_NativeFunctionPtr, (void*)ptr);
			HasSet = ptr->HasSet;
		}

		// Token: 0x06020BA1 RID: 134049 RVA: 0x0094D9E0 File Offset: 0x0094BBE0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 生成MainMesh和SubMeshes(ref USkeletalMesh OutMainMesh, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMesh> OutSubMeshes)
		{
			GPUNPCData_C.__生成MainMesh和SubMeshes_FunctionParams* ptr = stackalloc GPUNPCData_C.__生成MainMesh和SubMeshes_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GPUNPCData_C.__生成MainMesh和SubMeshes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__生成MainMesh和SubMeshes_NativeFunctionPtr, (void*)ptr, 1);
			ref GPUNPCData_C.__生成MainMesh和SubMeshes_FunctionParams ptr2 = ref *ptr;
			USkeletalMesh uskeletalMesh = OutMainMesh;
			ptr2.OutMainMesh = ((uskeletalMesh != null) ? uskeletalMesh.NativePtr : IntPtr.Zero);
			TArray<USkeletalMesh> tarray = OutSubMeshes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSubMeshes);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__生成MainMesh和SubMeshes_NativeFunctionPtr, (void*)ptr);
			OutMainMesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMesh>(ptr->OutMainMesh);
			TArray<USkeletalMesh> tarray2 = OutSubMeshes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubMeshes);
			}
			UnrealReflectionUtils.DestroyStruct(GPUNPCData_C.__生成MainMesh和SubMeshes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020BA2 RID: 134050 RVA: 0x0094DA80 File Offset: 0x0094BC80
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 随机起始动画时间噪声贴图(ref UTexture2D OutNoiseTex, ref int OutNoiseIndex)
		{
			GPUNPCData_C.__随机起始动画时间噪声贴图_FunctionParams* ptr = stackalloc GPUNPCData_C.__随机起始动画时间噪声贴图_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GPUNPCData_C.__随机起始动画时间噪声贴图_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__随机起始动画时间噪声贴图_NativeFunctionPtr, (void*)ptr, 1);
			ref GPUNPCData_C.__随机起始动画时间噪声贴图_FunctionParams ptr2 = ref *ptr;
			UTexture2D utexture2D = OutNoiseTex;
			ptr2.OutNoiseTex = ((utexture2D != null) ? utexture2D.NativePtr : IntPtr.Zero);
			ptr->OutNoiseIndex = OutNoiseIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__随机起始动画时间噪声贴图_NativeFunctionPtr, (void*)ptr);
			OutNoiseTex = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ptr->OutNoiseTex);
			OutNoiseIndex = ptr->OutNoiseIndex;
		}

		// Token: 0x06020BA3 RID: 134051 RVA: 0x0094DAF4 File Offset: 0x0094BCF4
		protected GPUNPCData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B34 RID: 72500
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C";

		// Token: 0x04011B35 RID: 72501
		private static IntPtr _ClassPtr;

		// Token: 0x04011B36 RID: 72502
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B37 RID: 72503
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x04011B38 RID: 72504
		internal static int __PropertyOffset_NpcSetupData;

		// Token: 0x04011B39 RID: 72505
		private static IntPtr __清空非合批资源_NativeFunctionPtr;

		// Token: 0x04011B3A RID: 72506
		private static IntPtr __HasCombinedBakedBoneTexture_NativeFunctionPtr;

		// Token: 0x04011B3B RID: 72507
		private static IntPtr __GetTotalNumFrames_NativeFunctionPtr;

		// Token: 0x04011B3C RID: 72508
		private static IntPtr __GetMaxNumTracks_NativeFunctionPtr;

		// Token: 0x04011B3D RID: 72509
		private static IntPtr __GetMeshesFromNPCSetupData_NativeFunctionPtr;

		// Token: 0x04011B3E RID: 72510
		private static IntPtr __HasSetSkeletalMesh_NativeFunctionPtr;

		// Token: 0x04011B3F RID: 72511
		private static IntPtr __生成MainMesh和SubMeshes_NativeFunctionPtr;

		// Token: 0x04011B40 RID: 72512
		private static IntPtr __随机起始动画时间噪声贴图_NativeFunctionPtr;

		// Token: 0x02008FAA RID: 36778
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasCombinedBakedBoneTexture_FunctionParams
		{
			// Token: 0x0402CD4E RID: 183630
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x02008FAB RID: 36779
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetTotalNumFrames_FunctionParams
		{
			// Token: 0x0402CD4F RID: 183631
			[FieldOffset(0)]
			public int OutTotalNumFrames;
		}

		// Token: 0x02008FAC RID: 36780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMaxNumTracks_FunctionParams
		{
			// Token: 0x0402CD50 RID: 183632
			[FieldOffset(0)]
			public int OutMaxNumTracks;
		}

		// Token: 0x02008FAD RID: 36781
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMeshesFromNPCSetupData_FunctionParams
		{
			// Token: 0x0402CD51 RID: 183633
			[FieldOffset(0)]
			public IntPtr OutMainMesh;

			// Token: 0x0402CD52 RID: 183634
			[FieldOffset(8)]
			public byte OutSubMeshes;
		}

		// Token: 0x02008FAE RID: 36782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSetSkeletalMesh_FunctionParams
		{
			// Token: 0x0402CD53 RID: 183635
			[FieldOffset(0)]
			public bool HasSet;
		}

		// Token: 0x02008FAF RID: 36783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __生成MainMesh和SubMeshes_FunctionParams
		{
			// Token: 0x0402CD54 RID: 183636
			[FieldOffset(0)]
			public IntPtr OutMainMesh;

			// Token: 0x0402CD55 RID: 183637
			[FieldOffset(8)]
			public byte OutSubMeshes;
		}

		// Token: 0x02008FB0 RID: 36784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __随机起始动画时间噪声贴图_FunctionParams
		{
			// Token: 0x0402CD56 RID: 183638
			[FieldOffset(0)]
			public IntPtr OutNoiseTex;

			// Token: 0x0402CD57 RID: 183639
			[FieldOffset(8)]
			public int OutNoiseIndex;
		}
	}
}
