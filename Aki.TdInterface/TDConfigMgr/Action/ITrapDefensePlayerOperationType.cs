using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223B RID: 8763
	public class ITrapDefensePlayerOperationType
	{
		// Token: 0x0600BF00 RID: 48896 RVA: 0x001B8EF0 File Offset: 0x001B70F0
		private ITrapDefensePlayerOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefensePlayerOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefensePlayerOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefensePlayerOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x001B8F28 File Offset: 0x001B7128
		public static ITrapDefensePlayerOperationType Create([Nullable(2)] ITrapDefensePlayerOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x001B8F3B File Offset: 0x001B713B
		public static ITrapDefensePlayerOperationType CreateFromSetValue([Nullable(2)] ITrapDefensePlayerOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x001B8F4E File Offset: 0x001B714E
		public ITrapDefensePlayerOperationType_SetValue ToSetValue()
		{
			return new ITrapDefensePlayerOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600BF04 RID: 48900 RVA: 0x001B8F61 File Offset: 0x001B7161
		// (set) Token: 0x0600BF05 RID: 48901 RVA: 0x001B8F8C File Offset: 0x001B718C
		public virtual ETrapDefensePlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400727E RID: 29310
		[Nullable(2)]
		protected ITrapDefensePlayerOperationType FbInstance;

		// Token: 0x0400727F RID: 29311
		[Nullable(2)]
		protected ITrapDefensePlayerOperationType_SetValue PocoInterface;
	}
}
