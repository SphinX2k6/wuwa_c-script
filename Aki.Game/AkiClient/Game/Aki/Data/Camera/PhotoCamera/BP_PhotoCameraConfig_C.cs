using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x02003FB0 RID: 16304
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class BP_PhotoCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029B6C RID: 170860 RVA: 0x009CAD90 File Offset: 0x009C8F90
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotoCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C");
			}
			return BP_PhotoCameraConfig_C._ClassPtr;
		}

		// Token: 0x06029B6D RID: 170861 RVA: 0x009CADB4 File Offset: 0x009C8FB4
		public BP_PhotoCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029B6E RID: 170862 RVA: 0x009CADDC File Offset: 0x009C8FDC
		public BP_PhotoCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x06029B6F RID: 170863 RVA: 0x009CAE0F File Offset: 0x009C900F
		// (set) Token: 0x06029B70 RID: 170864 RVA: 0x009CAE23 File Offset: 0x009C9023
		[Nullable(0)]
		public unsafe TEnumAsByte<PhotoCameraType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x06029B71 RID: 170865 RVA: 0x009CAE38 File Offset: 0x009C9038
		// (set) Token: 0x06029B72 RID: 170866 RVA: 0x009CAE71 File Offset: 0x009C9071
		public SPhotoCameraCommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraCommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SPhotoCameraCommonConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraCommonConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170064E8 RID: 25832
		// (get) Token: 0x06029B73 RID: 170867 RVA: 0x009CAE94 File Offset: 0x009C9094
		// (set) Token: 0x06029B74 RID: 170868 RVA: 0x009CAECD File Offset: 0x009C90CD
		public SPhotoCameraMoveConfig MoveConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraMoveConfig result;
				if ((result = this._MoveConfig) == null)
				{
					result = (this._MoveConfig = new SPhotoCameraMoveConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraMoveConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170064E9 RID: 25833
		// (get) Token: 0x06029B75 RID: 170869 RVA: 0x009CAEEE File Offset: 0x009C90EE
		// (set) Token: 0x06029B76 RID: 170870 RVA: 0x009CAF02 File Offset: 0x009C9102
		public unsafe SPhotoCameraSelfieIkConfig SelfieIkConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170064EA RID: 25834
		// (get) Token: 0x06029B77 RID: 170871 RVA: 0x009CAF18 File Offset: 0x009C9118
		// (set) Token: 0x06029B78 RID: 170872 RVA: 0x009CAF51 File Offset: 0x009C9151
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig> BodyTypeDeltaConfig
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig> result;
				if ((result = this._BodyTypeDeltaConfig) == null)
				{
					result = (this._BodyTypeDeltaConfig = new TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig>(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.BodyTypeDeltaConfig.CopyAssign(value);
			}
		}

		// Token: 0x170064EB RID: 25835
		// (get) Token: 0x06029B79 RID: 170873 RVA: 0x009CAF5F File Offset: 0x009C915F
		// (set) Token: 0x06029B7A RID: 170874 RVA: 0x009CAF6F File Offset: 0x009C916F
		public unsafe bool IsTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064EC RID: 25836
		// (get) Token: 0x06029B7B RID: 170875 RVA: 0x009CAF80 File Offset: 0x009C9180
		// (set) Token: 0x06029B7C RID: 170876 RVA: 0x009CAF90 File Offset: 0x009C9190
		public unsafe bool IsOpenDebugChangeConfigPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064ED RID: 25837
		// (get) Token: 0x06029B7D RID: 170877 RVA: 0x009CAFA4 File Offset: 0x009C91A4
		// (set) Token: 0x06029B7E RID: 170878 RVA: 0x009CAFDD File Offset: 0x009C91DD
		public SPhotoCameraCompositionConfig CompositionConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraCompositionConfig result;
				if ((result = this._CompositionConfig) == null)
				{
					result = (this._CompositionConfig = new SPhotoCameraCompositionConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraCompositionConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170064EE RID: 25838
		// (get) Token: 0x06029B7F RID: 170879 RVA: 0x009CAFFE File Offset: 0x009C91FE
		// (set) Token: 0x06029B80 RID: 170880 RVA: 0x009CB00E File Offset: 0x009C920E
		public unsafe float CharacterMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170064EF RID: 25839
		// (get) Token: 0x06029B81 RID: 170881 RVA: 0x009CB01F File Offset: 0x009C921F
		// (set) Token: 0x06029B82 RID: 170882 RVA: 0x009CB02F File Offset: 0x009C922F
		public unsafe bool NeedLeaveSitDownBeforeEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064F0 RID: 25840
		// (get) Token: 0x06029B83 RID: 170883 RVA: 0x009CB040 File Offset: 0x009C9240
		// (set) Token: 0x06029B84 RID: 170884 RVA: 0x009CB079 File Offset: 0x009C9279
		public TArray<string> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<string>(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x06029B85 RID: 170885 RVA: 0x009CB087 File Offset: 0x009C9287
		protected BP_PhotoCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156AF RID: 87727
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C";

		// Token: 0x040156B0 RID: 87728
		private static IntPtr _ClassPtr;

		// Token: 0x040156B1 RID: 87729
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156B2 RID: 87730
		internal static int __PropertyOffset_0;

		// Token: 0x040156B3 RID: 87731
		internal static int __PropertyOffset_1;

		// Token: 0x040156B4 RID: 87732
		[Nullable(2)]
		private SPhotoCameraCommonConfig _CommonConfig;

		// Token: 0x040156B5 RID: 87733
		internal static int __PropertyOffset_2;

		// Token: 0x040156B6 RID: 87734
		[Nullable(2)]
		private SPhotoCameraMoveConfig _MoveConfig;

		// Token: 0x040156B7 RID: 87735
		internal static int __PropertyOffset_3;

		// Token: 0x040156B8 RID: 87736
		internal static int __PropertyOffset_4;

		// Token: 0x040156B9 RID: 87737
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig> _BodyTypeDeltaConfig;

		// Token: 0x040156BA RID: 87738
		internal static int __PropertyOffset_5;

		// Token: 0x040156BB RID: 87739
		internal static int __PropertyOffset_6;

		// Token: 0x040156BC RID: 87740
		internal static int __PropertyOffset_7;

		// Token: 0x040156BD RID: 87741
		[Nullable(2)]
		private SPhotoCameraCompositionConfig _CompositionConfig;

		// Token: 0x040156BE RID: 87742
		internal static int __PropertyOffset_8;

		// Token: 0x040156BF RID: 87743
		internal static int __PropertyOffset_9;

		// Token: 0x040156C0 RID: 87744
		internal static int __PropertyOffset_10;

		// Token: 0x040156C1 RID: 87745
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Tags;
	}
}
