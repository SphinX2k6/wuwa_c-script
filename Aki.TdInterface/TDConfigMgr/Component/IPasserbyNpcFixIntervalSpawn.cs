using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000635 RID: 1589
	public class IPasserbyNpcFixIntervalSpawn : IPasserbyNpcSpawnBase
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x0005D028 File Offset: 0x0005B228
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

		// Token: 0x06002165 RID: 8549 RVA: 0x0005D060 File Offset: 0x0005B260
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

		// Token: 0x06002166 RID: 8550 RVA: 0x0005D073 File Offset: 0x0005B273
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

		// Token: 0x06002167 RID: 8551 RVA: 0x0005D086 File Offset: 0x0005B286
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0005D0BD File Offset: 0x0005B2BD
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x0005D0E8 File Offset: 0x0005B2E8
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

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0005D0F6 File Offset: 0x0005B2F6
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x0005D121 File Offset: 0x0005B321
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x0005D130 File Offset: 0x0005B330
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x0005D16A File Offset: 0x0005B36A
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

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0005D178 File Offset: 0x0005B378
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x0005D1A7 File Offset: 0x0005B3A7
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

		// Token: 0x040017A0 RID: 6048
		[Nullable(2)]
		protected new IPasserbyNpcFixIntervalSpawn FbInstance;

		// Token: 0x040017A1 RID: 6049
		[Nullable(2)]
		protected new IPasserbyNpcFixIntervalSpawn_SetValue PocoInterface;
	}
}
