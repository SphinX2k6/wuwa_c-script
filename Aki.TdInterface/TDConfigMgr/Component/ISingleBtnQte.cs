using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200076F RID: 1903
	public class ISingleBtnQte : IQteType
	{
		// Token: 0x0600288C RID: 10380 RVA: 0x0006BCA8 File Offset: 0x00069EA8
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

		// Token: 0x0600288D RID: 10381 RVA: 0x0006BCE0 File Offset: 0x00069EE0
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

		// Token: 0x0600288E RID: 10382 RVA: 0x0006BCF3 File Offset: 0x00069EF3
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

		// Token: 0x0600288F RID: 10383 RVA: 0x0006BD06 File Offset: 0x00069F06
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

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0006BD3D File Offset: 0x00069F3D
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0006BD68 File Offset: 0x00069F68
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

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0006BD76 File Offset: 0x00069F76
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0006BDA1 File Offset: 0x00069FA1
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

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0006BDB0 File Offset: 0x00069FB0
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x0006BE11 File Offset: 0x0006A011
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

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x0006BE28 File Offset: 0x0006A028
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0006BE89 File Offset: 0x0006A089
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

		// Token: 0x04001B8B RID: 7051
		[Nullable(2)]
		protected new ISingleBtnQte FbInstance;

		// Token: 0x04001B8C RID: 7052
		[Nullable(2)]
		protected new ISingleBtnQte_SetValue PocoInterface;

		// Token: 0x04001B8D RID: 7053
		private IQteCallback _SuccessCallbackCache;

		// Token: 0x04001B8E RID: 7054
		private bool _SuccessCallbackInited;

		// Token: 0x04001B8F RID: 7055
		private IQteCallback _FailureCallbackCache;

		// Token: 0x04001B90 RID: 7056
		private bool _FailureCallbackInited;
	}
}
