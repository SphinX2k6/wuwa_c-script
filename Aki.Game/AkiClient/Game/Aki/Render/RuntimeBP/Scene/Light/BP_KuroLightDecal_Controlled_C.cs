using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B0C RID: 15116
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Controlled.BP_KuroLightDecal_Controlled_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_KuroLightDecal_Controlled_C : AKuroLightActorBase, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020F1A RID: 134938 RVA: 0x008E0D58 File Offset: 0x008DEF58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroLightDecal_Controlled_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Controlled.BP_KuroLightDecal_Controlled_C");
			}
			return BP_KuroLightDecal_Controlled_C._ClassPtr;
		}

		// Token: 0x06020F1B RID: 134939 RVA: 0x008E0D7C File Offset: 0x008DEF7C
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroLightDecal_Controlled_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020F1C RID: 134940 RVA: 0x008E0D84 File Offset: 0x008DEF84
		public BP_KuroLightDecal_Controlled_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Controlled_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F1D RID: 134941 RVA: 0x008E0DAC File Offset: 0x008DEFAC
		[NullableContext(1)]
		public BP_KuroLightDecal_Controlled_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroLightDecal_Controlled_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x06020F1E RID: 134942 RVA: 0x008E0DDF File Offset: 0x008DEFDF
		// (set) Token: 0x06020F1F RID: 134943 RVA: 0x008E0DF3 File Offset: 0x008DEFF3
		public unsafe UBillboardComponent Sprite1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x06020F20 RID: 134944 RVA: 0x008E0E08 File Offset: 0x008DF008
		// (set) Token: 0x06020F21 RID: 134945 RVA: 0x008E0E1C File Offset: 0x008DF01C
		public unsafe UArrowComponent ArrowComponent1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x06020F22 RID: 134946 RVA: 0x008E0E31 File Offset: 0x008DF031
		// (set) Token: 0x06020F23 RID: 134947 RVA: 0x008E0E45 File Offset: 0x008DF045
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x06020F24 RID: 134948 RVA: 0x008E0E5A File Offset: 0x008DF05A
		// (set) Token: 0x06020F25 RID: 134949 RVA: 0x008E0E6A File Offset: 0x008DF06A
		public unsafe float FadeScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroLightDecal_Controlled_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroLightDecal_Controlled_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x06020F26 RID: 134950 RVA: 0x008E0E7B File Offset: 0x008DF07B
		// (set) Token: 0x06020F27 RID: 134951 RVA: 0x008E0E8F File Offset: 0x008DF08F
		public unsafe UMaterialInstanceConstant DecalMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceConstant>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroLightDecal_Controlled_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x06020F28 RID: 134952 RVA: 0x008E0EA4 File Offset: 0x008DF0A4
		// (set) Token: 0x06020F29 RID: 134953 RVA: 0x008E0EDD File Offset: 0x008DF0DD
		[Nullable(1)]
		public TMap<FName, float> Scalars
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalars) == null)
				{
					result = (this._Scalars = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Controlled_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalars.CopyAssign(value);
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x06020F2A RID: 134954 RVA: 0x008E0EEC File Offset: 0x008DF0EC
		// (set) Token: 0x06020F2B RID: 134955 RVA: 0x008E0F25 File Offset: 0x008DF125
		[Nullable(1)]
		public TMap<FName, UTexture> Textures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Textures) == null)
				{
					result = (this._Textures = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Controlled_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Textures.CopyAssign(value);
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x06020F2C RID: 134956 RVA: 0x008E0F34 File Offset: 0x008DF134
		// (set) Token: 0x06020F2D RID: 134957 RVA: 0x008E0F6D File Offset: 0x008DF16D
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vectors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroLightDecal_Controlled_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x06020F2E RID: 134958 RVA: 0x008E0F7C File Offset: 0x008DF17C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020F2F RID: 134959 RVA: 0x008E0FC4 File Offset: 0x008DF1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06020F30 RID: 134960 RVA: 0x008E100A File Offset: 0x008DF20A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void updateMaterialParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__updateMaterialParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06020F31 RID: 134961 RVA: 0x008E101E File Offset: 0x008DF21E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020F32 RID: 134962 RVA: 0x008E1032 File Offset: 0x008DF232
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020F33 RID: 134963 RVA: 0x008E1048 File Offset: 0x008DF248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetLightIntensityScale(float ScaleFactor)
		{
			BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F34 RID: 134964 RVA: 0x008E1090 File Offset: 0x008DF290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void SetLightIntensityScale_Implementation(float ScaleFactor)
		{
			BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams* ptr = stackalloc BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScaleFactor = ScaleFactor;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroLightDecal_Controlled_C.__SetLightIntensityScale_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020F35 RID: 134965 RVA: 0x008E10D7 File Offset: 0x008DF2D7
		protected BP_KuroLightDecal_Controlled_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010039 RID: 65593
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x0401003A RID: 65594
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_KuroLightDecal_Controlled.BP_KuroLightDecal_Controlled_C";

		// Token: 0x0401003B RID: 65595
		private static IntPtr _ClassPtr;

		// Token: 0x0401003C RID: 65596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401003D RID: 65597
		internal static int __PropertyOffset_1;

		// Token: 0x0401003E RID: 65598
		internal static int __PropertyOffset_2;

		// Token: 0x0401003F RID: 65599
		internal static int __PropertyOffset_3;

		// Token: 0x04010040 RID: 65600
		internal static int __PropertyOffset_4;

		// Token: 0x04010041 RID: 65601
		internal static int __PropertyOffset_5;

		// Token: 0x04010042 RID: 65602
		internal static int __PropertyOffset_6;

		// Token: 0x04010043 RID: 65603
		private TMap<FName, float> _Scalars;

		// Token: 0x04010044 RID: 65604
		internal static int __PropertyOffset_7;

		// Token: 0x04010045 RID: 65605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Textures;

		// Token: 0x04010046 RID: 65606
		internal static int __PropertyOffset_8;

		// Token: 0x04010047 RID: 65607
		private TMap<FName, FLinearColor> _Vectors;

		// Token: 0x04010048 RID: 65608
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04010049 RID: 65609
		private static IntPtr __updateMaterialParameters_NativeFunctionPtr;

		// Token: 0x0401004A RID: 65610
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401004B RID: 65611
		private static IntPtr __SetLightIntensityScale_NativeFunctionPtr;

		// Token: 0x02009C50 RID: 40016
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031304 RID: 201476
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C51 RID: 40017
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __SetLightIntensityScale_FunctionParams
		{
			// Token: 0x04031305 RID: 201477
			[FieldOffset(0)]
			public float ScaleFactor;
		}
	}
}
