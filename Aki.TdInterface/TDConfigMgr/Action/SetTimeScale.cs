using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E6 RID: 8678
	[NullableContext(1)]
	[Nullable(0)]
	public class SetTimeScale : ActionParams
	{
		// Token: 0x0600BEA5 RID: 48805 RVA: 0x001B6C90 File Offset: 0x001B4E90
		private SetTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x001B6CC8 File Offset: 0x001B4EC8
		public static SetTimeScale Create([Nullable(2)] SetTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x001B6CDB File Offset: 0x001B4EDB
		public static SetTimeScale CreateFromSetValue([Nullable(2)] SetTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEA8 RID: 48808 RVA: 0x001B6CEE File Offset: 0x001B4EEE
		public SetTimeScale_SetValue ToSetValue()
		{
			return new SetTimeScale_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600BEA9 RID: 48809 RVA: 0x001B6D04 File Offset: 0x001B4F04
		// (set) Token: 0x0600BEAA RID: 48810 RVA: 0x001B6D65 File Offset: 0x001B4F65
		public virtual ISetGlobalTimeScale Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = ISetGlobalTimeScale.Create(this.FbInstance.Config);
				}
				else
				{
					SetTimeScale_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x040071BD RID: 29117
		[Nullable(2)]
		protected new SetTimeScale FbInstance;

		// Token: 0x040071BE RID: 29118
		[Nullable(2)]
		protected SetTimeScale_SetValue PocoInterface;

		// Token: 0x040071BF RID: 29119
		private ISetGlobalTimeScale _ConfigCache;

		// Token: 0x040071C0 RID: 29120
		private bool _ConfigInited;
	}
}
