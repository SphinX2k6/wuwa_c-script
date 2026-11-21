using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296F RID: 10607
	public class FinishDungeon : ActionParams
	{
		// Token: 0x0600EB60 RID: 60256 RVA: 0x0022AF82 File Offset: 0x00229182
		public static FinishDungeon Create(IFinishDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FinishDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x0600EB61 RID: 60257 RVA: 0x0022AFA1 File Offset: 0x002291A1
		public virtual bool IsSuccess
		{
			get
			{
				return this.Instance.IsSuccess;
			}
		}

		// Token: 0x040081A1 RID: 33185
		private IFinishDungeon Instance;
	}
}
