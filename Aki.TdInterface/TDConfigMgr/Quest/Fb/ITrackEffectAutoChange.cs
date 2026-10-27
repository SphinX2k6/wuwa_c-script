using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001316 RID: 4886
	public class ITrackEffectAutoChange : ITrackEffectType
	{
		// Token: 0x06007030 RID: 28720 RVA: 0x0010F156 File Offset: 0x0010D356
		[NullableContext(1)]
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

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x06007031 RID: 28721 RVA: 0x0010F175 File Offset: 0x0010D375
		public override ETrackEffectType Type
		{
			get
			{
				return (ETrackEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007032 RID: 28722 RVA: 0x0010F182 File Offset: 0x0010D382
		public virtual int EnterRange
		{
			get
			{
				return this.Instance.EnterRange;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x0010F18F File Offset: 0x0010D38F
		public virtual int LeaveRange
		{
			get
			{
				return this.Instance.LeaveRange;
			}
		}

		// Token: 0x040040BC RID: 16572
		private ITrackEffectAutoChange Instance;
	}
}
