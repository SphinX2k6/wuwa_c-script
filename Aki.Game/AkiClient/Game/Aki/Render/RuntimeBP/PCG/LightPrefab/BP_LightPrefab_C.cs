using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab.Struction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.LightPrefab
{
	// Token: 0x02003C6A RID: 15466
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/BP_LightPrefab.BP_LightPrefab_C")]
	[UnrealStructLayout(5040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5033)]
	public class BP_LightPrefab_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023DA9 RID: 146857 RVA: 0x0092EE3E File Offset: 0x0092D03E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightPrefab_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/BP_LightPrefab.BP_LightPrefab_C");
			}
			return BP_LightPrefab_C._ClassPtr;
		}

		// Token: 0x06023DAA RID: 146858 RVA: 0x0092EE64 File Offset: 0x0092D064
		public BP_LightPrefab_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightPrefab_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023DAB RID: 146859 RVA: 0x0092EE8C File Offset: 0x0092D08C
		public BP_LightPrefab_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightPrefab_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x06023DAC RID: 146860 RVA: 0x0092EEBF File Offset: 0x0092D0BF
		// (set) Token: 0x06023DAD RID: 146861 RVA: 0x0092EED3 File Offset: 0x0092D0D3
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x06023DAE RID: 146862 RVA: 0x0092EEE8 File Offset: 0x0092D0E8
		// (set) Token: 0x06023DAF RID: 146863 RVA: 0x0092EEFC File Offset: 0x0092D0FC
		[Nullable(2)]
		public unsafe UArrowComponent LightPrefabArrow
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x06023DB0 RID: 146864 RVA: 0x0092EF11 File Offset: 0x0092D111
		// (set) Token: 0x06023DB1 RID: 146865 RVA: 0x0092EF25 File Offset: 0x0092D125
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x06023DB2 RID: 146866 RVA: 0x0092EF3A File Offset: 0x0092D13A
		// (set) Token: 0x06023DB3 RID: 146867 RVA: 0x0092EF4A File Offset: 0x0092D14A
		public unsafe bool 工具同步
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x06023DB4 RID: 146868 RVA: 0x0092EF5B File Offset: 0x0092D15B
		// (set) Token: 0x06023DB5 RID: 146869 RVA: 0x0092EF6B File Offset: 0x0092D16B
		public unsafe bool TOD同步
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x06023DB6 RID: 146870 RVA: 0x0092EF7C File Offset: 0x0092D17C
		// (set) Token: 0x06023DB7 RID: 146871 RVA: 0x0092EF8C File Offset: 0x0092D18C
		public unsafe float TOD同步频率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x06023DB8 RID: 146872 RVA: 0x0092EFA0 File Offset: 0x0092D1A0
		// (set) Token: 0x06023DB9 RID: 146873 RVA: 0x0092EFD9 File Offset: 0x0092D1D9
		public PCG_LightPrefab_Light 灯光
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Light result;
				if ((result = this._灯光) == null)
				{
					result = (this._灯光 = new PCG_LightPrefab_Light(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Light.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x06023DBA RID: 146874 RVA: 0x0092EFFC File Offset: 0x0092D1FC
		// (set) Token: 0x06023DBB RID: 146875 RVA: 0x0092F035 File Offset: 0x0092D235
		public PCG_LightPrefab_Mesh 模型
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Mesh result;
				if ((result = this._模型) == null)
				{
					result = (this._模型 = new PCG_LightPrefab_Mesh(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Mesh.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x06023DBC RID: 146876 RVA: 0x0092F058 File Offset: 0x0092D258
		// (set) Token: 0x06023DBD RID: 146877 RVA: 0x0092F091 File Offset: 0x0092D291
		public PCG_LightPrefab_Decal 贴花
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Decal result;
				if ((result = this._贴花) == null)
				{
					result = (this._贴花 = new PCG_LightPrefab_Decal(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Decal.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x06023DBE RID: 146878 RVA: 0x0092F0B4 File Offset: 0x0092D2B4
		// (set) Token: 0x06023DBF RID: 146879 RVA: 0x0092F0ED File Offset: 0x0092D2ED
		public PCG_LightPrefab_Fog 雾效
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Fog result;
				if ((result = this._雾效) == null)
				{
					result = (this._雾效 = new PCG_LightPrefab_Fog(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Fog.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x06023DC0 RID: 146880 RVA: 0x0092F110 File Offset: 0x0092D310
		// (set) Token: 0x06023DC1 RID: 146881 RVA: 0x0092F149 File Offset: 0x0092D349
		public PCG_LightPrefab_Effect 特效
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Effect result;
				if ((result = this._特效) == null)
				{
					result = (this._特效 = new PCG_LightPrefab_Effect(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Effect.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x06023DC2 RID: 146882 RVA: 0x0092F16C File Offset: 0x0092D36C
		// (set) Token: 0x06023DC3 RID: 146883 RVA: 0x0092F1A5 File Offset: 0x0092D3A5
		public PCG_LightPrefab_Swing 摆动
		{
			get
			{
				base.FastCheckIsValid();
				PCG_LightPrefab_Swing result;
				if ((result = this._摆动) == null)
				{
					result = (this._摆动 = new PCG_LightPrefab_Swing(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(PCG_LightPrefab_Swing.StaticStruct(), base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x06023DC4 RID: 146884 RVA: 0x0092F1C6 File Offset: 0x0092D3C6
		// (set) Token: 0x06023DC5 RID: 146885 RVA: 0x0092F1DA File Offset: 0x0092D3DA
		[Nullable(2)]
		public unsafe BP_GlobalGI_C GlobalGIActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x06023DC6 RID: 146886 RVA: 0x0092F1EF File Offset: 0x0092D3EF
		// (set) Token: 0x06023DC7 RID: 146887 RVA: 0x0092F1FF File Offset: 0x0092D3FF
		public unsafe float GlobalTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x06023DC8 RID: 146888 RVA: 0x0092F210 File Offset: 0x0092D410
		// (set) Token: 0x06023DC9 RID: 146889 RVA: 0x0092F220 File Offset: 0x0092D420
		public unsafe float LocalTimeOfDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x06023DCA RID: 146890 RVA: 0x0092F231 File Offset: 0x0092D431
		// (set) Token: 0x06023DCB RID: 146891 RVA: 0x0092F245 File Offset: 0x0092D445
		[Nullable(2)]
		public unsafe USceneComponent Array_Element
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x06023DCC RID: 146892 RVA: 0x0092F25A File Offset: 0x0092D45A
		// (set) Token: 0x06023DCD RID: 146893 RVA: 0x0092F26E File Offset: 0x0092D46E
		public unsafe FVector SwingDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x06023DCE RID: 146894 RVA: 0x0092F283 File Offset: 0x0092D483
		// (set) Token: 0x06023DCF RID: 146895 RVA: 0x0092F297 File Offset: 0x0092D497
		[Nullable(2)]
		public unsafe USceneComponent Array_Element_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightPrefab_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x06023DD0 RID: 146896 RVA: 0x0092F2AC File Offset: 0x0092D4AC
		// (set) Token: 0x06023DD1 RID: 146897 RVA: 0x0092F2BC File Offset: 0x0092D4BC
		public unsafe int TickCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x06023DD2 RID: 146898 RVA: 0x0092F2D0 File Offset: 0x0092D4D0
		// (set) Token: 0x06023DD3 RID: 146899 RVA: 0x0092F309 File Offset: 0x0092D509
		public TArray<UMaterialInstanceDynamic> DynamicMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterials) == null)
				{
					result = (this._DynamicMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x06023DD4 RID: 146900 RVA: 0x0092F318 File Offset: 0x0092D518
		// (set) Token: 0x06023DD5 RID: 146901 RVA: 0x0092F351 File Offset: 0x0092D551
		public TArray<AActor> ChildActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ChildActors) == null)
				{
					result = (this._ChildActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.ChildActors.CopyAssign(value);
			}
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x06023DD6 RID: 146902 RVA: 0x0092F35F File Offset: 0x0092D55F
		// (set) Token: 0x06023DD7 RID: 146903 RVA: 0x0092F36F File Offset: 0x0092D56F
		public unsafe bool IsDaytime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightPrefab_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023DD8 RID: 146904 RVA: 0x0092F380 File Offset: 0x0092D580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Material_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__Update_Material_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06023DD9 RID: 146905 RVA: 0x0092F394 File Offset: 0x0092D594
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LightModelProperty()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__LightModelProperty_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDA RID: 146906 RVA: 0x0092F3A8 File Offset: 0x0092D5A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshPrefab()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__RefreshPrefab_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDB RID: 146907 RVA: 0x0092F3BC File Offset: 0x0092D5BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetChildActorLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__ResetChildActorLocation_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDC RID: 146908 RVA: 0x0092F3D0 File Offset: 0x0092D5D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdataProperty()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__UpdataProperty_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDD RID: 146909 RVA: 0x0092F3E4 File Offset: 0x0092D5E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitialProperty()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__InitialProperty_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDE RID: 146910 RVA: 0x0092F3F8 File Offset: 0x0092D5F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023DDF RID: 146911 RVA: 0x0092F40C File Offset: 0x0092D60C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightPrefab_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023DE0 RID: 146912 RVA: 0x0092F421 File Offset: 0x0092D621
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023DE1 RID: 146913 RVA: 0x0092F435 File Offset: 0x0092D635
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightPrefab_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023DE2 RID: 146914 RVA: 0x0092F44C File Offset: 0x0092D64C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LightPrefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightPrefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightPrefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023DE3 RID: 146915 RVA: 0x0092F494 File Offset: 0x0092D694
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LightPrefab_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LightPrefab_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightPrefab_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightPrefab_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023DE4 RID: 146916 RVA: 0x0092F4DC File Offset: 0x0092D6DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LightPrefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LightPrefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightPrefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023DE5 RID: 146917 RVA: 0x0092F524 File Offset: 0x0092D724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LightPrefab_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LightPrefab_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightPrefab_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightPrefab_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023DE6 RID: 146918 RVA: 0x0092F56B File Offset: 0x0092D76B
		protected BP_LightPrefab_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BB6 RID: 72630
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/LightPrefab/BP_LightPrefab.BP_LightPrefab_C";

		// Token: 0x04011BB7 RID: 72631
		private static IntPtr _ClassPtr;

		// Token: 0x04011BB8 RID: 72632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BB9 RID: 72633
		internal static int __PropertyOffset_1;

		// Token: 0x04011BBA RID: 72634
		internal static int __PropertyOffset_2;

		// Token: 0x04011BBB RID: 72635
		internal static int __PropertyOffset_3;

		// Token: 0x04011BBC RID: 72636
		internal static int __PropertyOffset_4;

		// Token: 0x04011BBD RID: 72637
		internal static int __PropertyOffset_5;

		// Token: 0x04011BBE RID: 72638
		internal static int __PropertyOffset_6;

		// Token: 0x04011BBF RID: 72639
		internal static int __PropertyOffset_7;

		// Token: 0x04011BC0 RID: 72640
		[Nullable(2)]
		private PCG_LightPrefab_Light _灯光;

		// Token: 0x04011BC1 RID: 72641
		internal static int __PropertyOffset_8;

		// Token: 0x04011BC2 RID: 72642
		[Nullable(2)]
		private PCG_LightPrefab_Mesh _模型;

		// Token: 0x04011BC3 RID: 72643
		internal static int __PropertyOffset_9;

		// Token: 0x04011BC4 RID: 72644
		[Nullable(2)]
		private PCG_LightPrefab_Decal _贴花;

		// Token: 0x04011BC5 RID: 72645
		internal static int __PropertyOffset_10;

		// Token: 0x04011BC6 RID: 72646
		[Nullable(2)]
		private PCG_LightPrefab_Fog _雾效;

		// Token: 0x04011BC7 RID: 72647
		internal static int __PropertyOffset_11;

		// Token: 0x04011BC8 RID: 72648
		[Nullable(2)]
		private PCG_LightPrefab_Effect _特效;

		// Token: 0x04011BC9 RID: 72649
		internal static int __PropertyOffset_12;

		// Token: 0x04011BCA RID: 72650
		[Nullable(2)]
		private PCG_LightPrefab_Swing _摆动;

		// Token: 0x04011BCB RID: 72651
		internal static int __PropertyOffset_13;

		// Token: 0x04011BCC RID: 72652
		internal static int __PropertyOffset_14;

		// Token: 0x04011BCD RID: 72653
		internal static int __PropertyOffset_15;

		// Token: 0x04011BCE RID: 72654
		internal static int __PropertyOffset_16;

		// Token: 0x04011BCF RID: 72655
		internal static int __PropertyOffset_17;

		// Token: 0x04011BD0 RID: 72656
		internal static int __PropertyOffset_18;

		// Token: 0x04011BD1 RID: 72657
		internal static int __PropertyOffset_19;

		// Token: 0x04011BD2 RID: 72658
		internal static int __PropertyOffset_20;

		// Token: 0x04011BD3 RID: 72659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterials;

		// Token: 0x04011BD4 RID: 72660
		internal static int __PropertyOffset_21;

		// Token: 0x04011BD5 RID: 72661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ChildActors;

		// Token: 0x04011BD6 RID: 72662
		internal static int __PropertyOffset_22;

		// Token: 0x04011BD7 RID: 72663
		private static IntPtr __Update_Material_Parameter_NativeFunctionPtr;

		// Token: 0x04011BD8 RID: 72664
		private static IntPtr __LightModelProperty_NativeFunctionPtr;

		// Token: 0x04011BD9 RID: 72665
		private static IntPtr __RefreshPrefab_NativeFunctionPtr;

		// Token: 0x04011BDA RID: 72666
		private static IntPtr __ResetChildActorLocation_NativeFunctionPtr;

		// Token: 0x04011BDB RID: 72667
		private static IntPtr __UpdataProperty_NativeFunctionPtr;

		// Token: 0x04011BDC RID: 72668
		private static IntPtr __InitialProperty_NativeFunctionPtr;

		// Token: 0x04011BDD RID: 72669
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011BDE RID: 72670
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011BDF RID: 72671
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011BE0 RID: 72672
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009EAF RID: 40623
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031788 RID: 202632
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EB0 RID: 40624
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031789 RID: 202633
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
