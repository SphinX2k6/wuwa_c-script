using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002238 RID: 8760
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportToLatestResetPoint : ActionParams
	{
		// Token: 0x0600C03E RID: 49214 RVA: 0x001B9AC4 File Offset: 0x001B7CC4
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

		// Token: 0x0600C03F RID: 49215 RVA: 0x001B9AFC File Offset: 0x001B7CFC
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

		// Token: 0x0600C040 RID: 49216 RVA: 0x001B9B0F File Offset: 0x001B7D0F
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

		// Token: 0x0600C041 RID: 49217 RVA: 0x001B9B22 File Offset: 0x001B7D22
		public TeleportToLatestResetPoint_SetValue ToSetValue()
		{
			return new TeleportToLatestResetPoint_SetValue
			{
				Option = this.Option
			};
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600C042 RID: 49218 RVA: 0x001B9B38 File Offset: 0x001B7D38
		// (set) Token: 0x0600C043 RID: 49219 RVA: 0x001B9B99 File Offset: 0x001B7D99
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

		// Token: 0x040072A1 RID: 29345
		[Nullable(2)]
		protected new TeleportToLatestResetPoint FbInstance;

		// Token: 0x040072A2 RID: 29346
		[Nullable(2)]
		protected TeleportToLatestResetPoint_SetValue PocoInterface;

		// Token: 0x040072A3 RID: 29347
		private ITeleportToLatestResetPointDirectly _OptionCache;

		// Token: 0x040072A4 RID: 29348
		private bool _OptionInited;
	}
}
