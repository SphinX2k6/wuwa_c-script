using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AE RID: 10158
	public class SetHeadIconVisible : ActionParams
	{
		// Token: 0x0600E0E1 RID: 57569 RVA: 0x0021135F File Offset: 0x0020F55F
		public static SetHeadIconVisible Create(ISetHeadIconVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetHeadIconVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x0021137E File Offset: 0x0020F57E
		public virtual IHeadStyle HeadStyleConfig
		{
			get
			{
				if (this._HeadStyleConfigInited)
				{
					return this._HeadStyleConfigCache;
				}
				this._HeadStyleConfigInited = true;
				this._HeadStyleConfigCache = ActionReadHelper.ReadSetHeadIconVisible_HeadStyleConfig(this.Instance);
				return this._HeadStyleConfigCache;
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600E0E3 RID: 57571 RVA: 0x002113AD File Offset: 0x0020F5AD
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x04007A44 RID: 31300
		private ISetHeadIconVisible Instance;

		// Token: 0x04007A45 RID: 31301
		private IHeadStyle _HeadStyleConfigCache;

		// Token: 0x04007A46 RID: 31302
		private bool _HeadStyleConfigInited;
	}
}
