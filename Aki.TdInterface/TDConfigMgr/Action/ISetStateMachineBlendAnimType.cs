using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002079 RID: 8313
	public class ISetStateMachineBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600B07F RID: 45183 RVA: 0x0018D3B8 File Offset: 0x0018B5B8
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

		// Token: 0x0600B080 RID: 45184 RVA: 0x0018D3F0 File Offset: 0x0018B5F0
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

		// Token: 0x0600B081 RID: 45185 RVA: 0x0018D403 File Offset: 0x0018B603
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

		// Token: 0x0600B082 RID: 45186 RVA: 0x0018D416 File Offset: 0x0018B616
		public new ISetStateMachineBlendAnimType_SetValue ToSetValue()
		{
			return new ISetStateMachineBlendAnimType_SetValue
			{
				Type = this.Type,
				State = this.State
			};
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x0018D435 File Offset: 0x0018B635
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x0018D460 File Offset: 0x0018B660
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

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x0018D46E File Offset: 0x0018B66E
		// (set) Token: 0x0600B086 RID: 45190 RVA: 0x0018D499 File Offset: 0x0018B699
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

		// Token: 0x040068FD RID: 26877
		[Nullable(2)]
		protected new ISetStateMachineBlendAnimType FbInstance;

		// Token: 0x040068FE RID: 26878
		[Nullable(2)]
		protected new ISetStateMachineBlendAnimType_SetValue PocoInterface;
	}
}
