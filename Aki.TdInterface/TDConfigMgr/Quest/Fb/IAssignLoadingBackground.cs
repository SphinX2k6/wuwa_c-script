using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013CD RID: 5069
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssignLoadingBackground : IOperation
	{
		// Token: 0x060073BC RID: 29628 RVA: 0x0011594D File Offset: 0x00113B4D
		public static IAssignLoadingBackground Create(IAssignLoadingBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssignLoadingBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x060073BD RID: 29629 RVA: 0x0011596C File Offset: 0x00113B6C
		public override EOperation Type
		{
			get
			{
				return (EOperation)this.Instance.Type;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x00115979 File Offset: 0x00113B79
		public virtual string ImagePath
		{
			get
			{
				return this.Instance.ImagePath;
			}
		}

		// Token: 0x04004301 RID: 17153
		private IAssignLoadingBackground Instance;
	}
}
