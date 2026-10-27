using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C3 RID: 10179
	public class IChangeTimerUiConfig
	{
		// Token: 0x0600E268 RID: 57960 RVA: 0x002170A5 File Offset: 0x002152A5
		[NullableContext(1)]
		public static IChangeTimerUiConfig Create(IChangeTimerUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x0600E269 RID: 57961 RVA: 0x002170C4 File Offset: 0x002152C4
		public virtual EChangeTimerUiType UiType
		{
			get
			{
				return (EChangeTimerUiType)this.Instance.UiType;
			}
		}

		// Token: 0x04007D8F RID: 32143
		private IChangeTimerUiConfig Instance;
	}
}
