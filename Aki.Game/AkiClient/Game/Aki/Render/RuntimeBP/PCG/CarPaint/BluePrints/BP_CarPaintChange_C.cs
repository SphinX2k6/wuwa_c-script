using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints
{
	// Token: 0x020030EA RID: 12522
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class BP_CarPaintChange_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_CarPaintChange_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E511 RID: 124177 RVA: 0x00910F1A File Offset: 0x0090F11A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CarPaintChange_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C");
			}
			return BP_CarPaintChange_C._ClassPtr;
		}

		// Token: 0x0601E512 RID: 124178 RVA: 0x00910F40 File Offset: 0x0090F140
		public BP_CarPaintChange_C() : this(BuiltinUtils.AllocNativeUObject(BP_CarPaintChange_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E513 RID: 124179 RVA: 0x00910F68 File Offset: 0x0090F168
		[NullableContext(1)]
		public BP_CarPaintChange_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CarPaintChange_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0601E514 RID: 124180 RVA: 0x00910F9B File Offset: 0x0090F19B
		// (set) Token: 0x0601E515 RID: 124181 RVA: 0x00910FAF File Offset: 0x0090F1AF
		public unsafe UStaticMeshComponent PlaneDissolve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_PlaneDissolve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_PlaneDissolve, value);
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0601E516 RID: 124182 RVA: 0x00910FC4 File Offset: 0x0090F1C4
		// (set) Token: 0x0601E517 RID: 124183 RVA: 0x00910FD8 File Offset: 0x0090F1D8
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_Sphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_Sphere, value);
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0601E518 RID: 124184 RVA: 0x00910FED File Offset: 0x0090F1ED
		// (set) Token: 0x0601E519 RID: 124185 RVA: 0x00911001 File Offset: 0x0090F201
		public unsafe UStaticMeshComponent SM_Vehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_SM_Vehicle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_SM_Vehicle, value);
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0601E51A RID: 124186 RVA: 0x00911016 File Offset: 0x0090F216
		// (set) Token: 0x0601E51B RID: 124187 RVA: 0x0091102A File Offset: 0x0090F22A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0601E51C RID: 124188 RVA: 0x0091103F File Offset: 0x0090F23F
		// (set) Token: 0x0601E51D RID: 124189 RVA: 0x0091104F File Offset: 0x0090F24F
		public unsafe float CurrentColorSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_CurrentColorSet);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_CurrentColorSet) = value;
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0601E51E RID: 124190 RVA: 0x00911060 File Offset: 0x0090F260
		// (set) Token: 0x0601E51F RID: 124191 RVA: 0x00911070 File Offset: 0x0090F270
		public unsafe float TargetColorSet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_TargetColorSet);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_TargetColorSet) = value;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0601E520 RID: 124192 RVA: 0x00911081 File Offset: 0x0090F281
		// (set) Token: 0x0601E521 RID: 124193 RVA: 0x00911091 File Offset: 0x0090F291
		public unsafe float ColorChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ColorChangeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ColorChangeSpeed) = value;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0601E522 RID: 124194 RVA: 0x009110A2 File Offset: 0x0090F2A2
		// (set) Token: 0x0601E523 RID: 124195 RVA: 0x009110B2 File Offset: 0x0090F2B2
		public unsafe bool ShouldUpdateChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ShouldUpdateChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ShouldUpdateChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0601E524 RID: 124196 RVA: 0x009110C3 File Offset: 0x0090F2C3
		// (set) Token: 0x0601E525 RID: 124197 RVA: 0x009110D7 File Offset: 0x0090F2D7
		public unsafe UMaterialInstanceDynamic CarPaintDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI, value);
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0601E526 RID: 124198 RVA: 0x009110EC File Offset: 0x0090F2EC
		// (set) Token: 0x0601E527 RID: 124199 RVA: 0x00911100 File Offset: 0x0090F300
		public unsafe UMaterialInstanceDynamic CarPaintDMI1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI1, value);
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0601E528 RID: 124200 RVA: 0x00911115 File Offset: 0x0090F315
		// (set) Token: 0x0601E529 RID: 124201 RVA: 0x00911129 File Offset: 0x0090F329
		public unsafe UMaterialInstanceDynamic CarPaintDMI2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_CarPaintDMI2, value);
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0601E52A RID: 124202 RVA: 0x00911140 File Offset: 0x0090F340
		// (set) Token: 0x0601E52B RID: 124203 RVA: 0x00911179 File Offset: 0x0090F379
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> CarPaintDMIList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CarPaintDMIList) == null)
				{
					result = (this._CarPaintDMIList = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_CarPaintDMIList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CarPaintDMIList.CopyAssign(value);
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0601E52C RID: 124204 RVA: 0x00911187 File Offset: 0x0090F387
		// (set) Token: 0x0601E52D RID: 124205 RVA: 0x00911197 File Offset: 0x0090F397
		public unsafe int ColorSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ColorSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ColorSetID) = value;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0601E52E RID: 124206 RVA: 0x009111A8 File Offset: 0x0090F3A8
		// (set) Token: 0x0601E52F RID: 124207 RVA: 0x009111B8 File Offset: 0x0090F3B8
		public unsafe bool PlayPlaneDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_PlayPlaneDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_PlayPlaneDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0601E530 RID: 124208 RVA: 0x009111C9 File Offset: 0x0090F3C9
		// (set) Token: 0x0601E531 RID: 124209 RVA: 0x009111D9 File Offset: 0x0090F3D9
		public unsafe float DirEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_DirEdgeWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_DirEdgeWidth) = value;
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0601E532 RID: 124210 RVA: 0x009111EA File Offset: 0x0090F3EA
		// (set) Token: 0x0601E533 RID: 124211 RVA: 0x009111FE File Offset: 0x0090F3FE
		public unsafe FLinearColor PlaneDisEdgeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_PlaneDisEdgeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_PlaneDisEdgeColor) = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0601E534 RID: 124212 RVA: 0x00911213 File Offset: 0x0090F413
		// (set) Token: 0x0601E535 RID: 124213 RVA: 0x00911227 File Offset: 0x0090F427
		public unsafe UStaticMesh SMVehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_SMVehicle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_SMVehicle, value);
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0601E536 RID: 124214 RVA: 0x0091123C File Offset: 0x0090F43C
		// (set) Token: 0x0601E537 RID: 124215 RVA: 0x0091124C File Offset: 0x0090F44C
		public unsafe bool EditorDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_EditorDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_EditorDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0601E538 RID: 124216 RVA: 0x0091125D File Offset: 0x0090F45D
		// (set) Token: 0x0601E539 RID: 124217 RVA: 0x0091126D File Offset: 0x0090F46D
		public unsafe float ChangeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeRange) = value;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0601E53A RID: 124218 RVA: 0x0091127E File Offset: 0x0090F47E
		// (set) Token: 0x0601E53B RID: 124219 RVA: 0x0091128E File Offset: 0x0090F48E
		public unsafe float ChangeEdgeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeEdgeWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeEdgeWidth) = value;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0601E53C RID: 124220 RVA: 0x0091129F File Offset: 0x0090F49F
		// (set) Token: 0x0601E53D RID: 124221 RVA: 0x009112B3 File Offset: 0x0090F4B3
		public unsafe FLinearColor ChangeEdgeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeEdgeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_ChangeEdgeColor) = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0601E53E RID: 124222 RVA: 0x009112C8 File Offset: 0x0090F4C8
		// (set) Token: 0x0601E53F RID: 124223 RVA: 0x009112D8 File Offset: 0x0090F4D8
		public unsafe bool UseBPTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_UseBPTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CarPaintChange_C.__PropertyOffset_UseBPTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0601E540 RID: 124224 RVA: 0x009112E9 File Offset: 0x0090F4E9
		// (set) Token: 0x0601E541 RID: 124225 RVA: 0x009112FD File Offset: 0x0090F4FD
		public unsafe UTexture2D BaseTex2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_BaseTex2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_BaseTex2, value);
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0601E542 RID: 124226 RVA: 0x00911312 File Offset: 0x0090F512
		// (set) Token: 0x0601E543 RID: 124227 RVA: 0x00911326 File Offset: 0x0090F526
		public unsafe UTexture2D BaseTex3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_BaseTex3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CarPaintChange_C.__PropertyOffset_BaseTex3, value);
			}
		}

		// Token: 0x0601E544 RID: 124228 RVA: 0x0091133B File Offset: 0x0090F53B
		[SkipLocalsInit]
		public virtual void RecoverMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__RecoverMat_NativeFunctionPtr, null);
		}

		// Token: 0x0601E545 RID: 124229 RVA: 0x0091134F File Offset: 0x0090F54F
		[SkipLocalsInit]
		public virtual void Initialize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x0601E546 RID: 124230 RVA: 0x00911364 File Offset: 0x0090F564
		[SkipLocalsInit]
		public unsafe virtual void SetDMIListScalar([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> NewParam)
		{
			BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetDMIListScalar_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CarPaintChange_C.__SetDMIListScalar_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E547 RID: 124231 RVA: 0x009113DC File Offset: 0x0090F5DC
		[SkipLocalsInit]
		public unsafe virtual void SetDMI(UMaterialInstanceDynamic NewParam)
		{
			BP_CarPaintChange_C.__SetDMI_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetDMI_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = ((NewParam != null) ? NewParam.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetDMI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E548 RID: 124232 RVA: 0x00911431 File Offset: 0x0090F631
		[SkipLocalsInit]
		public virtual void SetColorFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorFunction_NativeFunctionPtr, null);
		}

		// Token: 0x0601E549 RID: 124233 RVA: 0x00911445 File Offset: 0x0090F645
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E54A RID: 124234 RVA: 0x00911459 File Offset: 0x0090F659
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E54B RID: 124235 RVA: 0x0091146D File Offset: 0x0090F66D
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E54C RID: 124236 RVA: 0x00911481 File Offset: 0x0090F681
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E54D RID: 124237 RVA: 0x00911498 File Offset: 0x0090F698
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E54E RID: 124238 RVA: 0x009114E0 File Offset: 0x0090F6E0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E54F RID: 124239 RVA: 0x00911528 File Offset: 0x0090F728
		[SkipLocalsInit]
		public unsafe virtual void SetColorChange(float TargetColorSet)
		{
			BP_CarPaintChange_C.__SetColorChange_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetColorChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetColorChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetColorChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TargetColorSet = TargetColorSet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E550 RID: 124240 RVA: 0x00911570 File Offset: 0x0090F770
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E551 RID: 124241 RVA: 0x009115B8 File Offset: 0x0090F7B8
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CarPaintChange_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CarPaintChange_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CarPaintChange_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E552 RID: 124242 RVA: 0x00911600 File Offset: 0x0090F800
		[SkipLocalsInit]
		public unsafe virtual void SetColorFunctionByBPI(bool _bool)
		{
			BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams* ptr = stackalloc BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CarPaintChange_C.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->_bool = _bool;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CarPaintChange_C.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E553 RID: 124243 RVA: 0x00911646 File Offset: 0x0090F846
		protected BP_CarPaintChange_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100C7 RID: 65735
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BP_CarPaintChange.BP_CarPaintChange_C";

		// Token: 0x040100C8 RID: 65736
		private static IntPtr _ClassPtr;

		// Token: 0x040100C9 RID: 65737
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100CA RID: 65738
		internal static int __PropertyOffset_PlaneDissolve;

		// Token: 0x040100CB RID: 65739
		internal static int __PropertyOffset_Sphere;

		// Token: 0x040100CC RID: 65740
		internal static int __PropertyOffset_SM_Vehicle;

		// Token: 0x040100CD RID: 65741
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040100CE RID: 65742
		internal static int __PropertyOffset_CurrentColorSet;

		// Token: 0x040100CF RID: 65743
		internal static int __PropertyOffset_TargetColorSet;

		// Token: 0x040100D0 RID: 65744
		internal static int __PropertyOffset_ColorChangeSpeed;

		// Token: 0x040100D1 RID: 65745
		internal static int __PropertyOffset_ShouldUpdateChange;

		// Token: 0x040100D2 RID: 65746
		internal static int __PropertyOffset_CarPaintDMI;

		// Token: 0x040100D3 RID: 65747
		internal static int __PropertyOffset_CarPaintDMI1;

		// Token: 0x040100D4 RID: 65748
		internal static int __PropertyOffset_CarPaintDMI2;

		// Token: 0x040100D5 RID: 65749
		internal static int __PropertyOffset_CarPaintDMIList;

		// Token: 0x040100D6 RID: 65750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CarPaintDMIList;

		// Token: 0x040100D7 RID: 65751
		internal static int __PropertyOffset_ColorSetID;

		// Token: 0x040100D8 RID: 65752
		internal static int __PropertyOffset_PlayPlaneDissolve;

		// Token: 0x040100D9 RID: 65753
		internal static int __PropertyOffset_DirEdgeWidth;

		// Token: 0x040100DA RID: 65754
		internal static int __PropertyOffset_PlaneDisEdgeColor;

		// Token: 0x040100DB RID: 65755
		internal static int __PropertyOffset_SMVehicle;

		// Token: 0x040100DC RID: 65756
		internal static int __PropertyOffset_EditorDebug;

		// Token: 0x040100DD RID: 65757
		internal static int __PropertyOffset_ChangeRange;

		// Token: 0x040100DE RID: 65758
		internal static int __PropertyOffset_ChangeEdgeWidth;

		// Token: 0x040100DF RID: 65759
		internal static int __PropertyOffset_ChangeEdgeColor;

		// Token: 0x040100E0 RID: 65760
		internal static int __PropertyOffset_UseBPTex;

		// Token: 0x040100E1 RID: 65761
		internal static int __PropertyOffset_BaseTex2;

		// Token: 0x040100E2 RID: 65762
		internal static int __PropertyOffset_BaseTex3;

		// Token: 0x040100E3 RID: 65763
		private static IntPtr __RecoverMat_NativeFunctionPtr;

		// Token: 0x040100E4 RID: 65764
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040100E5 RID: 65765
		private static IntPtr __SetDMIListScalar_NativeFunctionPtr;

		// Token: 0x040100E6 RID: 65766
		private static IntPtr __SetDMI_NativeFunctionPtr;

		// Token: 0x040100E7 RID: 65767
		private static IntPtr __SetColorFunction_NativeFunctionPtr;

		// Token: 0x040100E8 RID: 65768
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040100E9 RID: 65769
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040100EA RID: 65770
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040100EB RID: 65771
		private static IntPtr __SetColorChange_NativeFunctionPtr;

		// Token: 0x040100EC RID: 65772
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040100ED RID: 65773
		private static IntPtr __SetColorFunctionByBPI_NativeFunctionPtr;

		// Token: 0x02008E62 RID: 36450
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetDMIListScalar_FunctionParams
		{
			// Token: 0x0402CAAE RID: 182958
			[FieldOffset(0)]
			public byte NewParam;
		}

		// Token: 0x02008E63 RID: 36451
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetDMI_FunctionParams
		{
			// Token: 0x0402CAAF RID: 182959
			[FieldOffset(0)]
			public IntPtr NewParam;
		}

		// Token: 0x02008E64 RID: 36452
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAB0 RID: 182960
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E65 RID: 36453
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetColorChange_FunctionParams
		{
			// Token: 0x0402CAB1 RID: 182961
			[FieldOffset(0)]
			public float TargetColorSet;
		}

		// Token: 0x02008E66 RID: 36454
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAB2 RID: 182962
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E67 RID: 36455
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetColorFunctionByBPI_FunctionParams
		{
			// Token: 0x0402CAB3 RID: 182963
			[FieldOffset(0)]
			public bool _bool;
		}
	}
}
