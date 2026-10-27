using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AF6 RID: 15094
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_BackGroundDark.BP_BackGroundDark_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1762)]
	public class BP_BackGroundDark_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B15 RID: 133909 RVA: 0x008DAAAA File Offset: 0x008D8CAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BackGroundDark_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_BackGroundDark.BP_BackGroundDark_C");
			}
			return BP_BackGroundDark_C._ClassPtr;
		}

		// Token: 0x06020B16 RID: 133910 RVA: 0x008DAAD0 File Offset: 0x008D8CD0
		public BP_BackGroundDark_C() : this(BuiltinUtils.AllocNativeUObject(BP_BackGroundDark_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B17 RID: 133911 RVA: 0x008DAAF8 File Offset: 0x008D8CF8
		[NullableContext(1)]
		public BP_BackGroundDark_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BackGroundDark_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x06020B18 RID: 133912 RVA: 0x008DAB2B File Offset: 0x008D8D2B
		// (set) Token: 0x06020B19 RID: 133913 RVA: 0x008DAB3F File Offset: 0x008D8D3F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x06020B1A RID: 133914 RVA: 0x008DAB54 File Offset: 0x008D8D54
		// (set) Token: 0x06020B1B RID: 133915 RVA: 0x008DAB68 File Offset: 0x008D8D68
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x06020B1C RID: 133916 RVA: 0x008DAB7D File Offset: 0x008D8D7D
		// (set) Token: 0x06020B1D RID: 133917 RVA: 0x008DAB91 File Offset: 0x008D8D91
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x06020B1E RID: 133918 RVA: 0x008DABA8 File Offset: 0x008D8DA8
		// (set) Token: 0x06020B1F RID: 133919 RVA: 0x008DABE1 File Offset: 0x008D8DE1
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x06020B20 RID: 133920 RVA: 0x008DABF0 File Offset: 0x008D8DF0
		// (set) Token: 0x06020B21 RID: 133921 RVA: 0x008DAC29 File Offset: 0x008D8E29
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x06020B22 RID: 133922 RVA: 0x008DAC38 File Offset: 0x008D8E38
		// (set) Token: 0x06020B23 RID: 133923 RVA: 0x008DAC71 File Offset: 0x008D8E71
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x06020B24 RID: 133924 RVA: 0x008DAC7F File Offset: 0x008D8E7F
		// (set) Token: 0x06020B25 RID: 133925 RVA: 0x008DAC93 File Offset: 0x008D8E93
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BackGroundDark_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x06020B26 RID: 133926 RVA: 0x008DACA8 File Offset: 0x008D8EA8
		// (set) Token: 0x06020B27 RID: 133927 RVA: 0x008DACB8 File Offset: 0x008D8EB8
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x06020B28 RID: 133928 RVA: 0x008DACC9 File Offset: 0x008D8EC9
		// (set) Token: 0x06020B29 RID: 133929 RVA: 0x008DACDD File Offset: 0x008D8EDD
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x06020B2A RID: 133930 RVA: 0x008DACF2 File Offset: 0x008D8EF2
		// (set) Token: 0x06020B2B RID: 133931 RVA: 0x008DAD02 File Offset: 0x008D8F02
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x06020B2C RID: 133932 RVA: 0x008DAD13 File Offset: 0x008D8F13
		// (set) Token: 0x06020B2D RID: 133933 RVA: 0x008DAD23 File Offset: 0x008D8F23
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x06020B2E RID: 133934 RVA: 0x008DAD34 File Offset: 0x008D8F34
		// (set) Token: 0x06020B2F RID: 133935 RVA: 0x008DAD44 File Offset: 0x008D8F44
		public unsafe float Depth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x06020B30 RID: 133936 RVA: 0x008DAD55 File Offset: 0x008D8F55
		// (set) Token: 0x06020B31 RID: 133937 RVA: 0x008DAD65 File Offset: 0x008D8F65
		public unsafe bool AfterTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x06020B32 RID: 133938 RVA: 0x008DAD76 File Offset: 0x008D8F76
		// (set) Token: 0x06020B33 RID: 133939 RVA: 0x008DAD86 File Offset: 0x008D8F86
		public unsafe bool bMobileDisable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BackGroundDark_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020B34 RID: 133940 RVA: 0x008DAD97 File Offset: 0x008D8F97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020B35 RID: 133941 RVA: 0x008DADAB File Offset: 0x008D8FAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020B36 RID: 133942 RVA: 0x008DADBF File Offset: 0x008D8FBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BackGroundDark_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B37 RID: 133943 RVA: 0x008DADD4 File Offset: 0x008D8FD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020B38 RID: 133944 RVA: 0x008DADE8 File Offset: 0x008D8FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B39 RID: 133945 RVA: 0x008DAE00 File Offset: 0x008D9000
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BackGroundDark_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BackGroundDark_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BackGroundDark_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BackGroundDark_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B3A RID: 133946 RVA: 0x008DAE48 File Offset: 0x008D9048
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BackGroundDark_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BackGroundDark_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BackGroundDark_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BackGroundDark_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B3B RID: 133947 RVA: 0x008DAE8F File Offset: 0x008D908F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020B3C RID: 133948 RVA: 0x008DAEA3 File Offset: 0x008D90A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BackGroundDark_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B3D RID: 133949 RVA: 0x008DAEB8 File Offset: 0x008D90B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_BackGroundDark_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BackGroundDark_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BackGroundDark_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BackGroundDark_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BackGroundDark_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B3E RID: 133950 RVA: 0x008DAF00 File Offset: 0x008D9100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_BackGroundDark_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BackGroundDark_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BackGroundDark_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BackGroundDark_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BackGroundDark_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B3F RID: 133951 RVA: 0x008DAF47 File Offset: 0x008D9147
		protected BP_BackGroundDark_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDF6 RID: 65014
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_BackGroundDark.BP_BackGroundDark_C";

		// Token: 0x0400FDF7 RID: 65015
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDF8 RID: 65016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDF9 RID: 65017
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDFA RID: 65018
		internal static int __PropertyOffset_2;

		// Token: 0x0400FDFB RID: 65019
		internal static int __PropertyOffset_3;

		// Token: 0x0400FDFC RID: 65020
		internal static int __PropertyOffset_4;

		// Token: 0x0400FDFD RID: 65021
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FDFE RID: 65022
		internal static int __PropertyOffset_5;

		// Token: 0x0400FDFF RID: 65023
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FE00 RID: 65024
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE01 RID: 65025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FE02 RID: 65026
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE03 RID: 65027
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE04 RID: 65028
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE05 RID: 65029
		internal static int __PropertyOffset_10;

		// Token: 0x0400FE06 RID: 65030
		internal static int __PropertyOffset_11;

		// Token: 0x0400FE07 RID: 65031
		internal static int __PropertyOffset_12;

		// Token: 0x0400FE08 RID: 65032
		internal static int __PropertyOffset_13;

		// Token: 0x0400FE09 RID: 65033
		internal static int __PropertyOffset_14;

		// Token: 0x0400FE0A RID: 65034
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FE0B RID: 65035
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE0C RID: 65036
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE0D RID: 65037
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE0E RID: 65038
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FE0F RID: 65039
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C27 RID: 39975
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312D7 RID: 201431
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C28 RID: 39976
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312D8 RID: 201432
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
