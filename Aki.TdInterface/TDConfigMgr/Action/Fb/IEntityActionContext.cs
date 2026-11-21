using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200276A RID: 10090
	public class IEntityActionContext : IActionContextType
	{
		// Token: 0x0600DFAD RID: 57261 RVA: 0x0020EFF7 File Offset: 0x0020D1F7
		public static IEntityActionContext Create(IEntityActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600DFAE RID: 57262 RVA: 0x0020F016 File Offset: 0x0020D216
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x040079BA RID: 31162
		private IEntityActionContext Instance;
	}
}
