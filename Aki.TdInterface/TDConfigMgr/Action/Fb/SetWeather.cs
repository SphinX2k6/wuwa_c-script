using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289A RID: 10394
	[NullableContext(2)]
	[Nullable(0)]
	public class SetWeather : ActionParams
	{
		// Token: 0x0600E623 RID: 58915 RVA: 0x0021D1FC File Offset: 0x0021B3FC
		[NullableContext(1)]
		public static SetWeather Create(ISetWeather? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeather
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x0600E624 RID: 58916 RVA: 0x0021D21B File Offset: 0x0021B41B
		public virtual int WeatherId
		{
			get
			{
				return this.Instance.WeatherId;
			}
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x0600E625 RID: 58917 RVA: 0x0021D228 File Offset: 0x0021B428
		public virtual List<int> AreaIds
		{
			get
			{
				if (this._AreaIdsInited)
				{
					return this._AreaIdsCache;
				}
				this._AreaIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int areaIdsLength = this.Instance.AreaIdsLength;
				this._AreaIdsCache = new List<int>(areaIdsLength);
				for (int i = 0; i < areaIdsLength; i++)
				{
					this._AreaIdsCache.Add(this.Instance.AreaIds(i));
				}
				return this._AreaIdsCache;
			}
		}

		// Token: 0x04007F3C RID: 32572
		private ISetWeather Instance;

		// Token: 0x04007F3D RID: 32573
		private List<int> _AreaIdsCache;

		// Token: 0x04007F3E RID: 32574
		private bool _AreaIdsInited;
	}
}
