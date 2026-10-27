using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.ClothPath
{
	// Token: 0x02003C92 RID: 15506
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/BP_KuroCS_Cloth_Path.BP_KuroCS_Cloth_Path_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1594)]
	public class BP_KuroCS_Cloth_Path_C : AKuroCS_Cloth_Path, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602440D RID: 148493 RVA: 0x009393D4 File Offset: 0x009375D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCS_Cloth_Path_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/BP_KuroCS_Cloth_Path.BP_KuroCS_Cloth_Path_C");
			}
			return BP_KuroCS_Cloth_Path_C._ClassPtr;
		}

		// Token: 0x0602440E RID: 148494 RVA: 0x009393F8 File Offset: 0x009375F8
		public BP_KuroCS_Cloth_Path_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCS_Cloth_Path_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602440F RID: 148495 RVA: 0x00939420 File Offset: 0x00937620
		[NullableContext(1)]
		public BP_KuroCS_Cloth_Path_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCS_Cloth_Path_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x06024410 RID: 148496 RVA: 0x00939453 File Offset: 0x00937653
		// (set) Token: 0x06024411 RID: 148497 RVA: 0x00939467 File Offset: 0x00937667
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x06024412 RID: 148498 RVA: 0x0093947C File Offset: 0x0093767C
		// (set) Token: 0x06024413 RID: 148499 RVA: 0x00939490 File Offset: 0x00937690
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x06024414 RID: 148500 RVA: 0x009394A5 File Offset: 0x009376A5
		// (set) Token: 0x06024415 RID: 148501 RVA: 0x009394B9 File Offset: 0x009376B9
		public unsafe UDataTable DataTable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x06024416 RID: 148502 RVA: 0x009394D0 File Offset: 0x009376D0
		// (set) Token: 0x06024417 RID: 148503 RVA: 0x00939509 File Offset: 0x00937709
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x06024418 RID: 148504 RVA: 0x00939517 File Offset: 0x00937717
		// (set) Token: 0x06024419 RID: 148505 RVA: 0x00939527 File Offset: 0x00937727
		public unsafe bool bXueyuanBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x0602441A RID: 148506 RVA: 0x00939538 File Offset: 0x00937738
		// (set) Token: 0x0602441B RID: 148507 RVA: 0x00939548 File Offset: 0x00937748
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x0602441C RID: 148508 RVA: 0x00939559 File Offset: 0x00937759
		// (set) Token: 0x0602441D RID: 148509 RVA: 0x0093956D File Offset: 0x0093776D
		public unsafe UTextureRenderTarget2D RT_pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004612 RID: 17938
		// (get) Token: 0x0602441E RID: 148510 RVA: 0x00939582 File Offset: 0x00937782
		// (set) Token: 0x0602441F RID: 148511 RVA: 0x00939596 File Offset: 0x00937796
		public unsafe UTextureRenderTarget2D RT_normal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCS_Cloth_Path_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004613 RID: 17939
		// (get) Token: 0x06024420 RID: 148512 RVA: 0x009395AB File Offset: 0x009377AB
		// (set) Token: 0x06024421 RID: 148513 RVA: 0x009395BB File Offset: 0x009377BB
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004614 RID: 17940
		// (get) Token: 0x06024422 RID: 148514 RVA: 0x009395CC File Offset: 0x009377CC
		// (set) Token: 0x06024423 RID: 148515 RVA: 0x009395DC File Offset: 0x009377DC
		public unsafe float CollisionWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004615 RID: 17941
		// (get) Token: 0x06024424 RID: 148516 RVA: 0x009395F0 File Offset: 0x009377F0
		// (set) Token: 0x06024425 RID: 148517 RVA: 0x00939629 File Offset: 0x00937829
		[Nullable(1)]
		public TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPath> Preset
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPath> result;
				if ((result = this._Preset) == null)
				{
					result = (this._Preset = new TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPath>(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Preset.CopyAssign(value);
			}
		}

		// Token: 0x17004616 RID: 17942
		// (get) Token: 0x06024426 RID: 148518 RVA: 0x00939637 File Offset: 0x00937837
		// (set) Token: 0x06024427 RID: 148519 RVA: 0x00939647 File Offset: 0x00937847
		public unsafe bool bReadFromPreset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x06024428 RID: 148520 RVA: 0x00939658 File Offset: 0x00937858
		// (set) Token: 0x06024429 RID: 148521 RVA: 0x00939668 File Offset: 0x00937868
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x0602442A RID: 148522 RVA: 0x00939679 File Offset: 0x00937879
		// (set) Token: 0x0602442B RID: 148523 RVA: 0x00939689 File Offset: 0x00937889
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x0602442C RID: 148524 RVA: 0x0093969A File Offset: 0x0093789A
		// (set) Token: 0x0602442D RID: 148525 RVA: 0x009396AA File Offset: 0x009378AA
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x0602442E RID: 148526 RVA: 0x009396BB File Offset: 0x009378BB
		// (set) Token: 0x0602442F RID: 148527 RVA: 0x009396CB File Offset: 0x009378CB
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06024430 RID: 148528 RVA: 0x009396DC File Offset: 0x009378DC
		// (set) Token: 0x06024431 RID: 148529 RVA: 0x009396EC File Offset: 0x009378EC
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x06024432 RID: 148530 RVA: 0x00939700 File Offset: 0x00937900
		// (set) Token: 0x06024433 RID: 148531 RVA: 0x00939739 File Offset: 0x00937939
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x06024434 RID: 148532 RVA: 0x00939748 File Offset: 0x00937948
		// (set) Token: 0x06024435 RID: 148533 RVA: 0x00939781 File Offset: 0x00937981
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_19, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x06024436 RID: 148534 RVA: 0x00939790 File Offset: 0x00937990
		// (set) Token: 0x06024437 RID: 148535 RVA: 0x009397C9 File Offset: 0x009379C9
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x06024438 RID: 148536 RVA: 0x009397D7 File Offset: 0x009379D7
		// (set) Token: 0x06024439 RID: 148537 RVA: 0x009397E7 File Offset: 0x009379E7
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x0602443A RID: 148538 RVA: 0x009397F8 File Offset: 0x009379F8
		// (set) Token: 0x0602443B RID: 148539 RVA: 0x00939808 File Offset: 0x00937A08
		public unsafe bool SkipConstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCS_Cloth_Path_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602443C RID: 148540 RVA: 0x00939819 File Offset: 0x00937A19
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckLength()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__CheckLength_NativeFunctionPtr, null);
		}

		// Token: 0x0602443D RID: 148541 RVA: 0x0093982D File Offset: 0x00937A2D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReadFromDT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReadFromDT_NativeFunctionPtr, null);
		}

		// Token: 0x0602443E RID: 148542 RVA: 0x00939841 File Offset: 0x00937A41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x0602443F RID: 148543 RVA: 0x00939855 File Offset: 0x00937A55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024440 RID: 148544 RVA: 0x00939869 File Offset: 0x00937A69
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024441 RID: 148545 RVA: 0x0093987D File Offset: 0x00937A7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitDataFromPreset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__InitDataFromPreset_NativeFunctionPtr, null);
		}

		// Token: 0x06024442 RID: 148546 RVA: 0x00939891 File Offset: 0x00937A91
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024443 RID: 148547 RVA: 0x009398A5 File Offset: 0x00937AA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024444 RID: 148548 RVA: 0x009398B9 File Offset: 0x00937AB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024445 RID: 148549 RVA: 0x009398CD File Offset: 0x00937ACD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024446 RID: 148550 RVA: 0x009398E2 File Offset: 0x00937AE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024447 RID: 148551 RVA: 0x009398F6 File Offset: 0x00937AF6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024448 RID: 148552 RVA: 0x0093990C File Offset: 0x00937B0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024449 RID: 148553 RVA: 0x00939954 File Offset: 0x00937B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602444A RID: 148554 RVA: 0x0093999C File Offset: 0x00937B9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602444B RID: 148555 RVA: 0x009399E8 File Offset: 0x00937BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602444C RID: 148556 RVA: 0x00939A34 File Offset: 0x00937C34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602444D RID: 148557 RVA: 0x00939AF0 File Offset: 0x00937CF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCS_Cloth_Path_C.__BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602444E RID: 148558 RVA: 0x00939B79 File Offset: 0x00937D79
		protected BP_KuroCS_Cloth_Path_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F74 RID: 73588
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/BP_KuroCS_Cloth_Path.BP_KuroCS_Cloth_Path_C";

		// Token: 0x04011F75 RID: 73589
		private static IntPtr _ClassPtr;

		// Token: 0x04011F76 RID: 73590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F77 RID: 73591
		internal static int __PropertyOffset_1;

		// Token: 0x04011F78 RID: 73592
		internal static int __PropertyOffset_2;

		// Token: 0x04011F79 RID: 73593
		internal static int __PropertyOffset_3;

		// Token: 0x04011F7A RID: 73594
		internal static int __PropertyOffset_4;

		// Token: 0x04011F7B RID: 73595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04011F7C RID: 73596
		internal static int __PropertyOffset_5;

		// Token: 0x04011F7D RID: 73597
		internal static int __PropertyOffset_6;

		// Token: 0x04011F7E RID: 73598
		internal static int __PropertyOffset_7;

		// Token: 0x04011F7F RID: 73599
		internal static int __PropertyOffset_8;

		// Token: 0x04011F80 RID: 73600
		internal static int __PropertyOffset_9;

		// Token: 0x04011F81 RID: 73601
		internal static int __PropertyOffset_10;

		// Token: 0x04011F82 RID: 73602
		internal static int __PropertyOffset_11;

		// Token: 0x04011F83 RID: 73603
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPath> _Preset;

		// Token: 0x04011F84 RID: 73604
		internal static int __PropertyOffset_12;

		// Token: 0x04011F85 RID: 73605
		internal static int __PropertyOffset_13;

		// Token: 0x04011F86 RID: 73606
		internal static int __PropertyOffset_14;

		// Token: 0x04011F87 RID: 73607
		internal static int __PropertyOffset_15;

		// Token: 0x04011F88 RID: 73608
		internal static int __PropertyOffset_16;

		// Token: 0x04011F89 RID: 73609
		internal static int __PropertyOffset_17;

		// Token: 0x04011F8A RID: 73610
		internal static int __PropertyOffset_18;

		// Token: 0x04011F8B RID: 73611
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04011F8C RID: 73612
		internal static int __PropertyOffset_19;

		// Token: 0x04011F8D RID: 73613
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04011F8E RID: 73614
		internal static int __PropertyOffset_20;

		// Token: 0x04011F8F RID: 73615
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04011F90 RID: 73616
		internal static int __PropertyOffset_21;

		// Token: 0x04011F91 RID: 73617
		internal static int __PropertyOffset_22;

		// Token: 0x04011F92 RID: 73618
		private static IntPtr __CheckLength_NativeFunctionPtr;

		// Token: 0x04011F93 RID: 73619
		private static IntPtr __ReadFromDT_NativeFunctionPtr;

		// Token: 0x04011F94 RID: 73620
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x04011F95 RID: 73621
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04011F96 RID: 73622
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04011F97 RID: 73623
		private static IntPtr __InitDataFromPreset_NativeFunctionPtr;

		// Token: 0x04011F98 RID: 73624
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04011F99 RID: 73625
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04011F9A RID: 73626
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011F9B RID: 73627
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011F9C RID: 73628
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011F9D RID: 73629
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04011F9E RID: 73630
		private static IntPtr __BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011F9F RID: 73631
		private static IntPtr __BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009EF1 RID: 40689
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031806 RID: 202758
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EF2 RID: 40690
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031807 RID: 202759
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009EF3 RID: 40691
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031808 RID: 202760
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031809 RID: 202761
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403180A RID: 202762
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403180B RID: 202763
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403180C RID: 202764
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403180D RID: 202765
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EF4 RID: 40692
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCS_Cloth_Path_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403180E RID: 202766
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403180F RID: 202767
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031810 RID: 202768
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031811 RID: 202769
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
