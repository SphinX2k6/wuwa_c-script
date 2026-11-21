using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003236 RID: 12854
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_MovieCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602018E RID: 131470 RVA: 0x0093D518 File Offset: 0x0093B718
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MovieCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C");
			}
			return BP_MovieCameraConfig_C._ClassPtr;
		}

		// Token: 0x0602018F RID: 131471 RVA: 0x0093D53C File Offset: 0x0093B73C
		public BP_MovieCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MovieCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020190 RID: 131472 RVA: 0x0093D564 File Offset: 0x0093B764
		[NullableContext(1)]
		public BP_MovieCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MovieCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x06020191 RID: 131473 RVA: 0x0093D597 File Offset: 0x0093B797
		// (set) Token: 0x06020192 RID: 131474 RVA: 0x0093D5A7 File Offset: 0x0093B7A7
		public unsafe float ZSmoothFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_ZSmoothFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_ZSmoothFactor) = value;
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x06020193 RID: 131475 RVA: 0x0093D5B8 File Offset: 0x0093B7B8
		// (set) Token: 0x06020194 RID: 131476 RVA: 0x0093D5C8 File Offset: 0x0093B7C8
		public unsafe float ZSmoothDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_ZSmoothDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_ZSmoothDelta) = value;
			}
		}

		// Token: 0x06020195 RID: 131477 RVA: 0x0093D5D9 File Offset: 0x0093B7D9
		protected BP_MovieCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401144D RID: 70733
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C";

		// Token: 0x0401144E RID: 70734
		private static IntPtr _ClassPtr;

		// Token: 0x0401144F RID: 70735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011450 RID: 70736
		internal static int __PropertyOffset_ZSmoothFactor;

		// Token: 0x04011451 RID: 70737
		internal static int __PropertyOffset_ZSmoothDelta;
	}
}
