using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004355 RID: 17237
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 53)]
	public class BP_SM_ActionActivateSkillGroup_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB20 RID: 183072 RVA: 0x00A260FA File Offset: 0x00A242FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionActivateSkillGroup_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C");
			}
			return BP_SM_ActionActivateSkillGroup_C._ClassPtr;
		}

		// Token: 0x0602CB21 RID: 183073 RVA: 0x00A26120 File Offset: 0x00A24320
		public BP_SM_ActionActivateSkillGroup_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivateSkillGroup_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB22 RID: 183074 RVA: 0x00A26148 File Offset: 0x00A24348
		[NullableContext(1)]
		public BP_SM_ActionActivateSkillGroup_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivateSkillGroup_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700707E RID: 28798
		// (get) Token: 0x0602CB23 RID: 183075 RVA: 0x00A2617B File Offset: 0x00A2437B
		// (set) Token: 0x0602CB24 RID: 183076 RVA: 0x00A2618B File Offset: 0x00A2438B
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700707F RID: 28799
		// (get) Token: 0x0602CB25 RID: 183077 RVA: 0x00A2619C File Offset: 0x00A2439C
		// (set) Token: 0x0602CB26 RID: 183078 RVA: 0x00A261AC File Offset: 0x00A243AC
		public unsafe bool 激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivateSkillGroup_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CB27 RID: 183079 RVA: 0x00A261BD File Offset: 0x00A243BD
		protected BP_SM_ActionActivateSkillGroup_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401790A RID: 96522
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivateSkillGroup.BP_SM_ActionActivateSkillGroup_C";

		// Token: 0x0401790B RID: 96523
		private static IntPtr _ClassPtr;

		// Token: 0x0401790C RID: 96524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401790D RID: 96525
		internal static int __PropertyOffset_0;

		// Token: 0x0401790E RID: 96526
		internal static int __PropertyOffset_1;
	}
}
