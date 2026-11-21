using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002451 RID: 9297
	public class SetTimeScale : ActionParams
	{
		// Token: 0x0600CA61 RID: 51809 RVA: 0x001CE31C File Offset: 0x001CC51C
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

		// Token: 0x0600CA62 RID: 51810 RVA: 0x001CE354 File Offset: 0x001CC554
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

		// Token: 0x0600CA63 RID: 51811 RVA: 0x001CE367 File Offset: 0x001CC567
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

		// Token: 0x0600CA64 RID: 51812 RVA: 0x001CE37A File Offset: 0x001CC57A
		public SetTimeScale_SetValue ToSetValue()
		{
			return new SetTimeScale_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600CA65 RID: 51813 RVA: 0x001CE390 File Offset: 0x001CC590
		// (set) Token: 0x0600CA66 RID: 51814 RVA: 0x001CE3F1 File Offset: 0x001CC5F1
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

		// Token: 0x04007806 RID: 30726
		[Nullable(2)]
		protected new SetTimeScale FbInstance;

		// Token: 0x04007807 RID: 30727
		[Nullable(2)]
		protected SetTimeScale_SetValue PocoInterface;

		// Token: 0x04007808 RID: 30728
		private ISetGlobalTimeScale _ConfigCache;

		// Token: 0x04007809 RID: 30729
		private bool _ConfigInited;
	}
}
