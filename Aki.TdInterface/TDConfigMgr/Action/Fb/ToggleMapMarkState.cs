using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C44 RID: 11332
	public class ToggleMapMarkState : ActionParams
	{
		// Token: 0x0600F946 RID: 63814 RVA: 0x002437DC File Offset: 0x002419DC
		public static ToggleMapMarkState Create(IToggleMapMarkState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleMapMarkState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x0600F947 RID: 63815 RVA: 0x002437FB File Offset: 0x002419FB
		public virtual EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x04008848 RID: 34888
		private IToggleMapMarkState Instance;
	}
}
