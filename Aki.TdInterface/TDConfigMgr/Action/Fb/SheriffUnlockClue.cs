using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFD RID: 11005
	public class SheriffUnlockClue : ActionParams
	{
		// Token: 0x0600F10F RID: 61711 RVA: 0x0022F98D File Offset: 0x0022DB8D
		[NullableContext(1)]
		public static SheriffUnlockClue Create(ISheriffUnlockClue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffUnlockClue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x0600F110 RID: 61712 RVA: 0x0022F9AC File Offset: 0x0022DBAC
		public virtual int ClueId
		{
			get
			{
				return this.Instance.ClueId;
			}
		}

		// Token: 0x0400849B RID: 33947
		private ISheriffUnlockClue Instance;
	}
}
