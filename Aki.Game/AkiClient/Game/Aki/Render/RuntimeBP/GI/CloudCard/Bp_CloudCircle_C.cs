using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.CloudCard
{
	// Token: 0x02003D81 RID: 15745
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudCircle.Bp_CloudCircle_C")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1704)]
	public class Bp_CloudCircle_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A91 RID: 158353 RVA: 0x0097ACCE File Offset: 0x00978ECE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Bp_CloudCircle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudCircle.Bp_CloudCircle_C");
			}
			return Bp_CloudCircle_C._ClassPtr;
		}

		// Token: 0x06026A92 RID: 158354 RVA: 0x0097ACF4 File Offset: 0x00978EF4
		public Bp_CloudCircle_C() : this(BuiltinUtils.AllocNativeUObject(Bp_CloudCircle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A93 RID: 158355 RVA: 0x0097AD1C File Offset: 0x00978F1C
		[NullableContext(1)]
		public Bp_CloudCircle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Bp_CloudCircle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x06026A94 RID: 158356 RVA: 0x0097AD4F File Offset: 0x00978F4F
		// (set) Token: 0x06026A95 RID: 158357 RVA: 0x0097AD63 File Offset: 0x00978F63
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700537D RID: 21373
		// (get) Token: 0x06026A96 RID: 158358 RVA: 0x0097AD78 File Offset: 0x00978F78
		// (set) Token: 0x06026A97 RID: 158359 RVA: 0x0097AD8C File Offset: 0x00978F8C
		[Nullable(2)]
		public unsafe UStaticMesh SM_CloudCard
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700537E RID: 21374
		// (get) Token: 0x06026A98 RID: 158360 RVA: 0x0097ADA1 File Offset: 0x00978FA1
		// (set) Token: 0x06026A99 RID: 158361 RVA: 0x0097ADB1 File Offset: 0x00978FB1
		public unsafe int CloudRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700537F RID: 21375
		// (get) Token: 0x06026A9A RID: 158362 RVA: 0x0097ADC2 File Offset: 0x00978FC2
		// (set) Token: 0x06026A9B RID: 158363 RVA: 0x0097ADD2 File Offset: 0x00978FD2
		public unsafe int CloudColumn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005380 RID: 21376
		// (get) Token: 0x06026A9C RID: 158364 RVA: 0x0097ADE3 File Offset: 0x00978FE3
		// (set) Token: 0x06026A9D RID: 158365 RVA: 0x0097ADF3 File Offset: 0x00978FF3
		public unsafe int CloudCardCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005381 RID: 21377
		// (get) Token: 0x06026A9E RID: 158366 RVA: 0x0097AE04 File Offset: 0x00979004
		// (set) Token: 0x06026A9F RID: 158367 RVA: 0x0097AE14 File Offset: 0x00979014
		public unsafe float DefaultHorizontalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005382 RID: 21378
		// (get) Token: 0x06026AA0 RID: 158368 RVA: 0x0097AE25 File Offset: 0x00979025
		// (set) Token: 0x06026AA1 RID: 158369 RVA: 0x0097AE39 File Offset: 0x00979039
		public unsafe FVector CloudUVNoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x06026AA2 RID: 158370 RVA: 0x0097AE4E File Offset: 0x0097904E
		// (set) Token: 0x06026AA3 RID: 158371 RVA: 0x0097AE62 File Offset: 0x00979062
		public unsafe FRotator DefaultRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x06026AA4 RID: 158372 RVA: 0x0097AE78 File Offset: 0x00979078
		// (set) Token: 0x06026AA5 RID: 158373 RVA: 0x0097AEB1 File Offset: 0x009790B1
		[Nullable(1)]
		public TMap<UStaticMeshComponent, UMaterialInstanceDynamic> CloudCardComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMeshComponent, UMaterialInstanceDynamic> result;
				if ((result = this._CloudCardComponents) == null)
				{
					result = (this._CloudCardComponents = new TMap<UStaticMeshComponent, UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudCardComponents.CopyAssign(value);
			}
		}

		// Token: 0x17005385 RID: 21381
		// (get) Token: 0x06026AA6 RID: 158374 RVA: 0x0097AEBF File Offset: 0x009790BF
		// (set) Token: 0x06026AA7 RID: 158375 RVA: 0x0097AECF File Offset: 0x009790CF
		public unsafe float CloudUVNoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005386 RID: 21382
		// (get) Token: 0x06026AA8 RID: 158376 RVA: 0x0097AEE0 File Offset: 0x009790E0
		// (set) Token: 0x06026AA9 RID: 158377 RVA: 0x0097AEF0 File Offset: 0x009790F0
		public unsafe float CloudUVNoiseTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005387 RID: 21383
		// (get) Token: 0x06026AAA RID: 158378 RVA: 0x0097AF01 File Offset: 0x00979101
		// (set) Token: 0x06026AAB RID: 158379 RVA: 0x0097AF11 File Offset: 0x00979111
		public unsafe float DefaultDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005388 RID: 21384
		// (get) Token: 0x06026AAC RID: 158380 RVA: 0x0097AF24 File Offset: 0x00979124
		// (set) Token: 0x06026AAD RID: 158381 RVA: 0x0097AF5D File Offset: 0x0097915D
		[Nullable(1)]
		public TArray<FKuroCloudCircleData> CloudDatas
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCloudCircleData> result;
				if ((result = this._CloudDatas) == null)
				{
					result = (this._CloudDatas = new TArray<FKuroCloudCircleData>(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudDatas.CopyAssign(value);
			}
		}

		// Token: 0x17005389 RID: 21385
		// (get) Token: 0x06026AAE RID: 158382 RVA: 0x0097AF6B File Offset: 0x0097916B
		// (set) Token: 0x06026AAF RID: 158383 RVA: 0x0097AF7B File Offset: 0x0097917B
		public unsafe float CurYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x06026AB0 RID: 158384 RVA: 0x0097AF8C File Offset: 0x0097918C
		// (set) Token: 0x06026AB1 RID: 158385 RVA: 0x0097AF9C File Offset: 0x0097919C
		public unsafe float WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x06026AB2 RID: 158386 RVA: 0x0097AFB0 File Offset: 0x009791B0
		// (set) Token: 0x06026AB3 RID: 158387 RVA: 0x0097AFE9 File Offset: 0x009791E9
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
					result = (this._FadeTime = new TArray<float>(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FadeTime.CopyAssign(value);
			}
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x06026AB4 RID: 158388 RVA: 0x0097AFF8 File Offset: 0x009791F8
		// (set) Token: 0x06026AB5 RID: 158389 RVA: 0x0097B031 File Offset: 0x00979231
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
					result = (this._CloudMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CloudMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x06026AB6 RID: 158390 RVA: 0x0097B03F File Offset: 0x0097923F
		// (set) Token: 0x06026AB7 RID: 158391 RVA: 0x0097B053 File Offset: 0x00979253
		[Nullable(2)]
		public unsafe UTexture2D CloudTex
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x06026AB8 RID: 158392 RVA: 0x0097B068 File Offset: 0x00979268
		// (set) Token: 0x06026AB9 RID: 158393 RVA: 0x0097B078 File Offset: 0x00979278
		public unsafe bool ToggleNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x06026ABA RID: 158394 RVA: 0x0097B089 File Offset: 0x00979289
		// (set) Token: 0x06026ABB RID: 158395 RVA: 0x0097B09D File Offset: 0x0097929D
		public unsafe FLinearColor CloudAmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Bp_CloudCircle_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x06026ABC RID: 158396 RVA: 0x0097B0B2 File Offset: 0x009792B2
		// (set) Token: 0x06026ABD RID: 158397 RVA: 0x0097B0C6 File Offset: 0x009792C6
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic CloudMatMid
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Bp_CloudCircle_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x06026ABE RID: 158398 RVA: 0x0097B0DC File Offset: 0x009792DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardBrightness(int Idx, ref float Brightness)
		{
			Bp_CloudCircle_C.__GetCardBrightness_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardBrightness_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardBrightness_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardBrightness_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->Brightness = Brightness;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardBrightness_NativeFunctionPtr, (void*)ptr);
			Brightness = ptr->Brightness;
		}

		// Token: 0x06026ABF RID: 158399 RVA: 0x0097B134 File Offset: 0x00979334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardDisappearTime(int Idx, ref float FullStayTime)
		{
			Bp_CloudCircle_C.__GetCardDisappearTime_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardDisappearTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardDisappearTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardDisappearTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FullStayTime = FullStayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardDisappearTime_NativeFunctionPtr, (void*)ptr);
			FullStayTime = ptr->FullStayTime;
		}

		// Token: 0x06026AC0 RID: 158400 RVA: 0x0097B18C File Offset: 0x0097938C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetFadeTickTime(int Idx, ref float FadeTime)
		{
			Bp_CloudCircle_C.__GetFadeTickTime_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetFadeTickTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetFadeTickTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetFadeTickTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeTime = FadeTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetFadeTickTime_NativeFunctionPtr, (void*)ptr);
			FadeTime = ptr->FadeTime;
		}

		// Token: 0x06026AC1 RID: 158401 RVA: 0x0097B1E4 File Offset: 0x009793E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FadeTimeTick(float DeltaTime)
		{
			Bp_CloudCircle_C.__FadeTimeTick_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__FadeTimeTick_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(Bp_CloudCircle_C.__FadeTimeTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__FadeTimeTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__FadeTimeTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026AC2 RID: 158402 RVA: 0x0097B22C File Offset: 0x0097942C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardMaterial(int Idx, ref UMaterialInstanceDynamic MatIns)
		{
			Bp_CloudCircle_C.__GetCardMaterial_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardMaterial_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardMaterial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardMaterial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ref Bp_CloudCircle_C.__GetCardMaterial_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MatIns;
			ptr2.MatIns = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardMaterial_NativeFunctionPtr, (void*)ptr);
			MatIns = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MatIns);
		}

		// Token: 0x06026AC3 RID: 158403 RVA: 0x0097B298 File Offset: 0x00979498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFullStayTime(int Idx, ref float FullStayTime)
		{
			Bp_CloudCircle_C.__GetCardFullStayTime_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardFullStayTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardFullStayTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardFullStayTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FullStayTime = FullStayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardFullStayTime_NativeFunctionPtr, (void*)ptr);
			FullStayTime = ptr->FullStayTime;
		}

		// Token: 0x06026AC4 RID: 158404 RVA: 0x0097B2F0 File Offset: 0x009794F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFadeInTime(int Idx, ref float FadeInTime)
		{
			Bp_CloudCircle_C.__GetCardFadeInTime_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardFadeInTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardFadeInTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardFadeInTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeInTime = FadeInTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardFadeInTime_NativeFunctionPtr, (void*)ptr);
			FadeInTime = ptr->FadeInTime;
		}

		// Token: 0x06026AC5 RID: 158405 RVA: 0x0097B348 File Offset: 0x00979548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardFadeOutTime(int Idx, ref float FadeOutTime)
		{
			Bp_CloudCircle_C.__GetCardFadeOutTime_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardFadeOutTime_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardFadeOutTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardFadeOutTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->FadeOutTime = FadeOutTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardFadeOutTime_NativeFunctionPtr, (void*)ptr);
			FadeOutTime = ptr->FadeOutTime;
		}

		// Token: 0x06026AC6 RID: 158406 RVA: 0x0097B3A0 File Offset: 0x009795A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaMin(int Idx, ref float alphamin)
		{
			Bp_CloudCircle_C.__GetCardAlphaMin_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardAlphaMin_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardAlphaMin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardAlphaMin_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphamin = alphamin;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardAlphaMin_NativeFunctionPtr, (void*)ptr);
			alphamin = ptr->alphamin;
		}

		// Token: 0x06026AC7 RID: 158407 RVA: 0x0097B3F8 File Offset: 0x009795F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaMax(int Idx, ref float alphamax)
		{
			Bp_CloudCircle_C.__GetCardAlphaMax_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardAlphaMax_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardAlphaMax_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardAlphaMax_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphamax = alphamax;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardAlphaMax_NativeFunctionPtr, (void*)ptr);
			alphamax = ptr->alphamax;
		}

		// Token: 0x06026AC8 RID: 158408 RVA: 0x0097B450 File Offset: 0x00979650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardAlphaControl(int Idx, ref float alphacontrol)
		{
			Bp_CloudCircle_C.__GetCardAlphaControl_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardAlphaControl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardAlphaControl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardAlphaControl_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->alphacontrol = alphacontrol;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardAlphaControl_NativeFunctionPtr, (void*)ptr);
			alphacontrol = ptr->alphacontrol;
		}

		// Token: 0x06026AC9 RID: 158409 RVA: 0x0097B4A8 File Offset: 0x009796A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardOffset(int Idx, ref FVector Offset)
		{
			Bp_CloudCircle_C.__GetCardOffset_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardOffset_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardOffset_NativeFunctionPtr, (void*)ptr);
			Offset = ptr->Offset;
		}

		// Token: 0x06026ACA RID: 158410 RVA: 0x0097B508 File Offset: 0x00979708
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardScale(int Idx, UStaticMeshComponent SMComponent, ref FVector scale)
		{
			Bp_CloudCircle_C.__GetCardScale_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardScale_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->SMComponent = ((SMComponent != null) ? SMComponent.NativePtr : IntPtr.Zero);
			ptr->scale = scale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardScale_NativeFunctionPtr, (void*)ptr);
			scale = ptr->scale;
		}

		// Token: 0x06026ACB RID: 158411 RVA: 0x0097B580 File Offset: 0x00979780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Card_Horizontal_Offset(int Idx, ref float HorizontalOffset)
		{
			Bp_CloudCircle_C.__Get_Card_Horizontal_Offset_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__Get_Card_Horizontal_Offset_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Bp_CloudCircle_C.__Get_Card_Horizontal_Offset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__Get_Card_Horizontal_Offset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->HorizontalOffset = HorizontalOffset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__Get_Card_Horizontal_Offset_NativeFunctionPtr, (void*)ptr);
			HorizontalOffset = ptr->HorizontalOffset;
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x0097B5D8 File Offset: 0x009797D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardTextureIdx(int Idx, ref int TextureIdx)
		{
			Bp_CloudCircle_C.__GetCardTextureIdx_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardTextureIdx_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardTextureIdx_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardTextureIdx_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->TextureIdx = TextureIdx;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardTextureIdx_NativeFunctionPtr, (void*)ptr);
			TextureIdx = ptr->TextureIdx;
		}

		// Token: 0x06026ACD RID: 158413 RVA: 0x0097B630 File Offset: 0x00979830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardRotator(int Idx, ref FRotator rotator)
		{
			Bp_CloudCircle_C.__GetCardRotator_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardRotator_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardRotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardRotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->rotator = rotator;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardRotator_NativeFunctionPtr, (void*)ptr);
			rotator = ptr->rotator;
		}

		// Token: 0x06026ACE RID: 158414 RVA: 0x0097B690 File Offset: 0x00979890
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCardDis(int Idx, ref float Distance)
		{
			Bp_CloudCircle_C.__GetCardDis_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__GetCardDis_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(Bp_CloudCircle_C.__GetCardDis_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__GetCardDis_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Idx = Idx;
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__GetCardDis_NativeFunctionPtr, (void*)ptr);
			Distance = ptr->Distance;
		}

		// Token: 0x06026ACF RID: 158415 RVA: 0x0097B6E6 File Offset: 0x009798E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetupCloudCards()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__SetupCloudCards_NativeFunctionPtr, null);
		}

		// Token: 0x06026AD0 RID: 158416 RVA: 0x0097B6FA File Offset: 0x009798FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026AD1 RID: 158417 RVA: 0x0097B70E File Offset: 0x0097990E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Bp_CloudCircle_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026AD2 RID: 158418 RVA: 0x0097B724 File Offset: 0x00979924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			Bp_CloudCircle_C.__ReceiveTick_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudCircle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026AD3 RID: 158419 RVA: 0x0097B76C File Offset: 0x0097996C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			Bp_CloudCircle_C.__ReceiveTick_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudCircle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Bp_CloudCircle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026AD4 RID: 158420 RVA: 0x0097B7B4 File Offset: 0x009799B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			Bp_CloudCircle_C.__EditorTick_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudCircle_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Bp_CloudCircle_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026AD5 RID: 158421 RVA: 0x0097B7FC File Offset: 0x009799FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			Bp_CloudCircle_C.__EditorTick_FunctionParams* ptr = stackalloc Bp_CloudCircle_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Bp_CloudCircle_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Bp_CloudCircle_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Bp_CloudCircle_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026AD6 RID: 158422 RVA: 0x0097B843 File Offset: 0x00979A43
		protected Bp_CloudCircle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136F1 RID: 79601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/CloudCard/Bp_CloudCircle.Bp_CloudCircle_C";

		// Token: 0x040136F2 RID: 79602
		private static IntPtr _ClassPtr;

		// Token: 0x040136F3 RID: 79603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040136F4 RID: 79604
		internal static int __PropertyOffset_1;

		// Token: 0x040136F5 RID: 79605
		internal static int __PropertyOffset_2;

		// Token: 0x040136F6 RID: 79606
		internal static int __PropertyOffset_3;

		// Token: 0x040136F7 RID: 79607
		internal static int __PropertyOffset_4;

		// Token: 0x040136F8 RID: 79608
		internal static int __PropertyOffset_5;

		// Token: 0x040136F9 RID: 79609
		internal static int __PropertyOffset_6;

		// Token: 0x040136FA RID: 79610
		internal static int __PropertyOffset_7;

		// Token: 0x040136FB RID: 79611
		internal static int __PropertyOffset_8;

		// Token: 0x040136FC RID: 79612
		internal static int __PropertyOffset_9;

		// Token: 0x040136FD RID: 79613
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMeshComponent, UMaterialInstanceDynamic> _CloudCardComponents;

		// Token: 0x040136FE RID: 79614
		internal static int __PropertyOffset_10;

		// Token: 0x040136FF RID: 79615
		internal static int __PropertyOffset_11;

		// Token: 0x04013700 RID: 79616
		internal static int __PropertyOffset_12;

		// Token: 0x04013701 RID: 79617
		internal static int __PropertyOffset_13;

		// Token: 0x04013702 RID: 79618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCloudCircleData> _CloudDatas;

		// Token: 0x04013703 RID: 79619
		internal static int __PropertyOffset_14;

		// Token: 0x04013704 RID: 79620
		internal static int __PropertyOffset_15;

		// Token: 0x04013705 RID: 79621
		internal static int __PropertyOffset_16;

		// Token: 0x04013706 RID: 79622
		[Nullable(2)]
		private TArray<float> _FadeTime;

		// Token: 0x04013707 RID: 79623
		internal static int __PropertyOffset_17;

		// Token: 0x04013708 RID: 79624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _CloudMaterials;

		// Token: 0x04013709 RID: 79625
		internal static int __PropertyOffset_18;

		// Token: 0x0401370A RID: 79626
		internal static int __PropertyOffset_19;

		// Token: 0x0401370B RID: 79627
		internal static int __PropertyOffset_20;

		// Token: 0x0401370C RID: 79628
		internal static int __PropertyOffset_21;

		// Token: 0x0401370D RID: 79629
		private static IntPtr __GetCardBrightness_NativeFunctionPtr;

		// Token: 0x0401370E RID: 79630
		private static IntPtr __GetCardDisappearTime_NativeFunctionPtr;

		// Token: 0x0401370F RID: 79631
		private static IntPtr __GetFadeTickTime_NativeFunctionPtr;

		// Token: 0x04013710 RID: 79632
		private static IntPtr __FadeTimeTick_NativeFunctionPtr;

		// Token: 0x04013711 RID: 79633
		private static IntPtr __GetCardMaterial_NativeFunctionPtr;

		// Token: 0x04013712 RID: 79634
		private static IntPtr __GetCardFullStayTime_NativeFunctionPtr;

		// Token: 0x04013713 RID: 79635
		private static IntPtr __GetCardFadeInTime_NativeFunctionPtr;

		// Token: 0x04013714 RID: 79636
		private static IntPtr __GetCardFadeOutTime_NativeFunctionPtr;

		// Token: 0x04013715 RID: 79637
		private static IntPtr __GetCardAlphaMin_NativeFunctionPtr;

		// Token: 0x04013716 RID: 79638
		private static IntPtr __GetCardAlphaMax_NativeFunctionPtr;

		// Token: 0x04013717 RID: 79639
		private static IntPtr __GetCardAlphaControl_NativeFunctionPtr;

		// Token: 0x04013718 RID: 79640
		private static IntPtr __GetCardOffset_NativeFunctionPtr;

		// Token: 0x04013719 RID: 79641
		private static IntPtr __GetCardScale_NativeFunctionPtr;

		// Token: 0x0401371A RID: 79642
		private static IntPtr __Get_Card_Horizontal_Offset_NativeFunctionPtr;

		// Token: 0x0401371B RID: 79643
		private static IntPtr __GetCardTextureIdx_NativeFunctionPtr;

		// Token: 0x0401371C RID: 79644
		private static IntPtr __GetCardRotator_NativeFunctionPtr;

		// Token: 0x0401371D RID: 79645
		private static IntPtr __GetCardDis_NativeFunctionPtr;

		// Token: 0x0401371E RID: 79646
		private static IntPtr __SetupCloudCards_NativeFunctionPtr;

		// Token: 0x0401371F RID: 79647
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013720 RID: 79648
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013721 RID: 79649
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A125 RID: 41253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardBrightness_FunctionParams
		{
			// Token: 0x04031CA6 RID: 203942
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CA7 RID: 203943
			[FieldOffset(4)]
			public float Brightness;
		}

		// Token: 0x0200A126 RID: 41254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardDisappearTime_FunctionParams
		{
			// Token: 0x04031CA8 RID: 203944
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CA9 RID: 203945
			[FieldOffset(4)]
			public float FullStayTime;
		}

		// Token: 0x0200A127 RID: 41255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetFadeTickTime_FunctionParams
		{
			// Token: 0x04031CAA RID: 203946
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CAB RID: 203947
			[FieldOffset(4)]
			public float FadeTime;
		}

		// Token: 0x0200A128 RID: 41256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FadeTimeTick_FunctionParams
		{
			// Token: 0x04031CAC RID: 203948
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A129 RID: 41257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetCardMaterial_FunctionParams
		{
			// Token: 0x04031CAD RID: 203949
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CAE RID: 203950
			[FieldOffset(8)]
			public IntPtr MatIns;
		}

		// Token: 0x0200A12A RID: 41258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFullStayTime_FunctionParams
		{
			// Token: 0x04031CAF RID: 203951
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CB0 RID: 203952
			[FieldOffset(4)]
			public float FullStayTime;
		}

		// Token: 0x0200A12B RID: 41259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFadeInTime_FunctionParams
		{
			// Token: 0x04031CB1 RID: 203953
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CB2 RID: 203954
			[FieldOffset(4)]
			public float FadeInTime;
		}

		// Token: 0x0200A12C RID: 41260
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCardFadeOutTime_FunctionParams
		{
			// Token: 0x04031CB3 RID: 203955
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CB4 RID: 203956
			[FieldOffset(4)]
			public float FadeOutTime;
		}

		// Token: 0x0200A12D RID: 41261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaMin_FunctionParams
		{
			// Token: 0x04031CB5 RID: 203957
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CB6 RID: 203958
			[FieldOffset(4)]
			public float alphamin;
		}

		// Token: 0x0200A12E RID: 41262
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaMax_FunctionParams
		{
			// Token: 0x04031CB7 RID: 203959
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CB8 RID: 203960
			[FieldOffset(4)]
			public float alphamax;
		}

		// Token: 0x0200A12F RID: 41263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCardAlphaControl_FunctionParams
		{
			// Token: 0x04031CB9 RID: 203961
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CBA RID: 203962
			[FieldOffset(4)]
			public float alphacontrol;
		}

		// Token: 0x0200A130 RID: 41264
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetCardOffset_FunctionParams
		{
			// Token: 0x04031CBB RID: 203963
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CBC RID: 203964
			[FieldOffset(4)]
			public FVector Offset;
		}

		// Token: 0x0200A131 RID: 41265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __GetCardScale_FunctionParams
		{
			// Token: 0x04031CBD RID: 203965
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CBE RID: 203966
			[FieldOffset(8)]
			public IntPtr SMComponent;

			// Token: 0x04031CBF RID: 203967
			[FieldOffset(16)]
			public FVector scale;
		}

		// Token: 0x0200A132 RID: 41266
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Get_Card_Horizontal_Offset_FunctionParams
		{
			// Token: 0x04031CC0 RID: 203968
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CC1 RID: 203969
			[FieldOffset(4)]
			public float HorizontalOffset;
		}

		// Token: 0x0200A133 RID: 41267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetCardTextureIdx_FunctionParams
		{
			// Token: 0x04031CC2 RID: 203970
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CC3 RID: 203971
			[FieldOffset(4)]
			public int TextureIdx;
		}

		// Token: 0x0200A134 RID: 41268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetCardRotator_FunctionParams
		{
			// Token: 0x04031CC4 RID: 203972
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CC5 RID: 203973
			[FieldOffset(4)]
			public FRotator rotator;
		}

		// Token: 0x0200A135 RID: 41269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __GetCardDis_FunctionParams
		{
			// Token: 0x04031CC6 RID: 203974
			[FieldOffset(0)]
			public int Idx;

			// Token: 0x04031CC7 RID: 203975
			[FieldOffset(4)]
			public float Distance;
		}

		// Token: 0x0200A136 RID: 41270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CC8 RID: 203976
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A137 RID: 41271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031CC9 RID: 203977
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
