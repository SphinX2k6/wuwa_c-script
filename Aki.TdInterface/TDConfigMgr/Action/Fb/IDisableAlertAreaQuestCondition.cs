using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029F0 RID: 10736
	public class IDisableAlertAreaQuestCondition : IDisableAlertAreaCondition
	{
		// Token: 0x0600ED09 RID: 60681 RVA: 0x0022960A File Offset: 0x0022780A
		[NullableContext(1)]
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

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x0600ED0A RID: 60682 RVA: 0x00229629 File Offset: 0x00227829
		public override EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x00229636 File Offset: 0x00227836
		public virtual int RelatedQuestId
		{
			get
			{
				return this.Instance.RelatedQuestId;
			}
		}

		// Token: 0x04008288 RID: 33416
		private IDisableAlertAreaQuestCondition Instance;
	}
}
