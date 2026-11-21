using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A27 RID: 10791
	public class IVisionSettlementHardTip : ICommonTipType
	{
		// Token: 0x0600EE77 RID: 61047 RVA: 0x0022FC25 File Offset: 0x0022DE25
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

		// Token: 0x170046D7 RID: 18135
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x0022FC44 File Offset: 0x0022DE44
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x0600EE79 RID: 61049 RVA: 0x0022FC51 File Offset: 0x0022DE51
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x0600EE7A RID: 61050 RVA: 0x0022FC5E File Offset: 0x0022DE5E
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x0600EE7B RID: 61051 RVA: 0x0022FC6B File Offset: 0x0022DE6B
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x0600EE7C RID: 61052 RVA: 0x0022FC6E File Offset: 0x0022DE6E
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008307 RID: 33543
		private IVisionSettlementHardTip Instance;
	}
}
