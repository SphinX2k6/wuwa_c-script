using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015B3 RID: 5555
	public class IRecallConditionByEntityType : IRecallConditionBase
	{
		// Token: 0x06007D34 RID: 32052 RVA: 0x00129819 File Offset: 0x00127A19
		public static IRecallConditionByEntityType Create(IRecallConditionByEntityType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByEntityType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x00129838 File Offset: 0x00127A38
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06007D36 RID: 32054 RVA: 0x00129845 File Offset: 0x00127A45
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06007D37 RID: 32055 RVA: 0x00129854 File Offset: 0x00127A54
		public virtual List<string> EntityTypes
		{
			get
			{
				if (this._EntityTypesInited)
				{
					return this._EntityTypesCache;
				}
				this._EntityTypesInited = true;
				int entityTypesLength = this.Instance.EntityTypesLength;
				this._EntityTypesCache = new List<string>(entityTypesLength);
				for (int i = 0; i < entityTypesLength; i++)
				{
					this._EntityTypesCache.Add(this.Instance.EntityTypes(i));
				}
				return this._EntityTypesCache;
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06007D38 RID: 32056 RVA: 0x001298B8 File Offset: 0x00127AB8
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x04004857 RID: 18519
		private IRecallConditionByEntityType Instance;

		// Token: 0x04004858 RID: 18520
		private List<string> _EntityTypesCache;

		// Token: 0x04004859 RID: 18521
		private bool _EntityTypesInited;

		// Token: 0x0400485A RID: 18522
		private List<int> _AreaIdsCache;

		// Token: 0x0400485B RID: 18523
		private bool _AreaIdsInited;
	}
}
