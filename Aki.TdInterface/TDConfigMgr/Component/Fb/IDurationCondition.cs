using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C4A RID: 3146
	public class IDurationCondition : ISpawnMonsterCompleteCondition
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x000B66EC File Offset: 0x000B48EC
		public static IDurationCondition Create(IDurationCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurationCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x000B670B File Offset: 0x000B490B
		public override ESpawnMonsterCompleteCondition Type
		{
			get
			{
				return (ESpawnMonsterCompleteCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x000B6718 File Offset: 0x000B4918
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x000B6728 File Offset: 0x000B4928
		public virtual bool? Refill
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Refill);
			}
		}

		// Token: 0x04002875 RID: 10357
		private IDurationCondition Instance;
	}
}
