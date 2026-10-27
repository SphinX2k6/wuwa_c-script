using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneCapture_3To2
{
	// Token: 0x02003BB8 RID: 15288
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1577)]
	public class BP_SceneCapture_3To2_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06022238 RID: 139832 RVA: 0x00900AAC File Offset: 0x008FECAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneCapture_3To2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C");
			}
			return BP_SceneCapture_3To2_C._ClassPtr;
		}

		// Token: 0x06022239 RID: 139833 RVA: 0x00900AD0 File Offset: 0x008FECD0
		public BP_SceneCapture_3To2_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_3To2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602223A RID: 139834 RVA: 0x00900AF8 File Offset: 0x008FECF8
		[NullableContext(1)]
		public BP_SceneCapture_3To2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneCapture_3To2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0602223B RID: 139835 RVA: 0x00900B2B File Offset: 0x008FED2B
		// (set) Token: 0x0602223C RID: 139836 RVA: 0x00900B3F File Offset: 0x008FED3F
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0602223D RID: 139837 RVA: 0x00900B54 File Offset: 0x008FED54
		// (set) Token: 0x0602223E RID: 139838 RVA: 0x00900B68 File Offset: 0x008FED68
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0602223F RID: 139839 RVA: 0x00900B80 File Offset: 0x008FED80
		// (set) Token: 0x06022240 RID: 139840 RVA: 0x00900BB9 File Offset: 0x008FEDB9
		[Nullable(1)]
		public TArray<AActor> HiddenActor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HiddenActor) == null)
				{
					result = (this._HiddenActor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HiddenActor.CopyAssign(value);
			}
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x06022241 RID: 139841 RVA: 0x00900BC8 File Offset: 0x008FEDC8
		// (set) Token: 0x06022242 RID: 139842 RVA: 0x00900C01 File Offset: 0x008FEE01
		[Nullable(1)]
		public TArray<AActor> ActorPosition
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorPosition) == null)
				{
					result = (this._ActorPosition = new TArray<AActor>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorPosition.CopyAssign(value);
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x06022243 RID: 139843 RVA: 0x00900C0F File Offset: 0x008FEE0F
		// (set) Token: 0x06022244 RID: 139844 RVA: 0x00900C1F File Offset: 0x008FEE1F
		public unsafe bool Capture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x06022245 RID: 139845 RVA: 0x00900C30 File Offset: 0x008FEE30
		// (set) Token: 0x06022246 RID: 139846 RVA: 0x00900C44 File Offset: 0x008FEE44
		public unsafe AKuroPostProcessVolume PPV
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x06022247 RID: 139847 RVA: 0x00900C59 File Offset: 0x008FEE59
		// (set) Token: 0x06022248 RID: 139848 RVA: 0x00900C6E File Offset: 0x008FEE6E
		[Nullable(1)]
		public TSoftObjectPtr<UTextureRenderTarget2D> RTSoft
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UTextureRenderTarget2D>(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_7, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_7, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x06022249 RID: 139849 RVA: 0x00900C93 File Offset: 0x008FEE93
		// (set) Token: 0x0602224A RID: 139850 RVA: 0x00900CA7 File Offset: 0x008FEEA7
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneCapture_3To2_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0602224B RID: 139851 RVA: 0x00900CBC File Offset: 0x008FEEBC
		// (set) Token: 0x0602224C RID: 139852 RVA: 0x00900CCC File Offset: 0x008FEECC
		public unsafe bool First
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneCapture_3To2_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602224D RID: 139853 RVA: 0x00900CE0 File Offset: 0x008FEEE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0602224E RID: 139854 RVA: 0x00900D30 File Offset: 0x008FEF30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0602224F RID: 139855 RVA: 0x00900D7F File Offset: 0x008FEF7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableToonDepth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__DisableToonDepth_NativeFunctionPtr, null);
		}

		// Token: 0x06022250 RID: 139856 RVA: 0x00900D93 File Offset: 0x008FEF93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableToonDepth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EnableToonDepth_NativeFunctionPtr, null);
		}

		// Token: 0x06022251 RID: 139857 RVA: 0x00900DA7 File Offset: 0x008FEFA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AllowOcclusionQueries()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__AllowOcclusionQueries_NativeFunctionPtr, null);
		}

		// Token: 0x06022252 RID: 139858 RVA: 0x00900DBB File Offset: 0x008FEFBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x06022253 RID: 139859 RVA: 0x00900DD0 File Offset: 0x008FEFD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetEnablePPV(float Enable3To2Toggle)
		{
			BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__SetEnablePPV_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__SetEnablePPV_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable3To2Toggle = Enable3To2Toggle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__SetEnablePPV_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022254 RID: 139860 RVA: 0x00900E16 File Offset: 0x008FF016
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CaptureScene_Running()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__CaptureScene_Running_NativeFunctionPtr, null);
		}

		// Token: 0x06022255 RID: 139861 RVA: 0x00900E2A File Offset: 0x008FF02A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x00900E3E File Offset: 0x008FF03E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06022257 RID: 139863 RVA: 0x00900E52 File Offset: 0x008FF052
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x06022258 RID: 139864 RVA: 0x00900E66 File Offset: 0x008FF066
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x06022259 RID: 139865 RVA: 0x00900E7A File Offset: 0x008FF07A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0602225A RID: 139866 RVA: 0x00900E90 File Offset: 0x008FF090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneCapture_3To2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602225B RID: 139867 RVA: 0x00900ED8 File Offset: 0x008FF0D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneCapture_3To2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneCapture_3To2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneCapture_3To2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602225C RID: 139868 RVA: 0x00900F1F File Offset: 0x008FF11F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602225D RID: 139869 RVA: 0x00900F33 File Offset: 0x008FF133
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602225E RID: 139870 RVA: 0x00900F48 File Offset: 0x008FF148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602225F RID: 139871 RVA: 0x00900F5C File Offset: 0x008FF15C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneCapture_3To2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022260 RID: 139872 RVA: 0x00900F71 File Offset: 0x008FF171
		protected BP_SceneCapture_3To2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B8A RID: 68490
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneCapture_3To2/BP_SceneCapture_3To2.BP_SceneCapture_3To2_C";

		// Token: 0x04010B8B RID: 68491
		private static IntPtr _ClassPtr;

		// Token: 0x04010B8C RID: 68492
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B8D RID: 68493
		internal static int __PropertyOffset_1;

		// Token: 0x04010B8E RID: 68494
		internal static int __PropertyOffset_2;

		// Token: 0x04010B8F RID: 68495
		internal static int __PropertyOffset_3;

		// Token: 0x04010B90 RID: 68496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActor;

		// Token: 0x04010B91 RID: 68497
		internal static int __PropertyOffset_4;

		// Token: 0x04010B92 RID: 68498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorPosition;

		// Token: 0x04010B93 RID: 68499
		internal static int __PropertyOffset_5;

		// Token: 0x04010B94 RID: 68500
		internal static int __PropertyOffset_6;

		// Token: 0x04010B95 RID: 68501
		internal static int __PropertyOffset_7;

		// Token: 0x04010B96 RID: 68502
		internal static int __PropertyOffset_8;

		// Token: 0x04010B97 RID: 68503
		internal static int __PropertyOffset_9;

		// Token: 0x04010B98 RID: 68504
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04010B99 RID: 68505
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04010B9A RID: 68506
		private static IntPtr __DisableToonDepth_NativeFunctionPtr;

		// Token: 0x04010B9B RID: 68507
		private static IntPtr __EnableToonDepth_NativeFunctionPtr;

		// Token: 0x04010B9C RID: 68508
		private static IntPtr __AllowOcclusionQueries_NativeFunctionPtr;

		// Token: 0x04010B9D RID: 68509
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x04010B9E RID: 68510
		private static IntPtr __SetEnablePPV_NativeFunctionPtr;

		// Token: 0x04010B9F RID: 68511
		private static IntPtr __CaptureScene_Running_NativeFunctionPtr;

		// Token: 0x04010BA0 RID: 68512
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04010BA1 RID: 68513
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04010BA2 RID: 68514
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04010BA3 RID: 68515
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04010BA4 RID: 68516
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04010BA5 RID: 68517
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010BA6 RID: 68518
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04010BA7 RID: 68519
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009D45 RID: 40261
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x040314B0 RID: 201904
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02009D46 RID: 40262
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x040314B1 RID: 201905
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009D47 RID: 40263
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetEnablePPV_FunctionParams
		{
			// Token: 0x040314B2 RID: 201906
			[FieldOffset(0)]
			public float Enable3To2Toggle;
		}

		// Token: 0x02009D48 RID: 40264
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040314B3 RID: 201907
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
