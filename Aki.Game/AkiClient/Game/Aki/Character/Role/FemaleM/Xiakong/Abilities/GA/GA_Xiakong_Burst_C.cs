using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleM.Xiakong.Abilities.GA
{
	// Token: 0x02004099 RID: 16537
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class GA_Xiakong_Burst_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A972 RID: 174450 RVA: 0x009E55E8 File Offset: 0x009E37E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Xiakong_Burst_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C");
			}
			return GA_Xiakong_Burst_C._ClassPtr;
		}

		// Token: 0x0602A973 RID: 174451 RVA: 0x009E560C File Offset: 0x009E380C
		public GA_Xiakong_Burst_C() : this(BuiltinUtils.AllocNativeUObject(GA_Xiakong_Burst_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A974 RID: 174452 RVA: 0x009E5634 File Offset: 0x009E3834
		[NullableContext(1)]
		public GA_Xiakong_Burst_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Xiakong_Burst_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700686E RID: 26734
		// (get) Token: 0x0602A975 RID: 174453 RVA: 0x009E5667 File Offset: 0x009E3867
		// (set) Token: 0x0602A976 RID: 174454 RVA: 0x009E5677 File Offset: 0x009E3877
		public unsafe int 夏空
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700686F RID: 26735
		// (get) Token: 0x0602A977 RID: 174455 RVA: 0x009E5688 File Offset: 0x009E3888
		// (set) Token: 0x0602A978 RID: 174456 RVA: 0x009E5698 File Offset: 0x009E3898
		public unsafe bool IsInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006870 RID: 26736
		// (get) Token: 0x0602A979 RID: 174457 RVA: 0x009E56A9 File Offset: 0x009E38A9
		// (set) Token: 0x0602A97A RID: 174458 RVA: 0x009E56BD File Offset: 0x009E38BD
		public unsafe UAkAudioEvent Ak_Event01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006871 RID: 26737
		// (get) Token: 0x0602A97B RID: 174459 RVA: 0x009E56D2 File Offset: 0x009E38D2
		// (set) Token: 0x0602A97C RID: 174460 RVA: 0x009E56E6 File Offset: 0x009E38E6
		public unsafe UAkAudioEvent 目标
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006872 RID: 26738
		// (get) Token: 0x0602A97D RID: 174461 RVA: 0x009E56FB File Offset: 0x009E38FB
		// (set) Token: 0x0602A97E RID: 174462 RVA: 0x009E570F File Offset: 0x009E390F
		public unsafe UAkAudioEvent Ak_Event02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x0602A97F RID: 174463 RVA: 0x009E5724 File Offset: 0x009E3924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Buff校验()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__Buff校验_NativeFunctionPtr, null);
		}

		// Token: 0x0602A980 RID: 174464 RVA: 0x009E5738 File Offset: 0x009E3938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetIsInterrupt(bool value)
		{
			GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__SetIsInterrupt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__SetIsInterrupt_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A981 RID: 174465 RVA: 0x009E5780 File Offset: 0x009E3980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 判定结果(bool 是否成功, bool 是否后台自动判定, int 颜色类型)
		{
			GA_Xiakong_Burst_C.__判定结果_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__判定结果_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__判定结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__判定结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->是否成功 = 是否成功;
			ptr->是否后台自动判定 = 是否后台自动判定;
			ptr->颜色类型 = 颜色类型;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__判定结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A982 RID: 174466 RVA: 0x009E57D7 File Offset: 0x009E39D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnTick_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602A983 RID: 174467 RVA: 0x009E57EB File Offset: 0x009E39EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnCancelled_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602A984 RID: 174468 RVA: 0x009E57FF File Offset: 0x009E39FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnInterrupted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602A985 RID: 174469 RVA: 0x009E5813 File Offset: 0x009E3A13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnBlendOut_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602A986 RID: 174470 RVA: 0x009E5827 File Offset: 0x009E3A27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnCompleted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602A987 RID: 174471 RVA: 0x009E583B File Offset: 0x009E3A3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A988 RID: 174472 RVA: 0x009E584F File Offset: 0x009E3A4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A989 RID: 174473 RVA: 0x009E5864 File Offset: 0x009E3A64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A98A RID: 174474 RVA: 0x009E58AC File Offset: 0x009E3AAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A98B RID: 174475 RVA: 0x009E58F3 File Offset: 0x009E3AF3
		protected GA_Xiakong_Burst_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401606E RID: 90222
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C";

		// Token: 0x0401606F RID: 90223
		private static IntPtr _ClassPtr;

		// Token: 0x04016070 RID: 90224
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016071 RID: 90225
		internal new static int __PropertyOffset_1;

		// Token: 0x04016072 RID: 90226
		internal new static int __PropertyOffset_2;

		// Token: 0x04016073 RID: 90227
		internal new static int __PropertyOffset_3;

		// Token: 0x04016074 RID: 90228
		internal static int __PropertyOffset_4;

		// Token: 0x04016075 RID: 90229
		internal static int __PropertyOffset_5;

		// Token: 0x04016076 RID: 90230
		private static IntPtr __Buff校验_NativeFunctionPtr;

		// Token: 0x04016077 RID: 90231
		private static IntPtr __SetIsInterrupt_NativeFunctionPtr;

		// Token: 0x04016078 RID: 90232
		private static IntPtr __判定结果_NativeFunctionPtr;

		// Token: 0x04016079 RID: 90233
		private static IntPtr __OnTick_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x0401607A RID: 90234
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x0401607B RID: 90235
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x0401607C RID: 90236
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x0401607D RID: 90237
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x0401607E RID: 90238
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401607F RID: 90239
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3D4 RID: 41940
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsInterrupt_FunctionParams
		{
			// Token: 0x040321CB RID: 205259
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x0200A3D5 RID: 41941
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __判定结果_FunctionParams
		{
			// Token: 0x040321CC RID: 205260
			[FieldOffset(0)]
			public bool 是否成功;

			// Token: 0x040321CD RID: 205261
			[FieldOffset(1)]
			public bool 是否后台自动判定;

			// Token: 0x040321CE RID: 205262
			[FieldOffset(4)]
			public int 颜色类型;
		}

		// Token: 0x0200A3D6 RID: 41942
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040321CF RID: 205263
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
