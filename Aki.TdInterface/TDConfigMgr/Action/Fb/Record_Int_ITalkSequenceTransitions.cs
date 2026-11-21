using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E30 RID: 11824
	public class Record_Int_ITalkSequenceTransitions
	{
		// Token: 0x060100B2 RID: 65714 RVA: 0x0024EA88 File Offset: 0x0024CC88
		public static Record_Int_ITalkSequenceTransitions Create(Record_Int_ITalkSequenceTransitions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Record_Int_ITalkSequenceTransitions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x060100B3 RID: 65715 RVA: 0x0024EAA7 File Offset: 0x0024CCA7
		public virtual int Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x060100B4 RID: 65716 RVA: 0x0024EAB4 File Offset: 0x0024CCB4
		public virtual List<ITalkSequenceTransition> Values
		{
			get
			{
				if (this._ValuesInited)
				{
					return this._ValuesCache;
				}
				this._ValuesInited = true;
				int valuesLength = this.Instance.ValuesLength;
				this._ValuesCache = new List<ITalkSequenceTransition>(valuesLength);
				for (int i = 0; i < valuesLength; i++)
				{
					this._ValuesCache.Add(ITalkSequenceTransition.Create(this.Instance.Values(i)));
				}
				return this._ValuesCache;
			}
		}

		// Token: 0x04008C08 RID: 35848
		private Record_Int_ITalkSequenceTransitions Instance;

		// Token: 0x04008C09 RID: 35849
		private List<ITalkSequenceTransition> _ValuesCache;

		// Token: 0x04008C0A RID: 35850
		private bool _ValuesInited;
	}
}
