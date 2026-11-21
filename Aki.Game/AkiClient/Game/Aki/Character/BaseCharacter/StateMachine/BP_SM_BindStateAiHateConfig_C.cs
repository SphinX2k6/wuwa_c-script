using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003387 RID: 13191
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_BindStateAiHateConfig_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217A6 RID: 137126 RVA: 0x00961B25 File Offset: 0x0095FD25
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateAiHateConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C");
			}
			return BP_SM_BindStateAiHateConfig_C._ClassPtr;
		}

		// Token: 0x060217A7 RID: 137127 RVA: 0x00961B4C File Offset: 0x0095FD4C
		public BP_SM_BindStateAiHateConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiHateConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217A8 RID: 137128 RVA: 0x00961B74 File Offset: 0x0095FD74
		[NullableContext(1)]
		public BP_SM_BindStateAiHateConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiHateConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x060217A9 RID: 137129 RVA: 0x00961BA7 File Offset: 0x0095FDA7
		// (set) Token: 0x060217AA RID: 137130 RVA: 0x00961BB7 File Offset: 0x0095FDB7
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateAiHateConfig_C.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateAiHateConfig_C.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x060217AB RID: 137131 RVA: 0x00961BC8 File Offset: 0x0095FDC8
		protected BP_SM_BindStateAiHateConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124D1 RID: 74961
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C";

		// Token: 0x040124D2 RID: 74962
		private static IntPtr _ClassPtr;

		// Token: 0x040124D3 RID: 74963
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124D4 RID: 74964
		internal static int __PropertyOffset_ConfigId;
	}
}
