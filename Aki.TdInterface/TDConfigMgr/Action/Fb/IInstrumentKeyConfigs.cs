using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002838 RID: 10296
	[NullableContext(1)]
	[Nullable(0)]
	public class IInstrumentKeyConfigs
	{
		// Token: 0x0600E449 RID: 58441 RVA: 0x00219B30 File Offset: 0x00217D30
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

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x0600E44A RID: 58442 RVA: 0x00219B50 File Offset: 0x00217D50
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

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x0600E44B RID: 58443 RVA: 0x00219BB9 File Offset: 0x00217DB9
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

		// Token: 0x04007E4C RID: 32332
		private IInstrumentKeyConfigs Instance;

		// Token: 0x04007E4D RID: 32333
		private List<IInstrumentKeyAttribute> _GridsCache;

		// Token: 0x04007E4E RID: 32334
		private bool _GridsInited;

		// Token: 0x04007E4F RID: 32335
		[Nullable(2)]
		private IInstrumentBoardSize _BoardSizeCache;

		// Token: 0x04007E50 RID: 32336
		private bool _BoardSizeInited;
	}
}
