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
	// Token: 0x0200411F RID: 16671
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_AimAttackSword_Passive.GA_AimAttackSword_Passive_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_AimAttackSword_Passive_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF0D RID: 175885 RVA: 0x009F07E4 File Offset: 0x009EE9E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_AimAttackSword_Passive_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_AimAttackSword_Passive.GA_AimAttackSword_Passive_C");
			}
			return GA_AimAttackSword_Passive_C._ClassPtr;
		}

		// Token: 0x0602AF0E RID: 175886 RVA: 0x009F0808 File Offset: 0x009EEA08
		public GA_AimAttackSword_Passive_C() : this(BuiltinUtils.AllocNativeUObject(GA_AimAttackSword_Passive_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF0F RID: 175887 RVA: 0x009F0830 File Offset: 0x009EEA30
		public GA_AimAttackSword_Passive_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_AimAttackSword_Passive_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069CC RID: 27084
		// (get) Token: 0x0602AF10 RID: 175888 RVA: 0x009F0863 File Offset: 0x009EEA63
		// (set) Token: 0x0602AF11 RID: 175889 RVA: 0x009F0873 File Offset: 0x009EEA73
		public unsafe int 当前剑意
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_AimAttackSword_Passive_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_AimAttackSword_Passive_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170069CD RID: 27085
		// (get) Token: 0x0602AF12 RID: 175890 RVA: 0x009F0884 File Offset: 0x009EEA84
		// (set) Token: 0x0602AF13 RID: 175891 RVA: 0x009F0894 File Offset: 0x009EEA94
		public unsafe int 新剑意值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_AimAttackSword_Passive_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_AimAttackSword_Passive_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069CE RID: 27086
		// (get) Token: 0x0602AF14 RID: 175892 RVA: 0x009F08A8 File Offset: 0x009EEAA8
		// (set) Token: 0x0602AF15 RID: 175893 RVA: 0x009F08E1 File Offset: 0x009EEAE1
		public TArray<int> 剑buff特效ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._剑buff特效ID) == null)
				{
					result = (this._剑buff特效ID = new TArray<int>(base.NativePtr + (IntPtr)GA_AimAttackSword_Passive_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.剑buff特效ID.CopyAssign(value);
			}
		}

		// Token: 0x0602AF16 RID: 175894 RVA: 0x009F08EF File Offset: 0x009EEAEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_AimAttackSword_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF17 RID: 175895 RVA: 0x009F0903 File Offset: 0x009EEB03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_AimAttackSword_Passive_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AF18 RID: 175896 RVA: 0x009F0918 File Offset: 0x009EEB18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_AimAttackSword_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_AimAttackSword_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF19 RID: 175897 RVA: 0x009F0960 File Offset: 0x009EEB60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_AimAttackSword_Passive_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_AimAttackSword_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_AimAttackSword_Passive_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF1A RID: 175898 RVA: 0x009F09A7 File Offset: 0x009EEBA7
		protected GA_AimAttackSword_Passive_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016429 RID: 91177
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_AimAttackSword_Passive.GA_AimAttackSword_Passive_C";

		// Token: 0x0401642A RID: 91178
		private static IntPtr _ClassPtr;

		// Token: 0x0401642B RID: 91179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401642C RID: 91180
		internal new static int __PropertyOffset_1;

		// Token: 0x0401642D RID: 91181
		internal new static int __PropertyOffset_2;

		// Token: 0x0401642E RID: 91182
		internal new static int __PropertyOffset_3;

		// Token: 0x0401642F RID: 91183
		[Nullable(2)]
		private TArray<int> _剑buff特效ID;

		// Token: 0x04016430 RID: 91184
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016431 RID: 91185
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A438 RID: 42040
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032277 RID: 205431
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
