using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200134D RID: 4941
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestPlayerHitCount : IQuestPlayerHitStatisticsType
	{
		// Token: 0x06007136 RID: 28982 RVA: 0x00110F8F File Offset: 0x0010F18F
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

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06007137 RID: 28983 RVA: 0x00110FAE File Offset: 0x0010F1AE
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06007138 RID: 28984 RVA: 0x00110FBC File Offset: 0x0010F1BC
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

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06007139 RID: 28985 RVA: 0x00110FF4 File Offset: 0x0010F1F4
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

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600713A RID: 28986 RVA: 0x00111058 File Offset: 0x0010F258
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

		// Token: 0x0400415F RID: 16735
		private IQuestPlayerHitCount Instance;

		// Token: 0x04004160 RID: 16736
		private List<int> _EntityIdsCache;

		// Token: 0x04004161 RID: 16737
		private bool _EntityIdsInited;

		// Token: 0x04004162 RID: 16738
		private List<int> _SkillIdsCache;

		// Token: 0x04004163 RID: 16739
		private bool _SkillIdsInited;
	}
}
