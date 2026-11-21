using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003388 RID: 13192
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_BindStateAiSenseEnable_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217AC RID: 137132 RVA: 0x00961BD1 File Offset: 0x0095FDD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateAiSenseEnable_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C");
			}
			return BP_SM_BindStateAiSenseEnable_C._ClassPtr;
		}

		// Token: 0x060217AD RID: 137133 RVA: 0x00961BF8 File Offset: 0x0095FDF8
		public BP_SM_BindStateAiSenseEnable_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiSenseEnable_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217AE RID: 137134 RVA: 0x00961C20 File Offset: 0x0095FE20
		[NullableContext(1)]
		public BP_SM_BindStateAiSenseEnable_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateAiSenseEnable_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x060217AF RID: 137135 RVA: 0x00961C53 File Offset: 0x0095FE53
		// (set) Token: 0x060217B0 RID: 137136 RVA: 0x00961C63 File Offset: 0x0095FE63
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateAiSenseEnable_C.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateAiSenseEnable_C.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x060217B1 RID: 137137 RVA: 0x00961C74 File Offset: 0x0095FE74
		protected BP_SM_BindStateAiSenseEnable_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124D5 RID: 74965
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateAiSenseEnable.BP_SM_BindStateAiSenseEnable_C";

		// Token: 0x040124D6 RID: 74966
		private static IntPtr _ClassPtr;

		// Token: 0x040124D7 RID: 74967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124D8 RID: 74968
		internal static int __PropertyOffset_ConfigId;
	}
}
