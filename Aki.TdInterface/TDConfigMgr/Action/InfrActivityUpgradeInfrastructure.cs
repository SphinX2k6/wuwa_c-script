using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5C RID: 7260
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrActivityUpgradeInfrastructure : ActionParams
	{
		// Token: 0x06009BB1 RID: 39857 RVA: 0x0016572C File Offset: 0x0016392C
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

		// Token: 0x06009BB2 RID: 39858 RVA: 0x00165764 File Offset: 0x00163964
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

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00165777 File Offset: 0x00163977
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

		// Token: 0x06009BB4 RID: 39860 RVA: 0x0016578A File Offset: 0x0016398A
		public InfrActivityUpgradeInfrastructure_SetValue ToSetValue()
		{
			return new InfrActivityUpgradeInfrastructure_SetValue
			{
				Level = this.Level
			};
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009BB5 RID: 39861 RVA: 0x0016579D File Offset: 0x0016399D
		// (set) Token: 0x06009BB6 RID: 39862 RVA: 0x001657C8 File Offset: 0x001639C8
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

		// Token: 0x04005E84 RID: 24196
		[Nullable(2)]
		protected new InfrActivityUpgradeInfrastructure FbInstance;

		// Token: 0x04005E85 RID: 24197
		[Nullable(2)]
		protected InfrActivityUpgradeInfrastructure_SetValue PocoInterface;
	}
}
