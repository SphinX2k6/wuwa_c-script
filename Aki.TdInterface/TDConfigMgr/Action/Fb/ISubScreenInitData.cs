using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6E RID: 10862
	public class ISubScreenInitData
	{
		// Token: 0x0600EFC9 RID: 61385 RVA: 0x0023265A File Offset: 0x0023085A
		public static ISubScreenInitData Create(ISubScreenInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x0600EFCA RID: 61386 RVA: 0x00232679 File Offset: 0x00230879
		public virtual ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x0600EFCB RID: 61387 RVA: 0x00232686 File Offset: 0x00230886
		public virtual string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x040083DA RID: 33754
		private ISubScreenInitData Instance;
	}
}
