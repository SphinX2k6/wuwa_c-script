using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000214 RID: 532
	public class IBatchBulletCaster
	{
		// Token: 0x06000878 RID: 2168 RVA: 0x00027830 File Offset: 0x00025A30
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

		// Token: 0x06000879 RID: 2169 RVA: 0x00027868 File Offset: 0x00025A68
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

		// Token: 0x0600087A RID: 2170 RVA: 0x0002787B File Offset: 0x00025A7B
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

		// Token: 0x0600087B RID: 2171 RVA: 0x00027890 File Offset: 0x00025A90
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000278F6 File Offset: 0x00025AF6
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00027921 File Offset: 0x00025B21
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0002792F File Offset: 0x00025B2F
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x0002795B File Offset: 0x00025B5B
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0002796C File Offset: 0x00025B6C
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000279A6 File Offset: 0x00025BA6
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x000279B4 File Offset: 0x00025BB4
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x000279DF File Offset: 0x00025BDF
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x000279ED File Offset: 0x00025BED
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00027A18 File Offset: 0x00025C18
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00027A26 File Offset: 0x00025C26
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00027A51 File Offset: 0x00025C51
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00027A5F File Offset: 0x00025C5F
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00027A8A File Offset: 0x00025C8A
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

		// Token: 0x0400097A RID: 2426
		[Nullable(2)]
		protected IBatchBulletCaster FbInstance;

		// Token: 0x0400097B RID: 2427
		[Nullable(2)]
		protected IBatchBulletCaster_SetValue PocoInterface;
	}
}
