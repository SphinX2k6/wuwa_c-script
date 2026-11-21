using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C0A RID: 3082
	public class IOnMatchingCondition : IBulletCreateCondition
	{
		// Token: 0x060046B3 RID: 18099 RVA: 0x000B3E0A File Offset: 0x000B200A
		public static IOnMatchingCondition Create(IOnMatchingCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMatchingCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000B3E29 File Offset: 0x000B2029
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x000B3E36 File Offset: 0x000B2036
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x040027AF RID: 10159
		private IOnMatchingCondition Instance;
	}
}
