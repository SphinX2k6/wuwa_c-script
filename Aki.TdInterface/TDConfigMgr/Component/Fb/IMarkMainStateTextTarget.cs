using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C13 RID: 3091
	[NullableContext(2)]
	[Nullable(0)]
	public class IMarkMainStateTextTarget
	{
		// Token: 0x060046E8 RID: 18152 RVA: 0x000B2CF2 File Offset: 0x000B0EF2
		[NullableContext(1)]
		public static IMarkMainStateTextTarget Create(IMarkMainStateTextTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMarkMainStateTextTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x000B2D11 File Offset: 0x000B0F11
		public virtual string TidTargetName
		{
			get
			{
				return this.Instance.TidTargetName;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x000B2D1E File Offset: 0x000B0F1E
		public virtual string EdTidTargetName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002848 RID: 10312
		private IMarkMainStateTextTarget Instance;
	}
}
