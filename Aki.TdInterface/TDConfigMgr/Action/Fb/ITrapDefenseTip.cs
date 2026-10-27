using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002758 RID: 10072
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseTip : ICommonTipType
	{
		// Token: 0x0600E067 RID: 57447 RVA: 0x0021300A File Offset: 0x0021120A
		public static ITrapDefenseTip Create(ITrapDefenseTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x0600E068 RID: 57448 RVA: 0x00213029 File Offset: 0x00211229
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x0600E069 RID: 57449 RVA: 0x00213036 File Offset: 0x00211236
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x00213043 File Offset: 0x00211243
		public virtual ETrapDefenseTipType TipType
		{
			get
			{
				return (ETrapDefenseTipType)this.Instance.TipType;
			}
		}

		// Token: 0x04007C56 RID: 31830
		private ITrapDefenseTip Instance;
	}
}
