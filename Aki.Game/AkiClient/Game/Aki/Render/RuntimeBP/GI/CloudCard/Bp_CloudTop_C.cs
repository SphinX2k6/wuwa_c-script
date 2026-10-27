using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.CloudCard
{
	// Token: 0x02003D82 RID: 15746
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudTop.Bp_CloudTop_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class Bp_CloudTop_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026AD7 RID: 158423 RVA: 0x0097B84C File Offset: 0x00979A4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Bp_CloudTop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudTop.Bp_CloudTop_C");
			}
			return Bp_CloudTop_C._ClassPtr;
		}

		// Token: 0x06026AD8 RID: 158424 RVA: 0x0097B870 File Offset: 0x00979A70
		public Bp_CloudTop_C() : this(BuiltinUtils.AllocNativeUObject(Bp_CloudTop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026AD9 RID: 158425 RVA: 0x0097B898 File Offset: 0x00979A98
		[NullableContext(1)]
		public Bp_CloudTop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Bp_CloudTop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x06026ADA RID: 158426 RVA: 0x0097B8CB File Offset: 0x00979ACB
		// (set) Token: 0x06026ADB RID: 158427 RVA: 0x0097B8DF File Offset: 0x00979ADF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x06026ADC RID: 158428 RVA: 0x0097B8F4 File Offset: 0x00979AF4
		// (set) Token: 0x06026ADD RID: 158429 RVA: 0x0097B904 File Offset: 0x00979B04
		public unsafe int CloudRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x06026ADE RID: 158430 RVA: 0x0097B915 File Offset: 0x00979B15
		// (set) Token: 0x06026ADF RID: 158431 RVA: 0x0097B925 File Offset: 0x00979B25
		public unsafe int CloudColumn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x06026AE0 RID: 158432 RVA: 0x0097B936 File Offset: 0x00979B36
		// (set) Token: 0x06026AE1 RID: 158433 RVA: 0x0097B946 File Offset: 0x00979B46
		public unsafe int DefaultOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x06026AE2 RID: 158434 RVA: 0x0097B957 File Offset: 0x00979B57
		// (set) Token: 0x06026AE3 RID: 158435 RVA: 0x0097B96B File Offset: 0x00979B6B
		[Nullable(2)]
		public unsafe UStaticMesh SM_CloudCard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x06026AE4 RID: 158436 RVA: 0x0097B980 File Offset: 0x00979B80
		// (set) Token: 0x06026AE5 RID: 158437 RVA: 0x0097B990 File Offset: 0x00979B90
		public unsafe float DefaultHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x06026AE6 RID: 158438 RVA: 0x0097B9A4 File Offset: 0x00979BA4
		// (set) Token: 0x06026AE7 RID: 158439 RVA: 0x0097B9DD File Offset: 0x00979BDD
		[Nullable(1)]
		public TArray<UStaticMeshComponent> CloudCardComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._CloudCardComponents) == null)
				{
					result = (this._CloudCardComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudCardComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x06026AE8 RID: 158440 RVA: 0x0097B9EB File Offset: 0x00979BEB
		// (set) Token: 0x06026AE9 RID: 158441 RVA: 0x0097B9FB File Offset: 0x00979BFB
		public unsafe float InitAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06026AEA RID: 158442 RVA: 0x0097BA0C File Offset: 0x00979C0C
		// (set) Token: 0x06026AEB RID: 158443 RVA: 0x0097BA20 File Offset: 0x00979C20
		public unsafe FVector CloudUVNoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x06026AEC RID: 158444 RVA: 0x0097BA35 File Offset: 0x00979C35
		// (set) Token: 0x06026AED RID: 158445 RVA: 0x0097BA45 File Offset: 0x00979C45
		public unsafe float CloudUVNoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700539B RID: 21403
		// (get) Token: 0x06026AEE RID: 158446 RVA: 0x0097BA56 File Offset: 0x00979C56
		// (set) Token: 0x06026AEF RID: 158447 RVA: 0x0097BA66 File Offset: 0x00979C66
		public unsafe float CloudUVNoiseTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700539C RID: 21404
		// (get) Token: 0x06026AF0 RID: 158448 RVA: 0x0097BA78 File Offset: 0x00979C78
		// (set) Token: 0x06026AF1 RID: 158449 RVA: 0x0097BAB1 File Offset: 0x00979CB1
		[Nullable(1)]
		public TArray<FKuroCloudTopData> CloudDatas
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCloudTopData> result;
				if ((result = this._CloudDatas) == null)
				{
					result = (this._CloudDatas = new TArray<FKuroCloudTopData>(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudDatas.CopyAssign(value);
			}
		}

		// Token: 0x1700539D RID: 21405
		// (get) Token: 0x06026AF2 RID: 158450 RVA: 0x0097BABF File Offset: 0x00979CBF
		// (set) Token: 0x06026AF3 RID: 158451 RVA: 0x0097BACF File Offset: 0x00979CCF
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06026AF4 RID: 158452 RVA: 0x0097BAE0 File Offset: 0x00979CE0
		// (set) Token: 0x06026AF5 RID: 158453 RVA: 0x0097BAF0 File Offset: 0x00979CF0
		public unsafe float CurYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700539F RID: 21407
		// (get) Token: 0x06026AF6 RID: 158454 RVA: 0x0097BB04 File Offset: 0x00979D04
		// (set) Token: 0x06026AF7 RID: 158455 RVA: 0x0097BB3D File Offset: 0x00979D3D
		[Nullable(1)]
		public TArray<float> FadeTime
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._FadeTime) == null)
				{
					result = (this._FadeTime = new TArray<float>(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FadeTime.CopyAssign(value);
			}
		}

		// Token: 0x170053A0 RID: 21408
		// (get) Token: 0x06026AF8 RID: 158456 RVA: 0x0097BB4C File Offset: 0x00979D4C
		// (set) Token: 0x06026AF9 RID: 158457 RVA: 0x0097BB85 File Offset: 0x00979D85
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> CloudMaterials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._CloudMaterials) == null)
				{
					result = (this._CloudMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)Bp_CloudTop_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170053A1 RID: 21409
		// (get) Token: 0x06026AFA RID: 158458 RVA: 0x0097BB93 File Offset: 0x00979D93
		// (set) Token: 0x06026AFB RID: 158459 RVA: 0x0097BBA7 File Offset: 0x00979DA7
		[Nullable(1)]
		public unsafe string TestStr
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)Bp_CloudTop_C.__PropertyOffset_17)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)Bp_CloudTop_C.__PropertyOffset_17)), value);
			}
		}

		// Token: 0x170053A2 RID: 21410
		// (get) Token: 0x06026AFC RID: 158460 RVA: 0x0097BBBC File Offset: 0x00979DBC
		// (set) Token: 0x06026AFD RID: 158461 RVA: 0x0097BBD0 File Offset: 0x00979DD0
		[Nullable(2)]
		public unsafe UTexture2D CloudTex
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudTop_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x06026AFE RID: 158462 RVA: 0x0097BBE8 File Offset: 0x00979DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardBrightness(int Idx, ref float Brightness)
		{
			Bp_CloudTop_C.__GetCardBrightness_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardBrightness_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardBrightness_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardBrightness_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->Brightness = Brightness;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardBrightness_NativeFunctionPtr, (void*)ptr);
			Brightness = ptr->Brightness;
		}

		// Token: 0x06026AFF RID: 158463 RVA: 0x0097BC40 File Offset: 0x00979E40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardDisappearTime(int Idx, ref float FullStayTime)
		{
			Bp_CloudTop_C.__GetCardDisappearTime_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardDisappearTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardDisappearTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardDisappearTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FullStayTime = FullStayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardDisappearTime_NativeFunctionPtr, (void*)ptr);
			FullStayTime = ptr->FullStayTime;
		}

		// Token: 0x06026B00 RID: 158464 RVA: 0x0097BC98 File Offset: 0x00979E98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetFadeTickTime(int Idx, ref float FadeTime)
		{
			Bp_CloudTop_C.__GetFadeTickTime_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetFadeTickTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetFadeTickTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetFadeTickTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeTime = FadeTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetFadeTickTime_NativeFunctionPtr, (void*)ptr);
			FadeTime = ptr->FadeTime;
		}

		// Token: 0x06026B01 RID: 158465 RVA: 0x0097BCF0 File Offset: 0x00979EF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardMaterial(int Idx, ref UMaterialInstanceDynamic mat)
		{
			Bp_CloudTop_C.__GetCardMaterial_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardMaterial_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ref Bp_CloudTop_C.__GetCardMaterial_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = mat;
			ptr2.mat = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardMaterial_NativeFunctionPtr, (void*)ptr);
			mat = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->mat);
		}

		// Token: 0x06026B02 RID: 158466 RVA: 0x0097BD5C File Offset: 0x00979F5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFullStayTime(int Idx, ref float FullStayTime)
		{
			Bp_CloudTop_C.__GetCardFullStayTime_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardFullStayTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardFullStayTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardFullStayTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FullStayTime = FullStayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardFullStayTime_NativeFunctionPtr, (void*)ptr);
			FullStayTime = ptr->FullStayTime;
		}

		// Token: 0x06026B03 RID: 158467 RVA: 0x0097BDB4 File Offset: 0x00979FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFadeInTime(int Idx, ref float FadeInTime)
		{
			Bp_CloudTop_C.__GetCardFadeInTime_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardFadeInTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardFadeInTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardFadeInTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeInTime = FadeInTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardFadeInTime_NativeFunctionPtr, (void*)ptr);
			FadeInTime = ptr->FadeInTime;
		}

		// Token: 0x06026B04 RID: 158468 RVA: 0x0097BE0C File Offset: 0x0097A00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFadeOutTime(int Idx, ref float FadeOutTime)
		{
			Bp_CloudTop_C.__GetCardFadeOutTime_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardFadeOutTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardFadeOutTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardFadeOutTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeOutTime = FadeOutTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardFadeOutTime_NativeFunctionPtr, (void*)ptr);
			FadeOutTime = ptr->FadeOutTime;
		}

		// Token: 0x06026B05 RID: 158469 RVA: 0x0097BE64 File Offset: 0x0097A064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FadeTimeTick(float DeltaTime)
		{
			Bp_CloudTop_C.__FadeTimeTick_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__FadeTimeTick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(Bp_CloudTop_C.__FadeTimeTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__FadeTimeTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__FadeTimeTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B06 RID: 158470 RVA: 0x0097BEAC File Offset: 0x0097A0AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaMin(int Idx, ref float alphamax)
		{
			Bp_CloudTop_C.__GetCardAlphaMin_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardAlphaMin_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardAlphaMin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardAlphaMin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphamax = alphamax;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardAlphaMin_NativeFunctionPtr, (void*)ptr);
			alphamax = ptr->alphamax;
		}

		// Token: 0x06026B07 RID: 158471 RVA: 0x0097BF04 File Offset: 0x0097A104
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaMax(int Idx, ref float alphamax)
		{
			Bp_CloudTop_C.__GetCardAlphaMax_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardAlphaMax_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardAlphaMax_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardAlphaMax_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphamax = alphamax;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardAlphaMax_NativeFunctionPtr, (void*)ptr);
			alphamax = ptr->alphamax;
		}

		// Token: 0x06026B08 RID: 158472 RVA: 0x0097BF5C File Offset: 0x0097A15C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaControl(int Idx, ref float alphacontrol)
		{
			Bp_CloudTop_C.__GetCardAlphaControl_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardAlphaControl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardAlphaControl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardAlphaControl_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphacontrol = alphacontrol;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardAlphaControl_NativeFunctionPtr, (void*)ptr);
			alphacontrol = ptr->alphacontrol;
		}

		// Token: 0x06026B09 RID: 158473 RVA: 0x0097BFB4 File Offset: 0x0097A1B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardScale(int Idx, UStaticMeshComponent SMComponent, ref FVector scale)
		{
			Bp_CloudTop_C.__GetCardScale_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardScale_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->SMComponent = ((SMComponent != null) ? SMComponent.NativePtr : IntPtr.Zero);
			ptr->scale = scale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardScale_NativeFunctionPtr, (void*)ptr);
			scale = ptr->scale;
		}

		// Token: 0x06026B0A RID: 158474 RVA: 0x0097C02C File Offset: 0x0097A22C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardRotator(int Idx, ref FRotator Rotator)
		{
			Bp_CloudTop_C.__GetCardRotator_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardRotator_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardRotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardRotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->Rotator = Rotator;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardRotator_NativeFunctionPtr, (void*)ptr);
			Rotator = ptr->Rotator;
		}

		// Token: 0x06026B0B RID: 158475 RVA: 0x0097C08C File Offset: 0x0097A28C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardTextureIdx(int Idx, ref int TextureIdx)
		{
			Bp_CloudTop_C.__GetCardTextureIdx_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__GetCardTextureIdx_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudTop_C.__GetCardTextureIdx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__GetCardTextureIdx_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->TextureIdx = TextureIdx;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__GetCardTextureIdx_NativeFunctionPtr, (void*)ptr);
			TextureIdx = ptr->TextureIdx;
		}

		// Token: 0x06026B0C RID: 158476 RVA: 0x0097C0E4 File Offset: 0x0097A2E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Card_Offset(int Idx, FVector DefaultOffset, ref FVector Offset)
		{
			Bp_CloudTop_C.__Get_Card_Offset_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__Get_Card_Offset_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(Bp_CloudTop_C.__Get_Card_Offset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__Get_Card_Offset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->DefaultOffset = DefaultOffset;
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__Get_Card_Offset_NativeFunctionPtr, (void*)ptr);
			Offset = ptr->Offset;
		}

		// Token: 0x06026B0D RID: 158477 RVA: 0x0097C149 File Offset: 0x0097A349
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetupCloudCards()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__SetupCloudCards_NativeFunctionPtr, null);
		}

		// Token: 0x06026B0E RID: 158478 RVA: 0x0097C15D File Offset: 0x0097A35D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026B0F RID: 158479 RVA: 0x0097C171 File Offset: 0x0097A371
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Bp_CloudTop_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B10 RID: 158480 RVA: 0x0097C188 File Offset: 0x0097A388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			Bp_CloudTop_C.__ReceiveTick_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudTop_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudTop_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B11 RID: 158481 RVA: 0x0097C1D0 File Offset: 0x0097A3D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			Bp_CloudTop_C.__ReceiveTick_FunctionParams* ptr = stackalloc Bp_CloudTop_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudTop_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudTop_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Bp_CloudTop_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026B12 RID: 158482 RVA: 0x0097C217 File Offset: 0x0097A417
		protected Bp_CloudTop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013722 RID: 79650
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudTop.Bp_CloudTop_C";

		// Token: 0x04013723 RID: 79651
		private static IntPtr _ClassPtr;

		// Token: 0x04013724 RID: 79652
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013725 RID: 79653
		internal static int __PropertyOffset_1;

		// Token: 0x04013726 RID: 79654
		internal static int __PropertyOffset_2;

		// Token: 0x04013727 RID: 79655
		internal static int __PropertyOffset_3;

		// Token: 0x04013728 RID: 79656
		internal static int __PropertyOffset_4;

		// Token: 0x04013729 RID: 79657
		internal static int __PropertyOffset_5;

		// Token: 0x0401372A RID: 79658
		internal static int __PropertyOffset_6;

		// Token: 0x0401372B RID: 79659
		internal static int __PropertyOffset_7;

		// Token: 0x0401372C RID: 79660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _CloudCardComponents;

		// Token: 0x0401372D RID: 79661
		internal static int __PropertyOffset_8;

		// Token: 0x0401372E RID: 79662
		internal static int __PropertyOffset_9;

		// Token: 0x0401372F RID: 79663
		internal static int __PropertyOffset_10;

		// Token: 0x04013730 RID: 79664
		internal static int __PropertyOffset_11;

		// Token: 0x04013731 RID: 79665
		internal static int __PropertyOffset_12;

		// Token: 0x04013732 RID: 79666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCloudTopData> _CloudDatas;

		// Token: 0x04013733 RID: 79667
		internal static int __PropertyOffset_13;

		// Token: 0x04013734 RID: 79668
		internal static int __PropertyOffset_14;

		// Token: 0x04013735 RID: 79669
		internal static int __PropertyOffset_15;

		// Token: 0x04013736 RID: 79670
		[Nullable(2)]
		private TArray<float> _FadeTime;

		// Token: 0x04013737 RID: 79671
		internal static int __PropertyOffset_16;

		// Token: 0x04013738 RID: 79672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CloudMaterials;

		// Token: 0x04013739 RID: 79673
		internal static int __PropertyOffset_17;

		// Token: 0x0401373A RID: 79674
		internal static int __PropertyOffset_18;

		// Token: 0x0401373B RID: 79675
		private static IntPtr __GetCardBrightness_NativeFunctionPtr;

		// Token: 0x0401373C RID: 79676
		private static IntPtr __GetCardDisappearTime_NativeFunctionPtr;

		// Token: 0x0401373D RID: 79677
		private static IntPtr __GetFadeTickTime_NativeFunctionPtr;

		// Token: 0x0401373E RID: 79678
		private static IntPtr __GetCardMaterial_NativeFunctionPtr;

		// Token: 0x0401373F RID: 79679
		private static IntPtr __GetCardFullStayTime_NativeFunctionPtr;

		// Token: 0x04013740 RID: 79680
		private static IntPtr __GetCardFadeInTime_NativeFunctionPtr;

		// Token: 0x04013741 RID: 79681
		private static IntPtr __GetCardFadeOutTime_NativeFunctionPtr;

		// Token: 0x04013742 RID: 79682
		private static IntPtr __FadeTimeTick_NativeFunctionPtr;

		// Token: 0x04013743 RID: 79683
		private static IntPtr __GetCardAlphaMin_NativeFunctionPtr;

		// Token: 0x04013744 RID: 79684
		private static IntPtr __GetCardAlphaMax_NativeFunctionPtr;

		// Token: 0x04013745 RID: 79685
		private static IntPtr __GetCardAlphaControl_NativeFunctionPtr;

		// Token: 0x04013746 RID: 79686
		private static IntPtr __GetCardScale_NativeFunctionPtr;

		// Token: 0x04013747 RID: 79687
		private static IntPtr __GetCardRotator_NativeFunctionPtr;

		// Token: 0x04013748 RID: 79688
		private static IntPtr __GetCardTextureIdx_NativeFunctionPtr;

		// Token: 0x04013749 RID: 79689
		private static IntPtr __Get_Card_Offset_NativeFunctionPtr;

		// Token: 0x0401374A RID: 79690
		private static IntPtr __SetupCloudCards_NativeFunctionPtr;

		// Token: 0x0401374B RID: 79691
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401374C RID: 79692
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A138 RID: 41272
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardBrightness_FunctionParams
		{
			// Token: 0x04031CCA RID: 203978
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CCB RID: 203979
			[FieldOffset(4)]
			public float Brightness;
		}

		// Token: 0x0200A139 RID: 41273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardDisappearTime_FunctionParams
		{
			// Token: 0x04031CCC RID: 203980
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CCD RID: 203981
			[FieldOffset(4)]
			public float FullStayTime;
		}

		// Token: 0x0200A13A RID: 41274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetFadeTickTime_FunctionParams
		{
			// Token: 0x04031CCE RID: 203982
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CCF RID: 203983
			[FieldOffset(4)]
			public float FadeTime;
		}

		// Token: 0x0200A13B RID: 41275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetCardMaterial_FunctionParams
		{
			// Token: 0x04031CD0 RID: 203984
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CD1 RID: 203985
			[FieldOffset(8)]
			public IntPtr mat;
		}

		// Token: 0x0200A13C RID: 41276
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFullStayTime_FunctionParams
		{
			// Token: 0x04031CD2 RID: 203986
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CD3 RID: 203987
			[FieldOffset(4)]
			public float FullStayTime;
		}

		// Token: 0x0200A13D RID: 41277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFadeInTime_FunctionParams
		{
			// Token: 0x04031CD4 RID: 203988
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CD5 RID: 203989
			[FieldOffset(4)]
			public float FadeInTime;
		}

		// Token: 0x0200A13E RID: 41278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFadeOutTime_FunctionParams
		{
			// Token: 0x04031CD6 RID: 203990
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CD7 RID: 203991
			[FieldOffset(4)]
			public float FadeOutTime;
		}

		// Token: 0x0200A13F RID: 41279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __FadeTimeTick_FunctionParams
		{
			// Token: 0x04031CD8 RID: 203992
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A140 RID: 41280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaMin_FunctionParams
		{
			// Token: 0x04031CD9 RID: 203993
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CDA RID: 203994
			[FieldOffset(4)]
			public float alphamax;
		}

		// Token: 0x0200A141 RID: 41281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaMax_FunctionParams
		{
			// Token: 0x04031CDB RID: 203995
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CDC RID: 203996
			[FieldOffset(4)]
			public float alphamax;
		}

		// Token: 0x0200A142 RID: 41282
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaControl_FunctionParams
		{
			// Token: 0x04031CDD RID: 203997
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CDE RID: 203998
			[FieldOffset(4)]
			public float alphacontrol;
		}

		// Token: 0x0200A143 RID: 41283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __GetCardScale_FunctionParams
		{
			// Token: 0x04031CDF RID: 203999
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CE0 RID: 204000
			[FieldOffset(8)]
			public IntPtr SMComponent;

			// Token: 0x04031CE1 RID: 204001
			[FieldOffset(16)]
			public FVector scale;
		}

		// Token: 0x0200A144 RID: 41284
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __GetCardRotator_FunctionParams
		{
			// Token: 0x04031CE2 RID: 204002
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CE3 RID: 204003
			[FieldOffset(4)]
			public FRotator Rotator;
		}

		// Token: 0x0200A145 RID: 41285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardTextureIdx_FunctionParams
		{
			// Token: 0x04031CE4 RID: 204004
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CE5 RID: 204005
			[FieldOffset(4)]
			public int TextureIdx;
		}

		// Token: 0x0200A146 RID: 41286
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __Get_Card_Offset_FunctionParams
		{
			// Token: 0x04031CE6 RID: 204006
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CE7 RID: 204007
			[FieldOffset(4)]
			public FVector DefaultOffset;

			// Token: 0x04031CE8 RID: 204008
			[FieldOffset(16)]
			public FVector Offset;
		}

		// Token: 0x0200A147 RID: 41287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CE9 RID: 204009
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
