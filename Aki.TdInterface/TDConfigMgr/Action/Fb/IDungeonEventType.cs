using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CEF RID: 11503
	public class IDungeonEventType
	{
		// Token: 0x0600FBE8 RID: 64488 RVA: 0x002474CF File Offset: 0x002456CF
		public static IDungeonEventType Create(IDungeonEventType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDungeonEventType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x0600FBE9 RID: 64489 RVA: 0x002474EE File Offset: 0x002456EE
		public virtual EDungeonEventType Type
		{
			get
			{
				return (EDungeonEventType)this.Instance.Type;
			}
		}

		// Token: 0x04008995 RID: 35221
		private IDungeonEventType Instance;
	}
}
