using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145E RID: 5214
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallEntry
	{
		// Token: 0x0600767E RID: 30334 RVA: 0x0011AFA8 File Offset: 0x001191A8
		public static IRecallEntry Create(IRecallEntry? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallEntry
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x0011AFC7 File Offset: 0x001191C7
		public virtual int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x06007680 RID: 30336 RVA: 0x0011AFD4 File Offset: 0x001191D4
		public virtual List<int> IncludeGroups
		{
			get
			{
				if (this._IncludeGroupsInited)
				{
					return this._IncludeGroupsCache;
				}
				this._IncludeGroupsInited = true;
				int includeGroupsLength = this.Instance.IncludeGroupsLength;
				this._IncludeGroupsCache = new List<int>(includeGroupsLength);
				for (int i = 0; i < includeGroupsLength; i++)
				{
					this._IncludeGroupsCache.Add(this.Instance.IncludeGroups(i));
				}
				return this._IncludeGroupsCache;
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x06007681 RID: 30337 RVA: 0x0011B038 File Offset: 0x00119238
		public virtual List<int> ExcludeGroups
		{
			get
			{
				if (this._ExcludeGroupsInited)
				{
					return this._ExcludeGroupsCache;
				}
				this._ExcludeGroupsInited = true;
				int excludeGroupsLength = this.Instance.ExcludeGroupsLength;
				this._ExcludeGroupsCache = new List<int>(excludeGroupsLength);
				for (int i = 0; i < excludeGroupsLength; i++)
				{
					this._ExcludeGroupsCache.Add(this.Instance.ExcludeGroups(i));
				}
				return this._ExcludeGroupsCache;
			}
		}

		// Token: 0x040044CE RID: 17614
		private IRecallEntry Instance;

		// Token: 0x040044CF RID: 17615
		private List<int> _IncludeGroupsCache;

		// Token: 0x040044D0 RID: 17616
		private bool _IncludeGroupsInited;

		// Token: 0x040044D1 RID: 17617
		private List<int> _ExcludeGroupsCache;

		// Token: 0x040044D2 RID: 17618
		private bool _ExcludeGroupsInited;
	}
}
