using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002933 RID: 10547
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorRadioUiFunction : EnableFunction
	{
		// Token: 0x0600E9FC RID: 59900 RVA: 0x0022473D File Offset: 0x0022293D
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

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x0022475C File Offset: 0x0022295C
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x0600E9FE RID: 59902 RVA: 0x00224769 File Offset: 0x00222969
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

		// Token: 0x0400810F RID: 33039
		private IMotorRadioUiFunction Instance;

		// Token: 0x04008110 RID: 33040
		private IMotorRadioOperationRestriction _DisplayModeCache;

		// Token: 0x04008111 RID: 33041
		private bool _DisplayModeInited;
	}
}
