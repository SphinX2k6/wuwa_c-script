using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C01 RID: 3073
	public class DungeonEntryComponent : IComponentBase
	{
		// Token: 0x06004695 RID: 18069 RVA: 0x000B240F File Offset: 0x000B060F
		[NullableContext(1)]
		public static DungeonEntryComponent Create(IDungeonEntryComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DungeonEntryComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x000B2430 File Offset: 0x000B0630
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

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06004697 RID: 18071 RVA: 0x000B2468 File Offset: 0x000B0668
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002826 RID: 10278
		private IDungeonEntryComponent Instance;
	}
}
