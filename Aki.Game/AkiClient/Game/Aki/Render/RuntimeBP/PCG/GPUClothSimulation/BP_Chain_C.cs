using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CA8 RID: 15528
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_Chain.BP_Chain_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_Chain_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060247C3 RID: 149443 RVA: 0x0094020B File Offset: 0x0093E40B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Chain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_Chain.BP_Chain_C");
			}
			return BP_Chain_C._ClassPtr;
		}

		// Token: 0x060247C4 RID: 149444 RVA: 0x00940230 File Offset: 0x0093E430
		public BP_Chain_C() : this(BuiltinUtils.AllocNativeUObject(BP_Chain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247C5 RID: 149445 RVA: 0x00940258 File Offset: 0x0093E458
		[NullableContext(1)]
		public BP_Chain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Chain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x060247C6 RID: 149446 RVA: 0x0094028B File Offset: 0x0093E48B
		// (set) Token: 0x060247C7 RID: 149447 RVA: 0x0094029F File Offset: 0x0093E49F
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x060247C8 RID: 149448 RVA: 0x009402B4 File Offset: 0x0093E4B4
		// (set) Token: 0x060247C9 RID: 149449 RVA: 0x009402C8 File Offset: 0x0093E4C8
		public unsafe UStaticMeshComponent SM_Tab_Clo_03AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x060247CA RID: 149450 RVA: 0x009402DD File Offset: 0x0093E4DD
		// (set) Token: 0x060247CB RID: 149451 RVA: 0x009402F1 File Offset: 0x0093E4F1
		public unsafe UNiagaraComponent NS_chain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x060247CC RID: 149452 RVA: 0x00940306 File Offset: 0x0093E506
		// (set) Token: 0x060247CD RID: 149453 RVA: 0x0094031A File Offset: 0x0093E51A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x060247CE RID: 149454 RVA: 0x0094032F File Offset: 0x0093E52F
		// (set) Token: 0x060247CF RID: 149455 RVA: 0x00940343 File Offset: 0x0093E543
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x060247D0 RID: 149456 RVA: 0x00940358 File Offset: 0x0093E558
		// (set) Token: 0x060247D1 RID: 149457 RVA: 0x00940368 File Offset: 0x0093E568
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x060247D2 RID: 149458 RVA: 0x00940379 File Offset: 0x0093E579
		// (set) Token: 0x060247D3 RID: 149459 RVA: 0x00940389 File Offset: 0x0093E589
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004757 RID: 18263
		// (get) Token: 0x060247D4 RID: 149460 RVA: 0x0094039A File Offset: 0x0093E59A
		// (set) Token: 0x060247D5 RID: 149461 RVA: 0x009403AE File Offset: 0x0093E5AE
		public unsafe UMaterialInstanceDynamic Mat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Chain_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004758 RID: 18264
		// (get) Token: 0x060247D6 RID: 149462 RVA: 0x009403C3 File Offset: 0x0093E5C3
		// (set) Token: 0x060247D7 RID: 149463 RVA: 0x009403D3 File Offset: 0x0093E5D3
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004759 RID: 18265
		// (get) Token: 0x060247D8 RID: 149464 RVA: 0x009403E4 File Offset: 0x0093E5E4
		// (set) Token: 0x060247D9 RID: 149465 RVA: 0x009403F4 File Offset: 0x0093E5F4
		public unsafe float LinkDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Chain_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060247DA RID: 149466 RVA: 0x00940405 File Offset: 0x0093E605
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060247DB RID: 149467 RVA: 0x00940419 File Offset: 0x0093E619
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__initMats_NativeFunctionPtr, null);
		}

		// Token: 0x060247DC RID: 149468 RVA: 0x0094042D File Offset: 0x0093E62D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__initRT_NativeFunctionPtr, null);
		}

		// Token: 0x060247DD RID: 149469 RVA: 0x00940441 File Offset: 0x0093E641
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060247DE RID: 149470 RVA: 0x00940455 File Offset: 0x0093E655
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Chain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060247DF RID: 149471 RVA: 0x0094046A File Offset: 0x0093E66A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060247E0 RID: 149472 RVA: 0x0094047E File Offset: 0x0093E67E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Chain_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060247E1 RID: 149473 RVA: 0x00940494 File Offset: 0x0093E694
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Chain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Chain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Chain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Chain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Chain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247E2 RID: 149474 RVA: 0x009404DC File Offset: 0x0093E6DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Chain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Chain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Chain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Chain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Chain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060247E3 RID: 149475 RVA: 0x00940523 File Offset: 0x0093E723
		protected BP_Chain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121CC RID: 74188
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_Chain.BP_Chain_C";

		// Token: 0x040121CD RID: 74189
		private static IntPtr _ClassPtr;

		// Token: 0x040121CE RID: 74190
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121CF RID: 74191
		internal static int __PropertyOffset_1;

		// Token: 0x040121D0 RID: 74192
		internal static int __PropertyOffset_2;

		// Token: 0x040121D1 RID: 74193
		internal static int __PropertyOffset_3;

		// Token: 0x040121D2 RID: 74194
		internal static int __PropertyOffset_4;

		// Token: 0x040121D3 RID: 74195
		internal static int __PropertyOffset_5;

		// Token: 0x040121D4 RID: 74196
		internal static int __PropertyOffset_6;

		// Token: 0x040121D5 RID: 74197
		internal static int __PropertyOffset_7;

		// Token: 0x040121D6 RID: 74198
		internal static int __PropertyOffset_8;

		// Token: 0x040121D7 RID: 74199
		internal static int __PropertyOffset_9;

		// Token: 0x040121D8 RID: 74200
		internal static int __PropertyOffset_10;

		// Token: 0x040121D9 RID: 74201
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x040121DA RID: 74202
		private static IntPtr __initMats_NativeFunctionPtr;

		// Token: 0x040121DB RID: 74203
		private static IntPtr __initRT_NativeFunctionPtr;

		// Token: 0x040121DC RID: 74204
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040121DD RID: 74205
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040121DE RID: 74206
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009F2D RID: 40749
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318AF RID: 202927
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
