using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CD RID: 10701
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice : ActionParams
	{
		// Token: 0x0600EC87 RID: 60551 RVA: 0x002289C2 File Offset: 0x00226BC2
		[NullableContext(1)]
		public static VehiclePlayPassengerVoice Create(IVehiclePlayPassengerVoice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VehiclePlayPassengerVoice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x0600EC88 RID: 60552 RVA: 0x002289E1 File Offset: 0x00226BE1
		public virtual EGondolaVoiceTriggeredType TriggerType
		{
			get
			{
				return (EGondolaVoiceTriggeredType)this.Instance.TriggerType;
			}
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x0600EC89 RID: 60553 RVA: 0x002289EE File Offset: 0x00226BEE
		public virtual IPlayVoicePassengersConfig TriggerPassengers
		{
			get
			{
				if (this._TriggerPassengersInited)
				{
					return this._TriggerPassengersCache;
				}
				this._TriggerPassengersInited = true;
				this._TriggerPassengersCache = IPlayVoicePassengersConfig.Create(this.Instance.TriggerPassengers);
				return this._TriggerPassengersCache;
			}
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x0600EC8A RID: 60554 RVA: 0x00228A24 File Offset: 0x00226C24
		public virtual List<float> TriggerParams
		{
			get
			{
				if (this._TriggerParamsInited)
				{
					return this._TriggerParamsCache;
				}
				this._TriggerParamsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int triggerParamsLength = this.Instance.TriggerParamsLength;
				this._TriggerParamsCache = new List<float>(triggerParamsLength);
				for (int i = 0; i < triggerParamsLength; i++)
				{
					this._TriggerParamsCache.Add(this.Instance.TriggerParams(i));
				}
				return this._TriggerParamsCache;
			}
		}

		// Token: 0x0400823D RID: 33341
		private IVehiclePlayPassengerVoice Instance;

		// Token: 0x0400823E RID: 33342
		private IPlayVoicePassengersConfig _TriggerPassengersCache;

		// Token: 0x0400823F RID: 33343
		private bool _TriggerPassengersInited;

		// Token: 0x04008240 RID: 33344
		private List<float> _TriggerParamsCache;

		// Token: 0x04008241 RID: 33345
		private bool _TriggerParamsInited;
	}
}
