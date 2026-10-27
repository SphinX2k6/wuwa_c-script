using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200413E RID: 16702
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant.GA_Interaction_Giant_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Interaction_Giant_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B0EA RID: 176362 RVA: 0x009F471E File Offset: 0x009F291E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Interaction_Giant_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant.GA_Interaction_Giant_C");
			}
			return GA_Interaction_Giant_C._ClassPtr;
		}

		// Token: 0x0602B0EB RID: 176363 RVA: 0x009F4744 File Offset: 0x009F2944
		public GA_Interaction_Giant_C() : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Giant_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B0EC RID: 176364 RVA: 0x009F476C File Offset: 0x009F296C
		[NullableContext(1)]
		public GA_Interaction_Giant_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Interaction_Giant_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A10 RID: 27152
		// (get) Token: 0x0602B0ED RID: 176365 RVA: 0x009F479F File Offset: 0x009F299F
		// (set) Token: 0x0602B0EE RID: 176366 RVA: 0x009F47B3 File Offset: 0x009F29B3
		[Nullable(2)]
		public unsafe AActor 被控物
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Giant_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Interaction_Giant_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602B0EF RID: 176367 RVA: 0x009F47C8 File Offset: 0x009F29C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81C63D3F9C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__OnTick_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F0 RID: 176368 RVA: 0x009F47DC File Offset: 0x009F29DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81C63D3F9C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__OnCancelled_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F1 RID: 176369 RVA: 0x009F47F0 File Offset: 0x009F29F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81C63D3F9C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__OnInterrupted_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F2 RID: 176370 RVA: 0x009F4804 File Offset: 0x009F2A04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81C63D3F9C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__OnBlendOut_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F3 RID: 176371 RVA: 0x009F4818 File Offset: 0x009F2A18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81C63D3F9C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__OnCompleted_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F4 RID: 176372 RVA: 0x009F482C File Offset: 0x009F2A2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Interaction_Giant_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B0F5 RID: 176373 RVA: 0x009F4840 File Offset: 0x009F2A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Interaction_Giant_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B0F6 RID: 176374 RVA: 0x009F4855 File Offset: 0x009F2A55
		protected GA_Interaction_Giant_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016574 RID: 91508
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Interaction_Giant.GA_Interaction_Giant_C";

		// Token: 0x04016575 RID: 91509
		private static IntPtr _ClassPtr;

		// Token: 0x04016576 RID: 91510
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016577 RID: 91511
		internal new static int __PropertyOffset_1;

		// Token: 0x04016578 RID: 91512
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr;

		// Token: 0x04016579 RID: 91513
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr;

		// Token: 0x0401657A RID: 91514
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr;

		// Token: 0x0401657B RID: 91515
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr;

		// Token: 0x0401657C RID: 91516
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81C63D3F9C_NativeFunctionPtr;

		// Token: 0x0401657D RID: 91517
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
