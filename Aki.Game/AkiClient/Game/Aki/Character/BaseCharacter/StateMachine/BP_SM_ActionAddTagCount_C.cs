using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004357 RID: 17239
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class BP_SM_ActionAddTagCount_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB2E RID: 183086 RVA: 0x00A26271 File Offset: 0x00A24471
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionAddTagCount_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C");
			}
			return BP_SM_ActionAddTagCount_C._ClassPtr;
		}

		// Token: 0x0602CB2F RID: 183087 RVA: 0x00A26298 File Offset: 0x00A24498
		public BP_SM_ActionAddTagCount_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddTagCount_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB30 RID: 183088 RVA: 0x00A262C0 File Offset: 0x00A244C0
		[NullableContext(1)]
		public BP_SM_ActionAddTagCount_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionAddTagCount_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007081 RID: 28801
		// (get) Token: 0x0602CB31 RID: 183089 RVA: 0x00A262F3 File Offset: 0x00A244F3
		// (set) Token: 0x0602CB32 RID: 183090 RVA: 0x00A26307 File Offset: 0x00A24507
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007082 RID: 28802
		// (get) Token: 0x0602CB33 RID: 183091 RVA: 0x00A2631C File Offset: 0x00A2451C
		// (set) Token: 0x0602CB34 RID: 183092 RVA: 0x00A2632C File Offset: 0x00A2452C
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionAddTagCount_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602CB35 RID: 183093 RVA: 0x00A2633D File Offset: 0x00A2453D
		protected BP_SM_ActionAddTagCount_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017913 RID: 96531
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionAddTagCount.BP_SM_ActionAddTagCount_C";

		// Token: 0x04017914 RID: 96532
		private static IntPtr _ClassPtr;

		// Token: 0x04017915 RID: 96533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017916 RID: 96534
		internal static int __PropertyOffset_0;

		// Token: 0x04017917 RID: 96535
		internal static int __PropertyOffset_1;
	}
}
