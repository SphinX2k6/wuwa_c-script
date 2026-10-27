using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B1D RID: 2845
	public class IRoleMotionInteractType
	{
		// Token: 0x060041B9 RID: 16825 RVA: 0x000A8A46 File Offset: 0x000A6C46
		[NullableContext(1)]
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

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x000A8A65 File Offset: 0x000A6C65
		public virtual ERoleMotionInteractType Type
		{
			get
			{
				return (ERoleMotionInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04002510 RID: 9488
		private IRoleMotionInteractType Instance;
	}
}
