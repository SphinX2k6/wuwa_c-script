using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040EE RID: 16622
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv4.NCS_Out_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD8A RID: 175498 RVA: 0x009ED428 File Offset: 0x009EB628
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv4.NCS_Out_Lv4_C");
			}
			return NCS_Out_Lv4_C._ClassPtr;
		}

		// Token: 0x0602AD8B RID: 175499 RVA: 0x009ED44C File Offset: 0x009EB64C
		public NCS_Out_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD8C RID: 175500 RVA: 0x009ED474 File Offset: 0x009EB674
		[NullableContext(1)]
		public NCS_Out_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD8D RID: 175501 RVA: 0x009ED4A7 File Offset: 0x009EB6A7
		protected NCS_Out_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401632A RID: 90922
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv4.NCS_Out_Lv4_C";

		// Token: 0x0401632B RID: 90923
		private static IntPtr _ClassPtr;

		// Token: 0x0401632C RID: 90924
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
