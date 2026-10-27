using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.DownBurst
{
	// Token: 0x02003CC7 RID: 15559
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/DownBurst/BP_DownBurst.BP_DownBurst_C")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class BP_DownBurst_C : AUKuroCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024CAC RID: 150700 RVA: 0x009487A2 File Offset: 0x009469A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DownBurst_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/DownBurst/BP_DownBurst.BP_DownBurst_C");
			}
			return BP_DownBurst_C._ClassPtr;
		}

		// Token: 0x06024CAD RID: 150701 RVA: 0x009487C8 File Offset: 0x009469C8
		public BP_DownBurst_C() : this(BuiltinUtils.AllocNativeUObject(BP_DownBurst_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024CAE RID: 150702 RVA: 0x009487F0 File Offset: 0x009469F0
		[NullableContext(1)]
		public BP_DownBurst_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DownBurst_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x06024CAF RID: 150703 RVA: 0x00948823 File Offset: 0x00946A23
		// (set) Token: 0x06024CB0 RID: 150704 RVA: 0x00948837 File Offset: 0x00946A37
		public unsafe UStaticMeshComponent SM_VerticalQuad
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x06024CB1 RID: 150705 RVA: 0x0094884C File Offset: 0x00946A4C
		// (set) Token: 0x06024CB2 RID: 150706 RVA: 0x00948860 File Offset: 0x00946A60
		public unsafe USceneComponent MeshRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x06024CB3 RID: 150707 RVA: 0x00948875 File Offset: 0x00946A75
		// (set) Token: 0x06024CB4 RID: 150708 RVA: 0x00948889 File Offset: 0x00946A89
		public unsafe UBoxComponent StreamVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x06024CB5 RID: 150709 RVA: 0x0094889E File Offset: 0x00946A9E
		// (set) Token: 0x06024CB6 RID: 150710 RVA: 0x009488B2 File Offset: 0x00946AB2
		public unsafe UBoxComponent WeatherVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x06024CB7 RID: 150711 RVA: 0x009488C7 File Offset: 0x00946AC7
		// (set) Token: 0x06024CB8 RID: 150712 RVA: 0x009488DB File Offset: 0x00946ADB
		public unsafe USceneComponent WeatherRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x06024CB9 RID: 150713 RVA: 0x009488F0 File Offset: 0x00946AF0
		// (set) Token: 0x06024CBA RID: 150714 RVA: 0x00948904 File Offset: 0x00946B04
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x06024CBB RID: 150715 RVA: 0x00948919 File Offset: 0x00946B19
		// (set) Token: 0x06024CBC RID: 150716 RVA: 0x0094892D File Offset: 0x00946B2D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x06024CBD RID: 150717 RVA: 0x00948942 File Offset: 0x00946B42
		// (set) Token: 0x06024CBE RID: 150718 RVA: 0x00948952 File Offset: 0x00946B52
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x06024CBF RID: 150719 RVA: 0x00948963 File Offset: 0x00946B63
		// (set) Token: 0x06024CC0 RID: 150720 RVA: 0x00948973 File Offset: 0x00946B73
		public unsafe float MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x06024CC1 RID: 150721 RVA: 0x00948984 File Offset: 0x00946B84
		// (set) Token: 0x06024CC2 RID: 150722 RVA: 0x009489BD File Offset: 0x00946BBD
		[Nullable(1)]
		public TSet<AActor> BoundActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<AActor> result;
				if ((result = this._BoundActors) == null)
				{
					result = (this._BoundActors = new TSet<AActor>(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoundActors.CopyAssign(value);
			}
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x06024CC3 RID: 150723 RVA: 0x009489CB File Offset: 0x00946BCB
		// (set) Token: 0x06024CC4 RID: 150724 RVA: 0x009489DB File Offset: 0x00946BDB
		public unsafe bool bStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x06024CC5 RID: 150725 RVA: 0x009489EC File Offset: 0x00946BEC
		// (set) Token: 0x06024CC6 RID: 150726 RVA: 0x009489FC File Offset: 0x00946BFC
		public unsafe float SumLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x06024CC7 RID: 150727 RVA: 0x00948A0D File Offset: 0x00946C0D
		// (set) Token: 0x06024CC8 RID: 150728 RVA: 0x00948A1D File Offset: 0x00946C1D
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x06024CC9 RID: 150729 RVA: 0x00948A2E File Offset: 0x00946C2E
		// (set) Token: 0x06024CCA RID: 150730 RVA: 0x00948A3E File Offset: 0x00946C3E
		public unsafe float timeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x06024CCB RID: 150731 RVA: 0x00948A4F File Offset: 0x00946C4F
		// (set) Token: 0x06024CCC RID: 150732 RVA: 0x00948A5F File Offset: 0x00946C5F
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x06024CCD RID: 150733 RVA: 0x00948A70 File Offset: 0x00946C70
		// (set) Token: 0x06024CCE RID: 150734 RVA: 0x00948A80 File Offset: 0x00946C80
		public unsafe float fadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x06024CCF RID: 150735 RVA: 0x00948A94 File Offset: 0x00946C94
		// (set) Token: 0x06024CD0 RID: 150736 RVA: 0x00948ACD File Offset: 0x00946CCD
		[Nullable(1)]
		public TMap<AActor, float> BoundActorsOpacity
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<AActor, float> result;
				if ((result = this._BoundActorsOpacity) == null)
				{
					result = (this._BoundActorsOpacity = new TMap<AActor, float>(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoundActorsOpacity.CopyAssign(value);
			}
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x06024CD1 RID: 150737 RVA: 0x00948ADC File Offset: 0x00946CDC
		// (set) Token: 0x06024CD2 RID: 150738 RVA: 0x00948B15 File Offset: 0x00946D15
		[Nullable(1)]
		public TArray<AActor> BoundActorsArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._BoundActorsArray) == null)
				{
					result = (this._BoundActorsArray = new TArray<AActor>(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoundActorsArray.CopyAssign(value);
			}
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x06024CD3 RID: 150739 RVA: 0x00948B23 File Offset: 0x00946D23
		// (set) Token: 0x06024CD4 RID: 150740 RVA: 0x00948B33 File Offset: 0x00946D33
		public unsafe float coldDownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x06024CD5 RID: 150741 RVA: 0x00948B44 File Offset: 0x00946D44
		// (set) Token: 0x06024CD6 RID: 150742 RVA: 0x00948B54 File Offset: 0x00946D54
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DownBurst_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x06024CD7 RID: 150743 RVA: 0x00948B65 File Offset: 0x00946D65
		// (set) Token: 0x06024CD8 RID: 150744 RVA: 0x00948B79 File Offset: 0x00946D79
		public unsafe UKuroWeatherDataAsset WeatherDa
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x06024CD9 RID: 150745 RVA: 0x00948B8E File Offset: 0x00946D8E
		// (set) Token: 0x06024CDA RID: 150746 RVA: 0x00948BA2 File Offset: 0x00946DA2
		public unsafe AKuroPostProcessVolume Weather
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06024CDB RID: 150747 RVA: 0x00948BB7 File Offset: 0x00946DB7
		// (set) Token: 0x06024CDC RID: 150748 RVA: 0x00948BCB File Offset: 0x00946DCB
		public unsafe UMaterialInterface DownburstMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06024CDD RID: 150749 RVA: 0x00948BE0 File Offset: 0x00946DE0
		// (set) Token: 0x06024CDE RID: 150750 RVA: 0x00948BF4 File Offset: 0x00946DF4
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DownBurst_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x06024CDF RID: 150751 RVA: 0x00948C09 File Offset: 0x00946E09
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheInitBoundOpacity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__CacheInitBoundOpacity_NativeFunctionPtr, null);
		}

		// Token: 0x06024CE0 RID: 150752 RVA: 0x00948C20 File Offset: 0x00946E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateBoundOpacity(float Blend_Weight)
		{
			BP_DownBurst_C.__UpdateBoundOpacity_FunctionParams* ptr = stackalloc BP_DownBurst_C.__UpdateBoundOpacity_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_DownBurst_C.__UpdateBoundOpacity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DownBurst_C.__UpdateBoundOpacity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Blend_Weight = Blend_Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__UpdateBoundOpacity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CE1 RID: 150753 RVA: 0x00948C66 File Offset: 0x00946E66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024CE2 RID: 150754 RVA: 0x00948C7A File Offset: 0x00946E7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024CE3 RID: 150755 RVA: 0x00948C90 File Offset: 0x00946E90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DownBurst_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DownBurst_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DownBurst_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DownBurst_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CE4 RID: 150756 RVA: 0x00948CD8 File Offset: 0x00946ED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DownBurst_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DownBurst_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DownBurst_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DownBurst_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024CE5 RID: 150757 RVA: 0x00948D1F File Offset: 0x00946F1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x00948D33 File Offset: 0x00946F33
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024CE7 RID: 150759 RVA: 0x00948D48 File Offset: 0x00946F48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_DownBurst_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_DownBurst_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DownBurst_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DownBurst_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024CE8 RID: 150760 RVA: 0x00948D94 File Offset: 0x00946F94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_DownBurst_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_DownBurst_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_DownBurst_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DownBurst_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DownBurst_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024CE9 RID: 150761 RVA: 0x00948DE0 File Offset: 0x00946FE0
		protected BP_DownBurst_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012486 RID: 74886
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/DownBurst/BP_DownBurst.BP_DownBurst_C";

		// Token: 0x04012487 RID: 74887
		private static IntPtr _ClassPtr;

		// Token: 0x04012488 RID: 74888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012489 RID: 74889
		internal static int __PropertyOffset_1;

		// Token: 0x0401248A RID: 74890
		internal static int __PropertyOffset_2;

		// Token: 0x0401248B RID: 74891
		internal static int __PropertyOffset_3;

		// Token: 0x0401248C RID: 74892
		internal static int __PropertyOffset_4;

		// Token: 0x0401248D RID: 74893
		internal static int __PropertyOffset_5;

		// Token: 0x0401248E RID: 74894
		internal static int __PropertyOffset_6;

		// Token: 0x0401248F RID: 74895
		internal static int __PropertyOffset_7;

		// Token: 0x04012490 RID: 74896
		internal static int __PropertyOffset_8;

		// Token: 0x04012491 RID: 74897
		internal static int __PropertyOffset_9;

		// Token: 0x04012492 RID: 74898
		internal static int __PropertyOffset_10;

		// Token: 0x04012493 RID: 74899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AActor> _BoundActors;

		// Token: 0x04012494 RID: 74900
		internal static int __PropertyOffset_11;

		// Token: 0x04012495 RID: 74901
		internal static int __PropertyOffset_12;

		// Token: 0x04012496 RID: 74902
		internal static int __PropertyOffset_13;

		// Token: 0x04012497 RID: 74903
		internal static int __PropertyOffset_14;

		// Token: 0x04012498 RID: 74904
		internal static int __PropertyOffset_15;

		// Token: 0x04012499 RID: 74905
		internal static int __PropertyOffset_16;

		// Token: 0x0401249A RID: 74906
		internal static int __PropertyOffset_17;

		// Token: 0x0401249B RID: 74907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AActor, float> _BoundActorsOpacity;

		// Token: 0x0401249C RID: 74908
		internal static int __PropertyOffset_18;

		// Token: 0x0401249D RID: 74909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _BoundActorsArray;

		// Token: 0x0401249E RID: 74910
		internal static int __PropertyOffset_19;

		// Token: 0x0401249F RID: 74911
		internal static int __PropertyOffset_20;

		// Token: 0x040124A0 RID: 74912
		internal static int __PropertyOffset_21;

		// Token: 0x040124A1 RID: 74913
		internal static int __PropertyOffset_22;

		// Token: 0x040124A2 RID: 74914
		internal static int __PropertyOffset_23;

		// Token: 0x040124A3 RID: 74915
		internal static int __PropertyOffset_24;

		// Token: 0x040124A4 RID: 74916
		private static IntPtr __CacheInitBoundOpacity_NativeFunctionPtr;

		// Token: 0x040124A5 RID: 74917
		private static IntPtr __UpdateBoundOpacity_NativeFunctionPtr;

		// Token: 0x040124A6 RID: 74918
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040124A7 RID: 74919
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040124A8 RID: 74920
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x040124A9 RID: 74921
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009F6C RID: 40812
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateBoundOpacity_FunctionParams
		{
			// Token: 0x0403196B RID: 203115
			[FieldOffset(0)]
			public float Blend_Weight;
		}

		// Token: 0x02009F6D RID: 40813
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403196C RID: 203116
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F6E RID: 40814
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403196D RID: 203117
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
