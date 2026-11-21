using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E7A RID: 3706
	public class ISingleBtnQte : IQteType
	{
		// Token: 0x060053B9 RID: 21433 RVA: 0x000CE726 File Offset: 0x000CC926
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

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x000CE745 File Offset: 0x000CC945
		public override EQteType Type
		{
			get
			{
				return (EQteType)this.Instance.Type;
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x000CE752 File Offset: 0x000CC952
		public override int QteId
		{
			get
			{
				return this.Instance.QteId;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x060053BC RID: 21436 RVA: 0x000CE75F File Offset: 0x000CC95F
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x000CE793 File Offset: 0x000CC993
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

		// Token: 0x04002FE1 RID: 12257
		private ISingleBtnQte Instance;

		// Token: 0x04002FE2 RID: 12258
		[Nullable(2)]
		private IQteCallback _SuccessCallbackCache;

		// Token: 0x04002FE3 RID: 12259
		private bool _SuccessCallbackInited;

		// Token: 0x04002FE4 RID: 12260
		[Nullable(2)]
		private IQteCallback _FailureCallbackCache;

		// Token: 0x04002FE5 RID: 12261
		private bool _FailureCallbackInited;
	}
}
