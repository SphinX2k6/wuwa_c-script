using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A24 RID: 10788
	public class ITrapDefenseTip : ICommonTipType
	{
		// Token: 0x0600EE67 RID: 61031 RVA: 0x0022FB42 File Offset: 0x0022DD42
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

		// Token: 0x170046CD RID: 18125
		// (get) Token: 0x0600EE68 RID: 61032 RVA: 0x0022FB61 File Offset: 0x0022DD61
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046CE RID: 18126
		// (get) Token: 0x0600EE69 RID: 61033 RVA: 0x0022FB6E File Offset: 0x0022DD6E
		public virtual string MainText
		{
			get
			{
				return this.Instance.MainText;
			}
		}

		// Token: 0x170046CF RID: 18127
		// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x0022FB7B File Offset: 0x0022DD7B
		public virtual ETrapDefenseTipType TipType
		{
			get
			{
				return (ETrapDefenseTipType)this.Instance.TipType;
			}
		}

		// Token: 0x04008304 RID: 33540
		private ITrapDefenseTip Instance;
	}
}
