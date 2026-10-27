using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2E RID: 15150
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_WaterRadius.BP_WaterRadius_C")]
	[UnrealStructLayout(1776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1772)]
	public class BP_WaterRadius_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021765 RID: 137061 RVA: 0x008ECFA8 File Offset: 0x008EB1A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterRadius_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_WaterRadius.BP_WaterRadius_C");
			}
			return BP_WaterRadius_C._ClassPtr;
		}

		// Token: 0x06021766 RID: 137062 RVA: 0x008ECFCC File Offset: 0x008EB1CC
		public BP_WaterRadius_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterRadius_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021767 RID: 137063 RVA: 0x008ECFF4 File Offset: 0x008EB1F4
		[NullableContext(1)]
		public BP_WaterRadius_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterRadius_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x06021768 RID: 137064 RVA: 0x008ED027 File Offset: 0x008EB227
		// (set) Token: 0x06021769 RID: 137065 RVA: 0x008ED03B File Offset: 0x008EB23B
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0602176A RID: 137066 RVA: 0x008ED050 File Offset: 0x008EB250
		// (set) Token: 0x0602176B RID: 137067 RVA: 0x008ED064 File Offset: 0x008EB264
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0602176C RID: 137068 RVA: 0x008ED079 File Offset: 0x008EB279
		// (set) Token: 0x0602176D RID: 137069 RVA: 0x008ED08D File Offset: 0x008EB28D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0602176E RID: 137070 RVA: 0x008ED0A2 File Offset: 0x008EB2A2
		// (set) Token: 0x0602176F RID: 137071 RVA: 0x008ED0B6 File Offset: 0x008EB2B6
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x06021770 RID: 137072 RVA: 0x008ED0CC File Offset: 0x008EB2CC
		// (set) Token: 0x06021771 RID: 137073 RVA: 0x008ED105 File Offset: 0x008EB305
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x06021772 RID: 137074 RVA: 0x008ED114 File Offset: 0x008EB314
		// (set) Token: 0x06021773 RID: 137075 RVA: 0x008ED14D File Offset: 0x008EB34D
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x06021774 RID: 137076 RVA: 0x008ED15C File Offset: 0x008EB35C
		// (set) Token: 0x06021775 RID: 137077 RVA: 0x008ED195 File Offset: 0x008EB395
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x06021776 RID: 137078 RVA: 0x008ED1A3 File Offset: 0x008EB3A3
		// (set) Token: 0x06021777 RID: 137079 RVA: 0x008ED1B7 File Offset: 0x008EB3B7
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterRadius_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x06021778 RID: 137080 RVA: 0x008ED1CC File Offset: 0x008EB3CC
		// (set) Token: 0x06021779 RID: 137081 RVA: 0x008ED1DC File Offset: 0x008EB3DC
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0602177A RID: 137082 RVA: 0x008ED1ED File Offset: 0x008EB3ED
		// (set) Token: 0x0602177B RID: 137083 RVA: 0x008ED201 File Offset: 0x008EB401
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0602177C RID: 137084 RVA: 0x008ED216 File Offset: 0x008EB416
		// (set) Token: 0x0602177D RID: 137085 RVA: 0x008ED226 File Offset: 0x008EB426
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0602177E RID: 137086 RVA: 0x008ED237 File Offset: 0x008EB437
		// (set) Token: 0x0602177F RID: 137087 RVA: 0x008ED247 File Offset: 0x008EB447
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x06021780 RID: 137088 RVA: 0x008ED258 File Offset: 0x008EB458
		// (set) Token: 0x06021781 RID: 137089 RVA: 0x008ED268 File Offset: 0x008EB468
		public unsafe float Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x06021782 RID: 137090 RVA: 0x008ED279 File Offset: 0x008EB479
		// (set) Token: 0x06021783 RID: 137091 RVA: 0x008ED289 File Offset: 0x008EB489
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterRadius_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06021784 RID: 137092 RVA: 0x008ED29A File Offset: 0x008EB49A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06021785 RID: 137093 RVA: 0x008ED2AE File Offset: 0x008EB4AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021786 RID: 137094 RVA: 0x008ED2C2 File Offset: 0x008EB4C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRadius_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x008ED2D7 File Offset: 0x008EB4D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021788 RID: 137096 RVA: 0x008ED2EB File Offset: 0x008EB4EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021789 RID: 137097 RVA: 0x008ED300 File Offset: 0x008EB500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterRadius_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterRadius_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRadius_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRadius_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602178A RID: 137098 RVA: 0x008ED348 File Offset: 0x008EB548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterRadius_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterRadius_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRadius_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRadius_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602178B RID: 137099 RVA: 0x008ED38F File Offset: 0x008EB58F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602178C RID: 137100 RVA: 0x008ED3A3 File Offset: 0x008EB5A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRadius_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602178D RID: 137101 RVA: 0x008ED3B8 File Offset: 0x008EB5B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_WaterRadius_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WaterRadius_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRadius_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRadius_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterRadius_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602178E RID: 137102 RVA: 0x008ED400 File Offset: 0x008EB600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_WaterRadius_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WaterRadius_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterRadius_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterRadius_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterRadius_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602178F RID: 137103 RVA: 0x008ED447 File Offset: 0x008EB647
		protected BP_WaterRadius_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104D2 RID: 66770
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_WaterRadius.BP_WaterRadius_C";

		// Token: 0x040104D3 RID: 66771
		private static IntPtr _ClassPtr;

		// Token: 0x040104D4 RID: 66772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104D5 RID: 66773
		internal static int __PropertyOffset_1;

		// Token: 0x040104D6 RID: 66774
		internal static int __PropertyOffset_2;

		// Token: 0x040104D7 RID: 66775
		internal static int __PropertyOffset_3;

		// Token: 0x040104D8 RID: 66776
		internal static int __PropertyOffset_4;

		// Token: 0x040104D9 RID: 66777
		internal static int __PropertyOffset_5;

		// Token: 0x040104DA RID: 66778
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x040104DB RID: 66779
		internal static int __PropertyOffset_6;

		// Token: 0x040104DC RID: 66780
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x040104DD RID: 66781
		internal static int __PropertyOffset_7;

		// Token: 0x040104DE RID: 66782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x040104DF RID: 66783
		internal static int __PropertyOffset_8;

		// Token: 0x040104E0 RID: 66784
		internal static int __PropertyOffset_9;

		// Token: 0x040104E1 RID: 66785
		internal static int __PropertyOffset_10;

		// Token: 0x040104E2 RID: 66786
		internal static int __PropertyOffset_11;

		// Token: 0x040104E3 RID: 66787
		internal static int __PropertyOffset_12;

		// Token: 0x040104E4 RID: 66788
		internal static int __PropertyOffset_13;

		// Token: 0x040104E5 RID: 66789
		internal static int __PropertyOffset_14;

		// Token: 0x040104E6 RID: 66790
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x040104E7 RID: 66791
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040104E8 RID: 66792
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040104E9 RID: 66793
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040104EA RID: 66794
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x040104EB RID: 66795
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C94 RID: 40084
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031352 RID: 201554
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C95 RID: 40085
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031353 RID: 201555
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
