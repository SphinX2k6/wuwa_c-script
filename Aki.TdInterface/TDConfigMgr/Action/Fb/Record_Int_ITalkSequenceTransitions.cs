using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B12 RID: 11026
	[NullableContext(1)]
	[Nullable(0)]
	public class Record_Int_ITalkSequenceTransitions
	{
		// Token: 0x0600F15E RID: 61790 RVA: 0x0022FFF0 File Offset: 0x0022E1F0
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

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x0600F15F RID: 61791 RVA: 0x0023000F File Offset: 0x0022E20F
		public virtual int Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x0600F160 RID: 61792 RVA: 0x0023001C File Offset: 0x0022E21C
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

		// Token: 0x040084C0 RID: 33984
		private Record_Int_ITalkSequenceTransitions Instance;

		// Token: 0x040084C1 RID: 33985
		private List<ITalkSequenceTransition> _ValuesCache;

		// Token: 0x040084C2 RID: 33986
		private bool _ValuesInited;
	}
}
