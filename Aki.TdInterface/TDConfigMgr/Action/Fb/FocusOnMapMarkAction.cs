using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4B RID: 11339
	public class FocusOnMapMarkAction : ActionParams
	{
		// Token: 0x0600F961 RID: 63841 RVA: 0x002439C2 File Offset: 0x00241BC2
		public static FocusOnMapMarkAction Create(IFocusOnMapMarkAction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FocusOnMapMarkAction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x0600F962 RID: 63842 RVA: 0x002439E1 File Offset: 0x00241BE1
		public virtual IFocusOnMapMark MapMarkType
		{
			get
			{
				if (this._MapMarkTypeInited)
				{
					return this._MapMarkTypeCache;
				}
				this._MapMarkTypeInited = true;
				this._MapMarkTypeCache = ActionReadHelper.ReadFocusOnMapMarkAction_MapMarkType(this.Instance);
				return this._MapMarkTypeCache;
			}
		}

		// Token: 0x0400884F RID: 34895
		private IFocusOnMapMarkAction Instance;

		// Token: 0x04008850 RID: 34896
		private IFocusOnMapMark _MapMarkTypeCache;

		// Token: 0x04008851 RID: 34897
		private bool _MapMarkTypeInited;
	}
}
