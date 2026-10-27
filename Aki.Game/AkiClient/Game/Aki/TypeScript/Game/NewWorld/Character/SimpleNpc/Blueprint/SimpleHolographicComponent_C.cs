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
	// Token: 0x02003A17 RID: 14871
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SimpleHolographicComponent.SimpleHolographicComponent_C")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class SimpleHolographicComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F32B RID: 127787 RVA: 0x008AFC54 File Offset: 0x008ADE54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SimpleHolographicComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SimpleHolographicComponent.SimpleHolographicComponent_C");
			}
			return SimpleHolographicComponent_C._ClassPtr;
		}

		// Token: 0x0601F32C RID: 127788 RVA: 0x008AFC78 File Offset: 0x008ADE78
		public SimpleHolographicComponent_C() : this(BuiltinUtils.AllocNativeUObject(SimpleHolographicComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F32D RID: 127789 RVA: 0x008AFCA0 File Offset: 0x008ADEA0
		[NullableContext(1)]
		public SimpleHolographicComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SimpleHolographicComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0601F32E RID: 127790 RVA: 0x008AFCD4 File Offset: 0x008ADED4
		// (set) Token: 0x0601F32F RID: 127791 RVA: 0x008AFD0D File Offset: 0x008ADF0D
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
					result = (this._OL_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.OL_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0601F330 RID: 127792 RVA: 0x008AFD1C File Offset: 0x008ADF1C
		// (set) Token: 0x0601F331 RID: 127793 RVA: 0x008AFD55 File Offset: 0x008ADF55
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
					result = (this._Other_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Other_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0601F332 RID: 127794 RVA: 0x008AFD63 File Offset: 0x008ADF63
		// (set) Token: 0x0601F333 RID: 127795 RVA: 0x008AFD77 File Offset: 0x008ADF77
		[Nullable(2)]
		public unsafe PD_HolographicEffect_C DATA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HolographicEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + SimpleHolographicComponent_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SimpleHolographicComponent_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0601F334 RID: 127796 RVA: 0x008AFD8C File Offset: 0x008ADF8C
		// (set) Token: 0x0601F335 RID: 127797 RVA: 0x008AFD9C File Offset: 0x008ADF9C
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0601F336 RID: 127798 RVA: 0x008AFDAD File Offset: 0x008ADFAD
		// (set) Token: 0x0601F337 RID: 127799 RVA: 0x008AFDC1 File Offset: 0x008ADFC1
		public unsafe TEnumAsByte<EHolographicState> State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0601F338 RID: 127800 RVA: 0x008AFDD6 File Offset: 0x008ADFD6
		// (set) Token: 0x0601F339 RID: 127801 RVA: 0x008AFDE6 File Offset: 0x008ADFE6
		public unsafe bool bCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0601F33A RID: 127802 RVA: 0x008AFDF8 File Offset: 0x008ADFF8
		// (set) Token: 0x0601F33B RID: 127803 RVA: 0x008AFE31 File Offset: 0x008AE031
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
					result = (this._ComponentMaterialsCache = new TMap<USkeletalMeshComponent, SHolographicMaterialsCache>(base.NativePtr + (IntPtr)SimpleHolographicComponent_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ComponentMaterialsCache.CopyAssign(value);
			}
		}

		// Token: 0x0601F33C RID: 127804 RVA: 0x008AFE3F File Offset: 0x008AE03F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__StartEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F33D RID: 127805 RVA: 0x008AFE53 File Offset: 0x008AE053
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__EndEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F33E RID: 127806 RVA: 0x008AFE68 File Offset: 0x008AE068
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateMaterialsWithDa([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInstanceDynamic> Materials, in SHolographicData SHolographicData)
		{
			SimpleHolographicComponent_C.__UpdateMaterialsWithDa_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__UpdateMaterialsWithDa_FunctionParams[(UIntPtr)3031] + 15L / (long)sizeof(SimpleHolographicComponent_C.__UpdateMaterialsWithDa_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UMaterialInstanceDynamic> tarray = Materials;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Materials);
			}
			if (SHolographicData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHolographicData.StaticStruct(), &ptr->SHolographicData, SHolographicData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr);
			TArray<UMaterialInstanceDynamic> tarray2 = Materials;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Materials);
			}
			UnrealReflectionUtils.DestroyStruct(SimpleHolographicComponent_C.__UpdateMaterialsWithDa_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F33F RID: 127807 RVA: 0x008AFF07 File Offset: 0x008AE107
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveNpcEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__RemoveNpcEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601F340 RID: 127808 RVA: 0x008AFF1B File Offset: 0x008AE11B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0601F341 RID: 127809 RVA: 0x008AFF30 File Offset: 0x008AE130
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RevertMaterialParamters(SMaterialParamCache MaterialCache, ref UMaterialInstanceDynamic result)
		{
			SimpleHolographicComponent_C.__RevertMaterialParamters_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__RevertMaterialParamters_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(SimpleHolographicComponent_C.__RevertMaterialParamters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
			if (MaterialCache != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), &ptr->MaterialCache, MaterialCache.NativePtr, 1, false);
			}
			ref SimpleHolographicComponent_C.__RevertMaterialParamters_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = result;
			ptr2.result = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr);
			result = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->result);
			UnrealReflectionUtils.DestroyStruct(SimpleHolographicComponent_C.__RevertMaterialParamters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F342 RID: 127810 RVA: 0x008AFFCC File Offset: 0x008AE1CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual UMaterialInstanceDynamic CacheAndReplace(in SHolographicData SHolographicData, UPrimitiveComponent self2, int ElementIndex, UMaterialInstanceDynamic material, ref SMaterialParamCache CacheResult)
		{
			SimpleHolographicComponent_C.__CacheAndReplace_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__CacheAndReplace_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(SimpleHolographicComponent_C.__CacheAndReplace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr);
			if (CacheResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialParamCache.StaticStruct(), CacheResult.NativePtr, &ptr->CacheResult, 1, false);
			}
			UMaterialInstanceDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(SimpleHolographicComponent_C.__CacheAndReplace_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F343 RID: 127811 RVA: 0x008B00D0 File Offset: 0x008AE2D0
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
			SimpleHolographicComponent_C.__CacheMaterialParameters_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__CacheMaterialParameters_FunctionParams[(UIntPtr)2743] + 15L / (long)sizeof(SimpleHolographicComponent_C.__CacheMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr);
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
			UnrealReflectionUtils.DestroyStruct(SimpleHolographicComponent_C.__CacheMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F344 RID: 127812 RVA: 0x008B01E8 File Offset: 0x008AE3E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			SimpleHolographicComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SimpleHolographicComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SimpleHolographicComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F345 RID: 127813 RVA: 0x008B0230 File Offset: 0x008AE430
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			SimpleHolographicComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc SimpleHolographicComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SimpleHolographicComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SimpleHolographicComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SimpleHolographicComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F346 RID: 127814 RVA: 0x008B0277 File Offset: 0x008AE477
		protected SimpleHolographicComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF28 RID: 61224
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SimpleHolographicComponent.SimpleHolographicComponent_C";

		// Token: 0x0400EF29 RID: 61225
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF2A RID: 61226
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EF2B RID: 61227
		internal static int __PropertyOffset_1;

		// Token: 0x0400EF2C RID: 61228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _OL_Materials;

		// Token: 0x0400EF2D RID: 61229
		internal static int __PropertyOffset_2;

		// Token: 0x0400EF2E RID: 61230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Other_Materials;

		// Token: 0x0400EF2F RID: 61231
		internal static int __PropertyOffset_3;

		// Token: 0x0400EF30 RID: 61232
		internal static int __PropertyOffset_4;

		// Token: 0x0400EF31 RID: 61233
		internal static int __PropertyOffset_5;

		// Token: 0x0400EF32 RID: 61234
		internal static int __PropertyOffset_6;

		// Token: 0x0400EF33 RID: 61235
		internal static int __PropertyOffset_7;

		// Token: 0x0400EF34 RID: 61236
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<USkeletalMeshComponent, SHolographicMaterialsCache> _ComponentMaterialsCache;

		// Token: 0x0400EF35 RID: 61237
		private static IntPtr __StartEffect_NativeFunctionPtr;

		// Token: 0x0400EF36 RID: 61238
		private static IntPtr __EndEffect_NativeFunctionPtr;

		// Token: 0x0400EF37 RID: 61239
		private static IntPtr __UpdateMaterialsWithDa_NativeFunctionPtr;

		// Token: 0x0400EF38 RID: 61240
		private static IntPtr __RemoveNpcEffect_NativeFunctionPtr;

		// Token: 0x0400EF39 RID: 61241
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0400EF3A RID: 61242
		private static IntPtr __RevertMaterialParamters_NativeFunctionPtr;

		// Token: 0x0400EF3B RID: 61243
		private static IntPtr __CacheAndReplace_NativeFunctionPtr;

		// Token: 0x0400EF3C RID: 61244
		private static IntPtr __CacheMaterialParameters_NativeFunctionPtr;

		// Token: 0x0400EF3D RID: 61245
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009A6E RID: 39534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3016)]
		protected ref struct __UpdateMaterialsWithDa_FunctionParams
		{
			// Token: 0x04030FC5 RID: 200645
			[FieldOffset(0)]
			public byte Materials;

			// Token: 0x04030FC6 RID: 200646
			[FieldOffset(16)]
			public byte SHolographicData;
		}

		// Token: 0x02009A6F RID: 39535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __RevertMaterialParamters_FunctionParams
		{
			// Token: 0x04030FC7 RID: 200647
			[FieldOffset(0)]
			public byte MaterialCache;

			// Token: 0x04030FC8 RID: 200648
			[FieldOffset(176)]
			public IntPtr result;
		}

		// Token: 0x02009A70 RID: 39536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __CacheAndReplace_FunctionParams
		{
			// Token: 0x04030FC9 RID: 200649
			[FieldOffset(0)]
			public byte SHolographicData;

			// Token: 0x04030FCA RID: 200650
			[FieldOffset(96)]
			public IntPtr self2;

			// Token: 0x04030FCB RID: 200651
			[FieldOffset(104)]
			public int ElementIndex;

			// Token: 0x04030FCC RID: 200652
			[FieldOffset(112)]
			public IntPtr material;

			// Token: 0x04030FCD RID: 200653
			[FieldOffset(120)]
			public IntPtr __Result;

			// Token: 0x04030FCE RID: 200654
			[FieldOffset(128)]
			public byte CacheResult;
		}

		// Token: 0x02009A71 RID: 39537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2728)]
		protected ref struct __CacheMaterialParameters_FunctionParams
		{
			// Token: 0x04030FCF RID: 200655
			[FieldOffset(0)]
			public byte floats;

			// Token: 0x04030FD0 RID: 200656
			[FieldOffset(16)]
			public byte colors;

			// Token: 0x04030FD1 RID: 200657
			[FieldOffset(32)]
			public IntPtr material;

			// Token: 0x04030FD2 RID: 200658
			[FieldOffset(40)]
			public bool bReplaceMaterial;

			// Token: 0x04030FD3 RID: 200659
			[FieldOffset(44)]
			public int index;

			// Token: 0x04030FD4 RID: 200660
			[FieldOffset(48)]
			public byte result;
		}

		// Token: 0x02009A72 RID: 39538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04030FD5 RID: 200661
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
