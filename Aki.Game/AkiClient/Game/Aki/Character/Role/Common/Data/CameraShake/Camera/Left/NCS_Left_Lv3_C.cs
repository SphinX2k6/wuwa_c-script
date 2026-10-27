using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040F8 RID: 16632
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv3.NCS_Left_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Left_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADB2 RID: 175538 RVA: 0x009ED978 File Offset: 0x009EBB78
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv3.NCS_Left_Lv3_C");
			}
			return NCS_Left_Lv3_C._ClassPtr;
		}

		// Token: 0x0602ADB3 RID: 175539 RVA: 0x009ED99C File Offset: 0x009EBB9C
		public NCS_Left_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x009ED9C4 File Offset: 0x009EBBC4
		[NullableContext(1)]
		public NCS_Left_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x009ED9F7 File Offset: 0x009EBBF7
		protected NCS_Left_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016348 RID: 90952
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv3.NCS_Left_Lv3_C";

		// Token: 0x04016349 RID: 90953
		private static IntPtr _ClassPtr;

		// Token: 0x0401634A RID: 90954
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
