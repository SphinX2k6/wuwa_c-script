using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.GodRay
{
	// Token: 0x02003C83 RID: 15491
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeMediaPlaneLight.BP_KuroVolumeMediaPlaneLight_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_KuroVolumeMediaPlaneLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602420A RID: 147978 RVA: 0x009358E4 File Offset: 0x00933AE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeMediaPlaneLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeMediaPlaneLight.BP_KuroVolumeMediaPlaneLight_C");
			}
			return BP_KuroVolumeMediaPlaneLight_C._ClassPtr;
		}

		// Token: 0x0602420B RID: 147979 RVA: 0x00935908 File Offset: 0x00933B08
		public BP_KuroVolumeMediaPlaneLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeMediaPlaneLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602420C RID: 147980 RVA: 0x00935930 File Offset: 0x00933B30
		[NullableContext(1)]
		public BP_KuroVolumeMediaPlaneLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeMediaPlaneLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x0602420D RID: 147981 RVA: 0x00935963 File Offset: 0x00933B63
		// (set) Token: 0x0602420E RID: 147982 RVA: 0x00935977 File Offset: 0x00933B77
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x0602420F RID: 147983 RVA: 0x0093598C File Offset: 0x00933B8C
		// (set) Token: 0x06024210 RID: 147984 RVA: 0x009359A0 File Offset: 0x00933BA0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x06024211 RID: 147985 RVA: 0x009359B8 File Offset: 0x00933BB8
		// (set) Token: 0x06024212 RID: 147986 RVA: 0x009359F1 File Offset: 0x00933BF1
		[Nullable(1)]
		public TArray<AStaticMeshActor> VolumeLightMesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._VolumeLightMesh) == null)
				{
					result = (this._VolumeLightMesh = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VolumeLightMesh.CopyAssign(value);
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x06024213 RID: 147987 RVA: 0x009359FF File Offset: 0x00933BFF
		// (set) Token: 0x06024214 RID: 147988 RVA: 0x00935A13 File Offset: 0x00933C13
		public unsafe UMaterialInstance SourceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x06024215 RID: 147989 RVA: 0x00935A28 File Offset: 0x00933C28
		// (set) Token: 0x06024216 RID: 147990 RVA: 0x00935A3C File Offset: 0x00933C3C
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x06024217 RID: 147991 RVA: 0x00935A51 File Offset: 0x00933C51
		// (set) Token: 0x06024218 RID: 147992 RVA: 0x00935A61 File Offset: 0x00933C61
		public unsafe bool bUseMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x06024219 RID: 147993 RVA: 0x00935A72 File Offset: 0x00933C72
		// (set) Token: 0x0602421A RID: 147994 RVA: 0x00935A82 File Offset: 0x00933C82
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x0602421B RID: 147995 RVA: 0x00935A93 File Offset: 0x00933C93
		// (set) Token: 0x0602421C RID: 147996 RVA: 0x00935AA7 File Offset: 0x00933CA7
		public unsafe UTextureRenderTarget2D Texture_Render_Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x0602421D RID: 147997 RVA: 0x00935ABC File Offset: 0x00933CBC
		// (set) Token: 0x0602421E RID: 147998 RVA: 0x00935AD0 File Offset: 0x00933CD0
		public unsafe MediaPlayForModel_Special_C BoundMediaPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<MediaPlayForModel_Special_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeMediaPlaneLight_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x0602421F RID: 147999 RVA: 0x00935AE5 File Offset: 0x00933CE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlane()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__UpdatePlane_NativeFunctionPtr, null);
		}

		// Token: 0x06024220 RID: 148000 RVA: 0x00935AFC File Offset: 0x00933CFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVolumeMeshVisibility(bool bNewVisibility)
		{
			BP_KuroVolumeMediaPlaneLight_C.__SetVolumeMeshVisibility_FunctionParams* ptr = stackalloc BP_KuroVolumeMediaPlaneLight_C.__SetVolumeMeshVisibility_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroVolumeMediaPlaneLight_C.__SetVolumeMeshVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeMediaPlaneLight_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewVisibility = bNewVisibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__SetVolumeMeshVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024221 RID: 148001 RVA: 0x00935B42 File Offset: 0x00933D42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__UpdateMat_NativeFunctionPtr, null);
		}

		// Token: 0x06024222 RID: 148002 RVA: 0x00935B56 File Offset: 0x00933D56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Render()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__Render_NativeFunctionPtr, null);
		}

		// Token: 0x06024223 RID: 148003 RVA: 0x00935B6A File Offset: 0x00933D6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024224 RID: 148004 RVA: 0x00935B7E File Offset: 0x00933D7E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024225 RID: 148005 RVA: 0x00935B93 File Offset: 0x00933D93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024226 RID: 148006 RVA: 0x00935BA7 File Offset: 0x00933DA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024227 RID: 148007 RVA: 0x00935BBC File Offset: 0x00933DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024228 RID: 148008 RVA: 0x00935C04 File Offset: 0x00933E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024229 RID: 148009 RVA: 0x00935C4C File Offset: 0x00933E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeMediaPlaneLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602422A RID: 148010 RVA: 0x00935C94 File Offset: 0x00933E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeMediaPlaneLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeMediaPlaneLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeMediaPlaneLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602422B RID: 148011 RVA: 0x00935CDB File Offset: 0x00933EDB
		protected BP_KuroVolumeMediaPlaneLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E33 RID: 73267
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/GodRay/BP_KuroVolumeMediaPlaneLight.BP_KuroVolumeMediaPlaneLight_C";

		// Token: 0x04011E34 RID: 73268
		private static IntPtr _ClassPtr;

		// Token: 0x04011E35 RID: 73269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E36 RID: 73270
		internal static int __PropertyOffset_1;

		// Token: 0x04011E37 RID: 73271
		internal static int __PropertyOffset_2;

		// Token: 0x04011E38 RID: 73272
		internal static int __PropertyOffset_3;

		// Token: 0x04011E39 RID: 73273
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _VolumeLightMesh;

		// Token: 0x04011E3A RID: 73274
		internal static int __PropertyOffset_4;

		// Token: 0x04011E3B RID: 73275
		internal static int __PropertyOffset_5;

		// Token: 0x04011E3C RID: 73276
		internal static int __PropertyOffset_6;

		// Token: 0x04011E3D RID: 73277
		internal static int __PropertyOffset_7;

		// Token: 0x04011E3E RID: 73278
		internal static int __PropertyOffset_8;

		// Token: 0x04011E3F RID: 73279
		internal static int __PropertyOffset_9;

		// Token: 0x04011E40 RID: 73280
		private static IntPtr __UpdatePlane_NativeFunctionPtr;

		// Token: 0x04011E41 RID: 73281
		private static IntPtr __SetVolumeMeshVisibility_NativeFunctionPtr;

		// Token: 0x04011E42 RID: 73282
		private static IntPtr __UpdateMat_NativeFunctionPtr;

		// Token: 0x04011E43 RID: 73283
		private static IntPtr __Render_NativeFunctionPtr;

		// Token: 0x04011E44 RID: 73284
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011E45 RID: 73285
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011E46 RID: 73286
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011E47 RID: 73287
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009ED3 RID: 40659
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetVolumeMeshVisibility_FunctionParams
		{
			// Token: 0x040317C0 RID: 202688
			[FieldOffset(0)]
			public bool bNewVisibility;
		}

		// Token: 0x02009ED4 RID: 40660
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317C1 RID: 202689
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009ED5 RID: 40661
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040317C2 RID: 202690
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
