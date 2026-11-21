using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BEB RID: 3051
	public class IRoleMotionInteractType
	{
		// Token: 0x06004610 RID: 17936 RVA: 0x000B2AA6 File Offset: 0x000B0CA6
		public static IRoleMotionInteractType Create(IRoleMotionInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleMotionInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x000B2AC5 File Offset: 0x000B0CC5
		public virtual ERoleMotionInteractType Type
		{
			get
			{
				return (ERoleMotionInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002756 RID: 10070
		private IRoleMotionInteractType Instance;
	}
}
