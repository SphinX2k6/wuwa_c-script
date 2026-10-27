using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004353 RID: 17235
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_Node.BP_FSM_Node_C")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class BP_FSM_Node_C : UKuroStateMachineBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB08 RID: 183048 RVA: 0x00A25E3A File Offset: 0x00A2403A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_Node_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_Node.BP_FSM_Node_C");
			}
			return BP_FSM_Node_C._ClassPtr;
		}

		// Token: 0x0602CB09 RID: 183049 RVA: 0x00A25E60 File Offset: 0x00A24060
		public BP_FSM_Node_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_Node_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB0A RID: 183050 RVA: 0x00A25E88 File Offset: 0x00A24088
		public BP_FSM_Node_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_Node_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007076 RID: 28790
		// (get) Token: 0x0602CB0B RID: 183051 RVA: 0x00A25EBB File Offset: 0x00A240BB
		// (set) Token: 0x0602CB0C RID: 183052 RVA: 0x00A25ECB File Offset: 0x00A240CB
		public unsafe int 技能Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007077 RID: 28791
		// (get) Token: 0x0602CB0D RID: 183053 RVA: 0x00A25EDC File Offset: 0x00A240DC
		// (set) Token: 0x0602CB0E RID: 183054 RVA: 0x00A25EEC File Offset: 0x00A240EC
		public unsafe float 持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007078 RID: 28792
		// (get) Token: 0x0602CB0F RID: 183055 RVA: 0x00A25F00 File Offset: 0x00A24100
		// (set) Token: 0x0602CB10 RID: 183056 RVA: 0x00A25F39 File Offset: 0x00A24139
		public TArray<long> 绑定Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._绑定Buff) == null)
				{
					result = (this._绑定Buff = new TArray<long>(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.绑定Buff.CopyAssign(value);
			}
		}

		// Token: 0x17007079 RID: 28793
		// (get) Token: 0x0602CB11 RID: 183057 RVA: 0x00A25F48 File Offset: 0x00A24148
		// (set) Token: 0x0602CB12 RID: 183058 RVA: 0x00A25F81 File Offset: 0x00A24181
		public TArray<long> 进入时添加Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._进入时添加Buff) == null)
				{
					result = (this._进入时添加Buff = new TArray<long>(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.进入时添加Buff.CopyAssign(value);
			}
		}

		// Token: 0x1700707A RID: 28794
		// (get) Token: 0x0602CB13 RID: 183059 RVA: 0x00A25F90 File Offset: 0x00A24190
		// (set) Token: 0x0602CB14 RID: 183060 RVA: 0x00A25FC9 File Offset: 0x00A241C9
		public TArray<long> 退出时添加Buff
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._退出时添加Buff) == null)
				{
					result = (this._退出时添加Buff = new TArray<long>(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.退出时添加Buff.CopyAssign(value);
			}
		}

		// Token: 0x1700707B RID: 28795
		// (get) Token: 0x0602CB15 RID: 183061 RVA: 0x00A25FD8 File Offset: 0x00A241D8
		// (set) Token: 0x0602CB16 RID: 183062 RVA: 0x00A26011 File Offset: 0x00A24211
		public TArray<FGameplayTag> 绑定Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._绑定Tag) == null)
				{
					result = (this._绑定Tag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FSM_Node_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.绑定Tag.CopyAssign(value);
			}
		}

		// Token: 0x0602CB17 RID: 183063 RVA: 0x00A2601F File Offset: 0x00A2421F
		protected BP_FSM_Node_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178F8 RID: 96504
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_Node.BP_FSM_Node_C";

		// Token: 0x040178F9 RID: 96505
		private static IntPtr _ClassPtr;

		// Token: 0x040178FA RID: 96506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178FB RID: 96507
		internal static int __PropertyOffset_0;

		// Token: 0x040178FC RID: 96508
		internal static int __PropertyOffset_1;

		// Token: 0x040178FD RID: 96509
		internal static int __PropertyOffset_2;

		// Token: 0x040178FE RID: 96510
		[Nullable(2)]
		private TArray<long> _绑定Buff;

		// Token: 0x040178FF RID: 96511
		internal static int __PropertyOffset_3;

		// Token: 0x04017900 RID: 96512
		[Nullable(2)]
		private TArray<long> _进入时添加Buff;

		// Token: 0x04017901 RID: 96513
		internal static int __PropertyOffset_4;

		// Token: 0x04017902 RID: 96514
		[Nullable(2)]
		private TArray<long> _退出时添加Buff;

		// Token: 0x04017903 RID: 96515
		internal static int __PropertyOffset_5;

		// Token: 0x04017904 RID: 96516
		[Nullable(2)]
		private TArray<FGameplayTag> _绑定Tag;
	}
}
