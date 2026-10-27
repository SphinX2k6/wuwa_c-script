using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FarRotatorCloud
{
	// Token: 0x02003DB3 RID: 15795
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FarRotatorCloud/BP_FarRotatorCloud.BP_FarRotatorCloud_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1572)]
	public class BP_FarRotatorCloud_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060273BC RID: 160700 RVA: 0x0098BCC0 File Offset: 0x00989EC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FarRotatorCloud_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FarRotatorCloud/BP_FarRotatorCloud.BP_FarRotatorCloud_C");
			}
			return BP_FarRotatorCloud_C._ClassPtr;
		}

		// Token: 0x060273BD RID: 160701 RVA: 0x0098BCE4 File Offset: 0x00989EE4
		public BP_FarRotatorCloud_C() : this(BuiltinUtils.AllocNativeUObject(BP_FarRotatorCloud_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060273BE RID: 160702 RVA: 0x0098BD0C File Offset: 0x00989F0C
		[NullableContext(1)]
		public BP_FarRotatorCloud_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FarRotatorCloud_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x060273BF RID: 160703 RVA: 0x0098BD3F File Offset: 0x00989F3F
		// (set) Token: 0x060273C0 RID: 160704 RVA: 0x0098BD53 File Offset: 0x00989F53
		public unsafe UStaticMeshComponent Layer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x060273C1 RID: 160705 RVA: 0x0098BD68 File Offset: 0x00989F68
		// (set) Token: 0x060273C2 RID: 160706 RVA: 0x0098BD7C File Offset: 0x00989F7C
		public unsafe UStaticMeshComponent Layer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x060273C3 RID: 160707 RVA: 0x0098BD91 File Offset: 0x00989F91
		// (set) Token: 0x060273C4 RID: 160708 RVA: 0x0098BDA5 File Offset: 0x00989FA5
		public unsafe UStaticMeshComponent Layer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x060273C5 RID: 160709 RVA: 0x0098BDBA File Offset: 0x00989FBA
		// (set) Token: 0x060273C6 RID: 160710 RVA: 0x0098BDCE File Offset: 0x00989FCE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x060273C7 RID: 160711 RVA: 0x0098BDE3 File Offset: 0x00989FE3
		// (set) Token: 0x060273C8 RID: 160712 RVA: 0x0098BDF7 File Offset: 0x00989FF7
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x060273C9 RID: 160713 RVA: 0x0098BE0C File Offset: 0x0098A00C
		// (set) Token: 0x060273CA RID: 160714 RVA: 0x0098BE1C File Offset: 0x0098A01C
		public unsafe bool Close_Billboard
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x060273CB RID: 160715 RVA: 0x0098BE2D File Offset: 0x0098A02D
		// (set) Token: 0x060273CC RID: 160716 RVA: 0x0098BE3D File Offset: 0x0098A03D
		public unsafe float CloudRotatorSpeed_Layer1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x060273CD RID: 160717 RVA: 0x0098BE4E File Offset: 0x0098A04E
		// (set) Token: 0x060273CE RID: 160718 RVA: 0x0098BE5E File Offset: 0x0098A05E
		public unsafe float CloudRotatorSpeed_Layer2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x060273CF RID: 160719 RVA: 0x0098BE6F File Offset: 0x0098A06F
		// (set) Token: 0x060273D0 RID: 160720 RVA: 0x0098BE7F File Offset: 0x0098A07F
		public unsafe float CloudRotatorSpeed_Layer3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x060273D1 RID: 160721 RVA: 0x0098BE90 File Offset: 0x0098A090
		// (set) Token: 0x060273D2 RID: 160722 RVA: 0x0098BEA0 File Offset: 0x0098A0A0
		public unsafe float WorldPositionOffset_Intansity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x060273D3 RID: 160723 RVA: 0x0098BEB1 File Offset: 0x0098A0B1
		// (set) Token: 0x060273D4 RID: 160724 RVA: 0x0098BEC5 File Offset: 0x0098A0C5
		public unsafe UMaterialInstance Material_Layer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x060273D5 RID: 160725 RVA: 0x0098BEDA File Offset: 0x0098A0DA
		// (set) Token: 0x060273D6 RID: 160726 RVA: 0x0098BEEE File Offset: 0x0098A0EE
		public unsafe UMaterialInstance Material_Layer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x060273D7 RID: 160727 RVA: 0x0098BF03 File Offset: 0x0098A103
		// (set) Token: 0x060273D8 RID: 160728 RVA: 0x0098BF17 File Offset: 0x0098A117
		public unsafe UMaterialInstance Material_Layer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x060273D9 RID: 160729 RVA: 0x0098BF2C File Offset: 0x0098A12C
		// (set) Token: 0x060273DA RID: 160730 RVA: 0x0098BF40 File Offset: 0x0098A140
		public unsafe UMaterialInstanceDynamic MID_Material_Layer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x060273DB RID: 160731 RVA: 0x0098BF55 File Offset: 0x0098A155
		// (set) Token: 0x060273DC RID: 160732 RVA: 0x0098BF69 File Offset: 0x0098A169
		public unsafe UMaterialInstanceDynamic MID_Material_Layer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x060273DD RID: 160733 RVA: 0x0098BF7E File Offset: 0x0098A17E
		// (set) Token: 0x060273DE RID: 160734 RVA: 0x0098BF92 File Offset: 0x0098A192
		public unsafe UMaterialInstanceDynamic MID_Material_Layer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FarRotatorCloud_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x060273DF RID: 160735 RVA: 0x0098BFA7 File Offset: 0x0098A1A7
		// (set) Token: 0x060273E0 RID: 160736 RVA: 0x0098BFB7 File Offset: 0x0098A1B7
		public unsafe float VolumeCloudFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FarRotatorCloud_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x060273E1 RID: 160737 RVA: 0x0098BFC8 File Offset: 0x0098A1C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FarRotatorCloud_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060273E2 RID: 160738 RVA: 0x0098BFDC File Offset: 0x0098A1DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FarRotatorCloud_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060273E3 RID: 160739 RVA: 0x0098BFF1 File Offset: 0x0098A1F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FarRotatorCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060273E4 RID: 160740 RVA: 0x0098C005 File Offset: 0x0098A205
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FarRotatorCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060273E5 RID: 160741 RVA: 0x0098C01C File Offset: 0x0098A21C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FarRotatorCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FarRotatorCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273E6 RID: 160742 RVA: 0x0098C064 File Offset: 0x0098A264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FarRotatorCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FarRotatorCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FarRotatorCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060273E7 RID: 160743 RVA: 0x0098C0AC File Offset: 0x0098A2AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FarRotatorCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FarRotatorCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FarRotatorCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FarRotatorCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FarRotatorCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060273E8 RID: 160744 RVA: 0x0098C0F4 File Offset: 0x0098A2F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FarRotatorCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FarRotatorCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FarRotatorCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FarRotatorCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FarRotatorCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060273E9 RID: 160745 RVA: 0x0098C13B File Offset: 0x0098A33B
		protected BP_FarRotatorCloud_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013CAD RID: 81069
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FarRotatorCloud/BP_FarRotatorCloud.BP_FarRotatorCloud_C";

		// Token: 0x04013CAE RID: 81070
		private static IntPtr _ClassPtr;

		// Token: 0x04013CAF RID: 81071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013CB0 RID: 81072
		internal static int __PropertyOffset_1;

		// Token: 0x04013CB1 RID: 81073
		internal static int __PropertyOffset_2;

		// Token: 0x04013CB2 RID: 81074
		internal static int __PropertyOffset_3;

		// Token: 0x04013CB3 RID: 81075
		internal static int __PropertyOffset_4;

		// Token: 0x04013CB4 RID: 81076
		internal static int __PropertyOffset_5;

		// Token: 0x04013CB5 RID: 81077
		internal static int __PropertyOffset_6;

		// Token: 0x04013CB6 RID: 81078
		internal static int __PropertyOffset_7;

		// Token: 0x04013CB7 RID: 81079
		internal static int __PropertyOffset_8;

		// Token: 0x04013CB8 RID: 81080
		internal static int __PropertyOffset_9;

		// Token: 0x04013CB9 RID: 81081
		internal static int __PropertyOffset_10;

		// Token: 0x04013CBA RID: 81082
		internal static int __PropertyOffset_11;

		// Token: 0x04013CBB RID: 81083
		internal static int __PropertyOffset_12;

		// Token: 0x04013CBC RID: 81084
		internal static int __PropertyOffset_13;

		// Token: 0x04013CBD RID: 81085
		internal static int __PropertyOffset_14;

		// Token: 0x04013CBE RID: 81086
		internal static int __PropertyOffset_15;

		// Token: 0x04013CBF RID: 81087
		internal static int __PropertyOffset_16;

		// Token: 0x04013CC0 RID: 81088
		internal static int __PropertyOffset_17;

		// Token: 0x04013CC1 RID: 81089
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013CC2 RID: 81090
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013CC3 RID: 81091
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013CC4 RID: 81092
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A206 RID: 41478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E6E RID: 204398
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A207 RID: 41479
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E6F RID: 204399
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
