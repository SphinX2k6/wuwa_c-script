using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Assets.Levels.LiNaXiTa.QiQiu.ZhuCheng.SkinMesh.SK_Sev_Mon_01AL.CommonAnim.Montage
{
	// Token: 0x02003A72 RID: 14962
	[UnrealObjectPath("/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C")]
	[UnrealStructLayout(4624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4612)]
	public class ABP_LevelPrefabDaiyu_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAD2 RID: 129746 RVA: 0x008BF335 File Offset: 0x008BD535
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_LevelPrefabDaiyu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C");
			}
			return ABP_LevelPrefabDaiyu_C._ClassPtr;
		}

		// Token: 0x0601FAD3 RID: 129747 RVA: 0x008BF35C File Offset: 0x008BD55C
		public ABP_LevelPrefabDaiyu_C() : this(BuiltinUtils.AllocNativeUObject(ABP_LevelPrefabDaiyu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAD4 RID: 129748 RVA: 0x008BF384 File Offset: 0x008BD584
		[NullableContext(1)]
		public ABP_LevelPrefabDaiyu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_LevelPrefabDaiyu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0601FAD5 RID: 129749 RVA: 0x008BF3B7 File Offset: 0x008BD5B7
		// (set) Token: 0x0601FAD6 RID: 129750 RVA: 0x008BF3CB File Offset: 0x008BD5CB
		[Nullable(1)]
		public unsafe string State
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_18)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_18)), value);
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0601FAD7 RID: 129751 RVA: 0x008BF3E0 File Offset: 0x008BD5E0
		// (set) Token: 0x0601FAD8 RID: 129752 RVA: 0x008BF3F0 File Offset: 0x008BD5F0
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x0601FAD9 RID: 129753 RVA: 0x008BF404 File Offset: 0x008BD604
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_LevelPrefabDaiyu_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_LevelPrefabDaiyu_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_LevelPrefabDaiyu_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_LevelPrefabDaiyu_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_LevelPrefabDaiyu_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0601FADA RID: 129754 RVA: 0x008BF48C File Offset: 0x008BD68C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPlayRate(float playRate)
		{
			ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams* ptr = stackalloc ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_LevelPrefabDaiyu_C.__SetPlayRate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->playRate = playRate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_LevelPrefabDaiyu_C.__SetPlayRate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FADB RID: 129755 RVA: 0x008BF4D4 File Offset: 0x008BD6D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetState(string NewParam)
		{
			ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams* ptr = stackalloc ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->NewParam), NewParam);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FADC RID: 129756 RVA: 0x008BF531 File Offset: 0x008BD731
		protected ABP_LevelPrefabDaiyu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F404 RID: 62468
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C";

		// Token: 0x0400F405 RID: 62469
		private static IntPtr _ClassPtr;

		// Token: 0x0400F406 RID: 62470
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F407 RID: 62471
		internal static int __PropertyOffset_18;

		// Token: 0x0400F408 RID: 62472
		internal static int __PropertyOffset_19;

		// Token: 0x0400F409 RID: 62473
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x0400F40A RID: 62474
		private static IntPtr __SetPlayRate_NativeFunctionPtr;

		// Token: 0x0400F40B RID: 62475
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x02009B2F RID: 39727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04031138 RID: 201016
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x02009B30 RID: 39728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPlayRate_FunctionParams
		{
			// Token: 0x04031139 RID: 201017
			[FieldOffset(0)]
			public float playRate;
		}

		// Token: 0x02009B31 RID: 39729
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x0403113A RID: 201018
			[FieldOffset(0)]
			public FString NewParam;
		}
	}
}
