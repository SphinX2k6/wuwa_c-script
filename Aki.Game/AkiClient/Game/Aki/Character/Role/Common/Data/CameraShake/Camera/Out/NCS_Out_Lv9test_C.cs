using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040F3 RID: 16627
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9test.NCS_Out_Lv9test_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv9test_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD9E RID: 175518 RVA: 0x009ED6D0 File Offset: 0x009EB8D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv9test_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9test.NCS_Out_Lv9test_C");
			}
			return NCS_Out_Lv9test_C._ClassPtr;
		}

		// Token: 0x0602AD9F RID: 175519 RVA: 0x009ED6F4 File Offset: 0x009EB8F4
		public NCS_Out_Lv9test_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv9test_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADA0 RID: 175520 RVA: 0x009ED71C File Offset: 0x009EB91C
		[NullableContext(1)]
		public NCS_Out_Lv9test_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv9test_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADA1 RID: 175521 RVA: 0x009ED74F File Offset: 0x009EB94F
		protected NCS_Out_Lv9test_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016339 RID: 90937
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9test.NCS_Out_Lv9test_C";

		// Token: 0x0401633A RID: 90938
		private static IntPtr _ClassPtr;

		// Token: 0x0401633B RID: 90939
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
