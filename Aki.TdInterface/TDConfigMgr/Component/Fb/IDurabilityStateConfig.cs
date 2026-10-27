using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B6D RID: 2925
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurabilityStateConfig
	{
		// Token: 0x0600435D RID: 17245 RVA: 0x000ABBA0 File Offset: 0x000A9DA0
		public static IDurabilityStateConfig Create(IDurabilityStateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityStateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x000ABBC0 File Offset: 0x000A9DC0
		public virtual bool? NonDestructable
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.NonDestructable);
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x000ABBF8 File Offset: 0x000A9DF8
		public virtual List<IDurabilityState> DurabilityStates
		{
			get
			{
				if (this._DurabilityStatesInited)
				{
					return this._DurabilityStatesCache;
				}
				this._DurabilityStatesInited = true;
				int durabilityStatesLength = this.Instance.DurabilityStatesLength;
				this._DurabilityStatesCache = new List<IDurabilityState>(durabilityStatesLength);
				for (int i = 0; i < durabilityStatesLength; i++)
				{
					this._DurabilityStatesCache.Add(IDurabilityState.Create(this.Instance.DurabilityStates(i)));
				}
				return this._DurabilityStatesCache;
			}
		}

		// Token: 0x040025FA RID: 9722
		private IDurabilityStateConfig Instance;

		// Token: 0x040025FB RID: 9723
		private List<IDurabilityState> _DurabilityStatesCache;

		// Token: 0x040025FC RID: 9724
		private bool _DurabilityStatesInited;
	}
}
