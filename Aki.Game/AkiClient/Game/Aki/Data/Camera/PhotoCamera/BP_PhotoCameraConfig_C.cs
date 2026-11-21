using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera
{
	// Token: 0x02003238 RID: 12856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class BP_PhotoCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602019C RID: 131484 RVA: 0x0093D6B4 File Offset: 0x0093B8B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotoCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C");
			}
			return BP_PhotoCameraConfig_C._ClassPtr;
		}

		// Token: 0x0602019D RID: 131485 RVA: 0x0093D6D8 File Offset: 0x0093B8D8
		public BP_PhotoCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602019E RID: 131486 RVA: 0x0093D700 File Offset: 0x0093B900
		public BP_PhotoCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotoCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0602019F RID: 131487 RVA: 0x0093D733 File Offset: 0x0093B933
		// (set) Token: 0x060201A0 RID: 131488 RVA: 0x0093D747 File Offset: 0x0093B947
		[Nullable(0)]
		public unsafe TEnumAsByte<PhotoCameraType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_Type);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x060201A1 RID: 131489 RVA: 0x0093D75C File Offset: 0x0093B95C
		// (set) Token: 0x060201A2 RID: 131490 RVA: 0x0093D795 File Offset: 0x0093B995
		public SPhotoCameraCommonConfig CommonConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraCommonConfig result;
				if ((result = this._CommonConfig) == null)
				{
					result = (this._CommonConfig = new SPhotoCameraCommonConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CommonConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraCommonConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CommonConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x060201A3 RID: 131491 RVA: 0x0093D7B8 File Offset: 0x0093B9B8
		// (set) Token: 0x060201A4 RID: 131492 RVA: 0x0093D7F1 File Offset: 0x0093B9F1
		public SPhotoCameraMoveConfig MoveConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraMoveConfig result;
				if ((result = this._MoveConfig) == null)
				{
					result = (this._MoveConfig = new SPhotoCameraMoveConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_MoveConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraMoveConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_MoveConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x060201A5 RID: 131493 RVA: 0x0093D812 File Offset: 0x0093BA12
		// (set) Token: 0x060201A6 RID: 131494 RVA: 0x0093D826 File Offset: 0x0093BA26
		public unsafe SPhotoCameraSelfieIkConfig SelfieIkConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_SelfieIkConfig);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_SelfieIkConfig) = value;
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x060201A7 RID: 131495 RVA: 0x0093D83C File Offset: 0x0093BA3C
		// (set) Token: 0x060201A8 RID: 131496 RVA: 0x0093D875 File Offset: 0x0093BA75
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
					result = (this._BodyTypeDeltaConfig = new TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig>(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_BodyTypeDeltaConfig, this));
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

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x060201A9 RID: 131497 RVA: 0x0093D883 File Offset: 0x0093BA83
		// (set) Token: 0x060201AA RID: 131498 RVA: 0x0093D893 File Offset: 0x0093BA93
		public unsafe bool IsTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_IsTemplate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_IsTemplate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x060201AB RID: 131499 RVA: 0x0093D8A4 File Offset: 0x0093BAA4
		// (set) Token: 0x060201AC RID: 131500 RVA: 0x0093D8B4 File Offset: 0x0093BAB4
		public unsafe bool IsOpenDebugChangeConfigPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_IsOpenDebugChangeConfigPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_IsOpenDebugChangeConfigPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x060201AD RID: 131501 RVA: 0x0093D8C8 File Offset: 0x0093BAC8
		// (set) Token: 0x060201AE RID: 131502 RVA: 0x0093D901 File Offset: 0x0093BB01
		public SPhotoCameraCompositionConfig CompositionConfig
		{
			get
			{
				base.FastCheckIsValid();
				SPhotoCameraCompositionConfig result;
				if ((result = this._CompositionConfig) == null)
				{
					result = (this._CompositionConfig = new SPhotoCameraCompositionConfig(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CompositionConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPhotoCameraCompositionConfig.StaticStruct(), base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CompositionConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x060201AF RID: 131503 RVA: 0x0093D922 File Offset: 0x0093BB22
		// (set) Token: 0x060201B0 RID: 131504 RVA: 0x0093D932 File Offset: 0x0093BB32
		public unsafe float CharacterMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CharacterMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_CharacterMoveSpeed) = value;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x060201B1 RID: 131505 RVA: 0x0093D943 File Offset: 0x0093BB43
		// (set) Token: 0x060201B2 RID: 131506 RVA: 0x0093D953 File Offset: 0x0093BB53
		public unsafe bool NeedLeaveSitDownBeforeEnter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_NeedLeaveSitDownBeforeEnter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_NeedLeaveSitDownBeforeEnter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x060201B3 RID: 131507 RVA: 0x0093D964 File Offset: 0x0093BB64
		// (set) Token: 0x060201B4 RID: 131508 RVA: 0x0093D99D File Offset: 0x0093BB9D
		public TArray<string> Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new TArray<string>(base.NativePtr + (IntPtr)BP_PhotoCameraConfig_C.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				this.Tags.CopyAssign(value);
			}
		}

		// Token: 0x060201B5 RID: 131509 RVA: 0x0093D9AB File Offset: 0x0093BBAB
		protected BP_PhotoCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011457 RID: 70743
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/BP_PhotoCameraConfig.BP_PhotoCameraConfig_C";

		// Token: 0x04011458 RID: 70744
		private static IntPtr _ClassPtr;

		// Token: 0x04011459 RID: 70745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401145A RID: 70746
		internal static int __PropertyOffset_Type;

		// Token: 0x0401145B RID: 70747
		internal static int __PropertyOffset_CommonConfig;

		// Token: 0x0401145C RID: 70748
		[Nullable(2)]
		private SPhotoCameraCommonConfig _CommonConfig;

		// Token: 0x0401145D RID: 70749
		internal static int __PropertyOffset_MoveConfig;

		// Token: 0x0401145E RID: 70750
		[Nullable(2)]
		private SPhotoCameraMoveConfig _MoveConfig;

		// Token: 0x0401145F RID: 70751
		internal static int __PropertyOffset_SelfieIkConfig;

		// Token: 0x04011460 RID: 70752
		internal static int __PropertyOffset_BodyTypeDeltaConfig;

		// Token: 0x04011461 RID: 70753
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EPhotoCameraBodyType>, SPhotoCameraMorphDeltaConfig> _BodyTypeDeltaConfig;

		// Token: 0x04011462 RID: 70754
		internal static int __PropertyOffset_IsTemplate;

		// Token: 0x04011463 RID: 70755
		internal static int __PropertyOffset_IsOpenDebugChangeConfigPreview;

		// Token: 0x04011464 RID: 70756
		internal static int __PropertyOffset_CompositionConfig;

		// Token: 0x04011465 RID: 70757
		[Nullable(2)]
		private SPhotoCameraCompositionConfig _CompositionConfig;

		// Token: 0x04011466 RID: 70758
		internal static int __PropertyOffset_CharacterMoveSpeed;

		// Token: 0x04011467 RID: 70759
		internal static int __PropertyOffset_NeedLeaveSitDownBeforeEnter;

		// Token: 0x04011468 RID: 70760
		internal static int __PropertyOffset_Tags;

		// Token: 0x04011469 RID: 70761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Tags;
	}
}
