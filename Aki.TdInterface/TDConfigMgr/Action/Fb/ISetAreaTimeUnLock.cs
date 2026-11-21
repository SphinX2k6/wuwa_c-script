using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200279F RID: 10143
	public class ISetAreaTimeUnLock : ISetAreaTimeBase
	{
		// Token: 0x0600E0AC RID: 57516 RVA: 0x00210F00 File Offset: 0x0020F100
		public static ISetAreaTimeUnLock Create(ISetAreaTimeUnLock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAreaTimeUnLock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x00210F1F File Offset: 0x0020F11F
		public override ESetAreaTime Type
		{
			get
			{
				return (ESetAreaTime)this.Instance.Type;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600E0AE RID: 57518 RVA: 0x00210F2C File Offset: 0x0020F12C
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x04007A2D RID: 31277
		private ISetAreaTimeUnLock Instance;

		// Token: 0x04007A2E RID: 31278
		private List<int> _AreaIdsCache;

		// Token: 0x04007A2F RID: 31279
		private bool _AreaIdsInited;
	}
}
