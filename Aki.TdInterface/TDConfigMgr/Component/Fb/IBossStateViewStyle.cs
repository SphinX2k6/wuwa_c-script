using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE2 RID: 3298
	public class IBossStateViewStyle
	{
		// Token: 0x06004B48 RID: 19272 RVA: 0x000BCE8A File Offset: 0x000BB08A
		public static IBossStateViewStyle Create(IBossStateViewStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossStateViewStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x000BCEA9 File Offset: 0x000BB0A9
		public virtual EBossStateViewStyle Type
		{
			get
			{
				return (EBossStateViewStyle)this.Instance.Type;
			}
		}

		// Token: 0x04002A93 RID: 10899
		private IBossStateViewStyle Instance;
	}
}
