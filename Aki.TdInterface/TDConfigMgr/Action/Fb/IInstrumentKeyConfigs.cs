using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B0B RID: 11019
	public class IInstrumentKeyConfigs
	{
		// Token: 0x0600F26E RID: 62062 RVA: 0x00236994 File Offset: 0x00234B94
		public static IInstrumentKeyConfigs Create(IInstrumentKeyConfigs? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInstrumentKeyConfigs
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x0600F26F RID: 62063 RVA: 0x002369B4 File Offset: 0x00234BB4
		public virtual List<IInstrumentKeyAttribute> Grids
		{
			get
			{
				if (this._GridsInited)
				{
					return this._GridsCache;
				}
				this._GridsInited = true;
				int gridsLength = this.Instance.GridsLength;
				this._GridsCache = new List<IInstrumentKeyAttribute>(gridsLength);
				for (int i = 0; i < gridsLength; i++)
				{
					this._GridsCache.Add(IInstrumentKeyAttribute.Create(this.Instance.Grids(i)));
				}
				return this._GridsCache;
			}
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x0600F270 RID: 62064 RVA: 0x00236A1D File Offset: 0x00234C1D
		public virtual IInstrumentBoardSize BoardSize
		{
			get
			{
				if (this._BoardSizeInited)
				{
					return this._BoardSizeCache;
				}
				this._BoardSizeInited = true;
				this._BoardSizeCache = IInstrumentBoardSize.Create(this.Instance.BoardSize);
				return this._BoardSizeCache;
			}
		}

		// Token: 0x04008509 RID: 34057
		private IInstrumentKeyConfigs Instance;

		// Token: 0x0400850A RID: 34058
		private List<IInstrumentKeyAttribute> _GridsCache;

		// Token: 0x0400850B RID: 34059
		private bool _GridsInited;

		// Token: 0x0400850C RID: 34060
		[Nullable(2)]
		private IInstrumentBoardSize _BoardSizeCache;

		// Token: 0x0400850D RID: 34061
		private bool _BoardSizeInited;
	}
}
