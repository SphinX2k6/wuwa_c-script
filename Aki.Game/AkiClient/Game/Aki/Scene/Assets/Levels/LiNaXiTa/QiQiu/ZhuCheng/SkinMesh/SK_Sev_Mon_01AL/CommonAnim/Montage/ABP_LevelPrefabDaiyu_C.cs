using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Assets.Levels.LiNaXiTa.QiQiu.ZhuCheng.SkinMesh.SK_Sev_Mon_01AL.CommonAnim.Montage
{
	// Token: 0x020030A7 RID: 12455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C")]
	[UnrealStructLayout(4640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4628)]
	public class ABP_LevelPrefabDaiyu_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD3B RID: 122171 RVA: 0x009031B8 File Offset: 0x009013B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_LevelPrefabDaiyu_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C");
			}
			return ABP_LevelPrefabDaiyu_C._ClassPtr;
		}

		// Token: 0x0601DD3C RID: 122172 RVA: 0x009031DC File Offset: 0x009013DC
		public ABP_LevelPrefabDaiyu_C() : this(BuiltinUtils.AllocNativeUObject(ABP_LevelPrefabDaiyu_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD3D RID: 122173 RVA: 0x00903204 File Offset: 0x00901404
		public ABP_LevelPrefabDaiyu_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_LevelPrefabDaiyu_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0601DD3E RID: 122174 RVA: 0x00903237 File Offset: 0x00901437
		// (set) Token: 0x0601DD3F RID: 122175 RVA: 0x0090324B File Offset: 0x0090144B
		public unsafe string State
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_State)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_State)), value);
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0601DD40 RID: 122176 RVA: 0x00903260 File Offset: 0x00901460
		// (set) Token: 0x0601DD41 RID: 122177 RVA: 0x00903270 File Offset: 0x00901470
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_LevelPrefabDaiyu_C.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x0601DD42 RID: 122178 RVA: 0x00903284 File Offset: 0x00901484
		[SkipLocalsInit]
		public unsafe virtual void SetPlayRate(float playRate)
		{
			ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams* ptr = stackalloc ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_LevelPrefabDaiyu_C.__SetPlayRate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_LevelPrefabDaiyu_C.__SetPlayRate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->playRate = playRate;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_LevelPrefabDaiyu_C.__SetPlayRate_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DD43 RID: 122179 RVA: 0x009032CC File Offset: 0x009014CC
		[SkipLocalsInit]
		public unsafe virtual void SetState(string NewParam)
		{
			ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams* ptr = stackalloc ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ABP_LevelPrefabDaiyu_C.__SetState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->NewParam), NewParam);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(ABP_LevelPrefabDaiyu_C.__SetState_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD44 RID: 122180 RVA: 0x00903329 File Offset: 0x00901529
		protected ABP_LevelPrefabDaiyu_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBC8 RID: 64456
		public new const string __ObjectPath = "/Game/Aki/Scene/Assets/Levels/LiNaXiTa/QiQiu/ZhuCheng/SkinMesh/SK_Sev_Mon_01AL/CommonAnim/Montage/ABP_LevelPrefabDaiyu.ABP_LevelPrefabDaiyu_C";

		// Token: 0x0400FBC9 RID: 64457
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBCA RID: 64458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBCB RID: 64459
		internal static int __PropertyOffset_State;

		// Token: 0x0400FBCC RID: 64460
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x0400FBCD RID: 64461
		private static IntPtr __SetPlayRate_NativeFunctionPtr;

		// Token: 0x0400FBCE RID: 64462
		private static IntPtr __SetState_NativeFunctionPtr;

		// Token: 0x02008DB9 RID: 36281
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPlayRate_FunctionParams
		{
			// Token: 0x0402C9A6 RID: 182694
			[FieldOffset(0)]
			public float playRate;
		}

		// Token: 0x02008DBA RID: 36282
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetState_FunctionParams
		{
			// Token: 0x0402C9A7 RID: 182695
			[FieldOffset(0)]
			public FString NewParam;
		}
	}
}
