using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200250A RID: 9482
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionPreOption : ITalkOptionPreConditionBase
	{
		// Token: 0x0600D38C RID: 54156 RVA: 0x001F59FE File Offset: 0x001F3BFE
		public static ITalkOptionPreOption Create(ITalkOptionPreOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionPreOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600D38D RID: 54157 RVA: 0x001F5A1D File Offset: 0x001F3C1D
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600D38E RID: 54158 RVA: 0x001F5A2C File Offset: 0x001F3C2C
		public virtual List<int> PreOptions
		{
			get
			{
				if (this._PreOptionsInited)
				{
					return this._PreOptionsCache;
				}
				this._PreOptionsInited = true;
				int preOptionsLength = this.Instance.PreOptionsLength;
				this._PreOptionsCache = new List<int>(preOptionsLength);
				for (int i = 0; i < preOptionsLength; i++)
				{
					this._PreOptionsCache.Add(this.Instance.PreOptions(i));
				}
				return this._PreOptionsCache;
			}
		}

		// Token: 0x040073F6 RID: 29686
		private ITalkOptionPreOption Instance;

		// Token: 0x040073F7 RID: 29687
		private List<int> _PreOptionsCache;

		// Token: 0x040073F8 RID: 29688
		private bool _PreOptionsInited;
	}
}
