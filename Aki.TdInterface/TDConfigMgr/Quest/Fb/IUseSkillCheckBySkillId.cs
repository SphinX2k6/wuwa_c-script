using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001365 RID: 4965
	public class IUseSkillCheckBySkillId : IUseSkillCheckBase
	{
		// Token: 0x0600719F RID: 29087 RVA: 0x00111B7F File Offset: 0x0010FD7F
		[NullableContext(1)]
		public static IUseSkillCheckBySkillId Create(IUseSkillCheckBySkillId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x00111B9E File Offset: 0x0010FD9E
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x00111BAB File Offset: 0x0010FDAB
		public virtual int SkillId
		{
			get
			{
				return this.Instance.SkillId;
			}
		}

		// Token: 0x040041A5 RID: 16805
		private IUseSkillCheckBySkillId Instance;
	}
}
