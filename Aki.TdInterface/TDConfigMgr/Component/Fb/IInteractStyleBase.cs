using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B44 RID: 2884
	public class IInteractStyleBase
	{
		// Token: 0x060041E7 RID: 16871 RVA: 0x000A7A9A File Offset: 0x000A5C9A
		public static IInteractStyleBase Create(IInteractStyleBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x000A7AB9 File Offset: 0x000A5CB9
		public virtual EInteractStyleType Type
		{
			get
			{
				return (EInteractStyleType)this.Instance.Type;
			}
		}

		// Token: 0x0400247D RID: 9341
		private IInteractStyleBase Instance;
	}
}
