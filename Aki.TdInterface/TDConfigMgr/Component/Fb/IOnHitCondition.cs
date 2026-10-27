using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B39 RID: 2873
	public class IOnHitCondition : IBulletCreateCondition
	{
		// Token: 0x0600424D RID: 16973 RVA: 0x000A9C4F File Offset: 0x000A7E4F
		[NullableContext(1)]
		public static IOnHitCondition Create(IOnHitCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnHitCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x000A9C6E File Offset: 0x000A7E6E
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x000A9C7B File Offset: 0x000A7E7B
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x04002562 RID: 9570
		private IOnHitCondition Instance;
	}
}
