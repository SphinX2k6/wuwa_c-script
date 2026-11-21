using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001671 RID: 5745
	public class CommonTip2 : ActionParams
	{
		// Token: 0x06008175 RID: 33141 RVA: 0x001337CC File Offset: 0x001319CC
		private CommonTip2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CommonTip2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CommonTip2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CommonTip2_SetValue());
			}
			return result;
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00133804 File Offset: 0x00131A04
		public static CommonTip2 Create([Nullable(2)] CommonTip2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CommonTip2
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x00133817 File Offset: 0x00131A17
		public static CommonTip2 CreateFromSetValue([Nullable(2)] CommonTip2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CommonTip2
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x0013382A File Offset: 0x00131A2A
		public CommonTip2_SetValue ToSetValue()
		{
			return new CommonTip2_SetValue
			{
				TipOption = this.TipOption
			};
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x06008179 RID: 33145 RVA: 0x00133840 File Offset: 0x00131A40
		// (set) Token: 0x0600817A RID: 33146 RVA: 0x001338A1 File Offset: 0x00131AA1
		public virtual ICommonTip2PrepareCountdown TipOption
		{
			get
			{
				if (this._TipOptionInited)
				{
					return this._TipOptionCache;
				}
				this._TipOptionInited = true;
				if (this.FbInstance != null)
				{
					this._TipOptionCache = ICommonTip2PrepareCountdown.Create(this.FbInstance.TipOption);
				}
				else
				{
					CommonTip2_SetValue pocoInterface = this.PocoInterface;
					this._TipOptionCache = ((pocoInterface != null) ? pocoInterface.TipOption : null);
				}
				return this._TipOptionCache;
			}
			set
			{
				this.GetOrCreatePoco().TipOption = value;
				this._TipOptionInited = false;
			}
		}

		// Token: 0x04004AA2 RID: 19106
		[Nullable(2)]
		protected new CommonTip2 FbInstance;

		// Token: 0x04004AA3 RID: 19107
		[Nullable(2)]
		protected CommonTip2_SetValue PocoInterface;

		// Token: 0x04004AA4 RID: 19108
		private ICommonTip2PrepareCountdown _TipOptionCache;

		// Token: 0x04004AA5 RID: 19109
		private bool _TipOptionInited;
	}
}
