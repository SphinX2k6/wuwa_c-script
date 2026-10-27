using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F0 RID: 1776
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnMonsterStartCondition
	{
		// Token: 0x06002642 RID: 9794 RVA: 0x000667F0 File Offset: 0x000649F0
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

		// Token: 0x06002643 RID: 9795 RVA: 0x00066828 File Offset: 0x00064A28
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

		// Token: 0x06002644 RID: 9796 RVA: 0x0006683B File Offset: 0x00064A3B
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

		// Token: 0x06002645 RID: 9797 RVA: 0x0006684E File Offset: 0x00064A4E
		public ISpawnMonsterStartCondition_SetValue ToSetValue()
		{
			return new ISpawnMonsterStartCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x00066861 File Offset: 0x00064A61
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0006688C File Offset: 0x00064A8C
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

		// Token: 0x040019FE RID: 6654
		[Nullable(2)]
		protected ISpawnMonsterStartCondition FbInstance;

		// Token: 0x040019FF RID: 6655
		[Nullable(2)]
		protected ISpawnMonsterStartCondition_SetValue PocoInterface;
	}
}
