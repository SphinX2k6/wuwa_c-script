using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029D3 RID: 10707
	public class IUnlockCookSystemType
	{
		// Token: 0x0600ECF6 RID: 60662 RVA: 0x0022D9BC File Offset: 0x0022BBBC
		public static IUnlockCookSystemType Create(IUnlockCookSystemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUnlockCookSystemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x0022D9DB File Offset: 0x0022BBDB
		public virtual EUnlockCookSystemType Type
		{
			get
			{
				return (EUnlockCookSystemType)this.Instance.Type;
			}
		}

		// Token: 0x0400826D RID: 33389
		private IUnlockCookSystemType Instance;
	}
}
