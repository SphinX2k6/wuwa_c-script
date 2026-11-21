using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8D RID: 7821
	public class Invoke : ActionParams
	{
		// Token: 0x0600A645 RID: 42565 RVA: 0x0017AD64 File Offset: 0x00178F64
		private Invoke_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Invoke 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Invoke_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Invoke_SetValue());
			}
			return result;
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x0017AD9C File Offset: 0x00178F9C
		public static Invoke Create([Nullable(2)] Invoke instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Invoke
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x0017ADAF File Offset: 0x00178FAF
		public static Invoke CreateFromSetValue([Nullable(2)] Invoke_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Invoke
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x0017ADC2 File Offset: 0x00178FC2
		public Invoke_SetValue ToSetValue()
		{
			return new Invoke_SetValue
			{
				Who = this.Who,
				ActionInfo = this.ActionInfo
			};
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A649 RID: 42569 RVA: 0x0017ADE1 File Offset: 0x00178FE1
		// (set) Token: 0x0600A64A RID: 42570 RVA: 0x0017AE0C File Offset: 0x0017900C
		public virtual int Who
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Who;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Who;
			}
			set
			{
				this.GetOrCreatePoco().Who = value;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A64B RID: 42571 RVA: 0x0017AE1C File Offset: 0x0017901C
		// (set) Token: 0x0600A64C RID: 42572 RVA: 0x0017AE7D File Offset: 0x0017907D
		public virtual ActionInfo ActionInfo
		{
			get
			{
				if (this._ActionInfoInited)
				{
					return this._ActionInfoCache;
				}
				this._ActionInfoInited = true;
				if (this.FbInstance != null)
				{
					this._ActionInfoCache = ActionInfo.Create(this.FbInstance.ActionInfo);
				}
				else
				{
					Invoke_SetValue pocoInterface = this.PocoInterface;
					this._ActionInfoCache = ((pocoInterface != null) ? pocoInterface.ActionInfo : null);
				}
				return this._ActionInfoCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionInfo = value;
				this._ActionInfoInited = false;
			}
		}

		// Token: 0x0400644A RID: 25674
		[Nullable(2)]
		protected new Invoke FbInstance;

		// Token: 0x0400644B RID: 25675
		[Nullable(2)]
		protected Invoke_SetValue PocoInterface;

		// Token: 0x0400644C RID: 25676
		private ActionInfo _ActionInfoCache;

		// Token: 0x0400644D RID: 25677
		private bool _ActionInfoInited;
	}
}
