using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A8A RID: 10890
	public class DestroyQuest : ActionParams
	{
		// Token: 0x0600F058 RID: 61528 RVA: 0x0023397A File Offset: 0x00231B7A
		public static DestroyQuest Create(IDestroyQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x0600F059 RID: 61529 RVA: 0x00233999 File Offset: 0x00231B99
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x0600F05A RID: 61530 RVA: 0x002339A8 File Offset: 0x00231BA8
		public virtual bool? IsDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDestroy);
			}
		}

		// Token: 0x0400842E RID: 33838
		private IDestroyQuest Instance;
	}
}
