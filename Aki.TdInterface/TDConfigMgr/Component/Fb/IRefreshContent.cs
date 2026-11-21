using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B87 RID: 2951
	public class IRefreshContent
	{
		// Token: 0x06004381 RID: 17281 RVA: 0x000AB33F File Offset: 0x000A953F
		public static IRefreshContent Create(IRefreshContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x000AB35E File Offset: 0x000A955E
		public virtual ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x04002548 RID: 9544
		private IRefreshContent Instance;
	}
}
