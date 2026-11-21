using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000230 RID: 560
	public class IBulletCreateCondition
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x00028AF8 File Offset: 0x00026CF8
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

		// Token: 0x06000919 RID: 2329 RVA: 0x00028B30 File Offset: 0x00026D30
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

		// Token: 0x0600091A RID: 2330 RVA: 0x00028B43 File Offset: 0x00026D43
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

		// Token: 0x0600091B RID: 2331 RVA: 0x00028B56 File Offset: 0x00026D56
		public IBulletCreateCondition_SetValue ToSetValue()
		{
			return new IBulletCreateCondition_SetValue
			{
				Type = this.Type,
				BulletId = this.BulletId
			};
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00028B75 File Offset: 0x00026D75
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00028BA0 File Offset: 0x00026DA0
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

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00028BAE File Offset: 0x00026DAE
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00028BDA File Offset: 0x00026DDA
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

		// Token: 0x040009C8 RID: 2504
		[Nullable(2)]
		protected IBulletCreateCondition FbInstance;

		// Token: 0x040009C9 RID: 2505
		[Nullable(2)]
		protected IBulletCreateCondition_SetValue PocoInterface;
	}
}
