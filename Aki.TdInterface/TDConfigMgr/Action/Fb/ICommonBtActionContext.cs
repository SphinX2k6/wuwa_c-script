using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276D RID: 10093
	public class ICommonBtActionContext : IActionContextType
	{
		// Token: 0x0600DFB7 RID: 57271 RVA: 0x0020F0CA File Offset: 0x0020D2CA
		public static ICommonBtActionContext Create(ICommonBtActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonBtActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600DFB8 RID: 57272 RVA: 0x0020F0E9 File Offset: 0x0020D2E9
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079BD RID: 31165
		private ICommonBtActionContext Instance;
	}
}
