using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF4 RID: 3316
	public class CombatComponent : IComponentBase
	{
		// Token: 0x06004B98 RID: 19352 RVA: 0x000BD74E File Offset: 0x000BB94E
		public static CombatComponent Create(ICombatComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CombatComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x000BD770 File Offset: 0x000BB970
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06004B9A RID: 19354 RVA: 0x000BD7A8 File Offset: 0x000BB9A8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002ABD RID: 10941
		private ICombatComponent Instance;
	}
}
