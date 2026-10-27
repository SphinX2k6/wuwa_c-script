using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E1 RID: 9953
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterStandByConfig
	{
		// Token: 0x0600DE5D RID: 56925 RVA: 0x0020FDD5 File Offset: 0x0020DFD5
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

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x0600DE5E RID: 56926 RVA: 0x0020FDF4 File Offset: 0x0020DFF4
		public virtual string Tag
		{
			get
			{
				return this.Instance.Tag;
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x0020FE04 File Offset: 0x0020E004
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

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x0600DE60 RID: 56928 RVA: 0x0020FE3C File Offset: 0x0020E03C
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

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0600DE61 RID: 56929 RVA: 0x0020FE74 File Offset: 0x0020E074
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

		// Token: 0x04007B6F RID: 31599
		private IMonsterStandByConfig Instance;
	}
}
