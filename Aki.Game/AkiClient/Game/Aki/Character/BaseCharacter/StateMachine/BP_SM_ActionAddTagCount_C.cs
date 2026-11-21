using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003378 RID: 13176
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionAddTagCount_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602174C RID: 137036 RVA: 0x009610C5 File Offset: 0x0095F2C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionAddTagCount_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C");
			}
			return BP_SM_ActionAddTagCount_C._ClassPtr;
		}

		// Token: 0x0602174D RID: 137037 RVA: 0x009610EC File Offset: 0x0095F2EC
		public BP_SM_ActionAddTagCount_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddTagCount_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602174E RID: 137038 RVA: 0x00961114 File Offset: 0x0095F314
		[NullableContext(1)]
		public BP_SM_ActionAddTagCount_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddTagCount_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x0602174F RID: 137039 RVA: 0x00961147 File Offset: 0x0095F347
		// (set) Token: 0x06021750 RID: 137040 RVA: 0x0096115B File Offset: 0x0095F35B
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x06021751 RID: 137041 RVA: 0x00961170 File Offset: 0x0095F370
		// (set) Token: 0x06021752 RID: 137042 RVA: 0x00961180 File Offset: 0x0095F380
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x06021753 RID: 137043 RVA: 0x00961191 File Offset: 0x0095F391
		protected BP_SM_ActionAddTagCount_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012494 RID: 74900
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C";

		// Token: 0x04012495 RID: 74901
		private static IntPtr _ClassPtr;

		// Token: 0x04012496 RID: 74902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012497 RID: 74903
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012498 RID: 74904
		internal static int __PropertyOffset_Count;
	}
}
