using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000681 RID: 1665
	public class IPatrolPositionRefreshOnEntityVisibilityShown : IPatrolPositionRefreshTrigger
	{
		// Token: 0x060022F4 RID: 8948 RVA: 0x0005FFB4 File Offset: 0x0005E1B4
		private IPatrolPositionRefreshOnEntityVisibilityShown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefreshOnEntityVisibilityShown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefreshOnEntityVisibilityShown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefreshOnEntityVisibilityShown_SetValue());
			}
			return result;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0005FFEC File Offset: 0x0005E1EC
		public static IPatrolPositionRefreshOnEntityVisibilityShown Create([Nullable(2)] IPatrolPositionRefreshOnEntityVisibilityShown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityVisibilityShown
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0005FFFF File Offset: 0x0005E1FF
		public static IPatrolPositionRefreshOnEntityVisibilityShown CreateFromSetValue([Nullable(2)] IPatrolPositionRefreshOnEntityVisibilityShown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityVisibilityShown
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00060012 File Offset: 0x0005E212
		public new IPatrolPositionRefreshOnEntityVisibilityShown_SetValue ToSetValue()
		{
			return new IPatrolPositionRefreshOnEntityVisibilityShown_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x00060025 File Offset: 0x0005E225
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x00060050 File Offset: 0x0005E250
		public override EPatrolPositionRefreshTriggerType Type
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

		// Token: 0x04001866 RID: 6246
		[Nullable(2)]
		protected new IPatrolPositionRefreshOnEntityVisibilityShown FbInstance;

		// Token: 0x04001867 RID: 6247
		[Nullable(2)]
		protected new IPatrolPositionRefreshOnEntityVisibilityShown_SetValue PocoInterface;
	}
}
