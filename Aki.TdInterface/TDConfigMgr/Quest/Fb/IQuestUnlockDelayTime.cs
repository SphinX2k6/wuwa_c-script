using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A8 RID: 5544
	public class IQuestUnlockDelayTime
	{
		// Token: 0x06007D05 RID: 32005 RVA: 0x001292F3 File Offset: 0x001274F3
		public static IQuestUnlockDelayTime Create(IQuestUnlockDelayTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestUnlockDelayTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x06007D06 RID: 32006 RVA: 0x00129312 File Offset: 0x00127512
		public virtual int Day
		{
			get
			{
				return this.Instance.Day;
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x0012931F File Offset: 0x0012751F
		public virtual int Hour
		{
			get
			{
				return this.Instance.Hour;
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x06007D08 RID: 32008 RVA: 0x0012932C File Offset: 0x0012752C
		public virtual int Minute
		{
			get
			{
				return this.Instance.Minute;
			}
		}

		// Token: 0x04004842 RID: 18498
		private IQuestUnlockDelayTime Instance;
	}
}
