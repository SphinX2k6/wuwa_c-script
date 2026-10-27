using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203B RID: 8251
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnterPathMove : IVehicleControlType
	{
		// Token: 0x0600B556 RID: 46422 RVA: 0x001A5214 File Offset: 0x001A3414
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

		// Token: 0x0600B557 RID: 46423 RVA: 0x001A524C File Offset: 0x001A344C
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

		// Token: 0x0600B558 RID: 46424 RVA: 0x001A525F File Offset: 0x001A345F
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

		// Token: 0x0600B559 RID: 46425 RVA: 0x001A5272 File Offset: 0x001A3472
		public new IVehicleEnterPathMove_SetValue ToSetValue()
		{
			return new IVehicleEnterPathMove_SetValue
			{
				Type = this.Type,
				ControlParams = this.ControlParams,
				Pattern = this.Pattern
			};
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x001A529D File Offset: 0x001A349D
		// (set) Token: 0x0600B55B RID: 46427 RVA: 0x001A52C8 File Offset: 0x001A34C8
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

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x001A52D8 File Offset: 0x001A34D8
		// (set) Token: 0x0600B55D RID: 46429 RVA: 0x001A5339 File Offset: 0x001A3539
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B55E RID: 46430 RVA: 0x001A534E File Offset: 0x001A354E
		// (set) Token: 0x0600B55F RID: 46431 RVA: 0x001A5375 File Offset: 0x001A3575
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

		// Token: 0x04006D20 RID: 27936
		[Nullable(2)]
		protected new IVehicleEnterPathMove FbInstance;

		// Token: 0x04006D21 RID: 27937
		[Nullable(2)]
		protected new IVehicleEnterPathMove_SetValue PocoInterface;

		// Token: 0x04006D22 RID: 27938
		private IVehicleCruisingParams _ControlParamsCache;

		// Token: 0x04006D23 RID: 27939
		private bool _ControlParamsInited;
	}
}
