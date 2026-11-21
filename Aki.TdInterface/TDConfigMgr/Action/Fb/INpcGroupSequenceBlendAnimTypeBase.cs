using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D52 RID: 11602
	public class INpcGroupSequenceBlendAnimTypeBase
	{
		// Token: 0x0600FD4D RID: 64845 RVA: 0x002494CC File Offset: 0x002476CC
		public static INpcGroupSequenceBlendAnimTypeBase Create(INpcGroupSequenceBlendAnimTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceBlendAnimTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x0600FD4E RID: 64846 RVA: 0x002494EB File Offset: 0x002476EB
		public virtual ENpcGroupSequenceBlendAnimType Type
		{
			get
			{
				return (ENpcGroupSequenceBlendAnimType)this.Instance.Type;
			}
		}

		// Token: 0x04008A42 RID: 35394
		private INpcGroupSequenceBlendAnimTypeBase Instance;
	}
}
