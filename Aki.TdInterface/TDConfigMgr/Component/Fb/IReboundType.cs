using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D67 RID: 3431
	public class IReboundType
	{
		// Token: 0x06004E0A RID: 19978 RVA: 0x000C2975 File Offset: 0x000C0B75
		public static IReboundType Create(IReboundType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReboundType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x000C2994 File Offset: 0x000C0B94
		public virtual EReboundOptionType Type
		{
			get
			{
				return (EReboundOptionType)this.Instance.Type;
			}
		}

		// Token: 0x04002C52 RID: 11346
		private IReboundType Instance;
	}
}
