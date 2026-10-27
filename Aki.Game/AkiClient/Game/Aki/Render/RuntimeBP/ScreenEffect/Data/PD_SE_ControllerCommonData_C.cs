using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AEB RID: 15083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/PD_SE_ControllerCommonData.PD_SE_ControllerCommonData_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class PD_SE_ControllerCommonData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A8D RID: 133773 RVA: 0x008D93D5 File Offset: 0x008D75D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SE_ControllerCommonData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/PD_SE_ControllerCommonData.PD_SE_ControllerCommonData_C");
			}
			return PD_SE_ControllerCommonData_C._ClassPtr;
		}

		// Token: 0x06020A8E RID: 133774 RVA: 0x008D93FC File Offset: 0x008D75FC
		public PD_SE_ControllerCommonData_C() : this(BuiltinUtils.AllocNativeUObject(PD_SE_ControllerCommonData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A8F RID: 133775 RVA: 0x008D9424 File Offset: 0x008D7624
		public PD_SE_ControllerCommonData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SE_ControllerCommonData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x06020A90 RID: 133776 RVA: 0x008D9458 File Offset: 0x008D7658
		// (set) Token: 0x06020A91 RID: 133777 RVA: 0x008D9491 File Offset: 0x008D7691
		public S_SE_ControllerCommon Data
		{
			get
			{
				base.FastCheckIsValid();
				S_SE_ControllerCommon result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new S_SE_ControllerCommon(base.NativePtr + (IntPtr)PD_SE_ControllerCommonData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(S_SE_ControllerCommon.StaticStruct(), base.NativePtr + (IntPtr)PD_SE_ControllerCommonData_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06020A92 RID: 133778 RVA: 0x008D94B2 File Offset: 0x008D76B2
		protected PD_SE_ControllerCommonData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD93 RID: 64915
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/PD_SE_ControllerCommonData.PD_SE_ControllerCommonData_C";

		// Token: 0x0400FD94 RID: 64916
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD95 RID: 64917
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD96 RID: 64918
		internal static int __PropertyOffset_0;

		// Token: 0x0400FD97 RID: 64919
		[Nullable(2)]
		private S_SE_ControllerCommon _Data;
	}
}
