using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneInteraction.Coral
{
	// Token: 0x02003BB5 RID: 15285
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneInteraction/Coral/BP_CoralWindActor.BP_CoralWindActor_C")]
	[UnrealStructLayout(2000, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1996)]
	public class BP_CoralWindActor_C : ACoralWindActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221FC RID: 139772 RVA: 0x00900444 File Offset: 0x008FE644
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CoralWindActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneInteraction/Coral/BP_CoralWindActor.BP_CoralWindActor_C");
			}
			return BP_CoralWindActor_C._ClassPtr;
		}

		// Token: 0x060221FD RID: 139773 RVA: 0x00900468 File Offset: 0x008FE668
		public BP_CoralWindActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_CoralWindActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221FE RID: 139774 RVA: 0x00900490 File Offset: 0x008FE690
		[NullableContext(1)]
		public BP_CoralWindActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CoralWindActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x060221FF RID: 139775 RVA: 0x009004C3 File Offset: 0x008FE6C3
		// (set) Token: 0x06022200 RID: 139776 RVA: 0x009004D3 File Offset: 0x008FE6D3
		public unsafe float RadiusMutiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CoralWindActor_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CoralWindActor_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06022201 RID: 139777 RVA: 0x009004E4 File Offset: 0x008FE6E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CoralWindActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CoralWindActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CoralWindActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CoralWindActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CoralWindActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022202 RID: 139778 RVA: 0x0090052C File Offset: 0x008FE72C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CoralWindActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CoralWindActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CoralWindActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CoralWindActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CoralWindActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022203 RID: 139779 RVA: 0x00900573 File Offset: 0x008FE773
		protected BP_CoralWindActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B67 RID: 68455
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneInteraction/Coral/BP_CoralWindActor.BP_CoralWindActor_C";

		// Token: 0x04010B68 RID: 68456
		private static IntPtr _ClassPtr;

		// Token: 0x04010B69 RID: 68457
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B6A RID: 68458
		internal static int __PropertyOffset_1;

		// Token: 0x04010B6B RID: 68459
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D42 RID: 40258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314AD RID: 201901
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
