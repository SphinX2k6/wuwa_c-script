using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E10 RID: 3600
	public class IWuWaGoHintStepInteract : IWuWaGoHintStepBase
	{
		// Token: 0x06005172 RID: 20850 RVA: 0x000C8E64 File Offset: 0x000C7064
		[NullableContext(1)]
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x000C8E83 File Offset: 0x000C7083
		public override EWuWaGoHintStepType Type
		{
			get
			{
				return (EWuWaGoHintStepType)this.Instance.Type;
			}
		}

		// Token: 0x04002EE7 RID: 12007
		private IWuWaGoHintStepInteract Instance;
	}
}
