using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A65 RID: 10853
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideWorldEntityAndLevelPlayGroup : IHideGroupType
	{
		// Token: 0x0600EF9F RID: 61343 RVA: 0x00231FCC File Offset: 0x002301CC
		[NullableContext(0)]
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

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x0600EFA0 RID: 61344 RVA: 0x00231FEB File Offset: 0x002301EB
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004784 RID: 18308
		// (get) Token: 0x0600EFA1 RID: 61345 RVA: 0x00231FF8 File Offset: 0x002301F8
		[Nullable(0)]
		public virtual List<int> HideRangeEntities
		{
			[NullableContext(0)]
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

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x0600EFA2 RID: 61346 RVA: 0x0023205C File Offset: 0x0023025C
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

		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x0600EFA3 RID: 61347 RVA: 0x002320D4 File Offset: 0x002302D4
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

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x0600EFA4 RID: 61348 RVA: 0x0023214C File Offset: 0x0023034C
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

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x0600EFA5 RID: 61349 RVA: 0x002321C4 File Offset: 0x002303C4
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

		// Token: 0x040083BB RID: 33723
		private IHideWorldEntityAndLevelPlayGroup Instance;

		// Token: 0x040083BC RID: 33724
		[Nullable(0)]
		private List<int> _HideRangeEntitiesCache;

		// Token: 0x040083BD RID: 33725
		private bool _HideRangeEntitiesInited;

		// Token: 0x040083BE RID: 33726
		private List<int> _ExcludeEntitiesCache;

		// Token: 0x040083BF RID: 33727
		private bool _ExcludeEntitiesInited;

		// Token: 0x040083C0 RID: 33728
		private List<int> _ExcludeLevelPlaysCache;

		// Token: 0x040083C1 RID: 33729
		private bool _ExcludeLevelPlaysInited;

		// Token: 0x040083C2 RID: 33730
		private List<int> _AppendEntitiesCache;

		// Token: 0x040083C3 RID: 33731
		private bool _AppendEntitiesInited;

		// Token: 0x040083C4 RID: 33732
		private List<int> _AppendLevelPlaysCache;

		// Token: 0x040083C5 RID: 33733
		private bool _AppendLevelPlaysInited;
	}
}
