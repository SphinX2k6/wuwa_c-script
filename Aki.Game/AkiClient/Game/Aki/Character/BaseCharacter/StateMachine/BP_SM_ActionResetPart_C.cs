using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004361 RID: 17249
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_ActionResetPart_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB6A RID: 183146 RVA: 0x00A2696E File Offset: 0x00A24B6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionResetPart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C");
			}
			return BP_SM_ActionResetPart_C._ClassPtr;
		}

		// Token: 0x0602CB6B RID: 183147 RVA: 0x00A26994 File Offset: 0x00A24B94
		public BP_SM_ActionResetPart_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetPart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB6C RID: 183148 RVA: 0x00A269BC File Offset: 0x00A24BBC
		public BP_SM_ActionResetPart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionResetPart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700708B RID: 28811
		// (get) Token: 0x0602CB6D RID: 183149 RVA: 0x00A269EF File Offset: 0x00A24BEF
		// (set) Token: 0x0602CB6E RID: 183150 RVA: 0x00A26A03 File Offset: 0x00A24C03
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700708C RID: 28812
		// (get) Token: 0x0602CB6F RID: 183151 RVA: 0x00A26A18 File Offset: 0x00A24C18
		// (set) Token: 0x0602CB70 RID: 183152 RVA: 0x00A26A28 File Offset: 0x00A24C28
		public unsafe bool 重置激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700708D RID: 28813
		// (get) Token: 0x0602CB71 RID: 183153 RVA: 0x00A26A39 File Offset: 0x00A24C39
		// (set) Token: 0x0602CB72 RID: 183154 RVA: 0x00A26A49 File Offset: 0x00A24C49
		public unsafe bool 重置血量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionResetPart_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CB73 RID: 183155 RVA: 0x00A26A5A File Offset: 0x00A24C5A
		protected BP_SM_ActionResetPart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401793C RID: 96572
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionResetPart.BP_SM_ActionResetPart_C";

		// Token: 0x0401793D RID: 96573
		private static IntPtr _ClassPtr;

		// Token: 0x0401793E RID: 96574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401793F RID: 96575
		internal static int __PropertyOffset_0;

		// Token: 0x04017940 RID: 96576
		internal static int __PropertyOffset_1;

		// Token: 0x04017941 RID: 96577
		internal static int __PropertyOffset_2;
	}
}
