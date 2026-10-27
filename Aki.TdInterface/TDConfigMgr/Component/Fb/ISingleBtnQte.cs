using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7E RID: 3454
	[NullableContext(1)]
	[Nullable(0)]
	public class ISingleBtnQte : IQteType
	{
		// Token: 0x06004E94 RID: 20116 RVA: 0x000C2ED6 File Offset: 0x000C10D6
		public static ISingleBtnQte Create(ISingleBtnQte? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISingleBtnQte
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x000C2EF5 File Offset: 0x000C10F5
		public override EQteType Type
		{
			get
			{
				return (EQteType)this.Instance.Type;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004E96 RID: 20118 RVA: 0x000C2F02 File Offset: 0x000C1102
		public override int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x000C2F0F File Offset: 0x000C110F
		public virtual IQteCallback SuccessCallback
		{
			get
			{
				if (this._SuccessCallbackInited)
				{
					return this._SuccessCallbackCache;
				}
				this._SuccessCallbackInited = true;
				this._SuccessCallbackCache = IQteCallback.Create(this.Instance.SuccessCallback);
				return this._SuccessCallbackCache;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x000C2F43 File Offset: 0x000C1143
		public virtual IQteCallback FailureCallback
		{
			get
			{
				if (this._FailureCallbackInited)
				{
					return this._FailureCallbackCache;
				}
				this._FailureCallbackInited = true;
				this._FailureCallbackCache = IQteCallback.Create(this.Instance.FailureCallback);
				return this._FailureCallbackCache;
			}
		}

		// Token: 0x04002D1B RID: 11547
		private ISingleBtnQte Instance;

		// Token: 0x04002D1C RID: 11548
		[Nullable(2)]
		private IQteCallback _SuccessCallbackCache;

		// Token: 0x04002D1D RID: 11549
		private bool _SuccessCallbackInited;

		// Token: 0x04002D1E RID: 11550
		[Nullable(2)]
		private IQteCallback _FailureCallbackCache;

		// Token: 0x04002D1F RID: 11551
		private bool _FailureCallbackInited;
	}
}
