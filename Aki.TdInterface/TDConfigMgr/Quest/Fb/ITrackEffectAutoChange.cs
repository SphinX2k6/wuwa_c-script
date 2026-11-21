using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001466 RID: 5222
	public class ITrackEffectAutoChange : ITrackEffectType
	{
		// Token: 0x060076D0 RID: 30416 RVA: 0x0011D6C2 File Offset: 0x0011B8C2
		public static ITrackEffectAutoChange Create(ITrackEffectAutoChange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackEffectAutoChange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x060076D1 RID: 30417 RVA: 0x0011D6E1 File Offset: 0x0011B8E1
		public override ETrackEffectType Type
		{
			get
			{
				return (ETrackEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x0011D6EE File Offset: 0x0011B8EE
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x0011D6FB File Offset: 0x0011B8FB
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x04004438 RID: 17464
		private ITrackEffectAutoChange Instance;
	}
}
