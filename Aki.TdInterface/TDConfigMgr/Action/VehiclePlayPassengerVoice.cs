using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024E2 RID: 9442
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice : ActionParams
	{
		// Token: 0x0600CD4C RID: 52556 RVA: 0x001D3868 File Offset: 0x001D1A68
		[NullableContext(0)]
		private VehiclePlayPassengerVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VehiclePlayPassengerVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VehiclePlayPassengerVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VehiclePlayPassengerVoice_SetValue());
			}
			return result;
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x001D38A0 File Offset: 0x001D1AA0
		[NullableContext(0)]
		public static VehiclePlayPassengerVoice Create([Nullable(2)] VehiclePlayPassengerVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehiclePlayPassengerVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x001D38B3 File Offset: 0x001D1AB3
		[NullableContext(0)]
		public static VehiclePlayPassengerVoice CreateFromSetValue([Nullable(2)] VehiclePlayPassengerVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VehiclePlayPassengerVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x001D38C6 File Offset: 0x001D1AC6
		[NullableContext(0)]
		public VehiclePlayPassengerVoice_SetValue ToSetValue()
		{
			return new VehiclePlayPassengerVoice_SetValue
			{
				TriggerType = this.TriggerType,
				TriggerPassengers = this.TriggerPassengers,
				TriggerParams = this.TriggerParams
			};
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600CD50 RID: 52560 RVA: 0x001D38F1 File Offset: 0x001D1AF1
		// (set) Token: 0x0600CD51 RID: 52561 RVA: 0x001D391C File Offset: 0x001D1B1C
		public virtual EGondolaVoiceTriggeredType TriggerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerType;
				}
				if (this.PocoInterface == null)
				{
					return EGondolaVoiceTriggeredType.FindTreasure;
				}
				return this.PocoInterface.TriggerType;
			}
			set
			{
				this.GetOrCreatePoco().TriggerType = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x001D392C File Offset: 0x001D1B2C
		// (set) Token: 0x0600CD53 RID: 52563 RVA: 0x001D398D File Offset: 0x001D1B8D
		public virtual IPlayVoicePassengersConfig TriggerPassengers
		{
			get
			{
				if (this._TriggerPassengersInited)
				{
					return this._TriggerPassengersCache;
				}
				this._TriggerPassengersInited = true;
				if (this.FbInstance != null)
				{
					this._TriggerPassengersCache = IPlayVoicePassengersConfig.Create(this.FbInstance.TriggerPassengers);
				}
				else
				{
					VehiclePlayPassengerVoice_SetValue pocoInterface = this.PocoInterface;
					this._TriggerPassengersCache = ((pocoInterface != null) ? pocoInterface.TriggerPassengers : null);
				}
				return this._TriggerPassengersCache;
			}
			set
			{
				this.GetOrCreatePoco().TriggerPassengers = value;
				this._TriggerPassengersInited = false;
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600CD54 RID: 52564 RVA: 0x001D39A2 File Offset: 0x001D1BA2
		// (set) Token: 0x0600CD55 RID: 52565 RVA: 0x001D39C9 File Offset: 0x001D1BC9
		public virtual List<float> TriggerParams
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerParams;
				}
				VehiclePlayPassengerVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TriggerParams;
			}
			set
			{
				this.GetOrCreatePoco().TriggerParams = value;
			}
		}

		// Token: 0x04007995 RID: 31125
		protected new VehiclePlayPassengerVoice FbInstance;

		// Token: 0x04007996 RID: 31126
		protected VehiclePlayPassengerVoice_SetValue PocoInterface;

		// Token: 0x04007997 RID: 31127
		[Nullable(0)]
		private IPlayVoicePassengersConfig _TriggerPassengersCache;

		// Token: 0x04007998 RID: 31128
		private bool _TriggerPassengersInited;
	}
}
