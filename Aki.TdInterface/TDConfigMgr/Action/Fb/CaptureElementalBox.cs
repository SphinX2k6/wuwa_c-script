using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DFE RID: 11774
	public class CaptureElementalBox : ActionParams
	{
		// Token: 0x0600FFF6 RID: 65526 RVA: 0x0024DA08 File Offset: 0x0024BC08
		public static CaptureElementalBox Create(ICaptureElementalBox? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CaptureElementalBox
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x0600FFF7 RID: 65527 RVA: 0x0024DA27 File Offset: 0x0024BC27
		public virtual IControlElementalBoxTypeBase CtrlConfig
		{
			get
			{
				if (this._CtrlConfigInited)
				{
					return this._CtrlConfigCache;
				}
				this._CtrlConfigInited = true;
				this._CtrlConfigCache = ActionReadHelper.ReadCaptureElementalBox_CtrlConfig(this.Instance);
				return this._CtrlConfigCache;
			}
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x0600FFF8 RID: 65528 RVA: 0x0024DA56 File Offset: 0x0024BC56
		public virtual IElementalBoxTargetPosTypeBase TargetPosConfig
		{
			get
			{
				if (this._TargetPosConfigInited)
				{
					return this._TargetPosConfigCache;
				}
				this._TargetPosConfigInited = true;
				this._TargetPosConfigCache = ActionReadHelper.ReadCaptureElementalBox_TargetPosConfig(this.Instance);
				return this._TargetPosConfigCache;
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x0600FFF9 RID: 65529 RVA: 0x0024DA85 File Offset: 0x0024BC85
		public virtual float MoveSpeed
		{
			get
			{
				return this.Instance.MoveSpeed;
			}
		}

		// Token: 0x04008BB0 RID: 35760
		private ICaptureElementalBox Instance;

		// Token: 0x04008BB1 RID: 35761
		private IControlElementalBoxTypeBase _CtrlConfigCache;

		// Token: 0x04008BB2 RID: 35762
		private bool _CtrlConfigInited;

		// Token: 0x04008BB3 RID: 35763
		private IElementalBoxTargetPosTypeBase _TargetPosConfigCache;

		// Token: 0x04008BB4 RID: 35764
		private bool _TargetPosConfigInited;
	}
}
