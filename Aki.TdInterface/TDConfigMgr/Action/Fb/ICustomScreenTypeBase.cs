using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295E RID: 10590
	public class ICustomScreenTypeBase
	{
		// Token: 0x0600EB0E RID: 60174 RVA: 0x0022A6E6 File Offset: 0x002288E6
		public static ICustomScreenTypeBase Create(ICustomScreenTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x0600EB0F RID: 60175 RVA: 0x0022A705 File Offset: 0x00228905
		public virtual ECustomScreenType Type
		{
			get
			{
				return (ECustomScreenType)this.Instance.Type;
			}
		}

		// Token: 0x0400817C RID: 33148
		private ICustomScreenTypeBase Instance;
	}
}
