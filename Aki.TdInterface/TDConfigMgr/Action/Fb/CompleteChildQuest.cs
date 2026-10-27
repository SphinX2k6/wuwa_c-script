using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002648 RID: 9800
	public class CompleteChildQuest : ActionParams
	{
		// Token: 0x0600DBD4 RID: 56276 RVA: 0x0020B7AC File Offset: 0x002099AC
		[NullableContext(1)]
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

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0600DBD5 RID: 56277 RVA: 0x0020B7CB File Offset: 0x002099CB
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x0600DBD6 RID: 56278 RVA: 0x0020B7D8 File Offset: 0x002099D8
		public virtual int NodeId
		{
			get
			{
				return this.Instance.NodeId;
			}
		}

		// Token: 0x04007A2C RID: 31276
		private ICompleteChildQuest Instance;
	}
}
