using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D65 RID: 3429
	public class IOnEntityStateChangeAttachTiming : IAttachTiming
	{
		// Token: 0x06004DFE RID: 19966 RVA: 0x000C2792 File Offset: 0x000C0992
		public static IOnEntityStateChangeAttachTiming Create(IOnEntityStateChangeAttachTiming? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnEntityStateChangeAttachTiming
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x000C27B1 File Offset: 0x000C09B1
		public override EAttachTimingType Type
		{
			get
			{
				return (EAttachTimingType)this.Instance.Type;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x000C27C0 File Offset: 0x000C09C0
		public virtual List<IAttachTimingEntityStateConfig> StateConfigs
		{
			get
			{
				if (this._StateConfigsInited)
				{
					return this._StateConfigsCache;
				}
				this._StateConfigsInited = true;
				int stateConfigsLength = this.Instance.StateConfigsLength;
				this._StateConfigsCache = new List<IAttachTimingEntityStateConfig>(stateConfigsLength);
				for (int i = 0; i < stateConfigsLength; i++)
				{
					this._StateConfigsCache.Add(IAttachTimingEntityStateConfig.Create(this.Instance.StateConfigs(i)));
				}
				return this._StateConfigsCache;
			}
		}

		// Token: 0x04002C4A RID: 11338
		private IOnEntityStateChangeAttachTiming Instance;

		// Token: 0x04002C4B RID: 11339
		private List<IAttachTimingEntityStateConfig> _StateConfigsCache;

		// Token: 0x04002C4C RID: 11340
		private bool _StateConfigsInited;
	}
}
