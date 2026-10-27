using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002793 RID: 10131
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup : IHideGroupType
	{
		// Token: 0x0600E181 RID: 57729 RVA: 0x00215238 File Offset: 0x00213438
		[NullableContext(1)]
		public static IHideWorldEntityAndLevelPlayGroup Create(IHideWorldEntityAndLevelPlayGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldEntityAndLevelPlayGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x0600E182 RID: 57730 RVA: 0x00215257 File Offset: 0x00213457
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x0600E183 RID: 57731 RVA: 0x00215264 File Offset: 0x00213464
		[Nullable(1)]
		public virtual List<int> HideRangeEntities
		{
			[NullableContext(1)]
			get
			{
				if (this._HideRangeEntitiesInited)
				{
					return this._HideRangeEntitiesCache;
				}
				this._HideRangeEntitiesInited = true;
				int hideRangeEntitiesLength = this.Instance.HideRangeEntitiesLength;
				this._HideRangeEntitiesCache = new List<int>(hideRangeEntitiesLength);
				for (int i = 0; i < hideRangeEntitiesLength; i++)
				{
					this._HideRangeEntitiesCache.Add(this.Instance.HideRangeEntities(i));
				}
				return this._HideRangeEntitiesCache;
			}
		}

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x0600E184 RID: 57732 RVA: 0x002152C8 File Offset: 0x002134C8
		public virtual List<int> ExcludeEntities
		{
			get
			{
				if (this._ExcludeEntitiesInited)
				{
					return this._ExcludeEntitiesCache;
				}
				this._ExcludeEntitiesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int excludeEntitiesLength = this.Instance.ExcludeEntitiesLength;
				this._ExcludeEntitiesCache = new List<int>(excludeEntitiesLength);
				for (int i = 0; i < excludeEntitiesLength; i++)
				{
					this._ExcludeEntitiesCache.Add(this.Instance.ExcludeEntities(i));
				}
				return this._ExcludeEntitiesCache;
			}
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00215340 File Offset: 0x00213540
		public virtual List<int> ExcludeLevelPlays
		{
			get
			{
				if (this._ExcludeLevelPlaysInited)
				{
					return this._ExcludeLevelPlaysCache;
				}
				this._ExcludeLevelPlaysInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int excludeLevelPlaysLength = this.Instance.ExcludeLevelPlaysLength;
				this._ExcludeLevelPlaysCache = new List<int>(excludeLevelPlaysLength);
				for (int i = 0; i < excludeLevelPlaysLength; i++)
				{
					this._ExcludeLevelPlaysCache.Add(this.Instance.ExcludeLevelPlays(i));
				}
				return this._ExcludeLevelPlaysCache;
			}
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x0600E186 RID: 57734 RVA: 0x002153B8 File Offset: 0x002135B8
		public virtual List<int> AppendEntities
		{
			get
			{
				if (this._AppendEntitiesInited)
				{
					return this._AppendEntitiesCache;
				}
				this._AppendEntitiesInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int appendEntitiesLength = this.Instance.AppendEntitiesLength;
				this._AppendEntitiesCache = new List<int>(appendEntitiesLength);
				for (int i = 0; i < appendEntitiesLength; i++)
				{
					this._AppendEntitiesCache.Add(this.Instance.AppendEntities(i));
				}
				return this._AppendEntitiesCache;
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x0600E187 RID: 57735 RVA: 0x00215430 File Offset: 0x00213630
		public virtual List<int> AppendLevelPlays
		{
			get
			{
				if (this._AppendLevelPlaysInited)
				{
					return this._AppendLevelPlaysCache;
				}
				this._AppendLevelPlaysInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int appendLevelPlaysLength = this.Instance.AppendLevelPlaysLength;
				this._AppendLevelPlaysCache = new List<int>(appendLevelPlaysLength);
				for (int i = 0; i < appendLevelPlaysLength; i++)
				{
					this._AppendLevelPlaysCache.Add(this.Instance.AppendLevelPlays(i));
				}
				return this._AppendLevelPlaysCache;
			}
		}

		// Token: 0x04007D05 RID: 32005
		private IHideWorldEntityAndLevelPlayGroup Instance;

		// Token: 0x04007D06 RID: 32006
		[Nullable(1)]
		private List<int> _HideRangeEntitiesCache;

		// Token: 0x04007D07 RID: 32007
		private bool _HideRangeEntitiesInited;

		// Token: 0x04007D08 RID: 32008
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x04007D09 RID: 32009
		private bool _ExcludeEntitiesInited;

		// Token: 0x04007D0A RID: 32010
		private List<int> _ExcludeLevelPlaysCache;

		// Token: 0x04007D0B RID: 32011
		private bool _ExcludeLevelPlaysInited;

		// Token: 0x04007D0C RID: 32012
		private List<int> _AppendEntitiesCache;

		// Token: 0x04007D0D RID: 32013
		private bool _AppendEntitiesInited;

		// Token: 0x04007D0E RID: 32014
		private List<int> _AppendLevelPlaysCache;

		// Token: 0x04007D0F RID: 32015
		private bool _AppendLevelPlaysInited;
	}
}
