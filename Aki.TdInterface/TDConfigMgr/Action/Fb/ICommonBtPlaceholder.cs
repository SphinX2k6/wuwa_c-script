using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7B RID: 10875
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonBtPlaceholder
	{
		// Token: 0x0600EF0F RID: 61199 RVA: 0x0022C567 File Offset: 0x0022A767
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

		// Token: 0x17004BDB RID: 19419
		// (get) Token: 0x0600EF10 RID: 61200 RVA: 0x0022C586 File Offset: 0x0022A786
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17004BDC RID: 19420
		// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x0022C593 File Offset: 0x0022A793
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x0600EF12 RID: 61202 RVA: 0x0022C5A0 File Offset: 0x0022A7A0
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

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x0022C5D0 File Offset: 0x0022A7D0
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

		// Token: 0x04008389 RID: 33673
		private ICommonBtPlaceholder Instance;

		// Token: 0x0400838A RID: 33674
		private ICommonBtOverrideTaskInfoBase _ValueCache;

		// Token: 0x0400838B RID: 33675
		private bool _ValueInited;

		// Token: 0x0400838C RID: 33676
		private List<int> _RefTaskIdsCache;

		// Token: 0x0400838D RID: 33677
		private bool _RefTaskIdsInited;
	}
}
