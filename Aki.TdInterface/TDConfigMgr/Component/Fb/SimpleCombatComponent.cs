using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9F RID: 3487
	public class SimpleCombatComponent : IComponentBase
	{
		// Token: 0x06004F43 RID: 20291 RVA: 0x000C476A File Offset: 0x000C296A
		[NullableContext(1)]
		public static SimpleCombatComponent Create(ISimpleCombatComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SimpleCombatComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x000C478C File Offset: 0x000C298C
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x000C47C4 File Offset: 0x000C29C4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x000C47DA File Offset: 0x000C29DA
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04002D82 RID: 11650
		private ISimpleCombatComponent Instance;
	}
}
