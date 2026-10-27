using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E44 RID: 7748
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetStateMachineBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600A5C7 RID: 42439 RVA: 0x001776B8 File Offset: 0x001758B8
		private ISetStateMachineBlendAnimType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetStateMachineBlendAnimType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetStateMachineBlendAnimType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetStateMachineBlendAnimType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x001776F0 File Offset: 0x001758F0
		public static ISetStateMachineBlendAnimType Create([Nullable(2)] ISetStateMachineBlendAnimType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetStateMachineBlendAnimType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x00177703 File Offset: 0x00175903
		public static ISetStateMachineBlendAnimType CreateFromSetValue([Nullable(2)] ISetStateMachineBlendAnimType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetStateMachineBlendAnimType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x00177716 File Offset: 0x00175916
		public new ISetStateMachineBlendAnimType_SetValue ToSetValue()
		{
			return new ISetStateMachineBlendAnimType_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x00177735 File Offset: 0x00175935
		// (set) Token: 0x0600A5CC RID: 42444 RVA: 0x00177760 File Offset: 0x00175960
		public override EBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimType.StateMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x0017776E File Offset: 0x0017596E
		// (set) Token: 0x0600A5CE RID: 42446 RVA: 0x00177799 File Offset: 0x00175999
		public virtual EBlendAnimState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimState.CombatIdle;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04006319 RID: 25369
		[Nullable(2)]
		protected new ISetStateMachineBlendAnimType FbInstance;

		// Token: 0x0400631A RID: 25370
		[Nullable(2)]
		protected new ISetStateMachineBlendAnimType_SetValue PocoInterface;
	}
}
