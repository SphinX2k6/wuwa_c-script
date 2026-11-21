using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290D RID: 10509
	public class IRemoveEntityDecoration : IEntityDecorationConfig
	{
		// Token: 0x0600E9B1 RID: 59825 RVA: 0x0022807C File Offset: 0x0022627C
		public static IRemoveEntityDecoration Create(IRemoveEntityDecoration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveEntityDecoration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x0022809B File Offset: 0x0022629B
		public override EEntityDecorationType Type
		{
			get
			{
				return (EEntityDecorationType)this.Instance.Type;
			}
		}

		// Token: 0x040080CD RID: 32973
		private IRemoveEntityDecoration Instance;
	}
}
