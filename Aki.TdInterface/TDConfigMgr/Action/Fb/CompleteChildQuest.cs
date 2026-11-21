using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002908 RID: 10504
	public class CompleteChildQuest : ActionParams
	{
		// Token: 0x0600E9A2 RID: 59810 RVA: 0x00227F78 File Offset: 0x00226178
		public static CompleteChildQuest Create(ICompleteChildQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CompleteChildQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x00227F97 File Offset: 0x00226197
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x00227FA4 File Offset: 0x002261A4
		public virtual int NodeId
		{
			get
			{
				return this.Instance.NodeId;
			}
		}

		// Token: 0x040080C8 RID: 32968
		private ICompleteChildQuest Instance;
	}
}
