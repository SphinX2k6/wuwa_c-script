using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C10 RID: 3088
	public class ICreateBulletDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x060046C9 RID: 18121 RVA: 0x000B3F98 File Offset: 0x000B2198
		public static ICreateBulletDestroyCondition Create(ICreateBulletDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x000B3FB7 File Offset: 0x000B21B7
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x040027B7 RID: 10167
		private ICreateBulletDestroyCondition Instance;
	}
}
