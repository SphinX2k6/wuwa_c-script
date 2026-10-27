using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001364 RID: 4964
	public class IUseSkillCheckBySkillGenre : IUseSkillCheckBase
	{
		// Token: 0x0600719B RID: 29083 RVA: 0x00111B3E File Offset: 0x0010FD3E
		[NullableContext(1)]
		public static IUseSkillCheckBySkillGenre Create(IUseSkillCheckBySkillGenre? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillGenre
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x00111B5D File Offset: 0x0010FD5D
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00111B6A File Offset: 0x0010FD6A
		public virtual ESkillCategory SkillGenre
		{
			get
			{
				return (ESkillCategory)this.Instance.SkillGenre;
			}
		}

		// Token: 0x040041A4 RID: 16804
		private IUseSkillCheckBySkillGenre Instance;
	}
}
