using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E19 RID: 11801
	public class ILiveUnloadDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x0601005A RID: 65626 RVA: 0x0024E31F File Offset: 0x0024C51F
		public static ILiveUnloadDanmakuConfig Create(ILiveUnloadDanmakuConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveUnloadDanmakuConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x0601005B RID: 65627 RVA: 0x0024E33E File Offset: 0x0024C53E
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				return (ELiveDanmakuOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x0601005C RID: 65628 RVA: 0x0024E34B File Offset: 0x0024C54B
		public virtual ELiveDanmakuClearType ClearType
		{
			get
			{
				return (ELiveDanmakuClearType)this.Instance.ClearType;
			}
		}

		// Token: 0x04008BE1 RID: 35809
		private ILiveUnloadDanmakuConfig Instance;
	}
}
