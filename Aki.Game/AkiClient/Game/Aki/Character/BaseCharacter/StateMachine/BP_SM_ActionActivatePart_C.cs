using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004354 RID: 17236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_ActionActivatePart_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB18 RID: 183064 RVA: 0x00A26028 File Offset: 0x00A24228
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionActivatePart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C");
			}
			return BP_SM_ActionActivatePart_C._ClassPtr;
		}

		// Token: 0x0602CB19 RID: 183065 RVA: 0x00A2604C File Offset: 0x00A2424C
		public BP_SM_ActionActivatePart_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivatePart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB1A RID: 183066 RVA: 0x00A26074 File Offset: 0x00A24274
		public BP_SM_ActionActivatePart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionActivatePart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700707C RID: 28796
		// (get) Token: 0x0602CB1B RID: 183067 RVA: 0x00A260A7 File Offset: 0x00A242A7
		// (set) Token: 0x0602CB1C RID: 183068 RVA: 0x00A260BB File Offset: 0x00A242BB
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700707D RID: 28797
		// (get) Token: 0x0602CB1D RID: 183069 RVA: 0x00A260D0 File Offset: 0x00A242D0
		// (set) Token: 0x0602CB1E RID: 183070 RVA: 0x00A260E0 File Offset: 0x00A242E0
		public unsafe bool 激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionActivatePart_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CB1F RID: 183071 RVA: 0x00A260F1 File Offset: 0x00A242F1
		protected BP_SM_ActionActivatePart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017905 RID: 96517
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionActivatePart.BP_SM_ActionActivatePart_C";

		// Token: 0x04017906 RID: 96518
		private static IntPtr _ClassPtr;

		// Token: 0x04017907 RID: 96519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017908 RID: 96520
		internal static int __PropertyOffset_0;

		// Token: 0x04017909 RID: 96521
		internal static int __PropertyOffset_1;
	}
}
