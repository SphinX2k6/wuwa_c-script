using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A54 RID: 2644
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractiveComponent : IComponentBase
	{
		// Token: 0x06003CE2 RID: 15586 RVA: 0x0009CA2E File Offset: 0x0009AC2E
		public static InteractiveComponent Create(IInteractiveComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InteractiveComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x0009CA50 File Offset: 0x0009AC50
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

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x0009CA88 File Offset: 0x0009AC88
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x0009CA9E File Offset: 0x0009AC9E
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x0009CAAB File Offset: 0x0009ACAB
		public virtual string Icon
		{
			get
			{
				return this.Instance.Icon;
			}
		}

		// Token: 0x040021F1 RID: 8689
		private IInteractiveComponent Instance;
	}
}
