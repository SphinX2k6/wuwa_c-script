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
	// Token: 0x02004169 RID: 16745
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonLupa.GA_summonLupa_C")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class GA_summonLupa_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4DA RID: 177370 RVA: 0x009FC212 File Offset: 0x009FA412
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_summonLupa_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonLupa.GA_summonLupa_C");
			}
			return GA_summonLupa_C._ClassPtr;
		}

		// Token: 0x0602B4DB RID: 177371 RVA: 0x009FC238 File Offset: 0x009FA438
		public GA_summonLupa_C() : this(BuiltinUtils.AllocNativeUObject(GA_summonLupa_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4DC RID: 177372 RVA: 0x009FC260 File Offset: 0x009FA460
		[NullableContext(1)]
		public GA_summonLupa_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_summonLupa_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AD2 RID: 27346
		// (get) Token: 0x0602B4DD RID: 177373 RVA: 0x009FC294 File Offset: 0x009FA494
		// (set) Token: 0x0602B4DE RID: 177374 RVA: 0x009FC2CD File Offset: 0x009FA4CD
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
					result = (this._NewVar_0 = new TMap<int, bool>(base.NativePtr + (IntPtr)GA_summonLupa_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NewVar_0.CopyAssign(value);
			}
		}

		// Token: 0x17006AD3 RID: 27347
		// (get) Token: 0x0602B4DF RID: 177375 RVA: 0x009FC2DB File Offset: 0x009FA4DB
		// (set) Token: 0x0602B4E0 RID: 177376 RVA: 0x009FC2EB File Offset: 0x009FA4EB
		public unsafe bool NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_summonLupa_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_summonLupa_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AD4 RID: 27348
		// (get) Token: 0x0602B4E1 RID: 177377 RVA: 0x009FC2FC File Offset: 0x009FA4FC
		// (set) Token: 0x0602B4E2 RID: 177378 RVA: 0x009FC310 File Offset: 0x009FA510
		public unsafe TsBaseCharacter 露帕
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonLupa_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonLupa_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006AD5 RID: 27349
		// (get) Token: 0x0602B4E3 RID: 177379 RVA: 0x009FC325 File Offset: 0x009FA525
		// (set) Token: 0x0602B4E4 RID: 177380 RVA: 0x009FC339 File Offset: 0x009FA539
		public unsafe TsBaseCharacter 辅助闪避的角色
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonLupa_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_summonLupa_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17006AD6 RID: 27350
		// (get) Token: 0x0602B4E5 RID: 177381 RVA: 0x009FC34E File Offset: 0x009FA54E
		// (set) Token: 0x0602B4E6 RID: 177382 RVA: 0x009FC362 File Offset: 0x009FA562
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_summonLupa_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_summonLupa_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602B4E7 RID: 177383 RVA: 0x009FC377 File Offset: 0x009FA577
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_958D05BD436AC6F4B6B69ABBFDAC7873()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonLupa_C.__OnFinish_958D05BD436AC6F4B6B69ABBFDAC7873_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4E8 RID: 177384 RVA: 0x009FC38C File Offset: 0x009FA58C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_summonLupa_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_summonLupa_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_summonLupa_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_summonLupa_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonLupa_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B4E9 RID: 177385 RVA: 0x009FC3D4 File Offset: 0x009FA5D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_summonLupa_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_summonLupa_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_summonLupa_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_summonLupa_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_summonLupa_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B4EA RID: 177386 RVA: 0x009FC41B File Offset: 0x009FA61B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_summonLupa_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4EB RID: 177387 RVA: 0x009FC42F File Offset: 0x009FA62F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_summonLupa_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4EC RID: 177388 RVA: 0x009FC444 File Offset: 0x009FA644
		protected GA_summonLupa_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016831 RID: 92209
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_summonLupa.GA_summonLupa_C";

		// Token: 0x04016832 RID: 92210
		private static IntPtr _ClassPtr;

		// Token: 0x04016833 RID: 92211
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016834 RID: 92212
		internal new static int __PropertyOffset_1;

		// Token: 0x04016835 RID: 92213
		private TMap<int, bool> _NewVar_0;

		// Token: 0x04016836 RID: 92214
		internal new static int __PropertyOffset_2;

		// Token: 0x04016837 RID: 92215
		internal new static int __PropertyOffset_3;

		// Token: 0x04016838 RID: 92216
		internal static int __PropertyOffset_4;

		// Token: 0x04016839 RID: 92217
		internal static int __PropertyOffset_5;

		// Token: 0x0401683A RID: 92218
		private static IntPtr __OnFinish_958D05BD436AC6F4B6B69ABBFDAC7873_NativeFunctionPtr;

		// Token: 0x0401683B RID: 92219
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401683C RID: 92220
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4C9 RID: 42185
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032337 RID: 205623
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
