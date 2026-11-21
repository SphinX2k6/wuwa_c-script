using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D80 RID: 3456
	public class IStateAlert
	{
		// Token: 0x06004E8A RID: 20106 RVA: 0x000C3C35 File Offset: 0x000C1E35
		public static IStateAlert Create(IStateAlert? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateAlert
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x000C3C54 File Offset: 0x000C1E54
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x000C3C61 File Offset: 0x000C1E61
		public virtual int Alert
		{
			get
			{
				return this.Instance.Alert;
			}
		}

		// Token: 0x04002CAB RID: 11435
		private IStateAlert Instance;
	}
}
