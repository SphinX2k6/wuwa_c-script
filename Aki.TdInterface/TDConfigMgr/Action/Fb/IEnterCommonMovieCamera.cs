using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B99 RID: 11161
	public class IEnterCommonMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600F60C RID: 62988 RVA: 0x0023DA25 File Offset: 0x0023BC25
		public static IEnterCommonMovieCamera Create(IEnterCommonMovieCamera? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterCommonMovieCamera
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x0600F60D RID: 62989 RVA: 0x0023DA44 File Offset: 0x0023BC44
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x0600F60E RID: 62990 RVA: 0x0023DA51 File Offset: 0x0023BC51
		public virtual string RowName
		{
			get
			{
				return this.Instance.RowName;
			}
		}

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x0600F60F RID: 62991 RVA: 0x0023DA60 File Offset: 0x0023BC60
		public virtual int? SpecElementIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.SpecElementIndex);
			}
		}

		// Token: 0x040086ED RID: 34541
		private IEnterCommonMovieCamera Instance;
	}
}
