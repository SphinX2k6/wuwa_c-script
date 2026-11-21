using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A3 RID: 9379
	public class TeleportToLatestResetPoint : ActionParams
	{
		// Token: 0x0600CBFC RID: 52220 RVA: 0x001D1190 File Offset: 0x001CF390
		private TeleportToLatestResetPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TeleportToLatestResetPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TeleportToLatestResetPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TeleportToLatestResetPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x001D11C8 File Offset: 0x001CF3C8
		public static TeleportToLatestResetPoint Create([Nullable(2)] TeleportToLatestResetPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportToLatestResetPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x001D11DB File Offset: 0x001CF3DB
		public static TeleportToLatestResetPoint CreateFromSetValue([Nullable(2)] TeleportToLatestResetPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TeleportToLatestResetPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x001D11EE File Offset: 0x001CF3EE
		public TeleportToLatestResetPoint_SetValue ToSetValue()
		{
			return new TeleportToLatestResetPoint_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600CC00 RID: 52224 RVA: 0x001D1204 File Offset: 0x001CF404
		// (set) Token: 0x0600CC01 RID: 52225 RVA: 0x001D1265 File Offset: 0x001CF465
		public virtual ITeleportToLatestResetPointDirectly Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = ITeleportToLatestResetPointDirectly.Create(this.FbInstance.Option);
				}
				else
				{
					TeleportToLatestResetPoint_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x040078EB RID: 30955
		[Nullable(2)]
		protected new TeleportToLatestResetPoint FbInstance;

		// Token: 0x040078EC RID: 30956
		[Nullable(2)]
		protected TeleportToLatestResetPoint_SetValue PocoInterface;

		// Token: 0x040078ED RID: 30957
		private ITeleportToLatestResetPointDirectly _OptionCache;

		// Token: 0x040078EE RID: 30958
		private bool _OptionInited;
	}
}
