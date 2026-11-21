using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2B RID: 11563
	public class IClientEventTarget
	{
		// Token: 0x0600FCB9 RID: 64697 RVA: 0x002488E1 File Offset: 0x00246AE1
		public static IClientEventTarget Create(IClientEventTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEventTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x0600FCBA RID: 64698 RVA: 0x00248900 File Offset: 0x00246B00
		public virtual EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x040089FF RID: 35327
		private IClientEventTarget Instance;
	}
}
