using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B1D RID: 15133
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Sharpen.BP_Sharpen_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1749)]
	public class BP_Sharpen_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602125F RID: 135775 RVA: 0x008E5F40 File Offset: 0x008E4140
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Sharpen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Sharpen.BP_Sharpen_C");
			}
			return BP_Sharpen_C._ClassPtr;
		}

		// Token: 0x06021260 RID: 135776 RVA: 0x008E5F64 File Offset: 0x008E4164
		public BP_Sharpen_C() : this(BuiltinUtils.AllocNativeUObject(BP_Sharpen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021261 RID: 135777 RVA: 0x008E5F8C File Offset: 0x008E418C
		[NullableContext(1)]
		public BP_Sharpen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Sharpen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034A5 RID: 13477
		// (get) Token: 0x06021262 RID: 135778 RVA: 0x008E5FBF File Offset: 0x008E41BF
		// (set) Token: 0x06021263 RID: 135779 RVA: 0x008E5FD3 File Offset: 0x008E41D3
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170034A6 RID: 13478
		// (get) Token: 0x06021264 RID: 135780 RVA: 0x008E5FE8 File Offset: 0x008E41E8
		// (set) Token: 0x06021265 RID: 135781 RVA: 0x008E5FFC File Offset: 0x008E41FC
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170034A7 RID: 13479
		// (get) Token: 0x06021266 RID: 135782 RVA: 0x008E6011 File Offset: 0x008E4211
		// (set) Token: 0x06021267 RID: 135783 RVA: 0x008E6025 File Offset: 0x008E4225
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x06021268 RID: 135784 RVA: 0x008E603A File Offset: 0x008E423A
		// (set) Token: 0x06021269 RID: 135785 RVA: 0x008E604E File Offset: 0x008E424E
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0602126A RID: 135786 RVA: 0x008E6064 File Offset: 0x008E4264
		// (set) Token: 0x0602126B RID: 135787 RVA: 0x008E609D File Offset: 0x008E429D
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0602126C RID: 135788 RVA: 0x008E60AC File Offset: 0x008E42AC
		// (set) Token: 0x0602126D RID: 135789 RVA: 0x008E60E5 File Offset: 0x008E42E5
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0602126E RID: 135790 RVA: 0x008E60F4 File Offset: 0x008E42F4
		// (set) Token: 0x0602126F RID: 135791 RVA: 0x008E612D File Offset: 0x008E432D
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x06021270 RID: 135792 RVA: 0x008E613B File Offset: 0x008E433B
		// (set) Token: 0x06021271 RID: 135793 RVA: 0x008E614F File Offset: 0x008E434F
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Sharpen_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x06021272 RID: 135794 RVA: 0x008E6164 File Offset: 0x008E4364
		// (set) Token: 0x06021273 RID: 135795 RVA: 0x008E6174 File Offset: 0x008E4374
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x06021274 RID: 135796 RVA: 0x008E6185 File Offset: 0x008E4385
		// (set) Token: 0x06021275 RID: 135797 RVA: 0x008E6195 File Offset: 0x008E4395
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x06021276 RID: 135798 RVA: 0x008E61A6 File Offset: 0x008E43A6
		// (set) Token: 0x06021277 RID: 135799 RVA: 0x008E61B6 File Offset: 0x008E43B6
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x06021278 RID: 135800 RVA: 0x008E61C7 File Offset: 0x008E43C7
		// (set) Token: 0x06021279 RID: 135801 RVA: 0x008E61D7 File Offset: 0x008E43D7
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Sharpen_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602127A RID: 135802 RVA: 0x008E61E8 File Offset: 0x008E43E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602127B RID: 135803 RVA: 0x008E61FC File Offset: 0x008E43FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602127C RID: 135804 RVA: 0x008E6210 File Offset: 0x008E4410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Sharpen_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602127D RID: 135805 RVA: 0x008E6225 File Offset: 0x008E4425
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602127E RID: 135806 RVA: 0x008E6239 File Offset: 0x008E4439
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602127F RID: 135807 RVA: 0x008E6250 File Offset: 0x008E4450
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Sharpen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Sharpen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Sharpen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Sharpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021280 RID: 135808 RVA: 0x008E6298 File Offset: 0x008E4498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Sharpen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Sharpen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Sharpen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Sharpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021281 RID: 135809 RVA: 0x008E62DF File Offset: 0x008E44DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06021282 RID: 135810 RVA: 0x008E62F3 File Offset: 0x008E44F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Sharpen_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021283 RID: 135811 RVA: 0x008E6308 File Offset: 0x008E4508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Sharpen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Sharpen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Sharpen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Sharpen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Sharpen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021284 RID: 135812 RVA: 0x008E6350 File Offset: 0x008E4550
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Sharpen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Sharpen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Sharpen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Sharpen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Sharpen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021285 RID: 135813 RVA: 0x008E6397 File Offset: 0x008E4597
		protected BP_Sharpen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401021B RID: 66075
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Sharpen.BP_Sharpen_C";

		// Token: 0x0401021C RID: 66076
		private static IntPtr _ClassPtr;

		// Token: 0x0401021D RID: 66077
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401021E RID: 66078
		internal static int __PropertyOffset_1;

		// Token: 0x0401021F RID: 66079
		internal static int __PropertyOffset_2;

		// Token: 0x04010220 RID: 66080
		internal static int __PropertyOffset_3;

		// Token: 0x04010221 RID: 66081
		internal static int __PropertyOffset_4;

		// Token: 0x04010222 RID: 66082
		internal static int __PropertyOffset_5;

		// Token: 0x04010223 RID: 66083
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010224 RID: 66084
		internal static int __PropertyOffset_6;

		// Token: 0x04010225 RID: 66085
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04010226 RID: 66086
		internal static int __PropertyOffset_7;

		// Token: 0x04010227 RID: 66087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010228 RID: 66088
		internal static int __PropertyOffset_8;

		// Token: 0x04010229 RID: 66089
		internal static int __PropertyOffset_9;

		// Token: 0x0401022A RID: 66090
		internal static int __PropertyOffset_10;

		// Token: 0x0401022B RID: 66091
		internal static int __PropertyOffset_11;

		// Token: 0x0401022C RID: 66092
		internal static int __PropertyOffset_12;

		// Token: 0x0401022D RID: 66093
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0401022E RID: 66094
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401022F RID: 66095
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010230 RID: 66096
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010231 RID: 66097
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04010232 RID: 66098
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C74 RID: 40052
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031332 RID: 201522
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C75 RID: 40053
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031333 RID: 201523
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
