using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1D RID: 2845
	public class InteractiveComponent : IComponentBase
	{
		// Token: 0x06004102 RID: 16642 RVA: 0x000A5EA6 File Offset: 0x000A40A6
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x000A5EC8 File Offset: 0x000A40C8
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

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x000A5F00 File Offset: 0x000A4100
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x000A5F16 File Offset: 0x000A4116
		public virtual string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x000A5F23 File Offset: 0x000A4123
		public virtual string Icon
		{
			get
			{
				return this.Instance.Icon;
			}
		}

		// Token: 0x04002408 RID: 9224
		private IInteractiveComponent Instance;
	}
}
