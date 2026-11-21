using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4A RID: 11338
	public class IFocusOnQuestMapMark : IFocusOnMapMark
	{
		// Token: 0x0600F95D RID: 63837 RVA: 0x00243981 File Offset: 0x00241B81
		public static IFocusOnQuestMapMark Create(IFocusOnQuestMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnQuestMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x0600F95E RID: 63838 RVA: 0x002439A0 File Offset: 0x00241BA0
		public override EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x0600F95F RID: 63839 RVA: 0x002439AD File Offset: 0x00241BAD
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x0400884E RID: 34894
		private IFocusOnQuestMapMark Instance;
	}
}
