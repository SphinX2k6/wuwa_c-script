using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B5 RID: 5557
	public class IRecallConditionByGroup : IRecallConditionBase
	{
		// Token: 0x06007D40 RID: 32064 RVA: 0x00129A30 File Offset: 0x00127C30
		public static IRecallConditionByGroup Create(IRecallConditionByGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06007D41 RID: 32065 RVA: 0x00129A4F File Offset: 0x00127C4F
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x06007D42 RID: 32066 RVA: 0x00129A5C File Offset: 0x00127C5C
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06007D43 RID: 32067 RVA: 0x00129A6C File Offset: 0x00127C6C
		public virtual List<int> GroupIds
		{
			get
			{
				if (this._GroupIdsInited)
				{
					return this._GroupIdsCache;
				}
				this._GroupIdsInited = true;
				int groupIdsLength = this.Instance.GroupIdsLength;
				this._GroupIdsCache = new List<int>(groupIdsLength);
				for (int i = 0; i < groupIdsLength; i++)
				{
					this._GroupIdsCache.Add(this.Instance.GroupIds(i));
				}
				return this._GroupIdsCache;
			}
		}

		// Token: 0x04004861 RID: 18529
		private IRecallConditionByGroup Instance;

		// Token: 0x04004862 RID: 18530
		private List<int> _GroupIdsCache;

		// Token: 0x04004863 RID: 18531
		private bool _GroupIdsInited;
	}
}
