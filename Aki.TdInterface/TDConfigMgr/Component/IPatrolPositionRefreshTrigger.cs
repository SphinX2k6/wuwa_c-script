using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000683 RID: 1667
	public class IPatrolPositionRefreshTrigger
	{
		// Token: 0x060022FC RID: 8956 RVA: 0x00060070 File Offset: 0x0005E270
		private IPatrolPositionRefreshTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefreshTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefreshTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefreshTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000600A8 File Offset: 0x0005E2A8
		public static IPatrolPositionRefreshTrigger Create([Nullable(2)] IPatrolPositionRefreshTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000600BB File Offset: 0x0005E2BB
		public static IPatrolPositionRefreshTrigger CreateFromSetValue([Nullable(2)] IPatrolPositionRefreshTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000600CE File Offset: 0x0005E2CE
		public IPatrolPositionRefreshTrigger_SetValue ToSetValue()
		{
			return new IPatrolPositionRefreshTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x000600E1 File Offset: 0x0005E2E1
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x0006010C File Offset: 0x0005E30C
		public virtual EPatrolPositionRefreshTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolPositionRefreshTriggerType.EntityAwake;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001869 RID: 6249
		[Nullable(2)]
		protected IPatrolPositionRefreshTrigger FbInstance;

		// Token: 0x0400186A RID: 6250
		[Nullable(2)]
		protected IPatrolPositionRefreshTrigger_SetValue PocoInterface;
	}
}
