using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C6E RID: 11374
	public class IAudioStateGroup
	{
		// Token: 0x0600F9F3 RID: 63987 RVA: 0x00244848 File Offset: 0x00242A48
		public static IAudioStateGroup Create(IAudioStateGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioStateGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x0600F9F4 RID: 63988 RVA: 0x00244867 File Offset: 0x00242A67
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x0600F9F5 RID: 63989 RVA: 0x00244874 File Offset: 0x00242A74
		public virtual List<string> States
		{
			get
			{
				if (this._StatesInited)
				{
					return this._StatesCache;
				}
				this._StatesInited = true;
				int statesLength = this.Instance.StatesLength;
				this._StatesCache = new List<string>(statesLength);
				for (int i = 0; i < statesLength; i++)
				{
					this._StatesCache.Add(this.Instance.States(i));
				}
				return this._StatesCache;
			}
		}

		// Token: 0x04008892 RID: 34962
		private IAudioStateGroup Instance;

		// Token: 0x04008893 RID: 34963
		private List<string> _StatesCache;

		// Token: 0x04008894 RID: 34964
		private bool _StatesInited;
	}
}
