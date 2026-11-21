using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BD0 RID: 11216
	public class ITeleControlConfig : IExploreConfig
	{
		// Token: 0x0600F730 RID: 63280 RVA: 0x0023FD1D File Offset: 0x0023DF1D
		public static ITeleControlConfig Create(ITeleControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x0600F731 RID: 63281 RVA: 0x0023FD3C File Offset: 0x0023DF3C
		public override EExploreStateType Type
		{
			get
			{
				return (EExploreStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x0600F732 RID: 63282 RVA: 0x0023FD49 File Offset: 0x0023DF49
		public virtual ETeleControlType TeleControlType
		{
			get
			{
				return (ETeleControlType)this.Instance.TeleControlType;
			}
		}

		// Token: 0x0400875A RID: 34650
		private ITeleControlConfig Instance;
	}
}
