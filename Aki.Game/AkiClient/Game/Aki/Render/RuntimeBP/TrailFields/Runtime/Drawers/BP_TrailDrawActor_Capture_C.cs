using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB3 RID: 15027
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor_Capture.BP_TrailDrawActor_Capture_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class BP_TrailDrawActor_Capture_C : BP_TrailDrawActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602035D RID: 131933 RVA: 0x008CCB6C File Offset: 0x008CAD6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDrawActor_Capture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor_Capture.BP_TrailDrawActor_Capture_C");
			}
			return BP_TrailDrawActor_Capture_C._ClassPtr;
		}

		// Token: 0x0602035E RID: 131934 RVA: 0x008CCB90 File Offset: 0x008CAD90
		public BP_TrailDrawActor_Capture_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawActor_Capture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602035F RID: 131935 RVA: 0x008CCBB8 File Offset: 0x008CADB8
		[NullableContext(1)]
		public BP_TrailDrawActor_Capture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawActor_Capture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06020360 RID: 131936 RVA: 0x008CCBEB File Offset: 0x008CADEB
		// (set) Token: 0x06020361 RID: 131937 RVA: 0x008CCBFF File Offset: 0x008CADFF
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06020362 RID: 131938 RVA: 0x008CCC14 File Offset: 0x008CAE14
		// (set) Token: 0x06020363 RID: 131939 RVA: 0x008CCC24 File Offset: 0x008CAE24
		public unsafe float OrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06020364 RID: 131940 RVA: 0x008CCC35 File Offset: 0x008CAE35
		// (set) Token: 0x06020365 RID: 131941 RVA: 0x008CCC49 File Offset: 0x008CAE49
		public unsafe UTextureRenderTarget2D CaptureTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x06020366 RID: 131942 RVA: 0x008CCC5E File Offset: 0x008CAE5E
		// (set) Token: 0x06020367 RID: 131943 RVA: 0x008CCC72 File Offset: 0x008CAE72
		public unsafe UMaterialInstanceDynamic MirrorMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x06020368 RID: 131944 RVA: 0x008CCC88 File Offset: 0x008CAE88
		// (set) Token: 0x06020369 RID: 131945 RVA: 0x008CCCC1 File Offset: 0x008CAEC1
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> Object_Types
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._Object_Types) == null)
				{
					result = (this._Object_Types = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Object_Types.CopyAssign(value);
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0602036A RID: 131946 RVA: 0x008CCCCF File Offset: 0x008CAECF
		// (set) Token: 0x0602036B RID: 131947 RVA: 0x008CCCDF File Offset: 0x008CAEDF
		public unsafe float PixelWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0602036C RID: 131948 RVA: 0x008CCCF0 File Offset: 0x008CAEF0
		// (set) Token: 0x0602036D RID: 131949 RVA: 0x008CCD04 File Offset: 0x008CAF04
		public unsafe AActor Father
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0602036E RID: 131950 RVA: 0x008CCD19 File Offset: 0x008CAF19
		// (set) Token: 0x0602036F RID: 131951 RVA: 0x008CCD2D File Offset: 0x008CAF2D
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06020370 RID: 131952 RVA: 0x008CCD42 File Offset: 0x008CAF42
		// (set) Token: 0x06020371 RID: 131953 RVA: 0x008CCD52 File Offset: 0x008CAF52
		public unsafe bool UseBoundOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x06020372 RID: 131954 RVA: 0x008CCD63 File Offset: 0x008CAF63
		// (set) Token: 0x06020373 RID: 131955 RVA: 0x008CCD77 File Offset: 0x008CAF77
		public unsafe UTextureRenderTarget2D RT1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06020374 RID: 131956 RVA: 0x008CCD8C File Offset: 0x008CAF8C
		// (set) Token: 0x06020375 RID: 131957 RVA: 0x008CCDA0 File Offset: 0x008CAFA0
		public unsafe UTextureRenderTarget2D RT2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawActor_Capture_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x06020376 RID: 131958 RVA: 0x008CCDB5 File Offset: 0x008CAFB5
		// (set) Token: 0x06020377 RID: 131959 RVA: 0x008CCDC5 File Offset: 0x008CAFC5
		public unsafe float ZOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06020378 RID: 131960 RVA: 0x008CCDD6 File Offset: 0x008CAFD6
		// (set) Token: 0x06020379 RID: 131961 RVA: 0x008CCDE6 File Offset: 0x008CAFE6
		public unsafe bool UpdateEveryTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0602037A RID: 131962 RVA: 0x008CCDF7 File Offset: 0x008CAFF7
		// (set) Token: 0x0602037B RID: 131963 RVA: 0x008CCE07 File Offset: 0x008CB007
		public unsafe float RayUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0602037C RID: 131964 RVA: 0x008CCE18 File Offset: 0x008CB018
		// (set) Token: 0x0602037D RID: 131965 RVA: 0x008CCE28 File Offset: 0x008CB028
		public unsafe float RayDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawActor_Capture_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0602037E RID: 131966 RVA: 0x008CCE39 File Offset: 0x008CB039
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602037F RID: 131967 RVA: 0x008CCE4D File Offset: 0x008CB04D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020380 RID: 131968 RVA: 0x008CCE62 File Offset: 0x008CB062
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020381 RID: 131969 RVA: 0x008CCE76 File Offset: 0x008CB076
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x008CCE8C File Offset: 0x008CB08C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawActor_Capture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020383 RID: 131971 RVA: 0x008CCED4 File Offset: 0x008CB0D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawActor_Capture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawActor_Capture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawActor_Capture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020384 RID: 131972 RVA: 0x008CCF1B File Offset: 0x008CB11B
		protected BP_TrailDrawActor_Capture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F922 RID: 63778
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawActor_Capture.BP_TrailDrawActor_Capture_C";

		// Token: 0x0400F923 RID: 63779
		private static IntPtr _ClassPtr;

		// Token: 0x0400F924 RID: 63780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F925 RID: 63781
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F926 RID: 63782
		internal new static int __PropertyOffset_2;

		// Token: 0x0400F927 RID: 63783
		internal static int __PropertyOffset_3;

		// Token: 0x0400F928 RID: 63784
		internal static int __PropertyOffset_4;

		// Token: 0x0400F929 RID: 63785
		internal static int __PropertyOffset_5;

		// Token: 0x0400F92A RID: 63786
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Object_Types;

		// Token: 0x0400F92B RID: 63787
		internal static int __PropertyOffset_6;

		// Token: 0x0400F92C RID: 63788
		internal static int __PropertyOffset_7;

		// Token: 0x0400F92D RID: 63789
		internal static int __PropertyOffset_8;

		// Token: 0x0400F92E RID: 63790
		internal static int __PropertyOffset_9;

		// Token: 0x0400F92F RID: 63791
		internal static int __PropertyOffset_10;

		// Token: 0x0400F930 RID: 63792
		internal static int __PropertyOffset_11;

		// Token: 0x0400F931 RID: 63793
		internal static int __PropertyOffset_12;

		// Token: 0x0400F932 RID: 63794
		internal static int __PropertyOffset_13;

		// Token: 0x0400F933 RID: 63795
		internal static int __PropertyOffset_14;

		// Token: 0x0400F934 RID: 63796
		internal static int __PropertyOffset_15;

		// Token: 0x0400F935 RID: 63797
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F936 RID: 63798
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F937 RID: 63799
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B93 RID: 39827
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311E6 RID: 201190
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
