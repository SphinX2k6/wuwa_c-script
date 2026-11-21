using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D2 RID: 10706
	public class IUnlockSystemItemType
	{
		// Token: 0x0600ECF3 RID: 60659 RVA: 0x0022D988 File Offset: 0x0022BB88
		public static IUnlockSystemItemType Create(IUnlockSystemItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockSystemItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x0600ECF4 RID: 60660 RVA: 0x0022D9A7 File Offset: 0x0022BBA7
		public virtual EUnlockSystemItemType Type
		{
			get
			{
				return (EUnlockSystemItemType)this.Instance.Type;
			}
		}

		// Token: 0x0400826C RID: 33388
		private IUnlockSystemItemType Instance;
	}
}
