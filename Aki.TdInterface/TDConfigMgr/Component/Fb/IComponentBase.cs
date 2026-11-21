using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1A RID: 2842
	public class IComponentBase
	{
		// Token: 0x060040F6 RID: 16630 RVA: 0x000A5D21 File Offset: 0x000A3F21
		public static IComponentBase Create(IComponentBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IComponentBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x000A5D40 File Offset: 0x000A3F40
		public virtual bool? Disabled
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060040F8 RID: 16632 RVA: 0x000A5D78 File Offset: 0x000A3F78
		public virtual bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002403 RID: 9219
		private IComponentBase Instance;
	}
}
