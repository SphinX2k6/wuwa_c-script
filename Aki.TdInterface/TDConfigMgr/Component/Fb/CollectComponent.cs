using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B2A RID: 2858
	public class CollectComponent : IComponentBase
	{
		// Token: 0x060041FF RID: 16895 RVA: 0x000A9456 File Offset: 0x000A7656
		[NullableContext(1)]
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

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x000A9478 File Offset: 0x000A7678
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

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x000A94B0 File Offset: 0x000A76B0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06004202 RID: 16898 RVA: 0x000A94C8 File Offset: 0x000A76C8
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

		// Token: 0x04002541 RID: 9537
		private ICollectComponent Instance;
	}
}
