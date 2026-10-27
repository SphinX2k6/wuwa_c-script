using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002236 RID: 8758
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportToAndEnterVehicle : ActionParams
	{
		// Token: 0x0600C036 RID: 49206 RVA: 0x001B99C8 File Offset: 0x001B7BC8
		private TeleportToAndEnterVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TeleportToAndEnterVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TeleportToAndEnterVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TeleportToAndEnterVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x001B9A00 File Offset: 0x001B7C00
		public static TeleportToAndEnterVehicle Create([Nullable(2)] TeleportToAndEnterVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportToAndEnterVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x001B9A13 File Offset: 0x001B7C13
		public static TeleportToAndEnterVehicle CreateFromSetValue([Nullable(2)] TeleportToAndEnterVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TeleportToAndEnterVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C039 RID: 49209 RVA: 0x001B9A26 File Offset: 0x001B7C26
		public TeleportToAndEnterVehicle_SetValue ToSetValue()
		{
			return new TeleportToAndEnterVehicle_SetValue
			{
				ToVehicle = this.ToVehicle
			};
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600C03A RID: 49210 RVA: 0x001B9A3C File Offset: 0x001B7C3C
		// (set) Token: 0x0600C03B RID: 49211 RVA: 0x001B9A9D File Offset: 0x001B7C9D
		public virtual ITeleportToAndEnterFishingBoat ToVehicle
		{
			get
			{
				if (this._ToVehicleInited)
				{
					return this._ToVehicleCache;
				}
				this._ToVehicleInited = true;
				if (this.FbInstance != null)
				{
					this._ToVehicleCache = ITeleportToAndEnterFishingBoat.Create(this.FbInstance.ToVehicle);
				}
				else
				{
					TeleportToAndEnterVehicle_SetValue pocoInterface = this.PocoInterface;
					this._ToVehicleCache = ((pocoInterface != null) ? pocoInterface.ToVehicle : null);
				}
				return this._ToVehicleCache;
			}
			set
			{
				this.GetOrCreatePoco().ToVehicle = value;
				this._ToVehicleInited = false;
			}
		}

		// Token: 0x0400729C RID: 29340
		[Nullable(2)]
		protected new TeleportToAndEnterVehicle FbInstance;

		// Token: 0x0400729D RID: 29341
		[Nullable(2)]
		protected TeleportToAndEnterVehicle_SetValue PocoInterface;

		// Token: 0x0400729E RID: 29342
		private ITeleportToAndEnterFishingBoat _ToVehicleCache;

		// Token: 0x0400729F RID: 29343
		private bool _ToVehicleInited;
	}
}
