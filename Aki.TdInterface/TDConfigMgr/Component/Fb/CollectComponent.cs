using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF8 RID: 3064
	public class CollectComponent : IComponentBase
	{
		// Token: 0x06004658 RID: 18008 RVA: 0x000B351A File Offset: 0x000B171A
		public static CollectComponent Create(ICollectComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x000B353C File Offset: 0x000B173C
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

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x000B3574 File Offset: 0x000B1774
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x000B358C File Offset: 0x000B178C
		public virtual bool? IsDisableOneClickCollection
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDisableOneClickCollection);
			}
		}

		// Token: 0x04002789 RID: 10121
		private ICollectComponent Instance;
	}
}
