using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1B RID: 11803
	public class ILiveInteractDanmakuTriggerSkillGenre : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06010061 RID: 65633 RVA: 0x0024E394 File Offset: 0x0024C594
		public static ILiveInteractDanmakuTriggerSkillGenre Create(ILiveInteractDanmakuTriggerSkillGenre? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillGenre
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x06010062 RID: 65634 RVA: 0x0024E3B3 File Offset: 0x0024C5B3
		public override ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				return (ELiveInteractDanmakuTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x06010063 RID: 65635 RVA: 0x0024E3C0 File Offset: 0x0024C5C0
		public virtual int SkillGenre
		{
			get
			{
				return this.Instance.SkillGenre;
			}
		}

		// Token: 0x04008BE3 RID: 35811
		private ILiveInteractDanmakuTriggerSkillGenre Instance;
	}
}
