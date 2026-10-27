using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A4 RID: 10148
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeAdjust : ISubScreenModeConfig
	{
		// Token: 0x0600E1CC RID: 57804 RVA: 0x00215B94 File Offset: 0x00213D94
		public static ISubScreenModeAdjust Create(ISubScreenModeAdjust? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeAdjust
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x0600E1CD RID: 57805 RVA: 0x00215BB3 File Offset: 0x00213DB3
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x00215BC0 File Offset: 0x00213DC0
		public virtual List<ISetSubScreenData> AdjustConfigs
		{
			get
			{
				if (this._AdjustConfigsInited)
				{
					return this._AdjustConfigsCache;
				}
				this._AdjustConfigsInited = true;
				int adjustConfigsLength = this.Instance.AdjustConfigsLength;
				this._AdjustConfigsCache = new List<ISetSubScreenData>(adjustConfigsLength);
				for (int i = 0; i < adjustConfigsLength; i++)
				{
					this._AdjustConfigsCache.Add(ISetSubScreenData.Create(this.Instance.AdjustConfigs(i)));
				}
				return this._AdjustConfigsCache;
			}
		}

		// Token: 0x04007D36 RID: 32054
		private ISubScreenModeAdjust Instance;

		// Token: 0x04007D37 RID: 32055
		private List<ISetSubScreenData> _AdjustConfigsCache;

		// Token: 0x04007D38 RID: 32056
		private bool _AdjustConfigsInited;
	}
}
