using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B68 RID: 11112
	public class ISwitchDataLayersTransitionType
	{
		// Token: 0x0600F438 RID: 62520 RVA: 0x00239ED0 File Offset: 0x002380D0
		public static ISwitchDataLayersTransitionType Create(ISwitchDataLayersTransitionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x0600F439 RID: 62521 RVA: 0x00239EEF File Offset: 0x002380EF
		public virtual ESwitchDataLayersTransitionType Type
		{
			get
			{
				return (ESwitchDataLayersTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x040085EC RID: 34284
		private ISwitchDataLayersTransitionType Instance;
	}
}
