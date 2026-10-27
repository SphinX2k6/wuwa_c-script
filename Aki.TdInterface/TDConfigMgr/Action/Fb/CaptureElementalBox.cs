using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0A RID: 11018
	[NullableContext(1)]
	[Nullable(0)]
	public class CaptureElementalBox : ActionParams
	{
		// Token: 0x0600F140 RID: 61760 RVA: 0x0022FCFC File Offset: 0x0022DEFC
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

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x0600F141 RID: 61761 RVA: 0x0022FD1B File Offset: 0x0022DF1B
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

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x0600F142 RID: 61762 RVA: 0x0022FD4A File Offset: 0x0022DF4A
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

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x0600F143 RID: 61763 RVA: 0x0022FD79 File Offset: 0x0022DF79
		public virtual float MoveSpeed
		{
			get
			{
				return this.Instance.MoveSpeed;
			}
		}

		// Token: 0x040084AC RID: 33964
		private ICaptureElementalBox Instance;

		// Token: 0x040084AD RID: 33965
		private IControlElementalBoxTypeBase _CtrlConfigCache;

		// Token: 0x040084AE RID: 33966
		private bool _CtrlConfigInited;

		// Token: 0x040084AF RID: 33967
		private IElementalBoxTargetPosTypeBase _TargetPosConfigCache;

		// Token: 0x040084B0 RID: 33968
		private bool _TargetPosConfigInited;
	}
}
