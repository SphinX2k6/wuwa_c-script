using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Seq
{
	// Token: 0x0200403C RID: 16444
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Mengzhou_Seq_V2.BP_Motor_Mengzhou_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_Motor_Mengzhou_Seq_V2_C : BP_Motor_BaseVehicle_Seq_V2_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A359 RID: 172889 RVA: 0x009D93F4 File Offset: 0x009D75F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_Mengzhou_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Mengzhou_Seq_V2.BP_Motor_Mengzhou_Seq_V2_C");
			}
			return BP_Motor_Mengzhou_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A35A RID: 172890 RVA: 0x009D9418 File Offset: 0x009D7618
		public BP_Motor_Mengzhou_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Mengzhou_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A35B RID: 172891 RVA: 0x009D9440 File Offset: 0x009D7640
		[NullableContext(1)]
		public BP_Motor_Mengzhou_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Mengzhou_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A35C RID: 172892 RVA: 0x009D9473 File Offset: 0x009D7673
		protected BP_Motor_Mengzhou_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C2D RID: 89133
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Mengzhou_Seq_V2.BP_Motor_Mengzhou_Seq_V2_C";

		// Token: 0x04015C2E RID: 89134
		private static IntPtr _ClassPtr;

		// Token: 0x04015C2F RID: 89135
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
