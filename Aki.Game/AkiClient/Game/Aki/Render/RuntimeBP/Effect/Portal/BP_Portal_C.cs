using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal
{
	// Token: 0x02003DD2 RID: 15826
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1857)]
	public class BP_Portal_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060276F8 RID: 161528 RVA: 0x00991073 File Offset: 0x0098F273
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Portal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C");
			}
			return BP_Portal_C._ClassPtr;
		}

		// Token: 0x060276F9 RID: 161529 RVA: 0x00991098 File Offset: 0x0098F298
		public BP_Portal_C() : this(BuiltinUtils.AllocNativeUObject(BP_Portal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060276FA RID: 161530 RVA: 0x009910C0 File Offset: 0x0098F2C0
		[NullableContext(1)]
		public BP_Portal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Portal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x060276FB RID: 161531 RVA: 0x009910F3 File Offset: 0x0098F2F3
		// (set) Token: 0x060276FC RID: 161532 RVA: 0x00991107 File Offset: 0x0098F307
		public unsafe USceneCaptureComponent2D CapturePosition1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005823 RID: 22563
		// (get) Token: 0x060276FD RID: 161533 RVA: 0x0099111C File Offset: 0x0098F31C
		// (set) Token: 0x060276FE RID: 161534 RVA: 0x00991130 File Offset: 0x0098F330
		public unsafe USceneCaptureComponent2D CapturePosition2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005824 RID: 22564
		// (get) Token: 0x060276FF RID: 161535 RVA: 0x00991145 File Offset: 0x0098F345
		// (set) Token: 0x06027700 RID: 161536 RVA: 0x00991159 File Offset: 0x0098F359
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x06027701 RID: 161537 RVA: 0x0099116E File Offset: 0x0098F36E
		// (set) Token: 0x06027702 RID: 161538 RVA: 0x00991182 File Offset: 0x0098F382
		public unsafe FTransformDouble PortalWorldTransform1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x06027703 RID: 161539 RVA: 0x00991197 File Offset: 0x0098F397
		// (set) Token: 0x06027704 RID: 161540 RVA: 0x009911AB File Offset: 0x0098F3AB
		public unsafe FTransformDouble PortalWorldTransform2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x06027705 RID: 161541 RVA: 0x009911C0 File Offset: 0x0098F3C0
		// (set) Token: 0x06027706 RID: 161542 RVA: 0x009911D4 File Offset: 0x0098F3D4
		public unsafe UMaterialInstanceDynamic DMI_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x06027707 RID: 161543 RVA: 0x009911E9 File Offset: 0x0098F3E9
		// (set) Token: 0x06027708 RID: 161544 RVA: 0x009911FD File Offset: 0x0098F3FD
		public unsafe UMaterialInstanceDynamic DMI_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x06027709 RID: 161545 RVA: 0x00991212 File Offset: 0x0098F412
		// (set) Token: 0x0602770A RID: 161546 RVA: 0x00991226 File Offset: 0x0098F426
		public unsafe FLinearColor PortalColor1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x0602770B RID: 161547 RVA: 0x0099123B File Offset: 0x0098F43B
		// (set) Token: 0x0602770C RID: 161548 RVA: 0x0099124F File Offset: 0x0098F44F
		public unsafe FLinearColor PortalColor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x0602770D RID: 161549 RVA: 0x00991264 File Offset: 0x0098F464
		// (set) Token: 0x0602770E RID: 161550 RVA: 0x00991278 File Offset: 0x0098F478
		public unsafe AActor DebugActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x0602770F RID: 161551 RVA: 0x0099128D File Offset: 0x0098F48D
		// (set) Token: 0x06027710 RID: 161552 RVA: 0x009912A1 File Offset: 0x0098F4A1
		public unsafe AActor DebugActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x06027711 RID: 161553 RVA: 0x009912B6 File Offset: 0x0098F4B6
		// (set) Token: 0x06027712 RID: 161554 RVA: 0x009912C6 File Offset: 0x0098F4C6
		public unsafe bool Portal1Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700582E RID: 22574
		// (get) Token: 0x06027713 RID: 161555 RVA: 0x009912D7 File Offset: 0x0098F4D7
		// (set) Token: 0x06027714 RID: 161556 RVA: 0x009912E7 File Offset: 0x0098F4E7
		public unsafe bool Portal2Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700582F RID: 22575
		// (get) Token: 0x06027715 RID: 161557 RVA: 0x009912F8 File Offset: 0x0098F4F8
		// (set) Token: 0x06027716 RID: 161558 RVA: 0x0099130C File Offset: 0x0098F50C
		public unsafe UTextureRenderTarget2D RT2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005830 RID: 22576
		// (get) Token: 0x06027717 RID: 161559 RVA: 0x00991321 File Offset: 0x0098F521
		// (set) Token: 0x06027718 RID: 161560 RVA: 0x00991331 File Offset: 0x0098F531
		public unsafe float AnimShowLen_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x06027719 RID: 161561 RVA: 0x00991342 File Offset: 0x0098F542
		// (set) Token: 0x0602771A RID: 161562 RVA: 0x00991352 File Offset: 0x0098F552
		public unsafe float AnimFadeLen_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0602771B RID: 161563 RVA: 0x00991363 File Offset: 0x0098F563
		// (set) Token: 0x0602771C RID: 161564 RVA: 0x00991373 File Offset: 0x0098F573
		public unsafe bool AnimIsShowing_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0602771D RID: 161565 RVA: 0x00991384 File Offset: 0x0098F584
		// (set) Token: 0x0602771E RID: 161566 RVA: 0x00991398 File Offset: 0x0098F598
		public unsafe UCurveFloat AnimShowCurve_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0602771F RID: 161567 RVA: 0x009913AD File Offset: 0x0098F5AD
		// (set) Token: 0x06027720 RID: 161568 RVA: 0x009913C1 File Offset: 0x0098F5C1
		public unsafe UCurveFloat AnimFadeCurve_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x06027721 RID: 161569 RVA: 0x009913D6 File Offset: 0x0098F5D6
		// (set) Token: 0x06027722 RID: 161570 RVA: 0x009913E6 File Offset: 0x0098F5E6
		public unsafe float AnimCounter_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005836 RID: 22582
		// (get) Token: 0x06027723 RID: 161571 RVA: 0x009913F7 File Offset: 0x0098F5F7
		// (set) Token: 0x06027724 RID: 161572 RVA: 0x00991407 File Offset: 0x0098F607
		public unsafe float AnimShowLen_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x06027725 RID: 161573 RVA: 0x00991418 File Offset: 0x0098F618
		// (set) Token: 0x06027726 RID: 161574 RVA: 0x00991428 File Offset: 0x0098F628
		public unsafe float AnimFadeLen_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x06027727 RID: 161575 RVA: 0x00991439 File Offset: 0x0098F639
		// (set) Token: 0x06027728 RID: 161576 RVA: 0x00991449 File Offset: 0x0098F649
		public unsafe bool AnimIsShowing_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x06027729 RID: 161577 RVA: 0x0099145A File Offset: 0x0098F65A
		// (set) Token: 0x0602772A RID: 161578 RVA: 0x0099146E File Offset: 0x0098F66E
		public unsafe UCurveFloat AnimShowCurve_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x1700583A RID: 22586
		// (get) Token: 0x0602772B RID: 161579 RVA: 0x00991483 File Offset: 0x0098F683
		// (set) Token: 0x0602772C RID: 161580 RVA: 0x00991497 File Offset: 0x0098F697
		public unsafe UCurveFloat AnimFadeCurve_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x0602772D RID: 161581 RVA: 0x009914AC File Offset: 0x0098F6AC
		// (set) Token: 0x0602772E RID: 161582 RVA: 0x009914BC File Offset: 0x0098F6BC
		public unsafe float AnimCounter_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x0602772F RID: 161583 RVA: 0x009914CD File Offset: 0x0098F6CD
		// (set) Token: 0x06027730 RID: 161584 RVA: 0x009914E1 File Offset: 0x0098F6E1
		public unsafe UTextureRenderTarget2D RT1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x06027731 RID: 161585 RVA: 0x009914F8 File Offset: 0x0098F6F8
		// (set) Token: 0x06027732 RID: 161586 RVA: 0x00991531 File Offset: 0x0098F731
		[Nullable(1)]
		public FSoftObjectPath EffectData_1
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectData_1) == null)
				{
					result = (this._EffectData_1 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_28, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_28, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x06027733 RID: 161587 RVA: 0x00991554 File Offset: 0x0098F754
		// (set) Token: 0x06027734 RID: 161588 RVA: 0x0099158D File Offset: 0x0098F78D
		[Nullable(1)]
		public FSoftObjectPath EffectData_2
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectData_2) == null)
				{
					result = (this._EffectData_2 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_29, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_29, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x06027735 RID: 161589 RVA: 0x009915AE File Offset: 0x0098F7AE
		// (set) Token: 0x06027736 RID: 161590 RVA: 0x009915C2 File Offset: 0x0098F7C2
		public unsafe FVector PortalBounds1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x06027737 RID: 161591 RVA: 0x009915D7 File Offset: 0x0098F7D7
		// (set) Token: 0x06027738 RID: 161592 RVA: 0x009915E7 File Offset: 0x0098F7E7
		public unsafe bool EnableDebugCamera1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005841 RID: 22593
		// (get) Token: 0x06027739 RID: 161593 RVA: 0x009915F8 File Offset: 0x0098F7F8
		// (set) Token: 0x0602773A RID: 161594 RVA: 0x00991608 File Offset: 0x0098F808
		public unsafe bool EnableDebugCamera2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005842 RID: 22594
		// (get) Token: 0x0602773B RID: 161595 RVA: 0x00991619 File Offset: 0x0098F819
		// (set) Token: 0x0602773C RID: 161596 RVA: 0x0099162D File Offset: 0x0098F82D
		public unsafe FVector PortalBounds2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17005843 RID: 22595
		// (get) Token: 0x0602773D RID: 161597 RVA: 0x00991644 File Offset: 0x0098F844
		// (set) Token: 0x0602773E RID: 161598 RVA: 0x0099167D File Offset: 0x0098F87D
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Mobile_VeryLow
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Mobile_VeryLow) == null)
				{
					result = (this._CaptureConfig_Mobile_VeryLow = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_34, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_34, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x0602773F RID: 161599 RVA: 0x009916A0 File Offset: 0x0098F8A0
		// (set) Token: 0x06027740 RID: 161600 RVA: 0x009916D9 File Offset: 0x0098F8D9
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Mobile_Low
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Mobile_Low) == null)
				{
					result = (this._CaptureConfig_Mobile_Low = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_35, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_35, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x06027741 RID: 161601 RVA: 0x009916FC File Offset: 0x0098F8FC
		// (set) Token: 0x06027742 RID: 161602 RVA: 0x00991735 File Offset: 0x0098F935
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Mobile_Mid
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Mobile_Mid) == null)
				{
					result = (this._CaptureConfig_Mobile_Mid = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_36, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_36, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x06027743 RID: 161603 RVA: 0x00991758 File Offset: 0x0098F958
		// (set) Token: 0x06027744 RID: 161604 RVA: 0x00991791 File Offset: 0x0098F991
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Mobile_High
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Mobile_High) == null)
				{
					result = (this._CaptureConfig_Mobile_High = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_37, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_37, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x06027745 RID: 161605 RVA: 0x009917B4 File Offset: 0x0098F9B4
		// (set) Token: 0x06027746 RID: 161606 RVA: 0x009917ED File Offset: 0x0098F9ED
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Pc_VeryLow
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Pc_VeryLow) == null)
				{
					result = (this._CaptureConfig_Pc_VeryLow = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_38, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_38, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005848 RID: 22600
		// (get) Token: 0x06027747 RID: 161607 RVA: 0x00991810 File Offset: 0x0098FA10
		// (set) Token: 0x06027748 RID: 161608 RVA: 0x00991849 File Offset: 0x0098FA49
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Pc_Low
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Pc_Low) == null)
				{
					result = (this._CaptureConfig_Pc_Low = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_39, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_39, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005849 RID: 22601
		// (get) Token: 0x06027749 RID: 161609 RVA: 0x0099186C File Offset: 0x0098FA6C
		// (set) Token: 0x0602774A RID: 161610 RVA: 0x009918A5 File Offset: 0x0098FAA5
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Pc_Mid
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Pc_Mid) == null)
				{
					result = (this._CaptureConfig_Pc_Mid = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_40, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_40, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700584A RID: 22602
		// (get) Token: 0x0602774B RID: 161611 RVA: 0x009918C8 File Offset: 0x0098FAC8
		// (set) Token: 0x0602774C RID: 161612 RVA: 0x00991901 File Offset: 0x0098FB01
		[Nullable(1)]
		public FSceneCaptureComponent2DParams CaptureConfig_Pc_High
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSceneCaptureComponent2DParams result;
				if ((result = this._CaptureConfig_Pc_High) == null)
				{
					result = (this._CaptureConfig_Pc_High = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_41, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_41, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700584B RID: 22603
		// (get) Token: 0x0602774D RID: 161613 RVA: 0x00991922 File Offset: 0x0098FB22
		// (set) Token: 0x0602774E RID: 161614 RVA: 0x00991932 File Offset: 0x0098FB32
		public unsafe bool IsMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700584C RID: 22604
		// (get) Token: 0x0602774F RID: 161615 RVA: 0x00991943 File Offset: 0x0098FB43
		// (set) Token: 0x06027750 RID: 161616 RVA: 0x00991953 File Offset: 0x0098FB53
		public unsafe int PerformanceLevel_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x06027751 RID: 161617 RVA: 0x00991964 File Offset: 0x0098FB64
		// (set) Token: 0x06027752 RID: 161618 RVA: 0x00991974 File Offset: 0x0098FB74
		public unsafe int PerformanceLevel_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x06027753 RID: 161619 RVA: 0x00991985 File Offset: 0x0098FB85
		// (set) Token: 0x06027754 RID: 161620 RVA: 0x00991995 File Offset: 0x0098FB95
		public unsafe float CaptureMaxViewDistance_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x06027755 RID: 161621 RVA: 0x009919A6 File Offset: 0x0098FBA6
		// (set) Token: 0x06027756 RID: 161622 RVA: 0x009919B6 File Offset: 0x0098FBB6
		public unsafe float CaptureMaxViewDistance_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x06027757 RID: 161623 RVA: 0x009919C7 File Offset: 0x0098FBC7
		// (set) Token: 0x06027758 RID: 161624 RVA: 0x009919D7 File Offset: 0x0098FBD7
		public unsafe bool EnableDebugCapture1Params
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x06027759 RID: 161625 RVA: 0x009919E8 File Offset: 0x0098FBE8
		// (set) Token: 0x0602775A RID: 161626 RVA: 0x009919F8 File Offset: 0x0098FBF8
		public unsafe bool EnableDebugCapture2Params
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x0602775B RID: 161627 RVA: 0x00991A09 File Offset: 0x0098FC09
		// (set) Token: 0x0602775C RID: 161628 RVA: 0x00991A19 File Offset: 0x0098FC19
		public unsafe float CapturePerf_Lv0_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x0602775D RID: 161629 RVA: 0x00991A2A File Offset: 0x0098FC2A
		// (set) Token: 0x0602775E RID: 161630 RVA: 0x00991A3A File Offset: 0x0098FC3A
		public unsafe float CapturePerf_Lv1_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x0602775F RID: 161631 RVA: 0x00991A4B File Offset: 0x0098FC4B
		// (set) Token: 0x06027760 RID: 161632 RVA: 0x00991A5B File Offset: 0x0098FC5B
		public unsafe float CapturePerf_Lv2_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x06027761 RID: 161633 RVA: 0x00991A6C File Offset: 0x0098FC6C
		// (set) Token: 0x06027762 RID: 161634 RVA: 0x00991AA5 File Offset: 0x0098FCA5
		[Nullable(1)]
		public TMap<string, bool> Capture1InitShowFlags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, bool> result;
				if ((result = this._Capture1InitShowFlags) == null)
				{
					result = (this._Capture1InitShowFlags = new TMap<string, bool>(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_52, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Capture1InitShowFlags.CopyAssign(value);
			}
		}

		// Token: 0x17005856 RID: 22614
		// (get) Token: 0x06027763 RID: 161635 RVA: 0x00991AB4 File Offset: 0x0098FCB4
		// (set) Token: 0x06027764 RID: 161636 RVA: 0x00991AED File Offset: 0x0098FCED
		[Nullable(1)]
		public TMap<string, bool> Capture2InitShowFlags
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, bool> result;
				if ((result = this._Capture2InitShowFlags) == null)
				{
					result = (this._Capture2InitShowFlags = new TMap<string, bool>(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_53, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Capture2InitShowFlags.CopyAssign(value);
			}
		}

		// Token: 0x17005857 RID: 22615
		// (get) Token: 0x06027765 RID: 161637 RVA: 0x00991AFB File Offset: 0x0098FCFB
		// (set) Token: 0x06027766 RID: 161638 RVA: 0x00991B0B File Offset: 0x0098FD0B
		public unsafe bool IsMac
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027767 RID: 161639 RVA: 0x00991B1C File Offset: 0x0098FD1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DrawDebugPortalBounds(bool IsPortal1)
		{
			BP_Portal_C.__DrawDebugPortalBounds_FunctionParams* ptr = stackalloc BP_Portal_C.__DrawDebugPortalBounds_FunctionParams[(UIntPtr)351] + 15L / (long)sizeof(BP_Portal_C.__DrawDebugPortalBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__DrawDebugPortalBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsPortal1 = IsPortal1;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DrawDebugPortalBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027768 RID: 161640 RVA: 0x00991B68 File Offset: 0x0098FD68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PrintDebugCaptureParams(bool IsCapture1, FSceneCaptureComponent2DParams CaptureParam)
		{
			BP_Portal_C.__PrintDebugCaptureParams_FunctionParams* ptr = stackalloc BP_Portal_C.__PrintDebugCaptureParams_FunctionParams[(UIntPtr)815] + 15L / (long)sizeof(BP_Portal_C.__PrintDebugCaptureParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__PrintDebugCaptureParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			if (CaptureParam != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), &ptr->CaptureParam, CaptureParam.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__PrintDebugCaptureParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027769 RID: 161641 RVA: 0x00991BD4 File Offset: 0x0098FDD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckCapturePerformanceLevel(bool isPortalA, FTransformDouble targetTrans)
		{
			BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams* ptr = stackalloc BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__CheckCapturePerformanceLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPortalA = isPortalA;
			ptr->targetTrans = targetTrans;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__CheckCapturePerformanceLevel_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602776A RID: 161642 RVA: 0x00991C24 File Offset: 0x0098FE24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyCapturePerformace(bool IsPortalA, int ConfigLevel, float CaptureMaxViewDistance)
		{
			BP_Portal_C.__ApplyCapturePerformace_FunctionParams* ptr = stackalloc BP_Portal_C.__ApplyCapturePerformace_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Portal_C.__ApplyCapturePerformace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ApplyCapturePerformace_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsPortalA = IsPortalA;
			ptr->ConfigLevel = ConfigLevel;
			ptr->CaptureMaxViewDistance = CaptureMaxViewDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ApplyCapturePerformace_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602776B RID: 161643 RVA: 0x00991C78 File Offset: 0x0098FE78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAngleBetweenVector(FVector Vector1, FVector Vector2, ref float Angle)
		{
			BP_Portal_C.__GetAngleBetweenVector_FunctionParams* ptr = stackalloc BP_Portal_C.__GetAngleBetweenVector_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_Portal_C.__GetAngleBetweenVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__GetAngleBetweenVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vector1 = Vector1;
			ptr->Vector2 = Vector2;
			ptr->Angle = Angle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__GetAngleBetweenVector_NativeFunctionPtr, (void*)ptr);
			Angle = ptr->Angle;
		}

		// Token: 0x0602776C RID: 161644 RVA: 0x00991CD8 File Offset: 0x0098FED8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DrawDebugFrustum(FTransformDouble Transform, float FovX, float NearClipPlane, float AspectRatio)
		{
			BP_Portal_C.__DrawDebugFrustum_FunctionParams* ptr = stackalloc BP_Portal_C.__DrawDebugFrustum_FunctionParams[(UIntPtr)431] + 15L / (long)sizeof(BP_Portal_C.__DrawDebugFrustum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__DrawDebugFrustum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Transform = Transform;
			ptr->FovX = FovX;
			ptr->NearClipPlane = NearClipPlane;
			ptr->AspectRatio = AspectRatio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DrawDebugFrustum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602776D RID: 161645 RVA: 0x00991D38 File Offset: 0x0098FF38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMappingTransformToOtherPortal(FTransformDouble SourceTransform, bool bA2B, ref FTransformDouble TargetTransform)
		{
			BP_Portal_C.__GetMappingTransformToOtherPortal_FunctionParams* ptr = stackalloc BP_Portal_C.__GetMappingTransformToOtherPortal_FunctionParams[(UIntPtr)607] + 15L / (long)sizeof(BP_Portal_C.__GetMappingTransformToOtherPortal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__GetMappingTransformToOtherPortal_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SourceTransform = SourceTransform;
			ptr->bA2B = bA2B;
			ptr->TargetTransform = TargetTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__GetMappingTransformToOtherPortal_NativeFunctionPtr, (void*)ptr);
			TargetTransform = ptr->TargetTransform;
		}

		// Token: 0x0602776E RID: 161646 RVA: 0x00991DA0 File Offset: 0x0098FFA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePortalsCameraPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__UpdatePortalsCameraPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0602776F RID: 161647 RVA: 0x00991DB4 File Offset: 0x0098FFB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdatePortalAnimation(float ShowLen, float FadeLen, bool IsShown, UCurveFloat ShowCurve, UCurveFloat FadeCurve, float Counter, UStaticMeshComponent SM, UStaticMeshComponent DMI, ref float OutputCounter, ref float Factor)
		{
			BP_Portal_C.__UpdatePortalAnimation_FunctionParams* ptr = stackalloc BP_Portal_C.__UpdatePortalAnimation_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_Portal_C.__UpdatePortalAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__UpdatePortalAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ShowLen = ShowLen;
			ptr->FadeLen = FadeLen;
			ptr->IsShown = IsShown;
			ptr->ShowCurve = ((ShowCurve != null) ? ShowCurve.NativePtr : IntPtr.Zero);
			ptr->FadeCurve = ((FadeCurve != null) ? FadeCurve.NativePtr : IntPtr.Zero);
			ptr->Counter = Counter;
			ptr->SM = ((SM != null) ? SM.NativePtr : IntPtr.Zero);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->OutputCounter = OutputCounter;
			ptr->Factor = Factor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__UpdatePortalAnimation_NativeFunctionPtr, (void*)ptr);
			OutputCounter = ptr->OutputCounter;
			Factor = ptr->Factor;
		}

		// Token: 0x06027770 RID: 161648 RVA: 0x00991E94 File Offset: 0x00990094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCaptureShowFlags(bool IsCapture1, [Nullable(new byte[]
		{
			2,
			1
		})] TMap<string, bool> ShowFlags)
		{
			BP_Portal_C.__SetCaptureShowFlags_FunctionParams* ptr = stackalloc BP_Portal_C.__SetCaptureShowFlags_FunctionParams[(UIntPtr)543] + 15L / (long)sizeof(BP_Portal_C.__SetCaptureShowFlags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetCaptureShowFlags_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			if (ShowFlags != null)
			{
				ShowFlags.CopyTo(&ptr->ShowFlags, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetCaptureShowFlags_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_Portal_C.__SetCaptureShowFlags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027771 RID: 161649 RVA: 0x00991F08 File Offset: 0x00990108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCaptureShowFlags(bool IsCapture1, [Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<string, bool> ShowFlags)
		{
			BP_Portal_C.__GetCaptureShowFlags_FunctionParams* ptr = stackalloc BP_Portal_C.__GetCaptureShowFlags_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_Portal_C.__GetCaptureShowFlags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__GetCaptureShowFlags_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			TMap<string, bool> tmap = ShowFlags;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->ShowFlags);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__GetCaptureShowFlags_NativeFunctionPtr, (void*)ptr);
			TMap<string, bool> tmap2 = ShowFlags;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->ShowFlags);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Portal_C.__GetCaptureShowFlags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027772 RID: 161650 RVA: 0x00991F8C File Offset: 0x0099018C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCaptureMaxViewDistance(bool IsCapture1, float MaxViewDistance)
		{
			BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams* ptr = stackalloc BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetCaptureMaxViewDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			ptr->MaxViewDistance = MaxViewDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetCaptureMaxViewDistance_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027773 RID: 161651 RVA: 0x00991FDC File Offset: 0x009901DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCaptureShowingActors(bool IsCapture1, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> HiddenActors, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ForceShowActors)
		{
			BP_Portal_C.__SetCaptureShowingActors_FunctionParams* ptr = stackalloc BP_Portal_C.__SetCaptureShowingActors_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_Portal_C.__SetCaptureShowingActors_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetCaptureShowingActors_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			TArray<AActor> tarray = HiddenActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->HiddenActors);
			}
			TArray<AActor> tarray2 = ForceShowActors;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->ForceShowActors);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetCaptureShowingActors_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray3 = HiddenActors;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->HiddenActors);
			}
			TArray<AActor> tarray4 = ForceShowActors;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->ForceShowActors);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Portal_C.__SetCaptureShowingActors_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027774 RID: 161652 RVA: 0x00992083 File Offset: 0x00990283
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG_关闭2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_关闭2_NativeFunctionPtr, null);
		}

		// Token: 0x06027775 RID: 161653 RVA: 0x00992097 File Offset: 0x00990297
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG_关闭1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_关闭1_NativeFunctionPtr, null);
		}

		// Token: 0x06027776 RID: 161654 RVA: 0x009920AB File Offset: 0x009902AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG_开启2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_开启2_NativeFunctionPtr, null);
		}

		// Token: 0x06027777 RID: 161655 RVA: 0x009920BF File Offset: 0x009902BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisablePortal2Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DisablePortal2Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x06027778 RID: 161656 RVA: 0x009920D3 File Offset: 0x009902D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnablePortal2Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__EnablePortal2Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x06027779 RID: 161657 RVA: 0x009920E7 File Offset: 0x009902E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisablePortal1Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DisablePortal1Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0602777A RID: 161658 RVA: 0x009920FB File Offset: 0x009902FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnablePortal1Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__EnablePortal1Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0602777B RID: 161659 RVA: 0x00992110 File Offset: 0x00990310
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPortal2Transform(FTransformDouble Transform, FTransformDouble CaptureTransform)
		{
			BP_Portal_C.__SetPortal2Transform_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal2Transform_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_Portal_C.__SetPortal2Transform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal2Transform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Transform = Transform;
			ptr->CaptureTransform = CaptureTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal2Transform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602777C RID: 161660 RVA: 0x00992160 File Offset: 0x00990360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPortal1Transform(FTransformDouble Transform, FTransformDouble CaptureTransform)
		{
			BP_Portal_C.__SetPortal1Transform_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal1Transform_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_Portal_C.__SetPortal1Transform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal1Transform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Transform = Transform;
			ptr->CaptureTransform = CaptureTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal1Transform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602777D RID: 161661 RVA: 0x009921B0 File Offset: 0x009903B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPortal2Bounds(FVector Bounds)
		{
			BP_Portal_C.__SetPortal2Bounds_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal2Bounds_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_Portal_C.__SetPortal2Bounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal2Bounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Bounds = Bounds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal2Bounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602777E RID: 161662 RVA: 0x009921F8 File Offset: 0x009903F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPortal1Bounds(FVector Bounds)
		{
			BP_Portal_C.__SetPortal1Bounds_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal1Bounds_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_Portal_C.__SetPortal1Bounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal1Bounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Bounds = Bounds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal1Bounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602777F RID: 161663 RVA: 0x0099223E File Offset: 0x0099043E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DEBUG_开启1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_开启1_NativeFunctionPtr, null);
		}

		// Token: 0x06027780 RID: 161664 RVA: 0x00992252 File Offset: 0x00990452
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027781 RID: 161665 RVA: 0x00992266 File Offset: 0x00990466
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027782 RID: 161666 RVA: 0x0099227C File Offset: 0x0099047C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Portal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Portal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Portal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027783 RID: 161667 RVA: 0x009922C4 File Offset: 0x009904C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Portal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Portal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Portal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027784 RID: 161668 RVA: 0x0099230B File Offset: 0x0099050B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027785 RID: 161669 RVA: 0x0099231F File Offset: 0x0099051F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027786 RID: 161670 RVA: 0x00992334 File Offset: 0x00990534
		protected BP_Portal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EA9 RID: 81577
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C";

		// Token: 0x04013EAA RID: 81578
		private static IntPtr _ClassPtr;

		// Token: 0x04013EAB RID: 81579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EAC RID: 81580
		internal static int __PropertyOffset_1;

		// Token: 0x04013EAD RID: 81581
		internal static int __PropertyOffset_2;

		// Token: 0x04013EAE RID: 81582
		internal static int __PropertyOffset_3;

		// Token: 0x04013EAF RID: 81583
		internal static int __PropertyOffset_4;

		// Token: 0x04013EB0 RID: 81584
		internal static int __PropertyOffset_5;

		// Token: 0x04013EB1 RID: 81585
		internal static int __PropertyOffset_6;

		// Token: 0x04013EB2 RID: 81586
		internal static int __PropertyOffset_7;

		// Token: 0x04013EB3 RID: 81587
		internal static int __PropertyOffset_8;

		// Token: 0x04013EB4 RID: 81588
		internal static int __PropertyOffset_9;

		// Token: 0x04013EB5 RID: 81589
		internal static int __PropertyOffset_10;

		// Token: 0x04013EB6 RID: 81590
		internal static int __PropertyOffset_11;

		// Token: 0x04013EB7 RID: 81591
		internal static int __PropertyOffset_12;

		// Token: 0x04013EB8 RID: 81592
		internal static int __PropertyOffset_13;

		// Token: 0x04013EB9 RID: 81593
		internal static int __PropertyOffset_14;

		// Token: 0x04013EBA RID: 81594
		internal static int __PropertyOffset_15;

		// Token: 0x04013EBB RID: 81595
		internal static int __PropertyOffset_16;

		// Token: 0x04013EBC RID: 81596
		internal static int __PropertyOffset_17;

		// Token: 0x04013EBD RID: 81597
		internal static int __PropertyOffset_18;

		// Token: 0x04013EBE RID: 81598
		internal static int __PropertyOffset_19;

		// Token: 0x04013EBF RID: 81599
		internal static int __PropertyOffset_20;

		// Token: 0x04013EC0 RID: 81600
		internal static int __PropertyOffset_21;

		// Token: 0x04013EC1 RID: 81601
		internal static int __PropertyOffset_22;

		// Token: 0x04013EC2 RID: 81602
		internal static int __PropertyOffset_23;

		// Token: 0x04013EC3 RID: 81603
		internal static int __PropertyOffset_24;

		// Token: 0x04013EC4 RID: 81604
		internal static int __PropertyOffset_25;

		// Token: 0x04013EC5 RID: 81605
		internal static int __PropertyOffset_26;

		// Token: 0x04013EC6 RID: 81606
		internal static int __PropertyOffset_27;

		// Token: 0x04013EC7 RID: 81607
		internal static int __PropertyOffset_28;

		// Token: 0x04013EC8 RID: 81608
		private FSoftObjectPath _EffectData_1;

		// Token: 0x04013EC9 RID: 81609
		internal static int __PropertyOffset_29;

		// Token: 0x04013ECA RID: 81610
		private FSoftObjectPath _EffectData_2;

		// Token: 0x04013ECB RID: 81611
		internal static int __PropertyOffset_30;

		// Token: 0x04013ECC RID: 81612
		internal static int __PropertyOffset_31;

		// Token: 0x04013ECD RID: 81613
		internal static int __PropertyOffset_32;

		// Token: 0x04013ECE RID: 81614
		internal static int __PropertyOffset_33;

		// Token: 0x04013ECF RID: 81615
		internal static int __PropertyOffset_34;

		// Token: 0x04013ED0 RID: 81616
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_VeryLow;

		// Token: 0x04013ED1 RID: 81617
		internal static int __PropertyOffset_35;

		// Token: 0x04013ED2 RID: 81618
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_Low;

		// Token: 0x04013ED3 RID: 81619
		internal static int __PropertyOffset_36;

		// Token: 0x04013ED4 RID: 81620
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_Mid;

		// Token: 0x04013ED5 RID: 81621
		internal static int __PropertyOffset_37;

		// Token: 0x04013ED6 RID: 81622
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_High;

		// Token: 0x04013ED7 RID: 81623
		internal static int __PropertyOffset_38;

		// Token: 0x04013ED8 RID: 81624
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_VeryLow;

		// Token: 0x04013ED9 RID: 81625
		internal static int __PropertyOffset_39;

		// Token: 0x04013EDA RID: 81626
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_Low;

		// Token: 0x04013EDB RID: 81627
		internal static int __PropertyOffset_40;

		// Token: 0x04013EDC RID: 81628
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_Mid;

		// Token: 0x04013EDD RID: 81629
		internal static int __PropertyOffset_41;

		// Token: 0x04013EDE RID: 81630
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_High;

		// Token: 0x04013EDF RID: 81631
		internal static int __PropertyOffset_42;

		// Token: 0x04013EE0 RID: 81632
		internal static int __PropertyOffset_43;

		// Token: 0x04013EE1 RID: 81633
		internal static int __PropertyOffset_44;

		// Token: 0x04013EE2 RID: 81634
		internal static int __PropertyOffset_45;

		// Token: 0x04013EE3 RID: 81635
		internal static int __PropertyOffset_46;

		// Token: 0x04013EE4 RID: 81636
		internal static int __PropertyOffset_47;

		// Token: 0x04013EE5 RID: 81637
		internal static int __PropertyOffset_48;

		// Token: 0x04013EE6 RID: 81638
		internal static int __PropertyOffset_49;

		// Token: 0x04013EE7 RID: 81639
		internal static int __PropertyOffset_50;

		// Token: 0x04013EE8 RID: 81640
		internal static int __PropertyOffset_51;

		// Token: 0x04013EE9 RID: 81641
		internal static int __PropertyOffset_52;

		// Token: 0x04013EEA RID: 81642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _Capture1InitShowFlags;

		// Token: 0x04013EEB RID: 81643
		internal static int __PropertyOffset_53;

		// Token: 0x04013EEC RID: 81644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _Capture2InitShowFlags;

		// Token: 0x04013EED RID: 81645
		internal static int __PropertyOffset_54;

		// Token: 0x04013EEE RID: 81646
		private static IntPtr __DrawDebugPortalBounds_NativeFunctionPtr;

		// Token: 0x04013EEF RID: 81647
		private static IntPtr __PrintDebugCaptureParams_NativeFunctionPtr;

		// Token: 0x04013EF0 RID: 81648
		private static IntPtr __CheckCapturePerformanceLevel_NativeFunctionPtr;

		// Token: 0x04013EF1 RID: 81649
		private static IntPtr __ApplyCapturePerformace_NativeFunctionPtr;

		// Token: 0x04013EF2 RID: 81650
		private static IntPtr __GetAngleBetweenVector_NativeFunctionPtr;

		// Token: 0x04013EF3 RID: 81651
		private static IntPtr __DrawDebugFrustum_NativeFunctionPtr;

		// Token: 0x04013EF4 RID: 81652
		private static IntPtr __GetMappingTransformToOtherPortal_NativeFunctionPtr;

		// Token: 0x04013EF5 RID: 81653
		private static IntPtr __UpdatePortalsCameraPosition_NativeFunctionPtr;

		// Token: 0x04013EF6 RID: 81654
		private static IntPtr __UpdatePortalAnimation_NativeFunctionPtr;

		// Token: 0x04013EF7 RID: 81655
		private static IntPtr __SetCaptureShowFlags_NativeFunctionPtr;

		// Token: 0x04013EF8 RID: 81656
		private static IntPtr __GetCaptureShowFlags_NativeFunctionPtr;

		// Token: 0x04013EF9 RID: 81657
		private static IntPtr __SetCaptureMaxViewDistance_NativeFunctionPtr;

		// Token: 0x04013EFA RID: 81658
		private static IntPtr __SetCaptureShowingActors_NativeFunctionPtr;

		// Token: 0x04013EFB RID: 81659
		private static IntPtr __DEBUG_关闭2_NativeFunctionPtr;

		// Token: 0x04013EFC RID: 81660
		private static IntPtr __DEBUG_关闭1_NativeFunctionPtr;

		// Token: 0x04013EFD RID: 81661
		private static IntPtr __DEBUG_开启2_NativeFunctionPtr;

		// Token: 0x04013EFE RID: 81662
		private static IntPtr __DisablePortal2Rendering_NativeFunctionPtr;

		// Token: 0x04013EFF RID: 81663
		private static IntPtr __EnablePortal2Rendering_NativeFunctionPtr;

		// Token: 0x04013F00 RID: 81664
		private static IntPtr __DisablePortal1Rendering_NativeFunctionPtr;

		// Token: 0x04013F01 RID: 81665
		private static IntPtr __EnablePortal1Rendering_NativeFunctionPtr;

		// Token: 0x04013F02 RID: 81666
		private static IntPtr __SetPortal2Transform_NativeFunctionPtr;

		// Token: 0x04013F03 RID: 81667
		private static IntPtr __SetPortal1Transform_NativeFunctionPtr;

		// Token: 0x04013F04 RID: 81668
		private static IntPtr __SetPortal2Bounds_NativeFunctionPtr;

		// Token: 0x04013F05 RID: 81669
		private static IntPtr __SetPortal1Bounds_NativeFunctionPtr;

		// Token: 0x04013F06 RID: 81670
		private static IntPtr __DEBUG_开启1_NativeFunctionPtr;

		// Token: 0x04013F07 RID: 81671
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013F08 RID: 81672
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013F09 RID: 81673
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A228 RID: 41512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 336)]
		protected ref struct __DrawDebugPortalBounds_FunctionParams
		{
			// Token: 0x04031E92 RID: 204434
			[FieldOffset(0)]
			public bool IsPortal1;
		}

		// Token: 0x0200A229 RID: 41513
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 800)]
		protected ref struct __PrintDebugCaptureParams_FunctionParams
		{
			// Token: 0x04031E93 RID: 204435
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x04031E94 RID: 204436
			[FieldOffset(4)]
			public byte CaptureParam;
		}

		// Token: 0x0200A22A RID: 41514
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __CheckCapturePerformanceLevel_FunctionParams
		{
			// Token: 0x04031E95 RID: 204437
			[FieldOffset(0)]
			public bool isPortalA;

			// Token: 0x04031E96 RID: 204438
			[FieldOffset(16)]
			public FTransformDouble targetTrans;
		}

		// Token: 0x0200A22B RID: 41515
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ApplyCapturePerformace_FunctionParams
		{
			// Token: 0x04031E97 RID: 204439
			[FieldOffset(0)]
			public bool IsPortalA;

			// Token: 0x04031E98 RID: 204440
			[FieldOffset(4)]
			public int ConfigLevel;

			// Token: 0x04031E99 RID: 204441
			[FieldOffset(8)]
			public float CaptureMaxViewDistance;
		}

		// Token: 0x0200A22C RID: 41516
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAngleBetweenVector_FunctionParams
		{
			// Token: 0x04031E9A RID: 204442
			[FieldOffset(0)]
			public FVector Vector1;

			// Token: 0x04031E9B RID: 204443
			[FieldOffset(12)]
			public FVector Vector2;

			// Token: 0x04031E9C RID: 204444
			[FieldOffset(24)]
			public float Angle;
		}

		// Token: 0x0200A22D RID: 41517
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __DrawDebugFrustum_FunctionParams
		{
			// Token: 0x04031E9D RID: 204445
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x04031E9E RID: 204446
			[FieldOffset(64)]
			public float FovX;

			// Token: 0x04031E9F RID: 204447
			[FieldOffset(68)]
			public float NearClipPlane;

			// Token: 0x04031EA0 RID: 204448
			[FieldOffset(72)]
			public float AspectRatio;
		}

		// Token: 0x0200A22E RID: 41518
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 592)]
		protected ref struct __GetMappingTransformToOtherPortal_FunctionParams
		{
			// Token: 0x04031EA1 RID: 204449
			[FieldOffset(0)]
			public FTransformDouble SourceTransform;

			// Token: 0x04031EA2 RID: 204450
			[FieldOffset(64)]
			public bool bA2B;

			// Token: 0x04031EA3 RID: 204451
			[FieldOffset(80)]
			public FTransformDouble TargetTransform;
		}

		// Token: 0x0200A22F RID: 41519
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __UpdatePortalAnimation_FunctionParams
		{
			// Token: 0x04031EA4 RID: 204452
			[FieldOffset(0)]
			public float ShowLen;

			// Token: 0x04031EA5 RID: 204453
			[FieldOffset(4)]
			public float FadeLen;

			// Token: 0x04031EA6 RID: 204454
			[FieldOffset(8)]
			public bool IsShown;

			// Token: 0x04031EA7 RID: 204455
			[FieldOffset(16)]
			public IntPtr ShowCurve;

			// Token: 0x04031EA8 RID: 204456
			[FieldOffset(24)]
			public IntPtr FadeCurve;

			// Token: 0x04031EA9 RID: 204457
			[FieldOffset(32)]
			public float Counter;

			// Token: 0x04031EAA RID: 204458
			[FieldOffset(40)]
			public IntPtr SM;

			// Token: 0x04031EAB RID: 204459
			[FieldOffset(48)]
			public IntPtr DMI;

			// Token: 0x04031EAC RID: 204460
			[FieldOffset(56)]
			public float OutputCounter;

			// Token: 0x04031EAD RID: 204461
			[FieldOffset(60)]
			public float Factor;
		}

		// Token: 0x0200A230 RID: 41520
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __SetCaptureShowFlags_FunctionParams
		{
			// Token: 0x04031EAE RID: 204462
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x04031EAF RID: 204463
			[FieldOffset(8)]
			public byte ShowFlags;
		}

		// Token: 0x0200A231 RID: 41521
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetCaptureShowFlags_FunctionParams
		{
			// Token: 0x04031EB0 RID: 204464
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x04031EB1 RID: 204465
			[FieldOffset(8)]
			public byte ShowFlags;
		}

		// Token: 0x0200A232 RID: 41522
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCaptureMaxViewDistance_FunctionParams
		{
			// Token: 0x04031EB2 RID: 204466
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x04031EB3 RID: 204467
			[FieldOffset(4)]
			public float MaxViewDistance;
		}

		// Token: 0x0200A233 RID: 41523
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetCaptureShowingActors_FunctionParams
		{
			// Token: 0x04031EB4 RID: 204468
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x04031EB5 RID: 204469
			[FieldOffset(8)]
			public byte HiddenActors;

			// Token: 0x04031EB6 RID: 204470
			[FieldOffset(24)]
			public byte ForceShowActors;
		}

		// Token: 0x0200A234 RID: 41524
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetPortal2Transform_FunctionParams
		{
			// Token: 0x04031EB7 RID: 204471
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x04031EB8 RID: 204472
			[FieldOffset(64)]
			public FTransformDouble CaptureTransform;
		}

		// Token: 0x0200A235 RID: 41525
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetPortal1Transform_FunctionParams
		{
			// Token: 0x04031EB9 RID: 204473
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x04031EBA RID: 204474
			[FieldOffset(64)]
			public FTransformDouble CaptureTransform;
		}

		// Token: 0x0200A236 RID: 41526
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __SetPortal2Bounds_FunctionParams
		{
			// Token: 0x04031EBB RID: 204475
			[FieldOffset(0)]
			public FVector Bounds;
		}

		// Token: 0x0200A237 RID: 41527
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __SetPortal1Bounds_FunctionParams
		{
			// Token: 0x04031EBC RID: 204476
			[FieldOffset(0)]
			public FVector Bounds;
		}

		// Token: 0x0200A238 RID: 41528
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031EBD RID: 204477
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
