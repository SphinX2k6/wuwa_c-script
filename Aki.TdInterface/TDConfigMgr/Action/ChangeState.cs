using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001641 RID: 5697
	public class ChangeState : ActionParams
	{
		// Token: 0x06008097 RID: 32919 RVA: 0x00132054 File Offset: 0x00130254
		private ChangeState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeState_SetValue());
			}
			return result;
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x0013208C File Offset: 0x0013028C
		public static ChangeState Create([Nullable(2)] ChangeState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x0013209F File Offset: 0x0013029F
		public static ChangeState CreateFromSetValue([Nullable(2)] ChangeState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x001320B2 File Offset: 0x001302B2
		public ChangeState_SetValue ToSetValue()
		{
			return new ChangeState_SetValue
			{
				StateId = this.StateId
			};
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x001320C5 File Offset: 0x001302C5
		// (set) Token: 0x0600809C RID: 32924 RVA: 0x001320F0 File Offset: 0x001302F0
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x04004A3B RID: 19003
		[Nullable(2)]
		protected new ChangeState FbInstance;

		// Token: 0x04004A3C RID: 19004
		[Nullable(2)]
		protected ChangeState_SetValue PocoInterface;
	}
}
