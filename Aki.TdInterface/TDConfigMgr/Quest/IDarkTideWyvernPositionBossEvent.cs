using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200105E RID: 4190
	public class IDarkTideWyvernPositionBossEvent : IDarkTideBossEvent
	{
		// Token: 0x06005C4E RID: 23630 RVA: 0x000E0934 File Offset: 0x000DEB34
		private IDarkTideWyvernPositionBossEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDarkTideWyvernPositionBossEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDarkTideWyvernPositionBossEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDarkTideWyvernPositionBossEvent_SetValue());
			}
			return result;
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x000E096C File Offset: 0x000DEB6C
		public static IDarkTideWyvernPositionBossEvent Create([Nullable(2)] IDarkTideWyvernPositionBossEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideWyvernPositionBossEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x000E097F File Offset: 0x000DEB7F
		public static IDarkTideWyvernPositionBossEvent CreateFromSetValue([Nullable(2)] IDarkTideWyvernPositionBossEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDarkTideWyvernPositionBossEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x000E0992 File Offset: 0x000DEB92
		public new IDarkTideWyvernPositionBossEvent_SetValue ToSetValue()
		{
			return new IDarkTideWyvernPositionBossEvent_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x000E09A5 File Offset: 0x000DEBA5
		// (set) Token: 0x06005C53 RID: 23635 RVA: 0x000E09D0 File Offset: 0x000DEBD0
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

		// Token: 0x0400379E RID: 14238
		[Nullable(2)]
		protected new IDarkTideWyvernPositionBossEvent FbInstance;

		// Token: 0x0400379F RID: 14239
		[Nullable(2)]
		protected new IDarkTideWyvernPositionBossEvent_SetValue PocoInterface;
	}
}
