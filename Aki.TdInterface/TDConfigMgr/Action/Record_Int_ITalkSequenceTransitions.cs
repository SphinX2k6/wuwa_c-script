using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002395 RID: 9109
	public class Record_Int_ITalkSequenceTransitions
	{
		// Token: 0x0600C6C6 RID: 50886 RVA: 0x001C78CE File Offset: 0x001C5ACE
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

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600C6C7 RID: 50887 RVA: 0x001C78E1 File Offset: 0x001C5AE1
		public virtual int Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x001C78F0 File Offset: 0x001C5AF0
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

		// Token: 0x04007634 RID: 30260
		private Record_Int_ITalkSequenceTransitions FbInstance;

		// Token: 0x04007635 RID: 30261
		private List<ITalkSequenceTransition> _ValuesCache;

		// Token: 0x04007636 RID: 30262
		private bool _ValuesInited;
	}
}
