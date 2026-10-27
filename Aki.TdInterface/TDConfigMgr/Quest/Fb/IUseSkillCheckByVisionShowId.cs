using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001367 RID: 4967
	public class IUseSkillCheckByVisionShowId : IUseSkillCheckBase
	{
		// Token: 0x060071A7 RID: 29095 RVA: 0x00111C01 File Offset: 0x0010FE01
		[NullableContext(1)]
		public static IUseSkillCheckByVisionShowId Create(IUseSkillCheckByVisionShowId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionShowId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x00111C20 File Offset: 0x0010FE20
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x00111C2D File Offset: 0x0010FE2D
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x040041A7 RID: 16807
		private IUseSkillCheckByVisionShowId Instance;
	}
}
