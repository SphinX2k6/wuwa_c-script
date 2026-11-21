using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.Data.Water
{
	// Token: 0x02003145 RID: 12613
	[UnrealObjectPath("/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class BP_RippleWater_Data_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F042 RID: 127042 RVA: 0x009241BE File Offset: 0x009223BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RippleWater_Data_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C");
			}
			return BP_RippleWater_Data_C._ClassPtr;
		}

		// Token: 0x0601F043 RID: 127043 RVA: 0x009241E4 File Offset: 0x009223E4
		public BP_RippleWater_Data_C() : this(BuiltinUtils.AllocNativeUObject(BP_RippleWater_Data_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F044 RID: 127044 RVA: 0x0092420C File Offset: 0x0092240C
		[NullableContext(1)]
		public BP_RippleWater_Data_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RippleWater_Data_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F045 RID: 127045 RVA: 0x0092423F File Offset: 0x0092243F
		protected BP_RippleWater_Data_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401087E RID: 67710
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/Data/Water/BP_RippleWater_Data.BP_RippleWater_Data_C";

		// Token: 0x0401087F RID: 67711
		private static IntPtr _ClassPtr;

		// Token: 0x04010880 RID: 67712
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
