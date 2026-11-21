using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290B RID: 10507
	public class IEntityDecorationConfig
	{
		// Token: 0x0600E9AA RID: 59818 RVA: 0x00228007 File Offset: 0x00226207
		public static IEntityDecorationConfig Create(IEntityDecorationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityDecorationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x0600E9AB RID: 59819 RVA: 0x00228026 File Offset: 0x00226226
		public virtual EEntityDecorationType Type
		{
			get
			{
				return (EEntityDecorationType)this.Instance.Type;
			}
		}

		// Token: 0x040080CB RID: 32971
		private IEntityDecorationConfig Instance;
	}
}
