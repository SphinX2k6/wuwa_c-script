using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDD RID: 11485
	public class IDisableAlertAreaQuestCondition : IDisableAlertAreaCondition
	{
		// Token: 0x0600FBA0 RID: 64416 RVA: 0x00246F8E File Offset: 0x0024518E
		public static IDisableAlertAreaQuestCondition Create(IDisableAlertAreaQuestCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaQuestCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x0600FBA1 RID: 64417 RVA: 0x00246FAD File Offset: 0x002451AD
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x0600FBA2 RID: 64418 RVA: 0x00246FBA File Offset: 0x002451BA
		public virtual int RelatedQuestId
		{
			get
			{
				return this.Instance.RelatedQuestId;
			}
		}

		// Token: 0x04008979 RID: 35193
		private IDisableAlertAreaQuestCondition Instance;
	}
}
