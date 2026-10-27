using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C6 RID: 10438
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterRandomMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600E7E6 RID: 59366 RVA: 0x00220B5F File Offset: 0x0021ED5F
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

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x00220B7E File Offset: 0x0021ED7E
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x00220B8C File Offset: 0x0021ED8C
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

		// Token: 0x04008030 RID: 32816
		private IEnterRandomMovieCamera Instance;

		// Token: 0x04008031 RID: 32817
		private List<string> _RowNamesCache;

		// Token: 0x04008032 RID: 32818
		private bool _RowNamesInited;
	}
}
