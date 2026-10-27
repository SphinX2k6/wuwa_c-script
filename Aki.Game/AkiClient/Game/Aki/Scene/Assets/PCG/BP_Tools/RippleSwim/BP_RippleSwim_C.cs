using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.Render.Data.Water;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.RippleSwim
{
	// Token: 0x02003A70 RID: 14960
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C")]
	[UnrealStructLayout(2152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2145)]
	public class BP_RippleSwim_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9EC RID: 129516 RVA: 0x008BD740 File Offset: 0x008BB940
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RippleSwim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C");
			}
			return BP_RippleSwim_C._ClassPtr;
		}

		// Token: 0x0601F9ED RID: 129517 RVA: 0x008BD764 File Offset: 0x008BB964
		public BP_RippleSwim_C() : this(BuiltinUtils.AllocNativeUObject(BP_RippleSwim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9EE RID: 129518 RVA: 0x008BD78C File Offset: 0x008BB98C
		[NullableContext(1)]
		public BP_RippleSwim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RippleSwim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0601F9EF RID: 129519 RVA: 0x008BD7BF File Offset: 0x008BB9BF
		// (set) Token: 0x0601F9F0 RID: 129520 RVA: 0x008BD7D3 File Offset: 0x008BB9D3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0601F9F1 RID: 129521 RVA: 0x008BD7E8 File Offset: 0x008BB9E8
		// (set) Token: 0x0601F9F2 RID: 129522 RVA: 0x008BD7FC File Offset: 0x008BB9FC
		public unsafe UMaterialInstanceDynamic AddNewMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0601F9F3 RID: 129523 RVA: 0x008BD811 File Offset: 0x008BBA11
		// (set) Token: 0x0601F9F4 RID: 129524 RVA: 0x008BD825 File Offset: 0x008BBA25
		public unsafe UMaterialInstanceDynamic tempToPrevMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0601F9F5 RID: 129525 RVA: 0x008BD83A File Offset: 0x008BBA3A
		// (set) Token: 0x0601F9F6 RID: 129526 RVA: 0x008BD84E File Offset: 0x008BBA4E
		public unsafe UMaterialInstanceDynamic DrawMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0601F9F7 RID: 129527 RVA: 0x008BD863 File Offset: 0x008BBA63
		// (set) Token: 0x0601F9F8 RID: 129528 RVA: 0x008BD873 File Offset: 0x008BBA73
		public unsafe bool bSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0601F9F9 RID: 129529 RVA: 0x008BD884 File Offset: 0x008BBA84
		// (set) Token: 0x0601F9FA RID: 129530 RVA: 0x008BD898 File Offset: 0x008BBA98
		public unsafe AActor Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0601F9FB RID: 129531 RVA: 0x008BD8AD File Offset: 0x008BBAAD
		// (set) Token: 0x0601F9FC RID: 129532 RVA: 0x008BD8BD File Offset: 0x008BBABD
		public unsafe int PrevState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0601F9FD RID: 129533 RVA: 0x008BD8CE File Offset: 0x008BBACE
		// (set) Token: 0x0601F9FE RID: 129534 RVA: 0x008BD8DE File Offset: 0x008BBADE
		public unsafe int State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0601F9FF RID: 129535 RVA: 0x008BD8F0 File Offset: 0x008BBAF0
		// (set) Token: 0x0601FA00 RID: 129536 RVA: 0x008BD929 File Offset: 0x008BBB29
		[Nullable(1)]
		public FGameplayTagContainer Tag_Container
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tag_Container) == null)
				{
					result = (this._Tag_Container = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0601FA01 RID: 129537 RVA: 0x008BD94A File Offset: 0x008BBB4A
		// (set) Token: 0x0601FA02 RID: 129538 RVA: 0x008BD95E File Offset: 0x008BBB5E
		public unsafe BP_RippleWater_Data_C Current_Ripple_State
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0601FA03 RID: 129539 RVA: 0x008BD973 File Offset: 0x008BBB73
		// (set) Token: 0x0601FA04 RID: 129540 RVA: 0x008BD983 File Offset: 0x008BBB83
		public unsafe float Step
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0601FA05 RID: 129541 RVA: 0x008BD994 File Offset: 0x008BBB94
		// (set) Token: 0x0601FA06 RID: 129542 RVA: 0x008BD9A4 File Offset: 0x008BBBA4
		public unsafe float captureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0601FA07 RID: 129543 RVA: 0x008BD9B5 File Offset: 0x008BBBB5
		// (set) Token: 0x0601FA08 RID: 129544 RVA: 0x008BD9C9 File Offset: 0x008BBBC9
		public unsafe UMaterialInstanceDynamic rippleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0601FA09 RID: 129545 RVA: 0x008BD9DE File Offset: 0x008BBBDE
		// (set) Token: 0x0601FA0A RID: 129546 RVA: 0x008BD9F2 File Offset: 0x008BBBF2
		public unsafe UTextureRenderTarget2D prevRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0601FA0B RID: 129547 RVA: 0x008BDA07 File Offset: 0x008BBC07
		// (set) Token: 0x0601FA0C RID: 129548 RVA: 0x008BDA1B File Offset: 0x008BBC1B
		public unsafe UTextureRenderTarget2D currentRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0601FA0D RID: 129549 RVA: 0x008BDA30 File Offset: 0x008BBC30
		// (set) Token: 0x0601FA0E RID: 129550 RVA: 0x008BDA44 File Offset: 0x008BBC44
		public unsafe UTextureRenderTarget2D tempRTRef
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0601FA0F RID: 129551 RVA: 0x008BDA59 File Offset: 0x008BBC59
		// (set) Token: 0x0601FA10 RID: 129552 RVA: 0x008BDA6D File Offset: 0x008BBC6D
		public unsafe FVector PlayerLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0601FA11 RID: 129553 RVA: 0x008BDA82 File Offset: 0x008BBC82
		// (set) Token: 0x0601FA12 RID: 129554 RVA: 0x008BDA96 File Offset: 0x008BBC96
		public unsafe FVector2D Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0601FA13 RID: 129555 RVA: 0x008BDAAB File Offset: 0x008BBCAB
		// (set) Token: 0x0601FA14 RID: 129556 RVA: 0x008BDABF File Offset: 0x008BBCBF
		public unsafe AActor TestActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0601FA15 RID: 129557 RVA: 0x008BDAD4 File Offset: 0x008BBCD4
		// (set) Token: 0x0601FA16 RID: 129558 RVA: 0x008BDAE4 File Offset: 0x008BBCE4
		public unsafe float PlayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0601FA17 RID: 129559 RVA: 0x008BDAF5 File Offset: 0x008BBCF5
		// (set) Token: 0x0601FA18 RID: 129560 RVA: 0x008BDB09 File Offset: 0x008BBD09
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0601FA19 RID: 129561 RVA: 0x008BDB1E File Offset: 0x008BBD1E
		// (set) Token: 0x0601FA1A RID: 129562 RVA: 0x008BDB2E File Offset: 0x008BBD2E
		public unsafe bool bPlayerInWaterLast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x0601FA1B RID: 129563 RVA: 0x008BDB3F File Offset: 0x008BBD3F
		// (set) Token: 0x0601FA1C RID: 129564 RVA: 0x008BDB4F File Offset: 0x008BBD4F
		public unsafe float RippleDistanceNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0601FA1D RID: 129565 RVA: 0x008BDB60 File Offset: 0x008BBD60
		// (set) Token: 0x0601FA1E RID: 129566 RVA: 0x008BDB70 File Offset: 0x008BBD70
		public unsafe float RippleDistanceFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0601FA1F RID: 129567 RVA: 0x008BDB81 File Offset: 0x008BBD81
		// (set) Token: 0x0601FA20 RID: 129568 RVA: 0x008BDB95 File Offset: 0x008BBD95
		public unsafe FVector2D PositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0601FA21 RID: 129569 RVA: 0x008BDBAA File Offset: 0x008BBDAA
		// (set) Token: 0x0601FA22 RID: 129570 RVA: 0x008BDBBE File Offset: 0x008BBDBE
		public unsafe FVector LastRippleLocationNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0601FA23 RID: 129571 RVA: 0x008BDBD3 File Offset: 0x008BBDD3
		// (set) Token: 0x0601FA24 RID: 129572 RVA: 0x008BDBE3 File Offset: 0x008BBDE3
		public unsafe float RippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0601FA25 RID: 129573 RVA: 0x008BDBF4 File Offset: 0x008BBDF4
		// (set) Token: 0x0601FA26 RID: 129574 RVA: 0x008BDC08 File Offset: 0x008BBE08
		public unsafe FVector LastRippleLocationFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0601FA27 RID: 129575 RVA: 0x008BDC1D File Offset: 0x008BBE1D
		// (set) Token: 0x0601FA28 RID: 129576 RVA: 0x008BDC2D File Offset: 0x008BBE2D
		public unsafe float SwimRippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0601FA29 RID: 129577 RVA: 0x008BDC3E File Offset: 0x008BBE3E
		// (set) Token: 0x0601FA2A RID: 129578 RVA: 0x008BDC52 File Offset: 0x008BBE52
		public unsafe FVector2D PlayerPosNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0601FA2B RID: 129579 RVA: 0x008BDC67 File Offset: 0x008BBE67
		// (set) Token: 0x0601FA2C RID: 129580 RVA: 0x008BDC7B File Offset: 0x008BBE7B
		public unsafe FVector2D PlayerPosFluo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0601FA2D RID: 129581 RVA: 0x008BDC90 File Offset: 0x008BBE90
		// (set) Token: 0x0601FA2E RID: 129582 RVA: 0x008BDCA0 File Offset: 0x008BBEA0
		public unsafe float LastRipplePastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0601FA2F RID: 129583 RVA: 0x008BDCB1 File Offset: 0x008BBEB1
		// (set) Token: 0x0601FA30 RID: 129584 RVA: 0x008BDCC5 File Offset: 0x008BBEC5
		public unsafe BP_RippleWater_Data_C Swim_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0601FA31 RID: 129585 RVA: 0x008BDCDA File Offset: 0x008BBEDA
		// (set) Token: 0x0601FA32 RID: 129586 RVA: 0x008BDCEE File Offset: 0x008BBEEE
		public unsafe BP_RippleWater_Data_C Gongduola_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0601FA33 RID: 129587 RVA: 0x008BDD03 File Offset: 0x008BBF03
		// (set) Token: 0x0601FA34 RID: 129588 RVA: 0x008BDD17 File Offset: 0x008BBF17
		public unsafe BP_RippleWater_Data_C Fly_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0601FA35 RID: 129589 RVA: 0x008BDD2C File Offset: 0x008BBF2C
		// (set) Token: 0x0601FA36 RID: 129590 RVA: 0x008BDD40 File Offset: 0x008BBF40
		public unsafe BP_RippleWater_Data_C Drop_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0601FA37 RID: 129591 RVA: 0x008BDD55 File Offset: 0x008BBF55
		// (set) Token: 0x0601FA38 RID: 129592 RVA: 0x008BDD65 File Offset: 0x008BBF65
		public unsafe bool InFixedRippleArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0601FA39 RID: 129593 RVA: 0x008BDD76 File Offset: 0x008BBF76
		// (set) Token: 0x0601FA3A RID: 129594 RVA: 0x008BDD8A File Offset: 0x008BBF8A
		public unsafe UTextureRenderTarget2D PersistRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0601FA3B RID: 129595 RVA: 0x008BDD9F File Offset: 0x008BBF9F
		// (set) Token: 0x0601FA3C RID: 129596 RVA: 0x008BDDB3 File Offset: 0x008BBFB3
		public unsafe UTextureRenderTarget2D FinalRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0601FA3D RID: 129597 RVA: 0x008BDDC8 File Offset: 0x008BBFC8
		// (set) Token: 0x0601FA3E RID: 129598 RVA: 0x008BDDD8 File Offset: 0x008BBFD8
		public unsafe bool bCustomRippleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0601FA3F RID: 129599 RVA: 0x008BDDE9 File Offset: 0x008BBFE9
		// (set) Token: 0x0601FA40 RID: 129600 RVA: 0x008BDDFD File Offset: 0x008BBFFD
		public unsafe BP_SceneBattleInteract_C BulletConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0601FA41 RID: 129601 RVA: 0x008BDE12 File Offset: 0x008BC012
		// (set) Token: 0x0601FA42 RID: 129602 RVA: 0x008BDE26 File Offset: 0x008BC026
		public unsafe FVector2D BulletUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0601FA43 RID: 129603 RVA: 0x008BDE3B File Offset: 0x008BC03B
		// (set) Token: 0x0601FA44 RID: 129604 RVA: 0x008BDE4F File Offset: 0x008BC04F
		public unsafe FVector2D LastBulletUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0601FA45 RID: 129605 RVA: 0x008BDE64 File Offset: 0x008BC064
		// (set) Token: 0x0601FA46 RID: 129606 RVA: 0x008BDE74 File Offset: 0x008BC074
		public unsafe bool bSetUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0601FA47 RID: 129607 RVA: 0x008BDE85 File Offset: 0x008BC085
		// (set) Token: 0x0601FA48 RID: 129608 RVA: 0x008BDE95 File Offset: 0x008BC095
		public unsafe bool bShowDebugData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0601FA49 RID: 129609 RVA: 0x008BDEA6 File Offset: 0x008BC0A6
		// (set) Token: 0x0601FA4A RID: 129610 RVA: 0x008BDEB6 File Offset: 0x008BC0B6
		public unsafe double 翱翔射线长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0601FA4B RID: 129611 RVA: 0x008BDEC7 File Offset: 0x008BC0C7
		// (set) Token: 0x0601FA4C RID: 129612 RVA: 0x008BDED7 File Offset: 0x008BC0D7
		public unsafe float CurrRippleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0601FA4D RID: 129613 RVA: 0x008BDEE8 File Offset: 0x008BC0E8
		// (set) Token: 0x0601FA4E RID: 129614 RVA: 0x008BDEF8 File Offset: 0x008BC0F8
		public unsafe float CurrRippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0601FA4F RID: 129615 RVA: 0x008BDF09 File Offset: 0x008BC109
		// (set) Token: 0x0601FA50 RID: 129616 RVA: 0x008BDF19 File Offset: 0x008BC119
		public unsafe float RippleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0601FA51 RID: 129617 RVA: 0x008BDF2A File Offset: 0x008BC12A
		// (set) Token: 0x0601FA52 RID: 129618 RVA: 0x008BDF3A File Offset: 0x008BC13A
		public unsafe float FlyMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0601FA53 RID: 129619 RVA: 0x008BDF4B File Offset: 0x008BC14B
		// (set) Token: 0x0601FA54 RID: 129620 RVA: 0x008BDF5B File Offset: 0x008BC15B
		public unsafe float FlyMinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0601FA55 RID: 129621 RVA: 0x008BDF6C File Offset: 0x008BC16C
		// (set) Token: 0x0601FA56 RID: 129622 RVA: 0x008BDF7C File Offset: 0x008BC17C
		public unsafe float RippleAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0601FA57 RID: 129623 RVA: 0x008BDF8D File Offset: 0x008BC18D
		// (set) Token: 0x0601FA58 RID: 129624 RVA: 0x008BDFA1 File Offset: 0x008BC1A1
		public unsafe FVectorDouble AvailblePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0601FA59 RID: 129625 RVA: 0x008BDFB6 File Offset: 0x008BC1B6
		// (set) Token: 0x0601FA5A RID: 129626 RVA: 0x008BDFCA File Offset: 0x008BC1CA
		public unsafe FVectorDouble LastAvailblePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0601FA5B RID: 129627 RVA: 0x008BDFDF File Offset: 0x008BC1DF
		// (set) Token: 0x0601FA5C RID: 129628 RVA: 0x008BDFEF File Offset: 0x008BC1EF
		public unsafe float BulletMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0601FA5D RID: 129629 RVA: 0x008BE000 File Offset: 0x008BC200
		// (set) Token: 0x0601FA5E RID: 129630 RVA: 0x008BE010 File Offset: 0x008BC210
		public unsafe float BulletMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0601FA5F RID: 129631 RVA: 0x008BE021 File Offset: 0x008BC221
		// (set) Token: 0x0601FA60 RID: 129632 RVA: 0x008BE031 File Offset: 0x008BC231
		public unsafe double Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0601FA61 RID: 129633 RVA: 0x008BE042 File Offset: 0x008BC242
		// (set) Token: 0x0601FA62 RID: 129634 RVA: 0x008BE052 File Offset: 0x008BC252
		public unsafe float BulletLastHitTime0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0601FA63 RID: 129635 RVA: 0x008BE064 File Offset: 0x008BC264
		// (set) Token: 0x0601FA64 RID: 129636 RVA: 0x008BE09D File Offset: 0x008BC29D
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList0) == null)
				{
					result = (this._BulletPointList0 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_59, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList0.CopyAssign(value);
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0601FA65 RID: 129637 RVA: 0x008BE0AB File Offset: 0x008BC2AB
		// (set) Token: 0x0601FA66 RID: 129638 RVA: 0x008BE0BB File Offset: 0x008BC2BB
		public unsafe float BulletLastHitTime1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_60);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_60) = value;
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0601FA67 RID: 129639 RVA: 0x008BE0CC File Offset: 0x008BC2CC
		// (set) Token: 0x0601FA68 RID: 129640 RVA: 0x008BE105 File Offset: 0x008BC305
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList1
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList1) == null)
				{
					result = (this._BulletPointList1 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_61, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList1.CopyAssign(value);
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0601FA69 RID: 129641 RVA: 0x008BE113 File Offset: 0x008BC313
		// (set) Token: 0x0601FA6A RID: 129642 RVA: 0x008BE123 File Offset: 0x008BC323
		public unsafe float BulletLastHitTime2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0601FA6B RID: 129643 RVA: 0x008BE134 File Offset: 0x008BC334
		// (set) Token: 0x0601FA6C RID: 129644 RVA: 0x008BE16D File Offset: 0x008BC36D
		[Nullable(1)]
		public TArray<FVectorDouble> BulletPointList2
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletPointList2) == null)
				{
					result = (this._BulletPointList2 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_63, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletPointList2.CopyAssign(value);
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x0601FA6D RID: 129645 RVA: 0x008BE17B File Offset: 0x008BC37B
		// (set) Token: 0x0601FA6E RID: 129646 RVA: 0x008BE18B File Offset: 0x008BC38B
		public unsafe int CatMullStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x0601FA6F RID: 129647 RVA: 0x008BE19C File Offset: 0x008BC39C
		// (set) Token: 0x0601FA70 RID: 129648 RVA: 0x008BE1AC File Offset: 0x008BC3AC
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x0601FA71 RID: 129649 RVA: 0x008BE1BD File Offset: 0x008BC3BD
		// (set) Token: 0x0601FA72 RID: 129650 RVA: 0x008BE1CD File Offset: 0x008BC3CD
		public unsafe float Tension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0601FA73 RID: 129651 RVA: 0x008BE1E0 File Offset: 0x008BC3E0
		// (set) Token: 0x0601FA74 RID: 129652 RVA: 0x008BE219 File Offset: 0x008BC419
		[Nullable(1)]
		public TArray<FVectorDouble> AvailblePointList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._AvailblePointList) == null)
				{
					result = (this._AvailblePointList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_67, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AvailblePointList.CopyAssign(value);
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0601FA75 RID: 129653 RVA: 0x008BE227 File Offset: 0x008BC427
		// (set) Token: 0x0601FA76 RID: 129654 RVA: 0x008BE23B File Offset: 0x008BC43B
		public unsafe UTextureRenderTarget2D PointRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_68);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_68, value);
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0601FA77 RID: 129655 RVA: 0x008BE250 File Offset: 0x008BC450
		// (set) Token: 0x0601FA78 RID: 129656 RVA: 0x008BE264 File Offset: 0x008BC464
		public unsafe UMaterialInstanceDynamic AddPointsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_69);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_69, value);
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0601FA79 RID: 129657 RVA: 0x008BE279 File Offset: 0x008BC479
		// (set) Token: 0x0601FA7A RID: 129658 RVA: 0x008BE28D File Offset: 0x008BC48D
		public unsafe UMaterialInstanceDynamic AddCapsuleMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_70);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_70, value);
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0601FA7B RID: 129659 RVA: 0x008BE2A2 File Offset: 0x008BC4A2
		// (set) Token: 0x0601FA7C RID: 129660 RVA: 0x008BE2B6 File Offset: 0x008BC4B6
		[Nullable(0)]
		public unsafe TEnumAsByte<EDrawDebugTrace> Fly_Ray_Debug_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_71);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_71) = value;
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0601FA7D RID: 129661 RVA: 0x008BE2CB File Offset: 0x008BC4CB
		// (set) Token: 0x0601FA7E RID: 129662 RVA: 0x008BE2DF File Offset: 0x008BC4DF
		public unsafe FVector2D CurrentRippleCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0601FA7F RID: 129663 RVA: 0x008BE2F4 File Offset: 0x008BC4F4
		// (set) Token: 0x0601FA80 RID: 129664 RVA: 0x008BE304 File Offset: 0x008BC504
		public unsafe bool UseOldRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_73) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_73) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0601FA81 RID: 129665 RVA: 0x008BE315 File Offset: 0x008BC515
		// (set) Token: 0x0601FA82 RID: 129666 RVA: 0x008BE325 File Offset: 0x008BC525
		public unsafe float NewCaptureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_74);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_74) = value;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0601FA83 RID: 129667 RVA: 0x008BE336 File Offset: 0x008BC536
		// (set) Token: 0x0601FA84 RID: 129668 RVA: 0x008BE34A File Offset: 0x008BC54A
		public unsafe UMaterialInstanceDynamic NewRipplePrevMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_75);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_75, value);
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0601FA85 RID: 129669 RVA: 0x008BE35F File Offset: 0x008BC55F
		// (set) Token: 0x0601FA86 RID: 129670 RVA: 0x008BE373 File Offset: 0x008BC573
		public unsafe FLinearColor Weapon_0_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0601FA87 RID: 129671 RVA: 0x008BE388 File Offset: 0x008BC588
		// (set) Token: 0x0601FA88 RID: 129672 RVA: 0x008BE39C File Offset: 0x008BC59C
		public unsafe FLinearColor Weapon_1_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0601FA89 RID: 129673 RVA: 0x008BE3B1 File Offset: 0x008BC5B1
		// (set) Token: 0x0601FA8A RID: 129674 RVA: 0x008BE3C5 File Offset: 0x008BC5C5
		public unsafe FLinearColor Weapon_2_Debug_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_78);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_78) = value;
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0601FA8B RID: 129675 RVA: 0x008BE3DA File Offset: 0x008BC5DA
		// (set) Token: 0x0601FA8C RID: 129676 RVA: 0x008BE3EE File Offset: 0x008BC5EE
		public unsafe FVector2D RippleCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_79);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_79) = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0601FA8D RID: 129677 RVA: 0x008BE403 File Offset: 0x008BC603
		// (set) Token: 0x0601FA8E RID: 129678 RVA: 0x008BE417 File Offset: 0x008BC617
		public unsafe BP_RippleWater_Data_C Fuludelisi_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_80);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_80, value);
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0601FA8F RID: 129679 RVA: 0x008BE42C File Offset: 0x008BC62C
		// (set) Token: 0x0601FA90 RID: 129680 RVA: 0x008BE43C File Offset: 0x008BC63C
		public unsafe bool bEnableSwimRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_81) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_81) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0601FA91 RID: 129681 RVA: 0x008BE44D File Offset: 0x008BC64D
		// (set) Token: 0x0601FA92 RID: 129682 RVA: 0x008BE45D File Offset: 0x008BC65D
		public unsafe float WaterDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0601FA93 RID: 129683 RVA: 0x008BE46E File Offset: 0x008BC66E
		// (set) Token: 0x0601FA94 RID: 129684 RVA: 0x008BE47E File Offset: 0x008BC67E
		public unsafe float FallJumpDepthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0601FA95 RID: 129685 RVA: 0x008BE48F File Offset: 0x008BC68F
		// (set) Token: 0x0601FA96 RID: 129686 RVA: 0x008BE4A3 File Offset: 0x008BC6A3
		public unsafe BP_RippleWater_Data_C Moto_Ripple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleWater_Data_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_84);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RippleSwim_C.__PropertyOffset_84, value);
			}
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0601FA97 RID: 129687 RVA: 0x008BE4B8 File Offset: 0x008BC6B8
		// (set) Token: 0x0601FA98 RID: 129688 RVA: 0x008BE4C8 File Offset: 0x008BC6C8
		public unsafe bool bForceSwimRipple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_85) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RippleSwim_C.__PropertyOffset_85) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FA99 RID: 129689 RVA: 0x008BE4D9 File Offset: 0x008BC6D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Ripple_Stamp()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Ripple_Stamp_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA9A RID: 129690 RVA: 0x008BE4ED File Offset: 0x008BC6ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Ripple_Simulation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Ripple_Simulation_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA9B RID: 129691 RVA: 0x008BE504 File Offset: 0x008BC704
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckAndSetPos(float DeltaSeconds, ref float LastRippleTime)
		{
			BP_RippleSwim_C.__CheckAndSetPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CheckAndSetPos_FunctionParams[(UIntPtr)1359] + 15L / (long)sizeof(BP_RippleSwim_C.__CheckAndSetPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CheckAndSetPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->LastRippleTime = LastRippleTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CheckAndSetPos_NativeFunctionPtr, (void*)ptr);
			LastRippleTime = ptr->LastRippleTime;
		}

		// Token: 0x0601FA9C RID: 129692 RVA: 0x008BE55D File Offset: 0x008BC75D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetCloseSwimRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetCloseSwimRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA9D RID: 129693 RVA: 0x008BE574 File Offset: 0x008BC774
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Bullet_Data(BP_SceneBattleInteract_C Config)
		{
			BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_RippleSwim_C.__Set_Bullet_Data_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Set_Bullet_Data_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Set_Bullet_Data_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FA9E RID: 129694 RVA: 0x008BE5C9 File Offset: 0x008BC7C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetNewRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetNewRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA9F RID: 129695 RVA: 0x008BE5DD File Offset: 0x008BC7DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetOldRipple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetOldRipple_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAA0 RID: 129696 RVA: 0x008BE5F4 File Offset: 0x008BC7F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TexcoordToPosition(FVectorDouble RippleCenter, FVector2D RippleUV, float CaptureSize, ref FVector2D Position)
		{
			BP_RippleSwim_C.__TexcoordToPosition_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__TexcoordToPosition_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_RippleSwim_C.__TexcoordToPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__TexcoordToPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RippleUV = RippleUV;
			ptr->CaptureSize = CaptureSize;
			ptr->Position = Position;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__TexcoordToPosition_NativeFunctionPtr, (void*)ptr);
			Position = ptr->Position;
		}

		// Token: 0x0601FAA1 RID: 129697 RVA: 0x008BE668 File Offset: 0x008BC868
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Calc_Circle_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Circle_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Circle_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Circle_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAA2 RID: 129698 RVA: 0x008BE6C8 File Offset: 0x008BC8C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Calc_Capsule_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Capsule_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Capsule_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Capsule_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAA3 RID: 129699 RVA: 0x008BE728 File Offset: 0x008BC928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Compare_New_Point_Weapon_2(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_2_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601FAA4 RID: 129700 RVA: 0x008BE780 File Offset: 0x008BC980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Calc_Catmull_Weapon_2(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAA5 RID: 129701 RVA: 0x008BE7E0 File Offset: 0x008BC9E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Compare_New_Point_Weapon_1(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_1_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601FAA6 RID: 129702 RVA: 0x008BE838 File Offset: 0x008BCA38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Calc_Catmull_Weapon_1(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAA7 RID: 129703 RVA: 0x008BE898 File Offset: 0x008BCA98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Compare_New_Point_Weapon_0(FVectorDouble V2, ref bool Vaild)
		{
			BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_RippleSwim_C.__Compare_New_Point_Weapon_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Compare_New_Point_Weapon_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Vaild = Vaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Compare_New_Point_Weapon_0_NativeFunctionPtr, (void*)ptr);
			Vaild = ptr->Vaild;
		}

		// Token: 0x0601FAA8 RID: 129704 RVA: 0x008BE8F0 File Offset: 0x008BCAF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Calc_Catmull_Weapon_0(BP_SceneBattleInteract_C BulletConfig, FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams[(UIntPtr)495] + 15L / (long)sizeof(BP_RippleSwim_C.__Calc_Catmull_Weapon_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Calc_Catmull_Weapon_0_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletConfig = ((BulletConfig != null) ? BulletConfig.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Calc_Catmull_Weapon_0_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAA9 RID: 129705 RVA: 0x008BE950 File Offset: 0x008BCB50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord2D(FVectorDouble RippleCenter, FVector2D RipplePointLocation, float CaptureSize, ref FVector2D TexCoord)
		{
			BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcTexCoord2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RipplePointLocation = RipplePointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0601FAAA RID: 129706 RVA: 0x008BE9C4 File Offset: 0x008BCBC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPointsV3(ref TArray<FVectorDouble> PointList, ref bool Vaild, ref FVector2D P_0, ref FVector2D P_1, ref FVector2D P_2, ref FVector2D P_3)
		{
			BP_RippleSwim_C.__GetPointsV3_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__GetPointsV3_FunctionParams[(UIntPtr)343] + 15L / (long)sizeof(BP_RippleSwim_C.__GetPointsV3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVectorDouble> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->Vaild = Vaild;
			ptr->P_0 = P_0;
			ptr->P_1 = P_1;
			ptr->P_2 = P_2;
			ptr->P_3 = P_3;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr);
			TArray<FVectorDouble> tarray2 = PointList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			P_0 = ptr->P_0;
			P_1 = ptr->P_1;
			P_2 = ptr->P_2;
			P_3 = ptr->P_3;
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__GetPointsV3_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FAAB RID: 129707 RVA: 0x008BEAB8 File Offset: 0x008BCCB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPoints(ref TArray<FVector2D> PointList, ref bool Vaild, ref FVector2D P_0, ref FVector2D P_1, ref FVector2D P_2, ref FVector2D P_3)
		{
			BP_RippleSwim_C.__GetPoints_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__GetPoints_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_RippleSwim_C.__GetPoints_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector2D> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->Vaild = Vaild;
			ptr->P_0 = P_0;
			ptr->P_1 = P_1;
			ptr->P_2 = P_2;
			ptr->P_3 = P_3;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr);
			TArray<FVector2D> tarray2 = PointList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			P_0 = ptr->P_0;
			P_1 = ptr->P_1;
			P_2 = ptr->P_2;
			P_3 = ptr->P_3;
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__GetPoints_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FAAC RID: 129708 RVA: 0x008BEBAC File Offset: 0x008BCDAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CatmullRom(ref TArray<FVector2D> PointList, int StepCount, ref bool Vaild, ref TArray<FVector2D> CurveList)
		{
			BP_RippleSwim_C.__CatmullRom_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CatmullRom_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BP_RippleSwim_C.__CatmullRom_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector2D> tarray = PointList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PointList);
			}
			ptr->StepCount = StepCount;
			ptr->Vaild = Vaild;
			TArray<FVector2D> tarray2 = CurveList;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->CurveList);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr);
			TArray<FVector2D> tarray3 = PointList;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->PointList);
			}
			Vaild = ptr->Vaild;
			TArray<FVector2D> tarray4 = CurveList;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->CurveList);
			}
			UnrealReflectionUtils.DestroyStruct(BP_RippleSwim_C.__CatmullRom_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FAAD RID: 129709 RVA: 0x008BEC68 File Offset: 0x008BCE68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcDistance2D(FVectorDouble V1, FVectorDouble V2, ref double Distance)
		{
			BP_RippleSwim_C.__CalcDistance2D_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcDistance2D_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcDistance2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V1 = V1;
			ptr->V2 = V2;
			ptr->Distance = Distance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcDistance2D_NativeFunctionPtr, (void*)ptr);
			Distance = ptr->Distance;
		}

		// Token: 0x0601FAAE RID: 129710 RVA: 0x008BECC8 File Offset: 0x008BCEC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Choose_Available_Point(FVectorDouble CollisionPoint, FVectorDouble WeaponPoint, BP_SceneBattleInteract_C ConfigDA, ref FVectorDouble AvailblePoint)
		{
			BP_RippleSwim_C.__Choose_Available_Point_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Choose_Available_Point_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_RippleSwim_C.__Choose_Available_Point_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CollisionPoint = CollisionPoint;
			ptr->WeaponPoint = WeaponPoint;
			ptr->ConfigDA = ((ConfigDA != null) ? ConfigDA.NativePtr : IntPtr.Zero);
			ptr->AvailblePoint = AvailblePoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Choose_Available_Point_NativeFunctionPtr, (void*)ptr);
			AvailblePoint = ptr->AvailblePoint;
		}

		// Token: 0x0601FAAF RID: 129711 RVA: 0x008BED48 File Offset: 0x008BCF48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Change_Ripple_Preset(BP_RippleWater_Data_C NewRippleState)
		{
			BP_RippleSwim_C.__Change_Ripple_Preset_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__Change_Ripple_Preset_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_RippleSwim_C.__Change_Ripple_Preset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__Change_Ripple_Preset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewRippleState = ((NewRippleState != null) ? NewRippleState.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Change_Ripple_Preset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAB0 RID: 129712 RVA: 0x008BEDA0 File Offset: 0x008BCFA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble RippleCenter, FVectorDouble RipplePointLocation, float CaptureSize, ref FVector TexCoord)
		{
			BP_RippleSwim_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_RippleSwim_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RipplePointLocation = RipplePointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0601FAB1 RID: 129713 RVA: 0x008BEE11 File Offset: 0x008BD011
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear_RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Clear_RT_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB2 RID: 129714 RVA: 0x008BEE28 File Offset: 0x008BD028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetWaterRippleData(BP_RippleWater_Data_C InputPin)
		{
			BP_RippleSwim_C.__SetWaterRippleData_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__SetWaterRippleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_RippleSwim_C.__SetWaterRippleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__SetWaterRippleData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputPin = ((InputPin != null) ? InputPin.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__SetWaterRippleData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAB3 RID: 129715 RVA: 0x008BEE80 File Offset: 0x008BD080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AboveWater(FVector Location, ref bool bAboveWater)
		{
			BP_RippleSwim_C.__AboveWater_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__AboveWater_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_RippleSwim_C.__AboveWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__AboveWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			ptr->bAboveWater = bAboveWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__AboveWater_NativeFunctionPtr, (void*)ptr);
			bAboveWater = ptr->bAboveWater;
		}

		// Token: 0x0601FAB4 RID: 129716 RVA: 0x008BEED6 File Offset: 0x008BD0D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB5 RID: 129717 RVA: 0x008BEEEA File Offset: 0x008BD0EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FAB6 RID: 129718 RVA: 0x008BEEFF File Offset: 0x008BD0FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB7 RID: 129719 RVA: 0x008BEF13 File Offset: 0x008BD113
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FAB8 RID: 129720 RVA: 0x008BEF28 File Offset: 0x008BD128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RippleSwim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAB9 RID: 129721 RVA: 0x008BEF70 File Offset: 0x008BD170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RippleSwim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FABA RID: 129722 RVA: 0x008BEFB7 File Offset: 0x008BD1B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x0601FABB RID: 129723 RVA: 0x008BEFCB File Offset: 0x008BD1CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601FABC RID: 129724 RVA: 0x008BEFDF File Offset: 0x008BD1DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FABD RID: 129725 RVA: 0x008BEFF4 File Offset: 0x008BD1F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHitWater(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__OnBulletHitWater_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__OnBulletHitWater_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__OnBulletHitWater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__OnBulletHitWater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__OnBulletHitWater_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FABE RID: 129726 RVA: 0x008BF060 File Offset: 0x008BD260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BulletHitPos(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__BulletHitPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__BulletHitPos_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__BulletHitPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__BulletHitPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__BulletHitPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FABF RID: 129727 RVA: 0x008BF0CC File Offset: 0x008BD2CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHitPos(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__OnBulletHitPos_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__OnBulletHitPos_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__OnBulletHitPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__OnBulletHitPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__OnBulletHitPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAC0 RID: 129728 RVA: 0x008BF138 File Offset: 0x008BD338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TestHitEvent(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			BP_RippleSwim_C.__TestHitEvent_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__TestHitEvent_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_RippleSwim_C.__TestHitEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__TestHitEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__TestHitEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAC1 RID: 129729 RVA: 0x008BF1A4 File Offset: 0x008BD3A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FAC2 RID: 129730 RVA: 0x008BF1F0 File Offset: 0x008BD3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RippleSwim_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RippleSwim_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FAC3 RID: 129731 RVA: 0x008BF23C File Offset: 0x008BD43C
		protected BP_RippleSwim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F37D RID: 62333
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/BP_Tools/RippleSwim/BP_RippleSwim.BP_RippleSwim_C";

		// Token: 0x0400F37E RID: 62334
		private static IntPtr _ClassPtr;

		// Token: 0x0400F37F RID: 62335
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F380 RID: 62336
		internal static int __PropertyOffset_1;

		// Token: 0x0400F381 RID: 62337
		internal static int __PropertyOffset_2;

		// Token: 0x0400F382 RID: 62338
		internal static int __PropertyOffset_3;

		// Token: 0x0400F383 RID: 62339
		internal static int __PropertyOffset_4;

		// Token: 0x0400F384 RID: 62340
		internal static int __PropertyOffset_5;

		// Token: 0x0400F385 RID: 62341
		internal static int __PropertyOffset_6;

		// Token: 0x0400F386 RID: 62342
		internal static int __PropertyOffset_7;

		// Token: 0x0400F387 RID: 62343
		internal static int __PropertyOffset_8;

		// Token: 0x0400F388 RID: 62344
		internal static int __PropertyOffset_9;

		// Token: 0x0400F389 RID: 62345
		private FGameplayTagContainer _Tag_Container;

		// Token: 0x0400F38A RID: 62346
		internal static int __PropertyOffset_10;

		// Token: 0x0400F38B RID: 62347
		internal static int __PropertyOffset_11;

		// Token: 0x0400F38C RID: 62348
		internal static int __PropertyOffset_12;

		// Token: 0x0400F38D RID: 62349
		internal static int __PropertyOffset_13;

		// Token: 0x0400F38E RID: 62350
		internal static int __PropertyOffset_14;

		// Token: 0x0400F38F RID: 62351
		internal static int __PropertyOffset_15;

		// Token: 0x0400F390 RID: 62352
		internal static int __PropertyOffset_16;

		// Token: 0x0400F391 RID: 62353
		internal static int __PropertyOffset_17;

		// Token: 0x0400F392 RID: 62354
		internal static int __PropertyOffset_18;

		// Token: 0x0400F393 RID: 62355
		internal static int __PropertyOffset_19;

		// Token: 0x0400F394 RID: 62356
		internal static int __PropertyOffset_20;

		// Token: 0x0400F395 RID: 62357
		internal static int __PropertyOffset_21;

		// Token: 0x0400F396 RID: 62358
		internal static int __PropertyOffset_22;

		// Token: 0x0400F397 RID: 62359
		internal static int __PropertyOffset_23;

		// Token: 0x0400F398 RID: 62360
		internal static int __PropertyOffset_24;

		// Token: 0x0400F399 RID: 62361
		internal static int __PropertyOffset_25;

		// Token: 0x0400F39A RID: 62362
		internal static int __PropertyOffset_26;

		// Token: 0x0400F39B RID: 62363
		internal static int __PropertyOffset_27;

		// Token: 0x0400F39C RID: 62364
		internal static int __PropertyOffset_28;

		// Token: 0x0400F39D RID: 62365
		internal static int __PropertyOffset_29;

		// Token: 0x0400F39E RID: 62366
		internal static int __PropertyOffset_30;

		// Token: 0x0400F39F RID: 62367
		internal static int __PropertyOffset_31;

		// Token: 0x0400F3A0 RID: 62368
		internal static int __PropertyOffset_32;

		// Token: 0x0400F3A1 RID: 62369
		internal static int __PropertyOffset_33;

		// Token: 0x0400F3A2 RID: 62370
		internal static int __PropertyOffset_34;

		// Token: 0x0400F3A3 RID: 62371
		internal static int __PropertyOffset_35;

		// Token: 0x0400F3A4 RID: 62372
		internal static int __PropertyOffset_36;

		// Token: 0x0400F3A5 RID: 62373
		internal static int __PropertyOffset_37;

		// Token: 0x0400F3A6 RID: 62374
		internal static int __PropertyOffset_38;

		// Token: 0x0400F3A7 RID: 62375
		internal static int __PropertyOffset_39;

		// Token: 0x0400F3A8 RID: 62376
		internal static int __PropertyOffset_40;

		// Token: 0x0400F3A9 RID: 62377
		internal static int __PropertyOffset_41;

		// Token: 0x0400F3AA RID: 62378
		internal static int __PropertyOffset_42;

		// Token: 0x0400F3AB RID: 62379
		internal static int __PropertyOffset_43;

		// Token: 0x0400F3AC RID: 62380
		internal static int __PropertyOffset_44;

		// Token: 0x0400F3AD RID: 62381
		internal static int __PropertyOffset_45;

		// Token: 0x0400F3AE RID: 62382
		internal static int __PropertyOffset_46;

		// Token: 0x0400F3AF RID: 62383
		internal static int __PropertyOffset_47;

		// Token: 0x0400F3B0 RID: 62384
		internal static int __PropertyOffset_48;

		// Token: 0x0400F3B1 RID: 62385
		internal static int __PropertyOffset_49;

		// Token: 0x0400F3B2 RID: 62386
		internal static int __PropertyOffset_50;

		// Token: 0x0400F3B3 RID: 62387
		internal static int __PropertyOffset_51;

		// Token: 0x0400F3B4 RID: 62388
		internal static int __PropertyOffset_52;

		// Token: 0x0400F3B5 RID: 62389
		internal static int __PropertyOffset_53;

		// Token: 0x0400F3B6 RID: 62390
		internal static int __PropertyOffset_54;

		// Token: 0x0400F3B7 RID: 62391
		internal static int __PropertyOffset_55;

		// Token: 0x0400F3B8 RID: 62392
		internal static int __PropertyOffset_56;

		// Token: 0x0400F3B9 RID: 62393
		internal static int __PropertyOffset_57;

		// Token: 0x0400F3BA RID: 62394
		internal static int __PropertyOffset_58;

		// Token: 0x0400F3BB RID: 62395
		internal static int __PropertyOffset_59;

		// Token: 0x0400F3BC RID: 62396
		private TArray<FVectorDouble> _BulletPointList0;

		// Token: 0x0400F3BD RID: 62397
		internal static int __PropertyOffset_60;

		// Token: 0x0400F3BE RID: 62398
		internal static int __PropertyOffset_61;

		// Token: 0x0400F3BF RID: 62399
		private TArray<FVectorDouble> _BulletPointList1;

		// Token: 0x0400F3C0 RID: 62400
		internal static int __PropertyOffset_62;

		// Token: 0x0400F3C1 RID: 62401
		internal static int __PropertyOffset_63;

		// Token: 0x0400F3C2 RID: 62402
		private TArray<FVectorDouble> _BulletPointList2;

		// Token: 0x0400F3C3 RID: 62403
		internal static int __PropertyOffset_64;

		// Token: 0x0400F3C4 RID: 62404
		internal static int __PropertyOffset_65;

		// Token: 0x0400F3C5 RID: 62405
		internal static int __PropertyOffset_66;

		// Token: 0x0400F3C6 RID: 62406
		internal static int __PropertyOffset_67;

		// Token: 0x0400F3C7 RID: 62407
		private TArray<FVectorDouble> _AvailblePointList;

		// Token: 0x0400F3C8 RID: 62408
		internal static int __PropertyOffset_68;

		// Token: 0x0400F3C9 RID: 62409
		internal static int __PropertyOffset_69;

		// Token: 0x0400F3CA RID: 62410
		internal static int __PropertyOffset_70;

		// Token: 0x0400F3CB RID: 62411
		internal static int __PropertyOffset_71;

		// Token: 0x0400F3CC RID: 62412
		internal static int __PropertyOffset_72;

		// Token: 0x0400F3CD RID: 62413
		internal static int __PropertyOffset_73;

		// Token: 0x0400F3CE RID: 62414
		internal static int __PropertyOffset_74;

		// Token: 0x0400F3CF RID: 62415
		internal static int __PropertyOffset_75;

		// Token: 0x0400F3D0 RID: 62416
		internal static int __PropertyOffset_76;

		// Token: 0x0400F3D1 RID: 62417
		internal static int __PropertyOffset_77;

		// Token: 0x0400F3D2 RID: 62418
		internal static int __PropertyOffset_78;

		// Token: 0x0400F3D3 RID: 62419
		internal static int __PropertyOffset_79;

		// Token: 0x0400F3D4 RID: 62420
		internal static int __PropertyOffset_80;

		// Token: 0x0400F3D5 RID: 62421
		internal static int __PropertyOffset_81;

		// Token: 0x0400F3D6 RID: 62422
		internal static int __PropertyOffset_82;

		// Token: 0x0400F3D7 RID: 62423
		internal static int __PropertyOffset_83;

		// Token: 0x0400F3D8 RID: 62424
		internal static int __PropertyOffset_84;

		// Token: 0x0400F3D9 RID: 62425
		internal static int __PropertyOffset_85;

		// Token: 0x0400F3DA RID: 62426
		private static IntPtr __Ripple_Stamp_NativeFunctionPtr;

		// Token: 0x0400F3DB RID: 62427
		private static IntPtr __Ripple_Simulation_NativeFunctionPtr;

		// Token: 0x0400F3DC RID: 62428
		private static IntPtr __CheckAndSetPos_NativeFunctionPtr;

		// Token: 0x0400F3DD RID: 62429
		private static IntPtr __SetCloseSwimRipple_NativeFunctionPtr;

		// Token: 0x0400F3DE RID: 62430
		private static IntPtr __Set_Bullet_Data_NativeFunctionPtr;

		// Token: 0x0400F3DF RID: 62431
		private static IntPtr __SetNewRipple_NativeFunctionPtr;

		// Token: 0x0400F3E0 RID: 62432
		private static IntPtr __SetOldRipple_NativeFunctionPtr;

		// Token: 0x0400F3E1 RID: 62433
		private static IntPtr __TexcoordToPosition_NativeFunctionPtr;

		// Token: 0x0400F3E2 RID: 62434
		private static IntPtr __Calc_Circle_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400F3E3 RID: 62435
		private static IntPtr __Calc_Capsule_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400F3E4 RID: 62436
		private static IntPtr __Compare_New_Point_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400F3E5 RID: 62437
		private static IntPtr __Calc_Catmull_Weapon_2_NativeFunctionPtr;

		// Token: 0x0400F3E6 RID: 62438
		private static IntPtr __Compare_New_Point_Weapon_1_NativeFunctionPtr;

		// Token: 0x0400F3E7 RID: 62439
		private static IntPtr __Calc_Catmull_Weapon_1_NativeFunctionPtr;

		// Token: 0x0400F3E8 RID: 62440
		private static IntPtr __Compare_New_Point_Weapon_0_NativeFunctionPtr;

		// Token: 0x0400F3E9 RID: 62441
		private static IntPtr __Calc_Catmull_Weapon_0_NativeFunctionPtr;

		// Token: 0x0400F3EA RID: 62442
		private static IntPtr __CalcTexCoord2D_NativeFunctionPtr;

		// Token: 0x0400F3EB RID: 62443
		private static IntPtr __GetPointsV3_NativeFunctionPtr;

		// Token: 0x0400F3EC RID: 62444
		private static IntPtr __GetPoints_NativeFunctionPtr;

		// Token: 0x0400F3ED RID: 62445
		private static IntPtr __CatmullRom_NativeFunctionPtr;

		// Token: 0x0400F3EE RID: 62446
		private static IntPtr __CalcDistance2D_NativeFunctionPtr;

		// Token: 0x0400F3EF RID: 62447
		private static IntPtr __Choose_Available_Point_NativeFunctionPtr;

		// Token: 0x0400F3F0 RID: 62448
		private static IntPtr __Change_Ripple_Preset_NativeFunctionPtr;

		// Token: 0x0400F3F1 RID: 62449
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x0400F3F2 RID: 62450
		private static IntPtr __Clear_RT_NativeFunctionPtr;

		// Token: 0x0400F3F3 RID: 62451
		private static IntPtr __SetWaterRippleData_NativeFunctionPtr;

		// Token: 0x0400F3F4 RID: 62452
		private static IntPtr __AboveWater_NativeFunctionPtr;

		// Token: 0x0400F3F5 RID: 62453
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F3F6 RID: 62454
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F3F7 RID: 62455
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F3F8 RID: 62456
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x0400F3F9 RID: 62457
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x0400F3FA RID: 62458
		private static IntPtr __OnBulletHitWater_NativeFunctionPtr;

		// Token: 0x0400F3FB RID: 62459
		private static IntPtr __BulletHitPos_NativeFunctionPtr;

		// Token: 0x0400F3FC RID: 62460
		private static IntPtr __OnBulletHitPos_NativeFunctionPtr;

		// Token: 0x0400F3FD RID: 62461
		private static IntPtr __TestHitEvent_NativeFunctionPtr;

		// Token: 0x0400F3FE RID: 62462
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009B14 RID: 39700
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1344)]
		protected ref struct __CheckAndSetPos_FunctionParams
		{
			// Token: 0x040310EC RID: 200940
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040310ED RID: 200941
			[FieldOffset(4)]
			public float LastRippleTime;
		}

		// Token: 0x02009B15 RID: 39701
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Set_Bullet_Data_FunctionParams
		{
			// Token: 0x040310EE RID: 200942
			[FieldOffset(0)]
			public IntPtr Config;
		}

		// Token: 0x02009B16 RID: 39702
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __TexcoordToPosition_FunctionParams
		{
			// Token: 0x040310EF RID: 200943
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x040310F0 RID: 200944
			[FieldOffset(24)]
			public FVector2D RippleUV;

			// Token: 0x040310F1 RID: 200945
			[FieldOffset(32)]
			public float CaptureSize;

			// Token: 0x040310F2 RID: 200946
			[FieldOffset(36)]
			public FVector2D Position;
		}

		// Token: 0x02009B17 RID: 39703
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Calc_Circle_Weapon_2_FunctionParams
		{
			// Token: 0x040310F3 RID: 200947
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x040310F4 RID: 200948
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B18 RID: 39704
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __Calc_Capsule_Weapon_2_FunctionParams
		{
			// Token: 0x040310F5 RID: 200949
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x040310F6 RID: 200950
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B19 RID: 39705
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_2_FunctionParams
		{
			// Token: 0x040310F7 RID: 200951
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x040310F8 RID: 200952
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02009B1A RID: 39706
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_2_FunctionParams
		{
			// Token: 0x040310F9 RID: 200953
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x040310FA RID: 200954
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B1B RID: 39707
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_1_FunctionParams
		{
			// Token: 0x040310FB RID: 200955
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x040310FC RID: 200956
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02009B1C RID: 39708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_1_FunctionParams
		{
			// Token: 0x040310FD RID: 200957
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x040310FE RID: 200958
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B1D RID: 39709
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Compare_New_Point_Weapon_0_FunctionParams
		{
			// Token: 0x040310FF RID: 200959
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x04031100 RID: 200960
			[FieldOffset(24)]
			public bool Vaild;
		}

		// Token: 0x02009B1E RID: 39710
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 480)]
		protected ref struct __Calc_Catmull_Weapon_0_FunctionParams
		{
			// Token: 0x04031101 RID: 200961
			[FieldOffset(0)]
			public IntPtr BulletConfig;

			// Token: 0x04031102 RID: 200962
			[FieldOffset(8)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B1F RID: 39711
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __CalcTexCoord2D_FunctionParams
		{
			// Token: 0x04031103 RID: 200963
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x04031104 RID: 200964
			[FieldOffset(24)]
			public FVector2D RipplePointLocation;

			// Token: 0x04031105 RID: 200965
			[FieldOffset(32)]
			public float CaptureSize;

			// Token: 0x04031106 RID: 200966
			[FieldOffset(36)]
			public FVector2D TexCoord;
		}

		// Token: 0x02009B20 RID: 39712
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 328)]
		protected ref struct __GetPointsV3_FunctionParams
		{
			// Token: 0x04031107 RID: 200967
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x04031108 RID: 200968
			[FieldOffset(16)]
			public bool Vaild;

			// Token: 0x04031109 RID: 200969
			[FieldOffset(20)]
			public FVector2D P_0;

			// Token: 0x0403110A RID: 200970
			[FieldOffset(28)]
			public FVector2D P_1;

			// Token: 0x0403110B RID: 200971
			[FieldOffset(36)]
			public FVector2D P_2;

			// Token: 0x0403110C RID: 200972
			[FieldOffset(44)]
			public FVector2D P_3;
		}

		// Token: 0x02009B21 RID: 39713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetPoints_FunctionParams
		{
			// Token: 0x0403110D RID: 200973
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x0403110E RID: 200974
			[FieldOffset(16)]
			public bool Vaild;

			// Token: 0x0403110F RID: 200975
			[FieldOffset(20)]
			public FVector2D P_0;

			// Token: 0x04031110 RID: 200976
			[FieldOffset(28)]
			public FVector2D P_1;

			// Token: 0x04031111 RID: 200977
			[FieldOffset(36)]
			public FVector2D P_2;

			// Token: 0x04031112 RID: 200978
			[FieldOffset(44)]
			public FVector2D P_3;
		}

		// Token: 0x02009B22 RID: 39714
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __CatmullRom_FunctionParams
		{
			// Token: 0x04031113 RID: 200979
			[FieldOffset(0)]
			public byte PointList;

			// Token: 0x04031114 RID: 200980
			[FieldOffset(16)]
			public int StepCount;

			// Token: 0x04031115 RID: 200981
			[FieldOffset(20)]
			public bool Vaild;

			// Token: 0x04031116 RID: 200982
			[FieldOffset(24)]
			public byte CurveList;
		}

		// Token: 0x02009B23 RID: 39715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __CalcDistance2D_FunctionParams
		{
			// Token: 0x04031117 RID: 200983
			[FieldOffset(0)]
			public FVectorDouble V1;

			// Token: 0x04031118 RID: 200984
			[FieldOffset(24)]
			public FVectorDouble V2;

			// Token: 0x04031119 RID: 200985
			[FieldOffset(48)]
			public double Distance;
		}

		// Token: 0x02009B24 RID: 39716
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Choose_Available_Point_FunctionParams
		{
			// Token: 0x0403111A RID: 200986
			[FieldOffset(0)]
			public FVectorDouble CollisionPoint;

			// Token: 0x0403111B RID: 200987
			[FieldOffset(24)]
			public FVectorDouble WeaponPoint;

			// Token: 0x0403111C RID: 200988
			[FieldOffset(48)]
			public IntPtr ConfigDA;

			// Token: 0x0403111D RID: 200989
			[FieldOffset(56)]
			public FVectorDouble AvailblePoint;
		}

		// Token: 0x02009B25 RID: 39717
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __Change_Ripple_Preset_FunctionParams
		{
			// Token: 0x0403111E RID: 200990
			[FieldOffset(0)]
			public IntPtr NewRippleState;
		}

		// Token: 0x02009B26 RID: 39718
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x0403111F RID: 200991
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x04031120 RID: 200992
			[FieldOffset(24)]
			public FVectorDouble RipplePointLocation;

			// Token: 0x04031121 RID: 200993
			[FieldOffset(48)]
			public float CaptureSize;

			// Token: 0x04031122 RID: 200994
			[FieldOffset(52)]
			public FVector TexCoord;
		}

		// Token: 0x02009B27 RID: 39719
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetWaterRippleData_FunctionParams
		{
			// Token: 0x04031123 RID: 200995
			[FieldOffset(0)]
			public IntPtr InputPin;
		}

		// Token: 0x02009B28 RID: 39720
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __AboveWater_FunctionParams
		{
			// Token: 0x04031124 RID: 200996
			[FieldOffset(0)]
			public FVector Location;

			// Token: 0x04031125 RID: 200997
			[FieldOffset(12)]
			public bool bAboveWater;
		}

		// Token: 0x02009B29 RID: 39721
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031126 RID: 200998
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B2A RID: 39722
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OnBulletHitWater_FunctionParams
		{
			// Token: 0x04031127 RID: 200999
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x04031128 RID: 201000
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031129 RID: 201001
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403112A RID: 201002
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02009B2B RID: 39723
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __BulletHitPos_FunctionParams
		{
			// Token: 0x0403112B RID: 201003
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0403112C RID: 201004
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403112D RID: 201005
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403112E RID: 201006
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02009B2C RID: 39724
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OnBulletHitPos_FunctionParams
		{
			// Token: 0x0403112F RID: 201007
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x04031130 RID: 201008
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031131 RID: 201009
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031132 RID: 201010
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02009B2D RID: 39725
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __TestHitEvent_FunctionParams
		{
			// Token: 0x04031133 RID: 201011
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x04031134 RID: 201012
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031135 RID: 201013
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031136 RID: 201014
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02009B2E RID: 39726
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031137 RID: 201015
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
