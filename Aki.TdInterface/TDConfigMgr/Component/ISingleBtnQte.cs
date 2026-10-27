using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006CE RID: 1742
	[NullableContext(1)]
	[Nullable(0)]
	public class ISingleBtnQte : IQteType
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x00064C38 File Offset: 0x00062E38
		private ISingleBtnQte_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISingleBtnQte 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISingleBtnQte_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISingleBtnQte_SetValue());
			}
			return result;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00064C70 File Offset: 0x00062E70
		public static ISingleBtnQte Create([Nullable(2)] ISingleBtnQte instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISingleBtnQte
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00064C83 File Offset: 0x00062E83
		public static ISingleBtnQte CreateFromSetValue([Nullable(2)] ISingleBtnQte_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISingleBtnQte
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00064C96 File Offset: 0x00062E96
		public new ISingleBtnQte_SetValue ToSetValue()
		{
			return new ISingleBtnQte_SetValue
			{
				Type = this.Type,
				QteId = this.QteId,
				SuccessCallback = this.SuccessCallback,
				FailureCallback = this.FailureCallback
			};
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x00064CCD File Offset: 0x00062ECD
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x00064CF8 File Offset: 0x00062EF8
		public override EQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EQteType.SingleBtn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x00064D06 File Offset: 0x00062F06
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00064D31 File Offset: 0x00062F31
		public override int QteId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QteId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QteId;
			}
			set
			{
				this.GetOrCreatePoco().QteId = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x00064D40 File Offset: 0x00062F40
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00064DA1 File Offset: 0x00062FA1
		public virtual IQteCallback SuccessCallback
		{
			get
			{
				if (this._SuccessCallbackInited)
				{
					return this._SuccessCallbackCache;
				}
				this._SuccessCallbackInited = true;
				if (this.FbInstance != null)
				{
					this._SuccessCallbackCache = IQteCallback.Create(this.FbInstance.SuccessCallback);
				}
				else
				{
					ISingleBtnQte_SetValue pocoInterface = this.PocoInterface;
					this._SuccessCallbackCache = ((pocoInterface != null) ? pocoInterface.SuccessCallback : null);
				}
				return this._SuccessCallbackCache;
			}
			set
			{
				this.GetOrCreatePoco().SuccessCallback = value;
				this._SuccessCallbackInited = false;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x00064DB8 File Offset: 0x00062FB8
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00064E19 File Offset: 0x00063019
		public virtual IQteCallback FailureCallback
		{
			get
			{
				if (this._FailureCallbackInited)
				{
					return this._FailureCallbackCache;
				}
				this._FailureCallbackInited = true;
				if (this.FbInstance != null)
				{
					this._FailureCallbackCache = IQteCallback.Create(this.FbInstance.FailureCallback);
				}
				else
				{
					ISingleBtnQte_SetValue pocoInterface = this.PocoInterface;
					this._FailureCallbackCache = ((pocoInterface != null) ? pocoInterface.FailureCallback : null);
				}
				return this._FailureCallbackCache;
			}
			set
			{
				this.GetOrCreatePoco().FailureCallback = value;
				this._FailureCallbackInited = false;
			}
		}

		// Token: 0x0400198C RID: 6540
		[Nullable(2)]
		protected new ISingleBtnQte FbInstance;

		// Token: 0x0400198D RID: 6541
		[Nullable(2)]
		protected new ISingleBtnQte_SetValue PocoInterface;

		// Token: 0x0400198E RID: 6542
		private IQteCallback _SuccessCallbackCache;

		// Token: 0x0400198F RID: 6543
		private bool _SuccessCallbackInited;

		// Token: 0x04001990 RID: 6544
		private IQteCallback _FailureCallbackCache;

		// Token: 0x04001991 RID: 6545
		private bool _FailureCallbackInited;
	}
}
