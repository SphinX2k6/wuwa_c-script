using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C06 RID: 3078
	public class IBulletCreateCondition
	{
		// Token: 0x060046A2 RID: 18082 RVA: 0x000B3CD2 File Offset: 0x000B1ED2
		public static IBulletCreateCondition Create(IBulletCreateCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBulletCreateCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x000B3CF1 File Offset: 0x000B1EF1
		public virtual EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x000B3CFE File Offset: 0x000B1EFE
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x040027A9 RID: 10153
		private IBulletCreateCondition Instance;
	}
}
