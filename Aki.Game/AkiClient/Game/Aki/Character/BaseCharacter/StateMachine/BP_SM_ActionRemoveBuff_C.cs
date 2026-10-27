using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435F RID: 17247
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ActionRemoveBuff_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB5C RID: 183132 RVA: 0x00A267F0 File Offset: 0x00A249F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionRemoveBuff_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C");
			}
			return BP_SM_ActionRemoveBuff_C._ClassPtr;
		}

		// Token: 0x0602CB5D RID: 183133 RVA: 0x00A26814 File Offset: 0x00A24A14
		public BP_SM_ActionRemoveBuff_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveBuff_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB5E RID: 183134 RVA: 0x00A2683C File Offset: 0x00A24A3C
		[NullableContext(1)]
		public BP_SM_ActionRemoveBuff_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionRemoveBuff_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007088 RID: 28808
		// (get) Token: 0x0602CB5F RID: 183135 RVA: 0x00A2686F File Offset: 0x00A24A6F
		// (set) Token: 0x0602CB60 RID: 183136 RVA: 0x00A2687F File Offset: 0x00A24A7F
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionRemoveBuff_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionRemoveBuff_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB61 RID: 183137 RVA: 0x00A26890 File Offset: 0x00A24A90
		protected BP_SM_ActionRemoveBuff_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017933 RID: 96563
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionRemoveBuff.BP_SM_ActionRemoveBuff_C";

		// Token: 0x04017934 RID: 96564
		private static IntPtr _ClassPtr;

		// Token: 0x04017935 RID: 96565
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017936 RID: 96566
		internal static int __PropertyOffset_0;
	}
}
