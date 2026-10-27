using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002893 RID: 10387
	public class ISwitchDataLayersTransitionType
	{
		// Token: 0x0600E609 RID: 58889 RVA: 0x0021CF50 File Offset: 0x0021B150
		[NullableContext(1)]
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

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x0600E60A RID: 58890 RVA: 0x0021CF6F File Offset: 0x0021B16F
		public virtual ESwitchDataLayersTransitionType Type
		{
			get
			{
				return (ESwitchDataLayersTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x04007F2D RID: 32557
		private ISwitchDataLayersTransitionType Instance;
	}
}
