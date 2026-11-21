using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D53 RID: 11603
	public class INpcGroupSequenceMontageBlendAnimType : INpcGroupSequenceBlendAnimTypeBase
	{
		// Token: 0x0600FD50 RID: 64848 RVA: 0x00249500 File Offset: 0x00247700
		public static INpcGroupSequenceMontageBlendAnimType Create(INpcGroupSequenceMontageBlendAnimType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceMontageBlendAnimType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x0600FD51 RID: 64849 RVA: 0x0024951F File Offset: 0x0024771F
		public override ENpcGroupSequenceBlendAnimType Type
		{
			get
			{
				return (ENpcGroupSequenceBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x0600FD52 RID: 64850 RVA: 0x0024952C File Offset: 0x0024772C
		public virtual int MontageId
		{
			get
			{
				return this.Instance.MontageId;
			}
		}

		// Token: 0x04008A43 RID: 35395
		private INpcGroupSequenceMontageBlendAnimType Instance;
	}
}
