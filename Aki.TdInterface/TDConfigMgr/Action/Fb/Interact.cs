using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200277A RID: 10106
	public class Interact : ActionParams
	{
		// Token: 0x0600DFEF RID: 57327 RVA: 0x0020F716 File Offset: 0x0020D916
		public static Interact Create(IInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Interact
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x0020F735 File Offset: 0x0020D935
		public virtual int Who
		{
			get
			{
				return this.Instance.Who;
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x0020F742 File Offset: 0x0020D942
		public virtual string Param
		{
			get
			{
				return this.Instance.Param;
			}
		}

		// Token: 0x040079D0 RID: 31184
		private IInteract Instance;
	}
}
