using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001569 RID: 5481
	public class ICheckSpringFestivalGameplayType
	{
		// Token: 0x06007B8E RID: 31630 RVA: 0x00125D20 File Offset: 0x00123F20
		public static ICheckSpringFestivalGameplayType Create(ICheckSpringFestivalGameplayType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGameplayType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00125D3F File Offset: 0x00123F3F
		public virtual ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x04004731 RID: 18225
		private ICheckSpringFestivalGameplayType Instance;
	}
}
