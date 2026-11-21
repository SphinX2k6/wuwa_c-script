using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD1 RID: 3281
	public class DungeonEntryComponent : IComponentBase
	{
		// Token: 0x06004AF8 RID: 19192 RVA: 0x000BC5DB File Offset: 0x000BA7DB
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

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x000BC5FC File Offset: 0x000BA7FC
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

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x000BC634 File Offset: 0x000BA834
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002A72 RID: 10866
		private IDungeonEntryComponent Instance;
	}
}
