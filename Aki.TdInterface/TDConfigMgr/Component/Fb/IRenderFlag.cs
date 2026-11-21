using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF3 RID: 3571
	public class IRenderFlag
	{
		// Token: 0x060050ED RID: 20717 RVA: 0x000C89C9 File Offset: 0x000C6BC9
		public static IRenderFlag Create(IRenderFlag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x000C89E8 File Offset: 0x000C6BE8
		public virtual ERenderFlagType Type
		{
			get
			{
				return (ERenderFlagType)this.Instance.Type;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060050EF RID: 20719 RVA: 0x000C89F5 File Offset: 0x000C6BF5
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x04002E18 RID: 11800
		private IRenderFlag Instance;
	}
}
