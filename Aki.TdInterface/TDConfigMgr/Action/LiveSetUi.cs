using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002328 RID: 9000
	public class LiveSetUi : ActionParams
	{
		// Token: 0x0600C3FA RID: 50170 RVA: 0x001C1D6C File Offset: 0x001BFF6C
		private LiveSetUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LiveSetUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LiveSetUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LiveSetUi_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x001C1DA4 File Offset: 0x001BFFA4
		public static LiveSetUi Create([Nullable(2)] LiveSetUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x001C1DB7 File Offset: 0x001BFFB7
		public static LiveSetUi CreateFromSetValue([Nullable(2)] LiveSetUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LiveSetUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3FD RID: 50173 RVA: 0x001C1DCA File Offset: 0x001BFFCA
		public LiveSetUi_SetValue ToSetValue()
		{
			return new LiveSetUi_SetValue
			{
				UiConfig = this.UiConfig
			};
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600C3FE RID: 50174 RVA: 0x001C1DDD File Offset: 0x001BFFDD
		// (set) Token: 0x0600C3FF RID: 50175 RVA: 0x001C1E04 File Offset: 0x001C0004
		public virtual ILiveUiConfig UiConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiConfig;
				}
				LiveSetUi_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiConfig;
			}
			set
			{
				this.GetOrCreatePoco().UiConfig = value;
			}
		}

		// Token: 0x040074BC RID: 29884
		[Nullable(2)]
		protected new LiveSetUi FbInstance;

		// Token: 0x040074BD RID: 29885
		[Nullable(2)]
		protected LiveSetUi_SetValue PocoInterface;
	}
}
