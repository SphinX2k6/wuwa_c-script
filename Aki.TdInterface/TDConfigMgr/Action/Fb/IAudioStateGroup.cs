using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002988 RID: 10632
	[NullableContext(1)]
	[Nullable(0)]
	public class IAudioStateGroup
	{
		// Token: 0x0600EB78 RID: 60280 RVA: 0x002270F0 File Offset: 0x002252F0
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

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x0600EB79 RID: 60281 RVA: 0x0022710F File Offset: 0x0022530F
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x0600EB7A RID: 60282 RVA: 0x0022711C File Offset: 0x0022531C
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

		// Token: 0x040081AE RID: 33198
		private IAudioStateGroup Instance;

		// Token: 0x040081AF RID: 33199
		private List<string> _StatesCache;

		// Token: 0x040081B0 RID: 33200
		private bool _StatesInited;
	}
}
