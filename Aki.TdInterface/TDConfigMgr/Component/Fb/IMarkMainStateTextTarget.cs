using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE3 RID: 3299
	[NullableContext(2)]
	[Nullable(0)]
	public class IMarkMainStateTextTarget
	{
		// Token: 0x06004B4B RID: 19275 RVA: 0x000BCEBE File Offset: 0x000BB0BE
		[NullableContext(0)]
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x000BCEDD File Offset: 0x000BB0DD
		public virtual string TidTargetName
		{
			get
			{
				return this.Instance.TidTargetName;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x000BCEEA File Offset: 0x000BB0EA
		public virtual string EdTidTargetName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002A94 RID: 10900
		private IMarkMainStateTextTarget Instance;
	}
}
