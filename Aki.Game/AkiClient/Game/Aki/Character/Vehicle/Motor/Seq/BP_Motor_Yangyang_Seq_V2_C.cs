using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Seq
{
	// Token: 0x0200403D RID: 16445
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Yangyang_Seq_V2.BP_Motor_Yangyang_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_Motor_Yangyang_Seq_V2_C : BP_Motor_BaseVehicle_Seq_V2_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A35D RID: 172893 RVA: 0x009D947C File Offset: 0x009D767C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_Yangyang_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Yangyang_Seq_V2.BP_Motor_Yangyang_Seq_V2_C");
			}
			return BP_Motor_Yangyang_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A35E RID: 172894 RVA: 0x009D94A0 File Offset: 0x009D76A0
		public BP_Motor_Yangyang_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Yangyang_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A35F RID: 172895 RVA: 0x009D94C8 File Offset: 0x009D76C8
		[NullableContext(1)]
		public BP_Motor_Yangyang_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_Yangyang_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A360 RID: 172896 RVA: 0x009D94FB File Offset: 0x009D76FB
		protected BP_Motor_Yangyang_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C30 RID: 89136
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_Yangyang_Seq_V2.BP_Motor_Yangyang_Seq_V2_C";

		// Token: 0x04015C31 RID: 89137
		private static IntPtr _ClassPtr;

		// Token: 0x04015C32 RID: 89138
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
