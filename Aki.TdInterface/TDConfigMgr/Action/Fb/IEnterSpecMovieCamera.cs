using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C5 RID: 10437
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterSpecMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00220B1E File Offset: 0x0021ED1E
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

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x00220B3D File Offset: 0x0021ED3D
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x0600E7E4 RID: 59364 RVA: 0x00220B4A File Offset: 0x0021ED4A
		public virtual string RowName
		{
			get
			{
				return this.Instance.RowName;
			}
		}

		// Token: 0x0400802F RID: 32815
		private IEnterSpecMovieCamera Instance;
	}
}
