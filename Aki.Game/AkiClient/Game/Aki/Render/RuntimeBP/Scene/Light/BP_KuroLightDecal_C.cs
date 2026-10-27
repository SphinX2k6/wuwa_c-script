using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0A RID: 15114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal.BP_KuroLightDecal_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_KuroLightDecal_C : ADecalActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020EFA RID: 134906 RVA: 0x008E09CB File Offset: 0x008DEBCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroLightDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal.BP_KuroLightDecal_C");
			}
			return BP_KuroLightDecal_C._ClassPtr;
		}

		// Token: 0x06020EFB RID: 134907 RVA: 0x008E09EF File Offset: 0x008DEBEF
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroLightDecal_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020EFC RID: 134908 RVA: 0x008E09F8 File Offset: 0x008DEBF8
		public BP_KuroLightDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020EFD RID: 134909 RVA: 0x008E0A20 File Offset: 0x008DEC20
		public BP_KuroLightDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x06020EFE RID: 134910 RVA: 0x008E0A53 File Offset: 0x008DEC53
		// (set) Token: 0x06020EFF RID: 134911 RVA: 0x008E0A63 File Offset: 0x008DEC63
		public unsafe float FadeScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x06020F00 RID: 134912 RVA: 0x008E0A74 File Offset: 0x008DEC74
		// (set) Token: 0x06020F01 RID: 134913 RVA: 0x008E0A88 File Offset: 0x008DEC88
		[Nullable(2)]
		public unsafe UMaterialInstanceConstant DecalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x06020F02 RID: 134914 RVA: 0x008E0AA0 File Offset: 0x008DECA0
		// (set) Token: 0x06020F03 RID: 134915 RVA: 0x008E0AD9 File Offset: 0x008DECD9
		public TMap<FName, float> Scalars
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalars) == null)
				{
					result = (this._Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.Scalars.CopyAssign(value);
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x06020F04 RID: 134916 RVA: 0x008E0AE8 File Offset: 0x008DECE8
		// (set) Token: 0x06020F05 RID: 134917 RVA: 0x008E0B21 File Offset: 0x008DED21
		public TMap<FName, UTexture> Textures
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x06020F06 RID: 134918 RVA: 0x008E0B30 File Offset: 0x008DED30
		// (set) Token: 0x06020F07 RID: 134919 RVA: 0x008E0B69 File Offset: 0x008DED69
		public TMap<FName, FLinearColor> Vectors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x06020F08 RID: 134920 RVA: 0x008E0B77 File Offset: 0x008DED77
		// (set) Token: 0x06020F09 RID: 134921 RVA: 0x008E0B87 File Offset: 0x008DED87
		public unsafe float 最小显示距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x06020F0A RID: 134922 RVA: 0x008E0B98 File Offset: 0x008DED98
		// (set) Token: 0x06020F0B RID: 134923 RVA: 0x008E0BA8 File Offset: 0x008DEDA8
		public unsafe float 最大显示距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x06020F0C RID: 134924 RVA: 0x008E0BB9 File Offset: 0x008DEDB9
		// (set) Token: 0x06020F0D RID: 134925 RVA: 0x008E0BC9 File Offset: 0x008DEDC9
		public unsafe float 最小Fade距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x06020F0E RID: 134926 RVA: 0x008E0BDA File Offset: 0x008DEDDA
		// (set) Token: 0x06020F0F RID: 134927 RVA: 0x008E0BEA File Offset: 0x008DEDEA
		public unsafe float 最大Fade距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06020F10 RID: 134928 RVA: 0x008E0BFC File Offset: 0x008DEDFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020F11 RID: 134929 RVA: 0x008E0C44 File Offset: 0x008DEE44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020F12 RID: 134930 RVA: 0x008E0C8A File Offset: 0x008DEE8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void updateMaterialParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_C.__updateMaterialParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06020F13 RID: 134931 RVA: 0x008E0C9E File Offset: 0x008DEE9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020F14 RID: 134932 RVA: 0x008E0CB2 File Offset: 0x008DEEB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020F15 RID: 134933 RVA: 0x008E0CC7 File Offset: 0x008DEEC7
		protected BP_KuroLightDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010023 RID: 65571
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010024 RID: 65572
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal.BP_KuroLightDecal_C";

		// Token: 0x04010025 RID: 65573
		private static IntPtr _ClassPtr;

		// Token: 0x04010026 RID: 65574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010027 RID: 65575
		internal static int __PropertyOffset_0;

		// Token: 0x04010028 RID: 65576
		internal static int __PropertyOffset_1;

		// Token: 0x04010029 RID: 65577
		internal static int __PropertyOffset_2;

		// Token: 0x0401002A RID: 65578
		[Nullable(2)]
		private TMap<FName, float> _Scalars;

		// Token: 0x0401002B RID: 65579
		internal static int __PropertyOffset_3;

		// Token: 0x0401002C RID: 65580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Textures;

		// Token: 0x0401002D RID: 65581
		internal static int __PropertyOffset_4;

		// Token: 0x0401002E RID: 65582
		[Nullable(2)]
		private TMap<FName, FLinearColor> _Vectors;

		// Token: 0x0401002F RID: 65583
		internal static int __PropertyOffset_5;

		// Token: 0x04010030 RID: 65584
		internal static int __PropertyOffset_6;

		// Token: 0x04010031 RID: 65585
		internal static int __PropertyOffset_7;

		// Token: 0x04010032 RID: 65586
		internal static int __PropertyOffset_8;

		// Token: 0x04010033 RID: 65587
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04010034 RID: 65588
		private static IntPtr __updateMaterialParameters_NativeFunctionPtr;

		// Token: 0x04010035 RID: 65589
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009C4F RID: 40015
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031303 RID: 201475
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
