using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E1C RID: 11804
	public class ILiveInteractDanmakuTriggerSkillId : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06010065 RID: 65637 RVA: 0x0024E3D5 File Offset: 0x0024C5D5
		public static ILiveInteractDanmakuTriggerSkillId Create(ILiveInteractDanmakuTriggerSkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x06010066 RID: 65638 RVA: 0x0024E3F4 File Offset: 0x0024C5F4
		public override ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				return (ELiveInteractDanmakuTriggerType)this.Instance.Type;
			}
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x06010067 RID: 65639 RVA: 0x0024E401 File Offset: 0x0024C601
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x04008BE4 RID: 35812
		private ILiveInteractDanmakuTriggerSkillId Instance;
	}
}
