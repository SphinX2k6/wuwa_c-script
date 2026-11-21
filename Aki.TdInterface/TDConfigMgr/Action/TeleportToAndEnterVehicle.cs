using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A1 RID: 9377
	public class TeleportToAndEnterVehicle : ActionParams
	{
		// Token: 0x0600CBF4 RID: 52212 RVA: 0x001D1094 File Offset: 0x001CF294
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

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x001D10CC File Offset: 0x001CF2CC
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

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x001D10DF File Offset: 0x001CF2DF
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

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x001D10F2 File Offset: 0x001CF2F2
		public TeleportToAndEnterVehicle_SetValue ToSetValue()
		{
			return new TeleportToAndEnterVehicle_SetValue
			{
				ToVehicle = this.ToVehicle
			};
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600CBF8 RID: 52216 RVA: 0x001D1108 File Offset: 0x001CF308
		// (set) Token: 0x0600CBF9 RID: 52217 RVA: 0x001D1169 File Offset: 0x001CF369
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

		// Token: 0x040078E6 RID: 30950
		[Nullable(2)]
		protected new TeleportToAndEnterVehicle FbInstance;

		// Token: 0x040078E7 RID: 30951
		[Nullable(2)]
		protected TeleportToAndEnterVehicle_SetValue PocoInterface;

		// Token: 0x040078E8 RID: 30952
		private ITeleportToAndEnterFishingBoat _ToVehicleCache;

		// Token: 0x040078E9 RID: 30953
		private bool _ToVehicleInited;
	}
}
