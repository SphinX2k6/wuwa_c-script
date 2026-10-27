using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3F RID: 3391
	public class IBatchBulletCaster
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x000C06E7 File Offset: 0x000BE8E7
		[NullableContext(1)]
		public static IBatchBulletCaster Create(IBatchBulletCaster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBatchBulletCaster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x000C0706 File Offset: 0x000BE906
		public virtual int BulletIndex
		{
			get
			{
				return this.Instance.BulletIndex;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x000C0713 File Offset: 0x000BE913
		public virtual long BulletType
		{
			get
			{
				return this.Instance.BulletType;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x000C0720 File Offset: 0x000BE920
		public virtual int? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004D59 RID: 19801 RVA: 0x000C0756 File Offset: 0x000BE956
		public virtual int FlyTime
		{
			get
			{
				return this.Instance.FlyTime;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x000C0763 File Offset: 0x000BE963
		public virtual int FlyDistance
		{
			get
			{
				return this.Instance.FlyDistance;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004D5B RID: 19803 RVA: 0x000C0770 File Offset: 0x000BE970
		public virtual int WarningTime
		{
			get
			{
				return this.Instance.WarningTime;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x000C077D File Offset: 0x000BE97D
		public virtual int WarningWidth
		{
			get
			{
				return this.Instance.WarningWidth;
			}
		}

		// Token: 0x04002C5A RID: 11354
		private IBatchBulletCaster Instance;
	}
}
