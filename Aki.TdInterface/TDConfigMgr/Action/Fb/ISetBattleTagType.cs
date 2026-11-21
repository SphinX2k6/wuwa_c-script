using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200299A RID: 10650
	public class ISetBattleTagType
	{
		// Token: 0x0600EC10 RID: 60432 RVA: 0x0022C243 File Offset: 0x0022A443
		public static ISetBattleTagType Create(ISetBattleTagType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x0600EC11 RID: 60433 RVA: 0x0022C262 File Offset: 0x0022A462
		public virtual ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x040081FE RID: 33278
		private ISetBattleTagType Instance;
	}
}
