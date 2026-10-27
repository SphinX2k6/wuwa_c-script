using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AF7 RID: 10999
	public class BossPilingRandomBuff : ActionParams
	{
		// Token: 0x0600F0F7 RID: 61687 RVA: 0x0022F6D8 File Offset: 0x0022D8D8
		[NullableContext(1)]
		public static BossPilingRandomBuff Create(IBossPilingRandomBuff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BossPilingRandomBuff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x0600F0F8 RID: 61688 RVA: 0x0022F6F7 File Offset: 0x0022D8F7
		public virtual int BuffPoolId
		{
			get
			{
				return this.Instance.BuffPoolId;
			}
		}

		// Token: 0x0400848B RID: 33931
		private IBossPilingRandomBuff Instance;
	}
}
