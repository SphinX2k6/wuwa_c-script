using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B61 RID: 11105
	public class RestorePhantom : ActionParams
	{
		// Token: 0x0600F41D RID: 62493 RVA: 0x00239B60 File Offset: 0x00237D60
		public static RestorePhantom Create(IRestorePhantom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePhantom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x040085DD RID: 34269
		private IRestorePhantom Instance;
	}
}
