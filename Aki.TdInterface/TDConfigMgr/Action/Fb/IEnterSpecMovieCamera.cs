using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B9A RID: 11162
	public class IEnterSpecMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600F611 RID: 62993 RVA: 0x0023DA9E File Offset: 0x0023BC9E
		public static IEnterSpecMovieCamera Create(IEnterSpecMovieCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterSpecMovieCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x0600F612 RID: 62994 RVA: 0x0023DABD File Offset: 0x0023BCBD
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004B8C RID: 19340
		// (get) Token: 0x0600F613 RID: 62995 RVA: 0x0023DACA File Offset: 0x0023BCCA
		public virtual string RowName
		{
			get
			{
				return this.Instance.RowName;
			}
		}

		// Token: 0x040086EE RID: 34542
		private IEnterSpecMovieCamera Instance;
	}
}
