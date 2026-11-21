using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5A RID: 3418
	public class IAttachTarget
	{
		// Token: 0x06004DD2 RID: 19922 RVA: 0x000C238D File Offset: 0x000C058D
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

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x000C23AC File Offset: 0x000C05AC
		public virtual EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x04002C31 RID: 11313
		private IAttachTarget Instance;
	}
}
