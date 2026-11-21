using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CB9 RID: 11449
	public class IPlayVoicePassengersConfig
	{
		// Token: 0x0600FB1A RID: 64282 RVA: 0x00246283 File Offset: 0x00244483
		public static IPlayVoicePassengersConfig Create(IPlayVoicePassengersConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayVoicePassengersConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x0600FB1B RID: 64283 RVA: 0x002462A4 File Offset: 0x002444A4
		public virtual List<int> Passengers
		{
			get
			{
				if (this._PassengersInited)
				{
					return this._PassengersCache;
				}
				this._PassengersInited = true;
				int passengersLength = this.Instance.PassengersLength;
				this._PassengersCache = new List<int>(passengersLength);
				for (int i = 0; i < passengersLength; i++)
				{
					this._PassengersCache.Add(this.Instance.Passengers(i));
				}
				return this._PassengersCache;
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x0600FB1C RID: 64284 RVA: 0x00246308 File Offset: 0x00244508
		public virtual bool? MatchNone
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.MatchNone);
			}
		}

		// Token: 0x0400892B RID: 35115
		private IPlayVoicePassengersConfig Instance;

		// Token: 0x0400892C RID: 35116
		private List<int> _PassengersCache;

		// Token: 0x0400892D RID: 35117
		private bool _PassengersInited;
	}
}
