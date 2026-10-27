using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200275B RID: 10075
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementHardTip : ICommonTipType
	{
		// Token: 0x0600E077 RID: 57463 RVA: 0x002130ED File Offset: 0x002112ED
		public static IVisionSettlementHardTip Create(IVisionSettlementHardTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSettlementHardTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x0600E078 RID: 57464 RVA: 0x0021310C File Offset: 0x0021130C
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x0600E079 RID: 57465 RVA: 0x00213119 File Offset: 0x00211319
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x00213126 File Offset: 0x00211326
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x00213133 File Offset: 0x00211333
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x0600E07C RID: 57468 RVA: 0x00213136 File Offset: 0x00211336
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C59 RID: 31833
		private IVisionSettlementHardTip Instance;
	}
}
