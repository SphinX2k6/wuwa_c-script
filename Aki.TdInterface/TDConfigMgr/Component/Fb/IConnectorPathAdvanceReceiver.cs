using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D1C RID: 3356
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceReceiver
	{
		// Token: 0x06004C9B RID: 19611 RVA: 0x000BED4A File Offset: 0x000BCF4A
		public static IConnectorPathAdvanceReceiver Create(IConnectorPathAdvanceReceiver? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceReceiver
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x000BED69 File Offset: 0x000BCF69
		public virtual string ConnectedState
		{
			get
			{
				return this.Instance.ConnectedState;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06004C9D RID: 19613 RVA: 0x000BED76 File Offset: 0x000BCF76
		public virtual string DisconnectedState
		{
			get
			{
				return this.Instance.DisconnectedState;
			}
		}

		// Token: 0x04002BD9 RID: 11225
		private IConnectorPathAdvanceReceiver Instance;
	}
}
