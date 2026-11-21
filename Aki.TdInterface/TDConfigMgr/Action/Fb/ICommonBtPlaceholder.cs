using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D6F RID: 11631
	public class ICommonBtPlaceholder
	{
		// Token: 0x0600FDC5 RID: 64965 RVA: 0x0024A273 File Offset: 0x00248473
		public static ICommonBtPlaceholder Create(ICommonBtPlaceholder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtPlaceholder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x0600FDC6 RID: 64966 RVA: 0x0024A292 File Offset: 0x00248492
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x0600FDC7 RID: 64967 RVA: 0x0024A29F File Offset: 0x0024849F
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x0600FDC8 RID: 64968 RVA: 0x0024A2AC File Offset: 0x002484AC
		public virtual ICommonBtOverrideTaskInfoBase Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				this._ValueCache = ActionReadHelper.ReadICommonBtPlaceholder_Value(this.Instance);
				return this._ValueCache;
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x0600FDC9 RID: 64969 RVA: 0x0024A2DC File Offset: 0x002484DC
		public virtual List<int> RefTaskIds
		{
			get
			{
				if (this._RefTaskIdsInited)
				{
					return this._RefTaskIdsCache;
				}
				this._RefTaskIdsInited = true;
				int refTaskIdsLength = this.Instance.RefTaskIdsLength;
				this._RefTaskIdsCache = new List<int>(refTaskIdsLength);
				for (int i = 0; i < refTaskIdsLength; i++)
				{
					this._RefTaskIdsCache.Add(this.Instance.RefTaskIds(i));
				}
				return this._RefTaskIdsCache;
			}
		}

		// Token: 0x04008A8D RID: 35469
		private ICommonBtPlaceholder Instance;

		// Token: 0x04008A8E RID: 35470
		private ICommonBtOverrideTaskInfoBase _ValueCache;

		// Token: 0x04008A8F RID: 35471
		private bool _ValueInited;

		// Token: 0x04008A90 RID: 35472
		private List<int> _RefTaskIdsCache;

		// Token: 0x04008A91 RID: 35473
		private bool _RefTaskIdsInited;
	}
}
