using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D19 RID: 3353
	public class IConnectorPathAdvanceVisual
	{
		// Token: 0x06004C87 RID: 19591 RVA: 0x000BEA1C File Offset: 0x000BCC1C
		[NullableContext(1)]
		public static IConnectorPathAdvanceVisual Create(IConnectorPathAdvanceVisual? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x000BEA3B File Offset: 0x000BCC3B
		public virtual EConnectorPathAdvanceVisualType Type
		{
			get
			{
				return (EConnectorPathAdvanceVisualType)this.Instance.Type;
			}
		}

		// Token: 0x04002BCE RID: 11214
		private IConnectorPathAdvanceVisual Instance;
	}
}
