using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A51 RID: 10833
	[NullableContext(1)]
	[Nullable(0)]
	public class ReignsChangePlayerName : ActionParams
	{
		// Token: 0x0600EE66 RID: 61030 RVA: 0x0022B4A7 File Offset: 0x002296A7
		public static ReignsChangePlayerName Create(IReignsChangePlayerName? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangePlayerName
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x0600EE67 RID: 61031 RVA: 0x0022B4C6 File Offset: 0x002296C6
		public virtual string PlayerNameId
		{
			get
			{
				return this.Instance.PlayerNameId;
			}
		}

		// Token: 0x0400832D RID: 33581
		private IReignsChangePlayerName Instance;
	}
}
