using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5D RID: 3677
	public class IInhaledPerformance
	{
		// Token: 0x06005326 RID: 21286 RVA: 0x000CD531 File Offset: 0x000CB731
		public static IInhaledPerformance Create(IInhaledPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x000CD550 File Offset: 0x000CB750
		public virtual float InhaledTime
		{
			get
			{
				return this.Instance.InhaledTime;
			}
		}

		// Token: 0x04002F7E RID: 12158
		private IInhaledPerformance Instance;
	}
}
