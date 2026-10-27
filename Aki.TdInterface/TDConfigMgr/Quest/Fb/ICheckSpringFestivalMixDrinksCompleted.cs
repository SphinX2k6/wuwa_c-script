using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001413 RID: 5139
	public class ICheckSpringFestivalMixDrinksCompleted : ICheckSpringFestivalGameplayType
	{
		// Token: 0x060074D0 RID: 29904 RVA: 0x00117370 File Offset: 0x00115570
		[NullableContext(1)]
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

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x060074D1 RID: 29905 RVA: 0x0011738F File Offset: 0x0011558F
		public override ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x060074D2 RID: 29906 RVA: 0x0011739C File Offset: 0x0011559C
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

		// Token: 0x040043A1 RID: 17313
		private ICheckSpringFestivalMixDrinksCompleted Instance;
	}
}
