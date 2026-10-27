using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004367 RID: 17255
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_BindStateAiSenseEnable_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB8E RID: 183182 RVA: 0x00A26D7D File Offset: 0x00A24F7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateAiSenseEnable_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C");
			}
			return BP_SM_BindStateAiSenseEnable_C._ClassPtr;
		}

		// Token: 0x0602CB8F RID: 183183 RVA: 0x00A26DA4 File Offset: 0x00A24FA4
		public BP_SM_BindStateAiSenseEnable_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiSenseEnable_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB90 RID: 183184 RVA: 0x00A26DCC File Offset: 0x00A24FCC
		[NullableContext(1)]
		public BP_SM_BindStateAiSenseEnable_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiSenseEnable_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007091 RID: 28817
		// (get) Token: 0x0602CB91 RID: 183185 RVA: 0x00A26DFF File Offset: 0x00A24FFF
		// (set) Token: 0x0602CB92 RID: 183186 RVA: 0x00A26E0F File Offset: 0x00A2500F
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateAiSenseEnable_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateAiSenseEnable_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB93 RID: 183187 RVA: 0x00A26E20 File Offset: 0x00A25020
		protected BP_SM_BindStateAiSenseEnable_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017954 RID: 96596
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C";

		// Token: 0x04017955 RID: 96597
		private static IntPtr _ClassPtr;

		// Token: 0x04017956 RID: 96598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017957 RID: 96599
		internal static int __PropertyOffset_0;
	}
}
