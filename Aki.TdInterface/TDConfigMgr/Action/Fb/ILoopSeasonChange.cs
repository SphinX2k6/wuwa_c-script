using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B75 RID: 11125
	public class ILoopSeasonChange : IClientSetSeasonStateConfig
	{
		// Token: 0x0600F469 RID: 62569 RVA: 0x0023A3C8 File Offset: 0x002385C8
		public static ILoopSeasonChange Create(ILoopSeasonChange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILoopSeasonChange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x0600F46A RID: 62570 RVA: 0x0023A3E7 File Offset: 0x002385E7
		public override EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x0600F46B RID: 62571 RVA: 0x0023A3F4 File Offset: 0x002385F4
		public virtual bool EnableLoop
		{
			get
			{
				return this.Instance.EnableLoop;
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x0600F46C RID: 62572 RVA: 0x0023A401 File Offset: 0x00238601
		public virtual ISeasonLoopConfig SpringConfig
		{
			get
			{
				if (this._SpringConfigInited)
				{
					return this._SpringConfigCache;
				}
				this._SpringConfigInited = true;
				this._SpringConfigCache = ISeasonLoopConfig.Create(this.Instance.SpringConfig);
				return this._SpringConfigCache;
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x0600F46D RID: 62573 RVA: 0x0023A435 File Offset: 0x00238635
		public virtual ISeasonLoopConfig SummerConfig
		{
			get
			{
				if (this._SummerConfigInited)
				{
					return this._SummerConfigCache;
				}
				this._SummerConfigInited = true;
				this._SummerConfigCache = ISeasonLoopConfig.Create(this.Instance.SummerConfig);
				return this._SummerConfigCache;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x0600F46E RID: 62574 RVA: 0x0023A469 File Offset: 0x00238669
		public virtual ISeasonLoopConfig AutumnConfig
		{
			get
			{
				if (this._AutumnConfigInited)
				{
					return this._AutumnConfigCache;
				}
				this._AutumnConfigInited = true;
				this._AutumnConfigCache = ISeasonLoopConfig.Create(this.Instance.AutumnConfig);
				return this._AutumnConfigCache;
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x0600F46F RID: 62575 RVA: 0x0023A49D File Offset: 0x0023869D
		public virtual ISeasonLoopConfig WinterConfig
		{
			get
			{
				if (this._WinterConfigInited)
				{
					return this._WinterConfigCache;
				}
				this._WinterConfigInited = true;
				this._WinterConfigCache = ISeasonLoopConfig.Create(this.Instance.WinterConfig);
				return this._WinterConfigCache;
			}
		}

		// Token: 0x04008605 RID: 34309
		private ILoopSeasonChange Instance;

		// Token: 0x04008606 RID: 34310
		[Nullable(2)]
		private ISeasonLoopConfig _SpringConfigCache;

		// Token: 0x04008607 RID: 34311
		private bool _SpringConfigInited;

		// Token: 0x04008608 RID: 34312
		[Nullable(2)]
		private ISeasonLoopConfig _SummerConfigCache;

		// Token: 0x04008609 RID: 34313
		private bool _SummerConfigInited;

		// Token: 0x0400860A RID: 34314
		[Nullable(2)]
		private ISeasonLoopConfig _AutumnConfigCache;

		// Token: 0x0400860B RID: 34315
		private bool _AutumnConfigInited;

		// Token: 0x0400860C RID: 34316
		[Nullable(2)]
		private ISeasonLoopConfig _WinterConfigCache;

		// Token: 0x0400860D RID: 34317
		private bool _WinterConfigInited;
	}
}
