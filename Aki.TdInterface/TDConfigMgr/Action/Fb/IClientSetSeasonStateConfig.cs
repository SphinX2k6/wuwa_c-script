using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B72 RID: 11122
	public class IClientSetSeasonStateConfig
	{
		// Token: 0x0600F45D RID: 62557 RVA: 0x0023A305 File Offset: 0x00238505
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

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x0600F45E RID: 62558 RVA: 0x0023A324 File Offset: 0x00238524
		public virtual EClientSetSeasonStateType Type
		{
			get
			{
				return (EClientSetSeasonStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008602 RID: 34306
		private IClientSetSeasonStateConfig Instance;
	}
}
