using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024CE RID: 9422
	public class ISetBehaviorPaused
	{
		// Token: 0x0600D276 RID: 53878 RVA: 0x001F3A12 File Offset: 0x001F1C12
		[NullableContext(1)]
		public static ISetBehaviorPaused Create(ISetBehaviorPaused? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBehaviorPaused
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x0600D277 RID: 53879 RVA: 0x001F3A31 File Offset: 0x001F1C31
		public virtual bool IsPaused
		{
			get
			{
				return this.Instance.IsPaused;
			}
		}

		// Token: 0x04007378 RID: 29560
		private ISetBehaviorPaused Instance;
	}
}
