using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Star
{
	// Token: 0x02003D44 RID: 15684
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Star/BP_Star.BP_Star_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class BP_Star_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602618C RID: 156044 RVA: 0x0096B678 File Offset: 0x00969878
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Star_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Star/BP_Star.BP_Star_C");
			}
			return BP_Star_C._ClassPtr;
		}

		// Token: 0x0602618D RID: 156045 RVA: 0x0096B69C File Offset: 0x0096989C
		public BP_Star_C() : this(BuiltinUtils.AllocNativeUObject(BP_Star_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602618E RID: 156046 RVA: 0x0096B6C4 File Offset: 0x009698C4
		[NullableContext(1)]
		public BP_Star_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Star_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x0602618F RID: 156047 RVA: 0x0096B6F7 File Offset: 0x009698F7
		// (set) Token: 0x06026190 RID: 156048 RVA: 0x0096B70B File Offset: 0x0096990B
		public unsafe UStaticMeshComponent StarLayer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005065 RID: 20581
		// (get) Token: 0x06026191 RID: 156049 RVA: 0x0096B720 File Offset: 0x00969920
		// (set) Token: 0x06026192 RID: 156050 RVA: 0x0096B734 File Offset: 0x00969934
		public unsafe UStaticMeshComponent StarLayer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x06026193 RID: 156051 RVA: 0x0096B749 File Offset: 0x00969949
		// (set) Token: 0x06026194 RID: 156052 RVA: 0x0096B75D File Offset: 0x0096995D
		public unsafe UStaticMeshComponent StarLayer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x06026195 RID: 156053 RVA: 0x0096B772 File Offset: 0x00969972
		// (set) Token: 0x06026196 RID: 156054 RVA: 0x0096B786 File Offset: 0x00969986
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x06026197 RID: 156055 RVA: 0x0096B79B File Offset: 0x0096999B
		// (set) Token: 0x06026198 RID: 156056 RVA: 0x0096B7AB File Offset: 0x009699AB
		public unsafe float RotationLayer1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x06026199 RID: 156057 RVA: 0x0096B7BC File Offset: 0x009699BC
		// (set) Token: 0x0602619A RID: 156058 RVA: 0x0096B7CC File Offset: 0x009699CC
		public unsafe float RotationLayer2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x0602619B RID: 156059 RVA: 0x0096B7DD File Offset: 0x009699DD
		// (set) Token: 0x0602619C RID: 156060 RVA: 0x0096B7ED File Offset: 0x009699ED
		public unsafe float RotationLayer3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x0602619D RID: 156061 RVA: 0x0096B7FE File Offset: 0x009699FE
		// (set) Token: 0x0602619E RID: 156062 RVA: 0x0096B812 File Offset: 0x00969A12
		public unsafe FLinearColor Layer1Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x0602619F RID: 156063 RVA: 0x0096B827 File Offset: 0x00969A27
		// (set) Token: 0x060261A0 RID: 156064 RVA: 0x0096B83B File Offset: 0x00969A3B
		public unsafe FLinearColor Layer2Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x060261A1 RID: 156065 RVA: 0x0096B850 File Offset: 0x00969A50
		// (set) Token: 0x060261A2 RID: 156066 RVA: 0x0096B864 File Offset: 0x00969A64
		public unsafe FLinearColor Layer3Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Star_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x060261A3 RID: 156067 RVA: 0x0096B879 File Offset: 0x00969A79
		// (set) Token: 0x060261A4 RID: 156068 RVA: 0x0096B88D File Offset: 0x00969A8D
		public unsafe UMaterialInstanceDynamic MID_Layer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x060261A5 RID: 156069 RVA: 0x0096B8A2 File Offset: 0x00969AA2
		// (set) Token: 0x060261A6 RID: 156070 RVA: 0x0096B8B6 File Offset: 0x00969AB6
		public unsafe UMaterialInstanceDynamic MID_Layer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x060261A7 RID: 156071 RVA: 0x0096B8CB File Offset: 0x00969ACB
		// (set) Token: 0x060261A8 RID: 156072 RVA: 0x0096B8DF File Offset: 0x00969ADF
		public unsafe UMaterialInstanceDynamic MID_Layer3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Star_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x060261A9 RID: 156073 RVA: 0x0096B8F4 File Offset: 0x00969AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Visible(bool Bool)
		{
			BP_Star_C.__Visible_FunctionParams* ptr = stackalloc BP_Star_C.__Visible_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_Star_C.__Visible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Star_C.__Visible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Bool = Bool;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Star_C.__Visible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060261AA RID: 156074 RVA: 0x0096B93C File Offset: 0x00969B3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupData(float RotationLayer1, float RotationLayer2, float RotationLayer3, FLinearColor ColorLayer1, FLinearColor ColorLayer2, FLinearColor ColorLayer3)
		{
			BP_Star_C.__SetupData_FunctionParams* ptr = stackalloc BP_Star_C.__SetupData_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(BP_Star_C.__SetupData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Star_C.__SetupData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RotationLayer1 = RotationLayer1;
			ptr->RotationLayer2 = RotationLayer2;
			ptr->RotationLayer3 = RotationLayer3;
			ptr->ColorLayer1 = ColorLayer1;
			ptr->ColorLayer2 = ColorLayer2;
			ptr->ColorLayer3 = ColorLayer3;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Star_C.__SetupData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060261AB RID: 156075 RVA: 0x0096B9A8 File Offset: 0x00969BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RotateStar(float DeltaTime)
		{
			BP_Star_C.__RotateStar_FunctionParams* ptr = stackalloc BP_Star_C.__RotateStar_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Star_C.__RotateStar_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Star_C.__RotateStar_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Star_C.__RotateStar_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060261AC RID: 156076 RVA: 0x0096B9F0 File Offset: 0x00969BF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RotateMesh(UStaticMeshComponent Mesh, float RotataionSpeed, float DeltaTime)
		{
			BP_Star_C.__RotateMesh_FunctionParams* ptr = stackalloc BP_Star_C.__RotateMesh_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BP_Star_C.__RotateMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Star_C.__RotateMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->RotataionSpeed = RotataionSpeed;
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Star_C.__RotateMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060261AD RID: 156077 RVA: 0x0096BA56 File Offset: 0x00969C56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Star_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060261AE RID: 156078 RVA: 0x0096BA6A File Offset: 0x00969C6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Star_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060261AF RID: 156079 RVA: 0x0096BA7F File Offset: 0x00969C7F
		protected BP_Star_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401312C RID: 78124
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Star/BP_Star.BP_Star_C";

		// Token: 0x0401312D RID: 78125
		private static IntPtr _ClassPtr;

		// Token: 0x0401312E RID: 78126
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401312F RID: 78127
		internal static int __PropertyOffset_0;

		// Token: 0x04013130 RID: 78128
		internal static int __PropertyOffset_1;

		// Token: 0x04013131 RID: 78129
		internal static int __PropertyOffset_2;

		// Token: 0x04013132 RID: 78130
		internal static int __PropertyOffset_3;

		// Token: 0x04013133 RID: 78131
		internal static int __PropertyOffset_4;

		// Token: 0x04013134 RID: 78132
		internal static int __PropertyOffset_5;

		// Token: 0x04013135 RID: 78133
		internal static int __PropertyOffset_6;

		// Token: 0x04013136 RID: 78134
		internal static int __PropertyOffset_7;

		// Token: 0x04013137 RID: 78135
		internal static int __PropertyOffset_8;

		// Token: 0x04013138 RID: 78136
		internal static int __PropertyOffset_9;

		// Token: 0x04013139 RID: 78137
		internal static int __PropertyOffset_10;

		// Token: 0x0401313A RID: 78138
		internal static int __PropertyOffset_11;

		// Token: 0x0401313B RID: 78139
		internal static int __PropertyOffset_12;

		// Token: 0x0401313C RID: 78140
		private static IntPtr __Visible_NativeFunctionPtr;

		// Token: 0x0401313D RID: 78141
		private static IntPtr __SetupData_NativeFunctionPtr;

		// Token: 0x0401313E RID: 78142
		private static IntPtr __RotateStar_NativeFunctionPtr;

		// Token: 0x0401313F RID: 78143
		private static IntPtr __RotateMesh_NativeFunctionPtr;

		// Token: 0x04013140 RID: 78144
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0200A09B RID: 41115
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __Visible_FunctionParams
		{
			// Token: 0x04031B99 RID: 203673
			[FieldOffset(0)]
			public bool Bool;
		}

		// Token: 0x0200A09C RID: 41116
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __SetupData_FunctionParams
		{
			// Token: 0x04031B9A RID: 203674
			[FieldOffset(0)]
			public float RotationLayer1;

			// Token: 0x04031B9B RID: 203675
			[FieldOffset(4)]
			public float RotationLayer2;

			// Token: 0x04031B9C RID: 203676
			[FieldOffset(8)]
			public float RotationLayer3;

			// Token: 0x04031B9D RID: 203677
			[FieldOffset(12)]
			public FLinearColor ColorLayer1;

			// Token: 0x04031B9E RID: 203678
			[FieldOffset(28)]
			public FLinearColor ColorLayer2;

			// Token: 0x04031B9F RID: 203679
			[FieldOffset(44)]
			public FLinearColor ColorLayer3;
		}

		// Token: 0x0200A09D RID: 41117
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RotateStar_FunctionParams
		{
			// Token: 0x04031BA0 RID: 203680
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A09E RID: 41118
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __RotateMesh_FunctionParams
		{
			// Token: 0x04031BA1 RID: 203681
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031BA2 RID: 203682
			[FieldOffset(8)]
			public float RotataionSpeed;

			// Token: 0x04031BA3 RID: 203683
			[FieldOffset(12)]
			public float DeltaTime;
		}
	}
}
