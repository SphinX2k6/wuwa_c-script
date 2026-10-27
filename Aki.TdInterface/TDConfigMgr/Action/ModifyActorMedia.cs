using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D7 RID: 8407
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifyActorMedia : ActionParams
	{
		// Token: 0x0600B8B8 RID: 47288 RVA: 0x001AB3D8 File Offset: 0x001A95D8
		private ModifyActorMedia_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ModifyActorMedia 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ModifyActorMedia_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ModifyActorMedia_SetValue());
			}
			return result;
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x001AB410 File Offset: 0x001A9610
		public static ModifyActorMedia Create([Nullable(2)] ModifyActorMedia instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifyActorMedia
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x001AB423 File Offset: 0x001A9623
		public static ModifyActorMedia CreateFromSetValue([Nullable(2)] ModifyActorMedia_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ModifyActorMedia
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B8BB RID: 47291 RVA: 0x001AB436 File Offset: 0x001A9636
		public ModifyActorMedia_SetValue ToSetValue()
		{
			return new ModifyActorMedia_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600B8BC RID: 47292 RVA: 0x001AB44C File Offset: 0x001A964C
		// (set) Token: 0x0600B8BD RID: 47293 RVA: 0x001AB4AD File Offset: 0x001A96AD
		public virtual IChangeMediaPlayDa Config
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
					this._ConfigCache = IChangeMediaPlayDa.Create(this.FbInstance.Config);
				}
				else
				{
					ModifyActorMedia_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006EA9 RID: 28329
		[Nullable(2)]
		protected new ModifyActorMedia FbInstance;

		// Token: 0x04006EAA RID: 28330
		[Nullable(2)]
		protected ModifyActorMedia_SetValue PocoInterface;

		// Token: 0x04006EAB RID: 28331
		private IChangeMediaPlayDa _ConfigCache;

		// Token: 0x04006EAC RID: 28332
		private bool _ConfigInited;
	}
}
