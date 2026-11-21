using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001054 RID: 4180
	public class IDarkTideHaiweixiaArenaBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C24 RID: 23588 RVA: 0x000E0504 File Offset: 0x000DE704
		private IDarkTideHaiweixiaArenaBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideHaiweixiaArenaBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideHaiweixiaArenaBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideHaiweixiaArenaBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x000E053C File Offset: 0x000DE73C
		public static IDarkTideHaiweixiaArenaBossEvent Create([Nullable(2)] IDarkTideHaiweixiaArenaBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideHaiweixiaArenaBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x000E054F File Offset: 0x000DE74F
		public static IDarkTideHaiweixiaArenaBossEvent CreateFromSetValue([Nullable(2)] IDarkTideHaiweixiaArenaBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideHaiweixiaArenaBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x000E0562 File Offset: 0x000DE762
		public new IDarkTideHaiweixiaArenaBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideHaiweixiaArenaBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x000E0575 File Offset: 0x000DE775
		// (set) Token: 0x06005C29 RID: 23593 RVA: 0x000E05A0 File Offset: 0x000DE7A0
		public override EDarkTideBossEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400378C RID: 14220
		[Nullable(2)]
		protected new IDarkTideHaiweixiaArenaBossEvent FbInstance;

		// Token: 0x0400378D RID: 14221
		[Nullable(2)]
		protected new IDarkTideHaiweixiaArenaBossEvent_SetValue PocoInterface;
	}
}
