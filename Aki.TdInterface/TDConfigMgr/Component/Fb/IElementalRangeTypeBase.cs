using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E21 RID: 3617
	public class IElementalRangeTypeBase
	{
		// Token: 0x060051D8 RID: 20952 RVA: 0x000C9C25 File Offset: 0x000C7E25
		[NullableContext(1)]
		public static IElementalRangeTypeBase Create(IElementalRangeTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalRangeTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x000C9C44 File Offset: 0x000C7E44
		public virtual EElementalRangeType Type
		{
			get
			{
				return (EElementalRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002F24 RID: 12068
		private IElementalRangeTypeBase Instance;
	}
}
