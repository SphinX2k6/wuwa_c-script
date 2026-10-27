using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002965 RID: 10597
	public class IFocusOnQuestMapMark : IFocusOnMapMark
	{
		// Token: 0x0600EAE7 RID: 60135 RVA: 0x002262C9 File Offset: 0x002244C9
		[NullableContext(1)]
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

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x0600EAE8 RID: 60136 RVA: 0x002262E8 File Offset: 0x002244E8
		public override EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x0600EAE9 RID: 60137 RVA: 0x002262F5 File Offset: 0x002244F5
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x0400816D RID: 33133
		private IFocusOnQuestMapMark Instance;
	}
}
