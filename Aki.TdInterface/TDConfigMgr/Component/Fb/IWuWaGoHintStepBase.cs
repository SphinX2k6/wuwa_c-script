using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0E RID: 3598
	public class IWuWaGoHintStepBase
	{
		// Token: 0x0600516B RID: 20843 RVA: 0x000C8DC8 File Offset: 0x000C6FC8
		[NullableContext(1)]
		public static IWuWaGoHintStepBase Create(IWuWaGoHintStepBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoHintStepBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x000C8DE7 File Offset: 0x000C6FE7
		public virtual EWuWaGoHintStepType Type
		{
			get
			{
				return (EWuWaGoHintStepType)this.Instance.Type;
			}
		}

		// Token: 0x04002EE3 RID: 12003
		private IWuWaGoHintStepBase Instance;
	}
}
