using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AF7 RID: 15095
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageDecal.BP_CageDecal_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_CageDecal_C : ADecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B40 RID: 133952 RVA: 0x008DAF50 File Offset: 0x008D9150
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CageDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageDecal.BP_CageDecal_C");
			}
			return BP_CageDecal_C._ClassPtr;
		}

		// Token: 0x06020B41 RID: 133953 RVA: 0x008DAF74 File Offset: 0x008D9174
		public BP_CageDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_CageDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B42 RID: 133954 RVA: 0x008DAF9C File Offset: 0x008D919C
		[NullableContext(1)]
		public BP_CageDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CageDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x06020B43 RID: 133955 RVA: 0x008DAFCF File Offset: 0x008D91CF
		// (set) Token: 0x06020B44 RID: 133956 RVA: 0x008DAFE3 File Offset: 0x008D91E3
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x06020B45 RID: 133957 RVA: 0x008DAFF8 File Offset: 0x008D91F8
		// (set) Token: 0x06020B46 RID: 133958 RVA: 0x008DB00C File Offset: 0x008D920C
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x06020B47 RID: 133959 RVA: 0x008DB021 File Offset: 0x008D9221
		// (set) Token: 0x06020B48 RID: 133960 RVA: 0x008DB035 File Offset: 0x008D9235
		public unsafe UTexture2D Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageDecal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x06020B49 RID: 133961 RVA: 0x008DB04A File Offset: 0x008D924A
		// (set) Token: 0x06020B4A RID: 133962 RVA: 0x008DB05A File Offset: 0x008D925A
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x06020B4B RID: 133963 RVA: 0x008DB06B File Offset: 0x008D926B
		// (set) Token: 0x06020B4C RID: 133964 RVA: 0x008DB07B File Offset: 0x008D927B
		public unsafe float BlurScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x06020B4D RID: 133965 RVA: 0x008DB08C File Offset: 0x008D928C
		// (set) Token: 0x06020B4E RID: 133966 RVA: 0x008DB09C File Offset: 0x008D929C
		public unsafe float AngleDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x06020B4F RID: 133967 RVA: 0x008DB0AD File Offset: 0x008D92AD
		// (set) Token: 0x06020B50 RID: 133968 RVA: 0x008DB0BD File Offset: 0x008D92BD
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x06020B51 RID: 133969 RVA: 0x008DB0CE File Offset: 0x008D92CE
		// (set) Token: 0x06020B52 RID: 133970 RVA: 0x008DB0DE File Offset: 0x008D92DE
		public unsafe float OffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x06020B53 RID: 133971 RVA: 0x008DB0EF File Offset: 0x008D92EF
		// (set) Token: 0x06020B54 RID: 133972 RVA: 0x008DB0FF File Offset: 0x008D92FF
		public unsafe float ScaleY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageDecal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06020B55 RID: 133973 RVA: 0x008DB110 File Offset: 0x008D9310
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageDecal_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06020B56 RID: 133974 RVA: 0x008DB124 File Offset: 0x008D9324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020B57 RID: 133975 RVA: 0x008DB138 File Offset: 0x008D9338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B58 RID: 133976 RVA: 0x008DB14D File Offset: 0x008D934D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020B59 RID: 133977 RVA: 0x008DB161 File Offset: 0x008D9361
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B5A RID: 133978 RVA: 0x008DB178 File Offset: 0x008D9378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CageDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CageDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CageDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B5B RID: 133979 RVA: 0x008DB1C0 File Offset: 0x008D93C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CageDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CageDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CageDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B5C RID: 133980 RVA: 0x008DB208 File Offset: 0x008D9408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CageDecal_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CageDecal_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CageDecal_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageDecal_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B5D RID: 133981 RVA: 0x008DB254 File Offset: 0x008D9454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CageDecal_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CageDecal_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CageDecal_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageDecal_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageDecal_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B5E RID: 133982 RVA: 0x008DB2A0 File Offset: 0x008D94A0
		protected BP_CageDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE10 RID: 65040
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageDecal.BP_CageDecal_C";

		// Token: 0x0400FE11 RID: 65041
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE12 RID: 65042
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE13 RID: 65043
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE14 RID: 65044
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE15 RID: 65045
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE16 RID: 65046
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE17 RID: 65047
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE18 RID: 65048
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE19 RID: 65049
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE1A RID: 65050
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE1B RID: 65051
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE1C RID: 65052
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x0400FE1D RID: 65053
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE1E RID: 65054
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE1F RID: 65055
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE20 RID: 65056
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C29 RID: 39977
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312D9 RID: 201433
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C2A RID: 39978
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040312DA RID: 201434
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
