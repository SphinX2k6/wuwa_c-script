using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200437F RID: 17279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionCheckPartActivated_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC4E RID: 183374 RVA: 0x00A281F1 File Offset: 0x00A263F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckPartActivated_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C");
			}
			return BP_SM_ConditionCheckPartActivated_C._ClassPtr;
		}

		// Token: 0x0602CC4F RID: 183375 RVA: 0x00A28218 File Offset: 0x00A26418
		public BP_SM_ConditionCheckPartActivated_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPartActivated_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC50 RID: 183376 RVA: 0x00A28240 File Offset: 0x00A26440
		public BP_SM_ConditionCheckPartActivated_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckPartActivated_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070C1 RID: 28865
		// (get) Token: 0x0602CC51 RID: 183377 RVA: 0x00A28273 File Offset: 0x00A26473
		// (set) Token: 0x0602CC52 RID: 183378 RVA: 0x00A28287 File Offset: 0x00A26487
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckPartActivated_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionCheckPartActivated_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602CC53 RID: 183379 RVA: 0x00A2829C File Offset: 0x00A2649C
		protected BP_SM_ConditionCheckPartActivated_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179D1 RID: 96721
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckPartActivated.BP_SM_ConditionCheckPartActivated_C";

		// Token: 0x040179D2 RID: 96722
		private static IntPtr _ClassPtr;

		// Token: 0x040179D3 RID: 96723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179D4 RID: 96724
		internal static int __PropertyOffset_0;
	}
}
