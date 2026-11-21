using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120C RID: 4620
	public class IRecallConfig
	{
		// Token: 0x060067A5 RID: 26533 RVA: 0x000F8C4C File Offset: 0x000F6E4C
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

		// Token: 0x060067A6 RID: 26534 RVA: 0x000F8C84 File Offset: 0x000F6E84
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

		// Token: 0x060067A7 RID: 26535 RVA: 0x000F8C97 File Offset: 0x000F6E97
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

		// Token: 0x060067A8 RID: 26536 RVA: 0x000F8CAA File Offset: 0x000F6EAA
		public IRecallConfig_SetValue ToSetValue()
		{
			return new IRecallConfig_SetValue
			{
				RecallId = this.RecallId
			};
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x000F8CBD File Offset: 0x000F6EBD
		// (set) Token: 0x060067AA RID: 26538 RVA: 0x000F8CE8 File Offset: 0x000F6EE8
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

		// Token: 0x04003E0F RID: 15887
		[Nullable(2)]
		protected IRecallConfig FbInstance;

		// Token: 0x04003E10 RID: 15888
		[Nullable(2)]
		protected IRecallConfig_SetValue PocoInterface;
	}
}
