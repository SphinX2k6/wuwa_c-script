using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A5 RID: 10661
	public class IMonsterStandByConfig
	{
		// Token: 0x0600EC39 RID: 60473 RVA: 0x0022C615 File Offset: 0x0022A815
		public static IMonsterStandByConfig Create(IMonsterStandByConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterStandByConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x0600EC3A RID: 60474 RVA: 0x0022C634 File Offset: 0x0022A834
		public virtual string Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x0600EC3B RID: 60475 RVA: 0x0022C644 File Offset: 0x0022A844
		public virtual float? Duration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Duration);
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x0600EC3C RID: 60476 RVA: 0x0022C67C File Offset: 0x0022A87C
		public virtual int? RepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RepeatTimes);
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x0600EC3D RID: 60477 RVA: 0x0022C6B4 File Offset: 0x0022A8B4
		public virtual int? EmotionId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EmotionId);
			}
		}

		// Token: 0x0400820F RID: 33295
		private IMonsterStandByConfig Instance;
	}
}
