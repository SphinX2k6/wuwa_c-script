using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D35 RID: 11573
	public class IClientUiEvent : IClientEventTarget
	{
		// Token: 0x0600FCDC RID: 64732 RVA: 0x00248BC1 File Offset: 0x00246DC1
		public static IClientUiEvent Create(IClientUiEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientUiEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F20 RID: 20256
		// (get) Token: 0x0600FCDD RID: 64733 RVA: 0x00248BE0 File Offset: 0x00246DE0
		public override EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004F21 RID: 20257
		// (get) Token: 0x0600FCDE RID: 64734 RVA: 0x00248BED File Offset: 0x00246DED
		public virtual IClientEventUi Ui
		{
			get
			{
				if (this._UiInited)
				{
					return this._UiCache;
				}
				this._UiInited = true;
				this._UiCache = ActionReadHelper.ReadIClientUiEvent_Ui(this.Instance);
				return this._UiCache;
			}
		}

		// Token: 0x04008A11 RID: 35345
		private IClientUiEvent Instance;

		// Token: 0x04008A12 RID: 35346
		private IClientEventUi _UiCache;

		// Token: 0x04008A13 RID: 35347
		private bool _UiInited;
	}
}
