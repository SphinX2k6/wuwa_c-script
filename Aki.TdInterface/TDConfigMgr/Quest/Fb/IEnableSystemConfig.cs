using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001420 RID: 5152
	public class IEnableSystemConfig
	{
		// Token: 0x060074CE RID: 29902 RVA: 0x00118D42 File Offset: 0x00116F42
		public static IEnableSystemConfig Create(IEnableSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x060074CF RID: 29903 RVA: 0x00118D61 File Offset: 0x00116F61
		public virtual EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x0400429E RID: 17054
		private IEnableSystemConfig Instance;
	}
}
