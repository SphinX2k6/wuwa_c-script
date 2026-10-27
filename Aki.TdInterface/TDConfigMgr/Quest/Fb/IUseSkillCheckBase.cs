using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001363 RID: 4963
	public class IUseSkillCheckBase
	{
		// Token: 0x06007198 RID: 29080 RVA: 0x00111B0A File Offset: 0x0010FD0A
		[NullableContext(1)]
		public static IUseSkillCheckBase Create(IUseSkillCheckBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x00111B29 File Offset: 0x0010FD29
		public virtual EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x040041A3 RID: 16803
		private IUseSkillCheckBase Instance;
	}
}
