using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A81 RID: 10881
	public class ChangeFightTeam : ActionParams
	{
		// Token: 0x0600F01F RID: 61471 RVA: 0x00232F1C File Offset: 0x0023111C
		public static ChangeFightTeam Create(IChangeFightTeam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeFightTeam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x0600F020 RID: 61472 RVA: 0x00232F3C File Offset: 0x0023113C
		public virtual int? TeamIndex
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TeamIndex);
			}
		}

		// Token: 0x04008409 RID: 33801
		private IChangeFightTeam Instance;
	}
}
