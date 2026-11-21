using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6D RID: 10861
	public class ISubScreenModeConfig
	{
		// Token: 0x0600EFC6 RID: 61382 RVA: 0x00232626 File Offset: 0x00230826
		public static ISubScreenModeConfig Create(ISubScreenModeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x00232645 File Offset: 0x00230845
		public virtual ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040083D9 RID: 33753
		private ISubScreenModeConfig Instance;
	}
}
