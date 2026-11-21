using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024EE RID: 9454
	public class WaitUntilLevelSequenceReachMark : ActionParams
	{
		// Token: 0x0600CD88 RID: 52616 RVA: 0x001D3F84 File Offset: 0x001D2184
		private WaitUntilLevelSequenceReachMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("WaitUntilLevelSequenceReachMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			WaitUntilLevelSequenceReachMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new WaitUntilLevelSequenceReachMark_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x001D3FBC File Offset: 0x001D21BC
		public static WaitUntilLevelSequenceReachMark Create([Nullable(2)] WaitUntilLevelSequenceReachMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitUntilLevelSequenceReachMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x001D3FCF File Offset: 0x001D21CF
		public static WaitUntilLevelSequenceReachMark CreateFromSetValue([Nullable(2)] WaitUntilLevelSequenceReachMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new WaitUntilLevelSequenceReachMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x001D3FE2 File Offset: 0x001D21E2
		public WaitUntilLevelSequenceReachMark_SetValue ToSetValue()
		{
			return new WaitUntilLevelSequenceReachMark_SetValue
			{
				EntityId = this.EntityId,
				Mark = this.Mark
			};
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x001D4001 File Offset: 0x001D2201
		// (set) Token: 0x0600CD8D RID: 52621 RVA: 0x001D402C File Offset: 0x001D222C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600CD8E RID: 52622 RVA: 0x001D403A File Offset: 0x001D223A
		// (set) Token: 0x0600CD8F RID: 52623 RVA: 0x001D4065 File Offset: 0x001D2265
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x040079B5 RID: 31157
		[Nullable(2)]
		protected new WaitUntilLevelSequenceReachMark FbInstance;

		// Token: 0x040079B6 RID: 31158
		[Nullable(2)]
		protected WaitUntilLevelSequenceReachMark_SetValue PocoInterface;
	}
}
