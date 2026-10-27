using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001518 RID: 5400
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTip2 : ActionParams
	{
		// Token: 0x06007AAA RID: 31402 RVA: 0x00124BA4 File Offset: 0x00122DA4
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

		// Token: 0x06007AAB RID: 31403 RVA: 0x00124BDC File Offset: 0x00122DDC
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

		// Token: 0x06007AAC RID: 31404 RVA: 0x00124BEF File Offset: 0x00122DEF
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

		// Token: 0x06007AAD RID: 31405 RVA: 0x00124C02 File Offset: 0x00122E02
		public CommonTip2_SetValue ToSetValue()
		{
			return new CommonTip2_SetValue
			{
				TipOption = this.TipOption
			};
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x00124C18 File Offset: 0x00122E18
		// (set) Token: 0x06007AAF RID: 31407 RVA: 0x00124C79 File Offset: 0x00122E79
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

		// Token: 0x04004706 RID: 18182
		[Nullable(2)]
		protected new CommonTip2 FbInstance;

		// Token: 0x04004707 RID: 18183
		[Nullable(2)]
		protected CommonTip2_SetValue PocoInterface;

		// Token: 0x04004708 RID: 18184
		private ICommonTip2PrepareCountdown _TipOptionCache;

		// Token: 0x04004709 RID: 18185
		private bool _TipOptionInited;
	}
}
