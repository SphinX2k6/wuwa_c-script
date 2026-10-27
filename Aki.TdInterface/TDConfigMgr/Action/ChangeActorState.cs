using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014C4 RID: 5316
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeActorState : ActionParams
	{
		// Token: 0x06007916 RID: 30998 RVA: 0x00122130 File Offset: 0x00120330
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

		// Token: 0x06007917 RID: 30999 RVA: 0x00122168 File Offset: 0x00120368
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

		// Token: 0x06007918 RID: 31000 RVA: 0x0012217B File Offset: 0x0012037B
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

		// Token: 0x06007919 RID: 31001 RVA: 0x0012218E File Offset: 0x0012038E
		public ChangeActorState_SetValue ToSetValue()
		{
			return new ChangeActorState_SetValue
			{
				State = this.State
			};
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x001221A1 File Offset: 0x001203A1
		// (set) Token: 0x0600791B RID: 31003 RVA: 0x001221CC File Offset: 0x001203CC
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

		// Token: 0x04004652 RID: 18002
		[Nullable(2)]
		protected new ChangeActorState FbInstance;

		// Token: 0x04004653 RID: 18003
		[Nullable(2)]
		protected ChangeActorState_SetValue PocoInterface;
	}
}
