using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004360 RID: 17248
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionRemoveTagCount_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB62 RID: 183138 RVA: 0x00A26899 File Offset: 0x00A24A99
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionRemoveTagCount_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C");
			}
			return BP_SM_ActionRemoveTagCount_C._ClassPtr;
		}

		// Token: 0x0602CB63 RID: 183139 RVA: 0x00A268C0 File Offset: 0x00A24AC0
		public BP_SM_ActionRemoveTagCount_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveTagCount_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB64 RID: 183140 RVA: 0x00A268E8 File Offset: 0x00A24AE8
		[NullableContext(1)]
		public BP_SM_ActionRemoveTagCount_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveTagCount_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007089 RID: 28809
		// (get) Token: 0x0602CB65 RID: 183141 RVA: 0x00A2691B File Offset: 0x00A24B1B
		// (set) Token: 0x0602CB66 RID: 183142 RVA: 0x00A2692F File Offset: 0x00A24B2F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700708A RID: 28810
		// (get) Token: 0x0602CB67 RID: 183143 RVA: 0x00A26944 File Offset: 0x00A24B44
		// (set) Token: 0x0602CB68 RID: 183144 RVA: 0x00A26954 File Offset: 0x00A24B54
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveTagCount_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602CB69 RID: 183145 RVA: 0x00A26965 File Offset: 0x00A24B65
		protected BP_SM_ActionRemoveTagCount_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017937 RID: 96567
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveTagCount.BP_SM_ActionRemoveTagCount_C";

		// Token: 0x04017938 RID: 96568
		private static IntPtr _ClassPtr;

		// Token: 0x04017939 RID: 96569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401793A RID: 96570
		internal static int __PropertyOffset_0;

		// Token: 0x0401793B RID: 96571
		internal static int __PropertyOffset_1;
	}
}
