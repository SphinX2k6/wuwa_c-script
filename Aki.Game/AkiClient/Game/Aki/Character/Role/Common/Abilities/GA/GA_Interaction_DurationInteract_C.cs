using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200413D RID: 16701
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_DurationInteract.GA_Interaction_DurationInteract_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_DurationInteract_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0DD RID: 176349 RVA: 0x009F45E0 File Offset: 0x009F27E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_DurationInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_DurationInteract.GA_Interaction_DurationInteract_C");
			}
			return GA_Interaction_DurationInteract_C._ClassPtr;
		}

		// Token: 0x0602B0DE RID: 176350 RVA: 0x009F4604 File Offset: 0x009F2804
		public GA_Interaction_DurationInteract_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_DurationInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0DF RID: 176351 RVA: 0x009F462C File Offset: 0x009F282C
		[NullableContext(1)]
		public GA_Interaction_DurationInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_DurationInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A0F RID: 27151
		// (get) Token: 0x0602B0E0 RID: 176352 RVA: 0x009F465F File Offset: 0x009F285F
		// (set) Token: 0x0602B0E1 RID: 176353 RVA: 0x009F4673 File Offset: 0x009F2873
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_DurationInteract_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_DurationInteract_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B0E2 RID: 176354 RVA: 0x009F4688 File Offset: 0x009F2888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81303EAA5E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__OnTick_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E3 RID: 176355 RVA: 0x009F469C File Offset: 0x009F289C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81303EAA5E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__OnCancelled_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E4 RID: 176356 RVA: 0x009F46B0 File Offset: 0x009F28B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81303EAA5E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__OnInterrupted_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E5 RID: 176357 RVA: 0x009F46C4 File Offset: 0x009F28C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81303EAA5E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__OnBlendOut_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E6 RID: 176358 RVA: 0x009F46D8 File Offset: 0x009F28D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81303EAA5E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__OnCompleted_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E7 RID: 176359 RVA: 0x009F46EC File Offset: 0x009F28EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0E8 RID: 176360 RVA: 0x009F4700 File Offset: 0x009F2900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_DurationInteract_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0E9 RID: 176361 RVA: 0x009F4715 File Offset: 0x009F2915
		protected GA_Interaction_DurationInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401656A RID: 91498
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_DurationInteract.GA_Interaction_DurationInteract_C";

		// Token: 0x0401656B RID: 91499
		private static IntPtr _ClassPtr;

		// Token: 0x0401656C RID: 91500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401656D RID: 91501
		internal new static int __PropertyOffset_1;

		// Token: 0x0401656E RID: 91502
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr;

		// Token: 0x0401656F RID: 91503
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr;

		// Token: 0x04016570 RID: 91504
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr;

		// Token: 0x04016571 RID: 91505
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr;

		// Token: 0x04016572 RID: 91506
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81303EAA5E_NativeFunctionPtr;

		// Token: 0x04016573 RID: 91507
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
