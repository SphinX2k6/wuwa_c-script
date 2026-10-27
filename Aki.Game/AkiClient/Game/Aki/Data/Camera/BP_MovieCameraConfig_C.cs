using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003FAE RID: 16302
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_MovieCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029B5E RID: 170846 RVA: 0x009CABF4 File Offset: 0x009C8DF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MovieCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C");
			}
			return BP_MovieCameraConfig_C._ClassPtr;
		}

		// Token: 0x06029B5F RID: 170847 RVA: 0x009CAC18 File Offset: 0x009C8E18
		public BP_MovieCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MovieCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029B60 RID: 170848 RVA: 0x009CAC40 File Offset: 0x009C8E40
		[NullableContext(1)]
		public BP_MovieCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MovieCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064E3 RID: 25827
		// (get) Token: 0x06029B61 RID: 170849 RVA: 0x009CAC73 File Offset: 0x009C8E73
		// (set) Token: 0x06029B62 RID: 170850 RVA: 0x009CAC83 File Offset: 0x009C8E83
		public unsafe float ZSmoothFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x06029B63 RID: 170851 RVA: 0x009CAC94 File Offset: 0x009C8E94
		// (set) Token: 0x06029B64 RID: 170852 RVA: 0x009CACA4 File Offset: 0x009C8EA4
		public unsafe float ZSmoothDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovieCameraConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06029B65 RID: 170853 RVA: 0x009CACB5 File Offset: 0x009C8EB5
		protected BP_MovieCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156A5 RID: 87717
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_MovieCameraConfig.BP_MovieCameraConfig_C";

		// Token: 0x040156A6 RID: 87718
		private static IntPtr _ClassPtr;

		// Token: 0x040156A7 RID: 87719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156A8 RID: 87720
		internal static int __PropertyOffset_0;

		// Token: 0x040156A9 RID: 87721
		internal static int __PropertyOffset_1;
	}
}
