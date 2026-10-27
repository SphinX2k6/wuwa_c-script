using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002134 RID: 8500
	[NullableContext(1)]
	[Nullable(0)]
	public class Record_Int_ITalkSequenceTransitions
	{
		// Token: 0x0600BB38 RID: 47928 RVA: 0x001B071A File Offset: 0x001AE91A
		public static Record_Int_ITalkSequenceTransitions Create([Nullable(2)] Record_Int_ITalkSequenceTransitions instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Record_Int_ITalkSequenceTransitions
			{
				FbInstance = instance
			};
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600BB39 RID: 47929 RVA: 0x001B072D File Offset: 0x001AE92D
		public virtual int Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x001B073C File Offset: 0x001AE93C
		public virtual List<ITalkSequenceTransition> Values
		{
			get
			{
				if (this._ValuesInited)
				{
					return this._ValuesCache;
				}
				this._ValuesInited = true;
				if (this.FbInstance != null)
				{
					List<ITalkSequenceTransition> values = this.FbInstance.Values;
					if (values != null)
					{
						this._ValuesCache = new List<ITalkSequenceTransition>(values.Count);
						for (int i = 0; i < values.Count; i++)
						{
							this._ValuesCache.Add(ITalkSequenceTransition.Create(values[i]));
						}
					}
				}
				return this._ValuesCache;
			}
		}

		// Token: 0x04006FFF RID: 28671
		private Record_Int_ITalkSequenceTransitions FbInstance;

		// Token: 0x04007000 RID: 28672
		private List<ITalkSequenceTransition> _ValuesCache;

		// Token: 0x04007001 RID: 28673
		private bool _ValuesInited;
	}
}
