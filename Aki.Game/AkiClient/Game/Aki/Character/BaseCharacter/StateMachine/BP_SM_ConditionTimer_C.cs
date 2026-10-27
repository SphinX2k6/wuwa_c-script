using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438B RID: 17291
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_ConditionTimer_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCA6 RID: 183462 RVA: 0x00A28B2C File Offset: 0x00A26D2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTimer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C");
			}
			return BP_SM_ConditionTimer_C._ClassPtr;
		}

		// Token: 0x0602CCA7 RID: 183463 RVA: 0x00A28B50 File Offset: 0x00A26D50
		public BP_SM_ConditionTimer_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTimer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCA8 RID: 183464 RVA: 0x00A28B78 File Offset: 0x00A26D78
		[NullableContext(1)]
		public BP_SM_ConditionTimer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTimer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D5 RID: 28885
		// (get) Token: 0x0602CCA9 RID: 183465 RVA: 0x00A28BAB File Offset: 0x00A26DAB
		// (set) Token: 0x0602CCAA RID: 183466 RVA: 0x00A28BBB File Offset: 0x00A26DBB
		public unsafe int MinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070D6 RID: 28886
		// (get) Token: 0x0602CCAB RID: 183467 RVA: 0x00A28BCC File Offset: 0x00A26DCC
		// (set) Token: 0x0602CCAC RID: 183468 RVA: 0x00A28BDC File Offset: 0x00A26DDC
		public unsafe int MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070D7 RID: 28887
		// (get) Token: 0x0602CCAD RID: 183469 RVA: 0x00A28BED File Offset: 0x00A26DED
		// (set) Token: 0x0602CCAE RID: 183470 RVA: 0x00A28BFD File Offset: 0x00A26DFD
		public unsafe bool IsClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CCAF RID: 183471 RVA: 0x00A28C0E File Offset: 0x00A26E0E
		protected BP_SM_ConditionTimer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A09 RID: 96777
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C";

		// Token: 0x04017A0A RID: 96778
		private static IntPtr _ClassPtr;

		// Token: 0x04017A0B RID: 96779
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A0C RID: 96780
		internal static int __PropertyOffset_0;

		// Token: 0x04017A0D RID: 96781
		internal static int __PropertyOffset_1;

		// Token: 0x04017A0E RID: 96782
		internal static int __PropertyOffset_2;
	}
}
