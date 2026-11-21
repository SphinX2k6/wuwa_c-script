using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200161D RID: 5661
	public class ChangeActorState : ActionParams
	{
		// Token: 0x06007FE3 RID: 32739 RVA: 0x00130D7C File Offset: 0x0012EF7C
		private ChangeActorState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeActorState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeActorState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeActorState_SetValue());
			}
			return result;
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x00130DB4 File Offset: 0x0012EFB4
		public static ChangeActorState Create([Nullable(2)] ChangeActorState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeActorState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x00130DC7 File Offset: 0x0012EFC7
		public static ChangeActorState CreateFromSetValue([Nullable(2)] ChangeActorState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeActorState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00130DDA File Offset: 0x0012EFDA
		public ChangeActorState_SetValue ToSetValue()
		{
			return new ChangeActorState_SetValue
			{
				State = this.State
			};
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x06007FE7 RID: 32743 RVA: 0x00130DED File Offset: 0x0012EFED
		// (set) Token: 0x06007FE8 RID: 32744 RVA: 0x00130E18 File Offset: 0x0012F018
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x040049ED RID: 18925
		[Nullable(2)]
		protected new ChangeActorState FbInstance;

		// Token: 0x040049EE RID: 18926
		[Nullable(2)]
		protected ChangeActorState_SetValue PocoInterface;
	}
}
