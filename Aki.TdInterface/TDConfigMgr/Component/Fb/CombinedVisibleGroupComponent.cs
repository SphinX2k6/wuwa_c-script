using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCF RID: 3279
	public class CombinedVisibleGroupComponent : IComponentBase
	{
		// Token: 0x06004AEC RID: 19180 RVA: 0x000BC407 File Offset: 0x000BA607
		public static CombinedVisibleGroupComponent Create(ICombinedVisibleGroupComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CombinedVisibleGroupComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x000BC428 File Offset: 0x000BA628
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06004AEE RID: 19182 RVA: 0x000BC460 File Offset: 0x000BA660
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x000BC478 File Offset: 0x000BA678
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

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x000BC4DC File Offset: 0x000BA6DC
		public virtual bool IncludeSubArea
		{
			get
			{
				return this.Instance.IncludeSubArea;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x000BC4EC File Offset: 0x000BA6EC
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

		// Token: 0x04002A6C RID: 10860
		private ICombinedVisibleGroupComponent Instance;

		// Token: 0x04002A6D RID: 10861
		private List<int> _AreaIdsCache;

		// Token: 0x04002A6E RID: 10862
		private bool _AreaIdsInited;

		// Token: 0x04002A6F RID: 10863
		private List<int> _EntityIdsCache;

		// Token: 0x04002A70 RID: 10864
		private bool _EntityIdsInited;
	}
}
