using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001438 RID: 5176
	public class IDarkTideModule
	{
		// Token: 0x0600752E RID: 29998 RVA: 0x00119899 File Offset: 0x00117A99
		public static IDarkTideModule Create(IDarkTideModule? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideModule
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x001198B8 File Offset: 0x00117AB8
		public virtual EDarkTideModuleType Type
		{
			get
			{
				return (EDarkTideModuleType)this.Instance.Type;
			}
		}

		// Token: 0x040042DE RID: 17118
		private IDarkTideModule Instance;
	}
}
