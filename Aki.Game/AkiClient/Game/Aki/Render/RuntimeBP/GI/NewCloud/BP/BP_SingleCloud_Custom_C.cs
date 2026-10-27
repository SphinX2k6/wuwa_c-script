using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D60 RID: 15712
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud_Custom.BP_SingleCloud_Custom_C")]
	[UnrealStructLayout(1856, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1856)]
	public class BP_SingleCloud_Custom_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026799 RID: 157593 RVA: 0x009760BC File Offset: 0x009742BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SingleCloud_Custom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud_Custom.BP_SingleCloud_Custom_C");
			}
			return BP_SingleCloud_Custom_C._ClassPtr;
		}

		// Token: 0x0602679A RID: 157594 RVA: 0x009760E0 File Offset: 0x009742E0
		public BP_SingleCloud_Custom_C() : this(BuiltinUtils.AllocNativeUObject(BP_SingleCloud_Custom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602679B RID: 157595 RVA: 0x00976108 File Offset: 0x00974308
		[NullableContext(1)]
		public BP_SingleCloud_Custom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SingleCloud_Custom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x0602679C RID: 157596 RVA: 0x0097613B File Offset: 0x0097433B
		// (set) Token: 0x0602679D RID: 157597 RVA: 0x0097614F File Offset: 0x0097434F
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x0602679E RID: 157598 RVA: 0x00976164 File Offset: 0x00974364
		// (set) Token: 0x0602679F RID: 157599 RVA: 0x00976178 File Offset: 0x00974378
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x060267A0 RID: 157600 RVA: 0x0097618D File Offset: 0x0097438D
		// (set) Token: 0x060267A1 RID: 157601 RVA: 0x0097619D File Offset: 0x0097439D
		public unsafe bool bTowardCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x060267A2 RID: 157602 RVA: 0x009761AE File Offset: 0x009743AE
		// (set) Token: 0x060267A3 RID: 157603 RVA: 0x009761BE File Offset: 0x009743BE
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x060267A4 RID: 157604 RVA: 0x009761CF File Offset: 0x009743CF
		// (set) Token: 0x060267A5 RID: 157605 RVA: 0x009761DF File Offset: 0x009743DF
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x060267A6 RID: 157606 RVA: 0x009761F0 File Offset: 0x009743F0
		// (set) Token: 0x060267A7 RID: 157607 RVA: 0x00976204 File Offset: 0x00974404
		public unsafe UStaticMesh CustomMesh_Y_Aix
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x060267A8 RID: 157608 RVA: 0x00976219 File Offset: 0x00974419
		// (set) Token: 0x060267A9 RID: 157609 RVA: 0x00976229 File Offset: 0x00974429
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x060267AA RID: 157610 RVA: 0x0097623A File Offset: 0x0097443A
		// (set) Token: 0x060267AB RID: 157611 RVA: 0x0097624A File Offset: 0x0097444A
		public unsafe bool bInverseFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x060267AC RID: 157612 RVA: 0x0097625B File Offset: 0x0097445B
		// (set) Token: 0x060267AD RID: 157613 RVA: 0x0097626B File Offset: 0x0097446B
		public unsafe bool bEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x060267AE RID: 157614 RVA: 0x0097627C File Offset: 0x0097447C
		// (set) Token: 0x060267AF RID: 157615 RVA: 0x0097628C File Offset: 0x0097448C
		public unsafe bool bTowardCameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x060267B0 RID: 157616 RVA: 0x0097629D File Offset: 0x0097449D
		// (set) Token: 0x060267B1 RID: 157617 RVA: 0x009762B1 File Offset: 0x009744B1
		public unsafe FVector boundCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x060267B2 RID: 157618 RVA: 0x009762C6 File Offset: 0x009744C6
		// (set) Token: 0x060267B3 RID: 157619 RVA: 0x009762DA File Offset: 0x009744DA
		public unsafe FVectorDouble CameraPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x060267B4 RID: 157620 RVA: 0x009762EF File Offset: 0x009744EF
		// (set) Token: 0x060267B5 RID: 157621 RVA: 0x00976303 File Offset: 0x00974503
		public unsafe FRotator CameraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x060267B6 RID: 157622 RVA: 0x00976318 File Offset: 0x00974518
		// (set) Token: 0x060267B7 RID: 157623 RVA: 0x00976328 File Offset: 0x00974528
		public unsafe double DistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x060267B8 RID: 157624 RVA: 0x00976339 File Offset: 0x00974539
		// (set) Token: 0x060267B9 RID: 157625 RVA: 0x0097634D File Offset: 0x0097454D
		public unsafe FRotator CloudRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x060267BA RID: 157626 RVA: 0x00976362 File Offset: 0x00974562
		// (set) Token: 0x060267BB RID: 157627 RVA: 0x00976376 File Offset: 0x00974576
		public unsafe FVectorDouble ToBoundDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x060267BC RID: 157628 RVA: 0x0097638B File Offset: 0x0097458B
		// (set) Token: 0x060267BD RID: 157629 RVA: 0x0097639F File Offset: 0x0097459F
		public unsafe UMaterialInstanceConstant CloudMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SingleCloud_Custom_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x060267BE RID: 157630 RVA: 0x009763B4 File Offset: 0x009745B4
		// (set) Token: 0x060267BF RID: 157631 RVA: 0x009763ED File Offset: 0x009745ED
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x060267C0 RID: 157632 RVA: 0x009763FC File Offset: 0x009745FC
		// (set) Token: 0x060267C1 RID: 157633 RVA: 0x00976435 File Offset: 0x00974635
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_19, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x060267C2 RID: 157634 RVA: 0x00976444 File Offset: 0x00974644
		// (set) Token: 0x060267C3 RID: 157635 RVA: 0x0097647D File Offset: 0x0097467D
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_SingleCloud_Custom_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x060267C4 RID: 157636 RVA: 0x0097648B File Offset: 0x0097468B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x060267C5 RID: 157637 RVA: 0x0097649F File Offset: 0x0097469F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x060267C6 RID: 157638 RVA: 0x009764B3 File Offset: 0x009746B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCloudRotation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UpdateCloudRotation_NativeFunctionPtr, null);
		}

		// Token: 0x060267C7 RID: 157639 RVA: 0x009764C7 File Offset: 0x009746C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDistanceFade()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UpdateDistanceFade_NativeFunctionPtr, null);
		}

		// Token: 0x060267C8 RID: 157640 RVA: 0x009764DB File Offset: 0x009746DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateCameraPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UpdateCameraPosition_NativeFunctionPtr, null);
		}

		// Token: 0x060267C9 RID: 157641 RVA: 0x009764F0 File Offset: 0x009746F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMaterialParams(UMaterialInstanceDynamic MID)
		{
			BP_SingleCloud_Custom_C.__UpdateMaterialParams_FunctionParams* ptr = stackalloc BP_SingleCloud_Custom_C.__UpdateMaterialParams_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_SingleCloud_Custom_C.__UpdateMaterialParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_Custom_C.__UpdateMaterialParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MID = ((MID != null) ? MID.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UpdateMaterialParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060267CA RID: 157642 RVA: 0x00976548 File Offset: 0x00974748
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060267CB RID: 157643 RVA: 0x0097655C File Offset: 0x0097475C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060267CC RID: 157644 RVA: 0x00976574 File Offset: 0x00974774
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SingleCloud_Custom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SingleCloud_Custom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_Custom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_Custom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060267CD RID: 157645 RVA: 0x009765BC File Offset: 0x009747BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SingleCloud_Custom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SingleCloud_Custom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_Custom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_Custom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267CE RID: 157646 RVA: 0x00976603 File Offset: 0x00974803
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060267CF RID: 157647 RVA: 0x00976617 File Offset: 0x00974817
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060267D0 RID: 157648 RVA: 0x0097662C File Offset: 0x0097482C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_Custom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060267D1 RID: 157649 RVA: 0x00976674 File Offset: 0x00974874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SingleCloud_Custom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SingleCloud_Custom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SingleCloud_Custom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060267D2 RID: 157650 RVA: 0x009766BB File Offset: 0x009748BB
		protected BP_SingleCloud_Custom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134DC RID: 79068
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_SingleCloud_Custom.BP_SingleCloud_Custom_C";

		// Token: 0x040134DD RID: 79069
		private static IntPtr _ClassPtr;

		// Token: 0x040134DE RID: 79070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134DF RID: 79071
		internal static int __PropertyOffset_1;

		// Token: 0x040134E0 RID: 79072
		internal static int __PropertyOffset_2;

		// Token: 0x040134E1 RID: 79073
		internal static int __PropertyOffset_3;

		// Token: 0x040134E2 RID: 79074
		internal static int __PropertyOffset_4;

		// Token: 0x040134E3 RID: 79075
		internal static int __PropertyOffset_5;

		// Token: 0x040134E4 RID: 79076
		internal static int __PropertyOffset_6;

		// Token: 0x040134E5 RID: 79077
		internal static int __PropertyOffset_7;

		// Token: 0x040134E6 RID: 79078
		internal static int __PropertyOffset_8;

		// Token: 0x040134E7 RID: 79079
		internal static int __PropertyOffset_9;

		// Token: 0x040134E8 RID: 79080
		internal static int __PropertyOffset_10;

		// Token: 0x040134E9 RID: 79081
		internal static int __PropertyOffset_11;

		// Token: 0x040134EA RID: 79082
		internal static int __PropertyOffset_12;

		// Token: 0x040134EB RID: 79083
		internal static int __PropertyOffset_13;

		// Token: 0x040134EC RID: 79084
		internal static int __PropertyOffset_14;

		// Token: 0x040134ED RID: 79085
		internal static int __PropertyOffset_15;

		// Token: 0x040134EE RID: 79086
		internal static int __PropertyOffset_16;

		// Token: 0x040134EF RID: 79087
		internal static int __PropertyOffset_17;

		// Token: 0x040134F0 RID: 79088
		internal static int __PropertyOffset_18;

		// Token: 0x040134F1 RID: 79089
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x040134F2 RID: 79090
		internal static int __PropertyOffset_19;

		// Token: 0x040134F3 RID: 79091
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x040134F4 RID: 79092
		internal static int __PropertyOffset_20;

		// Token: 0x040134F5 RID: 79093
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x040134F6 RID: 79094
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040134F7 RID: 79095
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x040134F8 RID: 79096
		private static IntPtr __UpdateCloudRotation_NativeFunctionPtr;

		// Token: 0x040134F9 RID: 79097
		private static IntPtr __UpdateDistanceFade_NativeFunctionPtr;

		// Token: 0x040134FA RID: 79098
		private static IntPtr __UpdateCameraPosition_NativeFunctionPtr;

		// Token: 0x040134FB RID: 79099
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x040134FC RID: 79100
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040134FD RID: 79101
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040134FE RID: 79102
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040134FF RID: 79103
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A11A RID: 41242
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __UpdateMaterialParams_FunctionParams
		{
			// Token: 0x04031C90 RID: 203920
			[FieldOffset(0)]
			public IntPtr MID;
		}

		// Token: 0x0200A11B RID: 41243
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C91 RID: 203921
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A11C RID: 41244
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C92 RID: 203922
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
