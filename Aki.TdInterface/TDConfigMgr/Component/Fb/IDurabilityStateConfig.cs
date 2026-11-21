using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C3B RID: 3131
	public class IDurabilityStateConfig
	{
		// Token: 0x060047B6 RID: 18358 RVA: 0x000B5C64 File Offset: 0x000B3E64
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

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x000B5C84 File Offset: 0x000B3E84
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

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x000B5CBC File Offset: 0x000B3EBC
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

		// Token: 0x04002842 RID: 10306
		private IDurabilityStateConfig Instance;

		// Token: 0x04002843 RID: 10307
		private List<IDurabilityState> _DurabilityStatesCache;

		// Token: 0x04002844 RID: 10308
		private bool _DurabilityStatesInited;
	}
}
