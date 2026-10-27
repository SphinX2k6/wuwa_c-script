using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001366 RID: 4966
	public class IUseSkillCheckByVisionSummonId : IUseSkillCheckBase
	{
		// Token: 0x060071A3 RID: 29091 RVA: 0x00111BC0 File Offset: 0x0010FDC0
		[NullableContext(1)]
		public static IUseSkillCheckByVisionSummonId Create(IUseSkillCheckByVisionSummonId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionSummonId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x00111BDF File Offset: 0x0010FDDF
		public override EUseSkillCheckType Type
		{
			get
			{
				return (EUseSkillCheckType)this.Instance.Type;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x00111BEC File Offset: 0x0010FDEC
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x040041A6 RID: 16806
		private IUseSkillCheckByVisionSummonId Instance;
	}
}
