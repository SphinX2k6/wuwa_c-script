using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004381 RID: 17281
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC5A RID: 183386 RVA: 0x00A28359 File Offset: 0x00A26559
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C");
			}
			return BP_SM_ConditionCheckState_C._ClassPtr;
		}

		// Token: 0x0602CC5B RID: 183387 RVA: 0x00A28380 File Offset: 0x00A26580
		public BP_SM_ConditionCheckState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC5C RID: 183388 RVA: 0x00A283A8 File Offset: 0x00A265A8
		public BP_SM_ConditionCheckState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070C3 RID: 28867
		// (get) Token: 0x0602CC5D RID: 183389 RVA: 0x00A283DB File Offset: 0x00A265DB
		// (set) Token: 0x0602CC5E RID: 183390 RVA: 0x00A283EF File Offset: 0x00A265EF
		public unsafe string 检查状态
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckState_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckState_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602CC5F RID: 183391 RVA: 0x00A28404 File Offset: 0x00A26604
		protected BP_SM_ConditionCheckState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179D9 RID: 96729
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckState.BP_SM_ConditionCheckState_C";

		// Token: 0x040179DA RID: 96730
		private static IntPtr _ClassPtr;

		// Token: 0x040179DB RID: 96731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179DC RID: 96732
		internal static int __PropertyOffset_0;
	}
}
