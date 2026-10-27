using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002045 RID: 8261
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehiclePlayerMotor : ITargetVehicle
	{
		// Token: 0x0600B58C RID: 46476 RVA: 0x001A57D8 File Offset: 0x001A39D8
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

		// Token: 0x0600B58D RID: 46477 RVA: 0x001A5810 File Offset: 0x001A3A10
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

		// Token: 0x0600B58E RID: 46478 RVA: 0x001A5823 File Offset: 0x001A3A23
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

		// Token: 0x0600B58F RID: 46479 RVA: 0x001A5836 File Offset: 0x001A3A36
		public new IVehiclePlayerMotor_SetValue ToSetValue()
		{
			return new IVehiclePlayerMotor_SetValue
			{
				Type = this.Type,
				SummonPositionEntityId = this.SummonPositionEntityId
			};
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x001A5855 File Offset: 0x001A3A55
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x001A5880 File Offset: 0x001A3A80
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

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B592 RID: 46482 RVA: 0x001A5890 File Offset: 0x001A3A90
		// (set) Token: 0x0600B593 RID: 46483 RVA: 0x001A58CA File Offset: 0x001A3ACA
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

		// Token: 0x04006D38 RID: 27960
		[Nullable(2)]
		protected new IVehiclePlayerMotor FbInstance;

		// Token: 0x04006D39 RID: 27961
		[Nullable(2)]
		protected new IVehiclePlayerMotor_SetValue PocoInterface;
	}
}
