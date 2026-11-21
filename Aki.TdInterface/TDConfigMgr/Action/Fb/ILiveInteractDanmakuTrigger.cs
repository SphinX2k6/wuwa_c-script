using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1A RID: 11802
	public class ILiveInteractDanmakuTrigger
	{
		// Token: 0x0601005E RID: 65630 RVA: 0x0024E360 File Offset: 0x0024C560
		public static ILiveInteractDanmakuTrigger Create(ILiveInteractDanmakuTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050D8 RID: 20696
		// (get) Token: 0x0601005F RID: 65631 RVA: 0x0024E37F File Offset: 0x0024C57F
		public virtual ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				return (ELiveInteractDanmakuTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x04008BE2 RID: 35810
		private ILiveInteractDanmakuTrigger Instance;
	}
}
