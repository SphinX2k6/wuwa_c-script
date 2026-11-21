using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003409 RID: 13321
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1073)]
	public class BP_Fx_Control_Obj_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D9F RID: 138655 RVA: 0x0096D1C3 File Offset: 0x0096B3C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Control_Obj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C");
			}
			return BP_Fx_Control_Obj_C._ClassPtr;
		}

		// Token: 0x06021DA0 RID: 138656 RVA: 0x0096D1E8 File Offset: 0x0096B3E8
		public BP_Fx_Control_Obj_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Control_Obj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DA1 RID: 138657 RVA: 0x0096D210 File Offset: 0x0096B410
		[NullableContext(1)]
		public BP_Fx_Control_Obj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Control_Obj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x06021DA2 RID: 138658 RVA: 0x0096D243 File Offset: 0x0096B443
		// (set) Token: 0x06021DA3 RID: 138659 RVA: 0x0096D257 File Offset: 0x0096B457
		public unsafe UNiagaraComponent NS_Fx_Control_Obj_Beam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_NS_Fx_Control_Obj_Beam);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_NS_Fx_Control_Obj_Beam, value);
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x06021DA4 RID: 138660 RVA: 0x0096D26C File Offset: 0x0096B46C
		// (set) Token: 0x06021DA5 RID: 138661 RVA: 0x0096D280 File Offset: 0x0096B480
		public unsafe AActor EndActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_EndActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_EndActor, value);
			}
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x06021DA6 RID: 138662 RVA: 0x0096D295 File Offset: 0x0096B495
		// (set) Token: 0x06021DA7 RID: 138663 RVA: 0x0096D2A5 File Offset: 0x0096B4A5
		public unsafe bool CanShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Control_Obj_C.__PropertyOffset_CanShow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Control_Obj_C.__PropertyOffset_CanShow) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021DA8 RID: 138664 RVA: 0x0096D2B8 File Offset: 0x0096B4B8
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DA9 RID: 138665 RVA: 0x0096D300 File Offset: 0x0096B500
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DAA RID: 138666 RVA: 0x0096D346 File Offset: 0x0096B546
		protected BP_Fx_Control_Obj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012ACC RID: 76492
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C";

		// Token: 0x04012ACD RID: 76493
		private static IntPtr _ClassPtr;

		// Token: 0x04012ACE RID: 76494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012ACF RID: 76495
		internal static int __PropertyOffset_NS_Fx_Control_Obj_Beam;

		// Token: 0x04012AD0 RID: 76496
		internal static int __PropertyOffset_EndActor;

		// Token: 0x04012AD1 RID: 76497
		internal static int __PropertyOffset_CanShow;

		// Token: 0x04012AD2 RID: 76498
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090FB RID: 37115
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFD9 RID: 184281
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
