using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B0 RID: 10160
	public class ITalkOptionPreOption : ITalkOptionPreConditionBase
	{
		// Token: 0x0600E0E8 RID: 57576 RVA: 0x002113F6 File Offset: 0x0020F5F6
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

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600E0E9 RID: 57577 RVA: 0x00211415 File Offset: 0x0020F615
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				return (ETalkOptionPreConditionType)this.Instance.Type;
			}
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600E0EA RID: 57578 RVA: 0x00211424 File Offset: 0x0020F624
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

		// Token: 0x04007A48 RID: 31304
		private ITalkOptionPreOption Instance;

		// Token: 0x04007A49 RID: 31305
		private List<int> _PreOptionsCache;

		// Token: 0x04007A4A RID: 31306
		private bool _PreOptionsInited;
	}
}
