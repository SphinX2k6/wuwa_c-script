using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF5 RID: 3317
	public class EntityListComponent : IComponentBase
	{
		// Token: 0x06004B9C RID: 19356 RVA: 0x000BD7C6 File Offset: 0x000BB9C6
		public static EntityListComponent Create(IEntityListComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityListComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x000BD7E8 File Offset: 0x000BB9E8
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

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06004B9E RID: 19358 RVA: 0x000BD820 File Offset: 0x000BBA20
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002ABE RID: 10942
		private IEntityListComponent Instance;
	}
}
