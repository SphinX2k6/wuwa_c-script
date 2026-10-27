using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_4_SphereScreen.Mat
{
	// Token: 0x02003C13 RID: 15379
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_4_SphereScreen/Mat/BP_SpereDome.BP_SpereDome_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class BP_SpereDome_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060232E8 RID: 144104 RVA: 0x0091C8BE File Offset: 0x0091AABE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SpereDome_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_4_SphereScreen/Mat/BP_SpereDome.BP_SpereDome_C");
			}
			return BP_SpereDome_C._ClassPtr;
		}

		// Token: 0x060232E9 RID: 144105 RVA: 0x0091C8E4 File Offset: 0x0091AAE4
		public BP_SpereDome_C() : this(BuiltinUtils.AllocNativeUObject(BP_SpereDome_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060232EA RID: 144106 RVA: 0x0091C90C File Offset: 0x0091AB0C
		[NullableContext(1)]
		public BP_SpereDome_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SpereDome_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x060232EB RID: 144107 RVA: 0x0091C93F File Offset: 0x0091AB3F
		// (set) Token: 0x060232EC RID: 144108 RVA: 0x0091C953 File Offset: 0x0091AB53
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x060232ED RID: 144109 RVA: 0x0091C968 File Offset: 0x0091AB68
		// (set) Token: 0x060232EE RID: 144110 RVA: 0x0091C97C File Offset: 0x0091AB7C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x060232EF RID: 144111 RVA: 0x0091C991 File Offset: 0x0091AB91
		// (set) Token: 0x060232F0 RID: 144112 RVA: 0x0091C9A5 File Offset: 0x0091ABA5
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x060232F1 RID: 144113 RVA: 0x0091C9BA File Offset: 0x0091ABBA
		// (set) Token: 0x060232F2 RID: 144114 RVA: 0x0091C9CE File Offset: 0x0091ABCE
		public unsafe UMaterialInstanceDynamic DMI_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SpereDome_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x060232F3 RID: 144115 RVA: 0x0091C9E3 File Offset: 0x0091ABE3
		// (set) Token: 0x060232F4 RID: 144116 RVA: 0x0091C9F3 File Offset: 0x0091ABF3
		public unsafe float DissolveProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SpereDome_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SpereDome_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x060232F5 RID: 144117 RVA: 0x0091CA04 File Offset: 0x0091AC04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpereDome_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060232F6 RID: 144118 RVA: 0x0091CA18 File Offset: 0x0091AC18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpereDome_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060232F7 RID: 144119 RVA: 0x0091CA2D File Offset: 0x0091AC2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpereDome_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060232F8 RID: 144120 RVA: 0x0091CA41 File Offset: 0x0091AC41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpereDome_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060232F9 RID: 144121 RVA: 0x0091CA58 File Offset: 0x0091AC58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SpereDome_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpereDome_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpereDome_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpereDome_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpereDome_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232FA RID: 144122 RVA: 0x0091CAA0 File Offset: 0x0091ACA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SpereDome_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SpereDome_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpereDome_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpereDome_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpereDome_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060232FB RID: 144123 RVA: 0x0091CAE8 File Offset: 0x0091ACE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SpereDome_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SpereDome_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpereDome_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpereDome_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SpereDome_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232FC RID: 144124 RVA: 0x0091CB30 File Offset: 0x0091AD30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SpereDome_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SpereDome_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SpereDome_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SpereDome_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SpereDome_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060232FD RID: 144125 RVA: 0x0091CB77 File Offset: 0x0091AD77
		protected BP_SpereDome_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011573 RID: 71027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_4_SphereScreen/Mat/BP_SpereDome.BP_SpereDome_C";

		// Token: 0x04011574 RID: 71028
		private static IntPtr _ClassPtr;

		// Token: 0x04011575 RID: 71029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011576 RID: 71030
		internal static int __PropertyOffset_1;

		// Token: 0x04011577 RID: 71031
		internal static int __PropertyOffset_2;

		// Token: 0x04011578 RID: 71032
		internal static int __PropertyOffset_3;

		// Token: 0x04011579 RID: 71033
		internal static int __PropertyOffset_4;

		// Token: 0x0401157A RID: 71034
		internal static int __PropertyOffset_5;

		// Token: 0x0401157B RID: 71035
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401157C RID: 71036
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401157D RID: 71037
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401157E RID: 71038
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E22 RID: 40482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403166D RID: 202349
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E23 RID: 40483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403166E RID: 202350
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
