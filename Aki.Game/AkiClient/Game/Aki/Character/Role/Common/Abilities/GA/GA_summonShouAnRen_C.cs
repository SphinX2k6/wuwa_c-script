using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200416A RID: 16746
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonShouAnRen.GA_summonShouAnRen_C")]
	[UnrealStructLayout(1680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class GA_summonShouAnRen_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4ED RID: 177389 RVA: 0x009FC44D File Offset: 0x009FA64D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_summonShouAnRen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonShouAnRen.GA_summonShouAnRen_C");
			}
			return GA_summonShouAnRen_C._ClassPtr;
		}

		// Token: 0x0602B4EE RID: 177390 RVA: 0x009FC474 File Offset: 0x009FA674
		public GA_summonShouAnRen_C() : this(BuiltinUtils.AllocNativeUObject(GA_summonShouAnRen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4EF RID: 177391 RVA: 0x009FC49C File Offset: 0x009FA69C
		[NullableContext(1)]
		public GA_summonShouAnRen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_summonShouAnRen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AD7 RID: 27351
		// (get) Token: 0x0602B4F0 RID: 177392 RVA: 0x009FC4CF File Offset: 0x009FA6CF
		// (set) Token: 0x0602B4F1 RID: 177393 RVA: 0x009FC4DF File Offset: 0x009FA6DF
		public unsafe float 原来质量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006AD8 RID: 27352
		// (get) Token: 0x0602B4F2 RID: 177394 RVA: 0x009FC4F0 File Offset: 0x009FA6F0
		// (set) Token: 0x0602B4F3 RID: 177395 RVA: 0x009FC529 File Offset: 0x009FA729
		[Nullable(1)]
		public TMap<int, bool> NewVar_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, bool> result;
				if ((result = this._NewVar_0) == null)
				{
					result = (this._NewVar_0 = new TMap<int, bool>(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NewVar_0.CopyAssign(value);
			}
		}

		// Token: 0x17006AD9 RID: 27353
		// (get) Token: 0x0602B4F4 RID: 177396 RVA: 0x009FC537 File Offset: 0x009FA737
		// (set) Token: 0x0602B4F5 RID: 177397 RVA: 0x009FC547 File Offset: 0x009FA747
		public unsafe bool NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ADA RID: 27354
		// (get) Token: 0x0602B4F6 RID: 177398 RVA: 0x009FC558 File Offset: 0x009FA758
		// (set) Token: 0x0602B4F7 RID: 177399 RVA: 0x009FC56C File Offset: 0x009FA76C
		public unsafe TsBaseCharacter 守岸人
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonShouAnRen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonShouAnRen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006ADB RID: 27355
		// (get) Token: 0x0602B4F8 RID: 177400 RVA: 0x009FC581 File Offset: 0x009FA781
		// (set) Token: 0x0602B4F9 RID: 177401 RVA: 0x009FC595 File Offset: 0x009FA795
		public unsafe TsBaseCharacter 辅助闪避的角色
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonShouAnRen_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonShouAnRen_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006ADC RID: 27356
		// (get) Token: 0x0602B4FA RID: 177402 RVA: 0x009FC5AA File Offset: 0x009FA7AA
		// (set) Token: 0x0602B4FB RID: 177403 RVA: 0x009FC5BE File Offset: 0x009FA7BE
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_summonShouAnRen_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602B4FC RID: 177404 RVA: 0x009FC5D3 File Offset: 0x009FA7D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_338799594D3547E86A8DB6A3E235B50C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonShouAnRen_C.__OnFinish_338799594D3547E86A8DB6A3E235B50C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4FD RID: 177405 RVA: 0x009FC5E7 File Offset: 0x009FA7E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonShouAnRen_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4FE RID: 177406 RVA: 0x009FC5FB File Offset: 0x009FA7FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_summonShouAnRen_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4FF RID: 177407 RVA: 0x009FC610 File Offset: 0x009FA810
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_summonShouAnRen_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonShouAnRen_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B500 RID: 177408 RVA: 0x009FC658 File Offset: 0x009FA858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_summonShouAnRen_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_summonShouAnRen_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_summonShouAnRen_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B501 RID: 177409 RVA: 0x009FC69F File Offset: 0x009FA89F
		protected GA_summonShouAnRen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401683D RID: 92221
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonShouAnRen.GA_summonShouAnRen_C";

		// Token: 0x0401683E RID: 92222
		private static IntPtr _ClassPtr;

		// Token: 0x0401683F RID: 92223
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016840 RID: 92224
		internal new static int __PropertyOffset_1;

		// Token: 0x04016841 RID: 92225
		internal new static int __PropertyOffset_2;

		// Token: 0x04016842 RID: 92226
		private TMap<int, bool> _NewVar_0;

		// Token: 0x04016843 RID: 92227
		internal new static int __PropertyOffset_3;

		// Token: 0x04016844 RID: 92228
		internal static int __PropertyOffset_4;

		// Token: 0x04016845 RID: 92229
		internal static int __PropertyOffset_5;

		// Token: 0x04016846 RID: 92230
		internal static int __PropertyOffset_6;

		// Token: 0x04016847 RID: 92231
		private static IntPtr __OnFinish_338799594D3547E86A8DB6A3E235B50C_NativeFunctionPtr;

		// Token: 0x04016848 RID: 92232
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016849 RID: 92233
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4CA RID: 42186
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032338 RID: 205624
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
