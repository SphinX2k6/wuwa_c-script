using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C4 RID: 10436
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterCommonMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600E7DD RID: 59357 RVA: 0x00220AA5 File Offset: 0x0021ECA5
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

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x0600E7DE RID: 59358 RVA: 0x00220AC4 File Offset: 0x0021ECC4
		public override EMovieCameraType Type
		{
			get
			{
				return (EMovieCameraType)this.Instance.Type;
			}
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x00220AD1 File Offset: 0x0021ECD1
		public virtual string RowName
		{
			get
			{
				return this.Instance.RowName;
			}
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x0600E7E0 RID: 59360 RVA: 0x00220AE0 File Offset: 0x0021ECE0
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

		// Token: 0x0400802E RID: 32814
		private IEnterCommonMovieCamera Instance;
	}
}
