using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x020030F6 RID: 12534
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_ControlTodTime_C : AKuroControlTodTime, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E72C RID: 124716 RVA: 0x009144D2 File Offset: 0x009126D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ControlTodTime_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C");
			}
			return BP_ControlTodTime_C._ClassPtr;
		}

		// Token: 0x0601E72D RID: 124717 RVA: 0x009144F8 File Offset: 0x009126F8
		public BP_ControlTodTime_C() : this(BuiltinUtils.AllocNativeUObject(BP_ControlTodTime_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E72E RID: 124718 RVA: 0x00914520 File Offset: 0x00912720
		[NullableContext(1)]
		public BP_ControlTodTime_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ControlTodTime_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E72F RID: 124719 RVA: 0x00914553 File Offset: 0x00912753
		protected BP_ControlTodTime_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401020E RID: 66062
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_ControlTodTime.BP_ControlTodTime_C";

		// Token: 0x0401020F RID: 66063
		private static IntPtr _ClassPtr;

		// Token: 0x04010210 RID: 66064
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
