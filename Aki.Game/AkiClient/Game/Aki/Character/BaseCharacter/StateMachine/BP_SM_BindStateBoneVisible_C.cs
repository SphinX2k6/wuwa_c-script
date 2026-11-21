using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200338A RID: 13194
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_BindStateBoneVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217C8 RID: 137160 RVA: 0x00961E39 File Offset: 0x00960039
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBoneVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C");
			}
			return BP_SM_BindStateBoneVisible_C._ClassPtr;
		}

		// Token: 0x060217C9 RID: 137161 RVA: 0x00961E60 File Offset: 0x00960060
		public BP_SM_BindStateBoneVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217CA RID: 137162 RVA: 0x00961E88 File Offset: 0x00960088
		public BP_SM_BindStateBoneVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700449D RID: 17565
		// (get) Token: 0x060217CB RID: 137163 RVA: 0x00961EBB File Offset: 0x009600BB
		// (set) Token: 0x060217CC RID: 137164 RVA: 0x00961ECF File Offset: 0x009600CF
		public unsafe string 骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_骨骼名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_骨骼名)), value);
			}
		}

		// Token: 0x1700449E RID: 17566
		// (get) Token: 0x060217CD RID: 137165 RVA: 0x00961EE4 File Offset: 0x009600E4
		// (set) Token: 0x060217CE RID: 137166 RVA: 0x00961EF4 File Offset: 0x009600F4
		public unsafe bool 显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_显示) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_显示) = (value ? 1 : 0);
			}
		}

		// Token: 0x060217CF RID: 137167 RVA: 0x00961F05 File Offset: 0x00960105
		protected BP_SM_BindStateBoneVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124E5 RID: 74981
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C";

		// Token: 0x040124E6 RID: 74982
		private static IntPtr _ClassPtr;

		// Token: 0x040124E7 RID: 74983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124E8 RID: 74984
		internal static int __PropertyOffset_骨骼名;

		// Token: 0x040124E9 RID: 74985
		internal static int __PropertyOffset_显示;
	}
}
