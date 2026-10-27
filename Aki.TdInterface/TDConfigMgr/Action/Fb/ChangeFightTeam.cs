using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AE RID: 10158
	public class ChangeFightTeam : ActionParams
	{
		// Token: 0x0600E1FD RID: 57853 RVA: 0x00216148 File Offset: 0x00214348
		[NullableContext(1)]
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

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x0600E1FE RID: 57854 RVA: 0x00216168 File Offset: 0x00214368
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

		// Token: 0x04007D52 RID: 32082
		private IChangeFightTeam Instance;
	}
}
