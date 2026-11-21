using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9E RID: 3230
	public class INpcSpecialMarkBase
	{
		// Token: 0x060049D7 RID: 18903 RVA: 0x000BA045 File Offset: 0x000B8245
		public static INpcSpecialMarkBase Create(INpcSpecialMarkBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x000BA064 File Offset: 0x000B8264
		public virtual ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x040029D1 RID: 10705
		private INpcSpecialMarkBase Instance;
	}
}
