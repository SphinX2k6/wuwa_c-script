using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AC RID: 13228
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_ConditionTimer_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218C4 RID: 137412 RVA: 0x00963980 File Offset: 0x00961B80
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTimer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C");
			}
			return BP_SM_ConditionTimer_C._ClassPtr;
		}

		// Token: 0x060218C5 RID: 137413 RVA: 0x009639A4 File Offset: 0x00961BA4
		public BP_SM_ConditionTimer_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTimer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218C6 RID: 137414 RVA: 0x009639CC File Offset: 0x00961BCC
		[NullableContext(1)]
		public BP_SM_ConditionTimer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTimer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x060218C7 RID: 137415 RVA: 0x009639FF File Offset: 0x00961BFF
		// (set) Token: 0x060218C8 RID: 137416 RVA: 0x00963A0F File Offset: 0x00961C0F
		public unsafe int MinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_MinTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_MinTime) = value;
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x060218C9 RID: 137417 RVA: 0x00963A20 File Offset: 0x00961C20
		// (set) Token: 0x060218CA RID: 137418 RVA: 0x00963A30 File Offset: 0x00961C30
		public unsafe int MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_MaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_MaxTime) = value;
			}
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x060218CB RID: 137419 RVA: 0x00963A41 File Offset: 0x00961C41
		// (set) Token: 0x060218CC RID: 137420 RVA: 0x00963A51 File Offset: 0x00961C51
		public unsafe bool IsClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_IsClient) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTimer_C.__PropertyOffset_IsClient) = (value ? 1 : 0);
			}
		}

		// Token: 0x060218CD RID: 137421 RVA: 0x00963A62 File Offset: 0x00961C62
		protected BP_SM_ConditionTimer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401258A RID: 75146
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTimer.BP_SM_ConditionTimer_C";

		// Token: 0x0401258B RID: 75147
		private static IntPtr _ClassPtr;

		// Token: 0x0401258C RID: 75148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401258D RID: 75149
		internal static int __PropertyOffset_MinTime;

		// Token: 0x0401258E RID: 75150
		internal static int __PropertyOffset_MaxTime;

		// Token: 0x0401258F RID: 75151
		internal static int __PropertyOffset_IsClient;
	}
}
