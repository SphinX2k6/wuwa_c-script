using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200149D RID: 5277
	public class IQuestPlayerHitCount : IQuestPlayerHitStatisticsType
	{
		// Token: 0x060077D6 RID: 30678 RVA: 0x0011F4FB File Offset: 0x0011D6FB
		public static IQuestPlayerHitCount Create(IQuestPlayerHitCount? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerHitCount
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x0011F51A File Offset: 0x0011D71A
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x0011F528 File Offset: 0x0011D728
		public virtual float? Cd
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Cd);
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x0011F560 File Offset: 0x0011D760
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x0011F5C4 File Offset: 0x0011D7C4
		public virtual List<int> SkillIds
		{
			get
			{
				if (this._SkillIdsInited)
				{
					return this._SkillIdsCache;
				}
				this._SkillIdsInited = true;
				int skillIdsLength = this.Instance.SkillIdsLength;
				this._SkillIdsCache = new List<int>(skillIdsLength);
				for (int i = 0; i < skillIdsLength; i++)
				{
					this._SkillIdsCache.Add(this.Instance.SkillIds(i));
				}
				return this._SkillIdsCache;
			}
		}

		// Token: 0x040044DB RID: 17627
		private IQuestPlayerHitCount Instance;

		// Token: 0x040044DC RID: 17628
		private List<int> _EntityIdsCache;

		// Token: 0x040044DD RID: 17629
		private bool _EntityIdsInited;

		// Token: 0x040044DE RID: 17630
		private List<int> _SkillIdsCache;

		// Token: 0x040044DF RID: 17631
		private bool _SkillIdsInited;
	}
}
