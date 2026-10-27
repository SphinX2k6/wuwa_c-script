using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D9 RID: 10713
	public class IOpenQteConfig
	{
		// Token: 0x0600ECB6 RID: 60598 RVA: 0x00228E9C File Offset: 0x0022709C
		[NullableContext(1)]
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

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x0600ECB7 RID: 60599 RVA: 0x00228EBB File Offset: 0x002270BB
		public virtual EOpenQteType Type
		{
			get
			{
				return (EOpenQteType)this.Instance.Type;
			}
		}

		// Token: 0x0400825D RID: 33373
		private IOpenQteConfig Instance;
	}
}
