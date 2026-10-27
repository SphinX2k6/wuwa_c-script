using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001368 RID: 4968
	public class IUseSkillCheckByFollowShooterSkillId : IUseSkillCheckBase
	{
		// Token: 0x060071AB RID: 29099 RVA: 0x00111C42 File Offset: 0x0010FE42
		[NullableContext(1)]
		public static IUseSkillCheckByFollowShooterSkillId Create(IUseSkillCheckByFollowShooterSkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByFollowShooterSkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x00111C61 File Offset: 0x0010FE61
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x00111C6E File Offset: 0x0010FE6E
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x040041A8 RID: 16808
		private IUseSkillCheckByFollowShooterSkillId Instance;
	}
}
