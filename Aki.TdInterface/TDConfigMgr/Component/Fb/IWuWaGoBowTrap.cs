using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0D RID: 3597
	public class IWuWaGoBowTrap : IWuWaGoEntityBase
	{
		// Token: 0x06005168 RID: 20840 RVA: 0x000C8D94 File Offset: 0x000C6F94
		[NullableContext(1)]
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06005169 RID: 20841 RVA: 0x000C8DB3 File Offset: 0x000C6FB3
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04002EE2 RID: 12002
		private IWuWaGoBowTrap Instance;
	}
}
