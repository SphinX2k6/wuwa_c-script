using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026AA RID: 9898
	public class ExitDungeon : ActionParams
	{
		// Token: 0x0600DD83 RID: 56707 RVA: 0x0020E751 File Offset: 0x0020C951
		[NullableContext(1)]
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

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x0020E770 File Offset: 0x0020C970
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

		// Token: 0x04007B02 RID: 31490
		private IExitDungeon Instance;
	}
}
