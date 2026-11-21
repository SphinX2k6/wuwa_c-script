using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0F RID: 11279
	public class IMotorRadioUiFunction : EnableFunction
	{
		// Token: 0x0600F84E RID: 63566 RVA: 0x00241A95 File Offset: 0x0023FC95
		public static IMotorRadioUiFunction Create(IMotorRadioUiFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioUiFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x0600F84F RID: 63567 RVA: 0x00241AB4 File Offset: 0x0023FCB4
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x0600F850 RID: 63568 RVA: 0x00241AC1 File Offset: 0x0023FCC1
		public virtual IMotorRadioOperationRestriction DisplayMode
		{
			get
			{
				if (this._DisplayModeInited)
				{
					return this._DisplayModeCache;
				}
				this._DisplayModeInited = true;
				this._DisplayModeCache = ActionReadHelper.ReadIMotorRadioUiFunction_DisplayMode(this.Instance);
				return this._DisplayModeCache;
			}
		}

		// Token: 0x040087DD RID: 34781
		private IMotorRadioUiFunction Instance;

		// Token: 0x040087DE RID: 34782
		private IMotorRadioOperationRestriction _DisplayModeCache;

		// Token: 0x040087DF RID: 34783
		private bool _DisplayModeInited;
	}
}
