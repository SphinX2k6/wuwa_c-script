using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CBA RID: 11450
	[NullableContext(2)]
	[Nullable(0)]
	public class VehiclePlayPassengerVoice : ActionParams
	{
		// Token: 0x0600FB1E RID: 64286 RVA: 0x00246346 File Offset: 0x00244546
		[NullableContext(0)]
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

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x0600FB1F RID: 64287 RVA: 0x00246365 File Offset: 0x00244565
		public virtual EGondolaVoiceTriggeredType TriggerType
		{
			get
			{
				return (EGondolaVoiceTriggeredType)this.Instance.TriggerType;
			}
		}

		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x0600FB20 RID: 64288 RVA: 0x00246372 File Offset: 0x00244572
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

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x0600FB21 RID: 64289 RVA: 0x002463A8 File Offset: 0x002445A8
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

		// Token: 0x0400892E RID: 35118
		private IVehiclePlayPassengerVoice Instance;

		// Token: 0x0400892F RID: 35119
		private IPlayVoicePassengersConfig _TriggerPassengersCache;

		// Token: 0x04008930 RID: 35120
		private bool _TriggerPassengersInited;

		// Token: 0x04008931 RID: 35121
		private List<float> _TriggerParamsCache;

		// Token: 0x04008932 RID: 35122
		private bool _TriggerParamsInited;
	}
}
