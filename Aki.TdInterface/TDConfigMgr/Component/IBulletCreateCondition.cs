using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000207 RID: 519
	[NullableContext(1)]
	[Nullable(0)]
	public class IBulletCreateCondition
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x000271A4 File Offset: 0x000253A4
		private IBulletCreateCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBulletCreateCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBulletCreateCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBulletCreateCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000271DC File Offset: 0x000253DC
		public static IBulletCreateCondition Create([Nullable(2)] IBulletCreateCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletCreateCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000271EF File Offset: 0x000253EF
		public static IBulletCreateCondition CreateFromSetValue([Nullable(2)] IBulletCreateCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBulletCreateCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00027202 File Offset: 0x00025402
		public IBulletCreateCondition_SetValue ToSetValue()
		{
			return new IBulletCreateCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00027221 File Offset: 0x00025421
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x0002724C File Offset: 0x0002544C
		public virtual EBulletCreateCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBulletCreateCondition.OnHit;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002725A File Offset: 0x0002545A
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00027286 File Offset: 0x00025486
		public virtual long BulletId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BulletId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.BulletId;
			}
			set
			{
				this.GetOrCreatePoco().BulletId = value;
			}
		}

		// Token: 0x04000937 RID: 2359
		[Nullable(2)]
		protected IBulletCreateCondition FbInstance;

		// Token: 0x04000938 RID: 2360
		[Nullable(2)]
		protected IBulletCreateCondition_SetValue PocoInterface;
	}
}
