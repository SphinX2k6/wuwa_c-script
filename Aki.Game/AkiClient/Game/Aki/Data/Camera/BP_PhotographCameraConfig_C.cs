using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003FAF RID: 16303
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_PhotographCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029B66 RID: 170854 RVA: 0x009CACBE File Offset: 0x009C8EBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotographCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C");
			}
			return BP_PhotographCameraConfig_C._ClassPtr;
		}

		// Token: 0x06029B67 RID: 170855 RVA: 0x009CACE4 File Offset: 0x009C8EE4
		public BP_PhotographCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotographCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029B68 RID: 170856 RVA: 0x009CAD0C File Offset: 0x009C8F0C
		[NullableContext(1)]
		public BP_PhotographCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotographCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x06029B69 RID: 170857 RVA: 0x009CAD40 File Offset: 0x009C8F40
		// (set) Token: 0x06029B6A RID: 170858 RVA: 0x009CAD79 File Offset: 0x009C8F79
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EPhotographCamera>, float> 基础
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EPhotographCamera>, float> result;
				if ((result = this._基础) == null)
				{
					result = (this._基础 = new TMap<TEnumAsByte<EPhotographCamera>, float>(base.NativePtr + (IntPtr)BP_PhotographCameraConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.基础.CopyAssign(value);
			}
		}

		// Token: 0x06029B6B RID: 170859 RVA: 0x009CAD87 File Offset: 0x009C8F87
		protected BP_PhotographCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156AA RID: 87722
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C";

		// Token: 0x040156AB RID: 87723
		private static IntPtr _ClassPtr;

		// Token: 0x040156AC RID: 87724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156AD RID: 87725
		internal static int __PropertyOffset_0;

		// Token: 0x040156AE RID: 87726
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EPhotographCamera>, float> _基础;
	}
}
