using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACF RID: 10959
	public class IEnterMovieModeDurationType
	{
		// Token: 0x0600F061 RID: 61537 RVA: 0x0022E81A File Offset: 0x0022CA1A
		[NullableContext(1)]
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

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x0600F062 RID: 61538 RVA: 0x0022E839 File Offset: 0x0022CA39
		public virtual EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x04008437 RID: 33847
		private IEnterMovieModeDurationType Instance;
	}
}
