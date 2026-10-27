using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C7B RID: 3195
	public class IAttachTarget
	{
		// Token: 0x06004933 RID: 18739 RVA: 0x000B7B89 File Offset: 0x000B5D89
		[NullableContext(1)]
		public static IAttachTarget Create(IAttachTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004934 RID: 18740 RVA: 0x000B7BA8 File Offset: 0x000B5DA8
		public virtual EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x040029C4 RID: 10692
		private IAttachTarget Instance;
	}
}
