using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200150F RID: 5391
	public class ITakePhoto2ModeBase
	{
		// Token: 0x06007A0A RID: 31242 RVA: 0x0012362C File Offset: 0x0012182C
		public static ITakePhoto2ModeBase Create(ITakePhoto2ModeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2ModeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x0012364B File Offset: 0x0012184B
		public virtual ETakePhoto2Mode Type
		{
			get
			{
				return (ETakePhoto2Mode)this.Instance.Type;
			}
		}

		// Token: 0x04004643 RID: 17987
		private ITakePhoto2ModeBase Instance;
	}
}
