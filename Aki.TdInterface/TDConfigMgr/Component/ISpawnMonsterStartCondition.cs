using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000791 RID: 1937
	public class ISpawnMonsterStartCondition
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x0006D860 File Offset: 0x0006BA60
		private ISpawnMonsterStartCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnMonsterStartCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnMonsterStartCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnMonsterStartCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0006D898 File Offset: 0x0006BA98
		public static ISpawnMonsterStartCondition Create([Nullable(2)] ISpawnMonsterStartCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnMonsterStartCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x0006D8AB File Offset: 0x0006BAAB
		public static ISpawnMonsterStartCondition CreateFromSetValue([Nullable(2)] ISpawnMonsterStartCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnMonsterStartCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x0006D8BE File Offset: 0x0006BABE
		public ISpawnMonsterStartCondition_SetValue ToSetValue()
		{
			return new ISpawnMonsterStartCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x0006D8D1 File Offset: 0x0006BAD1
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x0006D8FC File Offset: 0x0006BAFC
		public virtual ESpawnMonsterStartCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001BFD RID: 7165
		[Nullable(2)]
		protected ISpawnMonsterStartCondition FbInstance;

		// Token: 0x04001BFE RID: 7166
		[Nullable(2)]
		protected ISpawnMonsterStartCondition_SetValue PocoInterface;
	}
}
