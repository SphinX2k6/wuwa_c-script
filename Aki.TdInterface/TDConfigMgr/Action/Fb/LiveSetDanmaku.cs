using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E21 RID: 11809
	public class LiveSetDanmaku : ActionParams
	{
		// Token: 0x0601007C RID: 65660 RVA: 0x0024E5C2 File Offset: 0x0024C7C2
		public static LiveSetDanmaku Create(ILiveSetDanmaku? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetDanmaku
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x0601007D RID: 65661 RVA: 0x0024E5E1 File Offset: 0x0024C7E1
		public virtual ILiveDanmakuOperation Operation
		{
			get
			{
				if (this._OperationInited)
				{
					return this._OperationCache;
				}
				this._OperationInited = true;
				this._OperationCache = ActionReadHelper.ReadLiveSetDanmaku_Operation(this.Instance);
				return this._OperationCache;
			}
		}

		// Token: 0x04008BED RID: 35821
		private ILiveSetDanmaku Instance;

		// Token: 0x04008BEE RID: 35822
		private ILiveDanmakuOperation _OperationCache;

		// Token: 0x04008BEF RID: 35823
		private bool _OperationInited;
	}
}
