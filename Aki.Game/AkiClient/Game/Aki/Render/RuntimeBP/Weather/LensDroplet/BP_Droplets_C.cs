using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.LensDroplet
{
	// Token: 0x02003A7A RID: 14970
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_Droplets.BP_Droplets_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_Droplets_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB70 RID: 129904 RVA: 0x008C0A39 File Offset: 0x008BEC39
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Droplets_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_Droplets.BP_Droplets_C");
			}
			return BP_Droplets_C._ClassPtr;
		}

		// Token: 0x0601FB71 RID: 129905 RVA: 0x008C0A60 File Offset: 0x008BEC60
		public BP_Droplets_C() : this(BuiltinUtils.AllocNativeUObject(BP_Droplets_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB72 RID: 129906 RVA: 0x008C0A88 File Offset: 0x008BEC88
		[NullableContext(1)]
		public BP_Droplets_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Droplets_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0601FB73 RID: 129907 RVA: 0x008C0ABB File Offset: 0x008BECBB
		// (set) Token: 0x0601FB74 RID: 129908 RVA: 0x008C0ACF File Offset: 0x008BECCF
		public unsafe UProceduralMeshComponent Droplets
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x0601FB75 RID: 129909 RVA: 0x008C0AE4 File Offset: 0x008BECE4
		// (set) Token: 0x0601FB76 RID: 129910 RVA: 0x008C0AF8 File Offset: 0x008BECF8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x0601FB77 RID: 129911 RVA: 0x008C0B0D File Offset: 0x008BED0D
		// (set) Token: 0x0601FB78 RID: 129912 RVA: 0x008C0B21 File Offset: 0x008BED21
		public unsafe UMaterialInstanceDynamic DropletDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x0601FB79 RID: 129913 RVA: 0x008C0B36 File Offset: 0x008BED36
		// (set) Token: 0x0601FB7A RID: 129914 RVA: 0x008C0B46 File Offset: 0x008BED46
		public unsafe float time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x0601FB7B RID: 129915 RVA: 0x008C0B57 File Offset: 0x008BED57
		// (set) Token: 0x0601FB7C RID: 129916 RVA: 0x008C0B67 File Offset: 0x008BED67
		public unsafe bool Should_Spawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x0601FB7D RID: 129917 RVA: 0x008C0B78 File Offset: 0x008BED78
		// (set) Token: 0x0601FB7E RID: 129918 RVA: 0x008C0B8C File Offset: 0x008BED8C
		public unsafe FRandomStream RandomStream
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x0601FB7F RID: 129919 RVA: 0x008C0BA1 File Offset: 0x008BEDA1
		// (set) Token: 0x0601FB80 RID: 129920 RVA: 0x008C0BB5 File Offset: 0x008BEDB5
		public unsafe FVector RandPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0601FB81 RID: 129921 RVA: 0x008C0BCC File Offset: 0x008BEDCC
		// (set) Token: 0x0601FB82 RID: 129922 RVA: 0x008C0C05 File Offset: 0x008BEE05
		[Nullable(1)]
		public TArray<FVector> VertexBuffer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VertexBuffer) == null)
				{
					result = (this._VertexBuffer = new TArray<FVector>(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VertexBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0601FB83 RID: 129923 RVA: 0x008C0C14 File Offset: 0x008BEE14
		// (set) Token: 0x0601FB84 RID: 129924 RVA: 0x008C0C4D File Offset: 0x008BEE4D
		[Nullable(1)]
		public TArray<FVector2D> UV0Buffer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UV0Buffer) == null)
				{
					result = (this._UV0Buffer = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UV0Buffer.CopyAssign(value);
			}
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0601FB85 RID: 129925 RVA: 0x008C0C5C File Offset: 0x008BEE5C
		// (set) Token: 0x0601FB86 RID: 129926 RVA: 0x008C0C95 File Offset: 0x008BEE95
		[Nullable(1)]
		public TArray<FLinearColor> VertexColorBuffer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._VertexColorBuffer) == null)
				{
					result = (this._VertexColorBuffer = new TArray<FLinearColor>(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VertexColorBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0601FB87 RID: 129927 RVA: 0x008C0CA3 File Offset: 0x008BEEA3
		// (set) Token: 0x0601FB88 RID: 129928 RVA: 0x008C0CB3 File Offset: 0x008BEEB3
		public unsafe int Int
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0601FB89 RID: 129929 RVA: 0x008C0CC4 File Offset: 0x008BEEC4
		// (set) Token: 0x0601FB8A RID: 129930 RVA: 0x008C0CD8 File Offset: 0x008BEED8
		public unsafe FVectorDouble CurrCamPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0601FB8B RID: 129931 RVA: 0x008C0CED File Offset: 0x008BEEED
		// (set) Token: 0x0601FB8C RID: 129932 RVA: 0x008C0D01 File Offset: 0x008BEF01
		public unsafe FVectorDouble PrezCamPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0601FB8D RID: 129933 RVA: 0x008C0D16 File Offset: 0x008BEF16
		// (set) Token: 0x0601FB8E RID: 129934 RVA: 0x008C0D2A File Offset: 0x008BEF2A
		public unsafe FVector CurrCamVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0601FB8F RID: 129935 RVA: 0x008C0D3F File Offset: 0x008BEF3F
		// (set) Token: 0x0601FB90 RID: 129936 RVA: 0x008C0D4F File Offset: 0x008BEF4F
		public unsafe bool IsEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0601FB91 RID: 129937 RVA: 0x008C0D60 File Offset: 0x008BEF60
		// (set) Token: 0x0601FB92 RID: 129938 RVA: 0x008C0D70 File Offset: 0x008BEF70
		public unsafe float DropletIntensityMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0601FB93 RID: 129939 RVA: 0x008C0D81 File Offset: 0x008BEF81
		// (set) Token: 0x0601FB94 RID: 129940 RVA: 0x008C0D91 File Offset: 0x008BEF91
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0601FB95 RID: 129941 RVA: 0x008C0DA2 File Offset: 0x008BEFA2
		// (set) Token: 0x0601FB96 RID: 129942 RVA: 0x008C0DB2 File Offset: 0x008BEFB2
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0601FB97 RID: 129943 RVA: 0x008C0DC3 File Offset: 0x008BEFC3
		// (set) Token: 0x0601FB98 RID: 129944 RVA: 0x008C0DD3 File Offset: 0x008BEFD3
		public unsafe float RainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0601FB99 RID: 129945 RVA: 0x008C0DE4 File Offset: 0x008BEFE4
		// (set) Token: 0x0601FB9A RID: 129946 RVA: 0x008C0DF8 File Offset: 0x008BEFF8
		public unsafe UMaterialInterface DropletMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0601FB9B RID: 129947 RVA: 0x008C0E0D File Offset: 0x008BF00D
		// (set) Token: 0x0601FB9C RID: 129948 RVA: 0x008C0E21 File Offset: 0x008BF021
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRainType> RainType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_21);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0601FB9D RID: 129949 RVA: 0x008C0E36 File Offset: 0x008BF036
		// (set) Token: 0x0601FB9E RID: 129950 RVA: 0x008C0E4A File Offset: 0x008BF04A
		public unsafe BP_LensDropletManager_C DropletManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_LensDropletManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Droplets_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0601FB9F RID: 129951 RVA: 0x008C0E5F File Offset: 0x008BF05F
		// (set) Token: 0x0601FBA0 RID: 129952 RVA: 0x008C0E6F File Offset: 0x008BF06F
		public unsafe float Boost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0601FBA1 RID: 129953 RVA: 0x008C0E80 File Offset: 0x008BF080
		// (set) Token: 0x0601FBA2 RID: 129954 RVA: 0x008C0E90 File Offset: 0x008BF090
		public unsafe float RandomRainDropSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Droplets_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x0601FBA3 RID: 129955 RVA: 0x008C0EA1 File Offset: 0x008BF0A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__UpdateParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBA4 RID: 129956 RVA: 0x008C0EB5 File Offset: 0x008BF0B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MakeOneDroplet()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__MakeOneDroplet_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBA5 RID: 129957 RVA: 0x008C0EC9 File Offset: 0x008BF0C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBA6 RID: 129958 RVA: 0x008C0EDD File Offset: 0x008BF0DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Droplets_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FBA7 RID: 129959 RVA: 0x008C0EF2 File Offset: 0x008BF0F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBA8 RID: 129960 RVA: 0x008C0F06 File Offset: 0x008BF106
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Droplets_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FBA9 RID: 129961 RVA: 0x008C0F1C File Offset: 0x008BF11C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Droplets_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Droplets_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Droplets_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Droplets_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBAA RID: 129962 RVA: 0x008C0F64 File Offset: 0x008BF164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Droplets_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Droplets_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Droplets_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Droplets_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Droplets_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FBAB RID: 129963 RVA: 0x008C0FAC File Offset: 0x008BF1AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Droplets_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Droplets_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Droplets_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Droplets_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Droplets_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBAC RID: 129964 RVA: 0x008C0FF4 File Offset: 0x008BF1F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Droplets_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Droplets_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Droplets_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Droplets_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Droplets_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FBAD RID: 129965 RVA: 0x008C103B File Offset: 0x008BF23B
		protected BP_Droplets_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F468 RID: 62568
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_Droplets.BP_Droplets_C";

		// Token: 0x0400F469 RID: 62569
		private static IntPtr _ClassPtr;

		// Token: 0x0400F46A RID: 62570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F46B RID: 62571
		internal static int __PropertyOffset_1;

		// Token: 0x0400F46C RID: 62572
		internal static int __PropertyOffset_2;

		// Token: 0x0400F46D RID: 62573
		internal static int __PropertyOffset_3;

		// Token: 0x0400F46E RID: 62574
		internal static int __PropertyOffset_4;

		// Token: 0x0400F46F RID: 62575
		internal static int __PropertyOffset_5;

		// Token: 0x0400F470 RID: 62576
		internal static int __PropertyOffset_6;

		// Token: 0x0400F471 RID: 62577
		internal static int __PropertyOffset_7;

		// Token: 0x0400F472 RID: 62578
		internal static int __PropertyOffset_8;

		// Token: 0x0400F473 RID: 62579
		private TArray<FVector> _VertexBuffer;

		// Token: 0x0400F474 RID: 62580
		internal static int __PropertyOffset_9;

		// Token: 0x0400F475 RID: 62581
		private TArray<FVector2D> _UV0Buffer;

		// Token: 0x0400F476 RID: 62582
		internal static int __PropertyOffset_10;

		// Token: 0x0400F477 RID: 62583
		private TArray<FLinearColor> _VertexColorBuffer;

		// Token: 0x0400F478 RID: 62584
		internal static int __PropertyOffset_11;

		// Token: 0x0400F479 RID: 62585
		internal static int __PropertyOffset_12;

		// Token: 0x0400F47A RID: 62586
		internal static int __PropertyOffset_13;

		// Token: 0x0400F47B RID: 62587
		internal static int __PropertyOffset_14;

		// Token: 0x0400F47C RID: 62588
		internal static int __PropertyOffset_15;

		// Token: 0x0400F47D RID: 62589
		internal static int __PropertyOffset_16;

		// Token: 0x0400F47E RID: 62590
		internal static int __PropertyOffset_17;

		// Token: 0x0400F47F RID: 62591
		internal static int __PropertyOffset_18;

		// Token: 0x0400F480 RID: 62592
		internal static int __PropertyOffset_19;

		// Token: 0x0400F481 RID: 62593
		internal static int __PropertyOffset_20;

		// Token: 0x0400F482 RID: 62594
		internal static int __PropertyOffset_21;

		// Token: 0x0400F483 RID: 62595
		internal static int __PropertyOffset_22;

		// Token: 0x0400F484 RID: 62596
		internal static int __PropertyOffset_23;

		// Token: 0x0400F485 RID: 62597
		internal static int __PropertyOffset_24;

		// Token: 0x0400F486 RID: 62598
		private static IntPtr __UpdateParameters_NativeFunctionPtr;

		// Token: 0x0400F487 RID: 62599
		private static IntPtr __MakeOneDroplet_NativeFunctionPtr;

		// Token: 0x0400F488 RID: 62600
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F489 RID: 62601
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F48A RID: 62602
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F48B RID: 62603
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009B41 RID: 39745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031156 RID: 201046
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B42 RID: 39746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031157 RID: 201047
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
