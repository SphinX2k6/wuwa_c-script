using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001465 RID: 5221
	public class ITrackEffectType
	{
		// Token: 0x060076CD RID: 30413 RVA: 0x0011D68E File Offset: 0x0011B88E
		public static ITrackEffectType Create(ITrackEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x0011D6AD File Offset: 0x0011B8AD
		public virtual ETrackEffectType Type
		{
			get
			{
				return (ETrackEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04004437 RID: 17463
		private ITrackEffectType Instance;
	}
}
