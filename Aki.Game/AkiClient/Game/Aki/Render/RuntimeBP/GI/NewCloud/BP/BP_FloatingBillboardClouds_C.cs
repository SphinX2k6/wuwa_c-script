using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5D RID: 15709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds.BP_FloatingBillboardClouds_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1660)]
	public class BP_FloatingBillboardClouds_C : AKuroFloatingBillboardCloudActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060266B8 RID: 157368 RVA: 0x00974A95 File Offset: 0x00972C95
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingBillboardClouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds.BP_FloatingBillboardClouds_C");
			}
			return BP_FloatingBillboardClouds_C._ClassPtr;
		}

		// Token: 0x060266B9 RID: 157369 RVA: 0x00974ABC File Offset: 0x00972CBC
		public BP_FloatingBillboardClouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingBillboardClouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060266BA RID: 157370 RVA: 0x00974AE4 File Offset: 0x00972CE4
		public BP_FloatingBillboardClouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingBillboardClouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x060266BB RID: 157371 RVA: 0x00974B17 File Offset: 0x00972D17
		// (set) Token: 0x060266BC RID: 157372 RVA: 0x00974B2B File Offset: 0x00972D2B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x060266BD RID: 157373 RVA: 0x00974B40 File Offset: 0x00972D40
		// (set) Token: 0x060266BE RID: 157374 RVA: 0x00974B50 File Offset: 0x00972D50
		public unsafe int Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x060266BF RID: 157375 RVA: 0x00974B64 File Offset: 0x00972D64
		// (set) Token: 0x060266C0 RID: 157376 RVA: 0x00974B9D File Offset: 0x00972D9D
		public TArray<BP_FloatingBillboardClouds_Prefab_C> Childs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_FloatingBillboardClouds_Prefab_C> result;
				if ((result = this._Childs) == null)
				{
					result = (this._Childs = new TArray<BP_FloatingBillboardClouds_Prefab_C>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.Childs.CopyAssign(value);
			}
		}

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x060266C1 RID: 157377 RVA: 0x00974BAB File Offset: 0x00972DAB
		// (set) Token: 0x060266C2 RID: 157378 RVA: 0x00974BBF File Offset: 0x00972DBF
		[Nullable(2)]
		public unsafe UKuroPDFloatingBillboardCloudPrefab CloudPD
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPDFloatingBillboardCloudPrefab>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloatingBillboardClouds_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x060266C3 RID: 157379 RVA: 0x00974BD4 File Offset: 0x00972DD4
		// (set) Token: 0x060266C4 RID: 157380 RVA: 0x00974BE4 File Offset: 0x00972DE4
		public unsafe bool Reset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x060266C5 RID: 157381 RVA: 0x00974BF5 File Offset: 0x00972DF5
		// (set) Token: 0x060266C6 RID: 157382 RVA: 0x00974C05 File Offset: 0x00972E05
		public unsafe int Trans_Sort_Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005210 RID: 21008
		// (get) Token: 0x060266C7 RID: 157383 RVA: 0x00974C18 File Offset: 0x00972E18
		// (set) Token: 0x060266C8 RID: 157384 RVA: 0x00974C51 File Offset: 0x00972E51
		public TArray<FVector2D> PoissonPositionList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._PoissonPositionList) == null)
				{
					result = (this._PoissonPositionList = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.PoissonPositionList.CopyAssign(value);
			}
		}

		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x060266C9 RID: 157385 RVA: 0x00974C60 File Offset: 0x00972E60
		// (set) Token: 0x060266CA RID: 157386 RVA: 0x00974C99 File Offset: 0x00972E99
		public TArray<int> PositionIndex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PositionIndex) == null)
				{
					result = (this._PositionIndex = new TArray<int>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.PositionIndex.CopyAssign(value);
			}
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x060266CB RID: 157387 RVA: 0x00974CA7 File Offset: 0x00972EA7
		// (set) Token: 0x060266CC RID: 157388 RVA: 0x00974CB7 File Offset: 0x00972EB7
		public unsafe float CloudHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x060266CD RID: 157389 RVA: 0x00974CC8 File Offset: 0x00972EC8
		// (set) Token: 0x060266CE RID: 157390 RVA: 0x00974CD8 File Offset: 0x00972ED8
		public unsafe int Threshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x060266CF RID: 157391 RVA: 0x00974CE9 File Offset: 0x00972EE9
		// (set) Token: 0x060266D0 RID: 157392 RVA: 0x00974CF9 File Offset: 0x00972EF9
		public unsafe int CloudRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x060266D1 RID: 157393 RVA: 0x00974D0A File Offset: 0x00972F0A
		// (set) Token: 0x060266D2 RID: 157394 RVA: 0x00974D1A File Offset: 0x00972F1A
		public unsafe int Height_Layering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x060266D3 RID: 157395 RVA: 0x00974D2B File Offset: 0x00972F2B
		// (set) Token: 0x060266D4 RID: 157396 RVA: 0x00974D3B File Offset: 0x00972F3B
		public unsafe float Height_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x060266D5 RID: 157397 RVA: 0x00974D4C File Offset: 0x00972F4C
		// (set) Token: 0x060266D6 RID: 157398 RVA: 0x00974D60 File Offset: 0x00972F60
		public unsafe FVector CloudScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x060266D7 RID: 157399 RVA: 0x00974D78 File Offset: 0x00972F78
		// (set) Token: 0x060266D8 RID: 157400 RVA: 0x00974DB1 File Offset: 0x00972FB1
		public TArray<FVector2D> TextureIndex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._TextureIndex) == null)
				{
					result = (this._TextureIndex = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.TextureIndex.CopyAssign(value);
			}
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x060266D9 RID: 157401 RVA: 0x00974DBF File Offset: 0x00972FBF
		// (set) Token: 0x060266DA RID: 157402 RVA: 0x00974DD3 File Offset: 0x00972FD3
		public unsafe FVector2D TextureIndexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x060266DB RID: 157403 RVA: 0x00974DE8 File Offset: 0x00972FE8
		// (set) Token: 0x060266DC RID: 157404 RVA: 0x00974DF8 File Offset: 0x00972FF8
		public unsafe float ChangeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x060266DD RID: 157405 RVA: 0x00974E09 File Offset: 0x00973009
		// (set) Token: 0x060266DE RID: 157406 RVA: 0x00974E1D File Offset: 0x0097301D
		public unsafe FVector2D CloudDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700521C RID: 21020
		// (get) Token: 0x060266DF RID: 157407 RVA: 0x00974E32 File Offset: 0x00973032
		// (set) Token: 0x060266E0 RID: 157408 RVA: 0x00974E42 File Offset: 0x00973042
		public unsafe bool UseStoredPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x060266E1 RID: 157409 RVA: 0x00974E54 File Offset: 0x00973054
		// (set) Token: 0x060266E2 RID: 157410 RVA: 0x00974E8D File Offset: 0x0097308D
		public TArray<FVector2D> StaticPositionList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._StaticPositionList) == null)
				{
					result = (this._StaticPositionList = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.StaticPositionList.CopyAssign(value);
			}
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x060266E3 RID: 157411 RVA: 0x00974E9B File Offset: 0x0097309B
		// (set) Token: 0x060266E4 RID: 157412 RVA: 0x00974EAB File Offset: 0x009730AB
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x060266E5 RID: 157413 RVA: 0x00974EBC File Offset: 0x009730BC
		// (set) Token: 0x060266E6 RID: 157414 RVA: 0x00974ED0 File Offset: 0x009730D0
		public unsafe FVectorDouble CloudPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x060266E7 RID: 157415 RVA: 0x00974EE5 File Offset: 0x009730E5
		// (set) Token: 0x060266E8 RID: 157416 RVA: 0x00974EF5 File Offset: 0x009730F5
		public unsafe int CloudDissolveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingBillboardClouds_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x060266E9 RID: 157417 RVA: 0x00974F06 File Offset: 0x00973106
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalculatePoissonPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__CalculatePoissonPosition_NativeFunctionPtr, null);
		}

		// Token: 0x060266EA RID: 157418 RVA: 0x00974F1C File Offset: 0x0097311C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CloudPrefabParamIni(BP_FloatingBillboardClouds_Prefab_C CloudPrefab, int CloudIndex)
		{
			BP_FloatingBillboardClouds_C.__CloudPrefabParamIni_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_C.__CloudPrefabParamIni_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_FloatingBillboardClouds_C.__CloudPrefabParamIni_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_C.__CloudPrefabParamIni_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPrefab = ((CloudPrefab != null) ? CloudPrefab.NativePtr : IntPtr.Zero);
			ptr->CloudIndex = CloudIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__CloudPrefabParamIni_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x00974F78 File Offset: 0x00973178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StoreCurrentPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__StoreCurrentPosition_NativeFunctionPtr, null);
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x00974F8C File Offset: 0x0097318C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CaluateIndex()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__CaluateIndex_NativeFunctionPtr, null);
		}

		// Token: 0x060266ED RID: 157421 RVA: 0x00974FA0 File Offset: 0x009731A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__RefreshCloud_NativeFunctionPtr, null);
		}

		// Token: 0x060266EE RID: 157422 RVA: 0x00974FB4 File Offset: 0x009731B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MainParamsUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__MainParamsUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x060266EF RID: 157423 RVA: 0x00974FC8 File Offset: 0x009731C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060266F0 RID: 157424 RVA: 0x00974FDC File Offset: 0x009731DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266F1 RID: 157425 RVA: 0x00974FF4 File Offset: 0x009731F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266F2 RID: 157426 RVA: 0x0097503C File Offset: 0x0097323C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266F3 RID: 157427 RVA: 0x00975084 File Offset: 0x00973284
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266F4 RID: 157428 RVA: 0x009750CC File Offset: 0x009732CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloatingBillboardClouds_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloatingBillboardClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266F5 RID: 157429 RVA: 0x00975113 File Offset: 0x00973313
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060266F6 RID: 157430 RVA: 0x00975127 File Offset: 0x00973327
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloatingBillboardClouds_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266F7 RID: 157431 RVA: 0x0097513C File Offset: 0x0097333C
		protected BP_FloatingBillboardClouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401345A RID: 78938
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_FloatingBillboardClouds.BP_FloatingBillboardClouds_C";

		// Token: 0x0401345B RID: 78939
		private static IntPtr _ClassPtr;

		// Token: 0x0401345C RID: 78940
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401345D RID: 78941
		internal static int __PropertyOffset_1;

		// Token: 0x0401345E RID: 78942
		internal static int __PropertyOffset_2;

		// Token: 0x0401345F RID: 78943
		internal static int __PropertyOffset_3;

		// Token: 0x04013460 RID: 78944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_FloatingBillboardClouds_Prefab_C> _Childs;

		// Token: 0x04013461 RID: 78945
		internal static int __PropertyOffset_4;

		// Token: 0x04013462 RID: 78946
		internal static int __PropertyOffset_5;

		// Token: 0x04013463 RID: 78947
		internal static int __PropertyOffset_6;

		// Token: 0x04013464 RID: 78948
		internal static int __PropertyOffset_7;

		// Token: 0x04013465 RID: 78949
		[Nullable(2)]
		private TArray<FVector2D> _PoissonPositionList;

		// Token: 0x04013466 RID: 78950
		internal static int __PropertyOffset_8;

		// Token: 0x04013467 RID: 78951
		[Nullable(2)]
		private TArray<int> _PositionIndex;

		// Token: 0x04013468 RID: 78952
		internal static int __PropertyOffset_9;

		// Token: 0x04013469 RID: 78953
		internal static int __PropertyOffset_10;

		// Token: 0x0401346A RID: 78954
		internal static int __PropertyOffset_11;

		// Token: 0x0401346B RID: 78955
		internal static int __PropertyOffset_12;

		// Token: 0x0401346C RID: 78956
		internal static int __PropertyOffset_13;

		// Token: 0x0401346D RID: 78957
		internal static int __PropertyOffset_14;

		// Token: 0x0401346E RID: 78958
		internal static int __PropertyOffset_15;

		// Token: 0x0401346F RID: 78959
		[Nullable(2)]
		private TArray<FVector2D> _TextureIndex;

		// Token: 0x04013470 RID: 78960
		internal static int __PropertyOffset_16;

		// Token: 0x04013471 RID: 78961
		internal static int __PropertyOffset_17;

		// Token: 0x04013472 RID: 78962
		internal static int __PropertyOffset_18;

		// Token: 0x04013473 RID: 78963
		internal static int __PropertyOffset_19;

		// Token: 0x04013474 RID: 78964
		internal static int __PropertyOffset_20;

		// Token: 0x04013475 RID: 78965
		[Nullable(2)]
		private TArray<FVector2D> _StaticPositionList;

		// Token: 0x04013476 RID: 78966
		internal static int __PropertyOffset_21;

		// Token: 0x04013477 RID: 78967
		internal static int __PropertyOffset_22;

		// Token: 0x04013478 RID: 78968
		internal static int __PropertyOffset_23;

		// Token: 0x04013479 RID: 78969
		private static IntPtr __CalculatePoissonPosition_NativeFunctionPtr;

		// Token: 0x0401347A RID: 78970
		private static IntPtr __CloudPrefabParamIni_NativeFunctionPtr;

		// Token: 0x0401347B RID: 78971
		private static IntPtr __StoreCurrentPosition_NativeFunctionPtr;

		// Token: 0x0401347C RID: 78972
		private static IntPtr __CaluateIndex_NativeFunctionPtr;

		// Token: 0x0401347D RID: 78973
		private static IntPtr __RefreshCloud_NativeFunctionPtr;

		// Token: 0x0401347E RID: 78974
		private static IntPtr __MainParamsUpdate_NativeFunctionPtr;

		// Token: 0x0401347F RID: 78975
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013480 RID: 78976
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013481 RID: 78977
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04013482 RID: 78978
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A10D RID: 41229
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CloudPrefabParamIni_FunctionParams
		{
			// Token: 0x04031C7F RID: 203903
			[FieldOffset(0)]
			public IntPtr CloudPrefab;

			// Token: 0x04031C80 RID: 203904
			[FieldOffset(8)]
			public int CloudIndex;
		}

		// Token: 0x0200A10E RID: 41230
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C81 RID: 203905
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A10F RID: 41231
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C82 RID: 203906
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
