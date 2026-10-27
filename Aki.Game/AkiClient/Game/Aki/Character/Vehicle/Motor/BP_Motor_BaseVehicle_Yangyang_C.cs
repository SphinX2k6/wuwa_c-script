using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004039 RID: 16441
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Yangyang.BP_Motor_BaseVehicle_Yangyang_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2280)]
	public class BP_Motor_BaseVehicle_Yangyang_C : BP_Motor_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A34B RID: 172875 RVA: 0x009D9230 File Offset: 0x009D7430
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Yangyang_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Yangyang.BP_Motor_BaseVehicle_Yangyang_C");
			}
			return BP_Motor_BaseVehicle_Yangyang_C._ClassPtr;
		}

		// Token: 0x0602A34C RID: 172876 RVA: 0x009D9254 File Offset: 0x009D7454
		public BP_Motor_BaseVehicle_Yangyang_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Yangyang_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A34D RID: 172877 RVA: 0x009D927C File Offset: 0x009D747C
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Yangyang_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Yangyang_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006737 RID: 26423
		// (get) Token: 0x0602A34E RID: 172878 RVA: 0x009D92AF File Offset: 0x009D74AF
		// (set) Token: 0x0602A34F RID: 172879 RVA: 0x009D92C3 File Offset: 0x009D74C3
		[Nullable(2)]
		public unsafe UNiagaraComponent NS_Fx_Motuo_Deng_Glow
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Yangyang_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Yangyang_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602A350 RID: 172880 RVA: 0x009D92D8 File Offset: 0x009D74D8
		protected BP_Motor_BaseVehicle_Yangyang_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C23 RID: 89123
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Yangyang.BP_Motor_BaseVehicle_Yangyang_C";

		// Token: 0x04015C24 RID: 89124
		private static IntPtr _ClassPtr;

		// Token: 0x04015C25 RID: 89125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C26 RID: 89126
		internal static int __PropertyOffset_0;
	}
}
