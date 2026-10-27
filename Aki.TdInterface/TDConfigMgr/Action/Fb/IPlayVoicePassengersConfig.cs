using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CC RID: 10700
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayVoicePassengersConfig
	{
		// Token: 0x0600EC83 RID: 60547 RVA: 0x002288FF File Offset: 0x00226AFF
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

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x0600EC84 RID: 60548 RVA: 0x00228920 File Offset: 0x00226B20
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

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x0600EC85 RID: 60549 RVA: 0x00228984 File Offset: 0x00226B84
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

		// Token: 0x0400823A RID: 33338
		private IPlayVoicePassengersConfig Instance;

		// Token: 0x0400823B RID: 33339
		private List<int> _PassengersCache;

		// Token: 0x0400823C RID: 33340
		private bool _PassengersInited;
	}
}
