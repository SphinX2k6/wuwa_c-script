using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002747 RID: 10055
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipMissionCompleteNew : ICommonTipType
	{
		// Token: 0x0600E012 RID: 57362 RVA: 0x00212AE1 File Offset: 0x00210CE1
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

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x0600E013 RID: 57363 RVA: 0x00212B00 File Offset: 0x00210D00
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x00212B0D File Offset: 0x00210D0D
		public virtual EQuestCommonTipType QuestType
		{
			get
			{
				return (EQuestCommonTipType)this.Instance.QuestType;
			}
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x0600E015 RID: 57365 RVA: 0x00212B1A File Offset: 0x00210D1A
		public virtual string TipTextKey
		{
			get
			{
				return this.Instance.TipTextKey;
			}
		}

		// Token: 0x04007C45 RID: 31813
		private ICommonTipMissionCompleteNew Instance;
	}
}
