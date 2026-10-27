using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E7D RID: 15997
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1073)]
	public class BP_Fx_Control_Obj_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028595 RID: 165269 RVA: 0x009AA511 File Offset: 0x009A8711
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Control_Obj_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C");
			}
			return BP_Fx_Control_Obj_C._ClassPtr;
		}

		// Token: 0x06028596 RID: 165270 RVA: 0x009AA538 File Offset: 0x009A8738
		public BP_Fx_Control_Obj_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Control_Obj_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028597 RID: 165271 RVA: 0x009AA560 File Offset: 0x009A8760
		[NullableContext(1)]
		public BP_Fx_Control_Obj_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Control_Obj_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x06028598 RID: 165272 RVA: 0x009AA593 File Offset: 0x009A8793
		// (set) Token: 0x06028599 RID: 165273 RVA: 0x009AA5A7 File Offset: 0x009A87A7
		public unsafe UNiagaraComponent NS_Fx_Control_Obj_Beam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0602859A RID: 165274 RVA: 0x009AA5BC File Offset: 0x009A87BC
		// (set) Token: 0x0602859B RID: 165275 RVA: 0x009AA5D0 File Offset: 0x009A87D0
		public unsafe AActor EndActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Control_Obj_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005D4D RID: 23885
		// (get) Token: 0x0602859C RID: 165276 RVA: 0x009AA5E5 File Offset: 0x009A87E5
		// (set) Token: 0x0602859D RID: 165277 RVA: 0x009AA5F5 File Offset: 0x009A87F5
		public unsafe bool CanShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Control_Obj_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Control_Obj_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602859E RID: 165278 RVA: 0x009AA608 File Offset: 0x009A8808
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602859F RID: 165279 RVA: 0x009AA650 File Offset: 0x009A8850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Control_Obj_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Control_Obj_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060285A0 RID: 165280 RVA: 0x009AA697 File Offset: 0x009A8897
		protected BP_Fx_Control_Obj_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014900 RID: 84224
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Control_Obj.BP_Fx_Control_Obj_C";

		// Token: 0x04014901 RID: 84225
		private static IntPtr _ClassPtr;

		// Token: 0x04014902 RID: 84226
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014903 RID: 84227
		internal static int __PropertyOffset_1;

		// Token: 0x04014904 RID: 84228
		internal static int __PropertyOffset_2;

		// Token: 0x04014905 RID: 84229
		internal static int __PropertyOffset_3;

		// Token: 0x04014906 RID: 84230
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2D1 RID: 41681
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032013 RID: 204819
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
