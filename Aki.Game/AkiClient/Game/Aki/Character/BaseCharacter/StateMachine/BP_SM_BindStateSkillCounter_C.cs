using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003396 RID: 13206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 89)]
	public class BP_SM_BindStateSkillCounter_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021820 RID: 137248 RVA: 0x0096283A File Offset: 0x00960A3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateSkillCounter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C");
			}
			return BP_SM_BindStateSkillCounter_C._ClassPtr;
		}

		// Token: 0x06021821 RID: 137249 RVA: 0x00962860 File Offset: 0x00960A60
		public BP_SM_BindStateSkillCounter_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateSkillCounter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021822 RID: 137250 RVA: 0x00962888 File Offset: 0x00960A88
		public BP_SM_BindStateSkillCounter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateSkillCounter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x06021823 RID: 137251 RVA: 0x009628BC File Offset: 0x00960ABC
		// (set) Token: 0x06021824 RID: 137252 RVA: 0x009628F5 File Offset: 0x00960AF5
		public TArray<int> SkillIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkillIds) == null)
				{
					result = (this._SkillIds = new TArray<int>(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_SkillIds, this));
				}
				return result;
			}
			set
			{
				this.SkillIds.CopyAssign(value);
			}
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x06021825 RID: 137253 RVA: 0x00962903 File Offset: 0x00960B03
		// (set) Token: 0x06021826 RID: 137254 RVA: 0x00962917 File Offset: 0x00960B17
		public unsafe string 黑板Key
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_黑板Key)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_黑板Key)), value);
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x06021827 RID: 137255 RVA: 0x0096292C File Offset: 0x00960B2C
		// (set) Token: 0x06021828 RID: 137256 RVA: 0x0096293C File Offset: 0x00960B3C
		public unsafe int 增加值Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_增加值Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_增加值Min) = value;
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x06021829 RID: 137257 RVA: 0x0096294D File Offset: 0x00960B4D
		// (set) Token: 0x0602182A RID: 137258 RVA: 0x0096295D File Offset: 0x00960B5D
		public unsafe int 增加值Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_增加值Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_增加值Max) = value;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x0602182B RID: 137259 RVA: 0x0096296E File Offset: 0x00960B6E
		// (set) Token: 0x0602182C RID: 137260 RVA: 0x0096297E File Offset: 0x00960B7E
		public unsafe bool 重置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_重置) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateSkillCounter_C.__PropertyOffset_重置) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602182D RID: 137261 RVA: 0x0096298F File Offset: 0x00960B8F
		protected BP_SM_BindStateSkillCounter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012521 RID: 75041
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateSkillCounter.BP_SM_BindStateSkillCounter_C";

		// Token: 0x04012522 RID: 75042
		private static IntPtr _ClassPtr;

		// Token: 0x04012523 RID: 75043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012524 RID: 75044
		internal static int __PropertyOffset_SkillIds;

		// Token: 0x04012525 RID: 75045
		[Nullable(2)]
		private TArray<int> _SkillIds;

		// Token: 0x04012526 RID: 75046
		internal static int __PropertyOffset_黑板Key;

		// Token: 0x04012527 RID: 75047
		internal static int __PropertyOffset_增加值Min;

		// Token: 0x04012528 RID: 75048
		internal static int __PropertyOffset_增加值Max;

		// Token: 0x04012529 RID: 75049
		internal static int __PropertyOffset_重置;
	}
}
