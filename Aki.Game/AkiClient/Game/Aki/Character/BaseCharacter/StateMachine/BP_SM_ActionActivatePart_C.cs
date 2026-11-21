using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003375 RID: 13173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_ActionActivatePart_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021736 RID: 137014 RVA: 0x00960E7C File Offset: 0x0095F07C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionActivatePart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C");
			}
			return BP_SM_ActionActivatePart_C._ClassPtr;
		}

		// Token: 0x06021737 RID: 137015 RVA: 0x00960EA0 File Offset: 0x0095F0A0
		public BP_SM_ActionActivatePart_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivatePart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021738 RID: 137016 RVA: 0x00960EC8 File Offset: 0x0095F0C8
		public BP_SM_ActionActivatePart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivatePart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x06021739 RID: 137017 RVA: 0x00960EFB File Offset: 0x0095F0FB
		// (set) Token: 0x0602173A RID: 137018 RVA: 0x00960F0F File Offset: 0x0095F10F
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x0602173B RID: 137019 RVA: 0x00960F24 File Offset: 0x0095F124
		// (set) Token: 0x0602173C RID: 137020 RVA: 0x00960F34 File Offset: 0x0095F134
		public unsafe bool 激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_激活) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_激活) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602173D RID: 137021 RVA: 0x00960F45 File Offset: 0x0095F145
		protected BP_SM_ActionActivatePart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012486 RID: 74886
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C";

		// Token: 0x04012487 RID: 74887
		private static IntPtr _ClassPtr;

		// Token: 0x04012488 RID: 74888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012489 RID: 74889
		internal static int __PropertyOffset_部位名;

		// Token: 0x0401248A RID: 74890
		internal static int __PropertyOffset_激活;
	}
}
