using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004366 RID: 17254
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_BindStateAiHateConfig_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB88 RID: 183176 RVA: 0x00A26CD1 File Offset: 0x00A24ED1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateAiHateConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C");
			}
			return BP_SM_BindStateAiHateConfig_C._ClassPtr;
		}

		// Token: 0x0602CB89 RID: 183177 RVA: 0x00A26CF8 File Offset: 0x00A24EF8
		public BP_SM_BindStateAiHateConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiHateConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB8A RID: 183178 RVA: 0x00A26D20 File Offset: 0x00A24F20
		[NullableContext(1)]
		public BP_SM_BindStateAiHateConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiHateConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007090 RID: 28816
		// (get) Token: 0x0602CB8B RID: 183179 RVA: 0x00A26D53 File Offset: 0x00A24F53
		// (set) Token: 0x0602CB8C RID: 183180 RVA: 0x00A26D63 File Offset: 0x00A24F63
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateAiHateConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateAiHateConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB8D RID: 183181 RVA: 0x00A26D74 File Offset: 0x00A24F74
		protected BP_SM_BindStateAiHateConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017950 RID: 96592
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiHateConfig.BP_SM_BindStateAiHateConfig_C";

		// Token: 0x04017951 RID: 96593
		private static IntPtr _ClassPtr;

		// Token: 0x04017952 RID: 96594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017953 RID: 96595
		internal static int __PropertyOffset_0;
	}
}
