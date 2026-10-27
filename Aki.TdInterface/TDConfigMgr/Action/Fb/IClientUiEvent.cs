using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A48 RID: 10824
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientUiEvent : IClientEventTarget
	{
		// Token: 0x0600EE44 RID: 60996 RVA: 0x0022B20D File Offset: 0x0022940D
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

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x0600EE45 RID: 60997 RVA: 0x0022B22C File Offset: 0x0022942C
		public override EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x0600EE46 RID: 60998 RVA: 0x0022B239 File Offset: 0x00229439
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

		// Token: 0x0400831E RID: 33566
		private IClientUiEvent Instance;

		// Token: 0x0400831F RID: 33567
		private IClientEventUi _UiCache;

		// Token: 0x04008320 RID: 33568
		private bool _UiInited;
	}
}
