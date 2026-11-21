using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228E RID: 8846
	public class IVehiclePlayerMotor : ITargetVehicle
	{
		// Token: 0x0600C0B2 RID: 49330 RVA: 0x001BBF44 File Offset: 0x001BA144
		private IVehiclePlayerMotor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehiclePlayerMotor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehiclePlayerMotor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehiclePlayerMotor_SetValue());
			}
			return result;
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x001BBF7C File Offset: 0x001BA17C
		public static IVehiclePlayerMotor Create([Nullable(2)] IVehiclePlayerMotor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehiclePlayerMotor
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x001BBF8F File Offset: 0x001BA18F
		public static IVehiclePlayerMotor CreateFromSetValue([Nullable(2)] IVehiclePlayerMotor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehiclePlayerMotor
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x001BBFA2 File Offset: 0x001BA1A2
		public new IVehiclePlayerMotor_SetValue ToSetValue()
		{
			return new IVehiclePlayerMotor_SetValue
			{
				Type = this.Type,
				SummonPositionEntityId = this.SummonPositionEntityId
			};
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x001BBFC1 File Offset: 0x001BA1C1
		// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x001BBFEC File Offset: 0x001BA1EC
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x001BBFFC File Offset: 0x001BA1FC
		// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x001BC036 File Offset: 0x001BA236
		public virtual int? SummonPositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SummonPositionEntityId;
				}
				IVehiclePlayerMotor_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SummonPositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SummonPositionEntityId = value;
			}
		}

		// Token: 0x04007341 RID: 29505
		[Nullable(2)]
		protected new IVehiclePlayerMotor FbInstance;

		// Token: 0x04007342 RID: 29506
		[Nullable(2)]
		protected new IVehiclePlayerMotor_SetValue PocoInterface;
	}
}
