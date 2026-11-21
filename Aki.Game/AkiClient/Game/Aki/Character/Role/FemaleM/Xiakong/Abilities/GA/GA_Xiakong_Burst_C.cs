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
	// Token: 0x02003297 RID: 12951
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class GA_Xiakong_Burst_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602073A RID: 132922 RVA: 0x00946EF8 File Offset: 0x009450F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Xiakong_Burst_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C");
			}
			return GA_Xiakong_Burst_C._ClassPtr;
		}

		// Token: 0x0602073B RID: 132923 RVA: 0x00946F1C File Offset: 0x0094511C
		public GA_Xiakong_Burst_C() : this(BuiltinUtils.AllocNativeUObject(GA_Xiakong_Burst_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602073C RID: 132924 RVA: 0x00946F44 File Offset: 0x00945144
		[NullableContext(1)]
		public GA_Xiakong_Burst_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Xiakong_Burst_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F1C RID: 16156
		// (get) Token: 0x0602073D RID: 132925 RVA: 0x00946F77 File Offset: 0x00945177
		// (set) Token: 0x0602073E RID: 132926 RVA: 0x00946F87 File Offset: 0x00945187
		public unsafe int 夏空
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_夏空);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_夏空) = value;
			}
		}

		// Token: 0x17003F1D RID: 16157
		// (get) Token: 0x0602073F RID: 132927 RVA: 0x00946F98 File Offset: 0x00945198
		// (set) Token: 0x06020740 RID: 132928 RVA: 0x00946FA8 File Offset: 0x009451A8
		public unsafe bool IsInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_IsInterrupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Xiakong_Burst_C.__PropertyOffset_IsInterrupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x06020741 RID: 132929 RVA: 0x00946FB9 File Offset: 0x009451B9
		// (set) Token: 0x06020742 RID: 132930 RVA: 0x00946FCD File Offset: 0x009451CD
		public unsafe UAkAudioEvent Ak_Event01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_Ak_Event01);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_Ak_Event01, value);
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x06020743 RID: 132931 RVA: 0x00946FE2 File Offset: 0x009451E2
		// (set) Token: 0x06020744 RID: 132932 RVA: 0x00946FF6 File Offset: 0x009451F6
		public unsafe UAkAudioEvent 目标
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_目标);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_目标, value);
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x06020745 RID: 132933 RVA: 0x0094700B File Offset: 0x0094520B
		// (set) Token: 0x06020746 RID: 132934 RVA: 0x0094701F File Offset: 0x0094521F
		public unsafe UAkAudioEvent Ak_Event02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_Ak_Event02);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Xiakong_Burst_C.__PropertyOffset_Ak_Event02, value);
			}
		}

		// Token: 0x06020747 RID: 132935 RVA: 0x00947034 File Offset: 0x00945234
		[SkipLocalsInit]
		public virtual void Buff校验()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__Buff校验_NativeFunctionPtr, null);
		}

		// Token: 0x06020748 RID: 132936 RVA: 0x00947048 File Offset: 0x00945248
		[SkipLocalsInit]
		public unsafe virtual void SetIsInterrupt(bool value)
		{
			GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__SetIsInterrupt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__SetIsInterrupt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->value = value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__SetIsInterrupt_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020749 RID: 132937 RVA: 0x00947090 File Offset: 0x00945290
		[SkipLocalsInit]
		public unsafe virtual void 判定结果(bool 是否成功, bool 是否后台自动判定, int 颜色类型)
		{
			GA_Xiakong_Burst_C.__判定结果_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__判定结果_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__判定结果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__判定结果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->是否成功 = 是否成功;
			ptr->是否后台自动判定 = 是否后台自动判定;
			ptr->颜色类型 = 颜色类型;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__判定结果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602074A RID: 132938 RVA: 0x009470E7 File Offset: 0x009452E7
		[SkipLocalsInit]
		public virtual void OnTick_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnTick_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602074B RID: 132939 RVA: 0x009470FB File Offset: 0x009452FB
		[SkipLocalsInit]
		public virtual void OnCancelled_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnCancelled_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602074C RID: 132940 RVA: 0x0094710F File Offset: 0x0094530F
		[SkipLocalsInit]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnInterrupted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602074D RID: 132941 RVA: 0x00947123 File Offset: 0x00945323
		[SkipLocalsInit]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnBlendOut_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602074E RID: 132942 RVA: 0x00947137 File Offset: 0x00945337
		[SkipLocalsInit]
		public virtual void OnCompleted_5D118C384AE61F1C80292E812B331739()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__OnCompleted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr, null);
		}

		// Token: 0x0602074F RID: 132943 RVA: 0x0094714B File Offset: 0x0094534B
		[SkipLocalsInit]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06020750 RID: 132944 RVA: 0x0094715F File Offset: 0x0094535F
		[SkipLocalsInit]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06020751 RID: 132945 RVA: 0x00947174 File Offset: 0x00945374
		[SkipLocalsInit]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020752 RID: 132946 RVA: 0x009471BC File Offset: 0x009453BC
		[SkipLocalsInit]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Xiakong_Burst_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Xiakong_Burst_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020753 RID: 132947 RVA: 0x00947202 File Offset: 0x00945402
		protected GA_Xiakong_Burst_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011888 RID: 71816
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/Xiakong/Abilities/GA/GA_Xiakong_Burst.GA_Xiakong_Burst_C";

		// Token: 0x04011889 RID: 71817
		private static IntPtr _ClassPtr;

		// Token: 0x0401188A RID: 71818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401188B RID: 71819
		internal static int __PropertyOffset_夏空;

		// Token: 0x0401188C RID: 71820
		internal static int __PropertyOffset_IsInterrupt;

		// Token: 0x0401188D RID: 71821
		internal static int __PropertyOffset_Ak_Event01;

		// Token: 0x0401188E RID: 71822
		internal static int __PropertyOffset_目标;

		// Token: 0x0401188F RID: 71823
		internal static int __PropertyOffset_Ak_Event02;

		// Token: 0x04011890 RID: 71824
		private static IntPtr __Buff校验_NativeFunctionPtr;

		// Token: 0x04011891 RID: 71825
		private static IntPtr __SetIsInterrupt_NativeFunctionPtr;

		// Token: 0x04011892 RID: 71826
		private static IntPtr __判定结果_NativeFunctionPtr;

		// Token: 0x04011893 RID: 71827
		private static IntPtr __OnTick_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x04011894 RID: 71828
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x04011895 RID: 71829
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x04011896 RID: 71830
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x04011897 RID: 71831
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E812B331739_NativeFunctionPtr;

		// Token: 0x04011898 RID: 71832
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04011899 RID: 71833
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x02008F6B RID: 36715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsInterrupt_FunctionParams
		{
			// Token: 0x0402CCEB RID: 183531
			[FieldOffset(0)]
			public bool value;
		}

		// Token: 0x02008F6C RID: 36716
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __判定结果_FunctionParams
		{
			// Token: 0x0402CCEC RID: 183532
			[FieldOffset(0)]
			public bool 是否成功;

			// Token: 0x0402CCED RID: 183533
			[FieldOffset(1)]
			public bool 是否后台自动判定;

			// Token: 0x0402CCEE RID: 183534
			[FieldOffset(4)]
			public int 颜色类型;
		}

		// Token: 0x02008F6D RID: 36717
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0402CCEF RID: 183535
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
