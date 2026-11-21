using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC3 RID: 11715
	public class IEnterMovieModeDurationType
	{
		// Token: 0x0600FF17 RID: 65303 RVA: 0x0024C526 File Offset: 0x0024A726
		public static IEnterMovieModeDurationType Create(IEnterMovieModeDurationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterMovieModeDurationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x0600FF18 RID: 65304 RVA: 0x0024C545 File Offset: 0x0024A745
		public virtual EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x04008B3B RID: 35643
		private IEnterMovieModeDurationType Instance;
	}
}
