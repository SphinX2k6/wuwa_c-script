using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B7 RID: 5559
	public class IRecallEntry
	{
		// Token: 0x06007D4B RID: 32075 RVA: 0x00129B8C File Offset: 0x00127D8C
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

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06007D4C RID: 32076 RVA: 0x00129BAB File Offset: 0x00127DAB
		public virtual int RecallId
		{
			get
			{
				return this.Instance.RecallId;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06007D4D RID: 32077 RVA: 0x00129BB8 File Offset: 0x00127DB8
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

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x00129C1C File Offset: 0x00127E1C
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

		// Token: 0x04004867 RID: 18535
		private IRecallEntry Instance;

		// Token: 0x04004868 RID: 18536
		private List<int> _IncludeGroupsCache;

		// Token: 0x04004869 RID: 18537
		private bool _IncludeGroupsInited;

		// Token: 0x0400486A RID: 18538
		private List<int> _ExcludeGroupsCache;

		// Token: 0x0400486B RID: 18539
		private bool _ExcludeGroupsInited;
	}
}
