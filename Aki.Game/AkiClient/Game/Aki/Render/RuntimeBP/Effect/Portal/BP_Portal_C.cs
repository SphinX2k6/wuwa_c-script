using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal
{
	// Token: 0x0200310D RID: 12557
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1857)]
	public class BP_Portal_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBCF RID: 125903 RVA: 0x0091BC57 File Offset: 0x00919E57
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Portal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C");
			}
			return BP_Portal_C._ClassPtr;
		}

		// Token: 0x0601EBD0 RID: 125904 RVA: 0x0091BC7C File Offset: 0x00919E7C
		public BP_Portal_C() : this(BuiltinUtils.AllocNativeUObject(BP_Portal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBD1 RID: 125905 RVA: 0x0091BCA4 File Offset: 0x00919EA4
		[NullableContext(1)]
		public BP_Portal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Portal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0601EBD2 RID: 125906 RVA: 0x0091BCD7 File Offset: 0x00919ED7
		// (set) Token: 0x0601EBD3 RID: 125907 RVA: 0x0091BCEB File Offset: 0x00919EEB
		public unsafe USceneCaptureComponent2D CapturePosition1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_CapturePosition1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_CapturePosition1, value);
			}
		}

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0601EBD4 RID: 125908 RVA: 0x0091BD00 File Offset: 0x00919F00
		// (set) Token: 0x0601EBD5 RID: 125909 RVA: 0x0091BD14 File Offset: 0x00919F14
		public unsafe USceneCaptureComponent2D CapturePosition2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_CapturePosition2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_CapturePosition2, value);
			}
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0601EBD6 RID: 125910 RVA: 0x0091BD29 File Offset: 0x00919F29
		// (set) Token: 0x0601EBD7 RID: 125911 RVA: 0x0091BD3D File Offset: 0x00919F3D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0601EBD8 RID: 125912 RVA: 0x0091BD52 File Offset: 0x00919F52
		// (set) Token: 0x0601EBD9 RID: 125913 RVA: 0x0091BD66 File Offset: 0x00919F66
		public unsafe FTransformDouble PortalWorldTransform1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalWorldTransform1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalWorldTransform1) = value;
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0601EBDA RID: 125914 RVA: 0x0091BD7B File Offset: 0x00919F7B
		// (set) Token: 0x0601EBDB RID: 125915 RVA: 0x0091BD8F File Offset: 0x00919F8F
		public unsafe FTransformDouble PortalWorldTransform2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalWorldTransform2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalWorldTransform2) = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0601EBDC RID: 125916 RVA: 0x0091BDA4 File Offset: 0x00919FA4
		// (set) Token: 0x0601EBDD RID: 125917 RVA: 0x0091BDB8 File Offset: 0x00919FB8
		public unsafe UMaterialInstanceDynamic DMI_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DMI_Portal1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DMI_Portal1, value);
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0601EBDE RID: 125918 RVA: 0x0091BDCD File Offset: 0x00919FCD
		// (set) Token: 0x0601EBDF RID: 125919 RVA: 0x0091BDE1 File Offset: 0x00919FE1
		public unsafe UMaterialInstanceDynamic DMI_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DMI_Portal2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DMI_Portal2, value);
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0601EBE0 RID: 125920 RVA: 0x0091BDF6 File Offset: 0x00919FF6
		// (set) Token: 0x0601EBE1 RID: 125921 RVA: 0x0091BE0A File Offset: 0x0091A00A
		public unsafe FLinearColor PortalColor1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalColor1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalColor1) = value;
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0601EBE2 RID: 125922 RVA: 0x0091BE1F File Offset: 0x0091A01F
		// (set) Token: 0x0601EBE3 RID: 125923 RVA: 0x0091BE33 File Offset: 0x0091A033
		public unsafe FLinearColor PortalColor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalColor2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalColor2) = value;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0601EBE4 RID: 125924 RVA: 0x0091BE48 File Offset: 0x0091A048
		// (set) Token: 0x0601EBE5 RID: 125925 RVA: 0x0091BE5C File Offset: 0x0091A05C
		public unsafe AActor DebugActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DebugActor1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DebugActor1, value);
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0601EBE6 RID: 125926 RVA: 0x0091BE71 File Offset: 0x0091A071
		// (set) Token: 0x0601EBE7 RID: 125927 RVA: 0x0091BE85 File Offset: 0x0091A085
		public unsafe AActor DebugActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DebugActor2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_DebugActor2, value);
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0601EBE8 RID: 125928 RVA: 0x0091BE9A File Offset: 0x0091A09A
		// (set) Token: 0x0601EBE9 RID: 125929 RVA: 0x0091BEAA File Offset: 0x0091A0AA
		public unsafe bool Portal1Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Portal1Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Portal1Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0601EBEA RID: 125930 RVA: 0x0091BEBB File Offset: 0x0091A0BB
		// (set) Token: 0x0601EBEB RID: 125931 RVA: 0x0091BECB File Offset: 0x0091A0CB
		public unsafe bool Portal2Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Portal2Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Portal2Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0601EBEC RID: 125932 RVA: 0x0091BEDC File Offset: 0x0091A0DC
		// (set) Token: 0x0601EBED RID: 125933 RVA: 0x0091BEF0 File Offset: 0x0091A0F0
		public unsafe UTextureRenderTarget2D RT2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_RT2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_RT2, value);
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0601EBEE RID: 125934 RVA: 0x0091BF05 File Offset: 0x0091A105
		// (set) Token: 0x0601EBEF RID: 125935 RVA: 0x0091BF15 File Offset: 0x0091A115
		public unsafe float AnimShowLen_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimShowLen_Portal1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimShowLen_Portal1) = value;
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0601EBF0 RID: 125936 RVA: 0x0091BF26 File Offset: 0x0091A126
		// (set) Token: 0x0601EBF1 RID: 125937 RVA: 0x0091BF36 File Offset: 0x0091A136
		public unsafe float AnimFadeLen_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimFadeLen_Portal1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimFadeLen_Portal1) = value;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0601EBF2 RID: 125938 RVA: 0x0091BF47 File Offset: 0x0091A147
		// (set) Token: 0x0601EBF3 RID: 125939 RVA: 0x0091BF57 File Offset: 0x0091A157
		public unsafe bool AnimIsShowing_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimIsShowing_Portal1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimIsShowing_Portal1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0601EBF4 RID: 125940 RVA: 0x0091BF68 File Offset: 0x0091A168
		// (set) Token: 0x0601EBF5 RID: 125941 RVA: 0x0091BF7C File Offset: 0x0091A17C
		public unsafe UCurveFloat AnimShowCurve_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimShowCurve_Portal1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimShowCurve_Portal1, value);
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0601EBF6 RID: 125942 RVA: 0x0091BF91 File Offset: 0x0091A191
		// (set) Token: 0x0601EBF7 RID: 125943 RVA: 0x0091BFA5 File Offset: 0x0091A1A5
		public unsafe UCurveFloat AnimFadeCurve_Portal1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimFadeCurve_Portal1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimFadeCurve_Portal1, value);
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0601EBF8 RID: 125944 RVA: 0x0091BFBA File Offset: 0x0091A1BA
		// (set) Token: 0x0601EBF9 RID: 125945 RVA: 0x0091BFCA File Offset: 0x0091A1CA
		public unsafe float AnimCounter_Portal1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimCounter_Portal1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimCounter_Portal1) = value;
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0601EBFA RID: 125946 RVA: 0x0091BFDB File Offset: 0x0091A1DB
		// (set) Token: 0x0601EBFB RID: 125947 RVA: 0x0091BFEB File Offset: 0x0091A1EB
		public unsafe float AnimShowLen_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimShowLen_Portal2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimShowLen_Portal2) = value;
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0601EBFC RID: 125948 RVA: 0x0091BFFC File Offset: 0x0091A1FC
		// (set) Token: 0x0601EBFD RID: 125949 RVA: 0x0091C00C File Offset: 0x0091A20C
		public unsafe float AnimFadeLen_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimFadeLen_Portal2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimFadeLen_Portal2) = value;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0601EBFE RID: 125950 RVA: 0x0091C01D File Offset: 0x0091A21D
		// (set) Token: 0x0601EBFF RID: 125951 RVA: 0x0091C02D File Offset: 0x0091A22D
		public unsafe bool AnimIsShowing_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimIsShowing_Portal2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimIsShowing_Portal2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0601EC00 RID: 125952 RVA: 0x0091C03E File Offset: 0x0091A23E
		// (set) Token: 0x0601EC01 RID: 125953 RVA: 0x0091C052 File Offset: 0x0091A252
		public unsafe UCurveFloat AnimShowCurve_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimShowCurve_Portal2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimShowCurve_Portal2, value);
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0601EC02 RID: 125954 RVA: 0x0091C067 File Offset: 0x0091A267
		// (set) Token: 0x0601EC03 RID: 125955 RVA: 0x0091C07B File Offset: 0x0091A27B
		public unsafe UCurveFloat AnimFadeCurve_Portal2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimFadeCurve_Portal2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_AnimFadeCurve_Portal2, value);
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0601EC04 RID: 125956 RVA: 0x0091C090 File Offset: 0x0091A290
		// (set) Token: 0x0601EC05 RID: 125957 RVA: 0x0091C0A0 File Offset: 0x0091A2A0
		public unsafe float AnimCounter_Portal2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimCounter_Portal2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_AnimCounter_Portal2) = value;
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0601EC06 RID: 125958 RVA: 0x0091C0B1 File Offset: 0x0091A2B1
		// (set) Token: 0x0601EC07 RID: 125959 RVA: 0x0091C0C5 File Offset: 0x0091A2C5
		public unsafe UTextureRenderTarget2D RT1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_RT1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Portal_C.__PropertyOffset_RT1, value);
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0601EC08 RID: 125960 RVA: 0x0091C0DC File Offset: 0x0091A2DC
		// (set) Token: 0x0601EC09 RID: 125961 RVA: 0x0091C115 File Offset: 0x0091A315
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
					result = (this._EffectData_1 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EffectData_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EffectData_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0601EC0A RID: 125962 RVA: 0x0091C138 File Offset: 0x0091A338
		// (set) Token: 0x0601EC0B RID: 125963 RVA: 0x0091C171 File Offset: 0x0091A371
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
					result = (this._EffectData_2 = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EffectData_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EffectData_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0601EC0C RID: 125964 RVA: 0x0091C192 File Offset: 0x0091A392
		// (set) Token: 0x0601EC0D RID: 125965 RVA: 0x0091C1A6 File Offset: 0x0091A3A6
		public unsafe FVector PortalBounds1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalBounds1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalBounds1) = value;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0601EC0E RID: 125966 RVA: 0x0091C1BB File Offset: 0x0091A3BB
		// (set) Token: 0x0601EC0F RID: 125967 RVA: 0x0091C1CB File Offset: 0x0091A3CB
		public unsafe bool EnableDebugCamera1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCamera1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCamera1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0601EC10 RID: 125968 RVA: 0x0091C1DC File Offset: 0x0091A3DC
		// (set) Token: 0x0601EC11 RID: 125969 RVA: 0x0091C1EC File Offset: 0x0091A3EC
		public unsafe bool EnableDebugCamera2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCamera2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCamera2) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0601EC12 RID: 125970 RVA: 0x0091C1FD File Offset: 0x0091A3FD
		// (set) Token: 0x0601EC13 RID: 125971 RVA: 0x0091C211 File Offset: 0x0091A411
		public unsafe FVector PortalBounds2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalBounds2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PortalBounds2) = value;
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0601EC14 RID: 125972 RVA: 0x0091C228 File Offset: 0x0091A428
		// (set) Token: 0x0601EC15 RID: 125973 RVA: 0x0091C261 File Offset: 0x0091A461
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
					result = (this._CaptureConfig_Mobile_VeryLow = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_VeryLow, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_VeryLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0601EC16 RID: 125974 RVA: 0x0091C284 File Offset: 0x0091A484
		// (set) Token: 0x0601EC17 RID: 125975 RVA: 0x0091C2BD File Offset: 0x0091A4BD
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
					result = (this._CaptureConfig_Mobile_Low = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_Low, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_Low, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0601EC18 RID: 125976 RVA: 0x0091C2E0 File Offset: 0x0091A4E0
		// (set) Token: 0x0601EC19 RID: 125977 RVA: 0x0091C319 File Offset: 0x0091A519
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
					result = (this._CaptureConfig_Mobile_Mid = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_Mid, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_Mid, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0601EC1A RID: 125978 RVA: 0x0091C33C File Offset: 0x0091A53C
		// (set) Token: 0x0601EC1B RID: 125979 RVA: 0x0091C375 File Offset: 0x0091A575
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
					result = (this._CaptureConfig_Mobile_High = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_High, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Mobile_High, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0601EC1C RID: 125980 RVA: 0x0091C398 File Offset: 0x0091A598
		// (set) Token: 0x0601EC1D RID: 125981 RVA: 0x0091C3D1 File Offset: 0x0091A5D1
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
					result = (this._CaptureConfig_Pc_VeryLow = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_VeryLow, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_VeryLow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0601EC1E RID: 125982 RVA: 0x0091C3F4 File Offset: 0x0091A5F4
		// (set) Token: 0x0601EC1F RID: 125983 RVA: 0x0091C42D File Offset: 0x0091A62D
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
					result = (this._CaptureConfig_Pc_Low = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_Low, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_Low, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0601EC20 RID: 125984 RVA: 0x0091C450 File Offset: 0x0091A650
		// (set) Token: 0x0601EC21 RID: 125985 RVA: 0x0091C489 File Offset: 0x0091A689
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
					result = (this._CaptureConfig_Pc_Mid = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_Mid, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_Mid, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0601EC22 RID: 125986 RVA: 0x0091C4AC File Offset: 0x0091A6AC
		// (set) Token: 0x0601EC23 RID: 125987 RVA: 0x0091C4E5 File Offset: 0x0091A6E5
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
					result = (this._CaptureConfig_Pc_High = new FSceneCaptureComponent2DParams(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_High, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSceneCaptureComponent2DParams.StaticStruct(), base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureConfig_Pc_High, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0601EC24 RID: 125988 RVA: 0x0091C506 File Offset: 0x0091A706
		// (set) Token: 0x0601EC25 RID: 125989 RVA: 0x0091C516 File Offset: 0x0091A716
		public unsafe bool IsMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_IsMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_IsMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0601EC26 RID: 125990 RVA: 0x0091C527 File Offset: 0x0091A727
		// (set) Token: 0x0601EC27 RID: 125991 RVA: 0x0091C537 File Offset: 0x0091A737
		public unsafe int PerformanceLevel_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PerformanceLevel_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PerformanceLevel_A) = value;
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0601EC28 RID: 125992 RVA: 0x0091C548 File Offset: 0x0091A748
		// (set) Token: 0x0601EC29 RID: 125993 RVA: 0x0091C558 File Offset: 0x0091A758
		public unsafe int PerformanceLevel_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PerformanceLevel_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_PerformanceLevel_B) = value;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0601EC2A RID: 125994 RVA: 0x0091C569 File Offset: 0x0091A769
		// (set) Token: 0x0601EC2B RID: 125995 RVA: 0x0091C579 File Offset: 0x0091A779
		public unsafe float CaptureMaxViewDistance_A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureMaxViewDistance_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureMaxViewDistance_A) = value;
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0601EC2C RID: 125996 RVA: 0x0091C58A File Offset: 0x0091A78A
		// (set) Token: 0x0601EC2D RID: 125997 RVA: 0x0091C59A File Offset: 0x0091A79A
		public unsafe float CaptureMaxViewDistance_B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureMaxViewDistance_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CaptureMaxViewDistance_B) = value;
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0601EC2E RID: 125998 RVA: 0x0091C5AB File Offset: 0x0091A7AB
		// (set) Token: 0x0601EC2F RID: 125999 RVA: 0x0091C5BB File Offset: 0x0091A7BB
		public unsafe bool EnableDebugCapture1Params
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCapture1Params) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCapture1Params) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0601EC30 RID: 126000 RVA: 0x0091C5CC File Offset: 0x0091A7CC
		// (set) Token: 0x0601EC31 RID: 126001 RVA: 0x0091C5DC File Offset: 0x0091A7DC
		public unsafe bool EnableDebugCapture2Params
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCapture2Params) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_EnableDebugCapture2Params) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0601EC32 RID: 126002 RVA: 0x0091C5ED File Offset: 0x0091A7ED
		// (set) Token: 0x0601EC33 RID: 126003 RVA: 0x0091C5FD File Offset: 0x0091A7FD
		public unsafe float CapturePerf_Lv0_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv0_MaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv0_MaxDist) = value;
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0601EC34 RID: 126004 RVA: 0x0091C60E File Offset: 0x0091A80E
		// (set) Token: 0x0601EC35 RID: 126005 RVA: 0x0091C61E File Offset: 0x0091A81E
		public unsafe float CapturePerf_Lv1_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv1_MaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv1_MaxDist) = value;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0601EC36 RID: 126006 RVA: 0x0091C62F File Offset: 0x0091A82F
		// (set) Token: 0x0601EC37 RID: 126007 RVA: 0x0091C63F File Offset: 0x0091A83F
		public unsafe float CapturePerf_Lv2_MaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv2_MaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_CapturePerf_Lv2_MaxDist) = value;
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0601EC38 RID: 126008 RVA: 0x0091C650 File Offset: 0x0091A850
		// (set) Token: 0x0601EC39 RID: 126009 RVA: 0x0091C689 File Offset: 0x0091A889
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
					result = (this._Capture1InitShowFlags = new TMap<string, bool>(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Capture1InitShowFlags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Capture1InitShowFlags.CopyAssign(value);
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0601EC3A RID: 126010 RVA: 0x0091C698 File Offset: 0x0091A898
		// (set) Token: 0x0601EC3B RID: 126011 RVA: 0x0091C6D1 File Offset: 0x0091A8D1
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
					result = (this._Capture2InitShowFlags = new TMap<string, bool>(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_Capture2InitShowFlags, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Capture2InitShowFlags.CopyAssign(value);
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0601EC3C RID: 126012 RVA: 0x0091C6DF File Offset: 0x0091A8DF
		// (set) Token: 0x0601EC3D RID: 126013 RVA: 0x0091C6EF File Offset: 0x0091A8EF
		public unsafe bool IsMac
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_IsMac) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Portal_C.__PropertyOffset_IsMac) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EC3E RID: 126014 RVA: 0x0091C700 File Offset: 0x0091A900
		[SkipLocalsInit]
		public unsafe virtual void DrawDebugPortalBounds(bool IsPortal1)
		{
			BP_Portal_C.__DrawDebugPortalBounds_FunctionParams* ptr = stackalloc BP_Portal_C.__DrawDebugPortalBounds_FunctionParams[(UIntPtr)351] + 15L / (long)sizeof(BP_Portal_C.__DrawDebugPortalBounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__DrawDebugPortalBounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsPortal1 = IsPortal1;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DrawDebugPortalBounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC3F RID: 126015 RVA: 0x0091C74C File Offset: 0x0091A94C
		[SkipLocalsInit]
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

		// Token: 0x0601EC40 RID: 126016 RVA: 0x0091C7B8 File Offset: 0x0091A9B8
		[SkipLocalsInit]
		public unsafe virtual void CheckCapturePerformanceLevel(bool isPortalA, FTransformDouble targetTrans)
		{
			BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams* ptr = stackalloc BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams[(UIntPtr)303] + 15L / (long)sizeof(BP_Portal_C.__CheckCapturePerformanceLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__CheckCapturePerformanceLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPortalA = isPortalA;
			ptr->targetTrans = targetTrans;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__CheckCapturePerformanceLevel_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC41 RID: 126017 RVA: 0x0091C808 File Offset: 0x0091AA08
		[SkipLocalsInit]
		public unsafe virtual void ApplyCapturePerformace(bool IsPortalA, int ConfigLevel, float CaptureMaxViewDistance)
		{
			BP_Portal_C.__ApplyCapturePerformace_FunctionParams* ptr = stackalloc BP_Portal_C.__ApplyCapturePerformace_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Portal_C.__ApplyCapturePerformace_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ApplyCapturePerformace_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsPortalA = IsPortalA;
			ptr->ConfigLevel = ConfigLevel;
			ptr->CaptureMaxViewDistance = CaptureMaxViewDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ApplyCapturePerformace_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC42 RID: 126018 RVA: 0x0091C85C File Offset: 0x0091AA5C
		[SkipLocalsInit]
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

		// Token: 0x0601EC43 RID: 126019 RVA: 0x0091C8BC File Offset: 0x0091AABC
		[SkipLocalsInit]
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

		// Token: 0x0601EC44 RID: 126020 RVA: 0x0091C91C File Offset: 0x0091AB1C
		[SkipLocalsInit]
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

		// Token: 0x0601EC45 RID: 126021 RVA: 0x0091C984 File Offset: 0x0091AB84
		[SkipLocalsInit]
		public virtual void UpdatePortalsCameraPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__UpdatePortalsCameraPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC46 RID: 126022 RVA: 0x0091C998 File Offset: 0x0091AB98
		[SkipLocalsInit]
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

		// Token: 0x0601EC47 RID: 126023 RVA: 0x0091CA78 File Offset: 0x0091AC78
		[SkipLocalsInit]
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

		// Token: 0x0601EC48 RID: 126024 RVA: 0x0091CAEC File Offset: 0x0091ACEC
		[SkipLocalsInit]
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

		// Token: 0x0601EC49 RID: 126025 RVA: 0x0091CB70 File Offset: 0x0091AD70
		[SkipLocalsInit]
		public unsafe virtual void SetCaptureMaxViewDistance(bool IsCapture1, float MaxViewDistance)
		{
			BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams* ptr = stackalloc BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Portal_C.__SetCaptureMaxViewDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetCaptureMaxViewDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsCapture1 = IsCapture1;
			ptr->MaxViewDistance = MaxViewDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetCaptureMaxViewDistance_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC4A RID: 126026 RVA: 0x0091CBC0 File Offset: 0x0091ADC0
		[SkipLocalsInit]
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

		// Token: 0x0601EC4B RID: 126027 RVA: 0x0091CC67 File Offset: 0x0091AE67
		[SkipLocalsInit]
		public virtual void DEBUG_关闭2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_关闭2_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC4C RID: 126028 RVA: 0x0091CC7B File Offset: 0x0091AE7B
		[SkipLocalsInit]
		public virtual void DEBUG_关闭1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_关闭1_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC4D RID: 126029 RVA: 0x0091CC8F File Offset: 0x0091AE8F
		[SkipLocalsInit]
		public virtual void DEBUG_开启2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_开启2_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC4E RID: 126030 RVA: 0x0091CCA3 File Offset: 0x0091AEA3
		[SkipLocalsInit]
		public virtual void DisablePortal2Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DisablePortal2Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC4F RID: 126031 RVA: 0x0091CCB7 File Offset: 0x0091AEB7
		[SkipLocalsInit]
		public virtual void EnablePortal2Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__EnablePortal2Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC50 RID: 126032 RVA: 0x0091CCCB File Offset: 0x0091AECB
		[SkipLocalsInit]
		public virtual void DisablePortal1Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DisablePortal1Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC51 RID: 126033 RVA: 0x0091CCDF File Offset: 0x0091AEDF
		[SkipLocalsInit]
		public virtual void EnablePortal1Rendering()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__EnablePortal1Rendering_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC52 RID: 126034 RVA: 0x0091CCF4 File Offset: 0x0091AEF4
		[SkipLocalsInit]
		public unsafe virtual void SetPortal2Transform(FTransformDouble Transform, FTransformDouble CaptureTransform)
		{
			BP_Portal_C.__SetPortal2Transform_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal2Transform_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_Portal_C.__SetPortal2Transform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal2Transform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Transform = Transform;
			ptr->CaptureTransform = CaptureTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal2Transform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC53 RID: 126035 RVA: 0x0091CD44 File Offset: 0x0091AF44
		[SkipLocalsInit]
		public unsafe virtual void SetPortal1Transform(FTransformDouble Transform, FTransformDouble CaptureTransform)
		{
			BP_Portal_C.__SetPortal1Transform_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal1Transform_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_Portal_C.__SetPortal1Transform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal1Transform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Transform = Transform;
			ptr->CaptureTransform = CaptureTransform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal1Transform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC54 RID: 126036 RVA: 0x0091CD94 File Offset: 0x0091AF94
		[SkipLocalsInit]
		public unsafe virtual void SetPortal2Bounds(FVector Bounds)
		{
			BP_Portal_C.__SetPortal2Bounds_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal2Bounds_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_Portal_C.__SetPortal2Bounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal2Bounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Bounds = Bounds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal2Bounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC55 RID: 126037 RVA: 0x0091CDDC File Offset: 0x0091AFDC
		[SkipLocalsInit]
		public unsafe virtual void SetPortal1Bounds(FVector Bounds)
		{
			BP_Portal_C.__SetPortal1Bounds_FunctionParams* ptr = stackalloc BP_Portal_C.__SetPortal1Bounds_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(BP_Portal_C.__SetPortal1Bounds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__SetPortal1Bounds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Bounds = Bounds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__SetPortal1Bounds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC56 RID: 126038 RVA: 0x0091CE22 File Offset: 0x0091B022
		[SkipLocalsInit]
		public virtual void DEBUG_开启1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__DEBUG_开启1_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC57 RID: 126039 RVA: 0x0091CE36 File Offset: 0x0091B036
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC58 RID: 126040 RVA: 0x0091CE4A File Offset: 0x0091B04A
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC59 RID: 126041 RVA: 0x0091CE60 File Offset: 0x0091B060
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Portal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Portal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Portal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC5A RID: 126042 RVA: 0x0091CEA8 File Offset: 0x0091B0A8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Portal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Portal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Portal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EC5B RID: 126043 RVA: 0x0091CEEE File Offset: 0x0091B0EE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Portal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC5C RID: 126044 RVA: 0x0091CF02 File Offset: 0x0091B102
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Portal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601EC5D RID: 126045 RVA: 0x0091CF16 File Offset: 0x0091B116
		protected BP_Portal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401051B RID: 66843
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Portal/BP_Portal.BP_Portal_C";

		// Token: 0x0401051C RID: 66844
		private static IntPtr _ClassPtr;

		// Token: 0x0401051D RID: 66845
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401051E RID: 66846
		internal static int __PropertyOffset_CapturePosition1;

		// Token: 0x0401051F RID: 66847
		internal static int __PropertyOffset_CapturePosition2;

		// Token: 0x04010520 RID: 66848
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010521 RID: 66849
		internal static int __PropertyOffset_PortalWorldTransform1;

		// Token: 0x04010522 RID: 66850
		internal static int __PropertyOffset_PortalWorldTransform2;

		// Token: 0x04010523 RID: 66851
		internal static int __PropertyOffset_DMI_Portal1;

		// Token: 0x04010524 RID: 66852
		internal static int __PropertyOffset_DMI_Portal2;

		// Token: 0x04010525 RID: 66853
		internal static int __PropertyOffset_PortalColor1;

		// Token: 0x04010526 RID: 66854
		internal static int __PropertyOffset_PortalColor2;

		// Token: 0x04010527 RID: 66855
		internal static int __PropertyOffset_DebugActor1;

		// Token: 0x04010528 RID: 66856
		internal static int __PropertyOffset_DebugActor2;

		// Token: 0x04010529 RID: 66857
		internal static int __PropertyOffset_Portal1Enable;

		// Token: 0x0401052A RID: 66858
		internal static int __PropertyOffset_Portal2Enable;

		// Token: 0x0401052B RID: 66859
		internal static int __PropertyOffset_RT2;

		// Token: 0x0401052C RID: 66860
		internal static int __PropertyOffset_AnimShowLen_Portal1;

		// Token: 0x0401052D RID: 66861
		internal static int __PropertyOffset_AnimFadeLen_Portal1;

		// Token: 0x0401052E RID: 66862
		internal static int __PropertyOffset_AnimIsShowing_Portal1;

		// Token: 0x0401052F RID: 66863
		internal static int __PropertyOffset_AnimShowCurve_Portal1;

		// Token: 0x04010530 RID: 66864
		internal static int __PropertyOffset_AnimFadeCurve_Portal1;

		// Token: 0x04010531 RID: 66865
		internal static int __PropertyOffset_AnimCounter_Portal1;

		// Token: 0x04010532 RID: 66866
		internal static int __PropertyOffset_AnimShowLen_Portal2;

		// Token: 0x04010533 RID: 66867
		internal static int __PropertyOffset_AnimFadeLen_Portal2;

		// Token: 0x04010534 RID: 66868
		internal static int __PropertyOffset_AnimIsShowing_Portal2;

		// Token: 0x04010535 RID: 66869
		internal static int __PropertyOffset_AnimShowCurve_Portal2;

		// Token: 0x04010536 RID: 66870
		internal static int __PropertyOffset_AnimFadeCurve_Portal2;

		// Token: 0x04010537 RID: 66871
		internal static int __PropertyOffset_AnimCounter_Portal2;

		// Token: 0x04010538 RID: 66872
		internal static int __PropertyOffset_RT1;

		// Token: 0x04010539 RID: 66873
		internal static int __PropertyOffset_EffectData_1;

		// Token: 0x0401053A RID: 66874
		private FSoftObjectPath _EffectData_1;

		// Token: 0x0401053B RID: 66875
		internal static int __PropertyOffset_EffectData_2;

		// Token: 0x0401053C RID: 66876
		private FSoftObjectPath _EffectData_2;

		// Token: 0x0401053D RID: 66877
		internal static int __PropertyOffset_PortalBounds1;

		// Token: 0x0401053E RID: 66878
		internal static int __PropertyOffset_EnableDebugCamera1;

		// Token: 0x0401053F RID: 66879
		internal static int __PropertyOffset_EnableDebugCamera2;

		// Token: 0x04010540 RID: 66880
		internal static int __PropertyOffset_PortalBounds2;

		// Token: 0x04010541 RID: 66881
		internal static int __PropertyOffset_CaptureConfig_Mobile_VeryLow;

		// Token: 0x04010542 RID: 66882
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_VeryLow;

		// Token: 0x04010543 RID: 66883
		internal static int __PropertyOffset_CaptureConfig_Mobile_Low;

		// Token: 0x04010544 RID: 66884
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_Low;

		// Token: 0x04010545 RID: 66885
		internal static int __PropertyOffset_CaptureConfig_Mobile_Mid;

		// Token: 0x04010546 RID: 66886
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_Mid;

		// Token: 0x04010547 RID: 66887
		internal static int __PropertyOffset_CaptureConfig_Mobile_High;

		// Token: 0x04010548 RID: 66888
		private FSceneCaptureComponent2DParams _CaptureConfig_Mobile_High;

		// Token: 0x04010549 RID: 66889
		internal static int __PropertyOffset_CaptureConfig_Pc_VeryLow;

		// Token: 0x0401054A RID: 66890
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_VeryLow;

		// Token: 0x0401054B RID: 66891
		internal static int __PropertyOffset_CaptureConfig_Pc_Low;

		// Token: 0x0401054C RID: 66892
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_Low;

		// Token: 0x0401054D RID: 66893
		internal static int __PropertyOffset_CaptureConfig_Pc_Mid;

		// Token: 0x0401054E RID: 66894
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_Mid;

		// Token: 0x0401054F RID: 66895
		internal static int __PropertyOffset_CaptureConfig_Pc_High;

		// Token: 0x04010550 RID: 66896
		private FSceneCaptureComponent2DParams _CaptureConfig_Pc_High;

		// Token: 0x04010551 RID: 66897
		internal static int __PropertyOffset_IsMobile;

		// Token: 0x04010552 RID: 66898
		internal static int __PropertyOffset_PerformanceLevel_A;

		// Token: 0x04010553 RID: 66899
		internal static int __PropertyOffset_PerformanceLevel_B;

		// Token: 0x04010554 RID: 66900
		internal static int __PropertyOffset_CaptureMaxViewDistance_A;

		// Token: 0x04010555 RID: 66901
		internal static int __PropertyOffset_CaptureMaxViewDistance_B;

		// Token: 0x04010556 RID: 66902
		internal static int __PropertyOffset_EnableDebugCapture1Params;

		// Token: 0x04010557 RID: 66903
		internal static int __PropertyOffset_EnableDebugCapture2Params;

		// Token: 0x04010558 RID: 66904
		internal static int __PropertyOffset_CapturePerf_Lv0_MaxDist;

		// Token: 0x04010559 RID: 66905
		internal static int __PropertyOffset_CapturePerf_Lv1_MaxDist;

		// Token: 0x0401055A RID: 66906
		internal static int __PropertyOffset_CapturePerf_Lv2_MaxDist;

		// Token: 0x0401055B RID: 66907
		internal static int __PropertyOffset_Capture1InitShowFlags;

		// Token: 0x0401055C RID: 66908
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _Capture1InitShowFlags;

		// Token: 0x0401055D RID: 66909
		internal static int __PropertyOffset_Capture2InitShowFlags;

		// Token: 0x0401055E RID: 66910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, bool> _Capture2InitShowFlags;

		// Token: 0x0401055F RID: 66911
		internal static int __PropertyOffset_IsMac;

		// Token: 0x04010560 RID: 66912
		private static IntPtr __DrawDebugPortalBounds_NativeFunctionPtr;

		// Token: 0x04010561 RID: 66913
		private static IntPtr __PrintDebugCaptureParams_NativeFunctionPtr;

		// Token: 0x04010562 RID: 66914
		private static IntPtr __CheckCapturePerformanceLevel_NativeFunctionPtr;

		// Token: 0x04010563 RID: 66915
		private static IntPtr __ApplyCapturePerformace_NativeFunctionPtr;

		// Token: 0x04010564 RID: 66916
		private static IntPtr __GetAngleBetweenVector_NativeFunctionPtr;

		// Token: 0x04010565 RID: 66917
		private static IntPtr __DrawDebugFrustum_NativeFunctionPtr;

		// Token: 0x04010566 RID: 66918
		private static IntPtr __GetMappingTransformToOtherPortal_NativeFunctionPtr;

		// Token: 0x04010567 RID: 66919
		private static IntPtr __UpdatePortalsCameraPosition_NativeFunctionPtr;

		// Token: 0x04010568 RID: 66920
		private static IntPtr __UpdatePortalAnimation_NativeFunctionPtr;

		// Token: 0x04010569 RID: 66921
		private static IntPtr __SetCaptureShowFlags_NativeFunctionPtr;

		// Token: 0x0401056A RID: 66922
		private static IntPtr __GetCaptureShowFlags_NativeFunctionPtr;

		// Token: 0x0401056B RID: 66923
		private static IntPtr __SetCaptureMaxViewDistance_NativeFunctionPtr;

		// Token: 0x0401056C RID: 66924
		private static IntPtr __SetCaptureShowingActors_NativeFunctionPtr;

		// Token: 0x0401056D RID: 66925
		private static IntPtr __DEBUG_关闭2_NativeFunctionPtr;

		// Token: 0x0401056E RID: 66926
		private static IntPtr __DEBUG_关闭1_NativeFunctionPtr;

		// Token: 0x0401056F RID: 66927
		private static IntPtr __DEBUG_开启2_NativeFunctionPtr;

		// Token: 0x04010570 RID: 66928
		private static IntPtr __DisablePortal2Rendering_NativeFunctionPtr;

		// Token: 0x04010571 RID: 66929
		private static IntPtr __EnablePortal2Rendering_NativeFunctionPtr;

		// Token: 0x04010572 RID: 66930
		private static IntPtr __DisablePortal1Rendering_NativeFunctionPtr;

		// Token: 0x04010573 RID: 66931
		private static IntPtr __EnablePortal1Rendering_NativeFunctionPtr;

		// Token: 0x04010574 RID: 66932
		private static IntPtr __SetPortal2Transform_NativeFunctionPtr;

		// Token: 0x04010575 RID: 66933
		private static IntPtr __SetPortal1Transform_NativeFunctionPtr;

		// Token: 0x04010576 RID: 66934
		private static IntPtr __SetPortal2Bounds_NativeFunctionPtr;

		// Token: 0x04010577 RID: 66935
		private static IntPtr __SetPortal1Bounds_NativeFunctionPtr;

		// Token: 0x04010578 RID: 66936
		private static IntPtr __DEBUG_开启1_NativeFunctionPtr;

		// Token: 0x04010579 RID: 66937
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401057A RID: 66938
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401057B RID: 66939
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008EC5 RID: 36549
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 336)]
		protected ref struct __DrawDebugPortalBounds_FunctionParams
		{
			// Token: 0x0402CB64 RID: 183140
			[FieldOffset(0)]
			public bool IsPortal1;
		}

		// Token: 0x02008EC6 RID: 36550
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 800)]
		protected ref struct __PrintDebugCaptureParams_FunctionParams
		{
			// Token: 0x0402CB65 RID: 183141
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x0402CB66 RID: 183142
			[FieldOffset(4)]
			public byte CaptureParam;
		}

		// Token: 0x02008EC7 RID: 36551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 288)]
		protected ref struct __CheckCapturePerformanceLevel_FunctionParams
		{
			// Token: 0x0402CB67 RID: 183143
			[FieldOffset(0)]
			public bool isPortalA;

			// Token: 0x0402CB68 RID: 183144
			[FieldOffset(16)]
			public FTransformDouble targetTrans;
		}

		// Token: 0x02008EC8 RID: 36552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ApplyCapturePerformace_FunctionParams
		{
			// Token: 0x0402CB69 RID: 183145
			[FieldOffset(0)]
			public bool IsPortalA;

			// Token: 0x0402CB6A RID: 183146
			[FieldOffset(4)]
			public int ConfigLevel;

			// Token: 0x0402CB6B RID: 183147
			[FieldOffset(8)]
			public float CaptureMaxViewDistance;
		}

		// Token: 0x02008EC9 RID: 36553
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetAngleBetweenVector_FunctionParams
		{
			// Token: 0x0402CB6C RID: 183148
			[FieldOffset(0)]
			public FVector Vector1;

			// Token: 0x0402CB6D RID: 183149
			[FieldOffset(12)]
			public FVector Vector2;

			// Token: 0x0402CB6E RID: 183150
			[FieldOffset(24)]
			public float Angle;
		}

		// Token: 0x02008ECA RID: 36554
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 416)]
		protected ref struct __DrawDebugFrustum_FunctionParams
		{
			// Token: 0x0402CB6F RID: 183151
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x0402CB70 RID: 183152
			[FieldOffset(64)]
			public float FovX;

			// Token: 0x0402CB71 RID: 183153
			[FieldOffset(68)]
			public float NearClipPlane;

			// Token: 0x0402CB72 RID: 183154
			[FieldOffset(72)]
			public float AspectRatio;
		}

		// Token: 0x02008ECB RID: 36555
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 592)]
		protected ref struct __GetMappingTransformToOtherPortal_FunctionParams
		{
			// Token: 0x0402CB73 RID: 183155
			[FieldOffset(0)]
			public FTransformDouble SourceTransform;

			// Token: 0x0402CB74 RID: 183156
			[FieldOffset(64)]
			public bool bA2B;

			// Token: 0x0402CB75 RID: 183157
			[FieldOffset(80)]
			public FTransformDouble TargetTransform;
		}

		// Token: 0x02008ECC RID: 36556
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __UpdatePortalAnimation_FunctionParams
		{
			// Token: 0x0402CB76 RID: 183158
			[FieldOffset(0)]
			public float ShowLen;

			// Token: 0x0402CB77 RID: 183159
			[FieldOffset(4)]
			public float FadeLen;

			// Token: 0x0402CB78 RID: 183160
			[FieldOffset(8)]
			public bool IsShown;

			// Token: 0x0402CB79 RID: 183161
			[FieldOffset(16)]
			public IntPtr ShowCurve;

			// Token: 0x0402CB7A RID: 183162
			[FieldOffset(24)]
			public IntPtr FadeCurve;

			// Token: 0x0402CB7B RID: 183163
			[FieldOffset(32)]
			public float Counter;

			// Token: 0x0402CB7C RID: 183164
			[FieldOffset(40)]
			public IntPtr SM;

			// Token: 0x0402CB7D RID: 183165
			[FieldOffset(48)]
			public IntPtr DMI;

			// Token: 0x0402CB7E RID: 183166
			[FieldOffset(56)]
			public float OutputCounter;

			// Token: 0x0402CB7F RID: 183167
			[FieldOffset(60)]
			public float Factor;
		}

		// Token: 0x02008ECD RID: 36557
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __SetCaptureShowFlags_FunctionParams
		{
			// Token: 0x0402CB80 RID: 183168
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x0402CB81 RID: 183169
			[FieldOffset(8)]
			public byte ShowFlags;
		}

		// Token: 0x02008ECE RID: 36558
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetCaptureShowFlags_FunctionParams
		{
			// Token: 0x0402CB82 RID: 183170
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x0402CB83 RID: 183171
			[FieldOffset(8)]
			public byte ShowFlags;
		}

		// Token: 0x02008ECF RID: 36559
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCaptureMaxViewDistance_FunctionParams
		{
			// Token: 0x0402CB84 RID: 183172
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x0402CB85 RID: 183173
			[FieldOffset(4)]
			public float MaxViewDistance;
		}

		// Token: 0x02008ED0 RID: 36560
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetCaptureShowingActors_FunctionParams
		{
			// Token: 0x0402CB86 RID: 183174
			[FieldOffset(0)]
			public bool IsCapture1;

			// Token: 0x0402CB87 RID: 183175
			[FieldOffset(8)]
			public byte HiddenActors;

			// Token: 0x0402CB88 RID: 183176
			[FieldOffset(24)]
			public byte ForceShowActors;
		}

		// Token: 0x02008ED1 RID: 36561
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetPortal2Transform_FunctionParams
		{
			// Token: 0x0402CB89 RID: 183177
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x0402CB8A RID: 183178
			[FieldOffset(64)]
			public FTransformDouble CaptureTransform;
		}

		// Token: 0x02008ED2 RID: 36562
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SetPortal1Transform_FunctionParams
		{
			// Token: 0x0402CB8B RID: 183179
			[FieldOffset(0)]
			public FTransformDouble Transform;

			// Token: 0x0402CB8C RID: 183180
			[FieldOffset(64)]
			public FTransformDouble CaptureTransform;
		}

		// Token: 0x02008ED3 RID: 36563
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __SetPortal2Bounds_FunctionParams
		{
			// Token: 0x0402CB8D RID: 183181
			[FieldOffset(0)]
			public FVector Bounds;
		}

		// Token: 0x02008ED4 RID: 36564
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __SetPortal1Bounds_FunctionParams
		{
			// Token: 0x0402CB8E RID: 183182
			[FieldOffset(0)]
			public FVector Bounds;
		}

		// Token: 0x02008ED5 RID: 36565
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB8F RID: 183183
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
