using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003393 RID: 13203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_BindStateMeshVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021806 RID: 137222 RVA: 0x00962578 File Offset: 0x00960778
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateMeshVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C");
			}
			return BP_SM_BindStateMeshVisible_C._ClassPtr;
		}

		// Token: 0x06021807 RID: 137223 RVA: 0x0096259C File Offset: 0x0096079C
		public BP_SM_BindStateMeshVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateMeshVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021808 RID: 137224 RVA: 0x009625C4 File Offset: 0x009607C4
		public BP_SM_BindStateMeshVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateMeshVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x06021809 RID: 137225 RVA: 0x009625F7 File Offset: 0x009607F7
		// (set) Token: 0x0602180A RID: 137226 RVA: 0x0096260B File Offset: 0x0096080B
		public unsafe string Tag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_Tag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_Tag)), value);
			}
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x0602180B RID: 137227 RVA: 0x00962620 File Offset: 0x00960820
		// (set) Token: 0x0602180C RID: 137228 RVA: 0x00962630 File Offset: 0x00960830
		public unsafe bool 显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_显示) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_显示) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x0602180D RID: 137229 RVA: 0x00962641 File Offset: 0x00960841
		// (set) Token: 0x0602180E RID: 137230 RVA: 0x00962651 File Offset: 0x00960851
		public unsafe bool 包含所有子节点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_包含所有子节点) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_包含所有子节点) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602180F RID: 137231 RVA: 0x00962662 File Offset: 0x00960862
		protected BP_SM_BindStateMeshVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012511 RID: 75025
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C";

		// Token: 0x04012512 RID: 75026
		private static IntPtr _ClassPtr;

		// Token: 0x04012513 RID: 75027
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012514 RID: 75028
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012515 RID: 75029
		internal static int __PropertyOffset_显示;

		// Token: 0x04012516 RID: 75030
		internal static int __PropertyOffset_包含所有子节点;
	}
}
