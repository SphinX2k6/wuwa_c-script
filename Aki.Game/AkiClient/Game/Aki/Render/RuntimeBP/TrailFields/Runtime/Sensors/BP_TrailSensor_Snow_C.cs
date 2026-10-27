using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors
{
	// Token: 0x02003AB0 RID: 15024
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Snow.BP_TrailSensor_Snow_C")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1308)]
	public class BP_TrailSensor_Snow_C : BP_TrailSensorActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020343 RID: 131907 RVA: 0x008CC87B File Offset: 0x008CAA7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailSensor_Snow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Snow.BP_TrailSensor_Snow_C");
			}
			return BP_TrailSensor_Snow_C._ClassPtr;
		}

		// Token: 0x06020344 RID: 131908 RVA: 0x008CC8A0 File Offset: 0x008CAAA0
		public BP_TrailSensor_Snow_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensor_Snow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020345 RID: 131909 RVA: 0x008CC8C8 File Offset: 0x008CAAC8
		[NullableContext(1)]
		public BP_TrailSensor_Snow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensor_Snow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x06020346 RID: 131910 RVA: 0x008CC8FB File Offset: 0x008CAAFB
		// (set) Token: 0x06020347 RID: 131911 RVA: 0x008CC90F File Offset: 0x008CAB0F
		public unsafe FName UVXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensor_Snow_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensor_Snow_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06020348 RID: 131912 RVA: 0x008CC924 File Offset: 0x008CAB24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void DrawFinished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensor_Snow_C.__DrawFinished_NativeFunctionPtr, null);
		}

		// Token: 0x06020349 RID: 131913 RVA: 0x008CC938 File Offset: 0x008CAB38
		protected BP_TrailSensor_Snow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F911 RID: 63761
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensor_Snow.BP_TrailSensor_Snow_C";

		// Token: 0x0400F912 RID: 63762
		private static IntPtr _ClassPtr;

		// Token: 0x0400F913 RID: 63763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F914 RID: 63764
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F915 RID: 63765
		private static IntPtr __DrawFinished_NativeFunctionPtr;
	}
}
