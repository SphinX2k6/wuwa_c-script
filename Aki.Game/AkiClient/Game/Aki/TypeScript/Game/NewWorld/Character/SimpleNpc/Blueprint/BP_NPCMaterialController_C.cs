using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A11 RID: 14865
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 361)]
	public class BP_NPCMaterialController_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2AB RID: 127659 RVA: 0x008AE834 File Offset: 0x008ACA34
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NPCMaterialController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C");
			}
			return BP_NPCMaterialController_C._ClassPtr;
		}

		// Token: 0x0601F2AC RID: 127660 RVA: 0x008AE858 File Offset: 0x008ACA58
		public BP_NPCMaterialController_C() : this(BuiltinUtils.AllocNativeUObject(BP_NPCMaterialController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2AD RID: 127661 RVA: 0x008AE880 File Offset: 0x008ACA80
		[NullableContext(1)]
		public BP_NPCMaterialController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NPCMaterialController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0601F2AE RID: 127662 RVA: 0x008AE8B4 File Offset: 0x008ACAB4
		// (set) Token: 0x0601F2AF RID: 127663 RVA: 0x008AE8ED File Offset: 0x008ACAED
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> OL_Materials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._OL_Materials) == null)
				{
					result = (this._OL_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OL_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0601F2B0 RID: 127664 RVA: 0x008AE8FC File Offset: 0x008ACAFC
		// (set) Token: 0x0601F2B1 RID: 127665 RVA: 0x008AE935 File Offset: 0x008ACB35
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Other_Materials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Other_Materials) == null)
				{
					result = (this._Other_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Other_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0601F2B2 RID: 127666 RVA: 0x008AE943 File Offset: 0x008ACB43
		// (set) Token: 0x0601F2B3 RID: 127667 RVA: 0x008AE957 File Offset: 0x008ACB57
		[Nullable(2)]
		public unsafe PD_HolographicEffect_C DATA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HolographicEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0601F2B4 RID: 127668 RVA: 0x008AE96C File Offset: 0x008ACB6C
		// (set) Token: 0x0601F2B5 RID: 127669 RVA: 0x008AE97C File Offset: 0x008ACB7C
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0601F2B6 RID: 127670 RVA: 0x008AE98D File Offset: 0x008ACB8D
		// (set) Token: 0x0601F2B7 RID: 127671 RVA: 0x008AE9A1 File Offset: 0x008ACBA1
		public unsafe TEnumAsByte<EHolographicState> State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0601F2B8 RID: 127672 RVA: 0x008AE9B6 File Offset: 0x008ACBB6
		// (set) Token: 0x0601F2B9 RID: 127673 RVA: 0x008AE9C6 File Offset: 0x008ACBC6
		public unsafe bool bCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0601F2BA RID: 127674 RVA: 0x008AE9D8 File Offset: 0x008ACBD8
		// (set) Token: 0x0601F2BB RID: 127675 RVA: 0x008AEA11 File Offset: 0x008ACC11
		[Nullable(1)]
		public TMap<USkeletalMeshComponent, SHolographicMaterialsCache> ComponentMaterialsCache
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<USkeletalMeshComponent, SHolographicMaterialsCache> result;
				if ((result = this._ComponentMaterialsCache) == null)
				{
					result = (this._ComponentMaterialsCache = new TMap<USkeletalMeshComponent, SHolographicMaterialsCache>(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentMaterialsCache.CopyAssign(value);
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0601F2BC RID: 127676 RVA: 0x008AEA1F File Offset: 0x008ACC1F
		// (set) Token: 0x0601F2BD RID: 127677 RVA: 0x008AEA2F File Offset: 0x008ACC2F
		public unsafe bool EnableBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0601F2BE RID: 127678 RVA: 0x008AEA40 File Offset: 0x008ACC40
		// (set) Token: 0x0601F2BF RID: 127679 RVA: 0x008AEA50 File Offset: 0x008ACC50
		public unsafe bool EnableMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0601F2C0 RID: 127680 RVA: 0x008AEA61 File Offset: 0x008ACC61
		// (set) Token: 0x0601F2C1 RID: 127681 RVA: 0x008AEA75 File Offset: 0x008ACC75
		[Nullable(2)]
		public unsafe UKuroMaterialControllerComponent MaterialController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0601F2C2 RID: 127682 RVA: 0x008AEA8A File Offset: 0x008ACC8A
		// (set) Token: 0x0601F2C3 RID: 127683 RVA: 0x008AEA9A File Offset: 0x008ACC9A
		public unsafe bool IsOnMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F2C4 RID: 127684 RVA: 0x008AEAAC File Offset: 0x008ACCAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyMaterialAndTexture(in SHolographicData SHolographicData, EKuroCharSlotSpecifiedType SlotType)
		{
			BP_NPCMaterialController_C.__ApplyMaterialAndTexture_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ApplyMaterialAndTexture_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ApplyMaterialAndTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ApplyMaterialAndTexture_NativeFunctionPtr, (void*)ptr, 1);
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			ptr->SlotType = SlotType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__ApplyMaterialAndTexture_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__ApplyMaterialAndTexture_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2C5 RID: 127685 RVA: 0x008AEB2C File Offset: 0x008ACD2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyMaterialsWithDa(in SHolographicData SHolographicData, EKuroCharSlotSpecifiedType SlotType)
		{
			BP_NPCMaterialController_C.__ApplyMaterialsWithDa_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ApplyMaterialsWithDa_FunctionParams[(UIntPtr)2967] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ApplyMaterialsWithDa_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ApplyMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			ptr->SlotType = SlotType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__ApplyMaterialsWithDa_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__ApplyMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2C6 RID: 127686 RVA: 0x008AEBAC File Offset: 0x008ACDAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MaterialPretreatment([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> Materials, in SHolographicData SHolographicData)
		{
			BP_NPCMaterialController_C.__MaterialPretreatment_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__MaterialPretreatment_FunctionParams[(UIntPtr)855] + 15L / (long)sizeof(BP_NPCMaterialController_C.__MaterialPretreatment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__MaterialPretreatment_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = Materials;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Materials);
			}
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__MaterialPretreatment_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Materials);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__MaterialPretreatment_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2C7 RID: 127687 RVA: 0x008AEC4B File Offset: 0x008ACE4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__EndEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2C8 RID: 127688 RVA: 0x008AEC5F File Offset: 0x008ACE5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__StartEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2C9 RID: 127689 RVA: 0x008AEC74 File Offset: 0x008ACE74
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMaterialsWithDa([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> Materials, in SHolographicData SHolographicData)
		{
			BP_NPCMaterialController_C.__UpdateMaterialsWithDa_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__UpdateMaterialsWithDa_FunctionParams[(UIntPtr)3007] + 15L / (long)sizeof(BP_NPCMaterialController_C.__UpdateMaterialsWithDa_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = Materials;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Materials);
			}
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Materials);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2CA RID: 127690 RVA: 0x008AED13 File Offset: 0x008ACF13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveNpcEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__RemoveNpcEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2CB RID: 127691 RVA: 0x008AED27 File Offset: 0x008ACF27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2CC RID: 127692 RVA: 0x008AED3C File Offset: 0x008ACF3C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RevertMaterialParamters(SMaterialParamCache MaterialCache, ref UMaterialInstanceDynamic result)
		{
			BP_NPCMaterialController_C.__RevertMaterialParamters_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__RevertMaterialParamters_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_NPCMaterialController_C.__RevertMaterialParamters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
			if (MaterialCache != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), &ptr->MaterialCache, MaterialCache.NativePtr, 1, false);
			}
			ref BP_NPCMaterialController_C.__RevertMaterialParamters_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = result;
			ptr2.result = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr);
			result = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->result);
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2CD RID: 127693 RVA: 0x008AEDD8 File Offset: 0x008ACFD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual UMaterialInstanceDynamic CacheAndReplace(in SHolographicData SHolographicData, UPrimitiveComponent self2, int ElementIndex, UMaterialInstanceDynamic material, ref SMaterialParamCache CacheResult)
		{
			BP_NPCMaterialController_C.__CacheAndReplace_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__CacheAndReplace_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(BP_NPCMaterialController_C.__CacheAndReplace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			ptr->self2 = ((self2 != null) ? self2.NativePtr : IntPtr.Zero);
			ptr->ElementIndex = ElementIndex;
			ptr->material = ((material != null) ? material.NativePtr : IntPtr.Zero);
			if (CacheResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), &ptr->CacheResult, CacheResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr);
			if (CacheResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), CacheResult.NativePtr, &ptr->CacheResult, 1, false);
			}
			UMaterialInstanceDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F2CE RID: 127694 RVA: 0x008AEEDC File Offset: 0x008AD0DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CacheMaterialParameters([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SMaterialControllerFloatParameter> floats, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SMaterialControllerColorParameter> colors, UMaterialInstanceDynamic material, bool bReplaceMaterial, int index, ref SMaterialParamCache result)
		{
			BP_NPCMaterialController_C.__CacheMaterialParameters_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__CacheMaterialParameters_FunctionParams[(UIntPtr)2743] + 15L / (long)sizeof(BP_NPCMaterialController_C.__CacheMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
			TArray<SMaterialControllerFloatParameter> tarray = floats;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->floats);
			}
			TArray<SMaterialControllerColorParameter> tarray2 = colors;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->colors);
			}
			ptr->material = ((material != null) ? material.NativePtr : IntPtr.Zero);
			ptr->bReplaceMaterial = bReplaceMaterial;
			ptr->index = index;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), &ptr->result, result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr);
			TArray<SMaterialControllerFloatParameter> tarray3 = floats;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->floats);
			}
			TArray<SMaterialControllerColorParameter> tarray4 = colors;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->colors);
			}
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), result.NativePtr, &ptr->result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_NPCMaterialController_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2CF RID: 127695 RVA: 0x008AEFF4 File Offset: 0x008AD1F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NPCMaterialController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F2D0 RID: 127696 RVA: 0x008AF03C File Offset: 0x008AD23C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NPCMaterialController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F2D1 RID: 127697 RVA: 0x008AF083 File Offset: 0x008AD283
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTickOnce()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__CustomTickOnce_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2D2 RID: 127698 RVA: 0x008AF097 File Offset: 0x008AD297
		protected BP_NPCMaterialController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EECE RID: 61134
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C";

		// Token: 0x0400EECF RID: 61135
		private static IntPtr _ClassPtr;

		// Token: 0x0400EED0 RID: 61136
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EED1 RID: 61137
		internal static int __PropertyOffset_1;

		// Token: 0x0400EED2 RID: 61138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _OL_Materials;

		// Token: 0x0400EED3 RID: 61139
		internal static int __PropertyOffset_2;

		// Token: 0x0400EED4 RID: 61140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Other_Materials;

		// Token: 0x0400EED5 RID: 61141
		internal static int __PropertyOffset_3;

		// Token: 0x0400EED6 RID: 61142
		internal static int __PropertyOffset_4;

		// Token: 0x0400EED7 RID: 61143
		internal static int __PropertyOffset_5;

		// Token: 0x0400EED8 RID: 61144
		internal static int __PropertyOffset_6;

		// Token: 0x0400EED9 RID: 61145
		internal static int __PropertyOffset_7;

		// Token: 0x0400EEDA RID: 61146
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<USkeletalMeshComponent, SHolographicMaterialsCache> _ComponentMaterialsCache;

		// Token: 0x0400EEDB RID: 61147
		internal static int __PropertyOffset_8;

		// Token: 0x0400EEDC RID: 61148
		internal static int __PropertyOffset_9;

		// Token: 0x0400EEDD RID: 61149
		internal static int __PropertyOffset_10;

		// Token: 0x0400EEDE RID: 61150
		internal static int __PropertyOffset_11;

		// Token: 0x0400EEDF RID: 61151
		private static IntPtr __ApplyMaterialAndTexture_NativeFunctionPtr;

		// Token: 0x0400EEE0 RID: 61152
		private static IntPtr __ApplyMaterialsWithDa_NativeFunctionPtr;

		// Token: 0x0400EEE1 RID: 61153
		private static IntPtr __MaterialPretreatment_NativeFunctionPtr;

		// Token: 0x0400EEE2 RID: 61154
		private static IntPtr __EndEffect_NativeFunctionPtr;

		// Token: 0x0400EEE3 RID: 61155
		private static IntPtr __StartEffect_NativeFunctionPtr;

		// Token: 0x0400EEE4 RID: 61156
		private static IntPtr __UpdateMaterialsWithDa_NativeFunctionPtr;

		// Token: 0x0400EEE5 RID: 61157
		private static IntPtr __RemoveNpcEffect_NativeFunctionPtr;

		// Token: 0x0400EEE6 RID: 61158
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0400EEE7 RID: 61159
		private static IntPtr __RevertMaterialParamters_NativeFunctionPtr;

		// Token: 0x0400EEE8 RID: 61160
		private static IntPtr __CacheAndReplace_NativeFunctionPtr;

		// Token: 0x0400EEE9 RID: 61161
		private static IntPtr __CacheMaterialParameters_NativeFunctionPtr;

		// Token: 0x0400EEEA RID: 61162
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400EEEB RID: 61163
		private static IntPtr __CustomTickOnce_NativeFunctionPtr;

		// Token: 0x02009A61 RID: 39521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __ApplyMaterialAndTexture_FunctionParams
		{
			// Token: 0x04030F9D RID: 200605
			[FieldOffset(0)]
			public byte SHolographicData;

			// Token: 0x04030F9E RID: 200606
			[FieldOffset(96)]
			public EKuroCharSlotSpecifiedType SlotType;
		}

		// Token: 0x02009A62 RID: 39522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2952)]
		protected ref struct __ApplyMaterialsWithDa_FunctionParams
		{
			// Token: 0x04030F9F RID: 200607
			[FieldOffset(0)]
			public byte SHolographicData;

			// Token: 0x04030FA0 RID: 200608
			[FieldOffset(96)]
			public EKuroCharSlotSpecifiedType SlotType;
		}

		// Token: 0x02009A63 RID: 39523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 840)]
		protected ref struct __MaterialPretreatment_FunctionParams
		{
			// Token: 0x04030FA1 RID: 200609
			[FieldOffset(0)]
			public byte Materials;

			// Token: 0x04030FA2 RID: 200610
			[FieldOffset(16)]
			public byte SHolographicData;
		}

		// Token: 0x02009A64 RID: 39524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2992)]
		protected ref struct __UpdateMaterialsWithDa_FunctionParams
		{
			// Token: 0x04030FA3 RID: 200611
			[FieldOffset(0)]
			public byte Materials;

			// Token: 0x04030FA4 RID: 200612
			[FieldOffset(16)]
			public byte SHolographicData;
		}

		// Token: 0x02009A65 RID: 39525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __RevertMaterialParamters_FunctionParams
		{
			// Token: 0x04030FA5 RID: 200613
			[FieldOffset(0)]
			public byte MaterialCache;

			// Token: 0x04030FA6 RID: 200614
			[FieldOffset(176)]
			public IntPtr result;
		}

		// Token: 0x02009A66 RID: 39526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __CacheAndReplace_FunctionParams
		{
			// Token: 0x04030FA7 RID: 200615
			[FieldOffset(0)]
			public byte SHolographicData;

			// Token: 0x04030FA8 RID: 200616
			[FieldOffset(96)]
			public IntPtr self2;

			// Token: 0x04030FA9 RID: 200617
			[FieldOffset(104)]
			public int ElementIndex;

			// Token: 0x04030FAA RID: 200618
			[FieldOffset(112)]
			public IntPtr material;

			// Token: 0x04030FAB RID: 200619
			[FieldOffset(120)]
			public IntPtr __Result;

			// Token: 0x04030FAC RID: 200620
			[FieldOffset(128)]
			public byte CacheResult;
		}

		// Token: 0x02009A67 RID: 39527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2728)]
		protected ref struct __CacheMaterialParameters_FunctionParams
		{
			// Token: 0x04030FAD RID: 200621
			[FieldOffset(0)]
			public byte floats;

			// Token: 0x04030FAE RID: 200622
			[FieldOffset(16)]
			public byte colors;

			// Token: 0x04030FAF RID: 200623
			[FieldOffset(32)]
			public IntPtr material;

			// Token: 0x04030FB0 RID: 200624
			[FieldOffset(40)]
			public bool bReplaceMaterial;

			// Token: 0x04030FB1 RID: 200625
			[FieldOffset(44)]
			public int index;

			// Token: 0x04030FB2 RID: 200626
			[FieldOffset(48)]
			public byte result;
		}

		// Token: 0x02009A68 RID: 39528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04030FB3 RID: 200627
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
