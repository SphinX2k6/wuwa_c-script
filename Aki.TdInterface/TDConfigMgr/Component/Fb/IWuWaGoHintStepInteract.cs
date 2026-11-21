using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F0C RID: 3852
	public class IWuWaGoHintStepInteract : IWuWaGoHintStepBase
	{
		// Token: 0x06005699 RID: 22169 RVA: 0x000D472C File Offset: 0x000D292C
		public static IWuWaGoHintStepInteract Create(IWuWaGoHintStepInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoHintStepInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x000D474B File Offset: 0x000D294B
		public override EWuWaGoHintStepType Type
		{
			get
			{
				return (EWuWaGoHintStepType)this.Instance.Type;
			}
		}

		// Token: 0x040031AF RID: 12719
		private IWuWaGoHintStepInteract Instance;
	}
}
