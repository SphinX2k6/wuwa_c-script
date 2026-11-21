using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290C RID: 10508
	public class IAddEntityDecoration : IEntityDecorationConfig
	{
		// Token: 0x0600E9AD RID: 59821 RVA: 0x0022803B File Offset: 0x0022623B
		public static IAddEntityDecoration Create(IAddEntityDecoration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddEntityDecoration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x0600E9AE RID: 59822 RVA: 0x0022805A File Offset: 0x0022625A
		public override EEntityDecorationType Type
		{
			get
			{
				return (EEntityDecorationType)this.Instance.Type;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x00228067 File Offset: 0x00226267
		public virtual string DecorationId
		{
			get
			{
				return this.Instance.DecorationId;
			}
		}

		// Token: 0x040080CC RID: 32972
		private IAddEntityDecoration Instance;
	}
}
