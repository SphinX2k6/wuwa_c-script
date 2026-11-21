using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003237 RID: 12855
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_PhotographCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020196 RID: 131478 RVA: 0x0093D5E2 File Offset: 0x0093B7E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhotographCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C");
			}
			return BP_PhotographCameraConfig_C._ClassPtr;
		}

		// Token: 0x06020197 RID: 131479 RVA: 0x0093D608 File Offset: 0x0093B808
		public BP_PhotographCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhotographCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020198 RID: 131480 RVA: 0x0093D630 File Offset: 0x0093B830
		[NullableContext(1)]
		public BP_PhotographCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhotographCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x06020199 RID: 131481 RVA: 0x0093D664 File Offset: 0x0093B864
		// (set) Token: 0x0602019A RID: 131482 RVA: 0x0093D69D File Offset: 0x0093B89D
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
					result = (this._基础 = new TMap<TEnumAsByte<EPhotographCamera>, float>(base.NativePtr + (IntPtr)BP_PhotographCameraConfig_C.__PropertyOffset_基础, this));
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

		// Token: 0x0602019B RID: 131483 RVA: 0x0093D6AB File Offset: 0x0093B8AB
		protected BP_PhotographCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011452 RID: 70738
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_PhotographCameraConfig.BP_PhotographCameraConfig_C";

		// Token: 0x04011453 RID: 70739
		private static IntPtr _ClassPtr;

		// Token: 0x04011454 RID: 70740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011455 RID: 70741
		internal static int __PropertyOffset_基础;

		// Token: 0x04011456 RID: 70742
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EPhotographCamera>, float> _基础;
	}
}
