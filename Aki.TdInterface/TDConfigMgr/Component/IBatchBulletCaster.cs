using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EB RID: 491
	[NullableContext(1)]
	[Nullable(0)]
	public class IBatchBulletCaster
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x00025EDC File Offset: 0x000240DC
		private IBatchBulletCaster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBatchBulletCaster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBatchBulletCaster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBatchBulletCaster_SetValue());
			}
			return result;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00025F14 File Offset: 0x00024114
		public static IBatchBulletCaster Create([Nullable(2)] IBatchBulletCaster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBatchBulletCaster
			{
				FbInstance = instance
			};
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00025F27 File Offset: 0x00024127
		public static IBatchBulletCaster CreateFromSetValue([Nullable(2)] IBatchBulletCaster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBatchBulletCaster
			{
				PocoInterface = value
			};
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00025F3C File Offset: 0x0002413C
		public IBatchBulletCaster_SetValue ToSetValue()
		{
			return new IBatchBulletCaster_SetValue
			{
				BulletIndex = this.BulletIndex,
				BulletType = this.BulletType,
				DelayTime = this.DelayTime,
				FlyTime = this.FlyTime,
				FlyDistance = this.FlyDistance,
				WarningTime = this.WarningTime,
				WarningWidth = this.WarningWidth
			};
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00025FA2 File Offset: 0x000241A2
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00025FCD File Offset: 0x000241CD
		public virtual int BulletIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BulletIndex;
			}
			set
			{
				this.GetOrCreatePoco().BulletIndex = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00025FDB File Offset: 0x000241DB
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00026007 File Offset: 0x00024207
		public virtual long BulletType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletType;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletType;
			}
			set
			{
				this.GetOrCreatePoco().BulletType = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00026018 File Offset: 0x00024218
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00026052 File Offset: 0x00024252
		public virtual int? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IBatchBulletCaster_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00026060 File Offset: 0x00024260
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0002608B File Offset: 0x0002428B
		public virtual int FlyTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlyTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlyTime;
			}
			set
			{
				this.GetOrCreatePoco().FlyTime = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00026099 File Offset: 0x00024299
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x000260C4 File Offset: 0x000242C4
		public virtual int FlyDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FlyDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FlyDistance;
			}
			set
			{
				this.GetOrCreatePoco().FlyDistance = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000260D2 File Offset: 0x000242D2
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x000260FD File Offset: 0x000242FD
		public virtual int WarningTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WarningTime;
			}
			set
			{
				this.GetOrCreatePoco().WarningTime = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0002610B File Offset: 0x0002430B
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00026136 File Offset: 0x00024336
		public virtual int WarningWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningWidth;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WarningWidth;
			}
			set
			{
				this.GetOrCreatePoco().WarningWidth = value;
			}
		}

		// Token: 0x040008E9 RID: 2281
		[Nullable(2)]
		protected IBatchBulletCaster FbInstance;

		// Token: 0x040008EA RID: 2282
		[Nullable(2)]
		protected IBatchBulletCaster_SetValue PocoInterface;
	}
}
