using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B38 RID: 2872
	public class IBulletCreateCondition
	{
		// Token: 0x06004249 RID: 16969 RVA: 0x000A9C0E File Offset: 0x000A7E0E
		[NullableContext(1)]
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

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x000A9C2D File Offset: 0x000A7E2D
		public virtual EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600424B RID: 16971 RVA: 0x000A9C3A File Offset: 0x000A7E3A
		public virtual long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x04002561 RID: 9569
		private IBulletCreateCondition Instance;
	}
}
