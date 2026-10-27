using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004035 RID: 16437
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Feixue.BP_Motor_BaseVehicle_Feixue_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class BP_Motor_BaseVehicle_Feixue_C : BP_Motor_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A2EE RID: 172782 RVA: 0x009D8735 File Offset: 0x009D6935
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Feixue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Feixue.BP_Motor_BaseVehicle_Feixue_C");
			}
			return BP_Motor_BaseVehicle_Feixue_C._ClassPtr;
		}

		// Token: 0x0602A2EF RID: 172783 RVA: 0x009D875C File Offset: 0x009D695C
		public BP_Motor_BaseVehicle_Feixue_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Feixue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A2F0 RID: 172784 RVA: 0x009D8784 File Offset: 0x009D6984
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Feixue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Feixue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006719 RID: 26393
		// (get) Token: 0x0602A2F1 RID: 172785 RVA: 0x009D87B7 File Offset: 0x009D69B7
		// (set) Token: 0x0602A2F2 RID: 172786 RVA: 0x009D87CB File Offset: 0x009D69CB
		public unsafe UNiagaraComponent Niagara2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Feixue_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Feixue_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700671A RID: 26394
		// (get) Token: 0x0602A2F3 RID: 172787 RVA: 0x009D87E0 File Offset: 0x009D69E0
		// (set) Token: 0x0602A2F4 RID: 172788 RVA: 0x009D87F4 File Offset: 0x009D69F4
		public unsafe UNiagaraComponent Niagara1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Feixue_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Feixue_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602A2F5 RID: 172789 RVA: 0x009D8809 File Offset: 0x009D6A09
		protected BP_Motor_BaseVehicle_Feixue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BEC RID: 89068
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Feixue.BP_Motor_BaseVehicle_Feixue_C";

		// Token: 0x04015BED RID: 89069
		private static IntPtr _ClassPtr;

		// Token: 0x04015BEE RID: 89070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BEF RID: 89071
		internal static int __PropertyOffset_0;

		// Token: 0x04015BF0 RID: 89072
		internal new static int __PropertyOffset_1;
	}
}
