using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9B RID: 11163
	public class IEnterRandomMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600F615 RID: 62997 RVA: 0x0023DADF File Offset: 0x0023BCDF
		public static IEnterRandomMovieCamera Create(IEnterRandomMovieCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterRandomMovieCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B8D RID: 19341
		// (get) Token: 0x0600F616 RID: 62998 RVA: 0x0023DAFE File Offset: 0x0023BCFE
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004B8E RID: 19342
		// (get) Token: 0x0600F617 RID: 62999 RVA: 0x0023DB0C File Offset: 0x0023BD0C
		public virtual List<string> RowNames
		{
			get
			{
				if (this._RowNamesInited)
				{
					return this._RowNamesCache;
				}
				this._RowNamesInited = true;
				int rowNamesLength = this.Instance.RowNamesLength;
				this._RowNamesCache = new List<string>(rowNamesLength);
				for (int i = 0; i < rowNamesLength; i++)
				{
					this._RowNamesCache.Add(this.Instance.RowNames(i));
				}
				return this._RowNamesCache;
			}
		}

		// Token: 0x040086EF RID: 34543
		private IEnterRandomMovieCamera Instance;

		// Token: 0x040086F0 RID: 34544
		private List<string> _RowNamesCache;

		// Token: 0x040086F1 RID: 34545
		private bool _RowNamesInited;
	}
}
