using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040EC RID: 16620
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv2.NCS_Out_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD82 RID: 175490 RVA: 0x009ED318 File Offset: 0x009EB518
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv2.NCS_Out_Lv2_C");
			}
			return NCS_Out_Lv2_C._ClassPtr;
		}

		// Token: 0x0602AD83 RID: 175491 RVA: 0x009ED33C File Offset: 0x009EB53C
		public NCS_Out_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD84 RID: 175492 RVA: 0x009ED364 File Offset: 0x009EB564
		[NullableContext(1)]
		public NCS_Out_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD85 RID: 175493 RVA: 0x009ED397 File Offset: 0x009EB597
		protected NCS_Out_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016324 RID: 90916
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv2.NCS_Out_Lv2_C";

		// Token: 0x04016325 RID: 90917
		private static IntPtr _ClassPtr;

		// Token: 0x04016326 RID: 90918
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
