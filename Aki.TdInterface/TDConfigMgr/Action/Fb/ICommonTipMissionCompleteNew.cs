using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A13 RID: 10771
	public class ICommonTipMissionCompleteNew : ICommonTipType
	{
		// Token: 0x0600EE12 RID: 60946 RVA: 0x0022F619 File Offset: 0x0022D819
		public static ICommonTipMissionCompleteNew Create(ICommonTipMissionCompleteNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionCompleteNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x0600EE13 RID: 60947 RVA: 0x0022F638 File Offset: 0x0022D838
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x0600EE14 RID: 60948 RVA: 0x0022F645 File Offset: 0x0022D845
		public virtual EQuestCommonTipType QuestType
		{
			get
			{
				return (EQuestCommonTipType)this.Instance.QuestType;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0600EE15 RID: 60949 RVA: 0x0022F652 File Offset: 0x0022D852
		public virtual string TipTextKey
		{
			get
			{
				return this.Instance.TipTextKey;
			}
		}

		// Token: 0x040082F3 RID: 33523
		private ICommonTipMissionCompleteNew Instance;
	}
}
