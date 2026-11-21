using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200156A RID: 5482
	public class ICheckSpringFestivalMixDrinksCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x06007B91 RID: 31633 RVA: 0x00125D54 File Offset: 0x00123F54
		public static ICheckSpringFestivalMixDrinksCompleted Create(ICheckSpringFestivalMixDrinksCompleted? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalMixDrinksCompleted
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x00125D73 File Offset: 0x00123F73
		public override ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x00125D80 File Offset: 0x00123F80
		public virtual int? Id
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Id);
			}
		}

		// Token: 0x04004732 RID: 18226
		private ICheckSpringFestivalMixDrinksCompleted Instance;
	}
}
