using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x0200414B RID: 16715
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_OverShoulder_TurnAround.GA_OverShoulder_TurnAround_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1532)]
	public class GA_OverShoulder_TurnAround_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B18D RID: 176525 RVA: 0x009F5CE4 File Offset: 0x009F3EE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_OverShoulder_TurnAround_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_OverShoulder_TurnAround.GA_OverShoulder_TurnAround_C");
			}
			return GA_OverShoulder_TurnAround_C._ClassPtr;
		}

		// Token: 0x0602B18E RID: 176526 RVA: 0x009F5D08 File Offset: 0x009F3F08
		public GA_OverShoulder_TurnAround_C() : this(BuiltinUtils.AllocNativeUObject(GA_OverShoulder_TurnAround_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B18F RID: 176527 RVA: 0x009F5D30 File Offset: 0x009F3F30
		[NullableContext(1)]
		public GA_OverShoulder_TurnAround_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_OverShoulder_TurnAround_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A1F RID: 27167
		// (get) Token: 0x0602B190 RID: 176528 RVA: 0x009F5D63 File Offset: 0x009F3F63
		// (set) Token: 0x0602B191 RID: 176529 RVA: 0x009F5D77 File Offset: 0x009F3F77
		[Nullable(2)]
		public unsafe TsBaseCharacter Owner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_OverShoulder_TurnAround_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_OverShoulder_TurnAround_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A20 RID: 27168
		// (get) Token: 0x0602B192 RID: 176530 RVA: 0x009F5D8C File Offset: 0x009F3F8C
		// (set) Token: 0x0602B193 RID: 176531 RVA: 0x009F5DA0 File Offset: 0x009F3FA0
		public unsafe FRotator EndRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_OverShoulder_TurnAround_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_OverShoulder_TurnAround_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B194 RID: 176532 RVA: 0x009F5DB5 File Offset: 0x009F3FB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81F8B7F793()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__OnTick_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr, null);
		}

		// Token: 0x0602B195 RID: 176533 RVA: 0x009F5DC9 File Offset: 0x009F3FC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81F8B7F793()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__OnCancelled_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr, null);
		}

		// Token: 0x0602B196 RID: 176534 RVA: 0x009F5DDD File Offset: 0x009F3FDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81F8B7F793()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__OnInterrupted_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr, null);
		}

		// Token: 0x0602B197 RID: 176535 RVA: 0x009F5DF1 File Offset: 0x009F3FF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81F8B7F793()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__OnBlendOut_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr, null);
		}

		// Token: 0x0602B198 RID: 176536 RVA: 0x009F5E05 File Offset: 0x009F4005
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81F8B7F793()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__OnCompleted_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr, null);
		}

		// Token: 0x0602B199 RID: 176537 RVA: 0x009F5E19 File Offset: 0x009F4019
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B19A RID: 176538 RVA: 0x009F5E2D File Offset: 0x009F402D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_OverShoulder_TurnAround_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B19B RID: 176539 RVA: 0x009F5E42 File Offset: 0x009F4042
		protected GA_OverShoulder_TurnAround_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165E4 RID: 91620
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_OverShoulder_TurnAround.GA_OverShoulder_TurnAround_C";

		// Token: 0x040165E5 RID: 91621
		private static IntPtr _ClassPtr;

		// Token: 0x040165E6 RID: 91622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165E7 RID: 91623
		internal new static int __PropertyOffset_1;

		// Token: 0x040165E8 RID: 91624
		internal new static int __PropertyOffset_2;

		// Token: 0x040165E9 RID: 91625
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr;

		// Token: 0x040165EA RID: 91626
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr;

		// Token: 0x040165EB RID: 91627
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr;

		// Token: 0x040165EC RID: 91628
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr;

		// Token: 0x040165ED RID: 91629
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81F8B7F793_NativeFunctionPtr;

		// Token: 0x040165EE RID: 91630
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
