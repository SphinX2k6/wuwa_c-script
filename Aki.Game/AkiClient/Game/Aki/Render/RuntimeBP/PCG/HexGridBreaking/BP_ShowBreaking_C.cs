using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x02003CA3 RID: 15523
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_ShowBreaking.BP_ShowBreaking_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1516)]
	public class BP_ShowBreaking_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024709 RID: 149257 RVA: 0x0093EB6A File Offset: 0x0093CD6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ShowBreaking_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_ShowBreaking.BP_ShowBreaking_C");
			}
			return BP_ShowBreaking_C._ClassPtr;
		}

		// Token: 0x0602470A RID: 149258 RVA: 0x0093EB90 File Offset: 0x0093CD90
		public BP_ShowBreaking_C() : this(BuiltinUtils.AllocNativeUObject(BP_ShowBreaking_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602470B RID: 149259 RVA: 0x0093EBB8 File Offset: 0x0093CDB8
		[NullableContext(1)]
		public BP_ShowBreaking_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ShowBreaking_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004711 RID: 18193
		// (get) Token: 0x0602470C RID: 149260 RVA: 0x0093EBEB File Offset: 0x0093CDEB
		// (set) Token: 0x0602470D RID: 149261 RVA: 0x0093EBFF File Offset: 0x0093CDFF
		public unsafe UStaticMeshComponent SM_Sev_Flo_01GS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004712 RID: 18194
		// (get) Token: 0x0602470E RID: 149262 RVA: 0x0093EC14 File Offset: 0x0093CE14
		// (set) Token: 0x0602470F RID: 149263 RVA: 0x0093EC28 File Offset: 0x0093CE28
		public unsafe UStaticMeshComponent SM_Sev_Flo_01FS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004713 RID: 18195
		// (get) Token: 0x06024710 RID: 149264 RVA: 0x0093EC3D File Offset: 0x0093CE3D
		// (set) Token: 0x06024711 RID: 149265 RVA: 0x0093EC51 File Offset: 0x0093CE51
		public unsafe UStaticMeshComponent SM_Sev_Flo_01ES
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004714 RID: 18196
		// (get) Token: 0x06024712 RID: 149266 RVA: 0x0093EC66 File Offset: 0x0093CE66
		// (set) Token: 0x06024713 RID: 149267 RVA: 0x0093EC7A File Offset: 0x0093CE7A
		public unsafe UStaticMeshComponent SM_Sev_Flo_01DS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004715 RID: 18197
		// (get) Token: 0x06024714 RID: 149268 RVA: 0x0093EC8F File Offset: 0x0093CE8F
		// (set) Token: 0x06024715 RID: 149269 RVA: 0x0093ECA3 File Offset: 0x0093CEA3
		public unsafe UStaticMeshComponent SM_Sev_Flo_01CS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004716 RID: 18198
		// (get) Token: 0x06024716 RID: 149270 RVA: 0x0093ECB8 File Offset: 0x0093CEB8
		// (set) Token: 0x06024717 RID: 149271 RVA: 0x0093ECCC File Offset: 0x0093CECC
		public unsafe UStaticMeshComponent SM_Sev_Flo_01BS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x06024718 RID: 149272 RVA: 0x0093ECE1 File Offset: 0x0093CEE1
		// (set) Token: 0x06024719 RID: 149273 RVA: 0x0093ECF5 File Offset: 0x0093CEF5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ShowBreaking_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x0602471A RID: 149274 RVA: 0x0093ED0A File Offset: 0x0093CF0A
		// (set) Token: 0x0602471B RID: 149275 RVA: 0x0093ED1A File Offset: 0x0093CF1A
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ShowBreaking_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ShowBreaking_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0602471C RID: 149276 RVA: 0x0093ED2B File Offset: 0x0093CF2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetCustomData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShowBreaking_C.__SetCustomData_NativeFunctionPtr, null);
		}

		// Token: 0x0602471D RID: 149277 RVA: 0x0093ED40 File Offset: 0x0093CF40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ShowBreaking_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShowBreaking_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShowBreaking_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShowBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShowBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602471E RID: 149278 RVA: 0x0093ED88 File Offset: 0x0093CF88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ShowBreaking_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ShowBreaking_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShowBreaking_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShowBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShowBreaking_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602471F RID: 149279 RVA: 0x0093EDD0 File Offset: 0x0093CFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ShowBreaking_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ShowBreaking_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShowBreaking_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShowBreaking_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ShowBreaking_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024720 RID: 149280 RVA: 0x0093EE18 File Offset: 0x0093D018
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ShowBreaking_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ShowBreaking_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ShowBreaking_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ShowBreaking_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ShowBreaking_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024721 RID: 149281 RVA: 0x0093EE5F File Offset: 0x0093D05F
		protected BP_ShowBreaking_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012158 RID: 74072
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_ShowBreaking.BP_ShowBreaking_C";

		// Token: 0x04012159 RID: 74073
		private static IntPtr _ClassPtr;

		// Token: 0x0401215A RID: 74074
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401215B RID: 74075
		internal static int __PropertyOffset_1;

		// Token: 0x0401215C RID: 74076
		internal static int __PropertyOffset_2;

		// Token: 0x0401215D RID: 74077
		internal static int __PropertyOffset_3;

		// Token: 0x0401215E RID: 74078
		internal static int __PropertyOffset_4;

		// Token: 0x0401215F RID: 74079
		internal static int __PropertyOffset_5;

		// Token: 0x04012160 RID: 74080
		internal static int __PropertyOffset_6;

		// Token: 0x04012161 RID: 74081
		internal static int __PropertyOffset_7;

		// Token: 0x04012162 RID: 74082
		internal static int __PropertyOffset_8;

		// Token: 0x04012163 RID: 74083
		private static IntPtr __SetCustomData_NativeFunctionPtr;

		// Token: 0x04012164 RID: 74084
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012165 RID: 74085
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F1F RID: 40735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031887 RID: 202887
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F20 RID: 40736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031888 RID: 202888
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
