using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E16 RID: 3606
	public class IConnectorPathAdvanceReceiver
	{
		// Token: 0x060051B5 RID: 20917 RVA: 0x000CA41E File Offset: 0x000C861E
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

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x000CA43D File Offset: 0x000C863D
		public virtual string ConnectedState
		{
			get
			{
				return this.Instance.ConnectedState;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x000CA44A File Offset: 0x000C864A
		public virtual string DisconnectedState
		{
			get
			{
				return this.Instance.DisconnectedState;
			}
		}

		// Token: 0x04002E99 RID: 11929
		private IConnectorPathAdvanceReceiver Instance;
	}
}
