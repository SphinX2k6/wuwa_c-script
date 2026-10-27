using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002275 RID: 8821
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice : ActionParams
	{
		// Token: 0x0600C186 RID: 49542 RVA: 0x001BC0E4 File Offset: 0x001BA2E4
		[NullableContext(1)]
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

		// Token: 0x0600C187 RID: 49543 RVA: 0x001BC11C File Offset: 0x001BA31C
		[NullableContext(1)]
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

		// Token: 0x0600C188 RID: 49544 RVA: 0x001BC12F File Offset: 0x001BA32F
		[NullableContext(1)]
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

		// Token: 0x0600C189 RID: 49545 RVA: 0x001BC142 File Offset: 0x001BA342
		[NullableContext(1)]
		public VehiclePlayPassengerVoice_SetValue ToSetValue()
		{
			return new VehiclePlayPassengerVoice_SetValue
			{
				TriggerType = this.TriggerType,
				TriggerPassengers = this.TriggerPassengers,
				TriggerParams = this.TriggerParams
			};
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x0600C18A RID: 49546 RVA: 0x001BC16D File Offset: 0x001BA36D
		// (set) Token: 0x0600C18B RID: 49547 RVA: 0x001BC198 File Offset: 0x001BA398
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

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x0600C18C RID: 49548 RVA: 0x001BC1A8 File Offset: 0x001BA3A8
		// (set) Token: 0x0600C18D RID: 49549 RVA: 0x001BC209 File Offset: 0x001BA409
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

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x0600C18E RID: 49550 RVA: 0x001BC21E File Offset: 0x001BA41E
		// (set) Token: 0x0600C18F RID: 49551 RVA: 0x001BC245 File Offset: 0x001BA445
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

		// Token: 0x04007348 RID: 29512
		protected new VehiclePlayPassengerVoice FbInstance;

		// Token: 0x04007349 RID: 29513
		protected VehiclePlayPassengerVoice_SetValue PocoInterface;

		// Token: 0x0400734A RID: 29514
		[Nullable(1)]
		private IPlayVoicePassengersConfig _TriggerPassengersCache;

		// Token: 0x0400734B RID: 29515
		private bool _TriggerPassengersInited;
	}
}
