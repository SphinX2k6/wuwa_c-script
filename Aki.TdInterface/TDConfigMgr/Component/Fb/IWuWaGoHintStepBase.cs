using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F0A RID: 3850
	public class IWuWaGoHintStepBase
	{
		// Token: 0x06005692 RID: 22162 RVA: 0x000D4690 File Offset: 0x000D2890
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

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06005693 RID: 22163 RVA: 0x000D46AF File Offset: 0x000D28AF
		public virtual EWuWaGoHintStepType Type
		{
			get
			{
				return (EWuWaGoHintStepType)this.Instance.Type;
			}
		}

		// Token: 0x040031AB RID: 12715
		private IWuWaGoHintStepBase Instance;
	}
}
