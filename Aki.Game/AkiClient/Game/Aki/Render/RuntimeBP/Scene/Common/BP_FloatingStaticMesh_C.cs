using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B5B RID: 15195
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh.BP_FloatingStaticMesh_C")]
	[UnrealStructLayout(2800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2796)]
	public class BP_FloatingStaticMesh_C : AKuroFloatingStaticMesh, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B20 RID: 138016 RVA: 0x008F3528 File Offset: 0x008F1728
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingStaticMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh.BP_FloatingStaticMesh_C");
			}
			return BP_FloatingStaticMesh_C._ClassPtr;
		}

		// Token: 0x06021B21 RID: 138017 RVA: 0x008F354C File Offset: 0x008F174C
		public BP_FloatingStaticMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B22 RID: 138018 RVA: 0x008F3574 File Offset: 0x008F1774
		public BP_FloatingStaticMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingStaticMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x06021B23 RID: 138019 RVA: 0x008F35A7 File Offset: 0x008F17A7
		// (set) Token: 0x06021B24 RID: 138020 RVA: 0x008F35BB File Offset: 0x008F17BB
		[Nullable(2)]
		public unsafe UKuroVirtualAttachmentParentComponent KuroVirtualAttachmentParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVirtualAttachmentParentComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x06021B25 RID: 138021 RVA: 0x008F35D0 File Offset: 0x008F17D0
		// (set) Token: 0x06021B26 RID: 138022 RVA: 0x008F35E4 File Offset: 0x008F17E4
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x06021B27 RID: 138023 RVA: 0x008F35F9 File Offset: 0x008F17F9
		// (set) Token: 0x06021B28 RID: 138024 RVA: 0x008F360D File Offset: 0x008F180D
		[Nullable(2)]
		public unsafe USceneComponent Scene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingStaticMesh_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x06021B29 RID: 138025 RVA: 0x008F3622 File Offset: 0x008F1822
		// (set) Token: 0x06021B2A RID: 138026 RVA: 0x008F3632 File Offset: 0x008F1832
		public unsafe bool 使用材质参数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x06021B2B RID: 138027 RVA: 0x008F3644 File Offset: 0x008F1844
		// (set) Token: 0x06021B2C RID: 138028 RVA: 0x008F367D File Offset: 0x008F187D
		public TMap<FName, float> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x06021B2D RID: 138029 RVA: 0x008F368C File Offset: 0x008F188C
		// (set) Token: 0x06021B2E RID: 138030 RVA: 0x008F36C5 File Offset: 0x008F18C5
		public TMap<FName, FLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x06021B2F RID: 138031 RVA: 0x008F36D3 File Offset: 0x008F18D3
		// (set) Token: 0x06021B30 RID: 138032 RVA: 0x008F36E7 File Offset: 0x008F18E7
		public unsafe FLinearColor EmissionDayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x06021B31 RID: 138033 RVA: 0x008F36FC File Offset: 0x008F18FC
		// (set) Token: 0x06021B32 RID: 138034 RVA: 0x008F3710 File Offset: 0x008F1910
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x06021B33 RID: 138035 RVA: 0x008F3725 File Offset: 0x008F1925
		// (set) Token: 0x06021B34 RID: 138036 RVA: 0x008F3735 File Offset: 0x008F1935
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x06021B35 RID: 138037 RVA: 0x008F3748 File Offset: 0x008F1948
		// (set) Token: 0x06021B36 RID: 138038 RVA: 0x008F3781 File Offset: 0x008F1981
		public TMap<AActor, FTransformDouble> ChildActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, FTransformDouble> result;
				if ((result = this._ChildActors) == null)
				{
					result = (this._ChildActors = new TMap<AActor, FTransformDouble>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.ChildActors.CopyAssign(value);
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x06021B37 RID: 138039 RVA: 0x008F3790 File Offset: 0x008F1990
		// (set) Token: 0x06021B38 RID: 138040 RVA: 0x008F37C9 File Offset: 0x008F19C9
		public TArray<float> CustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x06021B39 RID: 138041 RVA: 0x008F37D7 File Offset: 0x008F19D7
		// (set) Token: 0x06021B3A RID: 138042 RVA: 0x008F37E7 File Offset: 0x008F19E7
		public unsafe bool SpecialBlueprintActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x06021B3B RID: 138043 RVA: 0x008F37F8 File Offset: 0x008F19F8
		// (set) Token: 0x06021B3C RID: 138044 RVA: 0x008F3808 File Offset: 0x008F1A08
		public unsafe bool OverrideSuperFarActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x06021B3D RID: 138045 RVA: 0x008F3819 File Offset: 0x008F1A19
		// (set) Token: 0x06021B3E RID: 138046 RVA: 0x008F3829 File Offset: 0x008F1A29
		public unsafe bool HiddenState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x06021B3F RID: 138047 RVA: 0x008F383A File Offset: 0x008F1A3A
		// (set) Token: 0x06021B40 RID: 138048 RVA: 0x008F384A File Offset: 0x008F1A4A
		public unsafe bool UseWasRecentlyPassVisibilityTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingStaticMesh_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021B41 RID: 138049 RVA: 0x008F385B File Offset: 0x008F1A5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetCustomData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__SetCustomData_NativeFunctionPtr, null);
		}

		// Token: 0x06021B42 RID: 138050 RVA: 0x008F3870 File Offset: 0x008F1A70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyCustomPrimitiveData(UStaticMeshComponent Target)
		{
			BP_FloatingStaticMesh_C.__CopyCustomPrimitiveData_FunctionParams* ptr = stackalloc BP_FloatingStaticMesh_C.__CopyCustomPrimitiveData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FloatingStaticMesh_C.__CopyCustomPrimitiveData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingStaticMesh_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021B43 RID: 138051 RVA: 0x008F38C5 File Offset: 0x008F1AC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshChildActors()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__RefreshChildActors_NativeFunctionPtr, null);
		}

		// Token: 0x06021B44 RID: 138052 RVA: 0x008F38D9 File Offset: 0x008F1AD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__SetMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x06021B45 RID: 138053 RVA: 0x008F38ED File Offset: 0x008F1AED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021B46 RID: 138054 RVA: 0x008F3901 File Offset: 0x008F1B01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B47 RID: 138055 RVA: 0x008F3916 File Offset: 0x008F1B16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021B48 RID: 138056 RVA: 0x008F392A File Offset: 0x008F1B2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingStaticMesh_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021B49 RID: 138057 RVA: 0x008F393F File Offset: 0x008F1B3F
		protected BP_FloatingStaticMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010700 RID: 67328
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_FloatingStaticMesh.BP_FloatingStaticMesh_C";

		// Token: 0x04010701 RID: 67329
		private static IntPtr _ClassPtr;

		// Token: 0x04010702 RID: 67330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010703 RID: 67331
		internal static int __PropertyOffset_1;

		// Token: 0x04010704 RID: 67332
		internal static int __PropertyOffset_2;

		// Token: 0x04010705 RID: 67333
		internal static int __PropertyOffset_3;

		// Token: 0x04010706 RID: 67334
		internal static int __PropertyOffset_4;

		// Token: 0x04010707 RID: 67335
		internal static int __PropertyOffset_5;

		// Token: 0x04010708 RID: 67336
		[Nullable(2)]
		private TMap<FName, float> _FloatParameters;

		// Token: 0x04010709 RID: 67337
		internal static int __PropertyOffset_6;

		// Token: 0x0401070A RID: 67338
		[Nullable(2)]
		private TMap<FName, FLinearColor> _ColorParameters;

		// Token: 0x0401070B RID: 67339
		internal static int __PropertyOffset_7;

		// Token: 0x0401070C RID: 67340
		internal static int __PropertyOffset_8;

		// Token: 0x0401070D RID: 67341
		internal static int __PropertyOffset_9;

		// Token: 0x0401070E RID: 67342
		internal static int __PropertyOffset_10;

		// Token: 0x0401070F RID: 67343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AActor, FTransformDouble> _ChildActors;

		// Token: 0x04010710 RID: 67344
		internal static int __PropertyOffset_11;

		// Token: 0x04010711 RID: 67345
		[Nullable(2)]
		private TArray<float> _CustomData;

		// Token: 0x04010712 RID: 67346
		internal static int __PropertyOffset_12;

		// Token: 0x04010713 RID: 67347
		internal static int __PropertyOffset_13;

		// Token: 0x04010714 RID: 67348
		internal static int __PropertyOffset_14;

		// Token: 0x04010715 RID: 67349
		internal static int __PropertyOffset_15;

		// Token: 0x04010716 RID: 67350
		private static IntPtr __SetCustomData_NativeFunctionPtr;

		// Token: 0x04010717 RID: 67351
		private static IntPtr __CopyCustomPrimitiveData_NativeFunctionPtr;

		// Token: 0x04010718 RID: 67352
		private static IntPtr __RefreshChildActors_NativeFunctionPtr;

		// Token: 0x04010719 RID: 67353
		private static IntPtr __SetMaterialParams_NativeFunctionPtr;

		// Token: 0x0401071A RID: 67354
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401071B RID: 67355
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CC1 RID: 40129
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CopyCustomPrimitiveData_FunctionParams
		{
			// Token: 0x040313A6 RID: 201638
			[FieldOffset(0)]
			public IntPtr Target;
		}
	}
}
