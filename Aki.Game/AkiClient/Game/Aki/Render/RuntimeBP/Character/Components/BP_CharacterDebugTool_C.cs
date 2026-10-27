using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2A RID: 15914
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/BP_CharacterDebugTool.BP_CharacterDebugTool_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1268)]
	public class BP_CharacterDebugTool_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E24 RID: 163364 RVA: 0x0099E5DB File Offset: 0x0099C7DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterDebugTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/BP_CharacterDebugTool.BP_CharacterDebugTool_C");
			}
			return BP_CharacterDebugTool_C._ClassPtr;
		}

		// Token: 0x06027E25 RID: 163365 RVA: 0x0099E600 File Offset: 0x0099C800
		public BP_CharacterDebugTool_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterDebugTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E26 RID: 163366 RVA: 0x0099E628 File Offset: 0x0099C828
		[NullableContext(1)]
		public BP_CharacterDebugTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterDebugTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x06027E27 RID: 163367 RVA: 0x0099E65B File Offset: 0x0099C85B
		// (set) Token: 0x06027E28 RID: 163368 RVA: 0x0099E66F File Offset: 0x0099C86F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x06027E29 RID: 163369 RVA: 0x0099E684 File Offset: 0x0099C884
		// (set) Token: 0x06027E2A RID: 163370 RVA: 0x0099E698 File Offset: 0x0099C898
		public unsafe TsBaseCharacter Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x06027E2B RID: 163371 RVA: 0x0099E6AD File Offset: 0x0099C8AD
		// (set) Token: 0x06027E2C RID: 163372 RVA: 0x0099E6C1 File Offset: 0x0099C8C1
		public unsafe ASkeletalMeshActor SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x06027E2D RID: 163373 RVA: 0x0099E6D6 File Offset: 0x0099C8D6
		// (set) Token: 0x06027E2E RID: 163374 RVA: 0x0099E6EA File Offset: 0x0099C8EA
		public unsafe TsBaseCharacter LastCharacter
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x06027E2F RID: 163375 RVA: 0x0099E6FF File Offset: 0x0099C8FF
		// (set) Token: 0x06027E30 RID: 163376 RVA: 0x0099E70F File Offset: 0x0099C90F
		public unsafe int 材质控制器handle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x06027E31 RID: 163377 RVA: 0x0099E720 File Offset: 0x0099C920
		// (set) Token: 0x06027E32 RID: 163378 RVA: 0x0099E730 File Offset: 0x0099C930
		public unsafe int 材质控制器handle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x06027E33 RID: 163379 RVA: 0x0099E741 File Offset: 0x0099C941
		// (set) Token: 0x06027E34 RID: 163380 RVA: 0x0099E755 File Offset: 0x0099C955
		public unsafe PD_CharacterControllerData_C 材质控制器数据1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x06027E35 RID: 163381 RVA: 0x0099E76A File Offset: 0x0099C96A
		// (set) Token: 0x06027E36 RID: 163382 RVA: 0x0099E77E File Offset: 0x0099C97E
		public unsafe PD_CharacterControllerData_C 材质控制器数据2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x06027E37 RID: 163383 RVA: 0x0099E793 File Offset: 0x0099C993
		// (set) Token: 0x06027E38 RID: 163384 RVA: 0x0099E7A3 File Offset: 0x0099C9A3
		public unsafe bool dirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x06027E39 RID: 163385 RVA: 0x0099E7B4 File Offset: 0x0099C9B4
		// (set) Token: 0x06027E3A RID: 163386 RVA: 0x0099E7C8 File Offset: 0x0099C9C8
		public unsafe PD_CharacterControllerDataGroup_C 材质控制器组数据
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerDataGroup_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x06027E3B RID: 163387 RVA: 0x0099E7DD File Offset: 0x0099C9DD
		// (set) Token: 0x06027E3C RID: 163388 RVA: 0x0099E7ED File Offset: 0x0099C9ED
		public unsafe int GroupHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x06027E3D RID: 163389 RVA: 0x0099E7FE File Offset: 0x0099C9FE
		// (set) Token: 0x06027E3E RID: 163390 RVA: 0x0099E812 File Offset: 0x0099CA12
		public unsafe PD_CurveLinearColorData_C ColorCurveData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CurveLinearColorData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x06027E3F RID: 163391 RVA: 0x0099E827 File Offset: 0x0099CA27
		// (set) Token: 0x06027E40 RID: 163392 RVA: 0x0099E83B File Offset: 0x0099CA3B
		public unsafe PD_CurveFloatData_C FloatCurveData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CurveFloatData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterDebugTool_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x06027E41 RID: 163393 RVA: 0x0099E850 File Offset: 0x0099CA50
		// (set) Token: 0x06027E42 RID: 163394 RVA: 0x0099E864 File Offset: 0x0099CA64
		[Nullable(1)]
		public unsafe string 属性名称
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_14)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_14)), value);
			}
		}

		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x06027E43 RID: 163395 RVA: 0x0099E879 File Offset: 0x0099CA79
		// (set) Token: 0x06027E44 RID: 163396 RVA: 0x0099E889 File Offset: 0x0099CA89
		public unsafe float SectionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x06027E45 RID: 163397 RVA: 0x0099E89A File Offset: 0x0099CA9A
		// (set) Token: 0x06027E46 RID: 163398 RVA: 0x0099E8AE File Offset: 0x0099CAAE
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterBodySpecifiedType> BodyType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x06027E47 RID: 163399 RVA: 0x0099E8C3 File Offset: 0x0099CAC3
		// (set) Token: 0x06027E48 RID: 163400 RVA: 0x0099E8D7 File Offset: 0x0099CAD7
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterSlotSpecifiedType> SlotType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_17);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x06027E49 RID: 163401 RVA: 0x0099E8EC File Offset: 0x0099CAEC
		// (set) Token: 0x06027E4A RID: 163402 RVA: 0x0099E900 File Offset: 0x0099CB00
		public unsafe FLinearColor ColorValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x06027E4B RID: 163403 RVA: 0x0099E915 File Offset: 0x0099CB15
		// (set) Token: 0x06027E4C RID: 163404 RVA: 0x0099E925 File Offset: 0x0099CB25
		public unsafe float Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x06027E4D RID: 163405 RVA: 0x0099E936 File Offset: 0x0099CB36
		// (set) Token: 0x06027E4E RID: 163406 RVA: 0x0099E946 File Offset: 0x0099CB46
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x06027E4F RID: 163407 RVA: 0x0099E957 File Offset: 0x0099CB57
		// (set) Token: 0x06027E50 RID: 163408 RVA: 0x0099E967 File Offset: 0x0099CB67
		public unsafe bool IsDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x06027E51 RID: 163409 RVA: 0x0099E978 File Offset: 0x0099CB78
		// (set) Token: 0x06027E52 RID: 163410 RVA: 0x0099E988 File Offset: 0x0099CB88
		public unsafe float 材质控制1进度_仅Manul类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x06027E53 RID: 163411 RVA: 0x0099E999 File Offset: 0x0099CB99
		// (set) Token: 0x06027E54 RID: 163412 RVA: 0x0099E9A9 File Offset: 0x0099CBA9
		public unsafe float 材质控制2进度_仅Manul类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x06027E55 RID: 163413 RVA: 0x0099E9BA File Offset: 0x0099CBBA
		// (set) Token: 0x06027E56 RID: 163414 RVA: 0x0099E9CA File Offset: 0x0099CBCA
		public unsafe float Dither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x06027E57 RID: 163415 RVA: 0x0099E9DB File Offset: 0x0099CBDB
		// (set) Token: 0x06027E58 RID: 163416 RVA: 0x0099E9F0 File Offset: 0x0099CBF0
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> 特效数据
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_25, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_25, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x06027E59 RID: 163417 RVA: 0x0099EA15 File Offset: 0x0099CC15
		// (set) Token: 0x06027E5A RID: 163418 RVA: 0x0099EA25 File Offset: 0x0099CC25
		public unsafe int EffectId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterDebugTool_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x06027E5B RID: 163419 RVA: 0x0099EA36 File Offset: 0x0099CC36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除材质控制器1和附身特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除材质控制器1和附身特效_NativeFunctionPtr, null);
		}

		// Token: 0x06027E5C RID: 163420 RVA: 0x0099EA4A File Offset: 0x0099CC4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加材质控制器1和附身特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加材质控制器1和附身特效_NativeFunctionPtr, null);
		}

		// Token: 0x06027E5D RID: 163421 RVA: 0x0099EA5E File Offset: 0x0099CC5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除附身特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除附身特效_NativeFunctionPtr, null);
		}

		// Token: 0x06027E5E RID: 163422 RVA: 0x0099EA72 File Offset: 0x0099CC72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加附身特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加附身特效_NativeFunctionPtr, null);
		}

		// Token: 0x06027E5F RID: 163423 RVA: 0x0099EA86 File Offset: 0x0099CC86
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新Dither值()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__更新Dither值_NativeFunctionPtr, null);
		}

		// Token: 0x06027E60 RID: 163424 RVA: 0x0099EA9A File Offset: 0x0099CC9A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 减少材质控制1进度_仅Manul类型()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__减少材质控制1进度_仅Manul类型_NativeFunctionPtr, null);
		}

		// Token: 0x06027E61 RID: 163425 RVA: 0x0099EAAE File Offset: 0x0099CCAE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 增加材质控制1进度_仅Manul类型()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__增加材质控制1进度_仅Manul类型_NativeFunctionPtr, null);
		}

		// Token: 0x06027E62 RID: 163426 RVA: 0x0099EAC2 File Offset: 0x0099CCC2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 去掉胶囊体Dither()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__去掉胶囊体Dither_NativeFunctionPtr, null);
		}

		// Token: 0x06027E63 RID: 163427 RVA: 0x0099EAD6 File Offset: 0x0099CCD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加胶囊体Dither()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加胶囊体Dither_NativeFunctionPtr, null);
		}

		// Token: 0x06027E64 RID: 163428 RVA: 0x0099EAEA File Offset: 0x0099CCEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置浮点数属性()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__设置浮点数属性_NativeFunctionPtr, null);
		}

		// Token: 0x06027E65 RID: 163429 RVA: 0x0099EAFE File Offset: 0x0099CCFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置颜色属性()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__设置颜色属性_NativeFunctionPtr, null);
		}

		// Token: 0x06027E66 RID: 163430 RVA: 0x0099EB12 File Offset: 0x0099CD12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置曲线浮点数属性()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__设置曲线浮点数属性_NativeFunctionPtr, null);
		}

		// Token: 0x06027E67 RID: 163431 RVA: 0x0099EB26 File Offset: 0x0099CD26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置曲线颜色属性()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__设置曲线颜色属性_NativeFunctionPtr, null);
		}

		// Token: 0x06027E68 RID: 163432 RVA: 0x0099EB3A File Offset: 0x0099CD3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__初始化_NativeFunctionPtr, null);
		}

		// Token: 0x06027E69 RID: 163433 RVA: 0x0099EB4E File Offset: 0x0099CD4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除材质控制器1_ToEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除材质控制器1_ToEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6A RID: 163434 RVA: 0x0099EB62 File Offset: 0x0099CD62
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6B RID: 163435 RVA: 0x0099EB76 File Offset: 0x0099CD76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加材质控制器组()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加材质控制器组_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6C RID: 163436 RVA: 0x0099EB8A File Offset: 0x0099CD8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除所有状态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除所有状态_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6D RID: 163437 RVA: 0x0099EB9E File Offset: 0x0099CD9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除材质控制器2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除材质控制器2_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6E RID: 163438 RVA: 0x0099EBB2 File Offset: 0x0099CDB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加材质控制器2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加材质控制器2_NativeFunctionPtr, null);
		}

		// Token: 0x06027E6F RID: 163439 RVA: 0x0099EBC6 File Offset: 0x0099CDC6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 移除材质控制器1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__移除材质控制器1_NativeFunctionPtr, null);
		}

		// Token: 0x06027E70 RID: 163440 RVA: 0x0099EBDA File Offset: 0x0099CDDA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加材质控制器1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__添加材质控制器1_NativeFunctionPtr, null);
		}

		// Token: 0x06027E71 RID: 163441 RVA: 0x0099EBF0 File Offset: 0x0099CDF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterDebugTool_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterDebugTool_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027E72 RID: 163442 RVA: 0x0099EC38 File Offset: 0x0099CE38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterDebugTool_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterDebugTool_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterDebugTool_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027E73 RID: 163443 RVA: 0x0099EC7F File Offset: 0x0099CE7F
		protected BP_CharacterDebugTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040143C3 RID: 82883
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/BP_CharacterDebugTool.BP_CharacterDebugTool_C";

		// Token: 0x040143C4 RID: 82884
		private static IntPtr _ClassPtr;

		// Token: 0x040143C5 RID: 82885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040143C6 RID: 82886
		internal static int __PropertyOffset_1;

		// Token: 0x040143C7 RID: 82887
		internal static int __PropertyOffset_2;

		// Token: 0x040143C8 RID: 82888
		internal static int __PropertyOffset_3;

		// Token: 0x040143C9 RID: 82889
		internal static int __PropertyOffset_4;

		// Token: 0x040143CA RID: 82890
		internal static int __PropertyOffset_5;

		// Token: 0x040143CB RID: 82891
		internal static int __PropertyOffset_6;

		// Token: 0x040143CC RID: 82892
		internal static int __PropertyOffset_7;

		// Token: 0x040143CD RID: 82893
		internal static int __PropertyOffset_8;

		// Token: 0x040143CE RID: 82894
		internal static int __PropertyOffset_9;

		// Token: 0x040143CF RID: 82895
		internal static int __PropertyOffset_10;

		// Token: 0x040143D0 RID: 82896
		internal static int __PropertyOffset_11;

		// Token: 0x040143D1 RID: 82897
		internal static int __PropertyOffset_12;

		// Token: 0x040143D2 RID: 82898
		internal static int __PropertyOffset_13;

		// Token: 0x040143D3 RID: 82899
		internal static int __PropertyOffset_14;

		// Token: 0x040143D4 RID: 82900
		internal static int __PropertyOffset_15;

		// Token: 0x040143D5 RID: 82901
		internal static int __PropertyOffset_16;

		// Token: 0x040143D6 RID: 82902
		internal static int __PropertyOffset_17;

		// Token: 0x040143D7 RID: 82903
		internal static int __PropertyOffset_18;

		// Token: 0x040143D8 RID: 82904
		internal static int __PropertyOffset_19;

		// Token: 0x040143D9 RID: 82905
		internal static int __PropertyOffset_20;

		// Token: 0x040143DA RID: 82906
		internal static int __PropertyOffset_21;

		// Token: 0x040143DB RID: 82907
		internal static int __PropertyOffset_22;

		// Token: 0x040143DC RID: 82908
		internal static int __PropertyOffset_23;

		// Token: 0x040143DD RID: 82909
		internal static int __PropertyOffset_24;

		// Token: 0x040143DE RID: 82910
		internal static int __PropertyOffset_25;

		// Token: 0x040143DF RID: 82911
		internal static int __PropertyOffset_26;

		// Token: 0x040143E0 RID: 82912
		private static IntPtr __移除材质控制器1和附身特效_NativeFunctionPtr;

		// Token: 0x040143E1 RID: 82913
		private static IntPtr __添加材质控制器1和附身特效_NativeFunctionPtr;

		// Token: 0x040143E2 RID: 82914
		private static IntPtr __移除附身特效_NativeFunctionPtr;

		// Token: 0x040143E3 RID: 82915
		private static IntPtr __添加附身特效_NativeFunctionPtr;

		// Token: 0x040143E4 RID: 82916
		private static IntPtr __更新Dither值_NativeFunctionPtr;

		// Token: 0x040143E5 RID: 82917
		private static IntPtr __减少材质控制1进度_仅Manul类型_NativeFunctionPtr;

		// Token: 0x040143E6 RID: 82918
		private static IntPtr __增加材质控制1进度_仅Manul类型_NativeFunctionPtr;

		// Token: 0x040143E7 RID: 82919
		private static IntPtr __去掉胶囊体Dither_NativeFunctionPtr;

		// Token: 0x040143E8 RID: 82920
		private static IntPtr __添加胶囊体Dither_NativeFunctionPtr;

		// Token: 0x040143E9 RID: 82921
		private static IntPtr __设置浮点数属性_NativeFunctionPtr;

		// Token: 0x040143EA RID: 82922
		private static IntPtr __设置颜色属性_NativeFunctionPtr;

		// Token: 0x040143EB RID: 82923
		private static IntPtr __设置曲线浮点数属性_NativeFunctionPtr;

		// Token: 0x040143EC RID: 82924
		private static IntPtr __设置曲线颜色属性_NativeFunctionPtr;

		// Token: 0x040143ED RID: 82925
		private static IntPtr __初始化_NativeFunctionPtr;

		// Token: 0x040143EE RID: 82926
		private static IntPtr __移除材质控制器1_ToEnd_NativeFunctionPtr;

		// Token: 0x040143EF RID: 82927
		private static IntPtr __移除材质控制器组_NativeFunctionPtr;

		// Token: 0x040143F0 RID: 82928
		private static IntPtr __添加材质控制器组_NativeFunctionPtr;

		// Token: 0x040143F1 RID: 82929
		private static IntPtr __移除所有状态_NativeFunctionPtr;

		// Token: 0x040143F2 RID: 82930
		private static IntPtr __移除材质控制器2_NativeFunctionPtr;

		// Token: 0x040143F3 RID: 82931
		private static IntPtr __添加材质控制器2_NativeFunctionPtr;

		// Token: 0x040143F4 RID: 82932
		private static IntPtr __移除材质控制器1_NativeFunctionPtr;

		// Token: 0x040143F5 RID: 82933
		private static IntPtr __添加材质控制器1_NativeFunctionPtr;

		// Token: 0x040143F6 RID: 82934
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2A2 RID: 41634
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FC6 RID: 204742
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
