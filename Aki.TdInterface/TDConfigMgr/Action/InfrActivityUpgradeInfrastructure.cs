using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E55 RID: 7765
	public class InfrActivityUpgradeInfrastructure : ActionParams
	{
		// Token: 0x0600A511 RID: 42257 RVA: 0x00178B28 File Offset: 0x00176D28
		private InfrActivityUpgradeInfrastructure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("InfrActivityUpgradeInfrastructure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			InfrActivityUpgradeInfrastructure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new InfrActivityUpgradeInfrastructure_SetValue());
			}
			return result;
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x00178B60 File Offset: 0x00176D60
		public static InfrActivityUpgradeInfrastructure Create([Nullable(2)] InfrActivityUpgradeInfrastructure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InfrActivityUpgradeInfrastructure
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x00178B73 File Offset: 0x00176D73
		public static InfrActivityUpgradeInfrastructure CreateFromSetValue([Nullable(2)] InfrActivityUpgradeInfrastructure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new InfrActivityUpgradeInfrastructure
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x00178B86 File Offset: 0x00176D86
		public InfrActivityUpgradeInfrastructure_SetValue ToSetValue()
		{
			return new InfrActivityUpgradeInfrastructure_SetValue
			{
				Level = this.Level
			};
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A515 RID: 42261 RVA: 0x00178B99 File Offset: 0x00176D99
		// (set) Token: 0x0600A516 RID: 42262 RVA: 0x00178BC4 File Offset: 0x00176DC4
		public virtual int Level
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Level;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Level;
			}
			set
			{
				this.GetOrCreatePoco().Level = value;
			}
		}

		// Token: 0x040063BE RID: 25534
		[Nullable(2)]
		protected new InfrActivityUpgradeInfrastructure FbInstance;

		// Token: 0x040063BF RID: 25535
		[Nullable(2)]
		protected InfrActivityUpgradeInfrastructure_SetValue PocoInterface;
	}
}
