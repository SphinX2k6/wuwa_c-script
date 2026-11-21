using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002021 RID: 8225
	public class ISeasonLoopConfig
	{
		// Token: 0x0600AEA5 RID: 44709 RVA: 0x00189B94 File Offset: 0x00187D94
		private ISeasonLoopConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISeasonLoopConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISeasonLoopConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISeasonLoopConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x00189BCC File Offset: 0x00187DCC
		public static ISeasonLoopConfig Create([Nullable(2)] ISeasonLoopConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEA7 RID: 44711 RVA: 0x00189BDF File Offset: 0x00187DDF
		public static ISeasonLoopConfig CreateFromSetValue([Nullable(2)] ISeasonLoopConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEA8 RID: 44712 RVA: 0x00189BF2 File Offset: 0x00187DF2
		public ISeasonLoopConfig_SetValue ToSetValue()
		{
			return new ISeasonLoopConfig_SetValue
			{
				HoldTime = this.HoldTime,
				SwitchTime = this.SwitchTime
			};
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x00189C11 File Offset: 0x00187E11
		// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x00189C40 File Offset: 0x00187E40
		public virtual float HoldTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HoldTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.HoldTime;
			}
			set
			{
				this.GetOrCreatePoco().HoldTime = value;
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x00189C4E File Offset: 0x00187E4E
		// (set) Token: 0x0600AEAC RID: 44716 RVA: 0x00189C7D File Offset: 0x00187E7D
		public virtual float SwitchTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwitchTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SwitchTime;
			}
			set
			{
				this.GetOrCreatePoco().SwitchTime = value;
			}
		}

		// Token: 0x04006816 RID: 26646
		[Nullable(2)]
		protected ISeasonLoopConfig FbInstance;

		// Token: 0x04006817 RID: 26647
		[Nullable(2)]
		protected ISeasonLoopConfig_SetValue PocoInterface;
	}
}
