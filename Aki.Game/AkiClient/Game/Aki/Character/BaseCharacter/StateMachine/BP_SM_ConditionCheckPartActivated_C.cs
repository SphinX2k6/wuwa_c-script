using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A0 RID: 13216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckPartActivated_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602186C RID: 137324 RVA: 0x00963045 File Offset: 0x00961245
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckPartActivated_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C");
			}
			return BP_SM_ConditionCheckPartActivated_C._ClassPtr;
		}

		// Token: 0x0602186D RID: 137325 RVA: 0x0096306C File Offset: 0x0096126C
		public BP_SM_ConditionCheckPartActivated_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPartActivated_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602186E RID: 137326 RVA: 0x00963094 File Offset: 0x00961294
		public BP_SM_ConditionCheckPartActivated_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPartActivated_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C3 RID: 17603
		// (get) Token: 0x0602186F RID: 137327 RVA: 0x009630C7 File Offset: 0x009612C7
		// (set) Token: 0x06021870 RID: 137328 RVA: 0x009630DB File Offset: 0x009612DB
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckPartActivated_C.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckPartActivated_C.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x06021871 RID: 137329 RVA: 0x009630F0 File Offset: 0x009612F0
		protected BP_SM_ConditionCheckPartActivated_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012552 RID: 75090
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C";

		// Token: 0x04012553 RID: 75091
		private static IntPtr _ClassPtr;

		// Token: 0x04012554 RID: 75092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012555 RID: 75093
		internal static int __PropertyOffset_部位名;
	}
}
