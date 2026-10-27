using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0C RID: 15628
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_ConvertMaterialUpdate.BP_ConvertMaterialUpdate_C")]
	[UnrealStructLayout(1416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1416)]
	public class BP_ConvertMaterialUpdate_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060256DC RID: 153308 RVA: 0x009597D4 File Offset: 0x009579D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ConvertMaterialUpdate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConvertMaterialUpdate.BP_ConvertMaterialUpdate_C");
			}
			return BP_ConvertMaterialUpdate_C._ClassPtr;
		}

		// Token: 0x060256DD RID: 153309 RVA: 0x009597F8 File Offset: 0x009579F8
		public BP_ConvertMaterialUpdate_C() : this(BuiltinUtils.AllocNativeUObject(BP_ConvertMaterialUpdate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x00959820 File Offset: 0x00957A20
		public BP_ConvertMaterialUpdate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ConvertMaterialUpdate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x060256DF RID: 153311 RVA: 0x00959853 File Offset: 0x00957A53
		// (set) Token: 0x060256E0 RID: 153312 RVA: 0x00959867 File Offset: 0x00957A67
		[Nullable(2)]
		public unsafe USceneComponent StartPoint
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x060256E1 RID: 153313 RVA: 0x0095987C File Offset: 0x00957A7C
		// (set) Token: 0x060256E2 RID: 153314 RVA: 0x00959890 File Offset: 0x00957A90
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x060256E3 RID: 153315 RVA: 0x009598A5 File Offset: 0x00957AA5
		// (set) Token: 0x060256E4 RID: 153316 RVA: 0x009598B9 File Offset: 0x00957AB9
		public unsafe FName StartPositionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x060256E5 RID: 153317 RVA: 0x009598CE File Offset: 0x00957ACE
		// (set) Token: 0x060256E6 RID: 153318 RVA: 0x009598E2 File Offset: 0x00957AE2
		public unsafe FName Diffusion_Size_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x060256E7 RID: 153319 RVA: 0x009598F8 File Offset: 0x00957AF8
		// (set) Token: 0x060256E8 RID: 153320 RVA: 0x00959931 File Offset: 0x00957B31
		public TArray<UMaterialInstance> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x060256E9 RID: 153321 RVA: 0x0095993F File Offset: 0x00957B3F
		// (set) Token: 0x060256EA RID: 153322 RVA: 0x0095994F File Offset: 0x00957B4F
		public unsafe float Real_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x060256EB RID: 153323 RVA: 0x00959960 File Offset: 0x00957B60
		// (set) Token: 0x060256EC RID: 153324 RVA: 0x00959970 File Offset: 0x00957B70
		public unsafe float Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x060256ED RID: 153325 RVA: 0x00959981 File Offset: 0x00957B81
		// (set) Token: 0x060256EE RID: 153326 RVA: 0x00959995 File Offset: 0x00957B95
		public unsafe FName Progress_name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x060256EF RID: 153327 RVA: 0x009599AA File Offset: 0x00957BAA
		// (set) Token: 0x060256F0 RID: 153328 RVA: 0x009599BA File Offset: 0x00957BBA
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x060256F1 RID: 153329 RVA: 0x009599CB File Offset: 0x00957BCB
		// (set) Token: 0x060256F2 RID: 153330 RVA: 0x009599DB File Offset: 0x00957BDB
		public unsafe float Diffsuion_Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x060256F3 RID: 153331 RVA: 0x009599EC File Offset: 0x00957BEC
		// (set) Token: 0x060256F4 RID: 153332 RVA: 0x00959A00 File Offset: 0x00957C00
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x060256F5 RID: 153333 RVA: 0x00959A18 File Offset: 0x00957C18
		// (set) Token: 0x060256F6 RID: 153334 RVA: 0x00959A51 File Offset: 0x00957C51
		public TArray<AStaticMeshActor> SwitchActor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SwitchActor) == null)
				{
					result = (this._SwitchActor = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.SwitchActor.CopyAssign(value);
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x060256F7 RID: 153335 RVA: 0x00959A5F File Offset: 0x00957C5F
		// (set) Token: 0x060256F8 RID: 153336 RVA: 0x00959A73 File Offset: 0x00957C73
		[Nullable(2)]
		public unsafe UMaterialInstance Material_Instance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x060256F9 RID: 153337 RVA: 0x00959A88 File Offset: 0x00957C88
		// (set) Token: 0x060256FA RID: 153338 RVA: 0x00959AC1 File Offset: 0x00957CC1
		public TArray<AStaticMeshActor> SpawnerMeshActor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SpawnerMeshActor) == null)
				{
					result = (this._SpawnerMeshActor = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.SpawnerMeshActor.CopyAssign(value);
			}
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x060256FB RID: 153339 RVA: 0x00959AD0 File Offset: 0x00957CD0
		// (set) Token: 0x060256FC RID: 153340 RVA: 0x00959B09 File Offset: 0x00957D09
		public TArray<AStaticMeshActor> SpawnedMeshActor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SpawnedMeshActor) == null)
				{
					result = (this._SpawnedMeshActor = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.SpawnedMeshActor.CopyAssign(value);
			}
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x060256FD RID: 153341 RVA: 0x00959B17 File Offset: 0x00957D17
		// (set) Token: 0x060256FE RID: 153342 RVA: 0x00959B2B File Offset: 0x00957D2B
		public unsafe FName ReverseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x060256FF RID: 153343 RVA: 0x00959B40 File Offset: 0x00957D40
		// (set) Token: 0x06025700 RID: 153344 RVA: 0x00959B50 File Offset: 0x00957D50
		public unsafe int Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x06025701 RID: 153345 RVA: 0x00959B61 File Offset: 0x00957D61
		// (set) Token: 0x06025702 RID: 153346 RVA: 0x00959B71 File Offset: 0x00957D71
		public unsafe bool NeedDestory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x06025703 RID: 153347 RVA: 0x00959B84 File Offset: 0x00957D84
		// (set) Token: 0x06025704 RID: 153348 RVA: 0x00959BBD File Offset: 0x00957DBD
		public FKuroCurveFloat ProgressCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ProgressCurve) == null)
				{
					result = (this._ProgressCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x06025705 RID: 153349 RVA: 0x00959BDE File Offset: 0x00957DDE
		// (set) Token: 0x06025706 RID: 153350 RVA: 0x00959BEE File Offset: 0x00957DEE
		public unsafe bool EnableDA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x06025707 RID: 153351 RVA: 0x00959BFF File Offset: 0x00957DFF
		// (set) Token: 0x06025708 RID: 153352 RVA: 0x00959C13 File Offset: 0x00957E13
		[Nullable(2)]
		public unsafe ItemMaterialControllerActorData DA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ItemMaterialControllerActorData>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConvertMaterialUpdate_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x06025709 RID: 153353 RVA: 0x00959C28 File Offset: 0x00957E28
		// (set) Token: 0x0602570A RID: 153354 RVA: 0x00959C38 File Offset: 0x00957E38
		public unsafe int TEMP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x0602570B RID: 153355 RVA: 0x00959C49 File Offset: 0x00957E49
		// (set) Token: 0x0602570C RID: 153356 RVA: 0x00959C59 File Offset: 0x00957E59
		public unsafe bool EnableMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x0602570D RID: 153357 RVA: 0x00959C6A File Offset: 0x00957E6A
		// (set) Token: 0x0602570E RID: 153358 RVA: 0x00959C7A File Offset: 0x00957E7A
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x0602570F RID: 153359 RVA: 0x00959C8C File Offset: 0x00957E8C
		// (set) Token: 0x06025710 RID: 153360 RVA: 0x00959CC5 File Offset: 0x00957EC5
		public TArray<bool> Hidden
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._Hidden) == null)
				{
					result = (this._Hidden = new TArray<bool>(base.NativePtr + (IntPtr)BP_ConvertMaterialUpdate_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.Hidden.CopyAssign(value);
			}
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x00959CD3 File Offset: 0x00957ED3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReadAndSet()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReadAndSet_NativeFunctionPtr, null);
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x00959CE7 File Offset: 0x00957EE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReadAndSet_DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReadAndSet_DA_NativeFunctionPtr, null);
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x00959CFB File Offset: 0x00957EFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__DisableTick_NativeFunctionPtr, null);
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x00959D0F File Offset: 0x00957F0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__EnableTick_NativeFunctionPtr, null);
		}

		// Token: 0x06025715 RID: 153365 RVA: 0x00959D23 File Offset: 0x00957F23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreatAndChange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__CreatAndChange_NativeFunctionPtr, null);
		}

		// Token: 0x06025716 RID: 153366 RVA: 0x00959D37 File Offset: 0x00957F37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025717 RID: 153367 RVA: 0x00959D4B File Offset: 0x00957F4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025718 RID: 153368 RVA: 0x00959D60 File Offset: 0x00957F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025719 RID: 153369 RVA: 0x00959D74 File Offset: 0x00957F74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602571A RID: 153370 RVA: 0x00959D8C File Offset: 0x00957F8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConvertMaterialUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602571B RID: 153371 RVA: 0x00959DD4 File Offset: 0x00957FD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConvertMaterialUpdate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConvertMaterialUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602571C RID: 153372 RVA: 0x00959E1C File Offset: 0x0095801C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602571D RID: 153373 RVA: 0x00959E68 File Offset: 0x00958068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConvertMaterialUpdate_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602571E RID: 153374 RVA: 0x00959EB4 File Offset: 0x009580B4
		protected BP_ConvertMaterialUpdate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012ABF RID: 76479
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConvertMaterialUpdate.BP_ConvertMaterialUpdate_C";

		// Token: 0x04012AC0 RID: 76480
		private static IntPtr _ClassPtr;

		// Token: 0x04012AC1 RID: 76481
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AC2 RID: 76482
		internal static int __PropertyOffset_1;

		// Token: 0x04012AC3 RID: 76483
		internal static int __PropertyOffset_2;

		// Token: 0x04012AC4 RID: 76484
		internal static int __PropertyOffset_3;

		// Token: 0x04012AC5 RID: 76485
		internal static int __PropertyOffset_4;

		// Token: 0x04012AC6 RID: 76486
		internal static int __PropertyOffset_5;

		// Token: 0x04012AC7 RID: 76487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _Materials;

		// Token: 0x04012AC8 RID: 76488
		internal static int __PropertyOffset_6;

		// Token: 0x04012AC9 RID: 76489
		internal static int __PropertyOffset_7;

		// Token: 0x04012ACA RID: 76490
		internal static int __PropertyOffset_8;

		// Token: 0x04012ACB RID: 76491
		internal static int __PropertyOffset_9;

		// Token: 0x04012ACC RID: 76492
		internal static int __PropertyOffset_10;

		// Token: 0x04012ACD RID: 76493
		internal static int __PropertyOffset_11;

		// Token: 0x04012ACE RID: 76494
		internal static int __PropertyOffset_12;

		// Token: 0x04012ACF RID: 76495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SwitchActor;

		// Token: 0x04012AD0 RID: 76496
		internal static int __PropertyOffset_13;

		// Token: 0x04012AD1 RID: 76497
		internal static int __PropertyOffset_14;

		// Token: 0x04012AD2 RID: 76498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SpawnerMeshActor;

		// Token: 0x04012AD3 RID: 76499
		internal static int __PropertyOffset_15;

		// Token: 0x04012AD4 RID: 76500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SpawnedMeshActor;

		// Token: 0x04012AD5 RID: 76501
		internal static int __PropertyOffset_16;

		// Token: 0x04012AD6 RID: 76502
		internal static int __PropertyOffset_17;

		// Token: 0x04012AD7 RID: 76503
		internal static int __PropertyOffset_18;

		// Token: 0x04012AD8 RID: 76504
		internal static int __PropertyOffset_19;

		// Token: 0x04012AD9 RID: 76505
		[Nullable(2)]
		private FKuroCurveFloat _ProgressCurve;

		// Token: 0x04012ADA RID: 76506
		internal static int __PropertyOffset_20;

		// Token: 0x04012ADB RID: 76507
		internal static int __PropertyOffset_21;

		// Token: 0x04012ADC RID: 76508
		internal static int __PropertyOffset_22;

		// Token: 0x04012ADD RID: 76509
		internal static int __PropertyOffset_23;

		// Token: 0x04012ADE RID: 76510
		internal static int __PropertyOffset_24;

		// Token: 0x04012ADF RID: 76511
		internal static int __PropertyOffset_25;

		// Token: 0x04012AE0 RID: 76512
		[Nullable(2)]
		private TArray<bool> _Hidden;

		// Token: 0x04012AE1 RID: 76513
		private static IntPtr __ReadAndSet_NativeFunctionPtr;

		// Token: 0x04012AE2 RID: 76514
		private static IntPtr __ReadAndSet_DA_NativeFunctionPtr;

		// Token: 0x04012AE3 RID: 76515
		private static IntPtr __DisableTick_NativeFunctionPtr;

		// Token: 0x04012AE4 RID: 76516
		private static IntPtr __EnableTick_NativeFunctionPtr;

		// Token: 0x04012AE5 RID: 76517
		private static IntPtr __CreatAndChange_NativeFunctionPtr;

		// Token: 0x04012AE6 RID: 76518
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012AE7 RID: 76519
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012AE8 RID: 76520
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012AE9 RID: 76521
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009FF8 RID: 40952
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A93 RID: 203411
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FF9 RID: 40953
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031A94 RID: 203412
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
