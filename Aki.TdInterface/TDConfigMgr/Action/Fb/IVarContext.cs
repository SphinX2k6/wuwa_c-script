using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278C RID: 10124
	public class IVarContext
	{
		// Token: 0x0600E042 RID: 57410 RVA: 0x0021026A File Offset: 0x0020E46A
		public static IVarContext Create(IVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600E043 RID: 57411 RVA: 0x00210289 File Offset: 0x0020E489
		public virtual EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x040079FE RID: 31230
		private IVarContext Instance;
	}
}
