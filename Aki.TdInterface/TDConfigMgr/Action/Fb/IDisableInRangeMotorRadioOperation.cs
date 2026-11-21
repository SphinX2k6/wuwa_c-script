using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C19 RID: 11289
	public class IDisableInRangeMotorRadioOperation : IMotorRadioOperationRestriction
	{
		// Token: 0x0600F873 RID: 63603 RVA: 0x00241DED File Offset: 0x0023FFED
		public static IDisableInRangeMotorRadioOperation Create(IDisableInRangeMotorRadioOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableInRangeMotorRadioOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x0600F874 RID: 63604 RVA: 0x00241E0C File Offset: 0x0024000C
		public override EMotorRadioOperationType Type
		{
			get
			{
				return (EMotorRadioOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x0600F875 RID: 63605 RVA: 0x00241E19 File Offset: 0x00240019
		public virtual string RangeKey
		{
			get
			{
				return this.Instance.RangeKey;
			}
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x0600F876 RID: 63606 RVA: 0x00241E26 File Offset: 0x00240026
		public virtual IMotorRadioDisableRange DisableRangeType
		{
			get
			{
				if (this._DisableRangeTypeInited)
				{
					return this._DisableRangeTypeCache;
				}
				this._DisableRangeTypeInited = true;
				this._DisableRangeTypeCache = ActionReadHelper.ReadIDisableInRangeMotorRadioOperation_DisableRangeType(this.Instance);
				return this._DisableRangeTypeCache;
			}
		}

		// Token: 0x040087EF RID: 34799
		private IDisableInRangeMotorRadioOperation Instance;

		// Token: 0x040087F0 RID: 34800
		private IMotorRadioDisableRange _DisableRangeTypeCache;

		// Token: 0x040087F1 RID: 34801
		private bool _DisableRangeTypeInited;
	}
}
