using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F09 RID: 3849
	public class IWuWaGoBowTrap : IWuWaGoEntityBase
	{
		// Token: 0x0600568F RID: 22159 RVA: 0x000D465C File Offset: 0x000D285C
		public static IWuWaGoBowTrap Create(IWuWaGoBowTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoBowTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x000D467B File Offset: 0x000D287B
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x040031AA RID: 12714
		private IWuWaGoBowTrap Instance;
	}
}
