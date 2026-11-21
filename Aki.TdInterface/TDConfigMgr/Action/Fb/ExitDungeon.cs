using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296D RID: 10605
	public class ExitDungeon : ActionParams
	{
		// Token: 0x0600EB5A RID: 60250 RVA: 0x0022AEF1 File Offset: 0x002290F1
		public static ExitDungeon Create(IExitDungeon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitDungeon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x0600EB5B RID: 60251 RVA: 0x0022AF10 File Offset: 0x00229110
		public virtual bool? IsNeedSecondaryConfirmation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNeedSecondaryConfirmation);
			}
		}

		// Token: 0x0400819F RID: 33183
		private IExitDungeon Instance;
	}
}
