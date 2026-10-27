using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C21 RID: 3105
	public class CombatComponent : IComponentBase
	{
		// Token: 0x06004729 RID: 18217 RVA: 0x000B3417 File Offset: 0x000B1617
		[NullableContext(1)]
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

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600472A RID: 18218 RVA: 0x000B3438 File Offset: 0x000B1638
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

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x000B3470 File Offset: 0x000B1670
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400286A RID: 10346
		private ICombatComponent Instance;
	}
}
