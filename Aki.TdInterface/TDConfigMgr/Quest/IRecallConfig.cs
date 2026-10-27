using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DE RID: 4318
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConfig
	{
		// Token: 0x060061AC RID: 25004 RVA: 0x000EBB2C File Offset: 0x000E9D2C
		private IRecallConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x000EBB64 File Offset: 0x000E9D64
		public static IRecallConfig Create([Nullable(2)] IRecallConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x000EBB77 File Offset: 0x000E9D77
		public static IRecallConfig CreateFromSetValue([Nullable(2)] IRecallConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x000EBB8A File Offset: 0x000E9D8A
		public IRecallConfig_SetValue ToSetValue()
		{
			return new IRecallConfig_SetValue
			{
				RecallId = this.RecallId
			};
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x000EBB9D File Offset: 0x000E9D9D
		// (set) Token: 0x060061B1 RID: 25009 RVA: 0x000EBBC8 File Offset: 0x000E9DC8
		public virtual int RecallId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RecallId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RecallId;
			}
			set
			{
				this.GetOrCreatePoco().RecallId = value;
			}
		}

		// Token: 0x04003AC2 RID: 15042
		[Nullable(2)]
		protected IRecallConfig FbInstance;

		// Token: 0x04003AC3 RID: 15043
		[Nullable(2)]
		protected IRecallConfig_SetValue PocoInterface;
	}
}
