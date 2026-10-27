using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005C4 RID: 1476
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcFixIntervalSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x06001F3C RID: 7996 RVA: 0x00057DC8 File Offset: 0x00055FC8
		private IPasserbyNpcFixIntervalSpawn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcFixIntervalSpawn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcFixIntervalSpawn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcFixIntervalSpawn_SetValue());
			}
			return result;
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00057E00 File Offset: 0x00056000
		public static IPasserbyNpcFixIntervalSpawn Create([Nullable(2)] IPasserbyNpcFixIntervalSpawn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcFixIntervalSpawn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00057E13 File Offset: 0x00056013
		public static IPasserbyNpcFixIntervalSpawn CreateFromSetValue([Nullable(2)] IPasserbyNpcFixIntervalSpawn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcFixIntervalSpawn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00057E26 File Offset: 0x00056026
		public new IPasserbyNpcFixIntervalSpawn_SetValue ToSetValue()
		{
			return new IPasserbyNpcFixIntervalSpawn_SetValue
			{
				Type = this.Type,
				MaxSpawnCount = this.MaxSpawnCount,
				MinDistance = this.MinDistance,
				Interval = this.Interval
			};
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00057E5D File Offset: 0x0005605D
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00057E88 File Offset: 0x00056088
		public override EPasserbyNpcSpawnType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00057E96 File Offset: 0x00056096
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00057EC1 File Offset: 0x000560C1
		public override int MaxSpawnCount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxSpawnCount;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxSpawnCount;
			}
			set
			{
				this.GetOrCreatePoco().MaxSpawnCount = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00057ED0 File Offset: 0x000560D0
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00057F0A File Offset: 0x0005610A
		public override int? MinDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDistance;
				}
				IPasserbyNpcFixIntervalSpawn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MinDistance;
			}
			set
			{
				this.GetOrCreatePoco().MinDistance = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00057F18 File Offset: 0x00056118
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00057F47 File Offset: 0x00056147
		public virtual float Interval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Interval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Interval;
			}
			set
			{
				this.GetOrCreatePoco().Interval = value;
			}
		}

		// Token: 0x04001623 RID: 5667
		[Nullable(2)]
		protected new IPasserbyNpcFixIntervalSpawn FbInstance;

		// Token: 0x04001624 RID: 5668
		[Nullable(2)]
		protected new IPasserbyNpcFixIntervalSpawn_SetValue PocoInterface;
	}
}
