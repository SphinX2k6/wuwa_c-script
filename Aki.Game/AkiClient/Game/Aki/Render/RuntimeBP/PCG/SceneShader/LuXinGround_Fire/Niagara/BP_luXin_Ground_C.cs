using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader.LuXinGround_Fire.Niagara
{
	// Token: 0x02003C04 RID: 15364
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/LuXinGround_Fire/Niagara/BP_luXin_Ground.BP_luXin_Ground_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1549)]
	public class BP_luXin_Ground_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022FCB RID: 143307 RVA: 0x00917967 File Offset: 0x00915B67
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_luXin_Ground_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/LuXinGround_Fire/Niagara/BP_luXin_Ground.BP_luXin_Ground_C");
			}
			return BP_luXin_Ground_C._ClassPtr;
		}

		// Token: 0x06022FCC RID: 143308 RVA: 0x0091798C File Offset: 0x00915B8C
		public BP_luXin_Ground_C() : this(BuiltinUtils.AllocNativeUObject(BP_luXin_Ground_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022FCD RID: 143309 RVA: 0x009179B4 File Offset: 0x00915BB4
		[NullableContext(1)]
		public BP_luXin_Ground_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_luXin_Ground_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06022FCE RID: 143310 RVA: 0x009179E7 File Offset: 0x00915BE7
		// (set) Token: 0x06022FCF RID: 143311 RVA: 0x009179FB File Offset: 0x00915BFB
		public unsafe UStaticMeshComponent SM_lUXinFire_ES3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x06022FD0 RID: 143312 RVA: 0x00917A10 File Offset: 0x00915C10
		// (set) Token: 0x06022FD1 RID: 143313 RVA: 0x00917A24 File Offset: 0x00915C24
		public unsafe UTextRenderComponent TextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x06022FD2 RID: 143314 RVA: 0x00917A39 File Offset: 0x00915C39
		// (set) Token: 0x06022FD3 RID: 143315 RVA: 0x00917A4D File Offset: 0x00915C4D
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x06022FD4 RID: 143316 RVA: 0x00917A62 File Offset: 0x00915C62
		// (set) Token: 0x06022FD5 RID: 143317 RVA: 0x00917A76 File Offset: 0x00915C76
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_luXin_Ground_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x06022FD6 RID: 143318 RVA: 0x00917A8B File Offset: 0x00915C8B
		// (set) Token: 0x06022FD7 RID: 143319 RVA: 0x00917A9B File Offset: 0x00915C9B
		public unsafe bool EditorDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x06022FD8 RID: 143320 RVA: 0x00917AAC File Offset: 0x00915CAC
		// (set) Token: 0x06022FD9 RID: 143321 RVA: 0x00917ABC File Offset: 0x00915CBC
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x06022FDA RID: 143322 RVA: 0x00917ACD File Offset: 0x00915CCD
		// (set) Token: 0x06022FDB RID: 143323 RVA: 0x00917ADD File Offset: 0x00915CDD
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06022FDC RID: 143324 RVA: 0x00917AEE File Offset: 0x00915CEE
		// (set) Token: 0x06022FDD RID: 143325 RVA: 0x00917AFE File Offset: 0x00915CFE
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06022FDE RID: 143326 RVA: 0x00917B0F File Offset: 0x00915D0F
		// (set) Token: 0x06022FDF RID: 143327 RVA: 0x00917B1F File Offset: 0x00915D1F
		public unsafe float Spread_Niagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06022FE0 RID: 143328 RVA: 0x00917B30 File Offset: 0x00915D30
		// (set) Token: 0x06022FE1 RID: 143329 RVA: 0x00917B40 File Offset: 0x00915D40
		public unsafe bool SetNiagaraActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x06022FE2 RID: 143330 RVA: 0x00917B51 File Offset: 0x00915D51
		// (set) Token: 0x06022FE3 RID: 143331 RVA: 0x00917B61 File Offset: 0x00915D61
		public unsafe float Spread_Burnt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x06022FE4 RID: 143332 RVA: 0x00917B72 File Offset: 0x00915D72
		// (set) Token: 0x06022FE5 RID: 143333 RVA: 0x00917B82 File Offset: 0x00915D82
		public unsafe float Spread_BurntDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x06022FE6 RID: 143334 RVA: 0x00917B93 File Offset: 0x00915D93
		// (set) Token: 0x06022FE7 RID: 143335 RVA: 0x00917BA3 File Offset: 0x00915DA3
		public unsafe float BoundSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x06022FE8 RID: 143336 RVA: 0x00917BB4 File Offset: 0x00915DB4
		// (set) Token: 0x06022FE9 RID: 143337 RVA: 0x00917BC4 File Offset: 0x00915DC4
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06022FEA RID: 143338 RVA: 0x00917BD5 File Offset: 0x00915DD5
		// (set) Token: 0x06022FEB RID: 143339 RVA: 0x00917BE9 File Offset: 0x00915DE9
		public unsafe FLinearColor FireColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06022FEC RID: 143340 RVA: 0x00917BFE File Offset: 0x00915DFE
		// (set) Token: 0x06022FED RID: 143341 RVA: 0x00917C0E File Offset: 0x00915E0E
		public unsafe float End_Fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06022FEE RID: 143342 RVA: 0x00917C1F File Offset: 0x00915E1F
		// (set) Token: 0x06022FEF RID: 143343 RVA: 0x00917C2F File Offset: 0x00915E2F
		public unsafe bool IsES3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_luXin_Ground_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022FF0 RID: 143344 RVA: 0x00917C40 File Offset: 0x00915E40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__Is_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x06022FF1 RID: 143345 RVA: 0x00917C54 File Offset: 0x00915E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__initial_NativeFunctionPtr, null);
		}

		// Token: 0x06022FF2 RID: 143346 RVA: 0x00917C68 File Offset: 0x00915E68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022FF3 RID: 143347 RVA: 0x00917C7C File Offset: 0x00915E7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_luXin_Ground_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022FF4 RID: 143348 RVA: 0x00917C94 File Offset: 0x00915E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_luXin_Ground_C.__EditorTick_FunctionParams* ptr = stackalloc BP_luXin_Ground_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_luXin_Ground_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_luXin_Ground_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022FF5 RID: 143349 RVA: 0x00917CDC File Offset: 0x00915EDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_luXin_Ground_C.__EditorTick_FunctionParams* ptr = stackalloc BP_luXin_Ground_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_luXin_Ground_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_luXin_Ground_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_luXin_Ground_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022FF6 RID: 143350 RVA: 0x00917D24 File Offset: 0x00915F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_luXin_Ground_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_luXin_Ground_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_luXin_Ground_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_luXin_Ground_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022FF7 RID: 143351 RVA: 0x00917D6C File Offset: 0x00915F6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_luXin_Ground_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_luXin_Ground_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_luXin_Ground_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_luXin_Ground_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_luXin_Ground_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022FF8 RID: 143352 RVA: 0x00917DB3 File Offset: 0x00915FB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_luXin_Ground_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022FF9 RID: 143353 RVA: 0x00917DC7 File Offset: 0x00915FC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_luXin_Ground_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022FFA RID: 143354 RVA: 0x00917DDC File Offset: 0x00915FDC
		protected BP_luXin_Ground_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113A1 RID: 70561
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/LuXinGround_Fire/Niagara/BP_luXin_Ground.BP_luXin_Ground_C";

		// Token: 0x040113A2 RID: 70562
		private static IntPtr _ClassPtr;

		// Token: 0x040113A3 RID: 70563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113A4 RID: 70564
		internal static int __PropertyOffset_1;

		// Token: 0x040113A5 RID: 70565
		internal static int __PropertyOffset_2;

		// Token: 0x040113A6 RID: 70566
		internal static int __PropertyOffset_3;

		// Token: 0x040113A7 RID: 70567
		internal static int __PropertyOffset_4;

		// Token: 0x040113A8 RID: 70568
		internal static int __PropertyOffset_5;

		// Token: 0x040113A9 RID: 70569
		internal static int __PropertyOffset_6;

		// Token: 0x040113AA RID: 70570
		internal static int __PropertyOffset_7;

		// Token: 0x040113AB RID: 70571
		internal static int __PropertyOffset_8;

		// Token: 0x040113AC RID: 70572
		internal static int __PropertyOffset_9;

		// Token: 0x040113AD RID: 70573
		internal static int __PropertyOffset_10;

		// Token: 0x040113AE RID: 70574
		internal static int __PropertyOffset_11;

		// Token: 0x040113AF RID: 70575
		internal static int __PropertyOffset_12;

		// Token: 0x040113B0 RID: 70576
		internal static int __PropertyOffset_13;

		// Token: 0x040113B1 RID: 70577
		internal static int __PropertyOffset_14;

		// Token: 0x040113B2 RID: 70578
		internal static int __PropertyOffset_15;

		// Token: 0x040113B3 RID: 70579
		internal static int __PropertyOffset_16;

		// Token: 0x040113B4 RID: 70580
		internal static int __PropertyOffset_17;

		// Token: 0x040113B5 RID: 70581
		private static IntPtr __Is_ES3_NativeFunctionPtr;

		// Token: 0x040113B6 RID: 70582
		private static IntPtr __initial_NativeFunctionPtr;

		// Token: 0x040113B7 RID: 70583
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040113B8 RID: 70584
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040113B9 RID: 70585
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040113BA RID: 70586
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009DF9 RID: 40441
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031618 RID: 202264
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DFA RID: 40442
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031619 RID: 202265
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
