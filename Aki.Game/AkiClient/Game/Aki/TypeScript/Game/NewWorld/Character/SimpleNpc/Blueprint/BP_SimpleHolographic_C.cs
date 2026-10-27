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
	// Token: 0x02003A12 RID: 14866
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_Simpleholographic.BP_SimpleHolographic_C")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1202)]
	public class BP_SimpleHolographic_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F2D3 RID: 127699 RVA: 0x008AF0A0 File Offset: 0x008AD2A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SimpleHolographic_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_Simpleholographic.BP_SimpleHolographic_C");
			}
			return BP_SimpleHolographic_C._ClassPtr;
		}

		// Token: 0x0601F2D4 RID: 127700 RVA: 0x008AF0C4 File Offset: 0x008AD2C4
		public BP_SimpleHolographic_C() : this(BuiltinUtils.AllocNativeUObject(BP_SimpleHolographic_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F2D5 RID: 127701 RVA: 0x008AF0EC File Offset: 0x008AD2EC
		[NullableContext(1)]
		public BP_SimpleHolographic_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SimpleHolographic_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0601F2D6 RID: 127702 RVA: 0x008AF11F File Offset: 0x008AD31F
		// (set) Token: 0x0601F2D7 RID: 127703 RVA: 0x008AF133 File Offset: 0x008AD333
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0601F2D8 RID: 127704 RVA: 0x008AF148 File Offset: 0x008AD348
		// (set) Token: 0x0601F2D9 RID: 127705 RVA: 0x008AF181 File Offset: 0x008AD381
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
					result = (this._ComponentMaterialsCache = new TMap<USkeletalMeshComponent, SHolographicMaterialsCache>(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentMaterialsCache.CopyAssign(value);
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0601F2DA RID: 127706 RVA: 0x008AF190 File Offset: 0x008AD390
		// (set) Token: 0x0601F2DB RID: 127707 RVA: 0x008AF1C9 File Offset: 0x008AD3C9
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
					result = (this._OL_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OL_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0601F2DC RID: 127708 RVA: 0x008AF1D8 File Offset: 0x008AD3D8
		// (set) Token: 0x0601F2DD RID: 127709 RVA: 0x008AF211 File Offset: 0x008AD411
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
					result = (this._Other_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Other_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0601F2DE RID: 127710 RVA: 0x008AF21F File Offset: 0x008AD41F
		// (set) Token: 0x0601F2DF RID: 127711 RVA: 0x008AF233 File Offset: 0x008AD433
		public unsafe PD_HolographicEffect_C DATA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HolographicEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0601F2E0 RID: 127712 RVA: 0x008AF248 File Offset: 0x008AD448
		// (set) Token: 0x0601F2E1 RID: 127713 RVA: 0x008AF258 File Offset: 0x008AD458
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0601F2E2 RID: 127714 RVA: 0x008AF269 File Offset: 0x008AD469
		// (set) Token: 0x0601F2E3 RID: 127715 RVA: 0x008AF27D File Offset: 0x008AD47D
		public unsafe AActor TargetRole
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleHolographic_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0601F2E4 RID: 127716 RVA: 0x008AF292 File Offset: 0x008AD492
		// (set) Token: 0x0601F2E5 RID: 127717 RVA: 0x008AF2A6 File Offset: 0x008AD4A6
		[Nullable(0)]
		public unsafe TEnumAsByte<EHolographicState> State
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_8);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0601F2E6 RID: 127718 RVA: 0x008AF2BB File Offset: 0x008AD4BB
		// (set) Token: 0x0601F2E7 RID: 127719 RVA: 0x008AF2CB File Offset: 0x008AD4CB
		public unsafe bool bCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleHolographic_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F2E8 RID: 127720 RVA: 0x008AF2DC File Offset: 0x008AD4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RevertMaterialParamters(SMaterialParamCache MaterialCache, ref UMaterialInstanceDynamic result)
		{
			BP_SimpleHolographic_C.__RevertMaterialParamters_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__RevertMaterialParamters_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_SimpleHolographic_C.__RevertMaterialParamters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
			if (MaterialCache != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), &ptr->MaterialCache, MaterialCache.NativePtr, 1, false);
			}
			ref BP_SimpleHolographic_C.__RevertMaterialParamters_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = result;
			ptr2.result = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr);
			result = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->result);
			UnrealReflectionUtils.DestroyStruct(BP_SimpleHolographic_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2E9 RID: 127721 RVA: 0x008AF378 File Offset: 0x008AD578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual UMaterialInstanceDynamic CacheAndReplace(in SHolographicData SHolographicData, UPrimitiveComponent self2, int ElementIndex, UMaterialInstanceDynamic material, ref SMaterialParamCache CacheResult)
		{
			BP_SimpleHolographic_C.__CacheAndReplace_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__CacheAndReplace_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(BP_SimpleHolographic_C.__CacheAndReplace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr);
			if (CacheResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), CacheResult.NativePtr, &ptr->CacheResult, 1, false);
			}
			UMaterialInstanceDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(BP_SimpleHolographic_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F2EA RID: 127722 RVA: 0x008AF47C File Offset: 0x008AD67C
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
			BP_SimpleHolographic_C.__CacheMaterialParameters_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__CacheMaterialParameters_FunctionParams[(UIntPtr)2743] + 15L / (long)sizeof(BP_SimpleHolographic_C.__CacheMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr);
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
			UnrealReflectionUtils.DestroyStruct(BP_SimpleHolographic_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2EB RID: 127723 RVA: 0x008AF591 File Offset: 0x008AD791
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2EC RID: 127724 RVA: 0x008AF5A5 File Offset: 0x008AD7A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveNpcEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__RemoveNpcEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2ED RID: 127725 RVA: 0x008AF5BC File Offset: 0x008AD7BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMaterialsWithDa([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> Materials, in SHolographicData SHolographicData)
		{
			BP_SimpleHolographic_C.__UpdateMaterialsWithDa_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__UpdateMaterialsWithDa_FunctionParams[(UIntPtr)3031] + 15L / (long)sizeof(BP_SimpleHolographic_C.__UpdateMaterialsWithDa_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = Materials;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Materials);
			}
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Materials);
			}
			UnrealReflectionUtils.DestroyStruct(BP_SimpleHolographic_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F2EE RID: 127726 RVA: 0x008AF65B File Offset: 0x008AD85B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__EndEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2EF RID: 127727 RVA: 0x008AF66F File Offset: 0x008AD86F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__StartEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F2F0 RID: 127728 RVA: 0x008AF684 File Offset: 0x008AD884
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SimpleHolographic_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleHolographic_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleHolographic_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F2F1 RID: 127729 RVA: 0x008AF6CC File Offset: 0x008AD8CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SimpleHolographic_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleHolographic_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleHolographic_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleHolographic_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleHolographic_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F2F2 RID: 127730 RVA: 0x008AF713 File Offset: 0x008AD913
		protected BP_SimpleHolographic_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EEEC RID: 61164
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_Simpleholographic.BP_SimpleHolographic_C";

		// Token: 0x0400EEED RID: 61165
		private static IntPtr _ClassPtr;

		// Token: 0x0400EEEE RID: 61166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EEEF RID: 61167
		internal static int __PropertyOffset_1;

		// Token: 0x0400EEF0 RID: 61168
		internal static int __PropertyOffset_2;

		// Token: 0x0400EEF1 RID: 61169
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<USkeletalMeshComponent, SHolographicMaterialsCache> _ComponentMaterialsCache;

		// Token: 0x0400EEF2 RID: 61170
		internal static int __PropertyOffset_3;

		// Token: 0x0400EEF3 RID: 61171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _OL_Materials;

		// Token: 0x0400EEF4 RID: 61172
		internal static int __PropertyOffset_4;

		// Token: 0x0400EEF5 RID: 61173
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Other_Materials;

		// Token: 0x0400EEF6 RID: 61174
		internal static int __PropertyOffset_5;

		// Token: 0x0400EEF7 RID: 61175
		internal static int __PropertyOffset_6;

		// Token: 0x0400EEF8 RID: 61176
		internal static int __PropertyOffset_7;

		// Token: 0x0400EEF9 RID: 61177
		internal static int __PropertyOffset_8;

		// Token: 0x0400EEFA RID: 61178
		internal static int __PropertyOffset_9;

		// Token: 0x0400EEFB RID: 61179
		private static IntPtr __RevertMaterialParamters_NativeFunctionPtr;

		// Token: 0x0400EEFC RID: 61180
		private static IntPtr __CacheAndReplace_NativeFunctionPtr;

		// Token: 0x0400EEFD RID: 61181
		private static IntPtr __CacheMaterialParameters_NativeFunctionPtr;

		// Token: 0x0400EEFE RID: 61182
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0400EEFF RID: 61183
		private static IntPtr __RemoveNpcEffect_NativeFunctionPtr;

		// Token: 0x0400EF00 RID: 61184
		private static IntPtr __UpdateMaterialsWithDa_NativeFunctionPtr;

		// Token: 0x0400EF01 RID: 61185
		private static IntPtr __EndEffect_NativeFunctionPtr;

		// Token: 0x0400EF02 RID: 61186
		private static IntPtr __StartEffect_NativeFunctionPtr;

		// Token: 0x0400EF03 RID: 61187
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009A69 RID: 39529
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __RevertMaterialParamters_FunctionParams
		{
			// Token: 0x04030FB4 RID: 200628
			[FieldOffset(0)]
			public byte MaterialCache;

			// Token: 0x04030FB5 RID: 200629
			[FieldOffset(176)]
			public IntPtr result;
		}

		// Token: 0x02009A6A RID: 39530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __CacheAndReplace_FunctionParams
		{
			// Token: 0x04030FB6 RID: 200630
			[FieldOffset(0)]
			public byte SHolographicData;

			// Token: 0x04030FB7 RID: 200631
			[FieldOffset(96)]
			public IntPtr self2;

			// Token: 0x04030FB8 RID: 200632
			[FieldOffset(104)]
			public int ElementIndex;

			// Token: 0x04030FB9 RID: 200633
			[FieldOffset(112)]
			public IntPtr material;

			// Token: 0x04030FBA RID: 200634
			[FieldOffset(120)]
			public IntPtr __Result;

			// Token: 0x04030FBB RID: 200635
			[FieldOffset(128)]
			public byte CacheResult;
		}

		// Token: 0x02009A6B RID: 39531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2728)]
		protected ref struct __CacheMaterialParameters_FunctionParams
		{
			// Token: 0x04030FBC RID: 200636
			[FieldOffset(0)]
			public byte floats;

			// Token: 0x04030FBD RID: 200637
			[FieldOffset(16)]
			public byte colors;

			// Token: 0x04030FBE RID: 200638
			[FieldOffset(32)]
			public IntPtr material;

			// Token: 0x04030FBF RID: 200639
			[FieldOffset(40)]
			public bool bReplaceMaterial;

			// Token: 0x04030FC0 RID: 200640
			[FieldOffset(44)]
			public int index;

			// Token: 0x04030FC1 RID: 200641
			[FieldOffset(48)]
			public byte result;
		}

		// Token: 0x02009A6C RID: 39532
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3016)]
		protected ref struct __UpdateMaterialsWithDa_FunctionParams
		{
			// Token: 0x04030FC2 RID: 200642
			[FieldOffset(0)]
			public byte Materials;

			// Token: 0x04030FC3 RID: 200643
			[FieldOffset(16)]
			public byte SHolographicData;
		}

		// Token: 0x02009A6D RID: 39533
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04030FC4 RID: 200644
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
