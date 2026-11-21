using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.UI.UISceneView;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.PianoGameplay
{
	// Token: 0x020031E3 RID: 12771
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/PianoGameplay/BP_PianoGameplaySetting.BP_PianoGameplaySetting_C")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 268)]
	public class BP_PianoGameplaySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBD1 RID: 130001 RVA: 0x0093486D File Offset: 0x00932A6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PianoGameplaySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/PianoGameplay/BP_PianoGameplaySetting.BP_PianoGameplaySetting_C");
			}
			return BP_PianoGameplaySetting_C._ClassPtr;
		}

		// Token: 0x0601FBD2 RID: 130002 RVA: 0x00934894 File Offset: 0x00932A94
		public BP_PianoGameplaySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_PianoGameplaySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBD3 RID: 130003 RVA: 0x009348BC File Offset: 0x00932ABC
		public BP_PianoGameplaySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PianoGameplaySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0601FBD4 RID: 130004 RVA: 0x009348EF File Offset: 0x00932AEF
		// (set) Token: 0x0601FBD5 RID: 130005 RVA: 0x00934904 File Offset: 0x00932B04
		public TSoftClassPtr<BP_UISceneView_C> SplitScreenView
		{
			get
			{
				return new TSoftClassPtr<BP_UISceneView_C>(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_SplitScreenView, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_SplitScreenView, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0601FBD6 RID: 130006 RVA: 0x00934929 File Offset: 0x00932B29
		// (set) Token: 0x0601FBD7 RID: 130007 RVA: 0x0093493E File Offset: 0x00932B3E
		public TSoftObjectPtr<UMaterial> SplitScreenUIMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterial>(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_SplitScreenUIMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_SplitScreenUIMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0601FBD8 RID: 130008 RVA: 0x00934963 File Offset: 0x00932B63
		// (set) Token: 0x0601FBD9 RID: 130009 RVA: 0x00934977 File Offset: 0x00932B77
		public unsafe FVectorDouble CaptureOffsetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_CaptureOffsetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_CaptureOffsetLocation) = value;
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0601FBDA RID: 130010 RVA: 0x0093498C File Offset: 0x00932B8C
		// (set) Token: 0x0601FBDB RID: 130011 RVA: 0x009349A0 File Offset: 0x00932BA0
		public unsafe FRotator CaptureOffsetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_CaptureOffsetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_CaptureOffsetRotation) = value;
			}
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0601FBDC RID: 130012 RVA: 0x009349B5 File Offset: 0x00932BB5
		// (set) Token: 0x0601FBDD RID: 130013 RVA: 0x009349C5 File Offset: 0x00932BC5
		public unsafe float FlowMaskCenterOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskCenterOffsetX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskCenterOffsetX) = value;
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0601FBDE RID: 130014 RVA: 0x009349D6 File Offset: 0x00932BD6
		// (set) Token: 0x0601FBDF RID: 130015 RVA: 0x009349E6 File Offset: 0x00932BE6
		public unsafe float FlowMaskCenterOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskCenterOffsetY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskCenterOffsetY) = value;
			}
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0601FBE0 RID: 130016 RVA: 0x009349F7 File Offset: 0x00932BF7
		// (set) Token: 0x0601FBE1 RID: 130017 RVA: 0x00934A07 File Offset: 0x00932C07
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_Fov) = value;
			}
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0601FBE2 RID: 130018 RVA: 0x00934A18 File Offset: 0x00932C18
		// (set) Token: 0x0601FBE3 RID: 130019 RVA: 0x00934A28 File Offset: 0x00932C28
		public unsafe float KeyDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_KeyDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_KeyDelay) = value;
			}
		}

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0601FBE4 RID: 130020 RVA: 0x00934A39 File Offset: 0x00932C39
		// (set) Token: 0x0601FBE5 RID: 130021 RVA: 0x00934A49 File Offset: 0x00932C49
		public unsafe float AutoPlayDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_AutoPlayDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_AutoPlayDelay) = value;
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0601FBE6 RID: 130022 RVA: 0x00934A5A File Offset: 0x00932C5A
		// (set) Token: 0x0601FBE7 RID: 130023 RVA: 0x00934A6A File Offset: 0x00932C6A
		public unsafe float JudgeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_JudgeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_JudgeTime) = value;
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0601FBE8 RID: 130024 RVA: 0x00934A7B File Offset: 0x00932C7B
		// (set) Token: 0x0601FBE9 RID: 130025 RVA: 0x00934A8F File Offset: 0x00932C8F
		[Nullable(2)]
		public unsafe UCurveFloat FlowMaskAlphaPositionCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskAlphaPositionCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoGameplaySetting_C.__PropertyOffset_FlowMaskAlphaPositionCurve, value);
			}
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0601FBEA RID: 130026 RVA: 0x00934AA4 File Offset: 0x00932CA4
		// (set) Token: 0x0601FBEB RID: 130027 RVA: 0x00934AB4 File Offset: 0x00932CB4
		public unsafe bool EnableFlowMaskRealtimeTuning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_EnableFlowMaskRealtimeTuning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_EnableFlowMaskRealtimeTuning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0601FBEC RID: 130028 RVA: 0x00934AC5 File Offset: 0x00932CC5
		// (set) Token: 0x0601FBED RID: 130029 RVA: 0x00934AD5 File Offset: 0x00932CD5
		public unsafe float MusicFadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicFadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicFadeOutTime) = value;
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0601FBEE RID: 130030 RVA: 0x00934AE6 File Offset: 0x00932CE6
		// (set) Token: 0x0601FBEF RID: 130031 RVA: 0x00934AF6 File Offset: 0x00932CF6
		public unsafe float MusicStartRecoverTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicStartRecoverTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicStartRecoverTime) = value;
			}
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0601FBF0 RID: 130032 RVA: 0x00934B07 File Offset: 0x00932D07
		// (set) Token: 0x0601FBF1 RID: 130033 RVA: 0x00934B17 File Offset: 0x00932D17
		public unsafe float MusicRecoverTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicRecoverTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_MusicRecoverTime) = value;
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0601FBF2 RID: 130034 RVA: 0x00934B28 File Offset: 0x00932D28
		// (set) Token: 0x0601FBF3 RID: 130035 RVA: 0x00934B38 File Offset: 0x00932D38
		public unsafe int HelpID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_HelpID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoGameplaySetting_C.__PropertyOffset_HelpID) = value;
			}
		}

		// Token: 0x0601FBF4 RID: 130036 RVA: 0x00934B49 File Offset: 0x00932D49
		protected BP_PianoGameplaySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401107B RID: 69755
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/PianoGameplay/BP_PianoGameplaySetting.BP_PianoGameplaySetting_C";

		// Token: 0x0401107C RID: 69756
		private static IntPtr _ClassPtr;

		// Token: 0x0401107D RID: 69757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401107E RID: 69758
		internal static int __PropertyOffset_SplitScreenView;

		// Token: 0x0401107F RID: 69759
		internal static int __PropertyOffset_SplitScreenUIMaterial;

		// Token: 0x04011080 RID: 69760
		internal static int __PropertyOffset_CaptureOffsetLocation;

		// Token: 0x04011081 RID: 69761
		internal static int __PropertyOffset_CaptureOffsetRotation;

		// Token: 0x04011082 RID: 69762
		internal static int __PropertyOffset_FlowMaskCenterOffsetX;

		// Token: 0x04011083 RID: 69763
		internal static int __PropertyOffset_FlowMaskCenterOffsetY;

		// Token: 0x04011084 RID: 69764
		internal static int __PropertyOffset_Fov;

		// Token: 0x04011085 RID: 69765
		internal static int __PropertyOffset_KeyDelay;

		// Token: 0x04011086 RID: 69766
		internal static int __PropertyOffset_AutoPlayDelay;

		// Token: 0x04011087 RID: 69767
		internal static int __PropertyOffset_JudgeTime;

		// Token: 0x04011088 RID: 69768
		internal static int __PropertyOffset_FlowMaskAlphaPositionCurve;

		// Token: 0x04011089 RID: 69769
		internal static int __PropertyOffset_EnableFlowMaskRealtimeTuning;

		// Token: 0x0401108A RID: 69770
		internal static int __PropertyOffset_MusicFadeOutTime;

		// Token: 0x0401108B RID: 69771
		internal static int __PropertyOffset_MusicStartRecoverTime;

		// Token: 0x0401108C RID: 69772
		internal static int __PropertyOffset_MusicRecoverTime;

		// Token: 0x0401108D RID: 69773
		internal static int __PropertyOffset_HelpID;
	}
}
