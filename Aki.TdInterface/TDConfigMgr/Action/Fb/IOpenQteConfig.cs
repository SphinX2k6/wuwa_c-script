using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CC6 RID: 11462
	public class IOpenQteConfig
	{
		// Token: 0x0600FB4D RID: 64333 RVA: 0x00246820 File Offset: 0x00244A20
		public static IOpenQteConfig Create(IOpenQteConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenQteConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x0600FB4E RID: 64334 RVA: 0x0024683F File Offset: 0x00244A3F
		public virtual EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x0400894E RID: 35150
		private IOpenQteConfig Instance;
	}
}
