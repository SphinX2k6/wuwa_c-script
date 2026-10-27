using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Seq
{
	// Token: 0x0200403B RID: 16443
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Linnaea_Seq_V2.BP_Motor_Linnaea_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_Motor_Linnaea_Seq_V2_C : BP_Motor_BaseVehicle_Seq_V2_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A355 RID: 172885 RVA: 0x009D936C File Offset: 0x009D756C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_Linnaea_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Linnaea_Seq_V2.BP_Motor_Linnaea_Seq_V2_C");
			}
			return BP_Motor_Linnaea_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A356 RID: 172886 RVA: 0x009D9390 File Offset: 0x009D7590
		public BP_Motor_Linnaea_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Linnaea_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A357 RID: 172887 RVA: 0x009D93B8 File Offset: 0x009D75B8
		[NullableContext(1)]
		public BP_Motor_Linnaea_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Linnaea_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A358 RID: 172888 RVA: 0x009D93EB File Offset: 0x009D75EB
		protected BP_Motor_Linnaea_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C2A RID: 89130
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Linnaea_Seq_V2.BP_Motor_Linnaea_Seq_V2_C";

		// Token: 0x04015C2B RID: 89131
		private static IntPtr _ClassPtr;

		// Token: 0x04015C2C RID: 89132
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
