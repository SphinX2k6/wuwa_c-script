using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A67 RID: 10855
	public class IHideSpecifyLevelPlayGroup : IHideGroupType
	{
		// Token: 0x0600EFAC RID: 61356 RVA: 0x00232312 File Offset: 0x00230512
		public static IHideSpecifyLevelPlayGroup Create(IHideSpecifyLevelPlayGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyLevelPlayGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x0600EFAD RID: 61357 RVA: 0x00232331 File Offset: 0x00230531
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x0600EFAE RID: 61358 RVA: 0x00232340 File Offset: 0x00230540
		public virtual List<int> LevelPlays
		{
			get
			{
				if (this._LevelPlaysInited)
				{
					return this._LevelPlaysCache;
				}
				this._LevelPlaysInited = true;
				int levelPlaysLength = this.Instance.LevelPlaysLength;
				this._LevelPlaysCache = new List<int>(levelPlaysLength);
				for (int i = 0; i < levelPlaysLength; i++)
				{
					this._LevelPlaysCache.Add(this.Instance.LevelPlays(i));
				}
				return this._LevelPlaysCache;
			}
		}

		// Token: 0x040083C9 RID: 33737
		private IHideSpecifyLevelPlayGroup Instance;

		// Token: 0x040083CA RID: 33738
		private List<int> _LevelPlaysCache;

		// Token: 0x040083CB RID: 33739
		private bool _LevelPlaysInited;
	}
}
