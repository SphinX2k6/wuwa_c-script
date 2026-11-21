using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D4 RID: 10708
	public class IUnlockCookSystemCookBook : IUnlockCookSystemType
	{
		// Token: 0x0600ECF9 RID: 60665 RVA: 0x0022D9F0 File Offset: 0x0022BBF0
		public static IUnlockCookSystemCookBook Create(IUnlockCookSystemCookBook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemCookBook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x0600ECFA RID: 60666 RVA: 0x0022DA0F File Offset: 0x0022BC0F
		public override EUnlockCookSystemType Type
		{
			get
			{
				return (EUnlockCookSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x0022DA1C File Offset: 0x0022BC1C
		public virtual int CookBookId
		{
			get
			{
				return this.Instance.CookBookId;
			}
		}

		// Token: 0x0400826E RID: 33390
		private IUnlockCookSystemCookBook Instance;
	}
}
