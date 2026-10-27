using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0B RID: 15627
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1545)]
	public class BP_CenterDissolvePosition_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060256BA RID: 153274 RVA: 0x00959420 File Offset: 0x00957620
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CenterDissolvePosition_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C");
			}
			return BP_CenterDissolvePosition_C._ClassPtr;
		}

		// Token: 0x060256BB RID: 153275 RVA: 0x00959444 File Offset: 0x00957644
		public BP_CenterDissolvePosition_C() : this(BuiltinUtils.AllocNativeUObject(BP_CenterDissolvePosition_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060256BC RID: 153276 RVA: 0x0095946C File Offset: 0x0095766C
		[NullableContext(1)]
		public BP_CenterDissolvePosition_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CenterDissolvePosition_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C92 RID: 19602
		// (get) Token: 0x060256BD RID: 153277 RVA: 0x0095949F File Offset: 0x0095769F
		// (set) Token: 0x060256BE RID: 153278 RVA: 0x009594B3 File Offset: 0x009576B3
		public unsafe USceneComponent DissolveCenter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x060256BF RID: 153279 RVA: 0x009594C8 File Offset: 0x009576C8
		// (set) Token: 0x060256C0 RID: 153280 RVA: 0x009594DC File Offset: 0x009576DC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x060256C1 RID: 153281 RVA: 0x009594F1 File Offset: 0x009576F1
		// (set) Token: 0x060256C2 RID: 153282 RVA: 0x00959505 File Offset: 0x00957705
		public unsafe UTexture2D T_Noise
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CenterDissolvePosition_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x060256C3 RID: 153283 RVA: 0x0095951A File Offset: 0x0095771A
		// (set) Token: 0x060256C4 RID: 153284 RVA: 0x0095952A File Offset: 0x0095772A
		public unsafe float Dist_UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x060256C5 RID: 153285 RVA: 0x0095953B File Offset: 0x0095773B
		// (set) Token: 0x060256C6 RID: 153286 RVA: 0x0095954F File Offset: 0x0095774F
		public unsafe FLinearColor EmissiveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x060256C7 RID: 153287 RVA: 0x00959564 File Offset: 0x00957764
		// (set) Token: 0x060256C8 RID: 153288 RVA: 0x00959578 File Offset: 0x00957778
		public unsafe FVector CubeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x060256C9 RID: 153289 RVA: 0x0095958D File Offset: 0x0095778D
		// (set) Token: 0x060256CA RID: 153290 RVA: 0x0095959D File Offset: 0x0095779D
		public unsafe float DissolveRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x060256CB RID: 153291 RVA: 0x009595AE File Offset: 0x009577AE
		// (set) Token: 0x060256CC RID: 153292 RVA: 0x009595BE File Offset: 0x009577BE
		public unsafe float EdgeFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x060256CD RID: 153293 RVA: 0x009595CF File Offset: 0x009577CF
		// (set) Token: 0x060256CE RID: 153294 RVA: 0x009595DF File Offset: 0x009577DF
		public unsafe float DissolveEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x060256CF RID: 153295 RVA: 0x009595F0 File Offset: 0x009577F0
		// (set) Token: 0x060256D0 RID: 153296 RVA: 0x00959629 File Offset: 0x00957829
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> StaticMeshDMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._StaticMeshDMI) == null)
				{
					result = (this._StaticMeshDMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticMeshDMI.CopyAssign(value);
			}
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x060256D1 RID: 153297 RVA: 0x00959637 File Offset: 0x00957837
		// (set) Token: 0x060256D2 RID: 153298 RVA: 0x00959647 File Offset: 0x00957847
		public unsafe bool DMISet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CenterDissolvePosition_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x060256D3 RID: 153299 RVA: 0x00959658 File Offset: 0x00957858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Dissolve_Param()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__Set_Dissolve_Param_NativeFunctionPtr, null);
		}

		// Token: 0x060256D4 RID: 153300 RVA: 0x0095966C File Offset: 0x0095786C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_Dynamic_Material_Instance()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__Create_Dynamic_Material_Instance_NativeFunctionPtr, null);
		}

		// Token: 0x060256D5 RID: 153301 RVA: 0x00959680 File Offset: 0x00957880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060256D6 RID: 153302 RVA: 0x00959694 File Offset: 0x00957894
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060256D7 RID: 153303 RVA: 0x009596AC File Offset: 0x009578AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x009596F4 File Offset: 0x009578F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x0095973C File Offset: 0x0095793C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060256DA RID: 153306 RVA: 0x00959784 File Offset: 0x00957984
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CenterDissolvePosition_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CenterDissolvePosition_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CenterDissolvePosition_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CenterDissolvePosition_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256DB RID: 153307 RVA: 0x009597CB File Offset: 0x009579CB
		protected BP_CenterDissolvePosition_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AAB RID: 76459
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CenterDissolvePosition.BP_CenterDissolvePosition_C";

		// Token: 0x04012AAC RID: 76460
		private static IntPtr _ClassPtr;

		// Token: 0x04012AAD RID: 76461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AAE RID: 76462
		internal static int __PropertyOffset_1;

		// Token: 0x04012AAF RID: 76463
		internal static int __PropertyOffset_2;

		// Token: 0x04012AB0 RID: 76464
		internal static int __PropertyOffset_3;

		// Token: 0x04012AB1 RID: 76465
		internal static int __PropertyOffset_4;

		// Token: 0x04012AB2 RID: 76466
		internal static int __PropertyOffset_5;

		// Token: 0x04012AB3 RID: 76467
		internal static int __PropertyOffset_6;

		// Token: 0x04012AB4 RID: 76468
		internal static int __PropertyOffset_7;

		// Token: 0x04012AB5 RID: 76469
		internal static int __PropertyOffset_8;

		// Token: 0x04012AB6 RID: 76470
		internal static int __PropertyOffset_9;

		// Token: 0x04012AB7 RID: 76471
		internal static int __PropertyOffset_10;

		// Token: 0x04012AB8 RID: 76472
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _StaticMeshDMI;

		// Token: 0x04012AB9 RID: 76473
		internal static int __PropertyOffset_11;

		// Token: 0x04012ABA RID: 76474
		private static IntPtr __Set_Dissolve_Param_NativeFunctionPtr;

		// Token: 0x04012ABB RID: 76475
		private static IntPtr __Create_Dynamic_Material_Instance_NativeFunctionPtr;

		// Token: 0x04012ABC RID: 76476
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012ABD RID: 76477
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012ABE RID: 76478
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FF6 RID: 40950
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A91 RID: 203409
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FF7 RID: 40951
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A92 RID: 203410
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
