using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F4D RID: 3917
	public class IFrequencyPaintConfig
	{
		// Token: 0x060057DE RID: 22494 RVA: 0x000D6FB4 File Offset: 0x000D51B4
		public static IFrequencyPaintConfig Create(IFrequencyPaintConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x060057DF RID: 22495 RVA: 0x000D6FD3 File Offset: 0x000D51D3
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x060057E0 RID: 22496 RVA: 0x000D6FE0 File Offset: 0x000D51E0
		public virtual IFrequencyPaintLineBase LineType
		{
			get
			{
				if (this._LineTypeInited)
				{
					return this._LineTypeCache;
				}
				this._LineTypeInited = true;
				this._LineTypeCache = ComponentReadHelper.ReadIFrequencyPaintConfig_LineType(this.Instance);
				return this._LineTypeCache;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x000D7010 File Offset: 0x000D5210
		public virtual List<ActionInfo> SuccessActions
		{
			get
			{
				if (this._SuccessActionsInited)
				{
					return this._SuccessActionsCache;
				}
				this._SuccessActionsInited = true;
				int successActionsLength = this.Instance.SuccessActionsLength;
				this._SuccessActionsCache = new List<ActionInfo>(successActionsLength);
				for (int i = 0; i < successActionsLength; i++)
				{
					this._SuccessActionsCache.Add(ActionInfo.Create(this.Instance.SuccessActions(i)));
				}
				return this._SuccessActionsCache;
			}
		}

		// Token: 0x04003270 RID: 12912
		private IFrequencyPaintConfig Instance;

		// Token: 0x04003271 RID: 12913
		private IFrequencyPaintLineBase _LineTypeCache;

		// Token: 0x04003272 RID: 12914
		private bool _LineTypeInited;

		// Token: 0x04003273 RID: 12915
		private List<ActionInfo> _SuccessActionsCache;

		// Token: 0x04003274 RID: 12916
		private bool _SuccessActionsInited;
	}
}
