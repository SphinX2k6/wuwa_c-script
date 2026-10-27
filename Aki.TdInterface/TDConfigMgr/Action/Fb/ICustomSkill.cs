using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D3 RID: 10195
	public class ICustomSkill : ILeisureInteractType
	{
		// Token: 0x0600E29F RID: 58015 RVA: 0x002174CF File Offset: 0x002156CF
		[NullableContext(1)]
		public static ICustomSkill Create(ICustomSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x0600E2A0 RID: 58016 RVA: 0x002174EE File Offset: 0x002156EE
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x002174FB File Offset: 0x002156FB
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x04007DA5 RID: 32165
		private ICustomSkill Instance;
	}
}
