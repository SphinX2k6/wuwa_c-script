using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BC2 RID: 15298
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_Spline_Water.BP_Spline_Water_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_Spline_Water_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602241C RID: 140316 RVA: 0x00903BF8 File Offset: 0x00901DF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Spline_Water_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_Spline_Water.BP_Spline_Water_C");
			}
			return BP_Spline_Water_C._ClassPtr;
		}

		// Token: 0x0602241D RID: 140317 RVA: 0x00903C1C File Offset: 0x00901E1C
		public BP_Spline_Water_C() : this(BuiltinUtils.AllocNativeUObject(BP_Spline_Water_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602241E RID: 140318 RVA: 0x00903C44 File Offset: 0x00901E44
		[NullableContext(1)]
		public BP_Spline_Water_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Spline_Water_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x0602241F RID: 140319 RVA: 0x00903C77 File Offset: 0x00901E77
		// (set) Token: 0x06022420 RID: 140320 RVA: 0x00903C8B File Offset: 0x00901E8B
		public unsafe UNiagaraComponent Spline_Particle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x06022421 RID: 140321 RVA: 0x00903CA0 File Offset: 0x00901EA0
		// (set) Token: 0x06022422 RID: 140322 RVA: 0x00903CB4 File Offset: 0x00901EB4
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x06022423 RID: 140323 RVA: 0x00903CC9 File Offset: 0x00901EC9
		// (set) Token: 0x06022424 RID: 140324 RVA: 0x00903CDD File Offset: 0x00901EDD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x06022425 RID: 140325 RVA: 0x00903CF2 File Offset: 0x00901EF2
		// (set) Token: 0x06022426 RID: 140326 RVA: 0x00903D06 File Offset: 0x00901F06
		public unsafe UMaterialInterface RainSplineMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Spline_Water_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x06022427 RID: 140327 RVA: 0x00903D1B File Offset: 0x00901F1B
		// (set) Token: 0x06022428 RID: 140328 RVA: 0x00903D2B File Offset: 0x00901F2B
		public unsafe int Spawn_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003A98 RID: 15000
		// (get) Token: 0x06022429 RID: 140329 RVA: 0x00903D3C File Offset: 0x00901F3C
		// (set) Token: 0x0602242A RID: 140330 RVA: 0x00903D4C File Offset: 0x00901F4C
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003A99 RID: 15001
		// (get) Token: 0x0602242B RID: 140331 RVA: 0x00903D5D File Offset: 0x00901F5D
		// (set) Token: 0x0602242C RID: 140332 RVA: 0x00903D71 File Offset: 0x00901F71
		public unsafe FVector2D Min_Max_Scale_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x0602242D RID: 140333 RVA: 0x00903D86 File Offset: 0x00901F86
		// (set) Token: 0x0602242E RID: 140334 RVA: 0x00903D96 File Offset: 0x00901F96
		public unsafe int ScaleRandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x0602242F RID: 140335 RVA: 0x00903DA7 File Offset: 0x00901FA7
		// (set) Token: 0x06022430 RID: 140336 RVA: 0x00903DBB File Offset: 0x00901FBB
		public unsafe FVector2D Min_Max_Distance_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x06022431 RID: 140337 RVA: 0x00903DD0 File Offset: 0x00901FD0
		// (set) Token: 0x06022432 RID: 140338 RVA: 0x00903DE0 File Offset: 0x00901FE0
		public unsafe int DistanceRandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Spline_Water_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06022433 RID: 140339 RVA: 0x00903DF1 File Offset: 0x00901FF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Spline_Water_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06022434 RID: 140340 RVA: 0x00903E05 File Offset: 0x00902005
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Spline_Water_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x00903E19 File Offset: 0x00902019
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Spline_Water_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x00903E2E File Offset: 0x0090202E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Spline_Water_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022437 RID: 140343 RVA: 0x00903E42 File Offset: 0x00902042
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Spline_Water_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022438 RID: 140344 RVA: 0x00903E57 File Offset: 0x00902057
		protected BP_Spline_Water_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010CAC RID: 68780
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_Spline_Water.BP_Spline_Water_C";

		// Token: 0x04010CAD RID: 68781
		private static IntPtr _ClassPtr;

		// Token: 0x04010CAE RID: 68782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010CAF RID: 68783
		internal static int __PropertyOffset_1;

		// Token: 0x04010CB0 RID: 68784
		internal static int __PropertyOffset_2;

		// Token: 0x04010CB1 RID: 68785
		internal static int __PropertyOffset_3;

		// Token: 0x04010CB2 RID: 68786
		internal static int __PropertyOffset_4;

		// Token: 0x04010CB3 RID: 68787
		internal static int __PropertyOffset_5;

		// Token: 0x04010CB4 RID: 68788
		internal static int __PropertyOffset_6;

		// Token: 0x04010CB5 RID: 68789
		internal static int __PropertyOffset_7;

		// Token: 0x04010CB6 RID: 68790
		internal static int __PropertyOffset_8;

		// Token: 0x04010CB7 RID: 68791
		internal static int __PropertyOffset_9;

		// Token: 0x04010CB8 RID: 68792
		internal static int __PropertyOffset_10;

		// Token: 0x04010CB9 RID: 68793
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x04010CBA RID: 68794
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010CBB RID: 68795
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
