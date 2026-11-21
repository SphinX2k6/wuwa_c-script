using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E30 RID: 3632
	public class IEntityMatchConfig
	{
		// Token: 0x06005247 RID: 21063 RVA: 0x000CB85A File Offset: 0x000C9A5A
		public static IEntityMatchConfig Create(IEntityMatchConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x000CB879 File Offset: 0x000C9A79
		public virtual EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x04002EFD RID: 12029
		private IEntityMatchConfig Instance;
	}
}
