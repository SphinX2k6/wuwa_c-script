using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339A RID: 13210
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionBuffStack_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602184A RID: 137290 RVA: 0x00962C5B File Offset: 0x00960E5B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionBuffStack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C");
			}
			return BP_SM_ConditionBuffStack_C._ClassPtr;
		}

		// Token: 0x0602184B RID: 137291 RVA: 0x00962C80 File Offset: 0x00960E80
		public BP_SM_ConditionBuffStack_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionBuffStack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602184C RID: 137292 RVA: 0x00962CA8 File Offset: 0x00960EA8
		[NullableContext(1)]
		public BP_SM_ConditionBuffStack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionBuffStack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044BE RID: 17598
		// (get) Token: 0x0602184D RID: 137293 RVA: 0x00962CDB File Offset: 0x00960EDB
		// (set) Token: 0x0602184E RID: 137294 RVA: 0x00962CEB File Offset: 0x00960EEB
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_BuffId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_BuffId) = value;
			}
		}

		// Token: 0x170044BF RID: 17599
		// (get) Token: 0x0602184F RID: 137295 RVA: 0x00962CFC File Offset: 0x00960EFC
		// (set) Token: 0x06021850 RID: 137296 RVA: 0x00962D0C File Offset: 0x00960F0C
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x06021851 RID: 137297 RVA: 0x00962D1D File Offset: 0x00960F1D
		// (set) Token: 0x06021852 RID: 137298 RVA: 0x00962D2D File Offset: 0x00960F2D
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06021853 RID: 137299 RVA: 0x00962D3E File Offset: 0x00960F3E
		protected BP_SM_ConditionBuffStack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401253B RID: 75067
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C";

		// Token: 0x0401253C RID: 75068
		private static IntPtr _ClassPtr;

		// Token: 0x0401253D RID: 75069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401253E RID: 75070
		internal static int __PropertyOffset_BuffId;

		// Token: 0x0401253F RID: 75071
		internal static int __PropertyOffset_Min;

		// Token: 0x04012540 RID: 75072
		internal static int __PropertyOffset_Max;
	}
}
