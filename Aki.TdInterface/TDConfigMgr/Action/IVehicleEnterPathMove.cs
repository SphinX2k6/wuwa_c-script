using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002284 RID: 8836
	public class IVehicleEnterPathMove : IVehicleControlType
	{
		// Token: 0x0600C07C RID: 49276 RVA: 0x001BB980 File Offset: 0x001B9B80
		private IVehicleEnterPathMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleEnterPathMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleEnterPathMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleEnterPathMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600C07D RID: 49277 RVA: 0x001BB9B8 File Offset: 0x001B9BB8
		public static IVehicleEnterPathMove Create([Nullable(2)] IVehicleEnterPathMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleEnterPathMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C07E RID: 49278 RVA: 0x001BB9CB File Offset: 0x001B9BCB
		public static IVehicleEnterPathMove CreateFromSetValue([Nullable(2)] IVehicleEnterPathMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleEnterPathMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C07F RID: 49279 RVA: 0x001BB9DE File Offset: 0x001B9BDE
		public new IVehicleEnterPathMove_SetValue ToSetValue()
		{
			return new IVehicleEnterPathMove_SetValue
			{
				Type = this.Type,
				ControlParams = this.ControlParams,
				Pattern = this.Pattern
			};
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x0600C080 RID: 49280 RVA: 0x001BBA09 File Offset: 0x001B9C09
		// (set) Token: 0x0600C081 RID: 49281 RVA: 0x001BBA34 File Offset: 0x001B9C34
		public override EVehicleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleControlType.EnterPathMoving;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x0600C082 RID: 49282 RVA: 0x001BBA44 File Offset: 0x001B9C44
		// (set) Token: 0x0600C083 RID: 49283 RVA: 0x001BBAA5 File Offset: 0x001B9CA5
		public virtual IVehicleCruisingParams ControlParams
		{
			get
			{
				if (this._ControlParamsInited)
				{
					return this._ControlParamsCache;
				}
				this._ControlParamsInited = true;
				if (this.FbInstance != null)
				{
					this._ControlParamsCache = IVehicleCruisingParams.Create(this.FbInstance.ControlParams);
				}
				else
				{
					IVehicleEnterPathMove_SetValue pocoInterface = this.PocoInterface;
					this._ControlParamsCache = ((pocoInterface != null) ? pocoInterface.ControlParams : null);
				}
				return this._ControlParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().ControlParams = value;
				this._ControlParamsInited = false;
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0600C084 RID: 49284 RVA: 0x001BBABA File Offset: 0x001B9CBA
		// (set) Token: 0x0600C085 RID: 49285 RVA: 0x001BBAE1 File Offset: 0x001B9CE1
		public virtual ISplineMovePattern Pattern
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pattern;
				}
				IVehicleEnterPathMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pattern;
			}
			set
			{
				this.GetOrCreatePoco().Pattern = value;
			}
		}

		// Token: 0x04007329 RID: 29481
		[Nullable(2)]
		protected new IVehicleEnterPathMove FbInstance;

		// Token: 0x0400732A RID: 29482
		[Nullable(2)]
		protected new IVehicleEnterPathMove_SetValue PocoInterface;

		// Token: 0x0400732B RID: 29483
		private IVehicleCruisingParams _ControlParamsCache;

		// Token: 0x0400732C RID: 29484
		private bool _ControlParamsInited;
	}
}
