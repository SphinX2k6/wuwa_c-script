using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200289D RID: 10397
	public class IClientSetSeasonStateConfig
	{
		// Token: 0x0600E62E RID: 58926 RVA: 0x0021D385 File Offset: 0x0021B585
		[NullableContext(1)]
		public static IClientSetSeasonStateConfig Create(IClientSetSeasonStateConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientSetSeasonStateConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x0600E62F RID: 58927 RVA: 0x0021D3A4 File Offset: 0x0021B5A4
		public virtual EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x04007F43 RID: 32579
		private IClientSetSeasonStateConfig Instance;
	}
}
