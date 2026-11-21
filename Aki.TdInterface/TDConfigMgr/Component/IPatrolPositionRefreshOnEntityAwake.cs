using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067F RID: 1663
	public class IPatrolPositionRefreshOnEntityAwake : IPatrolPositionRefreshTrigger
	{
		// Token: 0x060022EC RID: 8940 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
		private IPatrolPositionRefreshOnEntityAwake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefreshOnEntityAwake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefreshOnEntityAwake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefreshOnEntityAwake_SetValue());
			}
			return result;
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0005FF30 File Offset: 0x0005E130
		public static IPatrolPositionRefreshOnEntityAwake Create([Nullable(2)] IPatrolPositionRefreshOnEntityAwake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityAwake
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0005FF43 File Offset: 0x0005E143
		public static IPatrolPositionRefreshOnEntityAwake CreateFromSetValue([Nullable(2)] IPatrolPositionRefreshOnEntityAwake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshOnEntityAwake
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0005FF56 File Offset: 0x0005E156
		public new IPatrolPositionRefreshOnEntityAwake_SetValue ToSetValue()
		{
			return new IPatrolPositionRefreshOnEntityAwake_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0005FF69 File Offset: 0x0005E169
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x0005FF94 File Offset: 0x0005E194
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

		// Token: 0x04001863 RID: 6243
		[Nullable(2)]
		protected new IPatrolPositionRefreshOnEntityAwake FbInstance;

		// Token: 0x04001864 RID: 6244
		[Nullable(2)]
		protected new IPatrolPositionRefreshOnEntityAwake_SetValue PocoInterface;
	}
}
