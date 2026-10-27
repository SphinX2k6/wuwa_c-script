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
	// Token: 0x02004190 RID: 16784
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class GPUNPCData_C : UBakedBoneInstanceDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B89A RID: 178330 RVA: 0x00A03555 File Offset: 0x00A01755
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GPUNPCData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C");
			}
			return GPUNPCData_C._ClassPtr;
		}

		// Token: 0x0602B89B RID: 178331 RVA: 0x00A0357C File Offset: 0x00A0177C
		public GPUNPCData_C() : this(BuiltinUtils.AllocNativeUObject(GPUNPCData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B89C RID: 178332 RVA: 0x00A035A4 File Offset: 0x00A017A4
		[NullableContext(1)]
		public GPUNPCData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GPUNPCData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006BBD RID: 27581
		// (get) Token: 0x0602B89D RID: 178333 RVA: 0x00A035D7 File Offset: 0x00A017D7
		// (set) Token: 0x0602B89E RID: 178334 RVA: 0x00A035EB File Offset: 0x00A017EB
		public unsafe USkeletalMesh SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006BBE RID: 27582
		// (get) Token: 0x0602B89F RID: 178335 RVA: 0x00A03600 File Offset: 0x00A01800
		// (set) Token: 0x0602B8A0 RID: 178336 RVA: 0x00A03614 File Offset: 0x00A01814
		public unsafe PD_NpcSetupData_C NpcSetupData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_NpcSetupData_C>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006BBF RID: 27583
		// (get) Token: 0x0602B8A1 RID: 178337 RVA: 0x00A03629 File Offset: 0x00A01829
		// (set) Token: 0x0602B8A2 RID: 178338 RVA: 0x00A0363D File Offset: 0x00A0183D
		public unsafe UBakedBoneTexture2D Combined_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006BC0 RID: 27584
		// (get) Token: 0x0602B8A3 RID: 178339 RVA: 0x00A03652 File Offset: 0x00A01852
		// (set) Token: 0x0602B8A4 RID: 178340 RVA: 0x00A03666 File Offset: 0x00A01866
		public unsafe UBakedBoneMontageInfoAsset BakedBoneMontageInfoAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneMontageInfoAsset>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCData_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602B8A5 RID: 178341 RVA: 0x00A0367B File Offset: 0x00A0187B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清空非合批资源()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__清空非合批资源_NativeFunctionPtr, null);
		}

		// Token: 0x0602B8A6 RID: 178342 RVA: 0x00A03690 File Offset: 0x00A01890
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasCombinedBakedBoneTexture(ref bool Result)
		{
			GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams* ptr = stackalloc GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(GPUNPCData_C.__HasCombinedBakedBoneTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__HasCombinedBakedBoneTexture_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__HasCombinedBakedBoneTexture_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0602B8A7 RID: 178343 RVA: 0x00A036E0 File Offset: 0x00A018E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetTotalNumFrames(ref int OutTotalNumFrames)
		{
			GPUNPCData_C.__GetTotalNumFrames_FunctionParams* ptr = stackalloc GPUNPCData_C.__GetTotalNumFrames_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GPUNPCData_C.__GetTotalNumFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__GetTotalNumFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTotalNumFrames = OutTotalNumFrames;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__GetTotalNumFrames_NativeFunctionPtr, (void*)ptr);
			OutTotalNumFrames = ptr->OutTotalNumFrames;
		}

		// Token: 0x0602B8A8 RID: 178344 RVA: 0x00A03730 File Offset: 0x00A01930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMaxNumTracks(ref int OutMaxNumTracks)
		{
			GPUNPCData_C.__GetMaxNumTracks_FunctionParams* ptr = stackalloc GPUNPCData_C.__GetMaxNumTracks_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GPUNPCData_C.__GetMaxNumTracks_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__GetMaxNumTracks_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutMaxNumTracks = OutMaxNumTracks;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__GetMaxNumTracks_NativeFunctionPtr, (void*)ptr);
			OutMaxNumTracks = ptr->OutMaxNumTracks;
		}

		// Token: 0x0602B8A9 RID: 178345 RVA: 0x00A03780 File Offset: 0x00A01980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602B8AA RID: 178346 RVA: 0x00A03820 File Offset: 0x00A01A20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HasSetSkeletalMesh(ref bool HasSet)
		{
			GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams* ptr = stackalloc GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(GPUNPCData_C.__HasSetSkeletalMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GPUNPCData_C.__HasSetSkeletalMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HasSet = HasSet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GPUNPCData_C.__HasSetSkeletalMesh_NativeFunctionPtr, (void*)ptr);
			HasSet = ptr->HasSet;
		}

		// Token: 0x0602B8AB RID: 178347 RVA: 0x00A03870 File Offset: 0x00A01A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602B8AC RID: 178348 RVA: 0x00A03910 File Offset: 0x00A01B10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602B8AD RID: 178349 RVA: 0x00A03984 File Offset: 0x00A01B84
		protected GPUNPCData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016AAD RID: 92845
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/GPUNPCData.GPUNPCData_C";

		// Token: 0x04016AAE RID: 92846
		private static IntPtr _ClassPtr;

		// Token: 0x04016AAF RID: 92847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016AB0 RID: 92848
		internal static int __PropertyOffset_0;

		// Token: 0x04016AB1 RID: 92849
		internal static int __PropertyOffset_1;

		// Token: 0x04016AB2 RID: 92850
		internal static int __PropertyOffset_2;

		// Token: 0x04016AB3 RID: 92851
		internal static int __PropertyOffset_3;

		// Token: 0x04016AB4 RID: 92852
		private static IntPtr __清空非合批资源_NativeFunctionPtr;

		// Token: 0x04016AB5 RID: 92853
		private static IntPtr __HasCombinedBakedBoneTexture_NativeFunctionPtr;

		// Token: 0x04016AB6 RID: 92854
		private static IntPtr __GetTotalNumFrames_NativeFunctionPtr;

		// Token: 0x04016AB7 RID: 92855
		private static IntPtr __GetMaxNumTracks_NativeFunctionPtr;

		// Token: 0x04016AB8 RID: 92856
		private static IntPtr __GetMeshesFromNPCSetupData_NativeFunctionPtr;

		// Token: 0x04016AB9 RID: 92857
		private static IntPtr __HasSetSkeletalMesh_NativeFunctionPtr;

		// Token: 0x04016ABA RID: 92858
		private static IntPtr __生成MainMesh和SubMeshes_NativeFunctionPtr;

		// Token: 0x04016ABB RID: 92859
		private static IntPtr __随机起始动画时间噪声贴图_NativeFunctionPtr;

		// Token: 0x0200A541 RID: 42305
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasCombinedBakedBoneTexture_FunctionParams
		{
			// Token: 0x040323BC RID: 205756
			[FieldOffset(0)]
			public bool Result;
		}

		// Token: 0x0200A542 RID: 42306
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetTotalNumFrames_FunctionParams
		{
			// Token: 0x040323BD RID: 205757
			[FieldOffset(0)]
			public int OutTotalNumFrames;
		}

		// Token: 0x0200A543 RID: 42307
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMaxNumTracks_FunctionParams
		{
			// Token: 0x040323BE RID: 205758
			[FieldOffset(0)]
			public int OutMaxNumTracks;
		}

		// Token: 0x0200A544 RID: 42308
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMeshesFromNPCSetupData_FunctionParams
		{
			// Token: 0x040323BF RID: 205759
			[FieldOffset(0)]
			public IntPtr OutMainMesh;

			// Token: 0x040323C0 RID: 205760
			[FieldOffset(8)]
			public byte OutSubMeshes;
		}

		// Token: 0x0200A545 RID: 42309
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HasSetSkeletalMesh_FunctionParams
		{
			// Token: 0x040323C1 RID: 205761
			[FieldOffset(0)]
			public bool HasSet;
		}

		// Token: 0x0200A546 RID: 42310
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __生成MainMesh和SubMeshes_FunctionParams
		{
			// Token: 0x040323C2 RID: 205762
			[FieldOffset(0)]
			public IntPtr OutMainMesh;

			// Token: 0x040323C3 RID: 205763
			[FieldOffset(8)]
			public byte OutSubMeshes;
		}

		// Token: 0x0200A547 RID: 42311
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __随机起始动画时间噪声贴图_FunctionParams
		{
			// Token: 0x040323C4 RID: 205764
			[FieldOffset(0)]
			public IntPtr OutNoiseTex;

			// Token: 0x040323C5 RID: 205765
			[FieldOffset(8)]
			public int OutNoiseIndex;
		}
	}
}
