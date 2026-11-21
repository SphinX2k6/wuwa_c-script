using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Spindrift
{
	// Token: 0x020030DA RID: 12506
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_FX_Sprindrift_2_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E2D5 RID: 123605 RVA: 0x0090D0C3 File Offset: 0x0090B2C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FX_Sprindrift_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C");
			}
			return BP_FX_Sprindrift_2_C._ClassPtr;
		}

		// Token: 0x0601E2D6 RID: 123606 RVA: 0x0090D0E8 File Offset: 0x0090B2E8
		public BP_FX_Sprindrift_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrift_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E2D7 RID: 123607 RVA: 0x0090D110 File Offset: 0x0090B310
		[NullableContext(1)]
		public BP_FX_Sprindrift_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrift_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003256 RID: 12886
		// (get) Token: 0x0601E2D8 RID: 123608 RVA: 0x0090D143 File Offset: 0x0090B343
		// (set) Token: 0x0601E2D9 RID: 123609 RVA: 0x0090D157 File Offset: 0x0090B357
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_Arrow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_Arrow, value);
			}
		}

		// Token: 0x17003257 RID: 12887
		// (get) Token: 0x0601E2DA RID: 123610 RVA: 0x0090D16C File Offset: 0x0090B36C
		// (set) Token: 0x0601E2DB RID: 123611 RVA: 0x0090D180 File Offset: 0x0090B380
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_Niagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_Niagara, value);
			}
		}

		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0601E2DC RID: 123612 RVA: 0x0090D195 File Offset: 0x0090B395
		// (set) Token: 0x0601E2DD RID: 123613 RVA: 0x0090D1A9 File Offset: 0x0090B3A9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0601E2DE RID: 123614 RVA: 0x0090D1BE File Offset: 0x0090B3BE
		// (set) Token: 0x0601E2DF RID: 123615 RVA: 0x0090D1D2 File Offset: 0x0090B3D2
		public unsafe UNiagaraSystem 粒子特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_粒子特效);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_粒子特效, value);
			}
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0601E2E0 RID: 123616 RVA: 0x0090D1E7 File Offset: 0x0090B3E7
		// (set) Token: 0x0601E2E1 RID: 123617 RVA: 0x0090D1F7 File Offset: 0x0090B3F7
		public unsafe int 全局时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_全局时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_全局时间) = value;
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0601E2E2 RID: 123618 RVA: 0x0090D208 File Offset: 0x0090B408
		// (set) Token: 0x0601E2E3 RID: 123619 RVA: 0x0090D218 File Offset: 0x0090B418
		public unsafe int 浪花数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花数量) = value;
			}
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0601E2E4 RID: 123620 RVA: 0x0090D229 File Offset: 0x0090B429
		// (set) Token: 0x0601E2E5 RID: 123621 RVA: 0x0090D239 File Offset: 0x0090B439
		public unsafe float 浪花范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花范围) = value;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0601E2E6 RID: 123622 RVA: 0x0090D24A File Offset: 0x0090B44A
		// (set) Token: 0x0601E2E7 RID: 123623 RVA: 0x0090D25E File Offset: 0x0090B45E
		public unsafe FLinearColor 浪花颜色_白天_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花颜色_白天_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花颜色_白天_) = value;
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0601E2E8 RID: 123624 RVA: 0x0090D273 File Offset: 0x0090B473
		// (set) Token: 0x0601E2E9 RID: 123625 RVA: 0x0090D287 File Offset: 0x0090B487
		public unsafe FLinearColor 浪花颜色_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花颜色_夜晚_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花颜色_夜晚_) = value;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0601E2EA RID: 123626 RVA: 0x0090D29C File Offset: 0x0090B49C
		// (set) Token: 0x0601E2EB RID: 123627 RVA: 0x0090D2AC File Offset: 0x0090B4AC
		public unsafe float 浪花周期
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花周期);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_浪花周期) = value;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0601E2EC RID: 123628 RVA: 0x0090D2BD File Offset: 0x0090B4BD
		// (set) Token: 0x0601E2ED RID: 123629 RVA: 0x0090D2D1 File Offset: 0x0090B4D1
		public unsafe FVector2D 周期偏移_白天_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_周期偏移_白天_夜晚_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_周期偏移_白天_夜晚_) = value;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0601E2EE RID: 123630 RVA: 0x0090D2E6 File Offset: 0x0090B4E6
		// (set) Token: 0x0601E2EF RID: 123631 RVA: 0x0090D2F6 File Offset: 0x0090B4F6
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_Activate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_Activate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0601E2F0 RID: 123632 RVA: 0x0090D307 File Offset: 0x0090B507
		// (set) Token: 0x0601E2F1 RID: 123633 RVA: 0x0090D317 File Offset: 0x0090B517
		public unsafe bool IsDayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_IsDayTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_IsDayTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0601E2F2 RID: 123634 RVA: 0x0090D328 File Offset: 0x0090B528
		// (set) Token: 0x0601E2F3 RID: 123635 RVA: 0x0090D33C File Offset: 0x0090B53C
		public unsafe UStaticMeshComponent CaptureMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_CaptureMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_CaptureMeshComponent, value);
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0601E2F4 RID: 123636 RVA: 0x0090D351 File Offset: 0x0090B551
		// (set) Token: 0x0601E2F5 RID: 123637 RVA: 0x0090D365 File Offset: 0x0090B565
		public unsafe UTextureRenderTarget2D RTCaptureWaveLine
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_RTCaptureWaveLine);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_RTCaptureWaveLine, value);
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0601E2F6 RID: 123638 RVA: 0x0090D37A File Offset: 0x0090B57A
		// (set) Token: 0x0601E2F7 RID: 123639 RVA: 0x0090D38A File Offset: 0x0090B58A
		public unsafe float ActivateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_ActivateTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_ActivateTime) = value;
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0601E2F8 RID: 123640 RVA: 0x0090D39B File Offset: 0x0090B59B
		// (set) Token: 0x0601E2F9 RID: 123641 RVA: 0x0090D3AF File Offset: 0x0090B5AF
		public unsafe USceneCaptureComponent2D SceneCaptureComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_SceneCaptureComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_SceneCaptureComponent, value);
			}
		}

		// Token: 0x0601E2FA RID: 123642 RVA: 0x0090D3C4 File Offset: 0x0090B5C4
		[SkipLocalsInit]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x0601E2FB RID: 123643 RVA: 0x0090D413 File Offset: 0x0090B613
		[SkipLocalsInit]
		public virtual void CaptureWaveLine()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__CaptureWaveLine_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2FC RID: 123644 RVA: 0x0090D428 File Offset: 0x0090B628
		[SkipLocalsInit]
		public unsafe virtual void DayAndNight(bool IsDayTime)
		{
			BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__DayAndNight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDayTime = IsDayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__DayAndNight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E2FD RID: 123645 RVA: 0x0090D471 File Offset: 0x0090B671
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2FE RID: 123646 RVA: 0x0090D485 File Offset: 0x0090B685
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E2FF RID: 123647 RVA: 0x0090D49C File Offset: 0x0090B69C
		[SkipLocalsInit]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E300 RID: 123648 RVA: 0x0090D4E2 File Offset: 0x0090B6E2
		[SkipLocalsInit]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601E301 RID: 123649 RVA: 0x0090D4F6 File Offset: 0x0090B6F6
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E302 RID: 123650 RVA: 0x0090D50A File Offset: 0x0090B70A
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E303 RID: 123651 RVA: 0x0090D520 File Offset: 0x0090B720
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E304 RID: 123652 RVA: 0x0090D568 File Offset: 0x0090B768
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E305 RID: 123653 RVA: 0x0090D5B0 File Offset: 0x0090B7B0
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E306 RID: 123654 RVA: 0x0090D5F8 File Offset: 0x0090B7F8
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E307 RID: 123655 RVA: 0x0090D63E File Offset: 0x0090B83E
		protected BP_FX_Sprindrift_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF6E RID: 65390
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C";

		// Token: 0x0400FF6F RID: 65391
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF70 RID: 65392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF71 RID: 65393
		internal static int __PropertyOffset_Arrow;

		// Token: 0x0400FF72 RID: 65394
		internal static int __PropertyOffset_Niagara;

		// Token: 0x0400FF73 RID: 65395
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FF74 RID: 65396
		internal static int __PropertyOffset_粒子特效;

		// Token: 0x0400FF75 RID: 65397
		internal static int __PropertyOffset_全局时间;

		// Token: 0x0400FF76 RID: 65398
		internal static int __PropertyOffset_浪花数量;

		// Token: 0x0400FF77 RID: 65399
		internal static int __PropertyOffset_浪花范围;

		// Token: 0x0400FF78 RID: 65400
		internal static int __PropertyOffset_浪花颜色_白天_;

		// Token: 0x0400FF79 RID: 65401
		internal static int __PropertyOffset_浪花颜色_夜晚_;

		// Token: 0x0400FF7A RID: 65402
		internal static int __PropertyOffset_浪花周期;

		// Token: 0x0400FF7B RID: 65403
		internal static int __PropertyOffset_周期偏移_白天_夜晚_;

		// Token: 0x0400FF7C RID: 65404
		internal static int __PropertyOffset_Activate;

		// Token: 0x0400FF7D RID: 65405
		internal static int __PropertyOffset_IsDayTime;

		// Token: 0x0400FF7E RID: 65406
		internal static int __PropertyOffset_CaptureMeshComponent;

		// Token: 0x0400FF7F RID: 65407
		internal static int __PropertyOffset_RTCaptureWaveLine;

		// Token: 0x0400FF80 RID: 65408
		internal static int __PropertyOffset_ActivateTime;

		// Token: 0x0400FF81 RID: 65409
		internal static int __PropertyOffset_SceneCaptureComponent;

		// Token: 0x0400FF82 RID: 65410
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x0400FF83 RID: 65411
		private static IntPtr __CaptureWaveLine_NativeFunctionPtr;

		// Token: 0x0400FF84 RID: 65412
		private static IntPtr __DayAndNight_NativeFunctionPtr;

		// Token: 0x0400FF85 RID: 65413
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF86 RID: 65414
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x0400FF87 RID: 65415
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x0400FF88 RID: 65416
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FF89 RID: 65417
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FF8A RID: 65418
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008E32 RID: 36402
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x0402CA73 RID: 182899
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008E33 RID: 36403
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DayAndNight_FunctionParams
		{
			// Token: 0x0402CA74 RID: 182900
			[FieldOffset(0)]
			public bool IsDayTime;
		}

		// Token: 0x02008E34 RID: 36404
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x0402CA75 RID: 182901
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008E35 RID: 36405
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA76 RID: 182902
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E36 RID: 36406
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA77 RID: 182903
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
