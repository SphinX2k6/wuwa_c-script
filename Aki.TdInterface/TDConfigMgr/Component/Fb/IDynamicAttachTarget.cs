using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7E RID: 3198
	public class IDynamicAttachTarget : IAttachTarget
	{
		// Token: 0x06004940 RID: 18752 RVA: 0x000B7CA7 File Offset: 0x000B5EA7
		[NullableContext(1)]
		public static IDynamicAttachTarget Create(IDynamicAttachTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicAttachTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06004941 RID: 18753 RVA: 0x000B7CC6 File Offset: 0x000B5EC6
		public override EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x040029CB RID: 10699
		private IDynamicAttachTarget Instance;
	}
}
