using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002281 RID: 8833
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitUntilLevelSequenceReachMark : ActionParams
	{
		// Token: 0x0600C1C2 RID: 49602 RVA: 0x001BC800 File Offset: 0x001BAA00
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

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x001BC838 File Offset: 0x001BAA38
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

		// Token: 0x0600C1C4 RID: 49604 RVA: 0x001BC84B File Offset: 0x001BAA4B
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

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x001BC85E File Offset: 0x001BAA5E
		public WaitUntilLevelSequenceReachMark_SetValue ToSetValue()
		{
			return new WaitUntilLevelSequenceReachMark_SetValue
			{
				EntityId = this.EntityId,
				Mark = this.Mark
			};
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600C1C6 RID: 49606 RVA: 0x001BC87D File Offset: 0x001BAA7D
		// (set) Token: 0x0600C1C7 RID: 49607 RVA: 0x001BC8A8 File Offset: 0x001BAAA8
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

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600C1C8 RID: 49608 RVA: 0x001BC8B6 File Offset: 0x001BAAB6
		// (set) Token: 0x0600C1C9 RID: 49609 RVA: 0x001BC8E1 File Offset: 0x001BAAE1
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

		// Token: 0x04007368 RID: 29544
		[Nullable(2)]
		protected new WaitUntilLevelSequenceReachMark FbInstance;

		// Token: 0x04007369 RID: 29545
		[Nullable(2)]
		protected WaitUntilLevelSequenceReachMark_SetValue PocoInterface;
	}
}
