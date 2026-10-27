using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.LensFlare
{
	// Token: 0x02003D6A RID: 15722
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/LensFlare/BP_LensFlare.BP_LensFlare_C")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class BP_LensFlare_C : UKuroLensFlare, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026940 RID: 158016 RVA: 0x00978BC8 File Offset: 0x00976DC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LensFlare_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/LensFlare/BP_LensFlare.BP_LensFlare_C");
			}
			return BP_LensFlare_C._ClassPtr;
		}

		// Token: 0x06026941 RID: 158017 RVA: 0x00978BEC File Offset: 0x00976DEC
		public BP_LensFlare_C() : this(BuiltinUtils.AllocNativeUObject(BP_LensFlare_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026942 RID: 158018 RVA: 0x00978C14 File Offset: 0x00976E14
		[NullableContext(1)]
		public BP_LensFlare_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LensFlare_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x06026943 RID: 158019 RVA: 0x00978C47 File Offset: 0x00976E47
		// (set) Token: 0x06026944 RID: 158020 RVA: 0x00978C5B File Offset: 0x00976E5B
		public unsafe UDataTable LensFlareDataTable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x06026945 RID: 158021 RVA: 0x00978C70 File Offset: 0x00976E70
		// (set) Token: 0x06026946 RID: 158022 RVA: 0x00978C84 File Offset: 0x00976E84
		public unsafe UMaterialInstance MILensFlare
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x06026947 RID: 158023 RVA: 0x00978C99 File Offset: 0x00976E99
		// (set) Token: 0x06026948 RID: 158024 RVA: 0x00978CA9 File Offset: 0x00976EA9
		public unsafe bool EditorUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x06026949 RID: 158025 RVA: 0x00978CBA File Offset: 0x00976EBA
		// (set) Token: 0x0602694A RID: 158026 RVA: 0x00978CCE File Offset: 0x00976ECE
		public unsafe UMaterialInstanceDynamic DMILensFlare
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x0602694B RID: 158027 RVA: 0x00978CE3 File Offset: 0x00976EE3
		// (set) Token: 0x0602694C RID: 158028 RVA: 0x00978CF3 File Offset: 0x00976EF3
		public unsafe int DefaultWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x0602694D RID: 158029 RVA: 0x00978D04 File Offset: 0x00976F04
		// (set) Token: 0x0602694E RID: 158030 RVA: 0x00978D18 File Offset: 0x00976F18
		public unsafe UTexture2D LensFlareTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensFlare_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x0602694F RID: 158031 RVA: 0x00978D2D File Offset: 0x00976F2D
		// (set) Token: 0x06026950 RID: 158032 RVA: 0x00978D41 File Offset: 0x00976F41
		public unsafe FLinearColor LensFlareColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensFlare_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06026951 RID: 158033 RVA: 0x00978D58 File Offset: 0x00976F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EncodeRGBM(FLinearColor InputLinearColor, ref FLinearColor OutputLinearColor)
		{
			BP_LensFlare_C.__EncodeRGBM_FunctionParams* ptr = stackalloc BP_LensFlare_C.__EncodeRGBM_FunctionParams[(UIntPtr)179] + 15L / (long)sizeof(BP_LensFlare_C.__EncodeRGBM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensFlare_C.__EncodeRGBM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputLinearColor = InputLinearColor;
			ptr->OutputLinearColor = OutputLinearColor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensFlare_C.__EncodeRGBM_NativeFunctionPtr, (void*)ptr);
			OutputLinearColor = ptr->OutputLinearColor;
		}

		// Token: 0x06026952 RID: 158034 RVA: 0x00978DBC File Offset: 0x00976FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CanUpdate(ref bool Ret)
		{
			BP_LensFlare_C.__CanUpdate_FunctionParams* ptr = stackalloc BP_LensFlare_C.__CanUpdate_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_LensFlare_C.__CanUpdate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensFlare_C.__CanUpdate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ret = Ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensFlare_C.__CanUpdate_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
		}

		// Token: 0x06026953 RID: 158035 RVA: 0x00978E0C File Offset: 0x0097700C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Update(bool IsRunning, bool Visible, FLinearColor ColorTint, FVectorDouble LensFlareWorldPosition)
		{
			BP_LensFlare_C.__Update_FunctionParams* ptr = stackalloc BP_LensFlare_C.__Update_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_LensFlare_C.__Update_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensFlare_C.__Update_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsRunning = IsRunning;
			ptr->Visible = Visible;
			ptr->ColorTint = ColorTint;
			ptr->LensFlareWorldPosition = LensFlareWorldPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensFlare_C.__Update_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026954 RID: 158036 RVA: 0x00978E68 File Offset: 0x00977068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensFlare_C.__InitMesh_NativeFunctionPtr, null);
		}

		// Token: 0x06026955 RID: 158037 RVA: 0x00978E7C File Offset: 0x0097707C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitLensFlare(UProceduralMeshComponent InputProceduralMesh)
		{
			BP_LensFlare_C.__InitLensFlare_FunctionParams* ptr = stackalloc BP_LensFlare_C.__InitLensFlare_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_LensFlare_C.__InitLensFlare_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensFlare_C.__InitLensFlare_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputProceduralMesh = ((InputProceduralMesh != null) ? InputProceduralMesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensFlare_C.__InitLensFlare_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026956 RID: 158038 RVA: 0x00978ED1 File Offset: 0x009770D1
		protected BP_LensFlare_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401362F RID: 79407
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/LensFlare/BP_LensFlare.BP_LensFlare_C";

		// Token: 0x04013630 RID: 79408
		private static IntPtr _ClassPtr;

		// Token: 0x04013631 RID: 79409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013632 RID: 79410
		internal static int __PropertyOffset_0;

		// Token: 0x04013633 RID: 79411
		internal static int __PropertyOffset_1;

		// Token: 0x04013634 RID: 79412
		internal static int __PropertyOffset_2;

		// Token: 0x04013635 RID: 79413
		internal static int __PropertyOffset_3;

		// Token: 0x04013636 RID: 79414
		internal static int __PropertyOffset_4;

		// Token: 0x04013637 RID: 79415
		internal static int __PropertyOffset_5;

		// Token: 0x04013638 RID: 79416
		internal static int __PropertyOffset_6;

		// Token: 0x04013639 RID: 79417
		private static IntPtr __EncodeRGBM_NativeFunctionPtr;

		// Token: 0x0401363A RID: 79418
		private static IntPtr __CanUpdate_NativeFunctionPtr;

		// Token: 0x0401363B RID: 79419
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0401363C RID: 79420
		private static IntPtr __InitMesh_NativeFunctionPtr;

		// Token: 0x0401363D RID: 79421
		private static IntPtr __InitLensFlare_NativeFunctionPtr;

		// Token: 0x0200A11D RID: 41245
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 164)]
		protected ref struct __EncodeRGBM_FunctionParams
		{
			// Token: 0x04031C93 RID: 203923
			[FieldOffset(0)]
			public FLinearColor InputLinearColor;

			// Token: 0x04031C94 RID: 203924
			[FieldOffset(16)]
			public FLinearColor OutputLinearColor;
		}

		// Token: 0x0200A11E RID: 41246
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CanUpdate_FunctionParams
		{
			// Token: 0x04031C95 RID: 203925
			[FieldOffset(0)]
			public bool Ret;
		}

		// Token: 0x0200A11F RID: 41247
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04031C96 RID: 203926
			[FieldOffset(0)]
			public bool IsRunning;

			// Token: 0x04031C97 RID: 203927
			[FieldOffset(1)]
			public bool Visible;

			// Token: 0x04031C98 RID: 203928
			[FieldOffset(4)]
			public FLinearColor ColorTint;

			// Token: 0x04031C99 RID: 203929
			[FieldOffset(24)]
			public FVectorDouble LensFlareWorldPosition;
		}

		// Token: 0x0200A120 RID: 41248
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitLensFlare_FunctionParams
		{
			// Token: 0x04031C9A RID: 203930
			[FieldOffset(0)]
			public IntPtr InputProceduralMesh;
		}
	}
}
