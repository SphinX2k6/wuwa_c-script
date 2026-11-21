using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E28 RID: 11816
	public class LiveSetParam : ActionParams
	{
		// Token: 0x06010097 RID: 65687 RVA: 0x0024E79E File Offset: 0x0024C99E
		public static LiveSetParam Create(ILiveSetParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x06010098 RID: 65688 RVA: 0x0024E7BD File Offset: 0x0024C9BD
		public virtual ILiveParamConfig Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				this._ParamCache = ActionReadHelper.ReadLiveSetParam_Param(this.Instance);
				return this._ParamCache;
			}
		}

		// Token: 0x04008BF6 RID: 35830
		private ILiveSetParam Instance;

		// Token: 0x04008BF7 RID: 35831
		private ILiveParamConfig _ParamCache;

		// Token: 0x04008BF8 RID: 35832
		private bool _ParamInited;
	}
}
