using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C22 RID: 3106
	public class EntityListComponent : IComponentBase
	{
		// Token: 0x0600472D RID: 18221 RVA: 0x000B348E File Offset: 0x000B168E
		[NullableContext(1)]
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

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x000B34B0 File Offset: 0x000B16B0
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

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x000B34E8 File Offset: 0x000B16E8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400286B RID: 10347
		private IEntityListComponent Instance;
	}
}
