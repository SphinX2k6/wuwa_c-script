using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040F6 RID: 16630
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv1.NCS_Left_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Left_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADAA RID: 175530 RVA: 0x009ED868 File Offset: 0x009EBA68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv1.NCS_Left_Lv1_C");
			}
			return NCS_Left_Lv1_C._ClassPtr;
		}

		// Token: 0x0602ADAB RID: 175531 RVA: 0x009ED88C File Offset: 0x009EBA8C
		public NCS_Left_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADAC RID: 175532 RVA: 0x009ED8B4 File Offset: 0x009EBAB4
		[NullableContext(1)]
		public NCS_Left_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADAD RID: 175533 RVA: 0x009ED8E7 File Offset: 0x009EBAE7
		protected NCS_Left_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016342 RID: 90946
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv1.NCS_Left_Lv1_C";

		// Token: 0x04016343 RID: 90947
		private static IntPtr _ClassPtr;

		// Token: 0x04016344 RID: 90948
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
