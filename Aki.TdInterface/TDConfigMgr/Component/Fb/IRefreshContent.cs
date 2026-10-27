using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABD RID: 2749
	public class IRefreshContent
	{
		// Token: 0x06003F57 RID: 16215 RVA: 0x000A1D4B File Offset: 0x0009FF4B
		[NullableContext(1)]
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

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x000A1D6A File Offset: 0x0009FF6A
		public virtual ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x0400232C RID: 9004
		private IRefreshContent Instance;
	}
}
