using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003376 RID: 13174
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 53)]
	public class BP_SM_ActionActivateSkillGroup_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602173E RID: 137022 RVA: 0x00960F4E File Offset: 0x0095F14E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionActivateSkillGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C");
			}
			return BP_SM_ActionActivateSkillGroup_C._ClassPtr;
		}

		// Token: 0x0602173F RID: 137023 RVA: 0x00960F74 File Offset: 0x0095F174
		public BP_SM_ActionActivateSkillGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivateSkillGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021740 RID: 137024 RVA: 0x00960F9C File Offset: 0x0095F19C
		[NullableContext(1)]
		public BP_SM_ActionActivateSkillGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivateSkillGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x06021741 RID: 137025 RVA: 0x00960FCF File Offset: 0x0095F1CF
		// (set) Token: 0x06021742 RID: 137026 RVA: 0x00960FDF File Offset: 0x0095F1DF
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x06021743 RID: 137027 RVA: 0x00960FF0 File Offset: 0x0095F1F0
		// (set) Token: 0x06021744 RID: 137028 RVA: 0x00961000 File Offset: 0x0095F200
		public unsafe bool 激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_激活) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_激活) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021745 RID: 137029 RVA: 0x00961011 File Offset: 0x0095F211
		protected BP_SM_ActionActivateSkillGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401248B RID: 74891
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C";

		// Token: 0x0401248C RID: 74892
		private static IntPtr _ClassPtr;

		// Token: 0x0401248D RID: 74893
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401248E RID: 74894
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x0401248F RID: 74895
		internal static int __PropertyOffset_激活;
	}
}
