using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B02 RID: 15106
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FlickerLight.BP_FlickerLight_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_FlickerLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D08 RID: 134408 RVA: 0x008DDDE1 File Offset: 0x008DBFE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlickerLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FlickerLight.BP_FlickerLight_C");
			}
			return BP_FlickerLight_C._ClassPtr;
		}

		// Token: 0x06020D09 RID: 134409 RVA: 0x008DDE08 File Offset: 0x008DC008
		public BP_FlickerLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlickerLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D0A RID: 134410 RVA: 0x008DDE30 File Offset: 0x008DC030
		[NullableContext(1)]
		public BP_FlickerLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlickerLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x06020D0B RID: 134411 RVA: 0x008DDE63 File Offset: 0x008DC063
		// (set) Token: 0x06020D0C RID: 134412 RVA: 0x008DDE77 File Offset: 0x008DC077
		public unsafe UStaticMeshComponent FogMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x06020D0D RID: 134413 RVA: 0x008DDE8C File Offset: 0x008DC08C
		// (set) Token: 0x06020D0E RID: 134414 RVA: 0x008DDEA0 File Offset: 0x008DC0A0
		public unsafe UStaticMeshComponent LightMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x06020D0F RID: 134415 RVA: 0x008DDEB5 File Offset: 0x008DC0B5
		// (set) Token: 0x06020D10 RID: 134416 RVA: 0x008DDEC9 File Offset: 0x008DC0C9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x06020D11 RID: 134417 RVA: 0x008DDEE0 File Offset: 0x008DC0E0
		// (set) Token: 0x06020D12 RID: 134418 RVA: 0x008DDF19 File Offset: 0x008DC119
		[Nullable(1)]
		public TArray<float> LightsIntensity
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LightsIntensity) == null)
				{
					result = (this._LightsIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LightsIntensity.CopyAssign(value);
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x06020D13 RID: 134419 RVA: 0x008DDF27 File Offset: 0x008DC127
		// (set) Token: 0x06020D14 RID: 134420 RVA: 0x008DDF37 File Offset: 0x008DC137
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x06020D15 RID: 134421 RVA: 0x008DDF48 File Offset: 0x008DC148
		// (set) Token: 0x06020D16 RID: 134422 RVA: 0x008DDF5C File Offset: 0x008DC15C
		public unsafe UStaticMesh LightModel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x06020D17 RID: 134423 RVA: 0x008DDF71 File Offset: 0x008DC171
		// (set) Token: 0x06020D18 RID: 134424 RVA: 0x008DDF85 File Offset: 0x008DC185
		public unsafe UMaterialInstance LightMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x06020D19 RID: 134425 RVA: 0x008DDF9A File Offset: 0x008DC19A
		// (set) Token: 0x06020D1A RID: 134426 RVA: 0x008DDFAA File Offset: 0x008DC1AA
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x06020D1B RID: 134427 RVA: 0x008DDFBB File Offset: 0x008DC1BB
		// (set) Token: 0x06020D1C RID: 134428 RVA: 0x008DDFCB File Offset: 0x008DC1CB
		public unsafe float Light
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x06020D1D RID: 134429 RVA: 0x008DDFDC File Offset: 0x008DC1DC
		// (set) Token: 0x06020D1E RID: 134430 RVA: 0x008DDFEC File Offset: 0x008DC1EC
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x06020D1F RID: 134431 RVA: 0x008DDFFD File Offset: 0x008DC1FD
		// (set) Token: 0x06020D20 RID: 134432 RVA: 0x008DE00D File Offset: 0x008DC20D
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x06020D21 RID: 134433 RVA: 0x008DE01E File Offset: 0x008DC21E
		// (set) Token: 0x06020D22 RID: 134434 RVA: 0x008DE02E File Offset: 0x008DC22E
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x06020D23 RID: 134435 RVA: 0x008DE03F File Offset: 0x008DC23F
		// (set) Token: 0x06020D24 RID: 134436 RVA: 0x008DE053 File Offset: 0x008DC253
		public unsafe FLinearColor EmissionDayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x06020D25 RID: 134437 RVA: 0x008DE068 File Offset: 0x008DC268
		// (set) Token: 0x06020D26 RID: 134438 RVA: 0x008DE07C File Offset: 0x008DC27C
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x06020D27 RID: 134439 RVA: 0x008DE091 File Offset: 0x008DC291
		// (set) Token: 0x06020D28 RID: 134440 RVA: 0x008DE0A1 File Offset: 0x008DC2A1
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x06020D29 RID: 134441 RVA: 0x008DE0B2 File Offset: 0x008DC2B2
		// (set) Token: 0x06020D2A RID: 134442 RVA: 0x008DE0C6 File Offset: 0x008DC2C6
		public unsafe UStaticMesh StaticMeshCone
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x06020D2B RID: 134443 RVA: 0x008DE0DB File Offset: 0x008DC2DB
		// (set) Token: 0x06020D2C RID: 134444 RVA: 0x008DE0EF File Offset: 0x008DC2EF
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x06020D2D RID: 134445 RVA: 0x008DE104 File Offset: 0x008DC304
		// (set) Token: 0x06020D2E RID: 134446 RVA: 0x008DE118 File Offset: 0x008DC318
		public unsafe UMaterialInstance MaterialInstanceB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x06020D2F RID: 134447 RVA: 0x008DE12D File Offset: 0x008DC32D
		// (set) Token: 0x06020D30 RID: 134448 RVA: 0x008DE141 File Offset: 0x008DC341
		public unsafe UMaterialInstance MaterialInstanceBT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x06020D31 RID: 134449 RVA: 0x008DE156 File Offset: 0x008DC356
		// (set) Token: 0x06020D32 RID: 134450 RVA: 0x008DE16A File Offset: 0x008DC36A
		public unsafe UMaterialInstance MaterialInstanceT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlickerLight_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x06020D33 RID: 134451 RVA: 0x008DE17F File Offset: 0x008DC37F
		// (set) Token: 0x06020D34 RID: 134452 RVA: 0x008DE18F File Offset: 0x008DC38F
		public unsafe bool EnableBottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x06020D35 RID: 134453 RVA: 0x008DE1A0 File Offset: 0x008DC3A0
		// (set) Token: 0x06020D36 RID: 134454 RVA: 0x008DE1B0 File Offset: 0x008DC3B0
		public unsafe bool IsWholeDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x06020D37 RID: 134455 RVA: 0x008DE1C1 File Offset: 0x008DC3C1
		// (set) Token: 0x06020D38 RID: 134456 RVA: 0x008DE1D1 File Offset: 0x008DC3D1
		public unsafe float ConeSin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x06020D39 RID: 134457 RVA: 0x008DE1E2 File Offset: 0x008DC3E2
		// (set) Token: 0x06020D3A RID: 134458 RVA: 0x008DE1F2 File Offset: 0x008DC3F2
		public unsafe float RadFallOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x06020D3B RID: 134459 RVA: 0x008DE203 File Offset: 0x008DC403
		// (set) Token: 0x06020D3C RID: 134460 RVA: 0x008DE213 File Offset: 0x008DC413
		public unsafe float TopClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x06020D3D RID: 134461 RVA: 0x008DE224 File Offset: 0x008DC424
		// (set) Token: 0x06020D3E RID: 134462 RVA: 0x008DE234 File Offset: 0x008DC434
		public unsafe float TopColorLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x06020D3F RID: 134463 RVA: 0x008DE245 File Offset: 0x008DC445
		// (set) Token: 0x06020D40 RID: 134464 RVA: 0x008DE259 File Offset: 0x008DC459
		public unsafe FLinearColor TopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x06020D41 RID: 134465 RVA: 0x008DE26E File Offset: 0x008DC46E
		// (set) Token: 0x06020D42 RID: 134466 RVA: 0x008DE282 File Offset: 0x008DC482
		public unsafe FLinearColor BottomColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x06020D43 RID: 134467 RVA: 0x008DE297 File Offset: 0x008DC497
		// (set) Token: 0x06020D44 RID: 134468 RVA: 0x008DE2A7 File Offset: 0x008DC4A7
		public unsafe float SkyLightInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x06020D45 RID: 134469 RVA: 0x008DE2B8 File Offset: 0x008DC4B8
		// (set) Token: 0x06020D46 RID: 134470 RVA: 0x008DE2C8 File Offset: 0x008DC4C8
		public unsafe float SkyLightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x06020D47 RID: 134471 RVA: 0x008DE2D9 File Offset: 0x008DC4D9
		// (set) Token: 0x06020D48 RID: 134472 RVA: 0x008DE2E9 File Offset: 0x008DC4E9
		public unsafe float DepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlickerLight_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x008DE2FA File Offset: 0x008DC4FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Flicker_Off()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__Flicker_Off_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x008DE30E File Offset: 0x008DC50E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Flicker_ON()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__Flicker_ON_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4B RID: 134475 RVA: 0x008DE324 File Offset: 0x008DC524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(float Speed, ref float ElapsedTime)
		{
			BP_FlickerLight_C.__Timer_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__Timer_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_FlickerLight_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Speed = Speed;
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x06020D4C RID: 134476 RVA: 0x008DE37C File Offset: 0x008DC57C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ToggleLights(float DeltaSeconds)
		{
			BP_FlickerLight_C.__ToggleLights_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__ToggleLights_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_FlickerLight_C.__ToggleLights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__ToggleLights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__ToggleLights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D4D RID: 134477 RVA: 0x008DE3C5 File Offset: 0x008DC5C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetLightIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__GetLightIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4E RID: 134478 RVA: 0x008DE3D9 File Offset: 0x008DC5D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020D4F RID: 134479 RVA: 0x008DE3ED File Offset: 0x008DC5ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlickerLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020D50 RID: 134480 RVA: 0x008DE402 File Offset: 0x008DC602
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020D51 RID: 134481 RVA: 0x008DE416 File Offset: 0x008DC616
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlickerLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020D52 RID: 134482 RVA: 0x008DE42C File Offset: 0x008DC62C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FlickerLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlickerLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D53 RID: 134483 RVA: 0x008DE474 File Offset: 0x008DC674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FlickerLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlickerLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlickerLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020D54 RID: 134484 RVA: 0x008DE4BC File Offset: 0x008DC6BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FlickerLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlickerLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020D55 RID: 134485 RVA: 0x008DE504 File Offset: 0x008DC704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FlickerLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FlickerLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlickerLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlickerLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlickerLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020D56 RID: 134486 RVA: 0x008DE54B File Offset: 0x008DC74B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlickerLight_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06020D57 RID: 134487 RVA: 0x008DE55F File Offset: 0x008DC75F
		protected BP_FlickerLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF12 RID: 65298
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_FlickerLight.BP_FlickerLight_C";

		// Token: 0x0400FF13 RID: 65299
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF14 RID: 65300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF15 RID: 65301
		internal static int __PropertyOffset_1;

		// Token: 0x0400FF16 RID: 65302
		internal static int __PropertyOffset_2;

		// Token: 0x0400FF17 RID: 65303
		internal static int __PropertyOffset_3;

		// Token: 0x0400FF18 RID: 65304
		internal static int __PropertyOffset_4;

		// Token: 0x0400FF19 RID: 65305
		private TArray<float> _LightsIntensity;

		// Token: 0x0400FF1A RID: 65306
		internal static int __PropertyOffset_5;

		// Token: 0x0400FF1B RID: 65307
		internal static int __PropertyOffset_6;

		// Token: 0x0400FF1C RID: 65308
		internal static int __PropertyOffset_7;

		// Token: 0x0400FF1D RID: 65309
		internal static int __PropertyOffset_8;

		// Token: 0x0400FF1E RID: 65310
		internal static int __PropertyOffset_9;

		// Token: 0x0400FF1F RID: 65311
		internal static int __PropertyOffset_10;

		// Token: 0x0400FF20 RID: 65312
		internal static int __PropertyOffset_11;

		// Token: 0x0400FF21 RID: 65313
		internal static int __PropertyOffset_12;

		// Token: 0x0400FF22 RID: 65314
		internal static int __PropertyOffset_13;

		// Token: 0x0400FF23 RID: 65315
		internal static int __PropertyOffset_14;

		// Token: 0x0400FF24 RID: 65316
		internal static int __PropertyOffset_15;

		// Token: 0x0400FF25 RID: 65317
		internal static int __PropertyOffset_16;

		// Token: 0x0400FF26 RID: 65318
		internal static int __PropertyOffset_17;

		// Token: 0x0400FF27 RID: 65319
		internal static int __PropertyOffset_18;

		// Token: 0x0400FF28 RID: 65320
		internal static int __PropertyOffset_19;

		// Token: 0x0400FF29 RID: 65321
		internal static int __PropertyOffset_20;

		// Token: 0x0400FF2A RID: 65322
		internal static int __PropertyOffset_21;

		// Token: 0x0400FF2B RID: 65323
		internal static int __PropertyOffset_22;

		// Token: 0x0400FF2C RID: 65324
		internal static int __PropertyOffset_23;

		// Token: 0x0400FF2D RID: 65325
		internal static int __PropertyOffset_24;

		// Token: 0x0400FF2E RID: 65326
		internal static int __PropertyOffset_25;

		// Token: 0x0400FF2F RID: 65327
		internal static int __PropertyOffset_26;

		// Token: 0x0400FF30 RID: 65328
		internal static int __PropertyOffset_27;

		// Token: 0x0400FF31 RID: 65329
		internal static int __PropertyOffset_28;

		// Token: 0x0400FF32 RID: 65330
		internal static int __PropertyOffset_29;

		// Token: 0x0400FF33 RID: 65331
		internal static int __PropertyOffset_30;

		// Token: 0x0400FF34 RID: 65332
		internal static int __PropertyOffset_31;

		// Token: 0x0400FF35 RID: 65333
		private static IntPtr __Flicker_Off_NativeFunctionPtr;

		// Token: 0x0400FF36 RID: 65334
		private static IntPtr __Flicker_ON_NativeFunctionPtr;

		// Token: 0x0400FF37 RID: 65335
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0400FF38 RID: 65336
		private static IntPtr __ToggleLights_NativeFunctionPtr;

		// Token: 0x0400FF39 RID: 65337
		private static IntPtr __GetLightIntensity_NativeFunctionPtr;

		// Token: 0x0400FF3A RID: 65338
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF3B RID: 65339
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FF3C RID: 65340
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FF3D RID: 65341
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FF3E RID: 65342
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x02009C3E RID: 39998
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x040312EE RID: 201454
			[FieldOffset(0)]
			public float Speed;

			// Token: 0x040312EF RID: 201455
			[FieldOffset(4)]
			public float ElapsedTime;
		}

		// Token: 0x02009C3F RID: 39999
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __ToggleLights_FunctionParams
		{
			// Token: 0x040312F0 RID: 201456
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C40 RID: 40000
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312F1 RID: 201457
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C41 RID: 40001
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312F2 RID: 201458
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
