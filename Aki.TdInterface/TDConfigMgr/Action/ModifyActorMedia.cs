using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002334 RID: 9012
	public class ModifyActorMedia : ActionParams
	{
		// Token: 0x0600C430 RID: 50224 RVA: 0x001C2300 File Offset: 0x001C0500
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

		// Token: 0x0600C431 RID: 50225 RVA: 0x001C2338 File Offset: 0x001C0538
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

		// Token: 0x0600C432 RID: 50226 RVA: 0x001C234B File Offset: 0x001C054B
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

		// Token: 0x0600C433 RID: 50227 RVA: 0x001C235E File Offset: 0x001C055E
		public ModifyActorMedia_SetValue ToSetValue()
		{
			return new ModifyActorMedia_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600C434 RID: 50228 RVA: 0x001C2374 File Offset: 0x001C0574
		// (set) Token: 0x0600C435 RID: 50229 RVA: 0x001C23D5 File Offset: 0x001C05D5
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

		// Token: 0x040074D3 RID: 29907
		[Nullable(2)]
		protected new ModifyActorMedia FbInstance;

		// Token: 0x040074D4 RID: 29908
		[Nullable(2)]
		protected ModifyActorMedia_SetValue PocoInterface;

		// Token: 0x040074D5 RID: 29909
		private IChangeMediaPlayDa _ConfigCache;

		// Token: 0x040074D6 RID: 29910
		private bool _ConfigInited;
	}
}
